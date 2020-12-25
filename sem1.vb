


Public Class Form2


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text IsNot "" And ComboBox1.Text IsNot "" Then

            ' comm.Connection = conn
            '  comm.CommandText = "Insert into sem1 ([Name of the project],[Subject]) VALUES ('" & Me.TextBox1.Text & "','" & Me.ComboBox1.Text & "')"
            '   comm.ExecuteNonQuery()


            additional_info.Show()
            Me.Hide()
        Else
            MessageBox.Show("CANNOT LEAVE THE ABOVE BOXES EMPTY")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        view_list.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



End Class