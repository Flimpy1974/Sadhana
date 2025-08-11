<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim cboInstructor As RBWIN_gradnikiV8.cct_ComboWithForm
        cboInstructor = New RBWIN_gradnikiV8.cct_ComboWithForm
        Me.SuspendLayout()
        '
        'cboInstructor
        '
        cboInstructor.pr_addEmptyRecord = False
        cboInstructor.pr_addFormEnabled = True
        cboInstructor.BackColor = System.Drawing.SystemColors.Control
        cboInstructor.pr_DataSource = Nothing
        cboInstructor.pr_DisplayMember = ""
        cboInstructor.pr_FormObjectName = "frmInstructor"
        cboInstructor.Location = New System.Drawing.Point(84, 121)
        cboInstructor.Name = "cboInstructor"
        cboInstructor.pr_SelectedValue = Nothing
        cboInstructor.Size = New System.Drawing.Size(125, 25)
        cboInstructor.pr_sqlSELECT = "select a.id_instructor, b.firstname + "" ""+b.lastname as name  from instructor a i" & _
            "nner join person  b on a.id_person = b.id_person"
        cboInstructor.TabIndex = 261
        cboInstructor.pr_boundto = "ID_Instructor"
        cboInstructor.pr_ValueMember = ""
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(cboInstructor)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub
End Class
