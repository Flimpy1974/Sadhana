Public Class EducationFormControl

    Private Sub frmEducation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.pr_cct_detail = EducationDataControl1
        Me.Width = 634
        Me.Height = 356
        splitGridDetail.Width = 626
        splitGridDetail.Height = 232
        splitGridDetail.SplitterDistance = 314
        splitGridDetail.IsSplitterFixed = True
        ' EducationDataControl1.Width = splitGridDetail.Width - splitGridDetail.SplitterDistance - splitGridDetail.SplitterWidth
        'EducationDataControl1.Height = 106
        Filldata()
        Me.splitMain.Panel1Collapsed = True
        dg.Focus()
    End Sub
    Public Overrides Sub Filldata()
        MyBase.FillData()
        ds.Tables(0).Columns("available").DefaultValue = True
        ds.Tables(0).Columns("sortorder").DefaultValue = 0
        EducationDataControl1.ds = Me.ds
        EducationDataControl1.Bind()
    End Sub
End Class
