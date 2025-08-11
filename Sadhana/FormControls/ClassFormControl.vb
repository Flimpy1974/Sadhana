Public Class ClassFormControl
    ' test taras od doma

    Private Sub frmClass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.pr_cct_detail = ClassDataControl1
        RBWIN_gradnikiV8.std_funk_BIR.ResizeToDefault(Me)
        RBWIN_gradnikiV8.std_funk_BIR.ResizeToDefault(Me.pr_cct_detail)
        Me.Width = 634
        Me.Height = 356

        '  ClassDataControl1.Width = splitGridDetail.Width - splitGridDetail.SplitterDistance - splitGridDetail.SplitterWidth
        '  ClassDataControl1.Height = 106
        cboInstructor.MySQLComboBox1.Text = ""
        cboInstructor.MySQLComboBox1.SelectedItem = ""
        cboLevel.MySQLComboBox1.SelectedItem = ""
        numLeto.Value = Now.Year
        FillData()
        'Me.splitMain.Panel1Collapsed = True
        dg.Focus()
    End Sub



    'Public Overrides Sub Filldata()
    '    If Not Me.DesignMode Then
    '        'pr_sqlWHERE = " WHERE 1 = 1 "
    '        'pr_sqlWHERE = pr_sqlWHERE + StringToSQLCondition(ComboValueToSQLCondition(cboInstructor.MySQLComboBox1), "a.id_instructor")
    '        'pr_sqlWHERE = pr_sqlWHERE + StringToSQLCondition(ComboValueToSQLCondition(cboLevel.MySQLComboBox1), "a.id_level")
    '        'pr_sqlWHERE = pr_sqlWHERE + StringToSQLCondition(numLeto.Value, "a.year_class")

    '        'MyBase.FillData()
    '        ''ds.Tables(0).Columns("available").DefaultValue = True
    '        'ds.Tables(0).Columns("year_class").DefaultValue = Date.Now.Year
    '        'ds.Tables(0).Columns("max_registered").DefaultValue = 20
    '        'ClassDataControl1.ds = Me.ds
    '        'ClassDataControl1.Bind()
    '    End If
    'End Sub

    Public Overrides Sub CleanLimits()
        numLeto.Text = ""
        cboInstructor.MySQLComboBox1.Text = ""
        cboLevel.MySQLComboBox1.Text = ""
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        'Dim datarow As DataRow
        'Dim objNewRecordCreator As NewRecordCreator = New NewRecordCreator
        'objNewRecordCreator.DataControlName = "RegisteredClassDataControl"
        'objNewRecordCreator.FormControlName = "RegisteredClassFormControl"
        'objNewRecordCreator.LoadDs()
        'objNewRecordCreator.objDataForm.Icon = New Icon(Me.GetType(), "vpis.ico")
        'Dim rcControl As RegisteredClassDataControl = CType(objNewRecordCreator.objDataControl, RegisteredClassDataControl)
        'datarow = CType(Me.pr_cct_detail.myCurrencyManager.Current, DataRowView).Row
        'objNewRecordCreator.ds.Tables(0).Rows(0)("id_class") = datarow.Item("id_class")
        'rcControl.ClassControl1.txtInstructor.Text = datarow.Item("Inštruktor")
        'rcControl.ClassControl1.txtEnota.Text = datarow.Item("Enota")
        'rcControl.ClassControl1.txtHall.Text = datarow.Item("Dvorana")
        'rcControl.ClassControl1.txtSemester.Text = datarow.Item("Semester")
        'rcControl.ClassControl1.txtYear.Text = datarow.Item("year_class")
        'rcControl.ClassControl1.txtLevel.Text = datarow.Item("Stopnja")
        'objNewRecordCreator.ShowDataForm(816, 193, "Vpis")
    End Sub
End Class
