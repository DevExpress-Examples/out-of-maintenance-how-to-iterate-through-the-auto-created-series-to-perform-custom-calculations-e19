Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections
Imports DevExpress.XtraCharts

Namespace SeriesTemplateSample
	Partial Public Class Form1
		Inherits Form
		Private series As New Hashtable()
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'gspDataSet.GSP' table. You can move, or remove it, as needed.
			Me.gSPTableAdapter.Fill(Me.gspDataSet.GSP)
			chartControl1.RefreshData()
			Dim count As Integer = 0
			Dim value As Double =0.0
			For Each key As String In series.Keys
				For Each p As SeriesPoint In (TryCast(series(key), Series)).Points
					count += 1
					value += p.Values(0)
				Next p
			Next key
			If count <> 0 Then
				Dim average As New Series("Average", ViewType.Bar)
				average.Points.Add(New SeriesPoint("Average", value / count))
				chartControl1.Series.Add(average)
			End If

		End Sub

		Private Sub chartControl1_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chartControl1.BoundDataChanged
			For Each s As Series In chartControl1.Series
				If (Not series.Contains(s.Name)) Then
					series.Add(s.Name, s)
				End If
			Next s
		End Sub
	End Class
End Namespace