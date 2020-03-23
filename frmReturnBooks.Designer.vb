<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnBooks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePickerReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.TxtStudentName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCourse = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBookTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTransactionID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lbl_IssueDate = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Bnt_Return = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 286)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search by BookTitle"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(225, 284)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 27)
        Me.TextBox1.TabIndex = 1
        '
        'DateTimePickerReturnDate
        '
        Me.DateTimePickerReturnDate.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerReturnDate.Location = New System.Drawing.Point(687, 145)
        Me.DateTimePickerReturnDate.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePickerReturnDate.Name = "DateTimePickerReturnDate"
        Me.DateTimePickerReturnDate.Size = New System.Drawing.Size(222, 25)
        Me.DateTimePickerReturnDate.TabIndex = 2
        '
        'TxtStudentName
        '
        Me.TxtStudentName.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStudentName.Location = New System.Drawing.Point(202, 46)
        Me.TxtStudentName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtStudentName.Name = "TxtStudentName"
        Me.TxtStudentName.Size = New System.Drawing.Size(160, 27)
        Me.TxtStudentName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Student Name:"
        '
        'TxtCourse
        '
        Me.TxtCourse.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCourse.Location = New System.Drawing.Point(202, 96)
        Me.TxtCourse.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCourse.Name = "TxtCourse"
        Me.TxtCourse.Size = New System.Drawing.Size(160, 27)
        Me.TxtCourse.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Course:"
        '
        'TxtBookTitle
        '
        Me.TxtBookTitle.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBookTitle.Location = New System.Drawing.Point(202, 145)
        Me.TxtBookTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBookTitle.Name = "TxtBookTitle"
        Me.TxtBookTitle.Size = New System.Drawing.Size(318, 27)
        Me.TxtBookTitle.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Book Title:"
        '
        'TxtTransactionID
        '
        Me.TxtTransactionID.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTransactionID.Location = New System.Drawing.Point(834, 46)
        Me.TxtTransactionID.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTransactionID.Name = "TxtTransactionID"
        Me.TxtTransactionID.Size = New System.Drawing.Size(161, 27)
        Me.TxtTransactionID.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(683, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Transaction ID:"
        '
        'Lbl_IssueDate
        '
        Me.Lbl_IssueDate.AutoSize = True
        Me.Lbl_IssueDate.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_IssueDate.Location = New System.Drawing.Point(683, 98)
        Me.Lbl_IssueDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_IssueDate.Name = "Lbl_IssueDate"
        Me.Lbl_IssueDate.Size = New System.Drawing.Size(47, 21)
        Me.Lbl_IssueDate.TabIndex = 11
        Me.Lbl_IssueDate.Text = "Date"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 333)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(992, 258)
        Me.DataGridView1.TabIndex = 12
        '
        'Bnt_Return
        '
        Me.Bnt_Return.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bnt_Return.Location = New System.Drawing.Point(823, 284)
        Me.Bnt_Return.Margin = New System.Windows.Forms.Padding(2)
        Me.Bnt_Return.Name = "Bnt_Return"
        Me.Bnt_Return.Size = New System.Drawing.Size(86, 26)
        Me.Bnt_Return.TabIndex = 13
        Me.Bnt_Return.Text = "Return"
        Me.Bnt_Return.UseVisualStyleBackColor = True
        '
        'frmReturnBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1075, 696)
        Me.Controls.Add(Me.Bnt_Return)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Lbl_IssueDate)
        Me.Controls.Add(Me.TxtTransactionID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtBookTitle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCourse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtStudentName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePickerReturnDate)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmReturnBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReturnBooks"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerReturnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCourse As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtBookTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTransactionID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Lbl_IssueDate As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Bnt_Return As System.Windows.Forms.Button
End Class
