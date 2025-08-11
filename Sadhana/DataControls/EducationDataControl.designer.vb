<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EducationDataControl
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
        Me.txtName = New RBWIN_gradnikiV8.bct_textbox
        Me.txtSort = New RBWIN_gradnikiV8.bct_textbox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CheckBox1 = New RBWIN_gradnikiV8.bct_checkbox
        Me.Label4 = New System.Windows.Forms.Label
        Me.MyTextBox2 = New RBWIN_gradnikiV8.bct_textbox
        Me.MyCheckBox1 = New RBWIN_gradnikiV8.bct_checkbox
        Me.MyNumericUpDown1 = New RBWIN_gradnikiV8.bct_NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.MyNumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MyNumericUpDown1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.MyTextBox2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.MyCheckBox1)
        Me.Panel1.Size = New System.Drawing.Size(287, 109)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Naziv"
        '
        'MyTextBox2
        '
        Me.MyTextBox2.BackColor = System.Drawing.Color.White
        Me.MyTextBox2.Location = New System.Drawing.Point(41, 39)
        Me.MyTextBox2.Name = "MyTextBox2"
        Me.MyTextBox2.pr_allow_mass_update = False
        Me.MyTextBox2.pr_bound_tip = Nothing
        Me.MyTextBox2.pr_boundto = "NAME"
        Me.MyTextBox2.pr_currencyDecimal = CType(2, Short)
        Me.MyTextBox2.pr_iscurrency = False
        Me.MyTextBox2.pr_locilo1000 = "."
        Me.MyTextBox2.pr_RKBValue = ""
        Me.MyTextBox2.pr_searchfield = Nothing
        Me.MyTextBox2.pr_text = ""
        Me.MyTextBox2.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.MyTextBox2.Size = New System.Drawing.Size(238, 20)
        Me.MyTextBox2.TabIndex = 14
        '
        'MyCheckBox1
        '
        Me.MyCheckBox1.AutoSize = True
        Me.MyCheckBox1.Location = New System.Drawing.Point(41, 64)
        Me.MyCheckBox1.Name = "MyCheckBox1"
        Me.MyCheckBox1.pr_allow_mass_update = False
        Me.MyCheckBox1.pr_bound_tip = Nothing
        Me.MyCheckBox1.pr_boundto = "available"
        Me.MyCheckBox1.pr_RKBValue = False
        Me.MyCheckBox1.pr_searchfield = Nothing
        Me.MyCheckBox1.Size = New System.Drawing.Size(65, 17)
        Me.MyCheckBox1.TabIndex = 16
        Me.MyCheckBox1.Text = "Na voljo"
        Me.MyCheckBox1.UseVisualStyleBackColor = True
        '
        'MyNumericUpDown1
        '
        Me.MyNumericUpDown1.BackColor = System.Drawing.Color.White
        Me.MyNumericUpDown1.Location = New System.Drawing.Point(181, 65)
        Me.MyNumericUpDown1.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.MyNumericUpDown1.Minimum = New Decimal(New Integer() {32767, 0, 0, -2147483648})
        Me.MyNumericUpDown1.Name = "MyNumericUpDown1"
        Me.MyNumericUpDown1.pr_allow_mass_update = False
        Me.MyNumericUpDown1.pr_bound_tip = Nothing
        Me.MyNumericUpDown1.pr_boundto = "sortorder"
        Me.MyNumericUpDown1.pr_RKBValue = "0"
        Me.MyNumericUpDown1.pr_searchfield = Nothing
        Me.MyNumericUpDown1.Size = New System.Drawing.Size(97, 20)
        Me.MyNumericUpDown1.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Sort"
        '
        'EducationDataControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Name = "EducationDataControl"
        Me.pr_GUID_FIELD = "GUID_Education"
        Me.pr_ID_FIELD = "ID_Education"
        Me.pr_TableName = "cat_Education"
        Me.Size = New System.Drawing.Size(287, 109)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MyNumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As RBWIN_gradnikiV8.bct_textbox
    Friend WithEvents txtSort As RBWIN_gradnikiV8.bct_textbox
    Friend WithEvents CheckBox1 As RBWIN_gradnikiV8.bct_checkbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents MyTextBox2 As RBWIN_gradnikiV8.bct_textbox
    Friend WithEvents MyCheckBox1 As RBWIN_gradnikiV8.bct_checkbox
    Friend WithEvents MyNumericUpDown1 As RBWIN_gradnikiV8.bct_NumericUpDown
    Public WithEvents Label3 As System.Windows.Forms.Label


End Class
