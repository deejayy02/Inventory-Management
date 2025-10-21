Imports System.Data

Public Class CheckoutCtrl

    ' Main product data
    Private AllProducts As New DataTable()
    ' Filtered view for display
    Private FilteredProducts As New DataView()
    ' Cart table
    Private dtCart As New DataTable()

    Private Sub CheckoutCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create columns for products
        AllProducts.Columns.Add("Select", GetType(Boolean))
        AllProducts.Columns.Add("Product")
        AllProducts.Columns.Add("Category")
        AllProducts.Columns.Add("Quantity", GetType(Integer))
        AllProducts.Columns.Add("Price", GetType(Decimal))

        ' Add sample product data
        AllProducts.Rows.Add(False, "Apple", "Fruits", 1, 25)
        AllProducts.Rows.Add(False, "Banana", "Fruits", 1, 15)
        AllProducts.Rows.Add(False, "Carrot", "Vegetables", 1, 20)
        AllProducts.Rows.Add(False, "Milk", "Dairy", 1, 60)
        AllProducts.Rows.Add(False, "Cheese", "Dairy", 1, 90)
        AllProducts.Rows.Add(False, "Bread", "Bakery", 1, 30)
        AllProducts.Rows.Add(False, "Cake", "Bakery", 1, 120)

        ' Setup DataView for filtering
        FilteredProducts = New DataView(AllProducts)
        dgvProducts.DataSource = FilteredProducts

        ' Make price column readonly
        dgvProducts.Columns("Price").ReadOnly = True

        ' Populate category ComboBox
        Dim categories = (From row In AllProducts.AsEnumerable()
                          Select row.Field(Of String)("Category")).Distinct().ToList()
        cboCategory.Items.Clear()
        cboCategory.Items.Add("All Categories")
        cboCategory.Items.AddRange(categories.ToArray())
        cboCategory.SelectedIndex = 0

        ' Setup Cart Table
        dtCart.Columns.Add("Product")
        dtCart.Columns.Add("Quantity", GetType(Integer))
        dtCart.Columns.Add("Price", GetType(Decimal))
        dtCart.Columns.Add("Subtotal", GetType(Decimal))
        dgvCart.DataSource = dtCart
    End Sub

    ' 🔍 Filter products by search text and category
    Private Sub ApplyFilter()
        Dim filterText As String = txtSearch.Text.Trim().ToLower()
        Dim selectedCategory As String = cboCategory.SelectedItem.ToString()

        Dim filterExpression As String = ""

        If selectedCategory <> "All Categories" Then
            filterExpression = $"Category = '{selectedCategory}'"
        End If

        If filterText <> "" Then
            If filterExpression <> "" Then filterExpression &= " AND "
            filterExpression &= $"LOWER(Product) LIKE '%{filterText}%'"
        End If

        FilteredProducts.RowFilter = filterExpression
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplyFilter()
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        ApplyFilter()
    End Sub

    ' 🛒 Add selected products to cart
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        For Each row As DataRowView In FilteredProducts
            If CBool(row("Select")) Then
                Dim product As String = row("Product").ToString()
                Dim qty As Integer = CInt(row("Quantity"))
                Dim price As Decimal = CDec(row("Price"))
                Dim subtotal As Decimal = qty * price

                ' Add to cart
                dtCart.Rows.Add(product, qty, price, subtotal)

                ' Uncheck after adding
                row("Select") = False
            End If
        Next
        UpdateTotal()
    End Sub

    ' ❌ Delete selected from cart
    Private Sub btnDeleteSelected_Click(sender As Object, e As EventArgs) Handles btnDeleteSelected.Click
        For i As Integer = dgvCart.SelectedRows.Count - 1 To 0 Step -1
            dgvCart.Rows.RemoveAt(dgvCart.SelectedRows(i).Index)
        Next
        UpdateTotal()
    End Sub

    ' 💰 Update total price
    Private Sub UpdateTotal()
        Dim total As Decimal = 0
        For Each row As DataRow In dtCart.Rows
            total += CDec(row("Subtotal"))
        Next
        lblTotal.Text = "₱" & total.ToString("N2")
    End Sub

    ' ✅ Checkout
    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        MessageBox.Show("Checkout successful! Total: " & lblTotal.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' 🧹 Cancel / Clear Cart
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dtCart.Clear()
        UpdateTotal()
    End Sub

End Class
