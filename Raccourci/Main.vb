Public Class Main
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://www.youtube.com")
    End Sub

    Private Sub QuitterAltF4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterAltF4ToolStripMenuItem.Click
        End
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("C:\Windows\System32\notepad.exe")
    End Sub

    Private Sub BlocNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocNoteToolStripMenuItem.Click
        Process.Start("C:\Windows\System32\notepad.exe")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("C:\Windows\System32\calc.exe")
    End Sub

    Private Sub CalculatriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatriceToolStripMenuItem.Click
        Process.Start("C:\Windows\System32\calc.exe")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Process.Start("https://www.gmail.com")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("https://www.instagram.com")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://www.twitter.com")
    End Sub

    Private Sub GmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GmailToolStripMenuItem.Click
        Process.Start("https://www.gmail.com")
    End Sub

    Private Sub InstagramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstagramToolStripMenuItem.Click
        Process.Start("https://www.instagram.com")
    End Sub

    Private Sub TwitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TwitterToolStripMenuItem.Click
        Process.Start("https://www.twitter.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Credits.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Process.Start("https://paypal.me/TSGAMEMING")
    End Sub

    Private Sub NotePadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotePadToolStripMenuItem.Click
        Process.Start("https://www.youtube.com")
    End Sub
End Class