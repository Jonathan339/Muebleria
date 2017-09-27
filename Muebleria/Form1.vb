Public Class Principal

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
        ComboBox1.Items.Add("Precio")



        Label1.Visible = False
        Label2.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        





    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click

        'cierra la aplicacion
        End

    End Sub

    Private Sub AjusteDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjusteDeToolStripMenuItem.Click






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

        'busqueda con combobox simple

        Dim fila As Integer
        

        If ComboBox1.SelectedItem <> "" And TextBox1.Text <> "" Then
            fila = Me.ArticuloBindingSource.Find(Me.ComboBox1.SelectedItem, TextBox1.Text)
            If fila <> -1 Then
                ArticuloBindingSource.Position = fila
                Me.DataGridViewTextBoxColumn1.Name = ArticuloBindingSource.Current("Id_Articulo")
                Me.DataGridViewTextBoxColumn2.Name = ArticuloBindingSource.Current("Descripcion")
                Me.DataGridViewTextBoxColumn3.Name = ArticuloBindingSource.Current("Categoria")
                Me.DataGridViewTextBoxColumn4.Name = ArticuloBindingSource.Current("Tipo")
                Me.DataGridViewTextBoxColumn5.Name = ArticuloBindingSource.Current("Precio")
                Me.DataGridViewTextBoxColumn6.Name = ArticuloBindingSource.Current("Stock")
                Me.DataGridViewTextBoxColumn7.Name = ArticuloBindingSource.Current("Stock_Minimo")


                'buscar solucion a la seleccion de la fila del registro.
                'no selecciona coloreando el registro que encontro
                Me.ArticuloDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            End If
        Else
            MsgBox("Por favor Ingrese los datos para realizar la busqueda.")
        End If



        'busqueda por combo y precio

        







    End Sub





    Private Sub ArticuloDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ArticuloDataGridView.CellContentClick





    End Sub

    

    
   
    
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedItem = "Precio" Then
            Label1.Visible = True
            Label2.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
        End If

    End Sub
End Class
