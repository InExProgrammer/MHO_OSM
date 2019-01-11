Public Class Validation


    Sub ImageSave(ByVal picBox As Control, ByVal sPath As String)

        Const WM_PRINT As Integer = &H317

        Dim myBmp As Bitmap
        Dim myGraphics As Graphics
        Dim hdc As System.IntPtr

        myBmp = New Bitmap( _
            picBox.DisplayRectangle.Width, _
            picBox.DisplayRectangle.Height)



        myGraphics = Graphics.FromImage(myBmp)

        hdc = myGraphics.GetHdc

        Call SendMessage(picBox.Handle, WM_PRINT, hdc, _
            EDrawingOptions.PRF_CHILDREN Or _
            EDrawingOptions.PRF_CLIENT Or _
            EDrawingOptions.PRF_NONCLIENT Or _
            EDrawingOptions.PRF_OWNED)

        myGraphics.ReleaseHdc(hdc)
        myBmp.Save(sPath)
        myGraphics.Dispose()
        myGraphics = Nothing

        myBmp = Nothing
    End Sub

    Declare Auto Function SendMessage Lib "user32" ( _
            ByVal hWnd As IntPtr, _
            ByVal Msg As Integer, _
            ByVal wParam As IntPtr, _
            ByVal lParam As Integer) As Integer

    Private Enum EDrawingOptions As Integer
        PRF_CHECKVISIBLE = &H1
        PRF_NONCLIENT = &H2
        PRF_CLIENT = &H4
        PRF_ERASEBKGND = &H8
        PRF_CHILDREN = &H10
        PRF_OWNED = &H20
    End Enum

    Sub InputNumberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(13)) Or e.KeyChar = Convert.ToChar(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub InputDoubleOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal txt As TextBox)
        If (Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(13)) Or e.KeyChar = Convert.ToChar(8) Or e.KeyChar = Convert.ToChar(45) Or e.KeyChar = Convert.ToChar(46) Then
            If txt.Text.Contains(".") And e.KeyChar = Convert.ToChar(46) Then
                e.Handled = True
            Else
                e.Handled = False
            End If


        Else
            e.Handled = True
        End If
    End Sub

    Sub InputLetterNumberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz0123456789) (*.#$+_-"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Sub InputLetterOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Sub EnableWhenFilled(ByVal txt As TextBox, ByVal btn As Button)
    btn.Enabled = IIf(txt.Text = "", False, True)
    End Sub

    Function DecimalPlace(ByVal num As String, ByVal pl As Integer) As String
        Return FormatNumber(CDbl(num), pl)
    End Function

    Sub AcceptButton(ByVal txt As TextBox, ByVal btn As Button, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(13) Then
            btn.Focus()
        End If
    End Sub

    'Get the first day of the month
    Public Function FirstDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Return New DateTime(sourceDate.Year, sourceDate.Month, 1)
    End Function

    'Get the last day of the month
    Public Function LastDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Dim lastDay As DateTime = New DateTime(sourceDate.Year, sourceDate.Month, 1)
        Return lastDay.AddMonths(1).AddDays(-1)
    End Function

    Public Function isValid(ByVal str As String) As Boolean
        Dim pattern As String = "^[a-zA-Z\s]+$"
        Dim reg As New System.Text.RegularExpressions.Regex(pattern)
        Return reg.IsMatch(str)
    End Function
End Class

