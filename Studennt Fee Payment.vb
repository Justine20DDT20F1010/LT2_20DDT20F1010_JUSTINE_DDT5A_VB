'Name : Justine Nanggai
'Class : DDT5A
'LabTask : 2
'No Matrik " : 20DDT20F1010
Public Class Studennt_Fee_Payment

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Splash_Screen.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Print action
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        ' Declare the variable
        Dim yuran, insurans, total As Integer
        Const Hotel As Integer = 200
        If txtschoolfee.Text = "" And txtinsurans.Text = "" Then
            MessageBox.Show("Please enter school fee payment", "Instruction", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Else

            yuran = Integer.Parse(txtschoolfee.Text)
            insurans = Integer.Parse(txtinsurans.Text)

            'Calculate
            total = Val(yuran) + Val(insurans) + Hotel

            'Display the total in TextBox
            txtdisplay.Text = "Congratulations the total fee should you pay is RM :" & "   " & total
        End If




    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'Print page
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        'Close the form 
        Me.Close()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        'Save file
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        ' Open file
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtdisplay.Clear()
        txtschoolfee.Clear()
        txtinsurans.Clear()


    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show(" CALL : 01116065468 / EMAIL : BrightStarCompnay@gmail.com", "HELP")
    End Sub
End Class