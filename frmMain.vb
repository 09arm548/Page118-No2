Public Class frmMain

    Private Sub btnDisplayAccountSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayAccountSummary.Click

        Dim sr As IO.StreamReader = IO.File.OpenText("..\..\Data.txt")
        Dim strFrmt1 As String = "{0, -15}{1, -15:c2}{2, -15:c2}{3, 15:c2}{4, 15:c2}{5, 15:c2}"
        Dim strAcctnumber As String
        Dim dblPastdue, dblPayment, dblPurchases, dblFinanceCharge, dblAmtDue As Double

        'add headings to the listbox
        lstAccountSummary.Items.Add(String.Format(strFrmt1, "Account", "Past Due", " ", " ", "Finance", "Current"))
        lstAccountSummary.Items.Add(String.Format(strFrmt1, "Number", "Amount", "Payments", "Purchases", "Charges", "Amount Due"))

        'read statement
        Do While Not sr.EndOfStream
            strAcctnumber = sr.ReadLine
            dblPastdue = CDbl(sr.ReadLine)
            dblPayment = CDbl(sr.ReadLine)
            dblPurchases = CDbl(sr.ReadLine)
            dblAmtDue = 0
            dblFinanceCharge = 0
            'compute
            If dblPastdue - dblPayment > 0 Then
                dblFinanceCharge = (dblPastdue - dblPayment) * 0.015
            End If
            'adds invoice info
            dblAmtDue = (dblPastdue - dblPayment) + dblPurchases + dblFinanceCharge
            lstAccountSummary.Items.Add(String.Format(strFrmt1, strAcctnumber, dblPastdue, dblPayment, dblPurchases, dblFinanceCharge, dblAmtDue))
        Loop

    End Sub

End Class