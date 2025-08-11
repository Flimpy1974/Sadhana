Public Class GeneralFormControl

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.ToolStrip.Visible = False
        Me.splitMain.Panel1Collapsed = True

    End Sub
    Private Sub frmGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 634
        Me.Height = 356
        Filldata()
        'Me.splitMain.Panel1Collapsed = True
        dg.Focus()
    End Sub
    Public Overrides Sub ResizeToDefaultFormControl()
        splitGridDetail.Width = 626
        splitGridDetail.Height = 232
        splitGridDetail.SplitterDistance = splitGridDetail.Height - Me.btnClose.Height - 15
        splitGridDetail.IsSplitterFixed = True
    End Sub
   
   
End Class
