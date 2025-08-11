Public Class ProductFormControl

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.pr_cct_detail = ProductDataControl1
    End Sub

    Public Overrides Sub Filldata()
        MyBase.FillData()
        ds.Tables(0).Columns("available").DefaultValue = True
        'ds.Tables(0).Columns("sortorder").DefaultValue = 0
        ProductDataControl1.ds = Me.ds
        ProductDataControl1.Bind()
    End Sub


End Class
