namespace Q183557
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDBDataSet = new Q183557.CarsDBDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrademark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLiter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCyl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.carsTableAdapter = new Q183557.CarsDBDataSetTableAdapters.CarsTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.AllowDrop = true;
            this.gridControl1.DataSource = this.carsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(505, 307);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DragOver += new System.Windows.Forms.DragEventHandler(this.gridControl1_DragOver);
            this.gridControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridControl1_DragDrop);
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carsDBDataSet;
            // 
            // carsDBDataSet
            // 
            this.carsDBDataSet.DataSetName = "CarsDBDataSet";
            this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTrademark,
            this.colModel,
            this.colHP,
            this.colLiter,
            this.colCyl});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTrademark, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseMove);
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            // 
            // colTrademark
            // 
            this.colTrademark.Caption = "Trademark";
            this.colTrademark.FieldName = "Trademark";
            this.colTrademark.Name = "colTrademark";
            // 
            // colModel
            // 
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 0;
            // 
            // colHP
            // 
            this.colHP.Caption = "HP";
            this.colHP.FieldName = "HP";
            this.colHP.Name = "colHP";
            this.colHP.Visible = true;
            this.colHP.VisibleIndex = 2;
            // 
            // colLiter
            // 
            this.colLiter.Caption = "Liter";
            this.colLiter.FieldName = "Liter";
            this.colLiter.Name = "colLiter";
            this.colLiter.Visible = true;
            this.colLiter.VisibleIndex = 3;
            // 
            // colCyl
            // 
            this.colCyl.Caption = "Cyl";
            this.colCyl.FieldName = "Cyl";
            this.colCyl.Name = "colCyl";
            this.colCyl.Visible = true;
            this.colCyl.VisibleIndex = 4;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 307);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private CarsDBDataSet carsDBDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private Q183557.CarsDBDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTrademark;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colHP;
        private DevExpress.XtraGrid.Columns.GridColumn colLiter;
        private DevExpress.XtraGrid.Columns.GridColumn colCyl;
        private System.Windows.Forms.Timer timer1;
    }
}

