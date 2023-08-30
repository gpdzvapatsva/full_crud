Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Public Class Form1
    'declaring the connection and setting up connection string
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gdzvapatsva\Desktop\logs.accdb")
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Searching for record and populating in textboxes
        conn.Open()
        Dim cmd As New OleDbCommand("Select * from products where product_id=@id", conn)
        'the below statement allows use of the search key
        cmd.Parameters.AddWithValue("id", txtID.Text)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            MessageBox.Show("record found")
            'populating the 
            txtProductID.Text = reader("product_id").ToString()
            txtProductName.Text = reader("product_name").ToString()
            txtQuantity.Text = reader("quantity").ToString()
            txtPrice.Text = reader("unit_price").ToString()
            conn.Close()
        Else
            MessageBox.Show("record not  found")
            conn.Close()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'updating a record
        Dim updatequery As String = "Update products set product_id =@product_id, product_name=@product_name, quantity=@quantity, unit_price=@unit_price where product_id=@id"
        runquery(updatequery)
        Try
            MessageBox.Show("record updated")
            clear()
        Catch ex As Exception
            MessageBox.Show("record not updated")
        End Try
    End Sub
    Sub runquery(ByVal query As String)
        'this sub procedure allows for insert, update and delete
        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("product_id", txtProductID.Text)
        cmd.Parameters.AddWithValue("product_name", txtProductName.Text)
        cmd.Parameters.AddWithValue("quantity", txtQuantity.Text)
        cmd.Parameters.AddWithValue("unit_price", txtPrice.Text)
        cmd.Parameters.AddWithValue("id", txtID.Text)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'inserting a record
        Dim insertquery As String = "Insert into products values (@product_id, @product_name, @quantity, @unit_price) "
        runquery(insertquery)
        Try
            MessageBox.Show("record inserted")
            clear()
        Catch ex As Exception
            MessageBox.Show("record not inserted")
        End Try
    End Sub

    'procedure to clear the textboxes
    Sub clear()
        txtID.Clear()
        txtProductID.Clear()
        txtProductName.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'inserting a record
        Dim deletequery As String = "Delete from products where product_id=@id "
        runquery(deletequery)
        Try
            MessageBox.Show("record deleted")
            clear()
        Catch ex As Exception
            MessageBox.Show("record not deleted")
        End Try
    End Sub


End Class
