﻿Public Class Principal

    Private Sub AgregarModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarModificarToolStripMenuItem.Click

        Articulos.Show()

    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Articulo_Busqueda.Show()
    End Sub

   

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Articulo' Puede moverla o quitarla según sea necesario.
        Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo)



        'Nombre de las tablas
        ComboBox1.Items.Add("Id_Articulo")
        ComboBox1.Items.Add("Descripcion")
        ComboBox1.Items.Add("Categoria")
        ComboBox1.Items.Add("Tipo")

        'configuracion del textbox para busqueda

        




    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click

        'cierra la aplicacion
        End

    End Sub


    Private Sub ActualizaciónPreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizaciónPreciosToolStripMenuItem.Click

        'form actualiza precios
        Actualizar_Precios.Show()

    End Sub

    Private Sub ArticuloBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticuloBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'busqueda con combobox


        If ComboBox1.SelectedItem <> "" And TextBox1.Text <> "" Then
            If ComboBox1.SelectedItem = "Id_Articulo" Then
                If IsNumeric(TextBox1.Text) Then
                    Dim vista As New DataView
                    vista.Table = Me.MuebleriaDataSet.Articulo
                    vista.RowFilter = "Id_Articulo = " & Val(Me.TextBox1.Text)
                    Me.ArticuloDataGridView.DataSource = vista
                Else
                    MsgBox("El ID debe ser un numero sin letras.")
                End If


            ElseIf ComboBox1.SelectedItem = "Descripcion" Then
                Dim vista As New DataView
                vista.Table = Me.MuebleriaDataSet.Articulo
                vista.RowFilter = "Descripcion like '" & Me.TextBox1.Text & "%'"
                Me.ArticuloDataGridView.DataSource = vista

            ElseIf ComboBox1.SelectedItem = "Categoria" Then

            ElseIf ComboBox1.SelectedItem = "Tipo" Then
                Dim vista As New DataView
                vista.Table = Me.MuebleriaDataSet.Articulo
                vista.RowFilter = "Tipo like '" & Me.TextBox1.Text & "%'"
                Me.ArticuloDataGridView.DataSource = vista

            End If

        Else
            MsgBox("Porfavor ingrese datos.")
        End If


    End Sub


    Private Sub MostrarVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarVentasToolStripMenuItem.Click

        'form ventas
        Ventas.Show()

    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click

        'form vendedores
        Vendedores.Show()
    End Sub


    Private Sub AgregarModificarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarModificarToolStripMenuItem1.Click

        'form clientes
        Cliente.Show()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If ComboBox1.SelectedItem <> "" And TextBox1.Text <> "" Then
                If ComboBox1.SelectedItem = "Id_Articulo" Then
                    If IsNumeric(TextBox1.Text) Then
                        Dim vista As New DataView
                        vista.Table = Me.MuebleriaDataSet.Articulo
                        vista.RowFilter = "Id_Articulo = " & Val(Me.TextBox1.Text)
                        Me.ArticuloDataGridView.DataSource = vista
                    Else
                        MsgBox("El ID debe ser un numero sin letras.")
                    End If
                    

                ElseIf ComboBox1.SelectedItem = "Descripcion" Then
                    Dim vista As New DataView
                    vista.Table = Me.MuebleriaDataSet.Articulo
                    vista.RowFilter = "Descripcion like '" & Me.TextBox1.Text & "%'"
                    Me.ArticuloDataGridView.DataSource = vista

                ElseIf ComboBox1.SelectedItem = "Categoria" Then

                ElseIf ComboBox1.SelectedItem = "Tipo" Then
                    Dim vista As New DataView
                    vista.Table = Me.MuebleriaDataSet.Articulo
                    vista.RowFilter = "Tipo like '" & Me.TextBox1.Text & "%'"
                    Me.ArticuloDataGridView.DataSource = vista

                End If

            Else
                MsgBox("Porfavor ingrese datos.")
            End If
        End If



    End Sub


    Private Sub AjusteDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjusteDeToolStripMenuItem.Click


        Ajuste_de_Stock.Show()
    End Sub

    Private Sub ArticuloDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ArticuloDataGridView.CellContentClick

    End Sub

    Private Sub ArticuloDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ArticuloDataGridView.DoubleClick

        Dim CodConsulta, fila, aux As Integer

        If ComboBox1.SelectedItem = "Id_Articulo" Then
            CodConsulta = TextBox1.Text
            fila = ArticuloBindingSource.Find("Id_Articulo", CodConsulta) 'me dice la posicion arranca de 0
            If fila = -1 Then
                MsgBox("No se encontro el Articulo")
            Else
                'se encontro
                ArticuloBindingSource.Position = fila ' mover el cursor a la fila obtenida con esto muestro
                aux = MsgBox("¿Quiere realizar esta venta?", 32 + 1, "¿Vender?")
                If aux = 1 Then

                    Vender.Show()
                    Vender.Id_ArticuloTextBox.Text = ArticuloBindingSource.Current("Id_Articulo")
                    Vender.Id_ArticuloTextBox1.Text = ArticuloBindingSource.Current("Id_Articulo")

                    Vender.DescripcionTextBox.Text = ArticuloBindingSource.Current("Descripcion")
                    Vender.CategoriaComboBox.Text = ArticuloBindingSource.Current("Categoria")
                    Vender.TipoComboBox.Text = ArticuloBindingSource.Current("Tipo")
                    Vender.PrecioTextBox.Text = ArticuloBindingSource.Current("Precio")
                    'Vender.Importe.Text = ArticuloBindingSource.Current("Precio")
                    Vender.StockTextBox.Text = ArticuloBindingSource.Current("Stock")
                    Vender.Stock_MinimoTextBox.Text = ArticuloBindingSource.Current("Stock_Minimo")


                End If
            End If
        End If
        


        



    End Sub
End Class
