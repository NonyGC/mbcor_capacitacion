<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReporteParticipante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteParticipante))
        Me.dtgParticipante = New Telerik.WinControls.UI.RadGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.rbtBuscar = New Telerik.WinControls.UI.RadButton()
        Me.cboBuscar = New Telerik.WinControls.UI.RadDropDownList()
        Me.gpbTipBusqueda = New System.Windows.Forms.GroupBox()
        Me.rbtOrigen = New System.Windows.Forms.RadioButton()
        Me.rbtLocal = New System.Windows.Forms.RadioButton()
        Me.rbtApeNom = New System.Windows.Forms.RadioButton()
        Me.gpbFecha = New System.Windows.Forms.GroupBox()
        Me.txtFechaini = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.txtFechafin = New Telerik.WinControls.UI.RadMaskedEditBox()
        CType(Me.dtgParticipante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgParticipante.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbTipBusqueda.SuspendLayout()
        Me.gpbFecha.SuspendLayout()
        CType(Me.txtFechaini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechafin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgParticipante
        '
        Me.dtgParticipante.AutoScroll = True
        Me.dtgParticipante.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgParticipante.Location = New System.Drawing.Point(42, 132)
        '
        '
        '
        Me.dtgParticipante.MasterTemplate.AllowAddNewRow = False
        Me.dtgParticipante.MasterTemplate.AllowDeleteRow = False
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
        GridViewTextBoxColumn18.Width = 150
        Me.dtgParticipante.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewTextBoxColumn11, GridViewTextBoxColumn12, GridViewTextBoxColumn13, GridViewTextBoxColumn14, GridViewTextBoxColumn15, GridViewTextBoxColumn16, GridViewTextBoxColumn17, GridViewTextBoxColumn18})
        Me.dtgParticipante.MasterTemplate.EnableFiltering = True
        Me.dtgParticipante.MasterTemplate.EnableGrouping = False
        Me.dtgParticipante.MasterTemplate.EnablePaging = True
        Me.dtgParticipante.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dtgParticipante.Name = "dtgParticipante"
        Me.dtgParticipante.ReadOnly = True
        Me.dtgParticipante.Size = New System.Drawing.Size(940, 488)
        Me.dtgParticipante.TabIndex = 1
        Me.dtgParticipante.ThemeName = "VisualStudio2012Light"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(-5, -4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1026, 21)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "REPORTE PARTICIPATES"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbtBuscar
        '
        Me.rbtBuscar.Location = New System.Drawing.Point(834, 101)
        Me.rbtBuscar.Name = "rbtBuscar"
        Me.rbtBuscar.Size = New System.Drawing.Size(148, 24)
        Me.rbtBuscar.TabIndex = 89
        Me.rbtBuscar.Text = "BUSCAR"
        Me.rbtBuscar.ThemeName = "VisualStudio2012Light"
        '
        'cboBuscar
        '
        Me.cboBuscar.Location = New System.Drawing.Point(362, 101)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(452, 24)
        Me.cboBuscar.TabIndex = 92
        Me.cboBuscar.ThemeName = "VisualStudio2012Light"
        '
        'gpbTipBusqueda
        '
        Me.gpbTipBusqueda.Controls.Add(Me.rbtOrigen)
        Me.gpbTipBusqueda.Controls.Add(Me.rbtLocal)
        Me.gpbTipBusqueda.Controls.Add(Me.rbtApeNom)
        Me.gpbTipBusqueda.Location = New System.Drawing.Point(68, 38)
        Me.gpbTipBusqueda.Name = "gpbTipBusqueda"
        Me.gpbTipBusqueda.Size = New System.Drawing.Size(289, 47)
        Me.gpbTipBusqueda.TabIndex = 96
        Me.gpbTipBusqueda.TabStop = False
        Me.gpbTipBusqueda.Text = "BURCAR POR:"
        '
        'rbtOrigen
        '
        Me.rbtOrigen.AutoSize = True
        Me.rbtOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtOrigen.Location = New System.Drawing.Point(215, 19)
        Me.rbtOrigen.Name = "rbtOrigen"
        Me.rbtOrigen.Size = New System.Drawing.Size(60, 17)
        Me.rbtOrigen.TabIndex = 98
        Me.rbtOrigen.TabStop = True
        Me.rbtOrigen.Text = "Origen"
        Me.rbtOrigen.UseVisualStyleBackColor = True
        '
        'rbtLocal
        '
        Me.rbtLocal.AutoSize = True
        Me.rbtLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtLocal.Location = New System.Drawing.Point(158, 19)
        Me.rbtLocal.Name = "rbtLocal"
        Me.rbtLocal.Size = New System.Drawing.Size(50, 17)
        Me.rbtLocal.TabIndex = 98
        Me.rbtLocal.TabStop = True
        Me.rbtLocal.Text = "Local"
        Me.rbtLocal.UseVisualStyleBackColor = True
        '
        'rbtApeNom
        '
        Me.rbtApeNom.AutoSize = True
        Me.rbtApeNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtApeNom.Location = New System.Drawing.Point(22, 19)
        Me.rbtApeNom.Name = "rbtApeNom"
        Me.rbtApeNom.Size = New System.Drawing.Size(129, 17)
        Me.rbtApeNom.TabIndex = 98
        Me.rbtApeNom.TabStop = True
        Me.rbtApeNom.Text = "Apellidos y Nombres"
        Me.rbtApeNom.UseVisualStyleBackColor = True
        '
        'gpbFecha
        '
        Me.gpbFecha.Controls.Add(Me.txtFechaini)
        Me.gpbFecha.Controls.Add(Me.txtFechafin)
        Me.gpbFecha.Enabled = False
        Me.gpbFecha.Location = New System.Drawing.Point(363, 38)
        Me.gpbFecha.Name = "gpbFecha"
        Me.gpbFecha.Size = New System.Drawing.Size(250, 47)
        Me.gpbFecha.TabIndex = 97
        Me.gpbFecha.TabStop = False
        Me.gpbFecha.Text = "RAGO DE FECHA"
        '
        'txtFechaini
        '
        Me.txtFechaini.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaini.Location = New System.Drawing.Point(20, 17)
        Me.txtFechaini.Mask = "00/00/0000"
        Me.txtFechaini.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.txtFechaini.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtFechaini.Name = "txtFechaini"
        '
        '
        '
        Me.txtFechaini.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtFechaini.Size = New System.Drawing.Size(97, 24)
        Me.txtFechaini.TabIndex = 98
        Me.txtFechaini.TabStop = False
        Me.txtFechaini.Text = "__/__/____"
        Me.txtFechaini.ThemeName = "VisualStudio2012Light"
        '
        'txtFechafin
        '
        Me.txtFechafin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechafin.Location = New System.Drawing.Point(135, 17)
        Me.txtFechafin.Mask = "00/00/0000"
        Me.txtFechafin.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.txtFechafin.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtFechafin.Name = "txtFechafin"
        '
        '
        '
        Me.txtFechafin.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtFechafin.Size = New System.Drawing.Size(97, 24)
        Me.txtFechafin.TabIndex = 98
        Me.txtFechafin.TabStop = False
        Me.txtFechafin.Text = "__/__/____"
        Me.txtFechafin.ThemeName = "VisualStudio2012Light"
        '
        'FrmReporteParticipante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 634)
        Me.Controls.Add(Me.gpbFecha)
        Me.Controls.Add(Me.gpbTipBusqueda)
        Me.Controls.Add(Me.dtgParticipante)
        Me.Controls.Add(Me.cboBuscar)
        Me.Controls.Add(Me.rbtBuscar)
        Me.Controls.Add(Me.Label15)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReporteParticipante"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = ""
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.dtgParticipante.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgParticipante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbTipBusqueda.ResumeLayout(False)
        Me.gpbTipBusqueda.PerformLayout()
        Me.gpbFecha.ResumeLayout(False)
        Me.gpbFecha.PerformLayout()
        CType(Me.txtFechaini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechafin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgParticipante As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents rbtBuscar As Telerik.WinControls.UI.RadButton
    Friend WithEvents cboBuscar As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents gpbTipBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents gpbFecha As System.Windows.Forms.GroupBox
    Friend WithEvents txtFechaini As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtFechafin As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents rbtOrigen As System.Windows.Forms.RadioButton
    Friend WithEvents rbtLocal As System.Windows.Forms.RadioButton
    Friend WithEvents rbtApeNom As System.Windows.Forms.RadioButton
End Class

