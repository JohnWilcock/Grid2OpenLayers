'
' Created by SharpDevelop.
' User: J.Wilcock
' Date: 05/03/2013
' Time: 16:15
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class Finished
public fileloc As string	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Me.Close
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		System.Diagnostics.Process.Start(fileloc)
		Me.Close
	End Sub
End Class
