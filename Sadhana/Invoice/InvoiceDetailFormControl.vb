Public Class InvoiceDetailFormControl
    Private mINVOICE_GUID As String = ""
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.pr_cct_detail = InvoiceDetailDataControl1
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Overrides Sub Formload()
        Me.pr_cct_detail = InvoiceDetailDataControl1
        Me.ResizeToDefaultFormControl()
        If mINVOICE_GUID <> "" Then
            pr_sqlWHERE = "  guid_invoice = '" & mINVOICE_GUID & "'"
            MyBase.FormLoad()
        End If

    End Sub

    Public Property pr_INVOICE_GUID() As String
        Get
            Return mINVOICE_GUID
        End Get
        Set(ByVal value As String)
            mINVOICE_GUID = value
        End Set
    End Property

    Public Overrides Sub AddRecord()
        If mINVOICE_GUID <> "" Then
            MyBase.AddRecord()
            Me.pr_cct_detail.myCurrencyManager.current("guid_invoice") = mINVOICE_GUID
        End If
    End Sub

End Class
