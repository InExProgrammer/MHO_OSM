Public Class frmStocks

    Dim con As New ConnectionAccess
    Dim val As New Validation
    Public Shared userID As String = ""
    Public Shared userName As String = ""
    Dim logIn As New frmLogIn

    Private Sub frmStocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loader("")
        userName = con.Search("SELECT USERNAME FROM TBL_USER WHERE USERID=" & userID).ToUpper
        UserToolStripMenuItem.Text = "User - " & userName

    End Sub
    Sub New(ByVal userID_ As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        userID = userID_
    End Sub

    Sub loader(ByVal where As String)
        txtStock.Text = Double.Parse(con.Search("SELECT TOP 1 ID FROM TBL_SUPPLIES ORDER BY ID DESC ")) + 1
        con.View("SELECT ID,DESCRIPTIONS,'' AS QUANTITY,UOM,ENCODED_BY,ENCODED_DATE FROM TBL_SUPPLIES " & where & " ORDER BY ID DESC", dgvStock)
        'Me.Refresh()
        Dim dsAdded As DataSet = con.ManualView("SELECT ID,SUM(TBL_TRANSACTION.QUANTITY) AS QTY FROM TBL_TRANSACTION WHERE TYPE='ADDING' GROUP BY ID")
        Dim dsIssuing As DataSet = con.ManualView("SELECT ID,SUM(TBL_TRANSACTION.QUANTITY) AS QTY FROM TBL_TRANSACTION WHERE TYPE='ISSUING' GROUP BY ID")
        For n As Integer = 0 To dgvStock.Rows.Count - 1

            Dim added As String = ""
            Dim subtracted As String = ""

            For addeds As Integer = 0 To dsAdded.Tables(0).Rows.Count - 1
                If dsAdded.Tables(0).Rows(addeds)("ID") = dgvStock.Rows(n).Cells("ID").Value.ToString Then
                    added = dsAdded.Tables(0).Rows(addeds)("QTY")
                End If
            Next

            For subtracts As Integer = 0 To dsIssuing.Tables(0).Rows.Count - 1
                If dsIssuing.Tables(0).Rows(subtracts)("ID") = dgvStock.Rows(n).Cells("ID").Value.ToString Then
                    subtracted = dsIssuing.Tables(0).Rows(subtracts)("QTY")
                End If
            Next
            
            If added = "" Then
                added = "0"
            End If
            If subtracted = "" Then
                subtracted = "0"
            End If

            dgvStock.Rows(n).Cells("QUANTITY").Value = (Double.Parse(added) - Double.Parse(subtracted)).ToString.PadLeft(2, "0")
        Next
        lblCount.Text = "Item Count: " & dgvStock.RowCount
        dgvStock.Columns(0).Width = 50
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        loader("WHERE DESCRIPTIONS LIKE '%" + txtSearch.Text + "%'")
    End Sub

 
    Private Sub dgvStock_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStock.CellDoubleClick
      
        Dim frmRegister As New frmTransaction(dgvStock.Rows(e.RowIndex).Cells("ID").Value.ToString, dgvStock.Rows(e.RowIndex).Cells("DESCRIPTIONS").Value.ToString)
        Select Case frmRegister.ShowDialog()
            Case Windows.Forms.DialogResult.Cancel
                loader("")
                txtSearch.Text = ""
        End Select
    End Sub

    Private Sub txtDescription_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown, txtQty.KeyDown, txtDescription.KeyDown, txtRemarks.KeyDown, btnAdd.KeyDown, dtpAdded.KeyDown, txtUOM.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True 'this will prevent ding sound
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtDescription.Text.Trim("") = "" Or txtQty.Text = "" Then
            MsgBox("Description and Quantity fields are required!", MsgBoxStyle.Exclamation)
        Else
            Dim dr As DialogResult = MsgBox("Are you sure you want to save this Item?", MsgBoxStyle.YesNo)
            If dr = Windows.Forms.DialogResult.Yes Then
                con.ExecuteQuery("INSERT INTO TBL_SUPPLIES (DESCRIPTIONS,UOM,ENCODED_BY,ENCODED_DATE) VALUES ('" + txtDescription.Text + "','" + txtUOM.Text + "','" + userName + "','" + Date.Now.ToString + "')")
                Dim lastID As String = con.Search("SELECT TOP 1 ID FROM TBL_SUPPLIES ORDER BY ID DESC ")
                con.ExecuteQuery("INSERT INTO TBL_TRANSACTION (ID,ISSUED_DATE,REMARKS,ENCODED_BY,ENCODED_DATE,TYPE,QUANTITY) VALUES (" + lastID + ",'" + dtpAdded.Value.ToShortDateString + "','" + txtRemarks.Text + "','" + userName + "','" + Date.Now.ToString + "','ADDING','" + txtQty.Text + "')")
                MsgBox("Succesfully Saved!", MsgBoxStyle.Information)
                txtDescription.Text = ""
                txtQty.Text = ""
                txtUOM.Text = ""
                txtRemarks.Text = ""
                loader("")
            End If
        End If
    End Sub

    Private Sub frmStocks_KeyPress(ByVal KeyAscii As Integer)
        If KeyAscii = 39 Then KeyAscii = 0
    End Sub


    Private Sub txtDescription_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescription.KeyPress, txtRemarks.KeyPress, txtSearch.KeyPress, txtUOM.KeyPress
        val.InputLetterNumberOnly(e)
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        val.InputNumberOnly(e)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click

        Me.Hide()
        logIn.Show()
    End Sub

    
  Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim changePASSWORDS As New frmChangePASSWORDS(userID)
        changePASSWORDS.ShowDialog()
    End Sub

    Private Sub StocksAddedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StocksAddedToolStripMenuItem.Click
        Dim added As New frmReports("ADDING")
        added.ShowDialog()
    End Sub

    Private Sub StocksIssuedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StocksIssuedToolStripMenuItem.Click
        Dim added As New frmReports("ISSUING")
        added.ShowDialog()
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Try
            Dim app As Object
            Dim xlbook As Object
            Dim xlsheet As Object
            app = CreateObject("Excel.Application")
            xlbook = app.Workbooks.Add()
            xlsheet = xlbook.ActiveSheet
            app.Visible = True
            With xlbook
                .Sheets("Sheet1").Name = "REPORT"
            End With

            Dim iX As Integer
            Dim iY As Integer
            Dim iC As Integer
            Dim iz As Integer
            For iC = 0 To dgvStock.Columns.Count - 1
                xlsheet.Cells(1, iC + 1).Value = dgvStock.Columns(iC).HeaderText
            Next
            iz = 1
            For iX = 0 To dgvStock.Rows.Count - 1
                For iY = 0 To dgvStock.Columns.Count - 1
                    Dim a As String = dgvStock(iY, iX).Value
                    If a <> Nothing Then xlsheet.Cells(iz + 1, iY + 1).value = dgvStock(iY, iX).Value.ToString
                Next
                iz = iz + 1
            Next
            xlsheet.Range("A1:F1").Font.Name = "Arial Narrow"
            xlsheet.Range("A1:F1").Font.Bold = True
            MsgBox("Export Done", MsgBoxStyle.Information, "Office Supplies Monitoring")

            app.Visible = True
            app.UserControl = True
            releaseobject(app)
            releaseobject(xlbook)
            releaseobject(xlsheet)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub releaseobject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        End Try
    End Sub



    Private Sub frmStocks_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try

            'Dim response As MsgBoxResult
            'response = MsgBox("Do you want to close?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
            'If response = MsgBoxResult.Yes Then
            '    Me.Dispose()
            '    Application.Exit()
            'ElseIf response = MsgBoxResult.No Then
            e.Cancel = True
            Me.WindowState = FormWindowState.Minimized

            '    Exit Sub
            'End If
        Catch ex As Exception
            Application.Exit()
        End Try
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Excel files |*.xls;*.xlsx"
        dialog.InitialDirectory = "C:\"
        dialog.Title = "Veuillez sélectionner le fichier à importer"
        'Encrypt the selected file. I'll do this later. :)
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim dt As DataTable
            dt = ImportExceltoDatatable(dialog.FileName)
            dgvUpload.DataSource = dt
            dgvUpload.Visible = True
            MsgBox(" done ! ", MsgBoxStyle.Information)
        End If
    End Sub
    Public Shared Function ImportExceltoDatatable(ByVal filepath As String) As DataTable
        ' string sqlquery= "Select * From [SheetName$] Where YourCondition";
        Dim dt As New DataTable
        Try
            Dim ds As New DataSet()
            Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & filepath & ";Extended Properties=""Excel 12.0;HDR=YES;"""
            Dim con As New OleDb.OleDbConnection(constring & "")

            con.Open()

            Dim myTableName = con.GetSchema("Tables").Rows(0)("TABLE_NAME")
            Dim sqlquery As String = String.Format("SELECT * FROM [{0}]", myTableName) ' "Select * From " & myTableName  
            Dim da As New OleDb.OleDbDataAdapter(sqlquery, con)
            da.Fill(ds)
            dt = ds.Tables(0)
            Return dt
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical)
            Return dt
        End Try
    End Function
End Class
