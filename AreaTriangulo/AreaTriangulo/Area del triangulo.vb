Public Class Triangulo
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim Base, Altura, Resultado As Single
        Base = TxtBase.Text
        Altura = TxtAltura.Text
        Resultado = Base * Altura / 2
        TxtResultado.Text = Resultado
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        TxtBase.Text = ""
        TxtAltura.Text = ""
        TxtResultado.Text = ""
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Close()
    End Sub

End Class
