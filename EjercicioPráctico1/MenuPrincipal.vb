
Imports System.Threading
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports EjercicioPráctico1.Problema1
Imports EjercicioPráctico1.Problema2
Imports EjercicioPráctico1.Problema3
Imports EjercicioPráctico1.Soporte


Public Class MenuPrincipal
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Problema1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Problema1ToolStripMenuItem1.Click
        Dim mensaje As New Problema1
        'verificacion de uso de programa:
        If Application.OpenForms().OfType(Of Problema1)().Any And Application.OpenForms().OfType(Of Problema2)().Any Then
            ' Form1 and Form2 and form 3 estan abiertos
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Problema1)().Any Then
            ' Form1 is open
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Problema2)().Any Then
            ' Form2 is open
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Problema3)().Any Then
            ' Form2 is open
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Soporte)().Any Then
            ' Soporte is open
            Soporte.Close()
        Else            ' Si no hay nada abierto
            mensaje.Show()
            mensaje.MdiParent = Me
            Me.Panel1.Controls.Add(mensaje)
        End If
    End Sub

    Private Sub MenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea salir de la aplicacion?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub
    'Problema 2-conversion de monedas
    Private Sub Problema2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Problema2ToolStripMenuItem1.Click
        Dim mensaje2 As New Problema2
        'verificacion de uso de programa:
        If Application.OpenForms().OfType(Of Problema1)().Any And Application.OpenForms().OfType(Of Problema2)().Any And Application.OpenForms().OfType(Of Problema3)().Any Then
            ' Form1 and Form2 and form 3 estan abiertos
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Problema1)().Any Then
            ' Form2 is open
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Problema2)().Any Then
            ' Form3 is open
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Soporte)().Any Then
            ' Form4 is open
            Soporte.Close()
        Else
            ' Si no hay nada abierto
            mensaje2.Show()
        End If
    End Sub

    Private Sub SoporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoporteToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of Problema1)().Any And Application.OpenForms().OfType(Of Problema2)().Any And Application.OpenForms().OfType(Of Problema3)().Any And Application.OpenForms().OfType(Of Soporte)().Any Then
            ' Form1 and Form2 estan abiertos
            Problema1.Close()
            Problema2.Close()
            Problema3.Close()
        ElseIf Application.OpenForms().OfType(Of Problema1)().Any Then
            ' Form2 is open
            Problema1.Close()
        ElseIf Application.OpenForms().OfType(Of Problema2)().Any Then
            ' Form2 is open
            Problema2.Close()
        ElseIf Application.OpenForms().OfType(Of Problema3)().Any Then
            ' Form3 is open
            Problema3.Close()
        End If
        Soporte.Show()
        Soporte.MdiParent = Me
        Me.Panel1.Controls.Add(Soporte)
    End Sub

    Private Sub Problema3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema3ToolStripMenuItem.Click
        Dim mensaje As New Problema3
        'verificacion de uso de programa:
        If Application.OpenForms().OfType(Of Problema1)().Any And Application.OpenForms().OfType(Of Problema2)().Any And Application.OpenForms().OfType(Of Problema3)().Any Then
            ' Form1 and Form2 and form 3 estan abiertos
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Problema1)().Any Then
            ' Form2 is open
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Problema2)().Any Then
            ' Form3 is open
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Soporte)().Any Then
            ' Form4 is open
            Soporte.Close()
        Else
            ' Si no hay nada abierto
            mensaje.Show()
        End If
    End Sub


End Class
