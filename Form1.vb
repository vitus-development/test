Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet.FinansialInsightLogin' table. You can move, or remove it, as needed.
        Me.FinansialInsightLoginTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSet.FinansialInsightLogin)
        'TODO: This line of code loads data into the 'BrugerDatasæt.Bruger' table. You can move, or remove it, as needed.
        Me.BrugerTableAdapter.Fill(Me.BrugerDatasæt.Bruger)

    End Sub
End Class
