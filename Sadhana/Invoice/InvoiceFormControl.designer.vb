<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceFormControl
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
        Dim Std_MousePointer1 As RBWIN_gradnikiV8.std_MousePointer = New RBWIN_gradnikiV8.std_MousePointer
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Cct_multisearch1 = New RBWIN_gradnikiV8.cct_multisearch
        Me.Cct_multisearch2 = New RBWIN_gradnikiV8.cct_multisearch
        Me.InvoiceDataControl1 = New Sadhana.InvoiceDataControl
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
        Me.splitMain.Panel1.Controls.Add(Me.Cct_multisearch1)
        Me.splitMain.Panel1.Controls.Add(Me.Label5)
        Me.splitMain.Panel1.Controls.Add(Me.Label4)
        Me.splitMain.Size = New System.Drawing.Size(1040, 520)
        Me.splitMain.SplitterDistance = 48
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(484, 11)
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(507, 11)
        '
        'splitGridDetail
        '
        '
        'splitGridDetail.Panel1
        '
        Me.splitGridDetail.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'splitGridDetail.Panel2
        '
        Me.splitGridDetail.Panel2.Controls.Add(Me.InvoiceDataControl1)
        Me.splitGridDetail.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.splitGridDetail.Size = New System.Drawing.Size(1040, 468)
        Me.splitGridDetail.SplitterDistance = 153
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
        'Cct_multisearch1
        '
        Me.Cct_multisearch1.Location = New System.Drawing.Point(34, 10)
        Me.Cct_multisearch1.Name = "Cct_multisearch1"
        Me.Cct_multisearch1.pr_allow_mass_update = False
        Me.Cct_multisearch1.pr_bound_tip = "S"
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
        Me.Cct_multisearch2.pr_bound_tip = "S"
        Me.Cct_multisearch2.pr_boundto = Nothing
        Me.Cct_multisearch2.pr_ControlName = "RBWIN_gradnikiV8.bct_textbox"
        Me.Cct_multisearch2.pr_RKBValue = ""
        Me.Cct_multisearch2.pr_searchfield = "lastname"
        Me.Cct_multisearch2.Size = New System.Drawing.Size(225, 25)
        Me.Cct_multisearch2.TabIndex = 1039
        '
        'InvoiceDataControl1
        '
        Me.InvoiceDataControl1.BackColor = System.Drawing.Color.Transparent
        Me.InvoiceDataControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.InvoiceDataControl1.ds = Nothing
        Me.InvoiceDataControl1.Location = New System.Drawing.Point(0, 0)
        Me.InvoiceDataControl1.Mousepointer = Std_MousePointer1
        Me.InvoiceDataControl1.myCurrencyManager = Nothing
        Me.InvoiceDataControl1.Name = "InvoiceDataControl1"
        Me.InvoiceDataControl1.pr_GUID_FIELD = "GUID_Invoice"
        Me.InvoiceDataControl1.pr_ID_FIELD = "ID_Invoice"
        Me.InvoiceDataControl1.pr_IsAddNew = False
        Me.InvoiceDataControl1.pr_OracleIDSEQ = Nothing
        Me.InvoiceDataControl1.pr_TableName = "Invoice"
        Me.InvoiceDataControl1.pr_WSURL_KEY = Nothing
        Me.InvoiceDataControl1.Size = New System.Drawing.Size(1040, 308)
        Me.InvoiceDataControl1.TabIndex = 0
        '
        'InvoiceFormControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Name = "InvoiceFormControl"
        Me.pr_DataForm = "InvoiceDataform"
        Me.pr_ID_COLUMN_NAME = "ID_Invoice"
        Me.pr_sqlORDER = "order by Inv.date_rec_last_edited desc"
        Me.pr_sqlSELECT = "SELECT per.firstname, per.lastname, per.date_birth,inv.* from Invoice inv inner j" & _
            "oin person per on inv.guid_person=per.guid_person"
        Me.Size = New System.Drawing.Size(1040, 545)
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel1.PerformLayout()
        Me.splitMain.Panel2.ResumeLayout(False)
        Me.splitMain.ResumeLayout(False)
        Me.splitGridDetail.Panel2.ResumeLayout(False)
        Me.splitGridDetail.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cct_multisearch1 As RBWIN_gradnikiV8.cct_multisearch
    Friend WithEvents Cct_multisearch2 As RBWIN_gradnikiV8.cct_multisearch
    Friend WithEvents InvoiceDataControl1 As Sadhana.InvoiceDataControl

End Class
