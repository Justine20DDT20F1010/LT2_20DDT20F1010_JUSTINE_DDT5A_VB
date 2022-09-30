'Name : Justine Nanggai
'Class : DDT5A
'LabTask : 2
' No Matrik " : 20DDT20F1010
Public Class login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        'if user do not enter username yet
        If txtusername.Text = "" And txtpsw.Text = "" Then
            MessageBox.Show("Please Enter Your Username And Password", " Login Page", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' In this line i'm set the password and username for student
        If txtusername.Text = "student" And txtpsw.Text = "student" Then
            MessageBox.Show("Success Login", " Login Page", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Student_Information.Show()
        End If


        ' In this line i'm set the password and username for teacher
        If txtusername.Text = "teacher" And txtpsw.Text = "teacher" Then
            MessageBox.Show("Success Login", " Login Page", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Student_Information.Show()
        End If


    End Sub
End Class
