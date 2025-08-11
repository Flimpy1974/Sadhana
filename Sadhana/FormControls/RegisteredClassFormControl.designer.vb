<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisteredClassFormControl
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisteredClassFormControl))
        Me.cboLocation = New RBWIN_gradnikiV8.cct_ComboWithForm
        Me.numLeto = New RBWIN_gradnikiV8.bct_NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboInstructor = New RBWIN_gradnikiV8.cct_ComboWithForm
        Me.cboLevel = New RBWIN_gradnikiV8.cct_ComboWithForm
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Cct_multisearch1 = New RBWIN_gradnikiV8.cct_multisearch
        Me.RegisteredClassDataControl1 = New Sadhana.RegisteredClassDataControl
        Me.splitMain.Panel1.SuspendLayout()
        Me.splitMain.Panel2.SuspendLayout()
        Me.splitMain.SuspendLayout()
        Me.splitGridDetail.Panel2.SuspendLayout()
        Me.splitGridDetail.SuspendLayout()
        CType(Me.numLeto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitMain
        '
        '
        'splitMain.Panel1
        '
        Me.splitMain.Panel1.Controls.Add(Me.Cct_multisearch1)
        Me.splitMain.Panel1.Controls.Add(Me.Label4)
        Me.splitMain.Panel1.Controls.Add(Me.Label5)
        Me.splitMain.Panel1.Controls.Add(Me.cboLocation)
        Me.splitMain.Panel1.Controls.Add(Me.numLeto)
        Me.splitMain.Panel1.Controls.Add(Me.Label3)
        Me.splitMain.Panel1.Controls.Add(Me.Label2)
        Me.splitMain.Panel1.Controls.Add(Me.cboInstructor)
        Me.splitMain.Panel1.Controls.Add(Me.cboLevel)
        Me.splitMain.Panel1.Controls.Add(Me.Label1)
        Me.splitMain.SplitterDistance = 66
        '
        'splitGridDetail
        '
        '
        'splitGridDetail.Panel2
        '
        Me.splitGridDetail.Panel2.Controls.Add(Me.RegisteredClassDataControl1)
        Me.splitGridDetail.Size = New System.Drawing.Size(1040, 411)
        Me.splitGridDetail.SplitterDistance = 78
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(490, 11)
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(513, 11)
        '
        'cboLocation
        '
        Me.cboLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboLocation.Location = New System.Drawing.Point(53, 37)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.pr_addEmptyRecord = True
        Me.cboLocation.pr_addFormEnabled = False
        Me.cboLocation.pr_allow_mass_update = False
        Me.cboLocation.pr_bound_tip = Nothing
        Me.cboLocation.pr_boundto = "GUID_LOCATION"
        Me.cboLocation.pr_DataSource = Nothing
        Me.cboLocation.pr_DisplayMember = ""
        Me.cboLocation.pr_FormObjectName = ""
        Me.cboLocation.pr_RKBValue = Nothing
        Me.cboLocation.pr_searchfield = Nothing
        Me.cboLocation.pr_SelectedValue = Nothing
        Me.cboLocation.pr_sqlSELECT = "select guid_location, name from Location"
        Me.cboLocation.pr_ValueMember = ""
        Me.cboLocation.Size = New System.Drawing.Size(125, 25)
        Me.cboLocation.TabIndex = 278
        '
        'numLeto
        '
        Me.numLeto.BackColor = System.Drawing.Color.White
        Me.numLeto.Location = New System.Drawing.Point(54, 12)
        Me.numLeto.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.numLeto.Minimum = New Decimal(New Integer() {32767, 0, 0, -2147483648})
        Me.numLeto.Name = "numLeto"
        Me.numLeto.pr_allow_mass_update = False
        Me.numLeto.pr_bound_tip = Nothing
        Me.numLeto.pr_boundto = "year_class"
        Me.numLeto.pr_RKBValue = "0"
        Me.numLeto.pr_searchfield = Nothing
        Me.numLeto.Size = New System.Drawing.Size(99, 20)
        Me.numLeto.TabIndex = 274
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(322, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 273
        Me.Label3.Text = "Stopnja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 271
        Me.Label2.Text = "Leto"
        '
        'cboInstructor
        '
        Me.cboInstructor.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboInstructor.Location = New System.Drawing.Point(215, 12)
        Me.cboInstructor.Name = "cboInstructor"
        Me.cboInstructor.pr_addEmptyRecord = True
        Me.cboInstructor.pr_addFormEnabled = False
        Me.cboInstructor.pr_allow_mass_update = False
        Me.cboInstructor.pr_bound_tip = Nothing
        Me.cboInstructor.pr_boundto = "GUID_Instructor"
        Me.cboInstructor.pr_DataSource = Nothing
        Me.cboInstructor.pr_DisplayMember = ""
        Me.cboInstructor.pr_FormObjectName = "frmInstructor"
        Me.cboInstructor.pr_RKBValue = Nothing
        Me.cboInstructor.pr_searchfield = Nothing
        Me.cboInstructor.pr_SelectedValue = Nothing
        Me.cboInstructor.pr_sqlSELECT = "select a.guid_instructor, b.firstname + "" ""+b.lastname as name  from instructor a" & _
            " inner join person  b on a.guid_person = b.guid_person"
        Me.cboInstructor.pr_ValueMember = ""
        Me.cboInstructor.Size = New System.Drawing.Size(125, 25)
        Me.cboInstructor.TabIndex = 269
        '
        'cboLevel
        '
        Me.cboLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboLevel.Location = New System.Drawing.Point(371, 12)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.pr_addEmptyRecord = True
        Me.cboLevel.pr_addFormEnabled = False
        Me.cboLevel.pr_allow_mass_update = False
        Me.cboLevel.pr_bound_tip = Nothing
        Me.cboLevel.pr_boundto = "GUID_LEVEL"
        Me.cboLevel.pr_DataSource = Nothing
        Me.cboLevel.pr_DisplayMember = ""
        Me.cboLevel.pr_FormObjectName = "frmLevel"
        Me.cboLevel.pr_RKBValue = Nothing
        Me.cboLevel.pr_searchfield = Nothing
        Me.cboLevel.pr_SelectedValue = Nothing
        Me.cboLevel.pr_sqlSELECT = "select guid_level, name from cat_level"
        Me.cboLevel.pr_ValueMember = ""
        Me.cboLevel.Size = New System.Drawing.Size(125, 25)
        Me.cboLevel.TabIndex = 272
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 270
        Me.Label1.Text = "Inštruktor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 281
        Me.Label5.Text = "Lokacija"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(164, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 283
        Me.Label4.Text = "Vaditelj"
        '
        'Cct_multisearch1
        '
        Me.Cct_multisearch1.Location = New System.Drawing.Point(216, 39)
        Me.Cct_multisearch1.Name = "Cct_multisearch1"
        Me.Cct_multisearch1.pr_allow_mass_update = False
        Me.Cct_multisearch1.pr_bound_tip = Nothing
        Me.Cct_multisearch1.pr_boundto = Nothing
        Me.Cct_multisearch1.pr_ControlName = "RBWIN_gradnikiV8.bct_textbox"
        Me.Cct_multisearch1.pr_RKBValue = ""
        Me.Cct_multisearch1.pr_searchfield = "firstname+lastname"
        Me.Cct_multisearch1.Size = New System.Drawing.Size(171, 25)
        Me.Cct_multisearch1.TabIndex = 1039
        '
        'RegisteredClassDataControl1
        '
        Me.RegisteredClassDataControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegisteredClassDataControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RegisteredClassDataControl1.ds = Nothing
        Me.RegisteredClassDataControl1.Location = New System.Drawing.Point(0, 0)
        Me.RegisteredClassDataControl1.myCurrencyManager = Nothing
        Me.RegisteredClassDataControl1.Name = "RegisteredClassDataControl1"
        Me.RegisteredClassDataControl1.pr_GUID_FIELD = "guid_registeredclass"
        Me.RegisteredClassDataControl1.pr_ID_FIELD = "ID_RegisteredClass"
        Me.RegisteredClassDataControl1.pr_IsAddNew = False
        Me.RegisteredClassDataControl1.pr_TableName = "RegisteredClass"
        Me.RegisteredClassDataControl1.Size = New System.Drawing.Size(1040, 194)
        Me.RegisteredClassDataControl1.TabIndex = 1
        '
        'RegisteredClassFormControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Name = "RegisteredClassFormControl"
        Me.pr_DataForm = "RegisteredClassDataform"
        Me.pr_ID_COLUMN_NAME = "id_registeredclass"
        Me.pr_sqlSELECT = resources.GetString("$this.pr_sqlSELECT")
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel1.PerformLayout()
        Me.splitMain.Panel2.ResumeLayout(False)
        Me.splitMain.ResumeLayout(False)
        Me.splitGridDetail.Panel2.ResumeLayout(False)
        Me.splitGridDetail.ResumeLayout(False)
        CType(Me.numLeto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegisteredClassDataControl1 As Sadhana.RegisteredClassDataControl
    Friend WithEvents numLeto As RBWIN_gradnikiV8.bct_NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboInstructor As RBWIN_gradnikiV8.cct_ComboWithForm
    Friend WithEvents cboLevel As RBWIN_gradnikiV8.cct_ComboWithForm
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboLocation As RBWIN_gradnikiV8.cct_ComboWithForm
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cct_multisearch1 As RBWIN_gradnikiV8.cct_multisearch

End Class
