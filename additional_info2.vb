Imports System.Data.OleDb

Public Class additional_info2

    Dim conn As New OleDbConnection
    Dim comm As New OleDb.OleDbCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer

        If TextBox4.Text.Length <= 5 Then

            MessageBox.Show("Incorrect Roll no of leader")

        End If

        If TextBox3.Text.Length <= 9 Then
            MessageBox.Show("Incorrect Phone number of leader")
        End If

        If TextBox1.Text.Length <= 5 And TextBox1.Text.Length > 0 Then

            MessageBox.Show("Incorrect Roll no of T1")
            GoTo Check
        End If

        If TextBox5.Text.Length <= 9 And TextBox5.Text.Length > 0 Then
            MessageBox.Show("Incorrect Phone number of T1")
            GoTo Check
        End If

        If TextBox6.Text.Length <= 5 And TextBox6.Text.Length > 0 Then

            MessageBox.Show("Incorrect Roll no of T2")
            GoTo Check
        End If

        If TextBox7.Text.Length <= 9 And TextBox7.Text.Length > 0 Then
            MessageBox.Show("Incorrect Phone number of T2")
            GoTo Check
        End If

        If TextBox8.Text.Length <= 5 And TextBox8.Text.Length > 0 Then

            MessageBox.Show("Incorrect Roll no of T3")
            GoTo Check
        End If

        If TextBox9.Text.Length <= 5 And TextBox9.Text.Length > 0 Then
            MessageBox.Show("Incorrect Phone number of T3")
            GoTo Check
        End If

        If TextBox2.Text.Length <= 5 And TextBox2.Text.Length > 0 Then

            MessageBox.Show("Incorrect Roll no of T4")
            GoTo Check
        End If

        If TextBox10.Text.Length <= 9 And TextBox10.Text.Length > 0 Then
            MessageBox.Show("Incorrect Phone number of T4")
            GoTo Check
        End If

        If TextBox11.Text.Length <= 5 And TextBox11.Text.Length > 0 Then

            MessageBox.Show("Incorrect Roll no of T5")
            GoTo Check
        End If

        If TextBox12.Text.Length <= 9 And TextBox12.Text.Length > 0 Then
            MessageBox.Show("Incorrect Phone number of T5")
            GoTo Check
        End If

        GoTo no_error

Check:  i = 1

no_error:

        If TextBox4.Text IsNot "" And TextBox3.Text IsNot "" And TextBox4.Text.Length = 6 And TextBox3.Text.Length = 10 And i < 1 Then

            comm.Connection = conn
            comm.CommandText = "Insert into sem2 ([Name of the project],[Subject],[Nos of teammates],[Roll no(L)],[Phone no (L)],[Roll no(t1)],[Phone no (t1)],[Roll no(t2)],[Phone no (t2)],[Roll no(t3)],[Phone no (t3)],[Roll no(t4)],[Phone no (t4)],[Roll no(t5)],[Phone no (t5)],[Description]  ) VALUES ('" & sem2.TextBox1.Text & "','" & sem2.ComboBox1.Text & "','" & Me.NumericUpDown1.Text & "','" & Me.TextBox4.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox1.Text & "','" & Me.TextBox5.Text & "','" & Me.TextBox6.Text & "','" & Me.TextBox7.Text & "','" & Me.TextBox8.Text & "','" & Me.TextBox9.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox10.Text & "','" & Me.TextBox11.Text & "','" & Me.TextBox12.Text & "','" & Me.TextBox13.Text & "')"
            comm.ExecuteNonQuery()
            RD()

            submit_success.Show()
            Me.Close()
        Else
            MessageBox.Show("CANNOT LEAVE THE BLOCKS INCOMPLETE")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sem2.Show()
        Me.Close()

    End Sub

    Private Sub additional_info2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:all_sem_data.accdb"
        conn.Open()
        RD()
    End Sub


    Public Sub RD()
        Dim da As New OleDbDataAdapter("SELECT *  FROM sem2", conn)
        Dim dt As New DataTable()

        da.Fill(dt)

        view_list2.DataGridView1.DataSource = dt


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress

        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTip1.Show("This is not a number", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub
End Class