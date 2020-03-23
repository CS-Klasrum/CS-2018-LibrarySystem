<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_AddBooks = New System.Windows.Forms.Button()
        Me.TxtAuthor = New System.Windows.Forms.TextBox()
        Me.TxtBookTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPageCount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPublisher = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtLocation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSubject = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Btn_Borrow = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Btn_AddNew = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 317)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1051, 367)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Book Author:"
        '
        'Btn_AddBooks
        '
        Me.Btn_AddBooks.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddBooks.Location = New System.Drawing.Point(700, 280)
        Me.Btn_AddBooks.Name = "Btn_AddBooks"
        Me.Btn_AddBooks.Size = New System.Drawing.Size(75, 30)
        Me.Btn_AddBooks.TabIndex = 2
        Me.Btn_AddBooks.Text = "Add"
        Me.Btn_AddBooks.UseVisualStyleBackColor = True
        '
        'TxtAuthor
        '
        Me.TxtAuthor.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAuthor.Location = New System.Drawing.Point(137, 28)
        Me.TxtAuthor.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAuthor.Multiline = True
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.Size = New System.Drawing.Size(211, 29)
        Me.TxtAuthor.TabIndex = 3
        '
        'TxtBookTitle
        '
        Me.TxtBookTitle.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBookTitle.Location = New System.Drawing.Point(137, 80)
        Me.TxtBookTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBookTitle.Multiline = True
        Me.TxtBookTitle.Name = "TxtBookTitle"
        Me.TxtBookTitle.Size = New System.Drawing.Size(269, 28)
        Me.TxtBookTitle.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Book Title:"
        '
        'TxtPageCount
        '
        Me.TxtPageCount.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPageCount.Location = New System.Drawing.Point(137, 136)
        Me.TxtPageCount.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPageCount.Multiline = True
        Me.TxtPageCount.Name = "TxtPageCount"
        Me.TxtPageCount.Size = New System.Drawing.Size(113, 27)
        Me.TxtPageCount.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(33, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Page Count:"
        '
        'TxtPublisher
        '
        Me.TxtPublisher.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPublisher.Location = New System.Drawing.Point(137, 189)
        Me.TxtPublisher.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPublisher.Multiline = True
        Me.TxtPublisher.Name = "TxtPublisher"
        Me.TxtPublisher.Size = New System.Drawing.Size(211, 27)
        Me.TxtPublisher.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(44, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Publisher:"
        '
        'TxtLocation
        '
        Me.TxtLocation.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLocation.Location = New System.Drawing.Point(807, 28)
        Me.TxtLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtLocation.Multiline = True
        Me.TxtLocation.Name = "TxtLocation"
        Me.TxtLocation.Size = New System.Drawing.Size(211, 28)
        Me.TxtLocation.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(623, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Location of Publisher:"
        '
        'TxtSubject
        '
        Me.TxtSubject.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubject.Location = New System.Drawing.Point(807, 79)
        Me.TxtSubject.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSubject.Multiline = True
        Me.TxtSubject.Name = "TxtSubject"
        Me.TxtSubject.Size = New System.Drawing.Size(211, 29)
        Me.TxtSubject.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(685, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Book Subject:"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.Location = New System.Drawing.Point(807, 136)
        Me.TxtQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtQuantity.Multiline = True
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(211, 27)
        Me.TxtQuantity.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(674, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Book Quantity:"
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(155, 288)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSearch.Multiline = True
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(290, 24)
        Me.TxtSearch.TabIndex = 17
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delete.Location = New System.Drawing.Point(781, 280)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(75, 30)
        Me.Btn_Delete.TabIndex = 20
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Update
        '
        Me.Btn_Update.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update.Location = New System.Drawing.Point(862, 280)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(75, 30)
        Me.Btn_Update.TabIndex = 21
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'Btn_Borrow
        '
        Me.Btn_Borrow.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Borrow.Location = New System.Drawing.Point(943, 280)
        Me.Btn_Borrow.Name = "Btn_Borrow"
        Me.Btn_Borrow.Size = New System.Drawing.Size(75, 30)
        Me.Btn_Borrow.TabIndex = 22
        Me.Btn_Borrow.Text = "Borrow"
        Me.Btn_Borrow.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(10, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 21)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Search by Title"
        '
        'Btn_AddNew
        '
        Me.Btn_AddNew.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddNew.Location = New System.Drawing.Point(575, 280)
        Me.Btn_AddNew.Name = "Btn_AddNew"
        Me.Btn_AddNew.Size = New System.Drawing.Size(119, 30)
        Me.Btn_AddNew.TabIndex = 24
        Me.Btn_AddNew.Text = "Add New Book"
        Me.Btn_AddNew.UseVisualStyleBackColor = True
        '
        'frmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1075, 696)
        Me.Controls.Add(Me.Btn_AddNew)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Btn_Borrow)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtSubject)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtLocation)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPublisher)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPageCount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtBookTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtAuthor)
        Me.Controls.Add(Me.Btn_AddBooks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBooks"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_AddBooks As System.Windows.Forms.Button
    Friend WithEvents TxtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents TxtBookTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPageCount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPublisher As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Delete As System.Windows.Forms.Button
    Friend WithEvents Btn_Update As System.Windows.Forms.Button
    Friend WithEvents Btn_Borrow As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Btn_AddNew As System.Windows.Forms.Button
End Class
