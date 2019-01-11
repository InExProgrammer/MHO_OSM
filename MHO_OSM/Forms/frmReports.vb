Public Class frmReports

    Dim con As New ConnectionAccess
    Dim reportType As String = ""


    Sub New(ByVal reportType_ As String)
        InitializeComponent()
        reportType = reportType_
    End Sub
    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If reportType = "ADDING" Then
            Me.Text = "SUMMARY OF RECEIVED STOCKS"
        Else
            Me.Text = "SUMMARY OF ISSUED STOCKS"
        End If
        loadTable()
    End Sub

    Sub loadTable()
        If reportType = "ADDING" Then
            con.View("SELECT  TBL_TRANSACTION.ISSUED_DATE AS DATE_RECEIVED,  TBL_TRANSACTION.ID, TBL_SUPPLIES.DESCRIPTIONS, TBL_TRANSACTION.QUANTITY, TBL_SUPPLIES.UOM,'OFFICE' AS AREA,TBL_TRANSACTION.ISSUED_TO AS RECEIVED_DATE, TBL_TRANSACTION.ISSUED_BY AS RECEIVED_BY,TBL_TRANSACTION.REMARKS FROM TBL_TRANSACTION INNER JOIN TBL_SUPPLIES ON TBL_TRANSACTION.ID = TBL_SUPPLIES.ID WHERE TYPE='" + reportType + "' AND ISSUED_DATE BETWEEN #" + dtpStart.Text + "# AND #" + dtpEnd.Text + "#;", dgvReport)
        Else
            con.View("SELECT  TBL_TRANSACTION.ISSUED_DATE,  TBL_TRANSACTION.ID, TBL_SUPPLIES.DESCRIPTIONS, TBL_TRANSACTION.QUANTITY, TBL_SUPPLIES.UOM, TBL_TRANSACTION.AREA,TBL_TRANSACTION.ISSUED_TO, TBL_TRANSACTION.ISSUED_BY,TBL_TRANSACTION.REMARKS FROM TBL_TRANSACTION INNER JOIN TBL_SUPPLIES ON TBL_TRANSACTION.ID = TBL_SUPPLIES.ID WHERE TYPE='" + reportType + "' AND ISSUED_DATE BETWEEN #" + dtpStart.Text + "# AND #" + dtpEnd.Text + "#;", dgvReport)
        End If
        lblCount.Text = "Count: " & dgvReport.Rows.Count
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        loadTable()
    End Sub
End Class