Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox1.Text = DateTime.Now.ToLongTimeString
        If CheckBox1.Checked = True Then
            If TextBox2.Text = TextBox1.Text Then
                My.Computer.Audio.Play(My.Resources.CPU, AudioPlayMode.BackgroundLoop)
            End If
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub
    Private Sub Rave_Alarm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub
    Private Sub Rave_alarm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox2.Text = DateTime.Now.ToLongTimeString
    End Sub
    Private Sub textbox2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox2.Text = DateTime.Now.ToLongTimeString
        If CheckBox1.Checked = True Then
            If TextBox1.Text = TextBox1.Text Then
                My.Computer.Audio.Play(My.Resources.CPU, AudioPlayMode.BackgroundLoop)
            End If
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If MessageBox.Show("Alarm made by rusty!" & vbNewLine & "simple type in your numbers in second text box" & vbNewLine & "and click the check button" & vbNewLine & "Inspired Bro FEMI.", "Alarm!", MessageBoxButtons.OK, _
            Nothing, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            System.Console.WriteLine("OK Clicked")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class