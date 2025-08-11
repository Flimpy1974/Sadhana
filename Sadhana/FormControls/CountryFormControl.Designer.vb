<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountryFormControl
    Inherits RBWIN_gradnikiV8.cct_search 'Sadhana.FormControl

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
        Me.CountryDataControl1 = New Sadhana.CountryDataControl
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
        'splitGridDetail
        '
        Me.splitGridDetail.Orientation = System.Windows.Forms.Orientation.Vertical
        '
        'splitGridDetail.Panel2
        '
        Me.splitGridDetail.Panel2.Controls.Add(Me.CountryDataControl1)
        '
        'CountryDataControl1
        '
        Me.CountryDataControl1.BackColor = System.Drawing.Color.Transparent
        Me.CountryDataControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CountryDataControl1.ds = Nothing
        Me.CountryDataControl1.Location = New System.Drawing.Point(0, 0)
        Me.CountryDataControl1.myCurrencyManager = Nothing
        Me.CountryDataControl1.Name = "CountryDataControl1"
        Me.CountryDataControl1.pr_GUID_FIELD = "GUID_COUNTRY"
        Me.CountryDataControl1.pr_ID_FIELD = "ID_COUNTRY"
        Me.CountryDataControl1.pr_IsAddNew = False
        Me.CountryDataControl1.pr_TableName = "cat_country"
        Me.CountryDataControl1.Size = New System.Drawing.Size(826, 150)
        Me.CountryDataControl1.TabIndex = 1
        '
        'CountryFormControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Name = "CountryFormControl"
        Me.pr_DataForm = "CountryDataform"
        Me.pr_ID_COLUMN_NAME = "ID_COUNTRY"
        Me.pr_sqlSELECT = "select * from cat_country"
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel2.ResumeLayout(False)
        Me.splitMain.ResumeLayout(False)
        Me.splitGridDetail.Panel2.ResumeLayout(False)
        Me.splitGridDetail.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CountryDataControl1 As Sadhana.CountryDataControl

End Class
