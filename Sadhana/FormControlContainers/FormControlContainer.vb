Public Class FormControlContainer
    Public WithEvents objFormControl As Object

    'Private Sub RecordPicked() Handles objFormControl.RecordPicked
    '    Me.Close()
    'End Sub

    Private Sub FormControlContainer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            objFormControl.ResizeToDefaultFormControl()
        End If
    End Sub
End Class