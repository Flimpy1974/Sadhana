<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductDataControl
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Bct_textbox1 = New RBWIN_gradnikiV8.bct_textbox
        Me.Label4 = New System.Windows.Forms.Label
        Me.MyTextBox2 = New RBWIN_gradnikiV8.bct_textbox
        Me.MyCheckBox1 = New RBWIN_gradnikiV8.bct_checkbox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Bct_textbox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.MyTextBox2)
        Me.Panel1.Controls.Add(Me.MyCheckBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Size = New System.Drawing.Size(338, 110)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 2008
        Me.Label5.Text = "Cena"
        '
        'Bct_textbox1
        '
        Me.Bct_textbox1.BackColor = System.Drawing.Color.White
        Me.Bct_textbox1.Location = New System.Drawing.Point(46, 58)
        Me.Bct_textbox1.Name = "Bct_textbox1"
        Me.Bct_textbox1.pr_allow_mass_update = False
        Me.Bct_textbox1.pr_bound_tip = Nothing
        Me.Bct_textbox1.pr_boundto = "price"
        Me.Bct_textbox1.pr_currencyDecimal = CType(2, Short)
        Me.Bct_textbox1.pr_iscurrency = False
        Me.Bct_textbox1.pr_locilo1000 = "."
        Me.Bct_textbox1.pr_RKBValue = ""
        Me.Bct_textbox1.pr_searchfield = Nothing
        Me.Bct_textbox1.pr_text = ""
        Me.Bct_textbox1.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.Bct_textbox1.Size = New System.Drawing.Size(129, 20)
        Me.Bct_textbox1.TabIndex = 2007
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 2006
        Me.Label4.Text = "Ime"
        '
        'MyTextBox2
        '
        Me.MyTextBox2.BackColor = System.Drawing.Color.White
        Me.MyTextBox2.Location = New System.Drawing.Point(46, 32)
        Me.MyTextBox2.Name = "MyTextBox2"
        Me.MyTextBox2.pr_allow_mass_update = False
        Me.MyTextBox2.pr_bound_tip = Nothing
        Me.MyTextBox2.pr_boundto = "description"
        Me.MyTextBox2.pr_currencyDecimal = CType(2, Short)
        Me.MyTextBox2.pr_iscurrency = False
        Me.MyTextBox2.pr_locilo1000 = "."
        Me.MyTextBox2.pr_RKBValue = ""
        Me.MyTextBox2.pr_searchfield = Nothing
        Me.MyTextBox2.pr_text = ""
        Me.MyTextBox2.pr_textAlignment = RBWIN_gradnikiV8.bct_textbox.enumAlignment.levo
        Me.MyTextBox2.Size = New System.Drawing.Size(259, 20)
        Me.MyTextBox2.TabIndex = 2004
        '
        'MyCheckBox1
        '
        Me.MyCheckBox1.AutoSize = True
        Me.MyCheckBox1.Location = New System.Drawing.Point(241, 60)
        Me.MyCheckBox1.Name = "MyCheckBox1"
        Me.MyCheckBox1.pr_allow_mass_update = False
        Me.MyCheckBox1.pr_bound_tip = Nothing
        Me.MyCheckBox1.pr_boundto = "available"
        Me.MyCheckBox1.pr_RKBValue = False
        Me.MyCheckBox1.pr_searchfield = Nothing
        Me.MyCheckBox1.Size = New System.Drawing.Size(65, 17)
        Me.MyCheckBox1.TabIndex = 2005
        Me.MyCheckBox1.Text = "Na voljo"
        Me.MyCheckBox1.UseVisualStyleBackColor = True
        '
        'ProductDataControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Name = "ProductDataControl"
        Me.pr_GUID_FIELD = "GUID_Product"
        Me.pr_ID_FIELD = "ID_Product"
        Me.pr_TableName = "cat_Product"
        Me.Size = New System.Drawing.Size(338, 110)
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
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Bct_textbox1 As RBWIN_gradnikiV8.bct_textbox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents MyTextBox2 As RBWIN_gradnikiV8.bct_textbox
    Friend WithEvents MyCheckBox1 As RBWIN_gradnikiV8.bct_checkbox


End Class
