Imports System.Math
Public Class Form1
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles lblR2.Click

    End Sub


    Const precioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagosinIVA As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoconiva As Double = 0
    Dim descuento As Double = 0
    Dim pagofinal As Double = 0
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' aqui va el codigo relacionado a los calculos de los pagos
        pagosinIVA = (Val(txtArroz.Text) * precioArroz) + (Val(txtFrijol.Text) * precioFrijol) + (Val(txtAzucar.Text) * precioAzucar)

        valorIVA = pagosinIVA * IVA
        pagoconiva = pagosinIVA + valorIVA
        descuento = (pagoconiva * 0.025)
        pagofinal = pagoconiva - descuento

        lblR1.Text = pagosinIVA
        lblR2.Text = valorIVA
        lblR3.Text = pagoconiva
        lblR4.Text = descuento
        lblR5.Text = pagofinal

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'aqui va el codigo relacionado a limpiar todas las variables
        txtArroz.Clear()
        txtFrijol.Clear()
        txtAzucar.Clear()


        lblR1.Text = String.Empty
        lblR2.Text = String.Empty
        lblR3.Text = String.Empty
        lblR4.Text = String.Empty
        lblR5.Text = String.Empty

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'aqui va el codigo que pregunta si queremos cerrar la app
        End
    End Sub

    Private Sub txtArroz_MouseMove(sender As Object, e As MouseEventArgs) Handles txtArroz.MouseMove

    End Sub

    Private Sub txtArroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArroz.KeyPress
        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrijol.KeyPress
        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAzucar_TextChanged(sender As Object, e As EventArgs) Handles txtAzucar.TextChanged

    End Sub

    Private Sub txtAzucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAzucar.KeyPress
        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
