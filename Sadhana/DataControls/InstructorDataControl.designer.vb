<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorDataControl
    Inherits cct_detail

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstructorDataControl))
        Me.txtName = New RBWIN_gradnikiV8.bct_textbox
        Me.txtSort = New RBWIN_gradnikiV8.bct_textbox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CheckBox1 = New RBWIN_gradnikiV8.bct_checkbox
        Me.PersonControl1 = New Sadhana.PersonControl
        Me.ComboWithForm1 = New RBWIN_gradnikiV8.cct_ComboWithForm
        Me.MyCheckBox1 = New RBWIN_gradnikiV8.bct_checkbox
        Me.MyCheckBox2 = New RBWIN_gradnikiV8.bct_checkbox
        Me.CDateTimePickerEx1 = New RBWIN_gradnikiV8.bct_DateTimePickerNullable
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CDateTimePickerEx1)
        Me.Panel1.Controls.Add(Me.MyCheckBox2)
        Me.Panel1.Controls.Add(Me.MyCheckBox1)
        Me.Panel1.Controls.Add(Me.ComboWithForm1)
        Me.Panel1.Controls.Add(Me.PersonControl1)
        Me.Panel1.Size = New System.Drawing.Size(495, 138)
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(21, 13)
        Me.txtName.Name = "txtName"
        Me.txtName.pr_allow_mass_update = False
        Me.txtName.pr_bound_tip = Nothing
        Me.txtName.pr_boundto = "NAME"
        Me.txtName.pr_currencyDecimal = CType(2, Short)
        Me.txtName.pr_iscurrency = False
        Me.txtName.pr_locilo1000 = "."
        Me.txtName.pr_RKBValue = ""
        Me.txtName.pr_searchfield = Nothing
        Me.txtName.pr_text = ""
        Me.txtName.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.txtName.Size = New System.Drawing.Size(259, 20)
        Me.txtName.TabIndex = 4
        '
        'txtSort
        '
        Me.txtSort.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSort.BackColor = System.Drawing.Color.White
        Me.txtSort.Location = New System.Drawing.Point(194, 37)
        Me.txtSort.Name = "txtSort"
        Me.txtSort.pr_allow_mass_update = False
        Me.txtSort.pr_bound_tip = Nothing
        Me.txtSort.pr_boundto = "SORTORDER"
        Me.txtSort.pr_currencyDecimal = CType(2, Short)
        Me.txtSort.pr_iscurrency = False
        Me.txtSort.pr_locilo1000 = "."
        Me.txtSort.pr_RKBValue = ""
        Me.txtSort.pr_searchfield = Nothing
        Me.txtSort.pr_text = ""
        Me.txtSort.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.txtSort.Size = New System.Drawing.Size(86, 20)
        Me.txtSort.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ime"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Sort"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(39, 35)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.pr_allow_mass_update = False
        Me.CheckBox1.pr_bound_tip = Nothing
        Me.CheckBox1.pr_boundto = "available"
        Me.CheckBox1.pr_RKBValue = False
        Me.CheckBox1.pr_searchfield = Nothing
        Me.CheckBox1.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Na voljo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PersonControl1
        '
        Me.PersonControl1.BackColor = System.Drawing.Color.Transparent
        Me.PersonControl1.Location = New System.Drawing.Point(3, 27)
        Me.PersonControl1.Name = "PersonControl1"
        Me.PersonControl1.PersonID = ""
        Me.PersonControl1.pr_allow_mass_update = False
        Me.PersonControl1.pr_bound_tip = Nothing
        Me.PersonControl1.pr_boundto = "guid_person"
        Me.PersonControl1.pr_RKBValue = CType(resources.GetObject("PersonControl1.pr_RKBValue"), Object)
        Me.PersonControl1.pr_searchfield = Nothing
        Me.PersonControl1.pr_strFormControlName = "PersonFormControl"
        Me.PersonControl1.pr_strUNIDField = "guid_person"
        Me.PersonControl1.pr_UNID = CType(resources.GetObject("PersonControl1.pr_UNID"), Object)
        Me.PersonControl1.Size = New System.Drawing.Size(310, 103)
        Me.PersonControl1.TabIndex = 10
        '
        'ComboWithForm1
        '
        Me.ComboWithForm1.BackColor = System.Drawing.Color.Transparent
        Me.ComboWithForm1.Location = New System.Drawing.Point(350, 36)
        Me.ComboWithForm1.Name = "ComboWithForm1"
        Me.ComboWithForm1.pr_addEmptyRecord = False
        Me.ComboWithForm1.pr_addFormEnabled = True
        Me.ComboWithForm1.pr_allow_mass_update = False
        Me.ComboWithForm1.pr_bound_tip = Nothing
        Me.ComboWithForm1.pr_boundto = "ID_SUBSIDIARY"
        Me.ComboWithForm1.pr_DataSource = Nothing
        Me.ComboWithForm1.pr_DisplayMember = ""
        Me.ComboWithForm1.pr_FormObjectName = "frmSubsidiary"
        Me.ComboWithForm1.pr_RKBValue = Nothing
        Me.ComboWithForm1.pr_searchfield = Nothing
        Me.ComboWithForm1.pr_SelectedValue = Nothing
        Me.ComboWithForm1.pr_sqlSELECT = "select id_subsidiary, name from Subsidiary"
        Me.ComboWithForm1.pr_ValueMember = ""
        Me.ComboWithForm1.Size = New System.Drawing.Size(125, 25)
        Me.ComboWithForm1.TabIndex = 24
        '
        'MyCheckBox1
        '
        Me.MyCheckBox1.AutoSize = True
        Me.MyCheckBox1.Location = New System.Drawing.Point(306, 68)
        Me.MyCheckBox1.Name = "MyCheckBox1"
        Me.MyCheckBox1.pr_allow_mass_update = False
        Me.MyCheckBox1.pr_bound_tip = Nothing
        Me.MyCheckBox1.pr_boundto = "is_mentor"
        Me.MyCheckBox1.pr_RKBValue = False
        Me.MyCheckBox1.pr_searchfield = Nothing
        Me.MyCheckBox1.Size = New System.Drawing.Size(59, 17)
        Me.MyCheckBox1.TabIndex = 25
        Me.MyCheckBox1.Text = "Mentor"
        Me.MyCheckBox1.UseVisualStyleBackColor = True
        '
        'MyCheckBox2
        '
        Me.MyCheckBox2.AutoSize = True
        Me.MyCheckBox2.Location = New System.Drawing.Point(370, 68)
        Me.MyCheckBox2.Name = "MyCheckBox2"
        Me.MyCheckBox2.pr_allow_mass_update = False
        Me.MyCheckBox2.pr_bound_tip = Nothing
        Me.MyCheckBox2.pr_boundto = "is_active"
        Me.MyCheckBox2.pr_RKBValue = False
        Me.MyCheckBox2.pr_searchfield = Nothing
        Me.MyCheckBox2.Size = New System.Drawing.Size(62, 17)
        Me.MyCheckBox2.TabIndex = 26
        Me.MyCheckBox2.Text = "Aktiven"
        Me.MyCheckBox2.UseVisualStyleBackColor = True
        '
        'CDateTimePickerEx1
        '
        Me.CDateTimePickerEx1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CDateTimePickerEx1.Location = New System.Drawing.Point(351, 90)
        Me.CDateTimePickerEx1.Name = "CDateTimePickerEx1"
        Me.CDateTimePickerEx1.pr_allow_mass_update = False
        Me.CDateTimePickerEx1.pr_bound_tip = Nothing
        Me.CDateTimePickerEx1.pr_boundto = "date_entry"
        Me.CDateTimePickerEx1.pr_RKBValue = New Date(2009, 1, 22, 11, 48, 53, 984)
        Me.CDateTimePickerEx1.pr_searchfield = Nothing
        Me.CDateTimePickerEx1.Size = New System.Drawing.Size(126, 20)
        Me.CDateTimePickerEx1.TabIndex = 27
        Me.CDateTimePickerEx1.Value = New Date(2009, 1, 22, 11, 48, 53, 984)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(314, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "Enota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Datum"
        '
        'InstructorDataControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Name = "InstructorDataControl"
        Me.pr_GUID_FIELD = "GUID_instructor"
        Me.pr_ID_FIELD = "ID_instructor"
        Me.pr_TableName = "Instructor"
        Me.Size = New System.Drawing.Size(495, 138)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As RBWIN_gradnikiV8.bct_textbox
    Friend WithEvents txtSort As RBWIN_gradnikiV8.bct_textbox
    Friend WithEvents CheckBox1 As RBWIN_gradnikiV8.bct_checkbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PersonControl1 As Sadhana.PersonControl
    Friend WithEvents ComboWithForm1 As RBWIN_gradnikiV8.cct_ComboWithForm
    Friend WithEvents MyCheckBox2 As RBWIN_gradnikiV8.bct_checkbox
    Friend WithEvents MyCheckBox1 As RBWIN_gradnikiV8.bct_checkbox
    Friend WithEvents CDateTimePickerEx1 As RBWIN_gradnikiV8.bct_DateTimePickerNullable
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label


End Class
