<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonFormControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonFormControl))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnRegister = New RBWIN_gradnikiV8.bct_btn
        Me.Cct_multisearch1 = New RBWIN_gradnikiV8.cct_multisearch
        Me.Cct_multisearch2 = New RBWIN_gradnikiV8.cct_multisearch
        Me.PersonDataControl1 = New Sadhana.PersonDataControl
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
        'splitMain.Panel1
        '
        Me.splitMain.Panel1.Controls.Add(Me.Cct_multisearch2)
        Me.splitMain.Panel1.Controls.Add(Me.btnRegister)
        Me.splitMain.Panel1.Controls.Add(Me.Cct_multisearch1)
        Me.splitMain.Panel1.Controls.Add(Me.Label5)
        Me.splitMain.Panel1.Controls.Add(Me.Label4)
        Me.splitMain.SplitterDistance = 48
        '
        'splitGridDetail
        '
        '
        'splitGridDetail.Panel2
        '
        Me.splitGridDetail.Panel2.Controls.Add(Me.PersonDataControl1)
        Me.splitGridDetail.Size = New System.Drawing.Size(1040, 429)
        Me.splitGridDetail.SplitterDistance = 240
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(484, 11)
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(507, 11)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Ime"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(205, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Priimek"
        '
        'btnRegister
        '
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Image = Global.Sadhana.My.Resources.Resources._class
        Me.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.Location = New System.Drawing.Point(588, 11)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(104, 23)
        Me.btnRegister.TabIndex = 286
        Me.btnRegister.Text = "Vpiši na vadbo"
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Cct_multisearch1
        '
        Me.Cct_multisearch1.Location = New System.Drawing.Point(34, 10)
        Me.Cct_multisearch1.Name = "Cct_multisearch1"
        Me.Cct_multisearch1.pr_allow_mass_update = False
        Me.Cct_multisearch1.pr_bound_tip = Nothing
        Me.Cct_multisearch1.pr_boundto = Nothing
        Me.Cct_multisearch1.pr_ControlName = "RBWIN_gradnikiV8.bct_textbox"
        Me.Cct_multisearch1.pr_RKBValue = ""
        Me.Cct_multisearch1.pr_searchfield = "firstname"
        Me.Cct_multisearch1.Size = New System.Drawing.Size(171, 25)
        Me.Cct_multisearch1.TabIndex = 1038
        '
        'Cct_multisearch2
        '
        Me.Cct_multisearch2.Location = New System.Drawing.Point(249, 11)
        Me.Cct_multisearch2.Name = "Cct_multisearch2"
        Me.Cct_multisearch2.pr_allow_mass_update = False
        Me.Cct_multisearch2.pr_bound_tip = Nothing
        Me.Cct_multisearch2.pr_boundto = Nothing
        Me.Cct_multisearch2.pr_ControlName = "RBWIN_gradnikiV8.bct_textbox"
        Me.Cct_multisearch2.pr_RKBValue = ""
        Me.Cct_multisearch2.pr_searchfield = "lastname"
        Me.Cct_multisearch2.Size = New System.Drawing.Size(225, 25)
        Me.Cct_multisearch2.TabIndex = 1039
        '
        'PersonDataControl1
        '
        Me.PersonDataControl1.BackColor = System.Drawing.Color.Transparent
        Me.PersonDataControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PersonDataControl1.ds = Nothing
        Me.PersonDataControl1.Location = New System.Drawing.Point(0, 0)
        Me.PersonDataControl1.myCurrencyManager = Nothing
        Me.PersonDataControl1.Name = "PersonDataControl1"
        Me.PersonDataControl1.pr_GUID_FIELD = "GUID_Person"
        Me.PersonDataControl1.pr_ID_FIELD = "ID_Person"
        Me.PersonDataControl1.pr_IsAddNew = False
        Me.PersonDataControl1.pr_TableName = "Person"
        Me.PersonDataControl1.Size = New System.Drawing.Size(1040, 177)
        Me.PersonDataControl1.TabIndex = 1
        '
        'PersonFormControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Name = "PersonFormControl"
        Me.pr_DataForm = "PersonDataform"
        Me.pr_ID_COLUMN_NAME = "ID_Person"
        Me.pr_sqlORDER = "order by person.date_rec_last_edited desc"
        Me.pr_sqlSELECT = resources.GetString("$this.pr_sqlSELECT")
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel1.PerformLayout()
        Me.splitMain.Panel2.ResumeLayout(False)
        Me.splitMain.ResumeLayout(False)
        Me.splitGridDetail.Panel2.ResumeLayout(False)
        Me.splitGridDetail.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PersonDataControl1 As Sadhana.PersonDataControl
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents btnRegister As RBWIN_gradnikiV8.bct_btn
    Friend WithEvents Cct_multisearch1 As RBWIN_gradnikiV8.cct_multisearch
    Friend WithEvents Cct_multisearch2 As RBWIN_gradnikiV8.cct_multisearch

End Class
