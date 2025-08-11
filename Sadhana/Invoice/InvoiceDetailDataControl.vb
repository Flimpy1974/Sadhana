Public Class InvoiceDetailDataControl

    Private Sub cboProduct_SelectionChanged(ByVal drv As System.Data.DataRowView) Handles cboProduct.SelectionChanged
        txtTax.Text = RBWIN_gradnikiV8.std_funk_BIR.NullToString(drv("tax_percent"))
        txtDescription.Text = RBWIN_gradnikiV8.std_funk_BIR.NullToString(drv("Description"))
        txtPrice.Text = RBWIN_gradnikiV8.std_funk_BIR.NullToString(drv("Price"))
        txtDiscount.Text = RBWIN_gradnikiV8.std_funk_BIR.NullToString(drv("Discount"))
    End Sub
End Class
