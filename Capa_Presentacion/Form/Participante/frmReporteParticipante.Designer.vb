<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteParticipante
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.rbtBuscar = New Telerik.WinControls.UI.RadButton()
        Me.cboFiltrar = New Telerik.WinControls.UI.RadCheckedDropDownList()
        CType(Me.dtgParticipante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgParticipante.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgParticipante
        '
        Me.dtgParticipante.AutoScroll = True
        Me.dtgParticipante.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgParticipante.Location = New System.Drawing.Point(40, 98)
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
        'RadTextBox1
        '
        Me.RadTextBox1.Location = New System.Drawing.Point(158, 66)
        Me.RadTextBox1.MinimumSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox1.Name = "RadTextBox1"
        '
        '
        '
        Me.RadTextBox1.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox1.Size = New System.Drawing.Size(445, 24)
        Me.RadTextBox1.TabIndex = 87
        Me.RadTextBox1.ThemeName = "VisualStudio2012Light"
        '
        'rbtBuscar
        '
        Me.rbtBuscar.Enabled = False
        Me.rbtBuscar.Location = New System.Drawing.Point(791, 66)
        Me.rbtBuscar.Name = "rbtBuscar"
        Me.rbtBuscar.Size = New System.Drawing.Size(115, 24)
        Me.rbtBuscar.TabIndex = 89
        Me.rbtBuscar.Text = "BUSCAR"
        Me.rbtBuscar.ThemeName = "VisualStudio2012Light"
        '
        'cboFiltrar
        '
        Me.cboFiltrar.Location = New System.Drawing.Point(616, 66)
        Me.cboFiltrar.Name = "cboFiltrar"
        Me.cboFiltrar.NullText = "Filtrar"
        Me.cboFiltrar.Size = New System.Drawing.Size(169, 24)
        Me.cboFiltrar.TabIndex = 90
        Me.cboFiltrar.ThemeName = "VisualStudio2012Light"
        '
        'FrmReporteParticipante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 609)
        Me.Controls.Add(Me.cboFiltrar)
        Me.Controls.Add(Me.rbtBuscar)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtgParticipante)
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
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgParticipante As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rbtBuscar As Telerik.WinControls.UI.RadButton
    Friend WithEvents cboFiltrar As Telerik.WinControls.UI.RadCheckedDropDownList
End Class

