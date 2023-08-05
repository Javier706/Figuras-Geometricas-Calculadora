Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Limpiar2.Click
        txtLado1.Text = ""
        txtLado2.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar2.Click
        Close()
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular2.Click
        Dim Lado1, Lado2, Resultado As Single
        Lado1 = txtLado1.Text
        Lado2 = txtLado2.Text
        Resultado = Lado1 * Lado2
        txtResult.Text = Resultado
    End Sub

End Class
