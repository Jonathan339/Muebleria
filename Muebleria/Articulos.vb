Public Class Articulos

    Private Sub ArticuloBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticuloBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)

    End Sub

    Private Sub Articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Tipo_Material' Puede moverla o quitarla según sea necesario.
        Me.Tipo_MaterialTableAdapter.Fill(Me.MuebleriaDataSet.Tipo_Material)
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.MuebleriaDataSet.Categoria)
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Articulo' Puede moverla o quitarla según sea necesario.
        Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo)


        ArticuloDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader




        'combo para tipo

        TipoComboBox.Items.Add("Algarrobo")
        TipoComboBox.Items.Add("Pino")
        TipoComboBox.Items.Add("Roble")
        TipoComboBox.Items.Add("Fibro facil")

        'combo para categoria
        CategoriaComboBox.Items.Add("Comedor")
        CategoriaComboBox.Items.Add("Cocina")
        CategoriaComboBox.Items.Add("Dormitorio")
        CategoriaComboBox.Items.Add("Living")
        CategoriaComboBox.Items.Add("Oficina")


        Me.ArticuloBindingSource.AddNew()



    End Sub

    Private Sub Id_ArticuloTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Id_ArticuloTextBox.KeyPress


        'en este evento se realiza la busqueda







    End Sub

    Private Sub Id_ArticuloTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id_ArticuloTextBox.TextChanged




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        'boton agregar y modificar
        
        Me.Validate()
        Me.ArticuloBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)
        Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo)

        Principal.ArticuloTableAdapter.Fill(Principal.MuebleriaDataSet.Articulo)

        Me.ArticuloBindingSource.MoveLast()
        Me.ArticuloBindingSource.AddNew()





    End Sub

    
End Class