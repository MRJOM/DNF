Public Class Form1
    Dim webResponse As String
    Dim loginCnt As Integer
    Dim ids(1000) As String
    Dim pws(1000) As String
    Dim nx(1000) As String

    Dim n As Long

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        web.Navigate("http://df.nexon.com")
        Do While web.ReadyState <> WebBrowserReadyState.Complete
            Application.DoEvents()
        Loop
        web.Navigate("http://df.nexon.com")
        Do While web.ReadyState <> WebBrowserReadyState.Complete
            Application.DoEvents()
        Loop

        readAccount()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next

        id.Text = ids(ListBox1.SelectedIndex)
        pw.Text = pws(ListBox1.SelectedIndex)

        login()

        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        loginCnt = loginCnt + 1

        If loginCnt = 3 Then
            web.Navigate("http://df.nexon.com/FRM/home/game/gamePlay.php")
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub login()

        web.Document.GetElementById("channel").SetAttribute("value", nx(ListBox1.SelectedIndex))
        web.Document.GetElementById("id").SetAttribute("value", id.Text)
        web.Document.GetElementById("pw").SetAttribute("value", pw.Text)
        Do While web.ReadyState <> WebBrowserReadyState.Complete
            Application.DoEvents()
        Loop
        Dim jsstrings As Object() = {"$('#loginForm').submit();"}
        web.Document.InvokeScript("eval", jsstrings)
        Do While web.ReadyState <> WebBrowserReadyState.Complete
            Application.DoEvents()
        Loop
        Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        End
    End Sub

    Private Sub readAccount()

        Dim fileReader As System.IO.StreamReader
        fileReader =
        My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath + "\data.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        n = stringReader

        ListBox1.Items.Clear()

        For i = 0 To n - 1

            ids(i) = fileReader.ReadLine()
            pws(i) = fileReader.ReadLine()
            nx(i) = fileReader.ReadLine()

            ListBox1.Items.Add("[" + nx(i) + "]" + ids(i))
        Next
        fileReader.Close()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim writer As System.IO.StreamWriter = New System.IO.StreamWriter(Application.StartupPath + "\data.txt")
        writer.WriteLine(n + 1)

        For i = 0 To n - 1
            writer.WriteLine(ids(i))
            writer.WriteLine(pws(i))
            writer.WriteLine(nx(i))
        Next

        writer.Write(TextBox1.Text + vbCrLf)
        writer.Write(TextBox2.Text + vbCrLf)
        If RadioButton3.Checked Then
            writer.Write("nx" + vbCrLf)
        Else
            writer.Write("df" + vbCrLf)
        End If

        writer.Close()

        readAccount()
    End Sub
End Class
