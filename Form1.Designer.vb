<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(554, 63)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(102, 36)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(554, 117)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 36)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(554, 174)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(102, 36)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(554, 236)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 36)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(309, 79)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 20)
        Me.txtProductID.TabIndex = 4
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(309, 133)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 20)
        Me.txtProductName.TabIndex = 5
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(309, 189)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(309, 239)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 7
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(309, 21)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SearchID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Product ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(200, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Unit Price"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtID)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
