<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckoutCtrl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.btnCheckou = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.btnDeleteSelected = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCheckou
        '
        Me.btnCheckou.Location = New System.Drawing.Point(991, 532)
        Me.btnCheckou.Name = "btnCheckou"
        Me.btnCheckou.Size = New System.Drawing.Size(134, 34)
        Me.btnCheckou.TabIndex = 1
        Me.btnCheckou.Text = "Check Out"
        Me.btnCheckou.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1149, 532)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(134, 34)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(99, 111)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(351, 32)
        Me.txtSearch.TabIndex = 8
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(560, 111)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(351, 24)
        Me.cboCategory.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label1.Location = New System.Drawing.Point(95, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Product"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label2.Location = New System.Drawing.Point(556, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Category"
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvProducts.Location = New System.Drawing.Point(99, 225)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersWidth = 51
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(473, 288)
        Me.dgvProducts.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label3.Location = New System.Drawing.Point(95, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Products"
        '
        'dgvCart
        '
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colum6, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvCart.Location = New System.Drawing.Point(638, 225)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.RowHeadersWidth = 51
        Me.dgvCart.RowTemplate.Height = 24
        Me.dgvCart.Size = New System.Drawing.Size(645, 263)
        Me.dgvCart.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label4.Location = New System.Drawing.Point(1145, 451)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Total : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Label5.Location = New System.Drawing.Point(712, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 22)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Cart"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!)
        Me.Label6.Location = New System.Drawing.Point(493, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(316, 51)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Checkout Form"
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Location = New System.Drawing.Point(160, 532)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(134, 34)
        Me.btnAddToCart.TabIndex = 19
        Me.btnAddToCart.Text = "Add to Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'btnDeleteSelected
        '
        Me.btnDeleteSelected.Location = New System.Drawing.Point(413, 532)
        Me.btnDeleteSelected.Name = "btnDeleteSelected"
        Me.btnDeleteSelected.Size = New System.Drawing.Size(134, 34)
        Me.btnDeleteSelected.TabIndex = 20
        Me.btnDeleteSelected.Text = "Delete Selected"
        Me.btnDeleteSelected.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Select"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Category"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Price"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Colum6
        '
        Me.Colum6.Frozen = True
        Me.Colum6.HeaderText = "Prodcut"
        Me.Colum6.MinimumWidth = 6
        Me.Colum6.Name = "Colum6"
        Me.Colum6.ReadOnly = True
        Me.Colum6.Width = 150
        '
        'Column6
        '
        Me.Column6.Frozen = True
        Me.Column6.HeaderText = "Quantity"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.Frozen = True
        Me.Column7.HeaderText = "Price"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'Column8
        '
        Me.Column8.Frozen = True
        Me.Column8.HeaderText = "Subtotal"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 150
        '
        'CheckoutCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnDeleteSelected)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvCart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCheckou)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CheckoutCtrl"
        Me.Size = New System.Drawing.Size(1368, 608)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCheckou As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Friend WithEvents cboCategory As ComboBox

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged

    End Sub

    Friend WithEvents Label1 As Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents Label3 As Label

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents Label4 As Label

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Label5 As Label

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Friend WithEvents Label6 As Label

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Friend WithEvents btnAddToCart As Button

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnAddToCart.Click

    End Sub

    Friend WithEvents btnDeleteSelected As Button
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Colum6 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn

    Private Sub CheckoutCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub