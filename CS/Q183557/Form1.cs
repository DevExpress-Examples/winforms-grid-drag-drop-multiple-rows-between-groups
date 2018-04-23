using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;

namespace Q183557 {
    public partial class Form1: Form {
        Rectangle dragRectangle = new Rectangle(Point.Empty,SystemInformation.DragSize);
        int groupRowHandle = GridControl.InvalidRowHandle;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender,EventArgs e) {
            // TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);

        }

        private void gridView1_MouseDown(object sender,MouseEventArgs e) {
            GridView view = (GridView)sender;
            if(view.GroupCount == 0) return;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if(e.Button == MouseButtons.Left &&
                hitInfo.InRowCell)
                dragRectangle.Location = e.Location;
            else
                dragRectangle.Location = Point.Empty;
        }

        private void gridView1_MouseMove(object sender,MouseEventArgs e) {
            GridView view = (GridView)sender;
            if(e.Button == MouseButtons.Left &&
                dragRectangle.Location != Point.Empty &&
                !dragRectangle.Contains(e.Location)) {
                int[] data = view.GetSelectedRows();
                for(int i = 0;i < data.Length;i++)
                    data[i] = view.GetDataSourceRowIndex(data[i]);
                view.GridControl.DoDragDrop(data,DragDropEffects.Move);
            }
        }

        private void gridControl1_DragOver(object sender,DragEventArgs e)
        {
            GridControl control = (GridControl)sender;
            GridView view = (GridView)control.DefaultView;
            GridHitInfo info = view.CalcHitInfo(control.PointToClient(new Point(e.X, e.Y)));
            if (info.InRowCell)
                e.Effect = DragDropEffects.Move;
            else 
                if(info.InRow && view.IsGroupRow(info.RowHandle)){
                    groupRowHandle = info.RowHandle;
                    timer1.Start();
                }
                else
                e.Effect = DragDropEffects.None;
        }

        private void gridControl1_DragDrop(object sender,DragEventArgs e) {
            if(e.Data != null &&
                e.Effect == DragDropEffects.Move) {
                GridControl control = (GridControl)sender;
                GridView view = (GridView)control.DefaultView;
                GridHitInfo info = view.CalcHitInfo(control.PointToClient(new Point(e.X,e.Y)));
                MoveRows(info.RowHandle,view,(int[])e.Data.GetData(typeof(int[])),view.GetRowLevel(info.RowHandle));
                view.RefreshData();
            }
        }

        private void MoveRows(int target,GridView view,int[] rows,int level) {
            GridColumn col = view.GroupedColumns[level - 1];
            object val = view.GetRowCellValue(target,col);
            foreach(int row in rows) {
                int rowHandle = view.GetRowHandle(row);
                view.SetRowCellValue(rowHandle,col,val);
            }
            if(level > 0) {
                level--;
                MoveRows(target,view,rows,level);
            }
        }

        private void timer1_Tick(object sender,EventArgs e) {
            ((Timer)sender).Stop();
            if(groupRowHandle != GridControl.InvalidRowHandle){
                gridView1.CollapseAllGroups();
                gridView1.ExpandGroupRow(groupRowHandle);
                groupRowHandle = GridControl.InvalidRowHandle;
            }
        }
    }
}