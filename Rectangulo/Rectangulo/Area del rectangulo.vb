Public Class Form1
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim Base, Altura, Resultado As Single
        Base = txtBase.Text
        Altura = txtAltura.Text
        Resultado = Base * Altura
        txtResultado.Text = Resultado

    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        txtBase.Text = ""
        txtAltura.Text = ""
        txtResultado.Text = ""

    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Close()
    End Sub
End Class
