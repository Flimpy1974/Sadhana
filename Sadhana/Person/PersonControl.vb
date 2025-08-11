Public Class PersonControl

    Public Property PersonID() As String
        Get
            Return txtID.Text
        End Get
        Set(ByVal Value As String)
            txtID.Text = Value
        End Set
    End Property
    
End Class
