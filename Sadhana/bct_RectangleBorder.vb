


Public Class bct_RectangleBorder


    Public Property pr_BorderColor() As System.Drawing.Color
        Get
            Return Me.Panel1.BackColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            Me.Panel1.BackColor = Value
            Me.Panel2.BackColor = Value
            Me.Panel3.BackColor = Value
            Me.Panel4.BackColor = Value
        End Set
    End Property

    Private Sub myEnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled = False Then
            Me.pr_BorderColor = System.Drawing.Color.LightGray
        Else
            Me.pr_BorderColor = Color.Black
        End If
    End Sub
End Class
