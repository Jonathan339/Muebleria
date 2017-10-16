Public Class Ventas

    Private Sub VentasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.CompraArt' Puede moverla o quitarla según sea necesario.
        Me.CompraArtTableAdapter.Fill(Me.MuebleriaDataSet.CompraArt)
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Articulo' Puede moverla o quitarla según sea necesario.
        Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo)
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.MuebleriaDataSet.Ventas)


        'Id_ArticuloTextBox.Text = ""
        'Id_VentasTextBox.Text = ""
        Id_clienteTextBox.Text = ""




        'DataGridView1.Visible = False

    End Sub

    Private Sub Id_VentasTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        'If Asc(Chr(13)) Then
        '    Dim vista As New DataView
        '    vista.Table = Me.MuebleriaDataSet.Ventas
        '    vista.RowFilter = "Id_Ventas = " & Val(Id_VentasTextBox.Text)
        '    Me.VentasDataGridView.DataSource = vista

        'End If


    End Sub


    Private Sub Id_ArticuloTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        'If Asc(Chr(13)) Then
        '    Dim vista As New DataView
        '    vista.Table = Me.MuebleriaDataSet.Articulo
        '    vista.RowFilter = "Id_Articulo = " & Val(Id_ArticuloTextBox.Text)
        '    Me.VentasDataGridView.DataSource = vista
        'End If


    End Sub

    Private Sub Id_clienteTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Id_clienteTextBox.KeyPress

        'If Asc(Chr(13)) Then
        '    Dim vista As New DataView
        '    vista.Table = Me.MuebleriaDataSet.Ventas
        '    vista.RowFilter = "Id_cliente = " & Val(Id_clienteTextBox.Text)
        '    Me.DateTimePicker1.DataSource = vista

        'End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        DataGridView1.Visible = True

        Dim fila, contador, Total, filaConsulta As Integer
        fila = 0 'ir bajando lineas en el datagrid
        Total = 0 'sumo los subtotales
        filaConsulta = 0 'para hacer la consulta de la otra tabla
        DataGridView1.Rows.Clear() 'limpio la grilla 
        CompraArtBindingSource.MoveFirst() 'muevo al primer registro de la tabla
        Do
            If FechaDateTimePicker.Text <> "" And DateTimePicker1.Text <> "" And Id_clienteTextBox.Text <> "" Then
                If CompraArtBindingSource.Current("Fecha") >= Me.FechaDateTimePicker.Text And CompraArtBindingSource.Current("Fecha") <= Me.DateTimePicker1.Text And CompraArtBindingSource.Current("Id_cliente") = Id_clienteTextBox.Text Then 'esta para texto
                    DataGridView1.Rows.Add()
                    DataGridView1.Item(0, fila).Value = CompraArtBindingSource.Current("Id_Compra")
                    DataGridView1.Item(1, fila).Value = CompraArtBindingSource.Current("Id_cliente")

                    filaConsulta = Me.ArticuloBindingSource.Find("Id_Articulo", Me.CompraArtBindingSource.Current("Id_Articulo")) 'busco relacion

                    Me.ArticuloBindingSource.Position = filaConsulta

                    DataGridView1.Item(0, fila).Value = Me.ArticuloBindingSource.Current("Descripcion")
                    DataGridView1.Item(1, fila).Value = Me.CompraArtBindingSource.Current("Fecha")
                    DataGridView1.Item(2, fila).Value = Me.CompraArtBindingSource.Current("Id_cliente")
                    DataGridView1.Item(3, fila).Value = Me.CompraArtBindingSource.Current("Cantidad")
                    DataGridView1.Item(4, fila).Value = Me.CompraArtBindingSource.Current("importe")
                    DataGridView1.Item(5, fila).Value = Me.CompraArtBindingSource.Current("importe") * Me.CompraArtBindingSource.Current("Cantidad")


                    Total = Total + ArticuloBindingSource.Current("Precio")
                    fila = fila + 1 'para ir bajando lineas en la grilla
                End If
            End If
            
            contador = contador + 1
            CompraArtBindingSource.MoveNext()
        Loop Until contador = VentasBindingSource.Count
        If fila = 0 Then
            MsgBox("No se encontro el articulo")
        Else
            'creo una fila final con el total a facturar
            DataGridView1.Item(4, fila).Value = "Total facturado"
            DataGridView1.Item(5, fila).Value = Total
        End If
        Id_clienteTextBox.Focus()




    End Sub
End Class