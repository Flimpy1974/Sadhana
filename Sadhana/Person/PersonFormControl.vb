Public Class PersonFormControl

    'Private Sub frmPerson_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Me.pr_cct_detail = PersonDataControl1
    '    ResizeToDefaultFormControl()
    '    RBWIN_gradnikiV8.std_funk_BIR.ResizeToDefault(Me)
    '    RBWIN_gradnikiV8.std_funk_BIR.ResizeToDefault(Me.pr_cct_detail)
    '    Me.Width = 634
    '    Me.Height = 356
    '    '  PersonDataControl1.Width = splitGridDetail.Width - splitGridDetail.SplitterDistance - splitGridDetail.SplitterWidth
    '    '  PersonDataControl1.Height = 106
    '    Filldata()
    '    'Me.splitMain.Panel1Collapsed = True
    '    dg.Focus()
    'End Sub


 
    'Public Overrides Sub ResizeToDefaultFormControl()

    '    splitGridDetail.Width = 626
    '    splitGridDetail.Height = 232
    '    splitGridDetail.SplitterDistance = splitGridDetail.Height - Me.pr_cct_detail.Height ' - 30
    '    splitGridDetail.IsSplitterFixed = True
    'End Sub

    'Public Overrides Sub Filldata()
    '    'pr_sqlWHERE = " WHERE 1 = 1 "
    '    'pr_sqlWHERE = pr_sqlWHERE + StringToSQLCondition(txtImeSearch.Text, "firstname")
    '    'pr_sqlWHERE = pr_sqlWHERE + StringToSQLCondition(txtPriimekSearch.Text, "lastname")

    '    MyBase.FillData()
    '    'ds.Tables(0).Columns("available").DefaultValue = True
    '    'ds.Tables(0).Columns("sortorder").DefaultValue = 0
    '    PersonDataControl1.ds = Me.ds
    '    PersonDataControl1.Bind()
    'End Sub

    Public Overrides Sub Filldata()
        MyBase.FillData()
        ' ds.Tables(0).Columns("available").DefaultValue = True
        'ds.Tables(0).Columns("sortorder").DefaultValue = 0
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Dim datarow As DataRow
        Dim objNewRecordCreator As RBWIN_gradnikiV8.NewRecordCreator = New RBWIN_gradnikiV8.NewRecordCreator
        objNewRecordCreator.DataControlName = "Sadhana." & "RegisteredClassDataControl" & ", Sadhana"
        objNewRecordCreator.FormControlName = "Sadhana." & "RegisteredClassFormControl" & ", Sadhana"

        objNewRecordCreator.LoadDs()
        Dim rcControl As RegisteredClassDataControl = CType(objNewRecordCreator.objDataControl, RegisteredClassDataControl)
        datarow = CType(Me.pr_cct_detail.myCurrencyManager.Current, DataRowView).Row
        objNewRecordCreator.ds.Tables(0).Rows(0)("guid_person") = datarow.Item("guid_person")
        objNewRecordCreator.ds.Tables(0).Rows(0)("charge_membership") = 0
        CType(rcControl.PersonControl1.txtIme.DataBindings(0).BindingManagerBase.Current, DataRowView).Row.Item("firstname") = datarow.Item("firstname")
        CType(rcControl.PersonControl1.txtPriimek.DataBindings(0).BindingManagerBase.Current, DataRowView).Row.Item("lastname") = datarow.Item("lastname")
        CType(rcControl.PersonControl1.dtpDatum.DataBindings(0).BindingManagerBase.Current, DataRowView).Row.Item("date_birth") = datarow.Item("date_birth")

        objNewRecordCreator.ShowDataForm(816, 193, "Vpis")
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.pr_cct_detail = PersonDataControl1
        'AddNewToolStripButton( 

        ' Add any initialization after the InitializeComponent() call.

    End Sub


End Class
