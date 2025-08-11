<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SemesterFormControl
    Inherits RBWIN_gradnikiV8.cct_search 'Sadhana.FormControl

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SemesterDataControl1 = New Sadhana.SemesterDataControl
        Me.splitMain.Panel1.SuspendLayout()
        Me.splitMain.Panel2.SuspendLayout()
        Me.splitMain.SuspendLayout()
        Me.splitGridDetail.Panel2.SuspendLayout()
        Me.splitGridDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitMain
        '
        '
        'splitGridDetail
        '
        Me.splitGridDetail.Orientation = System.Windows.Forms.Orientation.Vertical
        '
        'splitGridDetail.Panel2
        '
        Me.splitGridDetail.Panel2.Controls.Add(Me.SemesterDataControl1)
        '
        'SemesterDataControl1
        '
        Me.SemesterDataControl1.BackColor = System.Drawing.Color.Transparent
        Me.SemesterDataControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SemesterDataControl1.ds = Nothing
        Me.SemesterDataControl1.Location = New System.Drawing.Point(0, 0)
        Me.SemesterDataControl1.myCurrencyManager = Nothing
        Me.SemesterDataControl1.Name = "SemesterDataControl1"
        Me.SemesterDataControl1.pr_GUID_FIELD = "GUID_Semester"
        Me.SemesterDataControl1.pr_ID_FIELD = "ID_Semester"
        Me.SemesterDataControl1.pr_IsAddNew = False
        Me.SemesterDataControl1.pr_TableName = "cat_Semester"
        Me.SemesterDataControl1.Size = New System.Drawing.Size(826, 150)
        Me.SemesterDataControl1.TabIndex = 1
        '
        'SemesterFormControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Name = "SemesterFormControl"
        Me.pr_DataForm = "SemesterDataform"
        Me.pr_ID_COLUMN_NAME = "ID_Semester"
        Me.pr_sqlSELECT = "select * from cat_Semester"
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel2.ResumeLayout(False)
        Me.splitMain.ResumeLayout(False)
        Me.splitGridDetail.Panel2.ResumeLayout(False)
        Me.splitGridDetail.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SemesterDataControl1 As Sadhana.SemesterDataControl

End Class
