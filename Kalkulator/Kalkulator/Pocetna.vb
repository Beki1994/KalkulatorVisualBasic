Public Class Pocetna
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VerzijaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerzijaToolStripMenuItem.Click
        MsgBox("Druga Verzija", MsgBoxStyle.OkOnly, "Informacije o verziji")
    End Sub

    Private Sub JednostavniKalkulatorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles JednostavniKalkulatorToolStripMenuItem1.Click
        JednostavniKalkulator.Show()
    End Sub
End Class
