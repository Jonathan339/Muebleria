Public Class Ajuste_de_Stock

    Private Sub ArticuloBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.ArticuloBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)



    End Sub

    Private Sub Ajuste_de_Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Articulo' Puede moverla o quitarla según sea necesario.
        Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo)
        'Me.ArticuloBindingSource.AddNew()

    End Sub

    Private Sub Id_ArticuloTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Id_ArticuloTextBox.KeyPress

        Dim vista As New DataView
        vista.Table = Me.MuebleriaDataSet.Articulo
        vista.RowFilter = "Id_Articulo = " & Val(Id_ArticuloTextBox.Text)
        Me.ArticuloDataGridView.DataSource = vista

        'consulta 2

        Dim fila As Integer
        If Id_ArticuloTextBox.Text <> "" Then
            fila = Me.ArticuloBindingSource.Find("Id_Articulo", Id_ArticuloTextBox.Text) 'busca la fila del registro.
            If fila = -1 Then ' Si no se encuentra el articulo muestra un mensaje.
                MsgBox("El articulo ingresado no se encuentra o no existe.")
            Else
                ArticuloBindingSource.Position = fila
                DescripcionTextBox.Text = ArticuloBindingSource.Current("Descripcion")
                CategoriaComboBox.Text = ArticuloBindingSource.Current("Categoria")
                TipoComboBox.Text = ArticuloBindingSource.Current("Tipo")
                PrecioTextBox.Text = ArticuloBindingSource.Current("Precio")
                StockTextBox.Text = ArticuloBindingSource.Current("Stock")
                Stock_MinimoTextBox.Text = ArticuloBindingSource.Current("Stock_Minimo")
            End If
        End If





    End Sub



    Private Sub Id_ArticuloTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_ArticuloTextBox.TextChanged

        Dim vista As New DataView
        vista.Table = Me.MuebleriaDataSet.Articulo
        vista.RowFilter = "Id_Articulo = " & Val(Id_ArticuloTextBox.Text)
        Me.ArticuloDataGridView.DataSource = vista

        'consulta 2

        Dim fila As Integer
        If Id_ArticuloTextBox.Text <> "" Then
            fila = Me.ArticuloBindingSource.Find("Id_Articulo", Id_ArticuloTextBox.Text) 'busca la fila del registro.
            If fila = -1 Then ' Si no se encuentra el articulo muestra un mensaje.
                MsgBox("El articulo ingresado no se encuentra o no existe.")
            Else
                ArticuloBindingSource.Position = fila
                DescripcionTextBox.Text = ArticuloBindingSource.Current("Descripcion")
                CategoriaComboBox.Text = ArticuloBindingSource.Current("Categoria")
                TipoComboBox.Text = ArticuloBindingSource.Current("Tipo")
                PrecioTextBox.Text = ArticuloBindingSource.Current("Precio")
                StockTextBox.Text = ArticuloBindingSource.Current("Stock")
                Stock_MinimoTextBox.Text = ArticuloBindingSource.Current("Stock_Minimo")

            End If
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        'Boton Guardar
        Me.Validate()
        Me.ArticuloBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)
        'Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo)


    End Sub
End Class