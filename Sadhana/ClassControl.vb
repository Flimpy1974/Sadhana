Public Class ClassControl

    Public Property ClassID() As String
        Get
            Return txtID.Text
        End Get
        Set(ByVal Value As String)
            txtID.Text = Value
        End Set
    End Property

    Private Sub MyButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim mainForm As ClassFormControlContainer = New ClassFormControlContainer
        'mainForm.classFormControl1.EditMode = FormControl.FormControlMode.Pick
        'mainForm.Size = New System.Drawing.Size(751, 754)
        'mainForm.Icon = New Icon(Me.GetType(), "class.ico")
        'mainForm.ShowDialog()
        'If mainForm.classFormControl1.PickedDataRow IsNot Nothing Then
        '    txtID.Text = mainForm.classFormControl1.PickedDataRow.Item("id_class")
        '    txtLevel.Text = mainForm.classFormControl1.PickedDataRow.Item("stopnja")
        '    txtHall.Text = mainForm.classFormControl1.PickedDataRow.Item("dvorana")
        '    txtInstructor.Text = mainForm.classFormControl1.PickedDataRow.Item("Inštruktor")
        '    txtSemester.Text = mainForm.classFormControl1.PickedDataRow.Item("semester")
        '    txtYear.Text = mainForm.classFormControl1.PickedDataRow.Item("year_class")
        '    txtEnota.Text = mainForm.classFormControl1.PickedDataRow.Item("enota")
        '    dtpOd.Value = mainForm.classFormControl1.PickedDataRow.Item("time_start")
        '    dtpDo.Value = mainForm.classFormControl1.PickedDataRow.Item("time_end")
        'End If
    End Sub

    
    Private Sub CDateTimePickerEx5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ClassControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
