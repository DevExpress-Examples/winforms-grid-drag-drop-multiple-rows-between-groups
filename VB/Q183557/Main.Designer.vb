Namespace DXSample

    Partial Class Main

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.recordBindingSource = New System.Windows.Forms.BindingSource()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colParentID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colText = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInfo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDt = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDetail = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager()
            Me.dragDropEvents1 = New DevExpress.Utils.DragDrop.DragDropEvents()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.recordBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.recordBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(505, 307)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' recordBindingSource
            ' 
            Me.recordBindingSource.DataSource = GetType(DXSample.Record)
            ' 
            ' gridView1
            ' 
            Me.behaviorManager1.SetBehaviors(Me.gridView1, New DevExpress.Utils.Behaviors.Behavior() {CType((DevExpress.Utils.DragDrop.DragDropBehavior.Create(GetType(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), True, True, True, Me.dragDropEvents1)), DevExpress.Utils.Behaviors.Behavior)})
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colParentID, Me.colText, Me.colInfo, Me.colValue, Me.colDt, Me.colState, Me.colImage, Me.colDetail})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colParentID, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' colParentID
            ' 
            Me.colParentID.FieldName = "ParentID"
            Me.colParentID.Name = "colParentID"
            Me.colParentID.Visible = True
            Me.colParentID.VisibleIndex = 1
            ' 
            ' colText
            ' 
            Me.colText.FieldName = "Text"
            Me.colText.Name = "colText"
            Me.colText.Visible = True
            Me.colText.VisibleIndex = 1
            ' 
            ' colInfo
            ' 
            Me.colInfo.FieldName = "Info"
            Me.colInfo.Name = "colInfo"
            Me.colInfo.Visible = True
            Me.colInfo.VisibleIndex = 2
            ' 
            ' colValue
            ' 
            Me.colValue.FieldName = "Value"
            Me.colValue.Name = "colValue"
            Me.colValue.Visible = True
            Me.colValue.VisibleIndex = 3
            ' 
            ' colDt
            ' 
            Me.colDt.FieldName = "Dt"
            Me.colDt.Name = "colDt"
            Me.colDt.Visible = True
            Me.colDt.VisibleIndex = 4
            ' 
            ' colState
            ' 
            Me.colState.FieldName = "State"
            Me.colState.Name = "colState"
            Me.colState.Visible = True
            Me.colState.VisibleIndex = 5
            ' 
            ' colImage
            ' 
            Me.colImage.FieldName = "Image"
            Me.colImage.Name = "colImage"
            ' 
            ' colDetail
            ' 
            Me.colDetail.FieldName = "Detail"
            Me.colDetail.Name = "colDetail"
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(505, 307)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Main"
            Me.Text = "Main"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.recordBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.behaviorManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private recordBindingSource As System.Windows.Forms.BindingSource

        Private colID As DevExpress.XtraGrid.Columns.GridColumn

        Private colParentID As DevExpress.XtraGrid.Columns.GridColumn

        Private colText As DevExpress.XtraGrid.Columns.GridColumn

        Private colInfo As DevExpress.XtraGrid.Columns.GridColumn

        Private colValue As DevExpress.XtraGrid.Columns.GridColumn

        Private colDt As DevExpress.XtraGrid.Columns.GridColumn

        Private colState As DevExpress.XtraGrid.Columns.GridColumn

        Private colImage As DevExpress.XtraGrid.Columns.GridColumn

        Private colDetail As DevExpress.XtraGrid.Columns.GridColumn

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager

        Private dragDropEvents1 As DevExpress.Utils.DragDrop.DragDropEvents
    End Class
End Namespace
