

Imports System.Data.OleDb
Public Class view_list5
    Dim conn As New OleDbConnection
    Dim comm As New OleDb.OleDbCommand
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sem5.Show()
        Me.Close()

    End Sub

    Private Sub view_list5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'All_sem_dataDataSet4.sem5' table. You can move, or remove it, as needed.
        ' Me.Sem5TableAdapter.Fill(Me.All_sem_dataDataSet4.sem5)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text = "Name of the project" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=all_sem_data.accdb"
            Dim da As New OleDbDataAdapter("SELECT * FROM sem5 where [Name of the project] Like'" + TextBox1.Text + "%' order by [Roll no(L)] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt
        End If


        If ComboBox1.Text = "Subject" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=all_sem_data.accdb"
            Dim da As New OleDbDataAdapter("SELECT * FROM sem5 where [Subject] Like'" + TextBox1.Text + "%' order by [Roll no(L)] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt
        End If

        If ComboBox1.Text = "Nos of teammates" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=all_sem_data.accdb"
            Dim da As New OleDbDataAdapter("SELECT * FROM sem5 where [Nos of teammates] Like'" + TextBox1.Text + "%' order by [Roll no(L)] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt
        End If



        If ComboBox1.Text = "Roll no (L)" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=all_sem_data.accdb"
            Dim da As New OleDbDataAdapter("SELECT * FROM sem5 where [Roll no(L)] Like'" + TextBox1.Text + "%' order by [Roll no(L)] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt
        End If
        If ComboBox1.Text = "Roll no (t1)" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=all_sem_data.accdb"
            Dim da As New OleDbDataAdapter("SELECT * FROM sem5 where [Roll no(t1)] Like'" + TextBox1.Text + "%' order by [Roll no(t1)] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt
        End If
        If ComboBox1.Text = "Roll no (t2)" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=all_sem_data.accdb"
            Dim da As New OleDbDataAdapter("SELECT * FROM sem5 where [Roll no(t2)] Like'" + TextBox1.Text + "%' order by [Roll no(t2)] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt
        End If

        If ComboBox1.Text = "Roll no (t3)" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=all_sem_data.accdb"
            Dim da As New OleDbDataAdapter("SELECT * FROM sem5 where [Roll no(t3)] Like'" + TextBox1.Text + "%' order by [Roll no(t3)] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt
        End If

        If ComboBox1.Text = "Roll no (t4)" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=all_sem_data.accdb"
            Dim da As New OleDbDataAdapter("SELECT * FROM sem5 where [Roll no(t4)] Like'" + TextBox1.Text + "%' order by [Roll no(t4)] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt
        End If

        If ComboBox1.Text = "Roll no (t5)" Then
            conn = New OleDb.OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=all_sem_data.accdb"
            Dim da As New OleDbDataAdapter("SELECT * FROM sem5 where [Roll no(t5)] Like'" + TextBox1.Text + "%' order by [Roll no(t5)] asc", conn)
            Dim dt As New DataTable()

            da.Fill(dt)

            Me.DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub
End Class