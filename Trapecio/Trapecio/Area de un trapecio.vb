Public Class Form1
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim BaseMayor, BaseMenor, Altura, Resultado As Single
        BaseMayor = txtBaseMayor.Text
        BaseMenor = txtBaseMenor.Text
        Altura = txtAltura.Text

        Resultado = (BaseMayor + BaseMenor) * Altura / 2
        txtResultado.Text = Resultado


    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        txtBaseMayor.Text = ""
        txtBaseMenor.Text = ""
        txtAltura.Text = ""
        txtResultado.Text = ""
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Close()
    End Sub
End Class
