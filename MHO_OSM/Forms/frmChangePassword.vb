Public Class frmChangePASSWORDS
    Dim con As New ConnectionAccess
    Dim val As New Validation
    Dim userID As String = ""

    Sub New(ByVal userID_ As String)
        InitializeComponent()
        userID = userID_
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dr As DialogResult = MsgBox("Are you sure you want to save this PASSWORDS?", MsgBoxStyle.YesNo)
        If dr = Windows.Forms.DialogResult.Yes Then
            If txtOldPASSWORDS.Text <> con.Search("SELECT PASSWORDS FROM TBL_USER WHERE USERID=" & userID) Then
                MsgBox("Old PASSWORDS is incorrect", MsgBoxStyle.Exclamation)
            ElseIf txtNewPASSWORDS.Text <> txtPASSWORDS.Text Then
                MsgBox("PASSWORDSs not match!", MsgBoxStyle.Exclamation)
            Else
                con.ExecuteQuery("UPDATE TBL_USER SET PASSWORDS='" + txtPASSWORDS.Text + "' WHERE USERID=" & userID)
                MsgBox("Succesfully Saved (You can now use your new Password after you log-out!)!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub txtPASSWORDS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPASSWORDS.KeyDown, txtOldPASSWORDS.KeyDown, txtNewPASSWORDS.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True 'this will prevent ding sound
    End Sub

    Private Sub txtPASSWORDS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPASSWORDS.KeyPress, txtOldPASSWORDS.KeyPress, txtNewPASSWORDS.KeyPress
        val.InputLetterNumberOnly(e)
    End Sub

    Private Sub frmChangePASSWORDS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "CHANGE PASSWORDS - " & con.Search("SELECT USERNAME FROM TBL_USER WHERE USERID=" & userID).ToUpper
    End Sub

    Private Sub txtOldPASSWORDS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPASSWORDS.TextChanged, txtOldPASSWORDS.TextChanged, txtNewPASSWORDS.TextChanged
        If txtOldPASSWORDS.Text.Trim(" ") = "" Or txtNewPASSWORDS.Text.Trim(" ") = "" Or txtPASSWORDS.Text.Trim(" ") = "" Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub
End Class