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
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports System.Threading
Imports System.Threading.Tasks

Namespace Thread
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			InitData()
			FillData()
			InitGridColumns()
		End Sub

		Private data As DataTable
		Private Sub InitData()
			data = New DataTable("ColumnsTable")
			data.BeginInit()
			AddColumn(data, "ID", System.Type.GetType("System.Int32"), True)
			AddColumn(data, "First Name", System.Type.GetType("System.String"))
			data.EndInit()
		End Sub

'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not handle local variables named the same as class members well:
		Private Sub AddColumn(ByVal data As DataTable, ByVal name_Conflict As String, ByVal type As Type)
			AddColumn(data, name_Conflict, type, False)
		End Sub
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not handle local variables named the same as class members well:
		Private Sub AddColumn(ByVal data As DataTable, ByVal name_Conflict As String, ByVal type As Type, ByVal ro As Boolean)
			Dim col As DataColumn
			col = New DataColumn(name_Conflict, type)
			col.Caption = name_Conflict
			col.ReadOnly = ro
			data.Columns.Add(col)
		End Sub

		Private Sub FillData()
			FillData(data, False)
		End Sub

		Private Sub FillData(ByVal data As DataTable, ByVal deleteRows As Boolean)
			If deleteRows Then
				For i As Integer = data.Rows.Count - 1 To 0 Step -1
					If i Mod 2 <> 0 Then
						data.Rows.RemoveAt(i)
					End If
				Next i
			Else
				data.Clear()
				For i As Integer = 0 To 300
					data.Rows.Add(New Object() { i + 1, "Row " & (i + 1).ToString() })
				Next i
			End If
		End Sub
		Private gridControl1 As GridControl
		Private Sub InitGridColumns()
			gridControl1 = New GridControl()
			gridControl1.Dock = DockStyle.Right
			Controls.Add(gridControl1)
			gridControl1.DataSource = data
		End Sub

'INSTANT VB TODO TASK: There is no VB equivalent to 'volatile':
'ORIGINAL LINE: volatile bool deleting = false;
		Private deleting As Boolean = False

		Private Sub UpdateGridDataSource(ByVal copy As DataTable)
			FillData(copy, deleting)
			deleting = Not deleting
			gridControl1.BeginInvoke(New Action(Sub()
				gridControl1.DataSource = copy
			End Sub))
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If Not Me.button1.IsHandleCreated Then Return

			timer1.Start()
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			Task.Run(Sub() UpdateGridDataSource(data.Copy()))
		End Sub
	End Class
End Namespace