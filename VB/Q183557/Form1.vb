Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns

Namespace Q183557

    Public Partial Class Form1
        Inherits Form

        Private dragRectangle As Rectangle = New Rectangle(Point.Empty, SystemInformation.DragSize)

        Private groupRowHandle As Integer = GridControl.InvalidRowHandle

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
            carsTableAdapter.Fill(carsDBDataSet.Cars)
        End Sub

        Private Sub gridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim view As GridView = CType(sender, GridView)
            If view.GroupCount = 0 Then Return
            Dim hitInfo As GridHitInfo = view.CalcHitInfo(e.Location)
            If e.Button = MouseButtons.Left AndAlso hitInfo.InRowCell Then
                dragRectangle.Location = e.Location
            Else
                dragRectangle.Location = Point.Empty
            End If
        End Sub

        Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim view As GridView = CType(sender, GridView)
            If e.Button = MouseButtons.Left AndAlso dragRectangle.Location <> Point.Empty AndAlso Not dragRectangle.Contains(e.Location) Then
                Dim data As Integer() = view.GetSelectedRows()
                For i As Integer = 0 To data.Length - 1
                    data(i) = view.GetDataSourceRowIndex(data(i))
                Next

                view.GridControl.DoDragDrop(data, DragDropEffects.Move)
            End If
        End Sub

        Private Sub gridControl1_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
            Dim control As GridControl = CType(sender, GridControl)
            Dim view As GridView = CType(control.DefaultView, GridView)
            Dim info As GridHitInfo = view.CalcHitInfo(control.PointToClient(New Point(e.X, e.Y)))
            If info.InRowCell Then
                e.Effect = DragDropEffects.Move
            ElseIf info.InRow AndAlso view.IsGroupRow(info.RowHandle) Then
                groupRowHandle = info.RowHandle
                timer1.Start()
            Else
                e.Effect = DragDropEffects.None
            End If
        End Sub

        Private Sub gridControl1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data IsNot Nothing AndAlso e.Effect = DragDropEffects.Move Then
                Dim control As GridControl = CType(sender, GridControl)
                Dim view As GridView = CType(control.DefaultView, GridView)
                Dim info As GridHitInfo = view.CalcHitInfo(control.PointToClient(New Point(e.X, e.Y)))
                MoveRows(info.RowHandle, view, CType(e.Data.GetData(GetType(Integer())), Integer()), view.GetRowLevel(info.RowHandle))
                view.RefreshData()
            End If
        End Sub

        Private Sub MoveRows(ByVal target As Integer, ByVal view As GridView, ByVal rows As Integer(), ByVal level As Integer)
            Dim col As GridColumn = view.GroupedColumns(level - 1)
            Dim val As Object = view.GetRowCellValue(target, col)
            For Each row As Integer In rows
                Dim rowHandle As Integer = view.GetRowHandle(row)
                view.SetRowCellValue(rowHandle, col, val)
            Next

            If level > 0 Then
                level -= 1
                MoveRows(target, view, rows, level)
            End If
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            CType(sender, Timer).Stop()
            If groupRowHandle <> GridControl.InvalidRowHandle Then
                gridView1.CollapseAllGroups()
                gridView1.ExpandGroupRow(groupRowHandle)
                groupRowHandle = GridControl.InvalidRowHandle
            End If
        End Sub
    End Class
End Namespace
