Public Class InvoiceDataControl

    Public Overrides Sub SetControlsEnabledStatus(ByVal status As Boolean)
        MyBase.SetControlsEnabledStatus(status)
        'InvoiceDetailFormControl1.Enabled = True
    End Sub

    Public Overrides Sub cmPositionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If myCurrencyManager.Position <> -1 Then
            If myCurrencyManager.Current("guid_invoice") IsNot System.DBNull.Value Then
                InvoiceDetailFormControl1.pr_INVOICE_GUID = myCurrencyManager.Current("guid_invoice")
                InvoiceDetailFormControl1.Formload()
            End If
        End If
        'MsgBox(myCurrencyManager.Current("guid_invoice"))
    End Sub 'CurrencyManager_PositionChanged

    Public Overrides Sub Cancel()
        InvoiceDetailFormControl1.pr_cct_detail.cancel()
        MyBase.Cancel()
    End Sub
    
    
End Class
