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




        '-----------------------------------------------------------
        If ArticuloBindingSource.Current("Id_Articulo") = Val(Id_ArticuloTextBox.Text) Then
            DescripcionTextBox.Text = ArticuloBindingSource.Current("Descripcion")
            CategoriaComboBox.Text = ArticuloBindingSource.Current("Categoria")
            TipoComboBox.Text = ArticuloBindingSource.Current("Tipo")
            PrecioTextBox.Text = ArticuloBindingSource.Current("Precio")
            StockTextBox.Text = ArticuloBindingSource.Current("Stock")
            Stock_MinimoTextBox.Text = ArticuloBindingSource.Current("Stock_Minimo")
        End If
        
        
        '-------------------------------------------------------------

        Importe.Text = ArticuloBindingSource.Current("Precio")

        If NumericUpDown1.Value > 1 Then
            Importe.Text = Val(Importe.Text) * NumericUpDown1.Value
        End If


        'Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo)
        'Principal.ArticuloTableAdapter.Fill(Principal.MuebleriaDataSet.Articulo)




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'boton vender

        




    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

       
        'Importe.Text = NumericUpDown1.Value * Val(Importe.Text)

    End Sub
End Class