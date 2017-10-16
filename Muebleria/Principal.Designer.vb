<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregarModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizaciónPreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AjusteDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregarModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MostrarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MuebleriaDataSet = New WindowsApplication1.MuebleriaDataSet
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticuloTableAdapter = New WindowsApplication1.MuebleriaDataSetTableAdapters.ArticuloTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager
        Me.ArticuloDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.EliminarClinteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MuebleriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticuloToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.VentasToolStripMenuItem, Me.VendedoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(761, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArticuloToolStripMenuItem
        '
        Me.ArticuloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarModificarToolStripMenuItem, Me.ActualizaciónPreciosToolStripMenuItem, Me.AjusteDeToolStripMenuItem})
        Me.ArticuloToolStripMenuItem.Name = "ArticuloToolStripMenuItem"
        Me.ArticuloToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ArticuloToolStripMenuItem.Text = "Articulos"
        '
        'AgregarModificarToolStripMenuItem
        '
        Me.AgregarModificarToolStripMenuItem.Name = "AgregarModificarToolStripMenuItem"
        Me.AgregarModificarToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AgregarModificarToolStripMenuItem.Text = "Agregar articulo"
        '
        'ActualizaciónPreciosToolStripMenuItem
        '
        Me.ActualizaciónPreciosToolStripMenuItem.Name = "ActualizaciónPreciosToolStripMenuItem"
        Me.ActualizaciónPreciosToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ActualizaciónPreciosToolStripMenuItem.Text = "Actualización de Precios"
        '
        'AjusteDeToolStripMenuItem
        '
        Me.AjusteDeToolStripMenuItem.Name = "AjusteDeToolStripMenuItem"
        Me.AjusteDeToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AjusteDeToolStripMenuItem.Text = "Ajuste de Stock"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarModificarToolStripMenuItem1, Me.BuscarToolStripMenuItem, Me.EliminarClinteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AgregarModificarToolStripMenuItem1
        '
        Me.AgregarModificarToolStripMenuItem1.Name = "AgregarModificarToolStripMenuItem1"
        Me.AgregarModificarToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.AgregarModificarToolStripMenuItem1.Text = "Agregar/Modificar"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar cliente"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarVentasToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'MostrarVentasToolStripMenuItem
        '
        Me.MostrarVentasToolStripMenuItem.Name = "MostrarVentasToolStripMenuItem"
        Me.MostrarVentasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MostrarVentasToolStripMenuItem.Text = "Mostrar ventas"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem})
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Agregar empleado"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MuebleriaDataSet
        '
        Me.MuebleriaDataSet.DataSetName = "MuebleriaDataSet"
        Me.MuebleriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticuloBindingSource
        '
        Me.ArticuloBindingSource.DataMember = "Articulo"
        Me.ArticuloBindingSource.DataSource = Me.MuebleriaDataSet
        '
        'ArticuloTableAdapter
        '
        Me.ArticuloTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticuloTableAdapter = Me.ArticuloTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.SucursalTableAdapter = Nothing
        Me.TableAdapterManager.Tipo_MaterialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ArticuloDataGridView
        '
        Me.ArticuloDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArticuloDataGridView.AutoGenerateColumns = False
        Me.ArticuloDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ArticuloDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ArticuloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticuloDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ArticuloDataGridView.DataSource = Me.ArticuloBindingSource
        Me.ArticuloDataGridView.Location = New System.Drawing.Point(12, 97)
        Me.ArticuloDataGridView.Name = "ArticuloDataGridView"
        Me.ArticuloDataGridView.Size = New System.Drawing.Size(737, 224)
        Me.ArticuloDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Articulo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Articulo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Stock"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Stock_Minimo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Stock_Minimo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(737, 55)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(256, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 20)
        Me.TextBox1.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(120, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Buscar por"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EliminarClinteToolStripMenuItem
        '
        Me.EliminarClinteToolStripMenuItem.Name = "EliminarClinteToolStripMenuItem"
        Me.EliminarClinteToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.EliminarClinteToolStripMenuItem.Text = "Eliminar clinte"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 333)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ArticuloDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "M"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MuebleriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArticuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarModificarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizaciónPreciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjusteDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MuebleriaDataSet As WindowsApplication1.MuebleriaDataSet
    Friend WithEvents ArticuloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticuloTableAdapter As WindowsApplication1.MuebleriaDataSetTableAdapters.ArticuloTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArticuloDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MostrarVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarClinteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
