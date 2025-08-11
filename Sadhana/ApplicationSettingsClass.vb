Public Class ApplicationSettingsClass
    Private mControlBackgroundColor As Color

    Public Sub New()
        Me.ControlBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
    End Sub
    Public Property ControlBackgroundColor() As Color
        Get
            Return mControlBackgroundColor
        End Get
        Set(ByVal Value As Color)
            mControlBackgroundColor = Value
        End Set
    End Property

End Class
