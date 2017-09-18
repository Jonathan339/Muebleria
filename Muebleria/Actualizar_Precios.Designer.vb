<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualizar_Precios
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
        Dim Id_ArticuloLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim Stock_MinimoLabel As System.Windows.Forms.Label
        Me.MuebleriaDataSet = New WindowsApplication1.MuebleriaDataSet
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticuloTableAdapter = New WindowsApplication1.MuebleriaDataSetTableAdapters.ArticuloTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager
        Me.Id_ArticuloTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox
        Me.TipoComboBox = New System.Windows.Forms.ComboBox
        Me.PrecioTextBox = New System.Windows.Forms.TextBox
        Me.StockTextBox = New System.Windows.Forms.TextBox
        Me.Stock_MinimoTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Id_ArticuloLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        CategoriaLabel = New System.Windows.Forms.Label
        TipoLabel = New System.Windows.Forms.Label
        PrecioLabel = New System.Windows.Forms.Label
        StockLabel = New System.Windows.Forms.Label
        Stock_MinimoLabel = New System.Windows.Forms.Label
        CType(Me.MuebleriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'Id_ArticuloLabel
        '
        Id_ArticuloLabel.AutoSize = True
        Id_ArticuloLabel.Location = New System.Drawing.Point(6, 24)
        Id_ArticuloLabel.Name = "Id_ArticuloLabel"
        Id_ArticuloLabel.Size = New System.Drawing.Size(57, 13)
        Id_ArticuloLabel.TabIndex = 1
        Id_ArticuloLabel.Text = "Id Articulo:"
        '
        'Id_ArticuloTextBox
        '
        Me.Id_ArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Id_Articulo", True))
        Me.Id_ArticuloTextBox.Location = New System.Drawing.Point(86, 21)
        Me.Id_ArticuloTextBox.Name = "Id_ArticuloTextBox"
        Me.Id_ArticuloTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Id_ArticuloTextBox.TabIndex = 2
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(6, 50)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(86, 47)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(6, 76)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel.TabIndex = 5
        CategoriaLabel.Text = "Categoria:"
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Categoria", True))
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Location = New System.Drawing.Point(86, 73)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CategoriaComboBox.TabIndex = 6
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(6, 103)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 7
        TipoLabel.Text = "Tipo:"
        '
        'TipoComboBox
        '
        Me.TipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Tipo", True))
        Me.TipoComboBox.FormattingEnabled = True
        Me.TipoComboBox.Location = New System.Drawing.Point(86, 100)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TipoComboBox.TabIndex = 8
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(6, 130)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 9
        PrecioLabel.Text = "Precio:"
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(86, 127)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PrecioTextBox.TabIndex = 10
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(6, 156)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 13)
        StockLabel.TabIndex = 11
        StockLabel.Text = "Stock:"
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(86, 153)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(121, 20)
        Me.StockTextBox.TabIndex = 12
        '
        'Stock_MinimoLabel
        '
        Stock_MinimoLabel.AutoSize = True
        Stock_MinimoLabel.Location = New System.Drawing.Point(6, 182)
        Stock_MinimoLabel.Name = "Stock_MinimoLabel"
        Stock_MinimoLabel.Size = New System.Drawing.Size(74, 13)
        Stock_MinimoLabel.TabIndex = 13
        Stock_MinimoLabel.Text = "Stock Minimo:"
        '
        'Stock_MinimoTextBox
        '
        Me.Stock_MinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Stock_Minimo", True))
        Me.Stock_MinimoTextBox.Location = New System.Drawing.Point(86, 179)
        Me.Stock_MinimoTextBox.Name = "Stock_MinimoTextBox"
        Me.Stock_MinimoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Stock_MinimoTextBox.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Id_ArticuloLabel)
        Me.GroupBox1.Controls.Add(Stock_MinimoLabel)
        Me.GroupBox1.Controls.Add(Me.Id_ArticuloTextBox)
        Me.GroupBox1.Controls.Add(Me.Stock_MinimoTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.StockTextBox)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(StockLabel)
        Me.GroupBox1.Controls.Add(CategoriaLabel)
        Me.GroupBox1.Controls.Add(Me.PrecioTextBox)
        Me.GroupBox1.Controls.Add(Me.CategoriaComboBox)
        Me.GroupBox1.Controls.Add(PrecioLabel)
        Me.GroupBox1.Controls.Add(TipoLabel)
        Me.GroupBox1.Controls.Add(Me.TipoComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 271)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(86, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Actualizar_Precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 297)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Actualizar_Precios"
        Me.Text = "Actualizar_Precios"
        CType(Me.MuebleriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MuebleriaDataSet As WindowsApplication1.MuebleriaDataSet
    Friend WithEvents ArticuloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticuloTableAdapter As WindowsApplication1.MuebleriaDataSetTableAdapters.ArticuloTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_ArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TipoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stock_MinimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
