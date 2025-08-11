<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorFormControl
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
        Me.InstructorDataControl1 = New Sadhana.InstructorDataControl
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
        Me.splitGridDetail.Panel2.Controls.Add(Me.InstructorDataControl1)
        '
        'InstructorDataControl1
        '
        Me.InstructorDataControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.InstructorDataControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.InstructorDataControl1.ds = Nothing
        Me.InstructorDataControl1.Location = New System.Drawing.Point(0, 0)
        Me.InstructorDataControl1.myCurrencyManager = Nothing
        Me.InstructorDataControl1.Name = "InstructorDataControl1"
        Me.InstructorDataControl1.pr_GUID_FIELD = "GUID_instructor"
        Me.InstructorDataControl1.pr_ID_FIELD = "ID_instructor"
        Me.InstructorDataControl1.pr_IsAddNew = False
        Me.InstructorDataControl1.pr_TableName = "Instructor"
        Me.InstructorDataControl1.pr_WSURL_KEY = Nothing
        Me.InstructorDataControl1.Size = New System.Drawing.Size(826, 184)
        Me.InstructorDataControl1.TabIndex = 1
        '
        'InstructorFormControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Name = "InstructorFormControl"
        Me.pr_DataForm = "InstructorDataform"
        Me.pr_ID_COLUMN_NAME = "ID_instructor"
        Me.pr_sqlSELECT = "select b.lastname, b.firstname,b.date_birth,a.* from Instructor a left outer join" & _
            " person b on a.guid_person = b.guid_person"
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel2.ResumeLayout(False)
        Me.splitMain.ResumeLayout(False)
        Me.splitGridDetail.Panel2.ResumeLayout(False)
        Me.splitGridDetail.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InstructorDataControl1 As Sadhana.InstructorDataControl

End Class
