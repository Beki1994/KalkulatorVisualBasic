Public Class JednostavniKalkulator
    Dim zbrajanje1 As Double
    Dim zbrajanje2 As Double
    Dim rezzbra As Double
    Dim oduzimanje1 As Double
    Dim oduzimanje2 As Double
    Dim rezoduz As Double
    Dim mnozenje1 As Double
    Dim mnozenje2 As Double
    Dim rezmno As Double
    Dim djeljenje1 As Double
    Dim djeljenje2 As Double
    Dim rezdjelje As Double
    Private Sub btnZbrajanje_Click(sender As Object, e As EventArgs) Handles btnZbrajanje.Click
        zbrajanje1 = txtZbrajanje1.Text
        zbrajanje2 = txtZbrajanje2.Text

        rezzbra = zbrajanje1 + zbrajanje2

        txtRezZbra.Text = rezzbra
    End Sub

    Private Sub btnOduzimanje_Click(sender As Object, e As EventArgs) Handles btnOduzimanje.Click
        oduzimanje1 = txtOduzimanje1.Text
        oduzimanje2 = txtOduzimanje2.Text

        rezoduz = oduzimanje1 - oduzimanje2

        txtRezOdu.Text = rezoduz

    End Sub

    Private Sub btnMnozenje_Click(sender As Object, e As EventArgs) Handles btnMnozenje.Click
        mnozenje1 = txtMnozenje1.Text
        mnozenje2 = txtMnozenje2.Text

        rezmno = mnozenje1 * mnozenje2

        txtRezulMnozenje.Text = rezmno
    End Sub

    Private Sub btnDjeljenje_Click(sender As Object, e As EventArgs) Handles btnDjeljenje.Click
        djeljenje1 = txtDjeljenj1.Text
        djeljenje2 = txtDjeljenje2.Text

        rezdjelje = djeljenje1 / djeljenje2

        txtRezDjelje.Text = rezdjelje
    End Sub

    Private Sub btnIzracunaj_Click(sender As Object, e As EventArgs) Handles btnIzracunaj.Click
        zbrajanje1 = txtZbrajanje1.Text
        zbrajanje2 = txtZbrajanje2.Text

        rezzbra = zbrajanje1 + zbrajanje2

        txtRezZbra.Text = rezzbra

        oduzimanje1 = txtOduzimanje1.Text
        oduzimanje2 = txtOduzimanje2.Text

        rezoduz = oduzimanje1 - oduzimanje2

        txtRezOdu.Text = rezoduz

        mnozenje1 = txtMnozenje1.Text
        mnozenje2 = txtMnozenje2.Text

        rezmno = mnozenje1 * mnozenje2

        txtRezulMnozenje.Text = rezmno

        djeljenje1 = txtDjeljenj1.Text
        djeljenje2 = txtDjeljenje2.Text

        rezdjelje = djeljenje1 / djeljenje2

        txtRezDjelje.Text = rezdjelje
    End Sub

    Private Sub btnBrisi_Click(sender As Object, e As EventArgs) Handles btnBrisi.Click
        txtDjeljenj1.Text = ""
        txtDjeljenje2.Text = ""
        txtMnozenje1.Text = ""
        txtMnozenje2.Text = ""
        txtOduzimanje1.Text = ""
        txtOduzimanje2.Text = ""
        txtRezDjelje.Text = ""
        txtRezOdu.Text = ""
        txtRezulMnozenje.Text = ""
        txtRezZbra.Text = ""
        txtZbrajanje1.Text = ""
        txtZbrajanje2.Text = ""
    End Sub

    Private Sub PocetnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PocetnaToolStripMenuItem.Click
        Pocetna.Show()
    End Sub

    Private Sub VerzijaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerzijaToolStripMenuItem.Click
        MsgBox("Druga Verzija", MsgBoxStyle.OkOnly, "Informacije o verziji")
    End Sub
End Class