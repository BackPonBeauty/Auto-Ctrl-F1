Option Strict Off
Option Explicit On
Friend Class Form1
	Inherits System.Windows.Forms.Form

    'クラス名、キャプションから子ウィンドウのハンドルを取得
    Private Declare Function FindWindowEx Lib "user32.dll" Alias "FindWindowExA" (ByVal hwndParent As Integer, _
                                                                                  ByVal hwndChildAfter As Integer, _
                                                                                  ByVal lpClassName As String, _
                                                                                  ByVal lpWindowName As String) As Integer



    ' ウィンドウにメッセージを送る関数の宣言
    Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hWnd As Integer, _
                                                                                ByVal Msg As Integer, _
                                                                                ByVal wParam As Integer, _
                                                                                ByVal lParam As String) As Integer

    Private Const WM_IME_CHAR As Short = &H286S '文字コード送信
    Private Const WM_SETTEXT As Short = &HCS '文字列送信
    Public Const WM_CTRL As Short = &H17　　　　　　　　　　　　　'CTRL
    Public Const WM_F1 As Short = &H112　　　　　　　　　　　　'F1

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
            Command1.Text = "ON"
        Else
            Timer1.Enabled = False
            Command1.Text = "OFF"
        End If
    End Sub


    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_FormClosing(ByVal eventSender As System.Object, _
                                  ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        End
        eventArgs.Cancel = Cancel
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        SendKeys.Send("^{F1}") '[Alt] + [F1]
    End Sub
End Class