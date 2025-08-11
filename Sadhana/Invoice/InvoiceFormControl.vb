Public Class InvoiceFormControl
    Public Sub New()
        InitializeComponent()
        Me.pr_cct_detail = InvoiceDataControl1
    End Sub

    Public Overrides Sub FormLoad()
        'If System.ComponentModel.LicenseManager.UsageMode <> System.ComponentModel.LicenseUsageMode.Designtime Then
        'FormLoad()
        MyBase.FormLoad()
        If InvoiceDataControl1.myCurrencyManager.Position <> -1 Then
            InvoiceDataControl1.InvoiceDetailFormControl1.pr_INVOICE_GUID = InvoiceDataControl1.myCurrencyManager.Current("guid_invoice")
            'InvoiceDetailFormControl1.Formload()
            InvoiceDataControl1.InvoiceDetailFormControl1.Formload()
        End If

    End Sub

    Public Overrides Sub AddRecord()

        MyBase.AddRecord()
        CType(Me.pr_cct_detail, InvoiceDataControl).InvoiceDetailFormControl1.pr_INVOICE_GUID = Me.pr_cct_detail.myCurrencyManager.current("guid_invoice")
        CType(Me.pr_cct_detail, InvoiceDataControl).InvoiceDetailFormControl1.Formload()
    End Sub
End Class
