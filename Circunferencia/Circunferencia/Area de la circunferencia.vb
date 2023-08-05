Public Class Form1
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim Radio, Resultado As Single
        Radio = txtRadio.Text
        Resultado = 3.1416 * (Radio * Radio)
        txtResultado.Text = Resultado
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        txtRadio.Text = ""
        txtResultado.Text = ""
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Close()
    End Sub

End Class
