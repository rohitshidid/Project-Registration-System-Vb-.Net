<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class view_list
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_list))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameOfTheProjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NosOfTeammatesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollNoLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollNot1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollNot2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollNot3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollNot4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollNot5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sem1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.All_sem_dataDataSet = New semester_selection.all_sem_dataDataSet()
        Me.Sem1TableAdapter = New semester_selection.all_sem_dataDataSetTableAdapters.sem1TableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sem1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.All_sem_dataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(20, 418)
        Me.Button4.Name = "Button4"
        Me.Button4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button4.Size = New System.Drawing.Size(75, 35)
        Me.Button4.TabIndex = 67
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(29, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button7.Size = New System.Drawing.Size(798, 41)
        Me.Button7.TabIndex = 65
        Me.Button7.Text = "VIEW LIST"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(505, 433)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Step 2/4"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(560, 418)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProgressBar1.Size = New System.Drawing.Size(303, 28)
        Me.ProgressBar1.TabIndex = 63
        Me.ProgressBar1.Value = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(819, 277)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Project List"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameOfTheProjectDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.NosOfTeammatesDataGridViewTextBoxColumn, Me.RollNoLDataGridViewTextBoxColumn, Me.RollNot1DataGridViewTextBoxColumn, Me.RollNot2DataGridViewTextBoxColumn, Me.RollNot3DataGridViewTextBoxColumn, Me.RollNot4DataGridViewTextBoxColumn, Me.RollNot5DataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Sem1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(798, 255)
        Me.DataGridView1.TabIndex = 0
        '
        'NameOfTheProjectDataGridViewTextBoxColumn
        '
        Me.NameOfTheProjectDataGridViewTextBoxColumn.DataPropertyName = "Name of the project"
        Me.NameOfTheProjectDataGridViewTextBoxColumn.HeaderText = "Name of the project"
        Me.NameOfTheProjectDataGridViewTextBoxColumn.Name = "NameOfTheProjectDataGridViewTextBoxColumn"
        Me.NameOfTheProjectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        Me.SubjectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NosOfTeammatesDataGridViewTextBoxColumn
        '
        Me.NosOfTeammatesDataGridViewTextBoxColumn.DataPropertyName = "Nos of teammates"
        Me.NosOfTeammatesDataGridViewTextBoxColumn.HeaderText = "Nos of teammates"
        Me.NosOfTeammatesDataGridViewTextBoxColumn.Name = "NosOfTeammatesDataGridViewTextBoxColumn"
        Me.NosOfTeammatesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RollNoLDataGridViewTextBoxColumn
        '
        Me.RollNoLDataGridViewTextBoxColumn.DataPropertyName = "Roll no(L)"
        Me.RollNoLDataGridViewTextBoxColumn.HeaderText = "Roll no(L)"
        Me.RollNoLDataGridViewTextBoxColumn.Name = "RollNoLDataGridViewTextBoxColumn"
        Me.RollNoLDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RollNot1DataGridViewTextBoxColumn
        '
        Me.RollNot1DataGridViewTextBoxColumn.DataPropertyName = "Roll no(t1)"
        Me.RollNot1DataGridViewTextBoxColumn.HeaderText = "Roll no(t1)"
        Me.RollNot1DataGridViewTextBoxColumn.Name = "RollNot1DataGridViewTextBoxColumn"
        Me.RollNot1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'RollNot2DataGridViewTextBoxColumn
        '
        Me.RollNot2DataGridViewTextBoxColumn.DataPropertyName = "Roll no(t2)"
        Me.RollNot2DataGridViewTextBoxColumn.HeaderText = "Roll no(t2)"
        Me.RollNot2DataGridViewTextBoxColumn.Name = "RollNot2DataGridViewTextBoxColumn"
        Me.RollNot2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'RollNot3DataGridViewTextBoxColumn
        '
        Me.RollNot3DataGridViewTextBoxColumn.DataPropertyName = "Roll no(t3)"
        Me.RollNot3DataGridViewTextBoxColumn.HeaderText = "Roll no(t3)"
        Me.RollNot3DataGridViewTextBoxColumn.Name = "RollNot3DataGridViewTextBoxColumn"
        Me.RollNot3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'RollNot4DataGridViewTextBoxColumn
        '
        Me.RollNot4DataGridViewTextBoxColumn.DataPropertyName = "Roll no(t4)"
        Me.RollNot4DataGridViewTextBoxColumn.HeaderText = "Roll no(t4)"
        Me.RollNot4DataGridViewTextBoxColumn.Name = "RollNot4DataGridViewTextBoxColumn"
        Me.RollNot4DataGridViewTextBoxColumn.ReadOnly = True
        '
        'RollNot5DataGridViewTextBoxColumn
        '
        Me.RollNot5DataGridViewTextBoxColumn.DataPropertyName = "Roll no(t5)"
        Me.RollNot5DataGridViewTextBoxColumn.HeaderText = "Roll no(t5)"
        Me.RollNot5DataGridViewTextBoxColumn.Name = "RollNot5DataGridViewTextBoxColumn"
        Me.RollNot5DataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Sem1BindingSource
        '
        Me.Sem1BindingSource.DataMember = "sem1"
        Me.Sem1BindingSource.DataSource = Me.All_sem_dataDataSet
        '
        'All_sem_dataDataSet
        '
        Me.All_sem_dataDataSet.DataSetName = "all_sem_dataDataSet"
        Me.All_sem_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sem1TableAdapter
        '
        Me.Sem1TableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(566, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 23)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Search :-"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(659, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 20)
        Me.TextBox1.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 23)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Column :-"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Name of the project", "Subject", "Nos of teammates", "Roll no (L)", "Roll no (t1)", "Roll no (t2)", "Roll no (t3)", "Roll no (t4)", "Roll no (t5)"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(232, 21)
        Me.ComboBox1.TabIndex = 72
        '
        'view_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(883, 456)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "view_list"
        Me.Text = "view_list"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sem1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.All_sem_dataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents All_sem_dataDataSet As all_sem_dataDataSet
    Friend WithEvents Sem1BindingSource As BindingSource
    Friend WithEvents Sem1TableAdapter As all_sem_dataDataSetTableAdapters.sem1TableAdapter
    Friend WithEvents NameOfTheProjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NosOfTeammatesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RollNoLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RollNot1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RollNot2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RollNot3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RollNot4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RollNot5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
