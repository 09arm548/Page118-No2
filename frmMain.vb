Public Class frmMain

    Private Sub btnDisplayAccountSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayAccountSummary.Click

        Dim sr As IO.StreamReader = IO.File.OpenText("Data.txt")
        ' Try

        ' Catch ex As Exception
        'MsgBox("sldkfj")
        ' End Try
        Dim strAcctnumber As String
        Dim dblPastdue As Double
        Dim dblPayment As Double
        Dim dblPurchases As Double
        Dim dblFinanceCharge As Double
        Dim dblAmtDue As Double

        strAcctnumber = sr.ReadLine
        dblPastdue = CDbl(sr.ReadLine)

        lstAccountSummary.Items.Add(strAcctnumber & " " & dblPastdue)


    End Sub
End Class
