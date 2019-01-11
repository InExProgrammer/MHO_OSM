Public Class frmTransaction

    Dim stockID As Integer = 0
    Dim DESC As String = ""
    Dim con As New ConnectionAccess
    Dim val As New Validation
    Dim totalStock As Double = 0
    Dim transID As String = ""

    Sub New(ByVal ID_ As Int16, ByVal DESC_ As String)
        InitializeComponent()

        stockID = ID_
        DESC = DESC_

    End Sub
    Private Sub frmTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtStockID.Text = stockID
        txtDescription.Text = DESC
        cboArea.Text = "Office"
        dtpIssued.Value = Date.Now
        dtpAdded.Value = Date.Now
        txtIssuedBy.Text = frmStocks.userName
        loader()
        txtStockID.Select()

    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtDescription.Text.Trim("") = "" Or txtQTY.Text = "" Then
            MsgBox("Quantity field is required!", MsgBoxStyle.Exclamation)
        Else
            Dim dr As DialogResult = MsgBox("Are you sure you want to add quantity for this Item?", MsgBoxStyle.YesNo)
            If dr = Windows.Forms.DialogResult.Yes Then
                con.ExecuteQuery("INSERT INTO TBL_TRANSACTION (ID,ISSUED_DATE,REMARKS,ENCODED_BY,ENCODED_DATE,TYPE,QUANTITY) VALUES (" + txtStockID.Text + ",'" + dtpAdded.Value.ToShortDateString + "','" + txtRemarks.Text + "','" + frmStocks.userName + "','" + Date.Now.ToString + "','ADDING','" + txtQTY.Text + "')")
                MsgBox("Succesfully Saved!", MsgBoxStyle.Information)
                txtQTY.Text = ""
                txtRemarks.Text = ""
                loader()
            End If
        End If
    End Sub

    Sub loader()
        con.Options("SELECT DISTINCT ISSUED_TO FROM TBL_TRANSACTION", cbo, "ISSUED_TO", "ISSUED_TO")
        con.View("SELECT TBL_TRANSACTION.TYPE, TBL_TRANSACTION.QUANTITY, TBL_TRANSACTION.AREA, TBL_TRANSACTION.ISSUED_TO, TBL_TRANSACTION.ISSUED_BY, TBL_TRANSACTION.ISSUED_DATE, TBL_TRANSACTION.ENCODED_BY, TBL_TRANSACTION.ENCODED_DATE, TBL_TRANSACTION.REMARKS,TBL_TRANSACTION.TRANSACTION_ID FROM TBL_TRANSACTION WHERE (((TBL_TRANSACTION.ID)=" + txtStockID.Text + "))", dgvTransaction)
        'dgvTransaction.Columns(0).Visible = False
        totalStock = 0

        Dim Added As String = con.Search("SELECT SUM(TBL_TRANSACTION.QUANTITY) FROM TBL_TRANSACTION WHERE ID = " + txtStockID.Text + " AND TYPE='ADDING'").ToString
        Dim Issued As String = con.Search("SELECT SUM(TBL_TRANSACTION.QUANTITY) FROM TBL_TRANSACTION WHERE ID = " + txtStockID.Text + " AND TYPE='ISSUING'").ToString
        If Added = "" Then
            Added = "0"
        End If
        If Issued = "" Then
            Issued = "0"
        End If

        totalStock = Double.Parse(Added) - Double.Parse(Issued)
        lblAS.Text = "- Available Stock(s): " & totalStock
    End Sub

    Private Sub txtQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQTY.KeyPress, txtQTY2.KeyPress
        val.InputNumberOnly(e)
    End Sub

    Private Sub txtRemarks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRemarks.KeyPress, txtIssuedBy.KeyPress, txtIssuedTo.KeyPress, txtRemarks2.KeyPress, cbo.KeyPress
        val.InputLetterNumberOnly(e)
    End Sub

    Private Sub txtQTY_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRemarks.KeyDown, txtQTY.KeyDown, txtIssuedBy.KeyDown, txtIssuedTo.KeyDown, txtQTY2.KeyDown, txtRemarks2.KeyDown, dtpAdded.KeyDown, dtpIssued.KeyDown, cboArea.KeyDown, btnIssue.KeyDown, btnAdd.KeyDown, cbo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True 'this will prevent ding sound
    End Sub

    Private Sub btnIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssue.Click
        If txtDescription.Text.Trim("") = "" Or txtQTY2.Text = "" Or txtIssuedTo.Text = "" Or txtIssuedBy.Text = "" Then
            MsgBox("Issued by, Issued to, Quantity field is required!", MsgBoxStyle.Exclamation)
        ElseIf totalStock < txtQTY2.Text Then
            MsgBox("Not enough stocks!", MsgBoxStyle.Exclamation)
        Else
            Dim dr As DialogResult = MsgBox("Are you sure you want to add quantity for this Item?", MsgBoxStyle.YesNo)
            If dr = Windows.Forms.DialogResult.Yes Then
                con.ExecuteQuery("INSERT INTO TBL_TRANSACTION (ID,ISSUED_DATE,REMARKS,ENCODED_BY,ENCODED_DATE,TYPE,QUANTITY,AREA,ISSUED_TO,ISSUED_BY) VALUES (" + txtStockID.Text + ",'" + dtpIssued.Value.ToShortDateString + "','" + txtRemarks2.Text + "','" + frmStocks.userName + "','" + Date.Now.ToString + "','ISSUING','" + txtQTY2.Text + "','" + cboArea.Text + "','" + txtIssuedTo.Text + "','" + txtIssuedBy.Text + "')")
                MsgBox("Succesfully Saved!", MsgBoxStyle.Information)
                txtQTY2.Text = ""
                txtRemarks2.Text = ""
                txtIssuedTo.Text = ""
                txtIssuedBy.Text = ""
                loader()
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim dr As DialogResult = MsgBox("Are you sure you want to Delete this transaction? TRANSACTION ID:" & transID, MsgBoxStyle.YesNo)
        If dr = Windows.Forms.DialogResult.Yes Then
            con.ExecuteQuery("DELETE FROM TBL_TRANSACTION WHERE TRANSACTION_ID=" & transID)
            loader()
        End If
        btnRemove.Enabled = False
    End Sub

    Private Sub dgvTransaction_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTransaction.CellClick
        Try
            btnRemove.Enabled = True
            transID = dgvTransaction.Rows(e.RowIndex).Cells("TRANSACTION_ID").Value.ToString
        Catch ex As Exception

        End Try

    End Sub



    Private Sub txtQTY2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemarks2.Enter, txtQTY2.Enter, txtIssuedBy.Enter, dtpIssued.Enter, cboArea.Enter, cbo.Enter
        Issuance.BackColor = Color.LimeGreen
    End Sub

    Private Sub txtQTY2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemarks2.Leave, txtQTY2.Leave, txtIssuedBy.Leave, dtpIssued.Leave, cboArea.Leave, cbo.Leave
        Issuance.BackColor = Color.FromArgb(192, 255, 192)
    End Sub

    Private Sub txtRemarks_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemarks.Enter, txtQTY.Enter, dtpAdded.Enter
        Adding.BackColor = Color.LimeGreen
    End Sub

    Private Sub txtRemarks_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemarks.Leave, txtQTY.Leave, dtpAdded.Leave
        Adding.BackColor = Color.FromArgb(192, 255, 192)
    End Sub

    Private Sub cbo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo.TextChanged
        txtIssuedTo.Text = cbo.Text.Trim(" ")
    End Sub
End Class