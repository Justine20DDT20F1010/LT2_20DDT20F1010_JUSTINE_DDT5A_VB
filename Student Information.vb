'Name : Justine Nanggai
'Class : DDT5A
'LabTask : 2
'No Matrik " : 20DDT20F1010

Public Class Student_Information
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Splash_Screen.Show()
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        ' if user dont put input in form
        If txtage.Text = "" And txtemail.Text = "" And txtfathername.Text = "" And txticnumber.Text = "" And txtmothername.Text = "" And txtnum.Text = "" And txtstdname.Text = "" And txtaddress.Text = "" Then
            MessageBox.Show("Incomplete Form", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            MessageBox.Show("Complete", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Studennt_Fee_Payment.Show()
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtage.Clear()
        txtemail.Clear()
        txtfathername.Clear()
        txticnumber.Clear()
        txtstdname.Clear()
        txtnum.Clear()
        txtmothername.Clear()
        txtaddress.Clear()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show(" CALL : 01116065468 / EMAIL : BrightStarCompnay@gmail.com", "HELP")
    End Sub
End Class