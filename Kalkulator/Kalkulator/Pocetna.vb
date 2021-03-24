Public Class Pocetna
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VerzijaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerzijaToolStripMenuItem.Click
        MsgBox("Prva Verzija", MsgBoxStyle.MsgBoxHelp, "Informacije o verziji")
    End Sub

    Private Sub JednostavniKalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JednostavniKalkulatorToolStripMenuItem.Click
        JednostavniKalkulator.Show()
    End Sub
End Class
