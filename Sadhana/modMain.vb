Module modMain
    'Public obj_std_funk_bir As std_funk_BIR = New std_funk_BIR
    'Public wsMy As TargetAudienceWebService

    Public Sub Main()
        Application.EnableVisualStyles()
        Application.VisualStyleState = VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled
        'Dim objdbDatabase As RBWIN_gradnikiV8.data = New RBWIN_gradnikiV8.data
      
        Dim form As frm_Explorer_New = New frm_Explorer_New
        form.ShowDialog()
    End Sub

End Module
