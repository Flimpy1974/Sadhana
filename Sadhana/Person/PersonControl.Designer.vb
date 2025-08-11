<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonControl
    Inherits RBWIN_gradnikiV8.cct_generalUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtID = New RBWIN_gradnikiV8.bct_textbox
        Me.dtpDatum = New RBWIN_gradnikiV8.bct_DateTimePickerNullable
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPriimek = New RBWIN_gradnikiV8.bct_textbox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtIme = New RBWIN_gradnikiV8.bct_textbox
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(276, 11)
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(237, 64)
        Me.txtID.Name = "txtID"
        Me.txtID.pr_allow_mass_update = False
        Me.txtID.pr_bound_tip = Nothing
        Me.txtID.pr_boundto = ""
        Me.txtID.pr_currencyDecimal = CType(2, Short)
        Me.txtID.pr_iscurrency = False
        Me.txtID.pr_locilo1000 = "."
        Me.txtID.pr_RKBValue = ""
        Me.txtID.pr_searchfield = Nothing
        Me.txtID.pr_text = ""
        Me.txtID.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.txtID.Size = New System.Drawing.Size(35, 20)
        Me.txtID.TabIndex = 169
        Me.txtID.Visible = False
        '
        'dtpDatum
        '
        Me.dtpDatum.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDatum.CustomFormat = "dd.MM.yyyy"
        Me.dtpDatum.Enabled = False
        Me.dtpDatum.Location = New System.Drawing.Point(68, 64)
        Me.dtpDatum.Name = "dtpDatum"
        Me.dtpDatum.pr_allow_mass_update = False
        Me.dtpDatum.pr_bound_tip = Nothing
        Me.dtpDatum.pr_boundto = "date_birth"
        Me.dtpDatum.pr_RKBValue = New Date(2009, 1, 20, 15, 37, 15, 171)
        Me.dtpDatum.pr_searchfield = Nothing
        Me.dtpDatum.Size = New System.Drawing.Size(125, 20)
        Me.dtpDatum.TabIndex = 178
        Me.dtpDatum.Value = New Date(2009, 1, 20, 15, 37, 15, 171)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 177
        Me.Label3.Text = "Dat. rojstva"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Priimek"
        '
        'txtPriimek
        '
        Me.txtPriimek.BackColor = System.Drawing.Color.White
        Me.txtPriimek.Enabled = False
        Me.txtPriimek.Location = New System.Drawing.Point(68, 35)
        Me.txtPriimek.Name = "txtPriimek"
        Me.txtPriimek.pr_allow_mass_update = False
        Me.txtPriimek.pr_bound_tip = Nothing
        Me.txtPriimek.pr_boundto = "firstname"
        Me.txtPriimek.pr_currencyDecimal = CType(2, Short)
        Me.txtPriimek.pr_iscurrency = False
        Me.txtPriimek.pr_locilo1000 = "."
        Me.txtPriimek.pr_RKBValue = ""
        Me.txtPriimek.pr_searchfield = Nothing
        Me.txtPriimek.pr_text = ""
        Me.txtPriimek.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.txtPriimek.Size = New System.Drawing.Size(201, 20)
        Me.txtPriimek.TabIndex = 175
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "Ime"
        '
        'txtIme
        '
        Me.txtIme.BackColor = System.Drawing.Color.White
        Me.txtIme.Enabled = False
        Me.txtIme.Location = New System.Drawing.Point(68, 9)
        Me.txtIme.Name = "txtIme"
        Me.txtIme.pr_allow_mass_update = False
        Me.txtIme.pr_bound_tip = Nothing
        Me.txtIme.pr_boundto = "lastname"
        Me.txtIme.pr_currencyDecimal = CType(2, Short)
        Me.txtIme.pr_iscurrency = False
        Me.txtIme.pr_locilo1000 = "."
        Me.txtIme.pr_RKBValue = ""
        Me.txtIme.pr_searchfield = Nothing
        Me.txtIme.pr_text = ""
        Me.txtIme.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.txtIme.Size = New System.Drawing.Size(201, 20)
        Me.txtIme.TabIndex = 173
        '
        'PersonControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dtpDatum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPriimek)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIme)
        Me.Controls.Add(Me.txtID)
        Me.Name = "PersonControl"
        Me.Size = New System.Drawing.Size(303, 103)
        Me.Controls.SetChildIndex(Me.txtID, 0)
        Me.Controls.SetChildIndex(Me.btnSelect, 0)
        Me.Controls.SetChildIndex(Me.txtUNID, 0)
        Me.Controls.SetChildIndex(Me.txtIme, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtPriimek, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.dtpDatum, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtID As RBWIN_gradnikiV8.bct_textbox
    Friend WithEvents dtpDatum As RBWIN_gradnikiV8.bct_DateTimePickerNullable
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtPriimek As RBWIN_gradnikiV8.bct_textbox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtIme As RBWIN_gradnikiV8.bct_textbox

End Class
