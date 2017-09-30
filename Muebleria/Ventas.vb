Public Class Ventas

    Private Sub VentasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MuebleriaDataSet)

    End Sub

    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleriaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.MuebleriaDataSet.Ventas)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim vista As New DataView
        If Id_ArticuloTextBox.Text <> "" Then
            'Dim vista As New DataView
            vista.Table = Me.MuebleriaDataSet.Articulo
            vista.RowFilter = "Id_Articulo = " & Val(Id_ArticuloTextBox.Text)
            Me.VentasDataGridView.DataSource = vista

        ElseIf Id_clienteTextBox.Text <> "" Then 'busca por cliente
            vista.Table = Me.MuebleriaDataSet.Ventas
            vista.RowFilter = "Id_cliente = " & Val(Id_clienteTextBox.Text)
            Me.VentasDataGridView.DataSource = vista

        ElseIf Id_VentasTextBox.Text <> "" Then 'busca por Id_ventas
            vista.Table = Me.MuebleriaDataSet.Ventas
            vista.RowFilter = "Id_Ventas = " & Val(Id_VentasTextBox.Text)
            Me.VentasDataGridView.DataSource = vista

        ElseIf FechaDateTimePicker.Text <> "" And DateTimePicker1.Text <> "" Then 'busca por fecha
            Dim desde As String = FechaDateTimePicker.Text
            Dim hasta As String = DateTimePicker1.Text
            If VentasBindingSource.Current("Fecha") <> CInt(desde) And VentasBindingSource.Current("Fecha") <> CInt(hasta) Then
                MsgBox("No se encontraron ventas en esas fechas.")
            Else

                vista.RowFilter = "Fecha = " & Val(desde) And Val(hasta)
                Me.VentasDataGridView.DataSource = vista
                If Me.FechaDateTimePicker.Text Then

                End If
            End If
        End If




    End Sub
End Class