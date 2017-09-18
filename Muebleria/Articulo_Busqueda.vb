Public Class Articulo_Busqueda

    Private Sub ArticuloBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticuloBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)

    End Sub

    Private Sub Articulo_Busqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Articulo' Puede moverla o quitarla según sea necesario.
        Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo)

    End Sub

    Private Sub Buttodn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'busqueda
       
        

        For Each item As RadioButton In Me.Controls
            Dim fila As Integer
            Dim nombre As String
            nombre = item.Name + "TextBox.Text"

            If item.Checked Then
                If item.Name <> Id_ArticuloTextBox.Text Then
                    fila = Me.ArticuloBindingSource.Find(item.Name, nombre)
                    If fila <> -1 Then
                        ArticuloBindingSource.Position = fila
                        DescripcionTextBox.Text = ArticuloBindingSource.Current("Descripcion")
                        CategoriaComboBox.Text = ArticuloBindingSource.Current("Categoria")
                        TipoComboBox.Text = ArticuloBindingSource.Current("Tipo")
                        PrecioTextBox.Text = ArticuloBindingSource.Current("Precio")
                        StockTextBox.Text = ArticuloBindingSource.Current("Stock")
                        Stock_MinimoTextBox.Text = ArticuloBindingSource.Current("Stock_Minimo")

                    Else
                        fila = Me.ArticuloBindingSource.Find("Id_Articulo", nombre)
                        If fila <> -1 Then
                            ArticuloBindingSource.Position = fila
                            DescripcionTextBox.Text = ArticuloBindingSource.Current("Descripcion")
                            CategoriaComboBox.Text = ArticuloBindingSource.Current("Categoria")
                            TipoComboBox.Text = ArticuloBindingSource.Current("Tipo")
                            PrecioTextBox.Text = ArticuloBindingSource.Current("Precio")
                            StockTextBox.Text = ArticuloBindingSource.Current("Stock")
                            Stock_MinimoTextBox.Text = ArticuloBindingSource.Current("Stock_Minimo")

                        End If
                    End If
                End If
            End If

        Next





    End Sub

End Class