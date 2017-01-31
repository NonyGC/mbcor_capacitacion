<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListParticipante
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn12 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn13 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn14 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn15 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn16 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn17 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn18 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn19 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn20 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn21 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn22 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListParticipante))
        Me.dtgParticipantes = New Telerik.WinControls.UI.RadGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnEliminar = New Telerik.WinControls.UI.RadButton()
        Me.btnModificar = New Telerik.WinControls.UI.RadButton()
        Me.btnAgregar = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.cboFilterP = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        CType(Me.dtgParticipantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgParticipantes.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFilterP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFilterP.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFilterP.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgParticipantes
        '
        Me.dtgParticipantes.AutoScroll = True
        Me.dtgParticipantes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgParticipantes.Location = New System.Drawing.Point(31, 116)
        '
        '
        '
        Me.dtgParticipantes.MasterTemplate.AllowAddNewRow = False
        Me.dtgParticipantes.MasterTemplate.AllowDeleteRow = False
        Me.dtgParticipantes.MasterTemplate.AllowSearchRow = True
        GridViewTextBoxColumn1.FieldName = "codigo"
        GridViewTextBoxColumn1.HeaderText = "CODIGO"
        GridViewTextBoxColumn1.Name = "codigo"
        GridViewTextBoxColumn1.Width = 100
        GridViewTextBoxColumn2.FieldName = "apellido_pat"
        GridViewTextBoxColumn2.HeaderText = "AP. PATERNO"
        GridViewTextBoxColumn2.Name = "apellido_pat"
        GridViewTextBoxColumn2.Width = 150
        GridViewTextBoxColumn3.FieldName = "apellido_mat"
        GridViewTextBoxColumn3.HeaderText = "AP. MATERNO"
        GridViewTextBoxColumn3.Name = "apellido_mat"
        GridViewTextBoxColumn3.Width = 150
        GridViewTextBoxColumn4.FieldName = "nombres"
        GridViewTextBoxColumn4.HeaderText = "NOMBRES"
        GridViewTextBoxColumn4.Name = "nombres"
        GridViewTextBoxColumn4.Width = 150
        GridViewTextBoxColumn5.FieldName = "sexo"
        GridViewTextBoxColumn5.HeaderText = "SEXO"
        GridViewTextBoxColumn5.Name = "sexo"
        GridViewTextBoxColumn6.FieldName = "fecha_nacimiento"
        GridViewTextBoxColumn6.HeaderText = "F. NACIMIENTO"
        GridViewTextBoxColumn6.Name = "fecha_nacimiento"
        GridViewTextBoxColumn6.Width = 80
        GridViewTextBoxColumn7.FieldName = "dni_ce"
        GridViewTextBoxColumn7.HeaderText = "DNI/CE"
        GridViewTextBoxColumn7.Name = "dni_ce"
        GridViewTextBoxColumn7.Width = 80
        GridViewTextBoxColumn8.FieldName = "direccion"
        GridViewTextBoxColumn8.HeaderText = "DIRECCIÓN"
        GridViewTextBoxColumn8.IsVisible = False
        GridViewTextBoxColumn8.Name = "direccion"
        GridViewTextBoxColumn9.FieldName = "ubigeo"
        GridViewTextBoxColumn9.HeaderText = "UBIGEO"
        GridViewTextBoxColumn9.IsVisible = False
        GridViewTextBoxColumn9.Name = "ubigeo"
        GridViewTextBoxColumn10.FieldName = "tel_fijo"
        GridViewTextBoxColumn10.HeaderText = "FIJO"
        GridViewTextBoxColumn10.Name = "tel_fijo"
        GridViewTextBoxColumn10.Width = 100
        GridViewTextBoxColumn11.FieldName = "tel_mol"
        GridViewTextBoxColumn11.HeaderText = "MOVIL"
        GridViewTextBoxColumn11.Name = "tel_mol"
        GridViewTextBoxColumn11.Width = 100
        GridViewTextBoxColumn12.FieldName = "ope_movil"
        GridViewTextBoxColumn12.HeaderText = "OPE. MOVIL"
        GridViewTextBoxColumn12.Name = "ope_movil"
        GridViewTextBoxColumn12.Width = 80
        GridViewTextBoxColumn13.FieldName = "tel_fijo2"
        GridViewTextBoxColumn13.HeaderText = "FIJO2"
        GridViewTextBoxColumn13.Name = "tel_fijo2"
        GridViewTextBoxColumn14.FieldName = "tel_mol2"
        GridViewTextBoxColumn14.HeaderText = "MOVIL2"
        GridViewTextBoxColumn14.Name = "tel_mol2"
        GridViewTextBoxColumn15.FieldName = "ope_movil2"
        GridViewTextBoxColumn15.HeaderText = "OPERADOR2"
        GridViewTextBoxColumn15.Name = "ope_movil2"
        GridViewTextBoxColumn16.FieldName = "email"
        GridViewTextBoxColumn16.HeaderText = "EMAIL"
        GridViewTextBoxColumn16.Name = "email"
        GridViewTextBoxColumn16.Width = 300
        GridViewTextBoxColumn17.FieldName = "estado_civ"
        GridViewTextBoxColumn17.HeaderText = "ESTADO CIVIL"
        GridViewTextBoxColumn17.IsVisible = False
        GridViewTextBoxColumn17.Name = "estado_civ"
        GridViewTextBoxColumn18.FieldName = "profe_ocupa"
        GridViewTextBoxColumn18.HeaderText = "PROFE/OFICIO"
        GridViewTextBoxColumn18.Name = "profe_ocupa"
        GridViewTextBoxColumn18.Width = 80
        Me.dtgParticipantes.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewTextBoxColumn11, GridViewTextBoxColumn12, GridViewTextBoxColumn13, GridViewTextBoxColumn14, GridViewTextBoxColumn15, GridViewTextBoxColumn16, GridViewTextBoxColumn17, GridViewTextBoxColumn18})
        Me.dtgParticipantes.MasterTemplate.EnableGrouping = False
        Me.dtgParticipantes.MasterTemplate.EnablePaging = True
        Me.dtgParticipantes.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dtgParticipantes.Name = "dtgParticipantes"
        Me.dtgParticipantes.ReadOnly = True
        Me.dtgParticipantes.Size = New System.Drawing.Size(933, 435)
        Me.dtgParticipantes.TabIndex = 0
        Me.dtgParticipantes.ThemeName = "VisualStudio2012Light"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(-1, -2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(961, 21)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "LISTADO DE PARTICIPANTES REGISTRADOS"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(813, 70)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(151, 24)
        Me.btnEliminar.TabIndex = 86
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.ThemeName = "VisualStudio2012Light"
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(655, 70)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(151, 24)
        Me.btnModificar.TabIndex = 85
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.ThemeName = "VisualStudio2012Light"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(497, 70)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(151, 24)
        Me.btnAgregar.TabIndex = 84
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.ThemeName = "VisualStudio2012Light"
        '
        'RadButton1
        '
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton1.Location = New System.Drawing.Point(31, 70)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(151, 24)
        Me.RadButton1.TabIndex = 87
        Me.RadButton1.Text = "ACTUALIZAR"
        Me.RadButton1.ThemeName = "VisualStudio2012Light"
        '
        'cboFilterP
        '
        Me.cboFilterP.AutoSize = True
        '
        'cboFilterP.NestedRadGridView
        '
        Me.cboFilterP.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.cboFilterP.EditorControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboFilterP.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboFilterP.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboFilterP.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboFilterP.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.cboFilterP.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.cboFilterP.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.cboFilterP.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.cboFilterP.EditorControl.MasterTemplate.AllowRowResize = False
        GridViewTextBoxColumn19.EnableExpressionEditor = False
        GridViewTextBoxColumn19.FieldName = "codigo"
        GridViewTextBoxColumn19.HeaderText = "codigo"
        GridViewTextBoxColumn19.IsVisible = False
        GridViewTextBoxColumn19.Name = "codigo"
        GridViewTextBoxColumn20.EnableExpressionEditor = False
        GridViewTextBoxColumn20.FieldName = "nombre"
        GridViewTextBoxColumn20.HeaderText = "LOCAL"
        GridViewTextBoxColumn20.Name = "LOCAL"
        GridViewTextBoxColumn20.Width = 200
        GridViewTextBoxColumn21.EnableExpressionEditor = False
        GridViewTextBoxColumn21.FieldName = "fecha"
        GridViewTextBoxColumn21.HeaderText = "FECHA"
        GridViewTextBoxColumn21.Name = "FECHA"
        GridViewTextBoxColumn21.Width = 80
        GridViewTextBoxColumn22.EnableExpressionEditor = False
        GridViewTextBoxColumn22.FieldName = "origen"
        GridViewTextBoxColumn22.HeaderText = "ORIGEN"
        GridViewTextBoxColumn22.Name = "ORIGEN"
        GridViewTextBoxColumn22.Width = 100
        Me.cboFilterP.EditorControl.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn19, GridViewTextBoxColumn20, GridViewTextBoxColumn21, GridViewTextBoxColumn22})
        Me.cboFilterP.EditorControl.MasterTemplate.EnableGrouping = False
        Me.cboFilterP.EditorControl.MasterTemplate.ShowFilteringRow = False
        SortDescriptor1.PropertyName = "column1"
        Me.cboFilterP.EditorControl.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.cboFilterP.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.cboFilterP.EditorControl.Name = "NestedRadGridView"
        Me.cboFilterP.EditorControl.ReadOnly = True
        Me.cboFilterP.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboFilterP.EditorControl.ShowGroupPanel = False
        Me.cboFilterP.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.cboFilterP.EditorControl.TabIndex = 0
        Me.cboFilterP.Location = New System.Drawing.Point(497, 40)
        Me.cboFilterP.Name = "cboFilterP"
        Me.cboFilterP.NullText = "Seleccionar Local"
        Me.cboFilterP.Size = New System.Drawing.Size(377, 24)
        Me.cboFilterP.TabIndex = 89
        Me.cboFilterP.TabStop = False
        Me.cboFilterP.ThemeName = "VisualStudio2012Light"
        Me.cboFilterP.Visible = False
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(892, 39)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(72, 26)
        Me.RadButton2.TabIndex = 90
        Me.RadButton2.Text = "BUSCAR"
        Me.RadButton2.ThemeName = "VisualStudio2012Light"
        Me.RadButton2.Visible = False
        '
        'FrmListParticipante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 572)
        Me.Controls.Add(Me.dtgParticipantes)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.cboFilterP)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label15)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListParticipante"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MBCORP"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.dtgParticipantes.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgParticipantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFilterP.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFilterP.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFilterP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgParticipantes As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnModificar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAgregar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents cboFilterP As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
End Class

