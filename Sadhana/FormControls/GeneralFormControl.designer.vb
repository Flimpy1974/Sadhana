<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneralFormControl
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
        Me.btnClose = New RBWIN_gradnikiV8.bct_btn
        Me.splitMain.Panel1.SuspendLayout()
        Me.splitMain.Panel2.SuspendLayout()
        Me.splitMain.SuspendLayout()
        Me.splitGridDetail.Panel1.SuspendLayout()
        Me.splitGridDetail.Panel2.SuspendLayout()
        Me.splitGridDetail.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitMain
        '
        Me.splitMain.Size = New System.Drawing.Size(655, 481)
        '
        'splitGridDetail
        '
        '
        'splitGridDetail.Panel2
        '
        Me.splitGridDetail.Panel2.Controls.Add(Me.btnClose)
        Me.splitGridDetail.Size = New System.Drawing.Size(655, 431)
        '
        'dg
        '
        Me.dg.columnNames = New String(-1) {}
        Me.dg.columnWidths = New String(-1) {}
        Me.dg.Size = New System.Drawing.Size(655, 210)
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(484, 11)
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(507, 11)
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(6, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(91, 26)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Zapri"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GeneralFormControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.pr_DataForm = "GeneralDataform"
        Me.pr_ID_COLUMN_NAME = ""
        Me.Name = "GeneralFormControl"
        Me.Size = New System.Drawing.Size(655, 506)
        Me.pr_sqlSELECT = ""
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel2.ResumeLayout(False)
        Me.splitMain.ResumeLayout(False)
        Me.splitGridDetail.Panel1.ResumeLayout(False)
        Me.splitGridDetail.Panel2.ResumeLayout(False)
        Me.splitGridDetail.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As RBWIN_gradnikiV8.bct_btn
    'Friend WithEvents GeneralDataControl1 As Sadhana.GeneralDataControl

End Class
