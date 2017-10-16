Public Class Vender

    Private Sub ArticuloBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticuloBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.MuebleriaDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Articulo' Puede moverla o quitarla según sea necesario.
        Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo)

        '--------------------------------









    End Sub

    Private Sub Cantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cantidad.TextChanged

        If Cantidad.Text <> "" Then

            Importe.Text = Val(Cantidad.Text) * Val(Importe.Text)

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'boton ventas

        Dim fila, CodConsulta, aux, importe As Integer
        Dim aux2 As Date

        CodConsulta = Val(Id_ArticuloTextBox.Text)
        fila = Me.ArticuloBindingSource.Find("Id_articulo", CodConsulta) 'me dice la posicion arranca de 0

        If fila = -1 Then
            'no se encontro ultimo registro es -1
            MsgBox("El registro no se encontro")
        Else
            'Se encontro
            ArticuloBindingSource.Position = fila ' Mover el cursor a la fila obtenida con esto muestro
            aux = MsgBox("Quiere realizar esta venta Cod_articulo: " & CodConsulta, 32 + 1, "Vender")
            If aux = 1 Then
                If ArticuloBindingSource.Current("Stock") >= Val(Cantidad.Text) Then 'si true puedo vender
                    'guardo la transaccion en la tabla venta-----------------------------------------------

                    Me.VentasBindingSource.AddNew()
                    Me.VentasBindingSource.Current("Id_articulo") = ArticuloBindingSource.Current("Id_articulo")

                    'Me.VentasBindingSource.Current("Cantidad") = Val(Cantidad.Text)

                    aux2 = DateTime.Now
                    Me.VentasBindingSource.Current("Fecha") = aux2
                    'Me.VenBindingSource.Current("Precio") = Val(Cantidad.Text) * Me.ArticuloBindingSource.Current("Precio")
                    Me.VentasBindingSource.Current("Id_cliente") = Val(Id_cliente.Text)
                    Me.VentasBindingSource.EndEdit()
                    Me.VentasTableAdapter.Update(Me.MuebleriaDataSet.Ventas)

                    '------------------------------------------

                    'aca trabajo sobre la tabla stock descuento la cantidad vendida
                    Me.ArticuloBindingSource.Current("Stock") = ArticuloBindingSource.Current("Stock") - Val(Cantidad.Text)
                    'error coregir con lo que pase anteriormente
                    importe = Val(Cantidad.Text) * Me.ArticuloBindingSource.Current("Precio")
                    'muestro el cambio e el stock en el textbox

                    StockTextBox.Text = ArticuloBindingSource.Current("Stock")
                    'limpio los textbox de cantidad y cliente
                    Cantidad.Text = ""
                    Id_cliente.Text = ""


                    'muestro un mensaje
                    MsgBox("La venta a sido realizada con exito el importe es:" & importe & " Pesos")
                    Me.ArticuloBindingSource.EndEdit() 'cierro bd
                    Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet) 'grabo en disco las dos tablas
                    Principal.ArticuloTableAdapter.Fill(Principal.MuebleriaDataSet.Articulo) 'Para actualizar en el otro formulario la grilla
                    Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo) 'Actualizo la grilla stock
                    Me.VentasTableAdapter.Fill(Me.MuebleriaDataSet.Ventas) 'actualizo la grilla ventas


                Else
                    MsgBox("El stock es insuficiente, el stock actual es de: " & ArticuloBindingSource.Current("Cantidad") & " unidades")
                    limpiar(Me) 'funcion limpiar textbox
                    'TextBox1.Text = ""
                    'TextBox2.Text = ""
                    Cantidad.Focus()

                End If
            End If
        End If






    End Sub

    Private Sub Id_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_cliente.TextChanged



        'If Not IsNumeric(Id_cliente.Text) Then
        '    MsgBox("solo ingrese numero de cliente sin letras o caracteres")
        'End If


    End Sub
End Class