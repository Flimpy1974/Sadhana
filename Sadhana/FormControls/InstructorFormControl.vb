Public Class InstructorFormControl

    Public Overrides Sub Filldata()
        MyBase.FillData()
        ds.Tables(0).Columns("is_mentor").DefaultValue = False
        ds.Tables(0).Columns("is_active").DefaultValue = True
    End Sub
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.pr_cct_detail = InstructorDataControl1
        ' Add any initialization after the InitializeComponent() call.
    End Sub
   
    
End Class
