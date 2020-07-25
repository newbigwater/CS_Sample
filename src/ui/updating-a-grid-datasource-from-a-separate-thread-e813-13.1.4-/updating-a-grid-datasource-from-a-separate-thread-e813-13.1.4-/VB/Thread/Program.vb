﻿' Developer Express Code Central Example:
' How to avoid the ArgumentOutOfRangeException exception when updating the Grid's data source within a background thread
' 
' This example shows how to properly update the Grid's underlying data source from
' a background thread, and avoid possible synchronization problems.
' 
' 
' See
' Also:
' <kblink id = "AK2981"/>
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E813

Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace Thread
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Module
End Namespace