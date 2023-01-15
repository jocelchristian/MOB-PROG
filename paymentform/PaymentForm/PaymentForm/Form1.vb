Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add("Chicken Wings", "100")
        DataGridView1.Rows.Add("Beff Tapa", "200")
        DataGridView1.Rows.Add("Chicken Adobo", "150")
        DataGridView1.Rows.Add("Pork Adobo", "170")

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox4.Text = Val(TextBox3.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Label2.Text = TextBox1.Text
        Form2.Label3.Text = TextBox2.Text
        Form2.Label5.Text = TextBox3.Text
        Form2.Label7.Text = TextBox4.Text
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub
End Class
