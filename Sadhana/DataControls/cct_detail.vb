Public Class cct_detail
    Private mGUID_FIELD As String
    'Public Overrides Sub Add()
    '    MyBase.Add()
    '    CType(myCurrencyManager.Current, DataRowView).Row.Item(mGUID_FIELD) = GenerateGUID()
    'End Sub

    Public Function GenerateGUID() As String
        Return System.Guid.NewGuid.ToString()
    End Function

    Public Property pr_GUID_FIELD() As String
        Get
            Return mGUID_FIELD
        End Get
        Set(ByVal value As String)
            mGUID_FIELD = value
        End Set
    End Property

    'Public Overrides Sub ModifyRecordAtSave(ByRef inp As DataRowView)
    '    MyBase.ModifyRecordAtSave(inp)
    '    If inp.Row.RowState = DataRowState.Added Or inp.Row.RowState = DataRowState.Detached Then
    '        inp.Row.Item(mGUID_FIELD) = GenerateGUID()
    '    End If
    'End Sub

    Public Overrides Sub Add()
        MyBase.Add()
        CType(myCurrencyManager.Current, DataRowView).Row.Item(mGUID_FIELD) = GenerateGUID()
    End Sub
End Class
