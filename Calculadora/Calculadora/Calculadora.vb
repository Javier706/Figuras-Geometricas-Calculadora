﻿Public Class Calculadora
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        TabControl1.SelectedTab = TabPage1
    End Sub



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



    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub calcular2_Click(sender As Object, e As EventArgs) Handles calcular2.Click

        Dim Lado1, Lado2, Resultado As Single
        Lado1 = txtlado1.Text
        Lado2 = txtlado2.Text
        Resultado = Lado1 * Lado2
        txtresult.Text = Resultado
    End Sub

    Private Sub limpiar2_Click(sender As Object, e As EventArgs) Handles limpiar2.Click

        txtlado1.Text = ""
        txtlado2.Text = ""
        txtresult.Text = ""
    End Sub

    Private Sub cerrar2_Click(sender As Object, e As EventArgs) Handles cerrar2.Click
        Close()
    End Sub

    Private Sub calcular3_Click(sender As Object, e As EventArgs) Handles calcular3.Click
        Dim Base, Altura, Resultado As Single
        Base = txtbase3.Text
        Altura = txtaltura3.Text
        Resultado = Base * Altura
        txtresultado3.Text = Resultado
    End Sub

    Private Sub limpiar3_Click(sender As Object, e As EventArgs) Handles limpiar3.Click
        txtbase3.Text = ""
        txtaltura3.Text = ""
        txtresultado3.Text = ""
    End Sub

    Private Sub cerrar3_Click(sender As Object, e As EventArgs) Handles cerrar3.Click
        Close()
    End Sub

    Private Sub txtRadio_TextChanged(sender As Object, e As EventArgs) Handles txtRadio.TextChanged

    End Sub

    Private Sub calcular4_Click(sender As Object, e As EventArgs) Handles calcular4.Click
        Dim Radio, Resultado As Single
        Radio = txtRadio.Text
        Resultado = 3.1416 * (Radio * Radio)
        txtresultado4.Text = Resultado
    End Sub

    Private Sub limpiar4_Click(sender As Object, e As EventArgs) Handles limpiar4.Click
        txtRadio.Text = ""
        txtresultado4.Text = ""
    End Sub

    Private Sub cerrar4_Click(sender As Object, e As EventArgs) Handles cerrar4.Click
        Close()
    End Sub

    Private Sub calcular5_Click(sender As Object, e As EventArgs) Handles calcular5.Click
        Dim BaseMayor, BaseMenor, Altura, Resultado As Single
        BaseMayor = txtBaseMayor.Text
        BaseMenor = txtBaseMenor.Text
        Altura = txtaltura5.Text

        Resultado = (BaseMayor + BaseMenor) * Altura / 2
        txtresultado5.Text = Resultado
    End Sub

    Private Sub limpiar5_Click(sender As Object, e As EventArgs) Handles limpiar5.Click
        txtBaseMayor.Text = ""
        txtBaseMenor.Text = ""
        txtaltura5.Text = ""
        txtresultado5.Text = ""
    End Sub

    Private Sub cerrar5_Click(sender As Object, e As EventArgs) Handles cerrar5.Click
        Close()
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        TxtBase.Text = ""
        TxtAltura.Text = ""
        TxtResultado.Text = ""
        txtlado1.Text = ""
        txtlado2.Text = ""
        txtresult.Text = ""
        txtbase3.Text = ""
        txtaltura3.Text = ""
        txtresultado3.Text = ""
        txtRadio.Text = ""
        txtresultado4.Text = ""
        txtBaseMayor.Text = ""
        txtBaseMenor.Text = ""
        txtaltura5.Text = ""
        txtresultado5.Text = ""

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Acerca_de.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class
