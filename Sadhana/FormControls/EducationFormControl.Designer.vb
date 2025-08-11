<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EducationFormControl
    Inherits RBWIN_gradnikiV8.cct_search

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
        Me.EducationDataControl1 = New Sadhana.EducationDataControl
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
        Me.splitGridDetail.Panel2.Controls.Add(Me.EducationDataControl1)
        '
        'EducationDataControl1
        '
        Me.EducationDataControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EducationDataControl1.ds = Nothing
        Me.EducationDataControl1.Location = New System.Drawing.Point(0, 0)
        Me.EducationDataControl1.myCurrencyManager = Nothing
        Me.EducationDataControl1.Name = "EducationDataControl1"
        Me.EducationDataControl1.pr_GUID_FIELD = "GUID_Education"
        Me.EducationDataControl1.pr_ID_FIELD = "ID_Education"
        Me.EducationDataControl1.pr_IsAddNew = False
        Me.EducationDataControl1.pr_TableName = "cat_Education"
        Me.EducationDataControl1.Size = New System.Drawing.Size(826, 109)
        Me.EducationDataControl1.TabIndex = 1
        '
        'EducationFormControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Name = "EducationFormControl"
        Me.pr_ID_COLUMN_NAME = "ID_Education"
        Me.pr_sqlSELECT = "select * from cat_Education"
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel2.ResumeLayout(False)
        Me.splitMain.ResumeLayout(False)
        Me.splitGridDetail.Panel2.ResumeLayout(False)
        Me.splitGridDetail.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EducationDataControl1 As Sadhana.EducationDataControl

End Class
