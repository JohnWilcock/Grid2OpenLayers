'
' Created by SharpDevelop.
' User: John
' Date: 03/02/2013
' Time: 16:03
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Reflection



Public Partial Class Form1
	'initialise standard vars	
	Dim col1 As Color = Color.FromArgb(255,0,0)
	Dim col2 As Color = Color.FromArgb(0,0,255)
	Dim col3 As Color = Color.FromArgb(0,255,0)	
	Dim gridcount As Integer = 1
	Dim folderP As String
	Dim fpath0 As String
	
	Dim varblockstring As String = ""
	Dim updateblockstring As String = ""
	Dim ELEVArrayLoader As String = "[ELEVarray"
	Dim updateLoader As String = ""
	Dim tablebuilder As String = ""
	Dim tableheaders As String = ""
	Dim fullarray As String = "fullArray[i] =  new Array(); fullArray[i][0] = i; fullArray[i][0] = ELEVarray[i][0].toFixed(3); fullArray[i][1] = ELEVarray[i][1]; fullArray[0][0] = 'Distance'; "
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()

		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
    Sub Button1Click(sender As Object, e As EventArgs) Handles button1.Click
        'force reset variables
        resetVARS()

        'check file is present
        If File.Exists(textBox1.Text) Then
        Else
            MsgBox("please choose valid file")
            Exit Sub
        End If

        Dim fPath As String
        fPath = textBox1.Text
        fpath0 = fPath
        folderP = Path.GetDirectoryName(fPath)

        'set first array loader string so it includes a name for the graph key
        ELEVArrayLoader = "[{label:'" & Path.GetFileNameWithoutExtension(fPath) & "', data: ELEVarray}"
        'set first table header using grid file name
        tableheaders = "<th>" & Path.GetFileNameWithoutExtension(fPath) & "</th>"
        'and set the name 
        fullarray = fullarray & "fullArray[0][1] = '" & Path.GetFileNameWithoutExtension(textBox1.Text) & "';"

        'create folder for output js files
        'TODO : this
        System.IO.Directory.CreateDirectory(folderP & "\" & Path.GetFileNameWithoutExtension(fPath))

        Dim asc_len As Integer = File.ReadAllLines(fPath).Length
        Dim ascfile As New System.IO.StreamReader(fPath)


        Dim asc_values(10000) As String
        For j = 0 To asc_len
            asc_values(j) = ascfile.ReadLine
        Next
        ascfile.Close()

        'get top columns as they are metadata
        Dim Swidth As Integer = GetNumberFromStringUsingSB(asc_values(0))
        Dim Sheight As Integer = GetNumberFromStringUsingSB(asc_values(1))
        Dim xllcorner As Double = GetNumberFromStringUsingSB(asc_values(2))
        Dim yllcorner As Double = GetNumberFromStringUsingSB(asc_values(3))
        Dim cellsize As Double = GetNumberFromStringUsingSB(asc_values(4))
        'no data value is not always included (i.e. in most grid file provided by Edina & digimap) so we need to check for it.
        Dim NODATA_value As Double
        If asc_values(5).Substring(0, 5) = "NODATA" Then
            NODATA_value = GetNumberFromStringUsingSB(asc_values(5))
        Else
            NODATA_value = -9999
        End If
        'this is the cell size of the output JS grid
        Dim outputgridsize As Integer = numericUpDown1.Value

        'create the JS grid files 
        '(this creates the .js files in rXXcXX format where r is row number and c is column number ()
        'this should probaly be changed to mirror the style of a TMS .... or maybe not, this system has advantages (clearer when debuging)

        'find how many grid imcrements are required 
        Dim x_no As Integer = System.Math.Floor(Swidth / outputgridsize)
        Dim y_no As Integer = System.Math.Floor(Sheight / outputgridsize)

        'create blank arrays to find the min/max values
        Dim minA(Sheight) As Double
        Dim maxA(Sheight) As Double
        Dim minAtemp As Double = 100000
        Dim maxAtemp As Double = 0

        'starting at top left (google style! ... major faux pa !)
        Dim total_row_count As Long = 0 'TODO: was 1
        Dim grids_completed As Long = 0
        Dim total_grids As Long = (y_no + 1) * (x_no + 1)
        'for each row
        For y = 1 To y_no + 1

            For x = 1 To x_no + 1
                Dim objWriter As New System.IO.StreamWriter(folderP & "\" & Path.GetFileNameWithoutExtension(fPath) & "\" & "g1r" & y & "c" & x & ".js", False)
                'cycle through the rows and write to the JS file
                For row = 1 To outputgridsize
                    'check if row is valid (e.g. for patial grid squares)
                    If total_row_count + row <= Sheight Then
                        Dim row_value As String = "var g1r" & y & "c" & x & "l" & (total_row_count + row) & "= ["
                        'cycle throught the columns and create a string from only those columns needed.
                        Dim temp() As String
                        If (row + ((y - 1) * outputgridsize)) < Sheight Then '100 + is a problem - old: If  (100 + ((x-1) * outputgridsize)) < Swidth then
                            temp = asc_values(row + 5 + total_row_count).Split(" "c)
                            For Each value1 In temp
                                If value1 <> "" And value1 <> NODATA_value.ToString And value1 <> "-9999" Then
                                    'find min/max for colour calcs later
                                    minAtemp = Math.Min(minAtemp, CDbl(value1))
                                    maxAtemp = Math.Max(maxAtemp, CDbl(value1))
                                End If
                            Next
                        End If

                        For col = 1 To outputgridsize
                            If (col + ((x - 1) * outputgridsize)) < Swidth Then
                                row_value = row_value & ", " & (temp(col + ((x - 1) * outputgridsize))) 'had -1 probaly just an error. have removed.
                            Else
                                row_value = row_value & ", " & NODATA_value
                            End If
                        Next
                        row_value = row_value & "];"
                        row_value = row_value.Replace("[,", "[") 'replace first comma
                        objWriter.WriteLine(row_value)
                    End If
                Next
                objWriter.WriteLine("CurrentLoadTotal = CurrentLoadTotal - 1; allLoaded();")    'replaces onload events
                objWriter.Close() 'close the file

                'counter for progress bar
                grids_completed = grids_completed + 1
                progressBar1.Value = (grids_completed / total_grids) * 100
            Next


            total_row_count = total_row_count + outputgridsize
        Next


        'create image
        Dim image1 As New Bitmap(Swidth, Sheight)
        Dim theCol As Color

        For i = 1 To Sheight - 2
            Dim row_values As String = asc_values(i + 6)
            Dim row_values2 = row_values.Split(" "c)
            For j = 1 To Swidth - 1
                theCol = colorCalc(Double.Parse(row_values2(j)), minAtemp, maxAtemp, NODATA_value)
                image1.SetPixel(j, i, theCol)
            Next

        Next

        image1.Save(folderP & "\" & Path.GetFileNameWithoutExtension(fPath) & "\" & Path.GetFileNameWithoutExtension(fPath) & ".jpg", ImageFormat.Jpeg)
        'tileup(folderP & "\" & Path.GetFileNameWithoutExtension(fPath) & "\" & Path.GetFileNameWithoutExtension(fPath) & ".jpg")

        'background image
        Dim backgroundIMG As String = ""
        backgroundIMG = BGimg(textBox4.Text, folderP & "\" & Path.GetFileNameWithoutExtension(fPath), folderP)


        'check for other grids and cycle through them if present
        Dim num_of_grids As Integer = listBox1.Items.Count
        For d = 0 To listBox1.Items.Count - 1
            othergrids(listBox1.Items.Item(d))
        Next


        'table string .... if required
        Dim Table_string As String = ""
        If checkBox1.Checked Then Table_string = "<li><a href='#' rel='tabs2'>Table</a></li>"

        'and options string .... if required
        Dim options_string As String = ""
        Dim samples_string As String = ""
        If checkBox2.Checked Then
            options_string = "<li><a href='#' rel='tabs4'>Options</a></li>"

            'add selected sample sizes	
            samples_string = "Select the number of samples to be taken along each cross section<br><br><select id='samples' onchange='changesamples(this.value)'>"
            If listBox2.Items.Count = 0 Then listBox2.Items.Add(numericUpDown2.Value)

            'make sure default sample size is selected
            Dim selected As String = ""
            Dim found_selected As Boolean = False
            'loop through chossen sample sizes added them to avalible drop down choices
            For g = 0 To listBox2.Items.Count - 1
                If listBox2.Items(g) = numericUpDown2.Value Then
                    selected = "selected"
                    found_selected = True
                Else
                    selected = ""
                End If

                samples_string = samples_string & "<option value='" & listBox2.Items(g) & "' " & selected & ">" & listBox2.Items(g) & "</option>"
            Next
            'add default value if it was not present in the list and set it to selected by default
            If found_selected = False Then samples_string = samples_string & "<option value='" & numericUpDown2.Value & "' selected >" & numericUpDown2.Value & "</option>"
            samples_string = samples_string & "</select>"
        End If

        'if plot points is selected
        Dim plot_p As String = ""
        Dim plot_att As String = ""
        If checkBox3.Checked Then
            options_string = "<li><a href='#' rel='tabs4'>Options</a></li>"

            'add plot points button		
            plot_p = "<br><button class='cssbutton' onclick='plotpoints()'>Plot sample points on map</button> &nbsp &nbsp <button class='cssbutton' onclick='clearpoints()'>Clear points</button>"

            'build plot points attributes
            plot_att = ", {sample:r, chainage:ELEVarray[r][0], ele:ELEVarray[r][1]"
            For g = 1 To num_of_grids
                plot_att = plot_att & ", ele" & (g + 1) & ":ELEVarray" & (g + 1) & "[r][1]"
            Next
            plot_att = plot_att & "}"
        End If

        'create html file and set the variables in it / file paths

        Dim rm As System.Resources.ResourceManager
        rm = New System.Resources.ResourceManager("Grid2OL.Resource1", Assembly.GetExecutingAssembly())
        Dim html As String = rm.GetObject("html2")




        html = html.Replace("VBVAR_minX", xllcorner)
        html = html.Replace("VBVAR_maxX", (xllcorner + (cellsize * Swidth)))
        html = html.Replace("VBVAR_minY", yllcorner)
        html = html.Replace("VBVAR_maxY", (yllcorner + (cellsize * Sheight)))

        html = html.Replace("VBVAR_bitmap", (Path.GetFileNameWithoutExtension(fPath) & ".jpg"))
        html = html.Replace("VBVAR_bmpX", (Swidth / 5)) 'altered to allow zoom out
        html = html.Replace("VBVAR_bmpY", (Sheight / 5)) 'altered to allow zoom out

        html = html.Replace("VBVAR_cellsize", cellsize)
        html = html.Replace("VBVAR_gridsize", outputgridsize)
        html = html.Replace("VBVAR_intervals", numericUpDown2.Value)
        html = html.Replace("VBVAR_nrows", Sheight)

        html = html.Replace("xaxislabel1", textBox2.Text)
        html = html.Replace("yaxislabel1", textBox3.Text)

        html = html.Replace("VBVAR_bgImage", backgroundIMG)
        html = html.Replace("VBVAR_Table", Table_string)
        html = html.Replace("VBVAR_OPTIONS", options_string)
        html = html.Replace("VBVAR_SAMPLESSTRING", samples_string)
        html = html.Replace("VBVAR_PLOT", plot_p)

        html = html.Replace("VBVAR_PATH", (Path.GetFileNameWithoutExtension(fPath) & "/"))

        'add extra js for any other secondary grid
        html = html.Replace("VBVAR_GRIDS", gridcount)
        html = html.Replace("VBVARBLOCK", varblockstring)
        html = html.Replace("VBVAR_OTHERGRIDS", updateblockstring)
        html = html.Replace("VB[ELEVarray]", (ELEVArrayLoader & "]"))
        html = html.Replace("VBVAR_UPDATELOADER", updateLoader)
        html = html.Replace("VBVAR_TABLEBUILDER", tablebuilder)
        html = html.Replace("VBVAR_TABLEHEAD", tableheaders)
        html = html.Replace("VBVAR_FULLARRAY", fullarray)


        'check for simple or complex Xsecs and apply correct code block from resourses
        If radioButton1.Checked Then
            html = html.Replace("VBVAR_COMPLEX", rm.GetObject("Xcomplex"))
            html = html.Replace("VBVAR_GETXY", rm.GetObject("XcomplexXY"))
            html = html.Replace("VBVAR_SCXSEC", rm.GetObject("CompXsec"))

        Else
            html = html.Replace("VBVAR_COMPLEX", rm.GetObject("Xsimple"))
            html = html.Replace("VBVAR_GETXY", rm.GetObject("XsimpleXY"))
            html = html.Replace("VBVAR_SCXSEC", rm.GetObject("SimpXsec"))
        End If
        html = html.Replace("VBGRIDNO", "")
        html = html.Replace("VBVAR_P_ATTRIBUTES", plot_att)


        'check if the file exists
        checkEXISTS(folderP & "\" & Path.GetFileNameWithoutExtension(fPath) & ".html")

        'write the file
        Dim htmlWriter As New System.IO.StreamWriter(folderP & "\" & Path.GetFileNameWithoutExtension(fPath) & ".html", False)
        htmlWriter.Write(html)
        htmlWriter.Close()

        'write other JS files (OpenLayers, Jquery, EXcanvas, Flot)
        Dim OL As Byte() = rm.GetObject("OpenLayers")
        File.WriteAllBytes(folderP & "\" & Path.GetFileNameWithoutExtension(fPath) & "\OpenLayers.js", OL)

        Dim EXcanvas As Byte() = rm.GetObject("excanvas.min")
        File.WriteAllBytes(folderP & "\" & Path.GetFileNameWithoutExtension(fPath) & "\excanvas.min.js", EXcanvas)

        Dim flot As Byte() = rm.GetObject("jquery.flot")
        File.WriteAllBytes(folderP & "\" & Path.GetFileNameWithoutExtension(fPath) & "\jquery.flot.js", flot)

        Dim flotaxis As Byte() = rm.GetObject("jquery.flot.axislabels")
        File.WriteAllBytes(folderP & "\" & Path.GetFileNameWithoutExtension(fPath) & "\jquery.flot.axislabels.js", flotaxis)

        Dim jquery As Byte() = rm.GetObject("jquery-1.6.2")
        File.WriteAllBytes(folderP & "\" & Path.GetFileNameWithoutExtension(fPath) & "\jquery-1.6.2.js", jquery)


        Dim linktofile As String = folderP & "\" & Path.GetFileNameWithoutExtension(fPath) & ".html"
        Dim finished1 As New Finished
        finished1.fileloc = linktofile
        finished1.ShowDialog()



    End Sub
	
	
	
	'Functions and helpers *********************************************************************
	
	Sub resetVARS ()
	'initialise standard vars	
	col1 = Color.FromArgb(255,0,0)
	col2  = Color.FromArgb(0,0,255)
	col3 = Color.FromArgb(0,255,0)	
	gridcount  = 1
	
	varblockstring  = ""
	updateblockstring  = ""
	ELEVArrayLoader  = "[ELEVarray"
	updateLoader  = ""
	tablebuilder  = ""
	tableheaders  = ""
	fullarray  = "fullArray[i] =  new Array(); fullArray[i][0] = i; fullArray[i][0] = ELEVarray[i][0].toFixed(3); fullArray[i][1] = ELEVarray[i][1]; fullArray[0][0] = 'Distance'; "

	End Sub
	
	Function GetNumberFromStringUsingSB(ByVal theString As String) As double
   	 Dim sb As New System.Text.StringBuilder(theString.Length)
   	 	For Each ch As Char In theString
   	 		If Char.IsDigit(ch) Then sb.Append(ch)
   	 		If ch.ToString = Chr(46) Then sb.Append(ch)
   	 	Next
    Return double.Parse(CDbl(sb.ToString))
	End Function
	
	
	Function BGimg(ByVal fpath As String, byval saveName As string, byval folder1 As string) As String
		Dim bgMAP As String = ""
		Dim bgpath As String = Path.GetFileNameWithoutExtension(saveName & ".html") & "_BGmap." & Microsoft.VisualBasic.Right(fpath,3)
		
		'check for valid file
		If File.Exists(textBox4.Text) Then
		Else
			Return bgMAP
		End If
		
		'put file in var to check its dims
		Dim theIMG As Bitmap = Bitmap.FromFile(fpath)
		
		'save file to same location as others
		Dim saveLOC As String = folder1 & "\" & Path.GetFileNameWithoutExtension(saveName) & "\" & bgpath
		theIMG.Save(saveLOC)
		
		bgMAP = "var bgmap = new OpenLayers.Layer.Image(" & _
                "'Background Map'," & _
                Chr(34) & Path.GetFileNameWithoutExtension(saveName) & "/" & bgpath & Chr(34) & "," & _
                "new OpenLayers.Bounds(minX, minY, maxX, maxY)," & _
                "new OpenLayers.Size(" & theIMG.Width & ", " & theIMG.Height & ")," & _
                "{numZoomLevels: 10, isBaseLayer: false, alwaysInRange: true}" & _
            ");" & _
			"bgmap.setOpacity(0.5);" & _
			"map.addLayer(bgmap);"
		
		Return bgMAP
	End Function
	
	
	Function colorCalc(ByVal theVal As Double, byval minA As Double, byval maxA As double, byval NODATA_value As double) As Color
		'corretion factors are static and can be moved out of function
		Dim midpoint As Double = minA + ((maxA - minA)/2)
		Dim range As Double = maxA - minA
		
		Dim Amax As Double = maxA
		Dim Amin As Double = minA + (range/2)
		Dim midpointA As Double = Amin + ((Amax - Amin)/2)
		Dim rangeA As Double = Amax - Amin
				
		Dim Bmax As Double = maxA - (range/2)
		Dim Bmin As Double = minA 
		Dim midpointB As Double = Bmin + ((Bmax - Bmin)/2)
		Dim rangeB As Double = Bmax - Bmin
						
		Dim REDcorrectionS1 As Double = (CDbl(CDbl(col1.R) - CDbl(col3.R)))/(rangeA)
		Dim GREENcorrectionS1 As Double = (CDbl(CDbl(col1.G) - CDbl(col3.G)))/(rangeA)
		Dim BLUEcorrectionS1 As Double = (CDbl(CDbl(col1.B) - CDbl(col3.B)))/(rangeA)
		
		Dim REDcorrectionS2 As Double = (CDbl(CDbl(col3.R) - CDbl(col2.R)))/(rangeB)
		Dim GREENcorrectionS2 As Double = (CDbl(CDbl(col3.G) - CDbl(col2.G)))/(rangeB)
		Dim BLUEcorrectionS2 As Double = (CDbl(CDbl(col3.B) - CDbl(col2.B)))/(rangeB)


		Dim red As Integer
		Dim green As Integer
		Dim blue As Integer
		
		if theVal <> 0 And theVal <> NODATA_value And theVal <> -9999 then	'check for null data
			'if in stage 1 (highest to midpoint)
		If theVal > midpoint then
			red = CInt(((rangeA - (Amax - theVal)))*REDcorrectionS1) 
				If red < 0 Then red = red + 255
				If red < 0 Then red = 0
				If red > 255 Then red = 255
			blue = CInt(((rangeA - (Amax - theVal)))*BLUEcorrectionS1):
				If blue < 0 Then blue = blue + 255
				If blue > 255 Then blue = 255
				If blue < 0 Then blue = 0
			green = CInt(((rangeA - (Amax - theVal)))*GREENcorrectionS1)
				If green < 0 Then green = green + 255
				If green > 255 Then green = 255
				If green < 0 Then green = 0
		Else
			red = CInt(((rangeB - (Bmax - theVal)))*REDcorrectionS2) 
				If red < 0 Then red = red + 255
				If red < 0 Then red = 0
				If red > 255 Then red = 255
			blue = CInt(((rangeB - (Bmax - theVal)))*BLUEcorrectionS2):
				If blue < 0 Then blue = blue + 255
				If blue > 255 Then blue = 255
				If blue < 0 Then blue = 0
			green = CInt(((rangeB - (Bmax - theVal)))*GREENcorrectionS2)
				If green < 0 Then green = green + 255
				If green > 255 Then green = 255
				If green < 0 Then green = 0

		End If
		
		Else ' if null
			red = 255
			blue = 255
			green = 255	
		end if	
		
		Return color.FromArgb(red,green,blue)
	End Function
	
	
	Function checkEXISTS(filepath)
		If File.Exists(filepath) Then
			File.Delete(filepath)			
		End If
		
	End Function
	
	
	
	'form buttons *********************************************************************
	
	
	'file browser
    Sub Button2Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim OFD1 As New OpenFileDialog
        OFD1.Filter = "ASCII files (*.asc)|*.asc|ASCII Text Files (*.txt)|*.txt"
        OFD1.ShowDialog()
        textBox1.Text = OFD1.FileName
    End Sub
	
	
	'show and hide advanced options
    Sub Button4Click(sender As Object, e As EventArgs) Handles button4.Click
        If Me.Height > 140 Then
            Me.Height = 140
            tabControl1.Height = 140
        Else
            Me.Height = 300
        End If
    End Sub
	
	
	'colour picker 1
    Sub Button5Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim colpick As New ColorDialog
        colpick.ShowDialog()
        col1 = colpick.Color
        button5.BackColor = col1
    End Sub
	
	'colour picker 2
    Sub Button6Click(sender As Object, e As EventArgs) Handles button6.Click
        Dim colpick As New ColorDialog
        colpick.ShowDialog()
        col2 = colpick.Color
        button6.BackColor = col2
    End Sub
	
	'colour picker middle
    Sub Button8Click(sender As Object, e As EventArgs) Handles button8.Click
        Dim colpick As New ColorDialog
        colpick.ShowDialog()
        col3 = colpick.Color
        button8.BackColor = col3
    End Sub
	
	'image preview
    Sub Button7Click(sender As Object, e As EventArgs) Handles button7.Click

        'check file is present
        If File.Exists(textBox1.Text) Then
        Else
            MsgBox("please choose valid file")
            Exit Sub
        End If

        Dim fPath As String
        fPath = textBox1.Text
        Dim folderP As String = Path.GetDirectoryName(fPath)

        Dim asc_len As Integer = File.ReadAllLines(fPath).Length
        Dim ascfile As New System.IO.StreamReader(fPath)


        Dim asc_values(10000) As String
        For j = 0 To asc_len
            asc_values(j) = ascfile.ReadLine
        Next
        ascfile.Close()

        'get top columns as they are metadata
        Dim Swidth As Integer = GetNumberFromStringUsingSB(asc_values(0))
        Dim Sheight As Integer = GetNumberFromStringUsingSB(asc_values(1))
        Dim xllcorner As Double = GetNumberFromStringUsingSB(asc_values(2))
        Dim yllcorner As Double = GetNumberFromStringUsingSB(asc_values(3))
        Dim cellsize As Integer = GetNumberFromStringUsingSB(asc_values(4))
        Dim NODATA_value As Double
        If asc_values(5).Substring(0, 5) = "NODATA" Then
            NODATA_value = GetNumberFromStringUsingSB(asc_values(5))
        Else
            NODATA_value = -9999
        End If

        'get min/max
        Dim count As Integer = 1
        Dim temp() As String
        Dim minAtemp As Double = 1000000
        Dim maxAtemp As Double = 0
        For value1 = 0 To Sheight - 1
            If count > 6 Then
                temp = asc_values(value1).Split(" "c)
                For Each value2 In temp
                    If value2 <> "" And value2 <> NODATA_value.ToString And value2 <> "-9999" Then
                        minAtemp = Math.Min(minAtemp, CDbl(value2))
                        maxAtemp = Math.Max(maxAtemp, CDbl(value2))
                    End If
                Next
            End If
            count = count + 1
        Next


        'create image
        Dim image1 As New Bitmap(Swidth, Sheight)
        Dim theCol As Color

        For i = 1 To Sheight - 2
            Dim row_values As String = asc_values(i + 6)
            Dim row_values2 = row_values.Split(" "c)
            For j = 1 To Swidth - 1
                theCol = colorCalc(Double.Parse(row_values2(j)), minAtemp, maxAtemp, NODATA_value)
                image1.SetPixel(j, i, theCol)
            Next
            progressBar2.Value = ((i / Sheight) * 100)

        Next

        pictureBox1.Image = image1

    End Sub
	
	'basic help on what an ASCII file is 
    Sub Button3Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim about1 As New About
        about1.ShowDialog()
        'MsgBox("ArcMap > ArcToolBox > Conversion > Raster to ASCII" & vbNewLine & "Mapinfo > Vertical Mapper Grid Manager > Tools (bottom right corner) > Export Grid > ASCII Grid export" & vbNewLine & "QGIS(1.8 +) > Raster > Conversion > translate > output as ESRI Arc/Info ASCII *.asc " & vbnewline & vbnewline & "J.Wilcock 2013")
    End Sub
	
	'background image picker
    Sub Button9Click(sender As Object, e As EventArgs) Handles button9.Click
        Dim OFD1 As New OpenFileDialog
        OFD1.Filter = "Jpeg files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif"
        OFD1.ShowDialog()
        textBox4.Text = OFD1.FileName
    End Sub
	
	
	
	
	
	
	
	
	
	Sub othergrids(ByVal fPath As String)
		gridcount = gridcount + 1
		
		Dim asc_len As Integer = File.ReadAllLines(fPath).Length
		Dim ascfile As New System.IO.StreamReader(fPath)
				
		Dim asc_values(10000) As String
        For j = 0 To asc_len
        asc_values(j) = ascfile.ReadLine
        Next
        ascfile.Close()
        
        'get top columns as they are metadata
        Dim Swidth As integer = GetNumberFromStringUsingSB(asc_values(0))
        Dim Sheight As integer =  GetNumberFromStringUsingSB(asc_values(1))		
		Dim xllcorner As double = GetNumberFromStringUsingSB(asc_values(2))
		Dim yllcorner As double = GetNumberFromStringUsingSB(asc_values(3))
		Dim cellsize As double = GetNumberFromStringUsingSB(asc_values(4))		
		Dim NODATA_value As double = GetNumberFromStringUsingSB(asc_values(5))
		
		'this is the cell size of the output JS grid
		Dim outputgridsize As Integer = numericUpDown1.value		
		
		'find how many grid imcrements are required 
		Dim x_no As Integer = System.Math.Floor(Swidth/outputgridsize) 
		Dim y_no As Integer = System.Math.Floor(Sheight/outputgridsize) 
		
		'create blank arrays to find the min/max values
		Dim minA(Sheight) As Double
		Dim maxA(Sheight) As Double
		Dim minAtemp As Double = 0
		Dim maxAtemp As double = 0
		
		'starting at top left (google style! ... major faux pa)
		Dim total_row_count As Long = 0 'TODO: was 1
		Dim grids_completed As Long = 0
		Dim total_grids  As Long = (y_no + 1) * (x_no + 1)
		'for each row
		For y = 1 To y_no + 1
					
			For x = 1 To x_no + 1
				Dim objWriter As New System.IO.StreamWriter(folderP & "\" & Path.GetFileNameWithoutExtension(fPath0) & "\" & "g" & gridcount & "r" & y & "c" & x & ".js", false)
				'cycle through the rows and write to the JS file
				For row = 1 To outputgridsize
					'check if row is valid (e.g. for patial grid squares)
					If total_row_count + row < Sheight Then											
					Dim row_value As String = "var g" & gridcount & "r" & y & "c" & x & "l" & (total_row_count + row) & "= ["
					'cycle throught the columns and create a string from only those columns needed.
					Dim temp() As String
					If  (100 + ((x-1) * outputgridsize)) < Swidth then
						temp = asc_values(row + 5 + total_row_count).Split(" "c)
					End If
					
					For col = 1 To outputgridsize
						If  (col + ((x-1) * outputgridsize)) < Swidth then
							row_value = row_value & ", " & (temp(col + ((x-1) * outputgridsize))) 'had -1 probaly just an error. have removed.
						Else
							row_value = row_value & ", " & NODATA_value
						End if
					Next
					row_value = row_value & "];"
					row_value = row_value.Replace("[,","[") 'replace first comma
					objWriter.WriteLine(row_value)	
					End If
				Next
				objWriter.WriteLine("CurrentLoadTotal" & gridcount & " = CurrentLoadTotal" & gridcount & " - 1; allLoaded" & gridcount & "();")	'replaces onload events
				objWriter.Close() 'close the file
					
			'counter for progress bar
			grids_completed = grids_completed + 1
			progressBar1.Value = (grids_completed / total_grids) * 100
			Next

			
		total_row_count = total_row_count + outputgridsize	
		Next
		
		
		
		'create javascript and set the variables in it / file paths
			
		 Dim rm As System.Resources.ResourceManager
        rm = New System.Resources.ResourceManager("Grid2OL.Resource1", Assembly.GetExecutingAssembly())
        Dim html As String = rm.GetObject("varBlock")
	     Dim htmlupdate As String = rm.GetObject("UpdateBlock")
	     
	     htmlupdate = htmlupdate.Replace("VBGRIDNO", gridcount)
	     
	     html = html.Replace("VBGRIDNO", gridcount)
	     
	     html = html.Replace("VBVAR_minX", xllcorner)
	     html = html.Replace("VBVAR_maxX", (xllcorner + (cellsize * Swidth)))
	     html = html.Replace("VBVAR_minY", yllcorner)	
	     html = html.Replace("VBVAR_maxY", (yllcorner + (cellsize * Sheight)))
	     
	     html = html.Replace("VBVAR_bitmap", (Path.GetFileNameWithoutExtension(fPath) & ".jpg"))
	     html = html.Replace("VBVAR_bmpX", (Swidth/5)) 'altered to allow zoom out
	     html = html.Replace("VBVAR_bmpY", (Sheight/5))'altered to allow zoom out
	     
	     html = html.Replace("VBVAR_cellsize", cellsize)
	     html = html.Replace("VBVAR_gridsize", outputgridsize)
	     html = html.Replace("VBVAR_intervals", numericUpDown2.value)
	     html = html.Replace("VBVAR_nrows", Sheight)
	     
	'check for simple or complex Xsecs and apply correct code block from resourses
     If radioButton1.Checked Then 
	     htmlupdate = htmlupdate.Replace("VBVAR_COMPLEX", rm.GetObject("Xcomplex"))
	     htmlupdate = htmlupdate.Replace("VBVAR_GETXY", rm.GetObject("XcomplexXY"))
	     htmlupdate = htmlupdate.Replace("VBVAR_SCXSEC", rm.GetObject("CompXsec"))
	     
     Else
     	 htmlupdate = htmlupdate.Replace("VBVAR_COMPLEX", rm.GetObject("Xsimple"))
     	 htmlupdate = htmlupdate.Replace("VBVAR_GETXY", rm.GetObject("XsimpleXY"))
     	 htmlupdate = htmlupdate.Replace("VBVAR_SCXSEC", rm.GetObject("SimpXsec"))
     End if
	     
	     htmlupdate = htmlupdate.Replace("VBGRIDNO", gridcount)
	     htmlupdate = htmlupdate.Replace("VBVAR_PATH", (Path.GetFileNameWithoutExtension(fpath0)  & "/")) 'removed "/"
			
			varblockstring = varblockstring + html
			updateblockstring = updateblockstring + htmlupdate
			ELEVArrayLoader  = ELEVArrayLoader + ",{label:'" & Path.GetFileNameWithoutExtension(fpath) & "', data: ELEVarray" & gridcount & "}"
			updateLoader = updateLoader + " update" & gridcount & "();"
			tablebuilder = tablebuilder & "<td>" & Chr(34) & " + ELEVarray" & gridcount & "[i][1] + " & Chr(34) & "</td>"
			tableheaders = tableheaders & "<th>" & Path.GetFileNameWithoutExtension(fPath) & "</th>"
			fullarray = fullarray & "fullArray[i][" & (gridcount + 0) & "] = ELEVarray" & gridcount & "[i][1]; fullArray[0][" & gridcount & "] = '" & Path.GetFileNameWithoutExtension(fPath) & "';"
		
		
		End Sub
	
	
    Sub Button10Click(sender As Object, e As EventArgs) Handles button10.Click
        Dim OFD1 As New OpenFileDialog
        OFD1.Filter = "ASCII files (*.asc)|*.asc|ASCII Text Files (*.txt)|*.txt"
        OFD1.ShowDialog()
        listBox1.Items.Add(OFD1.FileName)
    End Sub
	
    Sub Button11Click(sender As Object, e As EventArgs) Handles button11.Click
        listBox1.Items.Clear()
    End Sub
	
    Sub Button12Click(sender As Object, e As EventArgs) Handles button12.Click
        listBox2.Items.Add(numericUpDown3.Value)
    End Sub
	
    Sub Button13Click(sender As Object, e As EventArgs) Handles button13.Click
        listBox2.Items.Clear()
    End Sub
	
	
	
	Sub tileup(ByVal Iname As String)
		
		Dim currentX As integer = 0
		Dim currentY As Integer = 0
		Dim xleftover As Integer = 256
		Dim yleftover As Integer = 256
		
		Dim tilefolder As String = Path.GetDirectoryName(Iname)
		Dim fname As String = Path.GetFileNameWithoutExtension(Iname)
		Directory.CreateDirectory(tilefolder & "\" & fname & "_tiles")
		
		Dim OrignalImage = Image.FromFile(Iname)
		Dim CropRect As New Rectangle(currentX, currentY, 256, 256)
    
    For y = 0 To (Math.Floor(OrignalImage.Height / 256))
    	For x = 0 To (Math.Floor(OrignalImage.Width / 256))
    		
    	If x = (Math.Floor(OrignalImage.Width / 256)) Then xleftover = 	OrignalImage.Width - (256 * (x))
    	If y = (Math.Floor(OrignalImage.height / 256)) Then yleftover = OrignalImage.height - (256 * (y))
    		
    	CropRect = New Rectangle(currentX * x, currentY * y, 256, 256)
	    Dim CropImage = New Bitmap(CropRect.Width, CropRect.Height)
	    Using grp = Graphics.FromImage(CropImage)
	        grp.DrawImage(OrignalImage, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
	        
	        CropImage.Save(tilefolder & "\" & fname & "_tiles\" & "1" & "_" & x & "_" & y & ".jpg")
	    End Using
	    
	    xleftover = 256
		yleftover  = 256
	    currentX = currentX + 256
    	Next
    currentY = currentY + 256
    Next
    'OriginalImage.Dispose

	End Sub
	
	
	
	
    Sub Form1Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        showHelp()
    End Sub

    Sub showHelp()
        If Me.Height > 300 Then
            Me.Height = 300
            tabControl1.Height = 145
        Else
            Me.Height = 700
            tabControl1.Height = 537
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        showHelp()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        showHelp()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        showHelp()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        showHelp()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        showHelp()
    End Sub
End Class
