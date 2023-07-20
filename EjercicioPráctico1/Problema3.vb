Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Problema3
    Public TotalF As Double
    Public T As String
    Public linea(3) As String
    Public Producto1(3) As String
    Public Ventas1(3) As Integer
    Public Precio1(3) As Double
    Public Total1(3) As Double
    Private Sub Problema3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Producto1(0) = "Cola"
        Producto1(1) = "Naranja"
        Producto1(2) = "Limon"
        linea(0) = ""
        linea(1) = ""
        linea(2) = ""
        ComboBox1.Items.Insert(0, "")
        ComboBox1.Items.Insert(1, "Cola")
        ComboBox1.Items.Insert(2, "Naranja")
        ComboBox1.Items.Insert(3, "Limon")
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim vt As Integer = Double.Parse(TextBox1.Text)
            Dim pr As Double = Double.Parse(TextBox2.Text)
            Dim cad As String = ComboBox1.SelectedItem.ToString()
            If cad = "" And TextBox1.Text = "" And TextBox1.Text = "" Then
                Label4.Visible = True
                Label4.ForeColor = Color.Red
                Label4.Text = "Error:Los campos estan vacios."
                Label5.Visible = True
                Label6.Visible = True
                Label7.Visible = True
            Else

                If cad = "" Or vt >= 5000000 Or vt = 0 Or pr = 0 Then
                    If cad = "" And TextBox1.Text = "" And TextBox2.Text = "" Then
                        Label4.Visible = True
                        Label4.ForeColor = Color.Red
                        Label4.Text = "Error: Todos los campos estan vacios."
                        Label5.Visible = True
                        Label6.Visible = True
                        Label7.Visible = True
                    End If
                    If vt >= 5000000 Then
                        Label4.Visible = True
                        Label4.ForeColor = Color.Red
                        Label4.Text = "Error: El valor maximo permitido es 5000000."
                        Label6.Visible = True
                    End If
                    If cad = "" Then
                        Label4.Visible = True
                        Label4.ForeColor = Color.Red
                        Label4.Text = "Error: verifique la seleccion."
                        Label5.Visible = True
                    End If
                    If TextBox1.Text = "" Then
                        Label4.Visible = True
                        Label4.ForeColor = Color.Red
                        Label4.Text = "Error: verifique que el campo no este vacio."
                        Label6.Visible = True
                    End If
                    If TextBox2.Text = "" Then
                        Label4.Visible = True
                        Label4.ForeColor = Color.Red
                        Label4.Text = "Error:  verifique que el campo no este vacio."
                        Label7.Visible = True
                    End If
                Else
                    'registro de tabla
                    If cad = "Cola" Then
                        Ventas1(0) += vt
                        Precio1(0) += pr
                        Total1(0) += vt * pr
                    End If
                    If cad = "Naranja" Then
                        Ventas1(1) += vt
                        Precio1(1) += pr
                        Total1(1) += vt * pr
                    End If
                    If cad = "Limon" Then
                        Ventas1(2) += vt
                        Precio1(2) += pr
                        Total1(2) += vt * pr
                    End If
                    TotalF = Total1(0) + Total1(1) + Total1(2)
                    T = " € " & TotalF.ToString("#,##0.00")
                    'tabla
                    DataGridView2.Rows.Clear()
                    DataGridView2.Rows.Add(Producto1(0), Ventas1(0), " € " & Precio1(0).ToString("#,##0.00"), " € " & Total1(0).ToString("#,##0.00"))
                    DataGridView2.Rows.Add(Producto1(1), Ventas1(1), " € " & Precio1(1).ToString("#,##0.00"), " € " & Total1(1).ToString("#,##0.00"))
                    DataGridView2.Rows.Add(Producto1(2), Ventas1(2), " € " & Precio1(2).ToString("#,##0.00"), " € " & Total1(2).ToString("#,##0.00"))
                    DataGridView2.Rows.Add(linea(0), linea(1), linea(2), T)
                    Label4.Visible = True
                    Label4.ForeColor = Color.Green
                    Label4.Text = "Error: Registro completado."
                End If
            End If
        Catch ex As Exception
            Label4.Visible = True
            Label4.ForeColor = Color.Red
            Label4.Text = "Error: El valor introducido es incorrecto."
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Producto1(0) = "Cola"
        Producto1(1) = "Naranja"
        Producto1(2) = "Limon"
        linea(0) = ""
        linea(1) = ""
        linea(2) = ""
        ComboBox1.Items.Clear()
        ComboBox1.Items.Insert(0, "")
        ComboBox1.Items.Insert(1, "Cola")
        ComboBox1.Items.Insert(2, "Naranja")
        ComboBox1.Items.Insert(3, "Limon")
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False

        Label7.Visible = False
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        Label4.Visible = False
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Label4.Visible = False
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        Label4.Visible = False
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'Permitir solo números enteros
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        'Permitir solo números decimales y enteros,
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        'Permitir solo un punto decimal
        If e.KeyChar = "." AndAlso sender.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If
    End Sub
    Public Sub Offp2()
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar el Registro?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Offp2()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            TextBox2.Select()
        End If
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            Button3.Select()
        End If
    End Sub
End Class