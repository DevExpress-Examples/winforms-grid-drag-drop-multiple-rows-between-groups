Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors

Namespace DXSample

    Public Partial Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            recordBindingSource.DataSource = DataHelper.GetData(10)
        End Sub
    End Class
End Namespace
