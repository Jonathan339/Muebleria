<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendedores
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
        Dim Id_EmpleadoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim FechaNacimientoLabel As System.Windows.Forms.Label
        Dim SectorLabel As System.Windows.Forms.Label
        Dim PuestoLabel As System.Windows.Forms.Label
        Dim Id_SucursalLabel As System.Windows.Forms.Label
        Dim FechaIngresoLabel As System.Windows.Forms.Label
        Dim FechaEgresoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendedores))
        Me.MuebleriaDataSet = New WindowsApplication1.MuebleriaDataSet
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New WindowsApplication1.MuebleriaDataSetTableAdapters.EmpleadoTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager
        Me.EmpleadoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.EmpleadoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.EmpleadoDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Id_EmpleadoTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox
        Me.FechaNacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.SectorTextBox = New System.Windows.Forms.TextBox
        Me.PuestoTextBox = New System.Windows.Forms.TextBox
        Me.Id_SucursalTextBox = New System.Windows.Forms.TextBox
        Me.FechaIngresoDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.FechaEgresoDateTimePicker = New System.Windows.Forms.DateTimePicker
        Id_EmpleadoLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        ApellidoLabel = New System.Windows.Forms.Label
        FechaNacimientoLabel = New System.Windows.Forms.Label
        SectorLabel = New System.Windows.Forms.Label
        PuestoLabel = New System.Windows.Forms.Label
        Id_SucursalLabel = New System.Windows.Forms.Label
        FechaIngresoLabel = New System.Windows.Forms.Label
        FechaEgresoLabel = New System.Windows.Forms.Label
        CType(Me.MuebleriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadoBindingNavigator.SuspendLayout()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_EmpleadoLabel
        '
        Id_EmpleadoLabel.AutoSize = True
        Id_EmpleadoLabel.Location = New System.Drawing.Point(15, 41)
        Id_EmpleadoLabel.Name = "Id_EmpleadoLabel"
        Id_EmpleadoLabel.Size = New System.Drawing.Size(69, 13)
        Id_EmpleadoLabel.TabIndex = 0
        Id_EmpleadoLabel.Text = "Id Empleado:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(15, 67)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(15, 93)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 4
        ApellidoLabel.Text = "Apellido:"
        '
        'FechaNacimientoLabel
        '
        FechaNacimientoLabel.AutoSize = True
        FechaNacimientoLabel.Location = New System.Drawing.Point(15, 120)
        FechaNacimientoLabel.Name = "FechaNacimientoLabel"
        FechaNacimientoLabel.Size = New System.Drawing.Size(96, 13)
        FechaNacimientoLabel.TabIndex = 6
        FechaNacimientoLabel.Text = "Fecha Nacimiento:"
        '
        'SectorLabel
        '
        SectorLabel.AutoSize = True
        SectorLabel.Location = New System.Drawing.Point(15, 145)
        SectorLabel.Name = "SectorLabel"
        SectorLabel.Size = New System.Drawing.Size(41, 13)
        SectorLabel.TabIndex = 8
        SectorLabel.Text = "Sector:"
        '
        'PuestoLabel
        '
        PuestoLabel.AutoSize = True
        PuestoLabel.Location = New System.Drawing.Point(15, 171)
        PuestoLabel.Name = "PuestoLabel"
        PuestoLabel.Size = New System.Drawing.Size(43, 13)
        PuestoLabel.TabIndex = 10
        PuestoLabel.Text = "Puesto:"
        '
        'Id_SucursalLabel
        '
        Id_SucursalLabel.AutoSize = True
        Id_SucursalLabel.Location = New System.Drawing.Point(15, 197)
        Id_SucursalLabel.Name = "Id_SucursalLabel"
        Id_SucursalLabel.Size = New System.Drawing.Size(63, 13)
        Id_SucursalLabel.TabIndex = 12
        Id_SucursalLabel.Text = "Id Sucursal:"
        '
        'FechaIngresoLabel
        '
        FechaIngresoLabel.AutoSize = True
        FechaIngresoLabel.Location = New System.Drawing.Point(15, 224)
        FechaIngresoLabel.Name = "FechaIngresoLabel"
        FechaIngresoLabel.Size = New System.Drawing.Size(78, 13)
        FechaIngresoLabel.TabIndex = 14
        FechaIngresoLabel.Text = "Fecha Ingreso:"
        '
        'FechaEgresoLabel
        '
        FechaEgresoLabel.AutoSize = True
        FechaEgresoLabel.Location = New System.Drawing.Point(15, 250)
        FechaEgresoLabel.Name = "FechaEgresoLabel"
        FechaEgresoLabel.Size = New System.Drawing.Size(76, 13)
        FechaEgresoLabel.TabIndex = 16
        FechaEgresoLabel.Text = "Fecha Egreso:"
        '
        'MuebleriaDataSet
        '
        Me.MuebleriaDataSet.DataSetName = "MuebleriaDataSet"
        Me.MuebleriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.MuebleriaDataSet
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticuloTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.CompraArtTableAdapter = Nothing
        Me.TableAdapterManager.compraTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Me.EmpleadoTableAdapter
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.SucursalTableAdapter = Nothing
        Me.TableAdapterManager.Tipo_MaterialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'EmpleadoBindingNavigator
        '
        Me.EmpleadoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpleadoBindingNavigator.BindingSource = Me.EmpleadoBindingSource
        Me.EmpleadoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadoBindingNavigatorSaveItem})
        Me.EmpleadoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadoBindingNavigator.Name = "EmpleadoBindingNavigator"
        Me.EmpleadoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadoBindingNavigator.Size = New System.Drawing.Size(765, 25)
        Me.EmpleadoBindingNavigator.TabIndex = 0
        Me.EmpleadoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EmpleadoBindingNavigatorSaveItem
        '
        Me.EmpleadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpleadoBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpleadoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpleadoBindingNavigatorSaveItem.Name = "EmpleadoBindingNavigatorSaveItem"
        Me.EmpleadoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpleadoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EmpleadoDataGridView
        '
        Me.EmpleadoDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpleadoDataGridView.AutoGenerateColumns = False
        Me.EmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.EmpleadoDataGridView.DataSource = Me.EmpleadoBindingSource
        Me.EmpleadoDataGridView.Location = New System.Drawing.Point(263, 45)
        Me.EmpleadoDataGridView.Name = "EmpleadoDataGridView"
        Me.EmpleadoDataGridView.Size = New System.Drawing.Size(490, 356)
        Me.EmpleadoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Empleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Empleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FechaNacimiento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FechaNacimiento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Sector"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sector"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Puesto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Puesto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Id_Sucursal"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Id_Sucursal"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FechaIngreso"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FechaIngreso"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FechaEgreso"
        Me.DataGridViewTextBoxColumn9.HeaderText = "FechaEgreso"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Id_EmpleadoLabel)
        Me.GroupBox1.Controls.Add(Me.Id_EmpleadoTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(ApellidoLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidoTextBox)
        Me.GroupBox1.Controls.Add(FechaNacimientoLabel)
        Me.GroupBox1.Controls.Add(Me.FechaNacimientoDateTimePicker)
        Me.GroupBox1.Controls.Add(SectorLabel)
        Me.GroupBox1.Controls.Add(Me.SectorTextBox)
        Me.GroupBox1.Controls.Add(PuestoLabel)
        Me.GroupBox1.Controls.Add(Me.PuestoTextBox)
        Me.GroupBox1.Controls.Add(Id_SucursalLabel)
        Me.GroupBox1.Controls.Add(Me.Id_SucursalTextBox)
        Me.GroupBox1.Controls.Add(FechaIngresoLabel)
        Me.GroupBox1.Controls.Add(Me.FechaIngresoDateTimePicker)
        Me.GroupBox1.Controls.Add(FechaEgresoLabel)
        Me.GroupBox1.Controls.Add(Me.FechaEgresoDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 356)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Id_EmpleadoTextBox
        '
        Me.Id_EmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Id_Empleado", True))
        Me.Id_EmpleadoTextBox.Location = New System.Drawing.Point(117, 38)
        Me.Id_EmpleadoTextBox.Name = "Id_EmpleadoTextBox"
        Me.Id_EmpleadoTextBox.Size = New System.Drawing.Size(120, 20)
        Me.Id_EmpleadoTextBox.TabIndex = 1
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(117, 64)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(120, 20)
        Me.NombreTextBox.TabIndex = 3
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(117, 90)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(120, 20)
        Me.ApellidoTextBox.TabIndex = 5
        '
        'FechaNacimientoDateTimePicker
        '
        Me.FechaNacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadoBindingSource, "FechaNacimiento", True))
        Me.FechaNacimientoDateTimePicker.Location = New System.Drawing.Point(117, 116)
        Me.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker"
        Me.FechaNacimientoDateTimePicker.Size = New System.Drawing.Size(120, 20)
        Me.FechaNacimientoDateTimePicker.TabIndex = 7
        '
        'SectorTextBox
        '
        Me.SectorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Sector", True))
        Me.SectorTextBox.Location = New System.Drawing.Point(117, 142)
        Me.SectorTextBox.Name = "SectorTextBox"
        Me.SectorTextBox.Size = New System.Drawing.Size(120, 20)
        Me.SectorTextBox.TabIndex = 9
        '
        'PuestoTextBox
        '
        Me.PuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Puesto", True))
        Me.PuestoTextBox.Location = New System.Drawing.Point(117, 168)
        Me.PuestoTextBox.Name = "PuestoTextBox"
        Me.PuestoTextBox.Size = New System.Drawing.Size(120, 20)
        Me.PuestoTextBox.TabIndex = 11
        '
        'Id_SucursalTextBox
        '
        Me.Id_SucursalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "Id_Sucursal", True))
        Me.Id_SucursalTextBox.Location = New System.Drawing.Point(117, 194)
        Me.Id_SucursalTextBox.Name = "Id_SucursalTextBox"
        Me.Id_SucursalTextBox.Size = New System.Drawing.Size(120, 20)
        Me.Id_SucursalTextBox.TabIndex = 13
        '
        'FechaIngresoDateTimePicker
        '
        Me.FechaIngresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadoBindingSource, "FechaIngreso", True))
        Me.FechaIngresoDateTimePicker.Location = New System.Drawing.Point(117, 220)
        Me.FechaIngresoDateTimePicker.Name = "FechaIngresoDateTimePicker"
        Me.FechaIngresoDateTimePicker.Size = New System.Drawing.Size(120, 20)
        Me.FechaIngresoDateTimePicker.TabIndex = 15
        '
        'FechaEgresoDateTimePicker
        '
        Me.FechaEgresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadoBindingSource, "FechaEgreso", True))
        Me.FechaEgresoDateTimePicker.Location = New System.Drawing.Point(117, 246)
        Me.FechaEgresoDateTimePicker.Name = "FechaEgresoDateTimePicker"
        Me.FechaEgresoDateTimePicker.Size = New System.Drawing.Size(120, 20)
        Me.FechaEgresoDateTimePicker.TabIndex = 17
        '
        'Vendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 413)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EmpleadoDataGridView)
        Me.Controls.Add(Me.EmpleadoBindingNavigator)
        Me.Name = "Vendedores"
        Me.Text = "Vendedores"
        CType(Me.MuebleriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadoBindingNavigator.ResumeLayout(False)
        Me.EmpleadoBindingNavigator.PerformLayout()
        CType(Me.EmpleadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MuebleriaDataSet As WindowsApplication1.MuebleriaDataSet
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoTableAdapter As WindowsApplication1.MuebleriaDataSetTableAdapters.EmpleadoTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MuebleriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EmpleadoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EmpleadoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Id_EmpleadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaNacimientoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SectorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PuestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_SucursalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaIngresoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaEgresoDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
