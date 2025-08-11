<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceDetailFormControl
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
        Dim Std_MousePointer1 As RBWIN_gradnikiV8.std_MousePointer = New RBWIN_gradnikiV8.std_MousePointer
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvoiceDetailFormControl))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.InvoiceDetailDataControl1 = New Sadhana.InvoiceDetailDataControl
        Me.splitMain.Panel1.SuspendLayout()
        Me.splitMain.Panel2.SuspendLayout()
        Me.splitMain.SuspendLayout()
        Me.splitGridDetail.Panel2.SuspendLayout()
        Me.splitGridDetail.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitMain
        '
        Me.splitMain.Panel1Collapsed = True
        Me.splitMain.Size = New System.Drawing.Size(549, 200)
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
        Me.splitGridDetail.Orientation = System.Windows.Forms.Orientation.Vertical
        '
        'splitGridDetail.Panel2
        '
        Me.splitGridDetail.Panel2.Controls.Add(Me.InvoiceDetailDataControl1)
        Me.splitGridDetail.Panel2.Controls.Add(Me.PictureBox1)
        Me.splitGridDetail.Size = New System.Drawing.Size(549, 200)
        Me.splitGridDetail.SplitterDistance = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(520, 200)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'InvoiceDetailDataControl1
        '
        Me.InvoiceDetailDataControl1.BackColor = System.Drawing.Color.Transparent
        Me.InvoiceDetailDataControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.InvoiceDetailDataControl1.ds = Nothing
        Me.InvoiceDetailDataControl1.Location = New System.Drawing.Point(0, 0)
        Me.InvoiceDetailDataControl1.Mousepointer = Std_MousePointer1
        Me.InvoiceDetailDataControl1.myCurrencyManager = Nothing
        Me.InvoiceDetailDataControl1.Name = "InvoiceDetailDataControl1"
        Me.InvoiceDetailDataControl1.pr_GUID_FIELD = "GUID_InvoiceDetail"
        Me.InvoiceDetailDataControl1.pr_ID_FIELD = "ID_InvoiceDetail"
        Me.InvoiceDetailDataControl1.pr_IsAddNew = False
        Me.InvoiceDetailDataControl1.pr_OracleIDSEQ = Nothing
        Me.InvoiceDetailDataControl1.pr_TableName = "InvoiceDetail"
        Me.InvoiceDetailDataControl1.pr_WSURL_KEY = Nothing
        Me.InvoiceDetailDataControl1.Size = New System.Drawing.Size(520, 157)
        Me.InvoiceDetailDataControl1.TabIndex = 0
        '
        'InvoiceDetailFormControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Name = "InvoiceDetailFormControl"
        Me.pr_DataForm = "InvoiceDetailDataform"
        Me.pr_ID_COLUMN_NAME = "ID_InvoiceDetail"
        Me.pr_sqlORDER = "order by date_rec_last_edited desc"
        Me.pr_sqlSELECT = resources.GetString("$this.pr_sqlSELECT")
        Me.Size = New System.Drawing.Size(549, 225)
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel2.ResumeLayout(False)
        Me.splitMain.ResumeLayout(False)
        Me.splitGridDetail.Panel2.ResumeLayout(False)
        Me.splitGridDetail.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents InvoiceDetailDataControl1 As Sadhana.InvoiceDetailDataControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
