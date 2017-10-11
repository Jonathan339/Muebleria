Public Class Vender

    Private Sub ArticuloBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticuloBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)

    End Sub

    Private Sub Vender_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.MuebleriaDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Articulo' Puede moverla o quitarla según sea necesario.
        Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo)


        '-------------------------------------------------------




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'boton vender

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
                If ArticuloBindingSource.Current("Stock") >= Val(Cantidad.Text) Then 'si true puedo alquilar

                    Me.ArticuloBindingSource.Current("Stock") = ArticuloBindingSource.Current("Stock") - Val(Cantidad.Text)

                    Me.VentasBindingSource.AddNew()
                    '--------------------------------

                    Me.VentasBindingSource.Current("Id_Articulo") = Val(Id_ArticuloTextBox.Text)

                    aux2 = DateTime.Now
                    Me.VentasBindingSource.Current("Fecha") = aux2
                    Me.VentasBindingSource.Current("Id_cliente") = Val(Id_clienteTextBox.Text)

                    '--------------------------------


                    Me.ArticuloBindingSource.EndEdit() 'cierro bd
                    Me.VentasTableAdapter.Update(Me.MuebleriaDataSet.Ventas)
                    Me.VentasTableAdapter.Fill(Me.MuebleriaDataSet.Ventas)





                    Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo) 'Para actualizar en el otro formulario la grilla
                    'actualizo la grilla del form principal
                    Principal.ArticuloTableAdapter.Fill(Principal.MuebleriaDataSet.Articulo)
                    'calculo el importe para mostrarlo
                    importe = Val(Cantidad.Text) * Me.ArticuloBindingSource.Current("Precio")
                    MsgBox("La venta a sido realizada con exito el importe es: " & importe & "  Pesos")


                    Principal.ArticuloTableAdapter.Fill(Principal.MuebleriaDataSet.Articulo) 'Actualizo la grilla



                    Me.VentasTableAdapter.Fill(Me.MuebleriaDataSet.Ventas) 'lleno la grilla de ventas con los datos

                Else
                    MsgBox("El stock es insuficiente, el stock actual es de: " & ArticuloBindingSource.Current("Cantidad") & " unidades")

                    'limpiar(Me) 'funcion limpiar textbox

                    Cantidad.Text = ""

                    Cantidad.Focus()

                End If
            End If
        End If



    End Sub

    

    Private Sub Cantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cantidad.TextChanged



        If Cantidad.Text <> "" Then

            Importe.Text = Val(Cantidad.Text) * Val(Importe.Text)

        End If


    End Sub

   
End Class