Public Class sem4
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        view_list4.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If TextBox1.Text IsNot "" And ComboBox1.Text IsNot "" Then
            additional_info4.Show()
            Me.Hide()
        Else
            MessageBox.Show("CANNOT LEAVE THE ABOVE BOXES EMPTY")
        End If

    End Sub
End Class