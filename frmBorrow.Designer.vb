<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrow
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
        Me.TxtSearchStudent = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePickerIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCourse = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSearchBookTitle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_IssueBook = New System.Windows.Forms.Button()
        Me.Btn_Back = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 164)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search by IDNumber"
        '
        'TxtSearchStudent
        '
        Me.TxtSearchStudent.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchStudent.Location = New System.Drawing.Point(194, 162)
        Me.TxtSearchStudent.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSearchStudent.Name = "TxtSearchStudent"
        Me.TxtSearchStudent.Size = New System.Drawing.Size(108, 27)
        Me.TxtSearchStudent.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 197)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(521, 297)
        Me.DataGridView1.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(597, 197)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(521, 297)
        Me.DataGridView2.TabIndex = 3
        '
        'TxtLastName
        '
        Me.TxtLastName.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLastName.Location = New System.Drawing.Point(128, 10)
        Me.TxtLastName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(108, 27)
        Me.TxtLastName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last Name:"
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirstName.Location = New System.Drawing.Point(128, 57)
        Me.TxtFirstName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(108, 27)
        Me.TxtFirstName.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "First Name:"
        '
        'TxtMiddleName
        '
        Me.TxtMiddleName.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMiddleName.Location = New System.Drawing.Point(128, 102)
        Me.TxtMiddleName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtMiddleName.Name = "TxtMiddleName"
        Me.TxtMiddleName.Size = New System.Drawing.Size(108, 27)
        Me.TxtMiddleName.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 104)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Middle Name:"
        '
        'DateTimePickerIssueDate
        '
        Me.DateTimePickerIssueDate.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerIssueDate.Location = New System.Drawing.Point(568, 103)
        Me.DateTimePickerIssueDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePickerIssueDate.Name = "DateTimePickerIssueDate"
        Me.DateTimePickerIssueDate.Size = New System.Drawing.Size(251, 25)
        Me.DateTimePickerIssueDate.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(467, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Issue Date:"
        '
        'TxtCourse
        '
        Me.TxtCourse.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCourse.Location = New System.Drawing.Point(540, 11)
        Me.TxtCourse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCourse.Name = "TxtCourse"
        Me.TxtCourse.Size = New System.Drawing.Size(108, 27)
        Me.TxtCourse.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(467, 13)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Course:"
        '
        'TxtSearchBookTitle
        '
        Me.TxtSearchBookTitle.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchBookTitle.Location = New System.Drawing.Point(782, 162)
        Me.TxtSearchBookTitle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSearchBookTitle.Name = "TxtSearchBookTitle"
        Me.TxtSearchBookTitle.Size = New System.Drawing.Size(336, 27)
        Me.TxtSearchBookTitle.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(598, 164)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Search by Book Title"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.Location = New System.Drawing.Point(556, 58)
        Me.TxtQuantity.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(108, 27)
        Me.TxtQuantity.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(467, 60)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 21)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Quantity:"
        '
        'Btn_IssueBook
        '
        Me.Btn_IssueBook.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_IssueBook.Location = New System.Drawing.Point(9, 509)
        Me.Btn_IssueBook.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_IssueBook.Name = "Btn_IssueBook"
        Me.Btn_IssueBook.Size = New System.Drawing.Size(86, 32)
        Me.Btn_IssueBook.TabIndex = 18
        Me.Btn_IssueBook.Text = "Borrow"
        Me.Btn_IssueBook.UseVisualStyleBackColor = True
        '
        'Btn_Back
        '
        Me.Btn_Back.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Back.Location = New System.Drawing.Point(128, 509)
        Me.Btn_Back.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(86, 32)
        Me.Btn_Back.TabIndex = 19
        Me.Btn_Back.Text = "Back"
        Me.Btn_Back.UseVisualStyleBackColor = True
        '
        'frmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1131, 552)
        Me.Controls.Add(Me.Btn_Back)
        Me.Controls.Add(Me.Btn_IssueBook)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtSearchBookTitle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCourse)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePickerIssueDate)
        Me.Controls.Add(Me.TxtMiddleName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtSearchStudent)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmBorrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBorrow"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSearchStudent As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TxtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCourse As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtSearchBookTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Btn_IssueBook As System.Windows.Forms.Button
    Friend WithEvents Btn_Back As System.Windows.Forms.Button
End Class
