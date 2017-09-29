Public Class Actualizar_Precios

    Private Sub ArticuloBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.ArticuloBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)

    End Sub

    Private Sub Actualizar_Precios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.MuebleriaDataSet.Categoria)
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Articulo' Puede moverla o quitarla según sea necesario.
        Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo)
        ' Me.ArticuloBindingSource.AddNew()

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


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Boton Guardar
        Me.Validate()
        Me.ArticuloBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)
        Me.ArticuloTableAdapter.Fill(Me.MuebleriaDataSet.Articulo)

        'Me.ArticuloBindingSource.MoveLast()
        'Me.ArticuloBindingSource.AddNew()

        'limpio los textbox y pongo focus en  Id_Articulo

        
        TextBox1.Focus()






    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Asc(e.KeyChar) = 13 Then

            'consulta 2
            Dim fila As Integer
            fila = Me.ArticuloBindingSource.Find("Id_Articulo", TextBox1.Text)
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




    End Sub


    

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        Dim vista As New DataView
        vista.Table = Me.MuebleriaDataSet.Articulo
        vista.RowFilter = "Id_Articulo = " & Val(Me.TextBox1.Text)
        Me.ArticuloDataGridView.DataSource = vista

        'consulta 2
        Dim fila As Integer
        If TextBox1.Text <> "" Then
            fila = Me.ArticuloBindingSource.Find("Id_Articulo", TextBox1.Text) 'busca la fila del registro.
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
        






End Class