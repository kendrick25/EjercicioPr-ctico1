Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Problema2

    Private Sub Problema2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.MaxLength = 12
        Button1.FlatAppearance.BorderSize = 0
        Panel2.Visible = False
        Label8.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        ComboBox2.Visible = False
        ComboBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        ComboBox1.Items.Insert(0, "")
        ComboBox1.Items.Insert(1, "Euros")
        ComboBox1.Items.Insert(2, "Dólares")
        ComboBox1.Items.Insert(3, "Yenes")
        ComboBox1.Items.Insert(4, "Pesetas")
        ComboBox1.Items.Insert(5, "Libras")
    End Sub


    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Offp2()
    End Sub
    Public Sub Offp2()
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar las conversiones?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            Me.Close()
        End If
    End Sub
    'covercion
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cadena As String = ComboBox1.SelectedItem.ToString()
        If cadena = "Euros" Or cadena = "Pesetas" Or cadena = "Yenes" Or cadena = "Libras" Then
            Label3.Visible = True
            ComboBox2.Visible = True
            ComboBox2.Items.Insert(0, "Dólares")
        End If
        If cadena = "Dólares" Then
            Label3.Visible = True
            ComboBox2.Visible = True
            ComboBox2.Items.Insert(0, "")
            ComboBox2.Items.Insert(1, "Euros")
            ComboBox2.Items.Insert(2, "Pesetas")
            ComboBox2.Items.Insert(3, "Yenes")
            ComboBox2.Items.Insert(4, "Libras")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim select1 As String = ComboBox1.SelectedItem.ToString()
        Dim select2 As String = ComboBox2.SelectedItem.ToString()
        Try
            If ComboBox1.SelectedItem.ToString() = "" Or ComboBox2.SelectedItem.ToString() = "" Or TextBox1.Text = "" Or Convert.ToDouble(TextBox1.Text) > 1000000 Or Convert.ToDouble(TextBox1.Text) = 0 Then
                If TextBox1.Text = "" Then
                    Panel2.Visible = True
                    Label8.Visible = True
                    Panel2.BackColor = Color.Black
                    Label8.ForeColor = Color.Red
                    Label8.Text = "Error: verifique el valor ingresado."
                    Label4.Visible = True
                End If
                If TextBox1.Text > 1000000 Then
                    Panel2.Visible = True
                    Label8.Visible = True
                    Panel2.BackColor = Color.Black
                    Label8.ForeColor = Color.Red
                    Label8.Text = "Error: El valor excede el millon de dolares."
                    Label4.Visible = True
                End If
                If Convert.ToDouble(TextBox1.Text) = 0 Then
                    Panel2.Visible = True
                    Label8.Visible = True
                    Panel2.BackColor = Color.Black
                    Label8.ForeColor = Color.Red
                    Label8.Text = "Error: Ingrese un valor mayor a 0."
                    Label4.Visible = True
                End If
                If ComboBox1.SelectedItem.ToString() = "" Then
                    Panel2.Visible = True
                    Label8.Visible = True
                    Panel2.BackColor = Color.Black
                    Label8.ForeColor = Color.Red
                    Label8.Text = "Error: verifique el valor seleccionado."
                    Label6.Visible = True
                End If
                If ComboBox2.SelectedItem.ToString() = "" Then
                    Panel2.Visible = True
                    Label8.Visible = True
                    Panel2.BackColor = Color.Black
                    Label8.ForeColor = Color.Red
                    Label8.Text = "Error: verifique el valor seleccionado."
                    Label7.Visible = True
                End If
            Else
                Label7.Visible = False
                Label6.Visible = False
                Label4.Visible = False
                Panel2.Visible = True
                Label8.Visible = True
                Panel2.BackColor = Color.Black
                Label8.ForeColor = Color.Green

                'conversion de monedas
                Dim cantidad As Double = Convert.ToDouble(TextBox1.Text)
                Dim resultado As Double
                'Euros a dolares
                If select1 = "Euros" And select2 = "Dólares" Then
                    resultado = cantidad * 1.18
                    Label8.Text = " $ " & resultado.ToString("#,##0.00")
                End If
                'Dolares a Euros
                If select1 = "Dólares" And select2 = "Euros" Then
                    resultado = cantidad * 0.85
                    Label8.Text = " € " & resultado.ToString("#,##0.00")
                End If
                'Dolares a Yenes
                If select1 = "Dólares" And select2 = "Yenes" Then
                    resultado = cantidad * 109.98
                    Label8.Text = " ¥  " & resultado.ToString("#,##0.00")
                End If
                'Yenes a Dolares
                If select1 = "Yenes" And select2 = "Dólares" Then
                    resultado = cantidad * 0.0091
                    Label8.Text = " $ " & resultado.ToString("#,##0.00")
                End If
                'Dolares a Pesetas
                If select1 = "Dólares" And select2 = "Pesetas" Then
                    resultado = cantidad * 166.39
                    Label8.Text = "  ₧ " & resultado.ToString("#,##0.00")
                End If
                'Pesetas a Dolares
                If select1 = "Pesetas" And select2 = "Dólares" Then
                    resultado = cantidad * 0.006
                    Label8.Text = " $ " & resultado.ToString("#,##0.00")
                End If
                'Dolares a Libras
                If ComboBox1.SelectedItem.ToString() = "Dólares" And ComboBox2.SelectedItem.ToString() = "Libras" Then
                    resultado = cantidad * 0.72
                    Label8.Text = " £) " & resultado.ToString("#,##0.00")
                End If
                'Libras a dolares
                If ComboBox1.SelectedItem.ToString() = "Libras" And ComboBox2.SelectedItem.ToString() = "Dólares" Then
                    resultado = cantidad * 1.39
                    Label8.Text = " $ " & resultado.ToString("#,##0.00")
                End If
                Button2.Visible = True
            End If
        Catch ex As Exception
            Panel2.Visible = True
            Label8.Visible = True
            Panel2.BackColor = Color.Black
            Label8.ForeColor = Color.Red
            Label8.Text = "Error: verifique los campos, estan vacios."
        End Try
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'Permitir solo números decimales y enteros, tanto positivos como negativos
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        'Permitir solo un punto decimal
        If e.KeyChar = "." AndAlso sender.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Button1.Visible = True
    End Sub
    'Limpiar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Visible = False
        Label8.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        ComboBox2.Visible = False
        ComboBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Items.Insert(0, "")
        ComboBox1.Items.Insert(1, "Euros")
        ComboBox1.Items.Insert(2, "Dólares")
        ComboBox1.Items.Insert(3, "Yenes")
        ComboBox1.Items.Insert(4, "Pesetas")
        ComboBox1.Items.Insert(5, "Libras")
        TextBox1.Text = ""
        Panel2.Visible = False
        Label8.Visible = False
        Button1.Visible = False
        Button2.Visible = False
    End Sub
    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        ComboBox2.Visible = False
        ComboBox2.Items.Clear()
        Label3.Visible = False
        Button1.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            ComboBox1.Visible = True
            Label2.Visible = True

        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        ComboBox2.Visible = False
        Label2.Visible = False
        ComboBox1.Visible = False
        ComboBox2.Items.Clear()
        Label3.Visible = False
        Button1.Visible = False
        Button2.Visible = False
    End Sub

End Class
