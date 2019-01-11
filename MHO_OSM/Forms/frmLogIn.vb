Public Class frmLogIn
    Dim val As New Validation
    Dim con As New ConnectionAccess

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        Dim username As String = con.Search("SELECT userID from tbl_user where username='" + txtUserName.Text + "' and PASSWORDS='" + txtPASSWORD.Text + "'")
        If userName = "" Then
            MsgBox("Invalid Username or Password!", MsgBoxStyle.Exclamation)
        Else
            My.Settings.USERNAME = txtUserName.Text
            My.Settings.Save()
            Dim main As New frmStocks(username)
            main.Show()
            Me.Hide()
        End If



    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress, txtPassword.KeyPress
        val.InputLetterNumberOnly(e)
    End Sub

    Private Sub txtUserName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserName.KeyDown, txtPassword.KeyDown, btnLogin.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True 'this will prevent ding sound
    End Sub




    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged, txtPassword.TextChanged
        If txtUserName.Text <> "" And txtPassword.Text <> "" Then
            btnLogin.Enabled = True
        Else
            btnLogin.Enabled = False
        End If
    End Sub

    Private Sub frmLogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUserName.Text = My.Settings.USERNAME
    End Sub

    

    Private Sub frmLogIn_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Environment.Exit(1)
        Catch ex As Exception

        End Try
    End Sub
End Class