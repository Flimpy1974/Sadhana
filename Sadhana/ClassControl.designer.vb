<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassControl
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtEnota = New RBWIN_gradnikiV8.bct_textbox
        Me.txtID = New RBWIN_gradnikiV8.bct_textbox
        Me.txtHall = New RBWIN_gradnikiV8.bct_textbox
        Me.txtSemester = New RBWIN_gradnikiV8.bct_textbox
        Me.txtYear = New RBWIN_gradnikiV8.bct_textbox
        Me.txtLevel = New RBWIN_gradnikiV8.bct_textbox
        Me.txtInstructor = New RBWIN_gradnikiV8.bct_textbox
        Me.Bct_DateTimePickerNullable1 = New RBWIN_gradnikiV8.bct_DateTimePickerNullable
        Me.Bct_DateTimePickerNullable2 = New RBWIN_gradnikiV8.bct_DateTimePickerNullable
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Image = Global.Sadhana.My.Resources.Resources._class
        Me.btnSelect.Location = New System.Drawing.Point(437, 11)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Stopnja"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(262, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "Inštruktor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "Leto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 173
        Me.Label5.Text = "Semester"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Dvorana"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(151, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 13)
        Me.Label16.TabIndex = 260
        Me.Label16.Text = "Do"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 13)
        Me.Label14.TabIndex = 259
        Me.Label14.Text = "Od"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(277, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 263
        Me.Label6.Text = "Enota"
        '
        'txtEnota
        '
        Me.txtEnota.BackColor = System.Drawing.Color.White
        Me.txtEnota.Enabled = False
        Me.txtEnota.Location = New System.Drawing.Point(315, 65)
        Me.txtEnota.Name = "txtEnota"
        Me.txtEnota.pr_allow_mass_update = False
        Me.txtEnota.pr_bound_tip = Nothing
        Me.txtEnota.pr_boundto = "enota"
        Me.txtEnota.pr_currencyDecimal = CType(2, Short)
        Me.txtEnota.pr_iscurrency = False
        Me.txtEnota.pr_locilo1000 = "."
        Me.txtEnota.pr_RKBValue = ""
        Me.txtEnota.pr_searchfield = Nothing
        Me.txtEnota.pr_text = ""
        Me.txtEnota.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.txtEnota.Size = New System.Drawing.Size(118, 20)
        Me.txtEnota.TabIndex = 262
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(442, 38)
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
        Me.txtID.Size = New System.Drawing.Size(19, 20)
        Me.txtID.TabIndex = 261
        Me.txtID.Visible = False
        '
        'txtHall
        '
        Me.txtHall.BackColor = System.Drawing.Color.White
        Me.txtHall.Enabled = False
        Me.txtHall.Location = New System.Drawing.Point(54, 38)
        Me.txtHall.Name = "txtHall"
        Me.txtHall.pr_allow_mass_update = False
        Me.txtHall.pr_bound_tip = Nothing
        Me.txtHall.pr_boundto = "dvorana"
        Me.txtHall.pr_currencyDecimal = CType(2, Short)
        Me.txtHall.pr_iscurrency = False
        Me.txtHall.pr_locilo1000 = "."
        Me.txtHall.pr_RKBValue = ""
        Me.txtHall.pr_searchfield = Nothing
        Me.txtHall.pr_text = ""
        Me.txtHall.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.txtHall.Size = New System.Drawing.Size(201, 20)
        Me.txtHall.TabIndex = 174
        '
        'txtSemester
        '
        Me.txtSemester.BackColor = System.Drawing.Color.White
        Me.txtSemester.Enabled = False
        Me.txtSemester.Location = New System.Drawing.Point(170, 12)
        Me.txtSemester.Name = "txtSemester"
        Me.txtSemester.pr_allow_mass_update = False
        Me.txtSemester.pr_bound_tip = Nothing
        Me.txtSemester.pr_boundto = "semester"
        Me.txtSemester.pr_currencyDecimal = CType(2, Short)
        Me.txtSemester.pr_iscurrency = False
        Me.txtSemester.pr_locilo1000 = "."
        Me.txtSemester.pr_RKBValue = ""
        Me.txtSemester.pr_searchfield = Nothing
        Me.txtSemester.pr_text = ""
        Me.txtSemester.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.txtSemester.Size = New System.Drawing.Size(85, 20)
        Me.txtSemester.TabIndex = 172
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.White
        Me.txtYear.Enabled = False
        Me.txtYear.Location = New System.Drawing.Point(54, 12)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.pr_allow_mass_update = False
        Me.txtYear.pr_bound_tip = Nothing
        Me.txtYear.pr_boundto = "year_class"
        Me.txtYear.pr_currencyDecimal = CType(2, Short)
        Me.txtYear.pr_iscurrency = False
        Me.txtYear.pr_locilo1000 = "."
        Me.txtYear.pr_RKBValue = ""
        Me.txtYear.pr_searchfield = Nothing
        Me.txtYear.pr_text = ""
        Me.txtYear.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.txtYear.Size = New System.Drawing.Size(53, 20)
        Me.txtYear.TabIndex = 170
        '
        'txtLevel
        '
        Me.txtLevel.BackColor = System.Drawing.Color.White
        Me.txtLevel.Enabled = False
        Me.txtLevel.Location = New System.Drawing.Point(315, 38)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.pr_allow_mass_update = False
        Me.txtLevel.pr_bound_tip = Nothing
        Me.txtLevel.pr_boundto = "stopnja"
        Me.txtLevel.pr_currencyDecimal = CType(2, Short)
        Me.txtLevel.pr_iscurrency = False
        Me.txtLevel.pr_locilo1000 = "."
        Me.txtLevel.pr_RKBValue = ""
        Me.txtLevel.pr_searchfield = Nothing
        Me.txtLevel.pr_text = ""
        Me.txtLevel.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.txtLevel.Size = New System.Drawing.Size(118, 20)
        Me.txtLevel.TabIndex = 164
        '
        'txtInstructor
        '
        Me.txtInstructor.BackColor = System.Drawing.Color.White
        Me.txtInstructor.Enabled = False
        Me.txtInstructor.Location = New System.Drawing.Point(315, 12)
        Me.txtInstructor.Name = "txtInstructor"
        Me.txtInstructor.pr_allow_mass_update = False
        Me.txtInstructor.pr_bound_tip = Nothing
        Me.txtInstructor.pr_boundto = "instruktor"
        Me.txtInstructor.pr_currencyDecimal = CType(2, Short)
        Me.txtInstructor.pr_iscurrency = False
        Me.txtInstructor.pr_locilo1000 = "."
        Me.txtInstructor.pr_RKBValue = ""
        Me.txtInstructor.pr_searchfield = Nothing
        Me.txtInstructor.pr_text = ""
        Me.txtInstructor.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.txtInstructor.Size = New System.Drawing.Size(118, 20)
        Me.txtInstructor.TabIndex = 162
        '
        'Bct_DateTimePickerNullable1
        '
        Me.Bct_DateTimePickerNullable1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Bct_DateTimePickerNullable1.CustomFormat = "hh:mm"
        Me.Bct_DateTimePickerNullable1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Bct_DateTimePickerNullable1.Location = New System.Drawing.Point(54, 64)
        Me.Bct_DateTimePickerNullable1.Name = "Bct_DateTimePickerNullable1"
        Me.Bct_DateTimePickerNullable1.pr_allow_mass_update = False
        Me.Bct_DateTimePickerNullable1.pr_bound_tip = Nothing
        Me.Bct_DateTimePickerNullable1.pr_boundto = "pricetek"
        Me.Bct_DateTimePickerNullable1.pr_RKBValue = New Date(2009, 1, 20, 15, 37, 15, 171)
        Me.Bct_DateTimePickerNullable1.pr_searchfield = Nothing
        Me.Bct_DateTimePickerNullable1.Size = New System.Drawing.Size(96, 20)
        Me.Bct_DateTimePickerNullable1.TabIndex = 266
        Me.Bct_DateTimePickerNullable1.Value = New Date(2009, 1, 20, 15, 37, 15, 171)
        '
        'Bct_DateTimePickerNullable2
        '
        Me.Bct_DateTimePickerNullable2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Bct_DateTimePickerNullable2.CustomFormat = "hh:mm"
        Me.Bct_DateTimePickerNullable2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Bct_DateTimePickerNullable2.Location = New System.Drawing.Point(172, 65)
        Me.Bct_DateTimePickerNullable2.Name = "Bct_DateTimePickerNullable2"
        Me.Bct_DateTimePickerNullable2.pr_allow_mass_update = False
        Me.Bct_DateTimePickerNullable2.pr_bound_tip = Nothing
        Me.Bct_DateTimePickerNullable2.pr_boundto = "konec"
        Me.Bct_DateTimePickerNullable2.pr_RKBValue = New Date(2009, 1, 20, 15, 37, 15, 171)
        Me.Bct_DateTimePickerNullable2.pr_searchfield = Nothing
        Me.Bct_DateTimePickerNullable2.Size = New System.Drawing.Size(85, 20)
        Me.Bct_DateTimePickerNullable2.TabIndex = 267
        Me.Bct_DateTimePickerNullable2.Value = New Date(2009, 1, 20, 15, 37, 15, 171)
        '
        'ClassControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Bct_DateTimePickerNullable2)
        Me.Controls.Add(Me.Bct_DateTimePickerNullable1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEnota)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHall)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSemester)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInstructor)
        Me.Name = "ClassControl"
        Me.Size = New System.Drawing.Size(472, 97)
        Me.Controls.SetChildIndex(Me.txtInstructor, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtLevel, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtYear, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtSemester, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtHall, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.txtID, 0)
        Me.Controls.SetChildIndex(Me.txtEnota, 0)
        Me.Controls.SetChildIndex(Me.btnSelect, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtUNID, 0)
        Me.Controls.SetChildIndex(Me.Bct_DateTimePickerNullable1, 0)
        Me.Controls.SetChildIndex(Me.Bct_DateTimePickerNullable2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtLevel As RBWIN_gradnikiV8.bct_textbox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtInstructor As RBWIN_gradnikiV8.bct_textbox
    Public WithEvents txtYear As RBWIN_gradnikiV8.bct_textbox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtSemester As RBWIN_gradnikiV8.bct_textbox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtHall As RBWIN_gradnikiV8.bct_textbox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents txtID As RBWIN_gradnikiV8.bct_textbox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txtEnota As RBWIN_gradnikiV8.bct_textbox
    Friend WithEvents Bct_DateTimePickerNullable1 As RBWIN_gradnikiV8.bct_DateTimePickerNullable
    Friend WithEvents Bct_DateTimePickerNullable2 As RBWIN_gradnikiV8.bct_DateTimePickerNullable

End Class
