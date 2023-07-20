Imports System.Net.Security
Imports System.Numerics
Imports System.Windows.Forms.VisualStyles

Public Class Problema1
    'declaracion de numeros
    Public n1 As Double
    Public n2 As Double
    Public n3 As Double
    Public n4 As Double
    Public n5 As Double
    'declaracion de casillas
    Public Suma As Boolean
    Public Resta As Boolean
    Public Multiplicacion As Boolean
    Public Division As Boolean
    Public Exponente As Boolean
    Public Modulo As Boolean
    Public allcalc As Boolean
    Public nancasilla As Boolean
    'Declaracion de resultados 
    Public RSuma As Double
    Public RResta As Double
    Public RMultiplicacion As Double
    Public RDivision As Double
    Public RExponente As Double
    Public RModulo As Double
    Public Rallcalc As Double
    Public Rnancasilla As Double
    'load
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False


    End Sub

    'calculos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'valor de los texbox
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
                'valores vacios
                If TextBox1.Text = "" Then
                    Label5.Visible = True
                Else
                    Label5.Visible = False
                End If

                If TextBox2.Text = "" Then
                    Label11.Visible = True
                Else
                    Label11.Visible = False
                End If

                If TextBox3.Text = "" Then
                    Label12.Visible = True
                Else
                    Label12.Visible = False
                End If

                If TextBox4.Text = "" Then
                    Label13.Visible = True
                Else
                    Label13.Visible = False
                End If
                If TextBox5.Text = "" Then
                    Label14.Visible = True
                Else
                    Label14.Visible = False
                End If
                TextBox6.ForeColor = Color.Red
                TextBox6.Text = "-----------------------" & vbCrLf & "  Error :" & vbCrLf & "Asegurese de ingresar los 5 numeros."
                '-------------------------------
            Else
                'valores de los checkbox
                'casillas marcadas
                Suma = CheckBox1.Checked
                Resta = CheckBox2.Checked
                Multiplicacion = CheckBox3.Checked
                Division = CheckBox4.Checked
                Exponente = CheckBox5.Checked
                Modulo = CheckBox6.Checked
                allcalc = CheckBox7.Checked
                nancasilla = CheckBox8.Checked
                If Suma = False And Resta = False And Multiplicacion = False And Division = False And Exponente = False And Modulo = False And allcalc = False Then
                    TextBox6.ForeColor = Color.Red
                    TextBox6.Text = "-----------------------" & vbCrLf & "  Error :" & vbCrLf & "Marque una casilla para realizar una operacion."
                Else
                    'valores de los numeros
                    n1 = Convert.ToDouble(TextBox1.Text)
                    n2 = Convert.ToDouble(TextBox2.Text)
                    n3 = Convert.ToDouble(TextBox3.Text)
                    n4 = Convert.ToDouble(TextBox4.Text)
                    n5 = Convert.ToDouble(TextBox5.Text)
                    'calculos si marcan todas las casillas************************************************
                    If allcalc = True Then
                        '-----------------------------------------------------
                        RSuma = n1 + n2 + n3 + n4 + n5
                        RResta = n1 - n2 - n3 - n4 - n5
                        RMultiplicacion = n1 * n2 * n3 * n4 * n5
                        RDivision = n1 / n2 / n3 / n4 / n5
                        RExponente = n1 ^ n2 ^ n3 ^ n4 ^ n5
                        RModulo = n1 Mod n2 Mod n3 Mod n4 Mod n5
                        If (RExponente > Double.MaxValue) Or (RMultiplicacion > Double.MaxValue) Or (RDivision > Double.MaxValue) Or (RModulo > Double.MaxValue) Then
                            TextBox6.ForeColor = Color.Red
                            TextBox6.Text = "-----------------------" & vbCrLf & "  Error :" & vbCrLf & "Los valores ingresados exceden de la capacidad del programa. (" & Double.MaxValue & ")"
                        Else
                            'division
                            Dim numerador As Integer = CInt(RDivision * 100)
                            Dim denominador As Integer = 100
                            While numerador Mod 2 = 0 AndAlso denominador Mod 2 = 0
                                numerador \= 2
                                denominador \= 2
                            End While
                            While numerador Mod 5 = 0 AndAlso denominador Mod 5 = 0
                                numerador \= 5
                                denominador \= 5
                            End While
                            'impresion del valor de suma
                            Dim sumastring As String = ""
                            Dim restastring As String = ""
                            Dim multistring As String = ""
                            Dim exponstring As String = ""
                            Dim divstring As String = ""
                            If Integer.TryParse(RSuma, Nothing) Then
                                sumastring = RSuma.ToString("#,##0")
                            Else
                                If Decimal.TryParse(RSuma, Nothing) Then
                                    sumastring = RSuma.ToString("#,##0.00")
                                End If
                            End If
                            'impresion del valor de resta
                            If Integer.TryParse(RResta, Nothing) Then
                                restastring = RResta.ToString("#,##0")
                            Else
                                If Decimal.TryParse(RResta, Nothing) Then
                                    restastring = RResta.ToString("#,##0.00")
                                End If
                            End If
                            'impresion del valor de multi
                            If Integer.TryParse(RMultiplicacion, Nothing) Then
                                multistring = RMultiplicacion.ToString("#,##0")
                            Else
                                If Decimal.TryParse(RMultiplicacion, Nothing) Then
                                    multistring = RMultiplicacion.ToString("#,##0.00")
                                End If
                            End If
                            'impresion del valor de div
                            If Integer.TryParse(RDivision, Nothing) Then
                                divstring = RDivision.ToString("#,##0")
                            Else
                                If Decimal.TryParse(RDivision, Nothing) Then
                                    divstring = RDivision.ToString("#,##0.00")
                                End If
                            End If

                            'impresion del valor de expo
                            If RExponente <= 10000 Then

                                If Integer.TryParse(RExponente, Nothing) Then
                                    exponstring = RExponente.ToString("#,##0")
                                Else
                                    If Double.TryParse(RExponente, Nothing) Then
                                        exponstring = RExponente.ToString("#,##0.00")
                                    End If
                                End If
                            Else
                                If RExponente > 10000 And RExponente < 100000 Then
                                    'impresion del valor de exp 2
                                    If Integer.TryParse(RExponente, Nothing) Then
                                        exponstring = (RExponente).ToString("0.00E+0")
                                    Else
                                        If Double.TryParse(RExponente, Nothing) Then
                                            exponstring = (RExponente).ToString("0.00E+0")
                                        End If
                                    End If
                                Else
                                    If RExponente >= 100000 Then
                                        'impresion del valor de exp 2

                                        If Integer.TryParse(RExponente, Nothing) Then
                                            exponstring = (RExponente).ToString("0.0000E+0")
                                        Else
                                            If Double.TryParse(RExponente, Nothing) Then
                                                exponstring = (RExponente).ToString("0.0000E+0")
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            'fracciones
                            Dim stringdiv As String = ""
                            If RDivision <> 0 Then
                                stringdiv = divstring & "  |  " & numerador & "/" & denominador
                            Else
                                stringdiv = divstring
                            End If
                            'impresion final
                            MessageBox.Show("--------------------------------------------" & vbCrLf &
                                        " Numeros ingresados:" & vbCrLf &
                                        "   " & n1 & vbCrLf &
                                        "   " & n2 & vbCrLf &
                                        "   " & n3 & vbCrLf &
                                        "   " & n4 & vbCrLf &
                                        "   " & n5 & vbCrLf &
                                        "--------------------------------------------" & vbCrLf &
                                        " Suma :" & sumastring & vbCrLf &
                                        " Resta : " & restastring & vbCrLf &
                                        " Multiplicación : " & multistring & vbCrLf &
                                        " Division : " & stringdiv & vbCrLf &
                                        " Exponente : " & exponstring & vbCrLf &
                                        " Modulo : " & RModulo & vbCrLf, "Resultado")
                            '-----------------------------------------------------
                            TextBox6.ForeColor = Color.Green
                            TextBox6.Text = "--------------------------------" & vbCrLf &
                                            "       Complete successfully" & vbCrLf &
                                            "--------------------------------"
                        End If
                    Else
                        Dim cad1 As String = ""
                        Dim cad2 As String = ""
                        Dim cad3 As String = ""
                        Dim cad4 As String = ""
                        Dim cad5 As String = ""
                        Dim cad6 As String = ""
                        'tipo de impresion 
                        Dim sumastring As String = ""
                        Dim restastring As String = ""
                        Dim multistring As String = ""
                        Dim exponstring As String = ""
                        Dim divstring As String = ""
                        'calculos de suma************************************************
                        If Suma = True Then
                            RSuma = n1 + n2 + n3 + n4 + n5
                            If Integer.TryParse(RSuma, Nothing) Then
                                sumastring = RSuma.ToString("#,##0")
                            Else
                                If Decimal.TryParse(RSuma, Nothing) Then
                                    sumastring = RSuma.ToString("#,##0.00")
                                End If
                            End If
                            cad1 = " Suma: " & sumastring & vbCrLf
                        End If
                        'calculos de Resta************************************************
                        If Resta = True Then
                            RResta = n1 - n2 - n3 - n4 - n5
                            If Integer.TryParse(RResta, Nothing) Then
                                restastring = RResta.ToString("#,##0")
                            Else
                                If Decimal.TryParse(RResta, Nothing) Then
                                    restastring = RResta.ToString("#,##0.00")
                                End If
                            End If
                            cad2 = " Resta: " & restastring & vbCrLf
                        End If
                        'calculos de Multiplicacion************************************************
                        If Multiplicacion = True Then
                            RMultiplicacion = n1 * n2 * n3 * n4 * n5
                            If (RMultiplicacion > Double.MaxValue) Then
                                TextBox6.ForeColor = Color.Red
                                TextBox6.Text = "-----------------------" & vbCrLf & "  Error :" & vbCrLf & "Los valores ingresados exceden de la capacidad del programa. (" & Double.MaxValue & ")"
                            Else
                                If Integer.TryParse(RMultiplicacion, Nothing) Then
                                    restastring = RMultiplicacion.ToString("#,##0")
                                Else
                                    If Decimal.TryParse(RMultiplicacion, Nothing) Then
                                        restastring = RMultiplicacion.ToString("#,##0.00")
                                    End If
                                End If
                                cad3 = "Multiplicación: " & restastring & vbCrLf
                            End If
                        End If
                        'calculos de Division************************************************
                        If Division = True Then
                            RDivision = n1 / n2 / n3 / n4 / n5
                            If (RDivision > Double.MaxValue) Then
                                TextBox6.ForeColor = Color.Red
                                TextBox6.Text = "-----------------------" & vbCrLf & "  Error :" & vbCrLf & "Los valores ingresados exceden de la capacidad del programa. (" & Double.MaxValue & ")"
                            Else
                                'division
                                Dim numerador As Integer = CInt(RDivision * 100)
                                Dim denominador As Integer = 100
                                While numerador Mod 2 = 0 AndAlso denominador Mod 2 = 0
                                    numerador \= 2
                                    denominador \= 2
                                End While
                                While numerador Mod 5 = 0 AndAlso denominador Mod 5 = 0
                                    numerador \= 5
                                    denominador \= 5
                                End While
                                'impresion del valor de div
                                If Integer.TryParse(RDivision, Nothing) Then
                                    divstring = RDivision.ToString("#,##0")
                                Else
                                    If Decimal.TryParse(RDivision, Nothing) Then
                                        divstring = RDivision.ToString("#,##0.00")
                                    End If
                                End If
                                Dim stringdiv As String = ""
                                If RDivision <> 0 Then
                                    stringdiv = divstring & "  |  " & numerador & "/" & denominador
                                Else
                                    stringdiv = divstring
                                End If
                                cad4 = "Division : " & stringdiv & vbCrLf
                            End If
                        End If
                        'calculos de Exponente************************************************
                        If Exponente = True Then
                            RExponente = n1 ^ n2 ^ n3 ^ n4 ^ n5
                            If (RExponente > Double.MaxValue) Then
                                TextBox6.ForeColor = Color.Red
                                TextBox6.Text = "-----------------------" & vbCrLf & "  Error :" & vbCrLf & "Los valores ingresados exceden de la capacidad del programa. (" & Double.MaxValue & ")"
                            Else
                                'impresion del valor de expo
                                If RExponente <= 10000 Then

                                    If Integer.TryParse(RExponente, Nothing) Then
                                        exponstring = RExponente.ToString("#,##0")
                                    Else
                                        If Double.TryParse(RExponente, Nothing) Then
                                            exponstring = RExponente.ToString("#,##0.00")
                                        End If
                                    End If
                                Else
                                    If RExponente > 10000 And RExponente < 100000 Then
                                        'impresion del valor de exp 2
                                        If Integer.TryParse(RExponente, Nothing) Then
                                            exponstring = (RExponente).ToString("0.00E+0")
                                        Else
                                            If Double.TryParse(RExponente, Nothing) Then
                                                exponstring = (RExponente).ToString("0.00E+0")
                                            End If
                                        End If
                                    Else
                                        If RExponente >= 100000 Then
                                            'impresion del valor de exp 2

                                            If Integer.TryParse(RExponente, Nothing) Then
                                                exponstring = (RExponente).ToString("0.0000E+0")
                                            Else
                                                If Double.TryParse(RExponente, Nothing) Then
                                                    exponstring = (RExponente).ToString("0.0000E+0")
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                                cad5 = "Exponente : " & exponstring & vbCrLf
                            End If
                        End If
                        'calculos de Modulo************************************************
                        If Modulo = True Then
                            RModulo = n1 Mod n2 Mod n3 Mod n4 Mod n5
                            If (RModulo > Double.MaxValue) Then
                                TextBox6.ForeColor = Color.Red
                                TextBox6.Text = "-----------------------" & vbCrLf & "  Error :" & vbCrLf & "Los valores ingresados exceden de la capacidad del programa. (" & Double.MaxValue & ")"
                            Else
                                cad6 = "Modulo : " & RModulo
                            End If
                        End If
                        'decicion de impresion 
                        '*********************************************************************
                        'impresion final
                        Dim impr As String = cad1 & cad2 & cad3 & cad4 & cad5 & cad6
                        MessageBox.Show("--------------------------------------------" & vbCrLf &
                                    " Numeros ingresados:" & vbCrLf &
                                    "   " & n1 & vbCrLf &
                                    "   " & n2 & vbCrLf &
                                    "   " & n3 & vbCrLf &
                                    "   " & n4 & vbCrLf &
                                    "   " & n5 & vbCrLf &
                                    "--------------------------------------------" & vbCrLf &
                                    impr)
                        '**********************************************************************
                        '-----------------------------------------------------
                        TextBox6.ForeColor = Color.Green
                        TextBox6.Text = "--------------------------------" & vbCrLf &
                                        "       Complete successfully" & vbCrLf &
                                        "--------------------------------"
                    End If
                End If
                '-------------------------------
            End If
        Catch ex As Exception
            TextBox6.ForeColor = Color.Red
            TextBox6.Text = "-----------------------" & vbCrLf & "  Error :" & vbCrLf & "    El valor introdcido es incorrecto"
        End Try
    End Sub
    'Finalizar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        offp1()
    End Sub
    'limpiar
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Limp()
    End Sub

    'funcion limpiar
    Public Sub Limp()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        TextBox6.ForeColor = Color.Green
        TextBox6.Text = "-----------------------" & vbCrLf & " Campos vacios."
    End Sub
    'funcion finalizar
    Public Sub Offp1()
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar el calculo?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            Me.Close()
        End If
    End Sub

    'teclado permitido
    'n1
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'Permitir solo números decimales y enteros, tanto positivos como negativos
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If

        'Permitir solo un signo menos al principio
        If e.KeyChar = "-" AndAlso sender.Text.IndexOf("-") > -1 Then
            e.Handled = True
        ElseIf e.KeyChar = "-" AndAlso sender.SelectionStart <> 0 Then
            e.Handled = True
        End If

        'Permitir solo un punto decimal
        If e.KeyChar = "." AndAlso sender.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If

    End Sub
    'n2
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        'Permitir solo números decimales y enteros, tanto positivos como negativos
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If

        'Permitir solo un signo menos al principio
        If e.KeyChar = "-" AndAlso sender.Text.IndexOf("-") > -1 Then
            e.Handled = True
        ElseIf e.KeyChar = "-" AndAlso sender.SelectionStart <> 0 Then
            e.Handled = True
        End If

        'Permitir solo un punto decimal
        If e.KeyChar = "." AndAlso sender.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If

    End Sub
    'n3
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        'Permitir solo números decimales y enteros, tanto positivos como negativos
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If

        'Permitir solo un signo menos al principio
        If e.KeyChar = "-" AndAlso sender.Text.IndexOf("-") > -1 Then
            e.Handled = True
        ElseIf e.KeyChar = "-" AndAlso sender.SelectionStart <> 0 Then
            e.Handled = True
        End If

        'Permitir solo un punto decimal
        If e.KeyChar = "." AndAlso sender.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If

    End Sub
    'n4
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        'Permitir solo números decimales y enteros, tanto positivos como negativos
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If

        'Permitir solo un signo menos al principio
        If e.KeyChar = "-" AndAlso sender.Text.IndexOf("-") > -1 Then
            e.Handled = True
        ElseIf e.KeyChar = "-" AndAlso sender.SelectionStart <> 0 Then
            e.Handled = True
        End If

        'Permitir solo un punto decimal
        If e.KeyChar = "." AndAlso sender.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If

    End Sub
    'n5
    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        'Permitir solo números decimales y enteros, tanto positivos como negativos
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If

        'Permitir solo un signo menos al principio
        If e.KeyChar = "-" AndAlso sender.Text.IndexOf("-") > -1 Then
            e.Handled = True
        ElseIf e.KeyChar = "-" AndAlso sender.SelectionStart <> 0 Then
            e.Handled = True
        End If

        'Permitir solo un punto decimal
        If e.KeyChar = "." AndAlso sender.Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If

    End Sub

    Private Sub CheckBox8_click(sender As Object, e As EventArgs) Handles CheckBox8.Click

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
    End Sub

    Private Sub CheckBox7_Click(sender As Object, e As EventArgs) Handles CheckBox7.Click

        CheckBox8.Checked = False
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
        CheckBox5.Checked = True
        CheckBox6.Checked = True
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        CheckBox8.Checked = False
        CheckBox7.Checked = False
    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        CheckBox8.Checked = False
        CheckBox7.Checked = False
    End Sub

    Private Sub CheckBox3_Click(sender As Object, e As EventArgs) Handles CheckBox3.Click
        CheckBox8.Checked = False
        CheckBox7.Checked = False
    End Sub
    Private Sub CheckBox4_Click(sender As Object, e As EventArgs) Handles CheckBox4.Click
        CheckBox8.Checked = False
        CheckBox7.Checked = False
    End Sub
    Private Sub CheckBox5_Click(sender As Object, e As EventArgs) Handles CheckBox5.Click
        CheckBox8.Checked = False
        CheckBox7.Checked = False
    End Sub
    Private Sub CheckBox6_Click(sender As Object, e As EventArgs) Handles CheckBox6.Click
        CheckBox8.Checked = False
        CheckBox7.Checked = False
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
            TextBox3.Select()
        End If
    End Sub
    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            TextBox4.Select()
        End If
    End Sub
    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            TextBox5.Select()
        End If
    End Sub
    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Agrega aquí la acción que deseas realizar
            Button1.Select()
        End If
    End Sub
End Class