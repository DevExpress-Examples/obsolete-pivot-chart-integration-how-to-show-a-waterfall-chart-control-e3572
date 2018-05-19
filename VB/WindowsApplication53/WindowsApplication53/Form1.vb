Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace WindowsApplication53
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			PopulateTable()
			pivotGridControl1.RefreshData()
			pivotGridControl1.BestFit()
		End Sub
		Private Sub PopulateTable()
			Dim myTable As DataTable = dataSet1.Tables("Data")
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today, 7 })
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddDays(1), 4 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today, 12 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(1), 14 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today, 11 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(1), 10 })

			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddYears(1), 4 })
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 2 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddYears(1), 3 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 1 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddYears(1), 8 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(1).AddYears(1), 22 })
		End Sub

		Private Sub pivotGridControl1_CustomChartDataSourceData(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventArgs) Handles pivotGridControl1.CustomChartDataSourceData

		End Sub

		Private list As New List(Of Series)()
		Private Sub chartControl1_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chartControl1.BoundDataChanged
			Dim chart As ChartControl = CType(sender, ChartControl)


			If chart.Series.Count < 1 Then
				Return
			End If
			For i As Integer = chart.Series.Count - 1 To 0 Step -1
				Dim s As Series = chart.Series(i)
				For Each point As SeriesPoint In s.Points
					Dim width As Double = point.Values(0)
					point.Values(0) = GetPreviousSeriesSummary(chart, i, point.Argument)
					point.Values(1) = point.Values(0) + width
				Next point
			Next i


		End Sub

		Private Function GetPreviousSeriesSummary(ByVal chart As ChartControl, ByVal seriesIndex As Integer, ByVal argument As String) As Double
			Dim summaryValue As Double = 0
			For i As Integer = 0 To seriesIndex - 1
				Dim s As Series = chart.Series(i)
				For Each point As SeriesPoint In s.Points
					If Equals(point.Argument, argument) Then
						summaryValue += point.Values(0)
					End If
				Next point
			Next i
			Return summaryValue
		End Function

		Private Sub chartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles chartControl1.CustomDrawSeriesPoint

		End Sub

	End Class
End Namespace