Public Class ApplicationSpecialUtils
    Inherits RBWIN_gradnikiV8.std_ApplicationSpecialUtils

    Public Overrides Sub ModifyRecordAtSave(ByRef inp As DataRowView)
        If inp.Row.RowState = DataRowState.Added Or inp.Row.RowState = DataRowState.Detached Then
            inp.Row.Item("date_rec_entry") = Date.Now
        End If
        inp.Row.Item("date_rec_last_edited") = Date.Now
    End Sub


    'Public Overrides Sub Add()
    '    MyBase.Add()
    '    CType(myCurrencyManager.Current, DataRowView).Row.Item(mGUID_FIELD) = GenerateGUID()
    'End Sub

    'Private Function GenerateGUID() As String
    '    Return System.Guid.NewGuid.ToString()
    'End Function
End Class
