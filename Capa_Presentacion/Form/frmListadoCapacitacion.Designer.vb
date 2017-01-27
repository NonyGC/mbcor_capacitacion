<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoCapacitacion
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoCapacitacion))
        Me.dgvCapacitacion = New Telerik.WinControls.UI.RadGridView()
        Me.btnAgregar = New Telerik.WinControls.UI.RadButton()
        Me.btnModificar = New Telerik.WinControls.UI.RadButton()
        Me.btnEliminar = New Telerik.WinControls.UI.RadButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.txtOrigenOtro = New Telerik.WinControls.UI.RadTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtExpositor = New Telerik.WinControls.UI.RadTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtOrigen = New Telerik.WinControls.UI.RadTextBox()
        Me.txtTema = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCantIngresada = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCantMasisa = New Telerik.WinControls.UI.RadTextBox()
        Me.txtFecha = New Telerik.WinControls.UI.RadTextBox()
        Me.txtLocal = New Telerik.WinControls.UI.RadTextBox()
        Me.txtOrganizador = New Telerik.WinControls.UI.RadTextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvCapacitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCapacitacion.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.txtOrigenOtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExpositor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantIngresada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantMasisa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrganizador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCapacitacion
        '
        Me.dgvCapacitacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCapacitacion.Location = New System.Drawing.Point(34, 114)
        '
        '
        '
        Me.dgvCapacitacion.MasterTemplate.AllowAddNewRow = False
        Me.dgvCapacitacion.MasterTemplate.AllowDeleteRow = False
        Me.dgvCapacitacion.MasterTemplate.AllowSearchRow = True
        GridViewTextBoxColumn1.FieldName = "codigo"
        GridViewTextBoxColumn1.HeaderText = "CÓDIGO"
        GridViewTextBoxColumn1.Name = "Cod"
        GridViewTextBoxColumn1.Width = 80
        GridViewTextBoxColumn2.FieldName = "origen"
        GridViewTextBoxColumn2.HeaderText = "ORIGEN"
        GridViewTextBoxColumn2.Name = "origen"
        GridViewTextBoxColumn2.Width = 150
        GridViewTextBoxColumn3.FieldName = "origOtro"
        GridViewTextBoxColumn3.HeaderText = "ORIGEN 2"
        GridViewTextBoxColumn3.Name = "origOtro"
        GridViewTextBoxColumn3.Width = 150
        GridViewTextBoxColumn4.FieldName = "organizador"
        GridViewTextBoxColumn4.HeaderText = "ORGANIZADOR"
        GridViewTextBoxColumn4.Name = "organizador"
        GridViewTextBoxColumn4.Width = 200
        GridViewTextBoxColumn5.FieldName = "local"
        GridViewTextBoxColumn5.HeaderText = "LOCAL"
        GridViewTextBoxColumn5.Name = "local"
        GridViewTextBoxColumn5.Width = 250
        GridViewTextBoxColumn6.FieldName = "cantMasisa"
        GridViewTextBoxColumn6.HeaderText = "CANT.MASISA"
        GridViewTextBoxColumn6.IsVisible = False
        GridViewTextBoxColumn6.Name = "cantMasisa"
        GridViewTextBoxColumn7.FieldName = "cantIngresada"
        GridViewTextBoxColumn7.HeaderText = "CANT.INGRESADA"
        GridViewTextBoxColumn7.IsVisible = False
        GridViewTextBoxColumn7.Name = "cantIngresada"
        GridViewTextBoxColumn8.FieldName = "fecha"
        GridViewTextBoxColumn8.HeaderText = "FECHA"
        GridViewTextBoxColumn8.IsVisible = False
        GridViewTextBoxColumn8.Name = "fecha"
        GridViewTextBoxColumn9.FieldName = "tema"
        GridViewTextBoxColumn9.HeaderText = "TEMA"
        GridViewTextBoxColumn9.IsVisible = False
        GridViewTextBoxColumn9.Name = "tema"
        GridViewTextBoxColumn10.FieldName = "expositor"
        GridViewTextBoxColumn10.HeaderText = "EXPOSITOR"
        GridViewTextBoxColumn10.IsVisible = False
        GridViewTextBoxColumn10.Name = "expositor"
        Me.dgvCapacitacion.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10})
        Me.dgvCapacitacion.MasterTemplate.EnablePaging = True
        Me.dgvCapacitacion.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dgvCapacitacion.Name = "dgvCapacitacion"
        Me.dgvCapacitacion.ReadOnly = True
        Me.dgvCapacitacion.Size = New System.Drawing.Size(719, 396)
        Me.dgvCapacitacion.TabIndex = 0
        Me.dgvCapacitacion.ThemeName = "VisualStudio2012Light"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(288, 84)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(151, 24)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.ThemeName = "VisualStudio2012Light"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(445, 84)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(151, 24)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.ThemeName = "VisualStudio2012Light"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(602, 84)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(151, 24)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.ThemeName = "VisualStudio2012Light"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1151, 21)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "GESTIONAR CAPACITACIÓN"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.txtOrigenOtro)
        Me.RadPanel1.Controls.Add(Me.Label2)
        Me.RadPanel1.Controls.Add(Me.txtExpositor)
        Me.RadPanel1.Controls.Add(Me.Label9)
        Me.RadPanel1.Controls.Add(Me.txtOrigen)
        Me.RadPanel1.Controls.Add(Me.txtTema)
        Me.RadPanel1.Controls.Add(Me.txtCantIngresada)
        Me.RadPanel1.Controls.Add(Me.txtCantMasisa)
        Me.RadPanel1.Controls.Add(Me.txtFecha)
        Me.RadPanel1.Controls.Add(Me.txtLocal)
        Me.RadPanel1.Controls.Add(Me.txtOrganizador)
        Me.RadPanel1.Controls.Add(Me.lblCodigo)
        Me.RadPanel1.Controls.Add(Me.Label8)
        Me.RadPanel1.Controls.Add(Me.Label7)
        Me.RadPanel1.Controls.Add(Me.Label6)
        Me.RadPanel1.Controls.Add(Me.Label36)
        Me.RadPanel1.Controls.Add(Me.Label5)
        Me.RadPanel1.Controls.Add(Me.Label4)
        Me.RadPanel1.Controls.Add(Me.Label3)
        Me.RadPanel1.Controls.Add(Me.Label1)
        Me.RadPanel1.Location = New System.Drawing.Point(771, 138)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(374, 323)
        Me.RadPanel1.TabIndex = 85
        Me.RadPanel1.ThemeName = "VisualStudio2012Light"
        '
        'txtOrigenOtro
        '
        Me.txtOrigenOtro.AutoSize = False
        Me.txtOrigenOtro.Location = New System.Drawing.Point(118, 85)
        Me.txtOrigenOtro.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtOrigenOtro.Multiline = True
        Me.txtOrigenOtro.Name = "txtOrigenOtro"
        Me.txtOrigenOtro.ReadOnly = True
        '
        '
        '
        Me.txtOrigenOtro.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtOrigenOtro.Size = New System.Drawing.Size(244, 24)
        Me.txtOrigenOtro.TabIndex = 129
        Me.txtOrigenOtro.ThemeName = "VisualStudio2012Light"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "OTRO ORIGEN:"
        '
        'txtExpositor
        '
        Me.txtExpositor.AutoSize = False
        Me.txtExpositor.Location = New System.Drawing.Point(118, 288)
        Me.txtExpositor.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtExpositor.Multiline = True
        Me.txtExpositor.Name = "txtExpositor"
        Me.txtExpositor.ReadOnly = True
        '
        '
        '
        Me.txtExpositor.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtExpositor.Size = New System.Drawing.Size(244, 24)
        Me.txtExpositor.TabIndex = 129
        Me.txtExpositor.ThemeName = "VisualStudio2012Light"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "EXPOSITOR:"
        '
        'txtOrigen
        '
        Me.txtOrigen.AutoSize = False
        Me.txtOrigen.Location = New System.Drawing.Point(118, 56)
        Me.txtOrigen.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtOrigen.Multiline = True
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.ReadOnly = True
        '
        '
        '
        Me.txtOrigen.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtOrigen.Size = New System.Drawing.Size(244, 24)
        Me.txtOrigen.TabIndex = 127
        Me.txtOrigen.ThemeName = "VisualStudio2012Light"
        '
        'txtTema
        '
        Me.txtTema.AutoSize = False
        Me.txtTema.Location = New System.Drawing.Point(118, 258)
        Me.txtTema.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtTema.Multiline = True
        Me.txtTema.Name = "txtTema"
        Me.txtTema.ReadOnly = True
        '
        '
        '
        Me.txtTema.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtTema.Size = New System.Drawing.Size(244, 24)
        Me.txtTema.TabIndex = 125
        Me.txtTema.ThemeName = "VisualStudio2012Light"
        '
        'txtCantIngresada
        '
        Me.txtCantIngresada.AutoSize = False
        Me.txtCantIngresada.Location = New System.Drawing.Point(118, 229)
        Me.txtCantIngresada.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtCantIngresada.Multiline = True
        Me.txtCantIngresada.Name = "txtCantIngresada"
        Me.txtCantIngresada.ReadOnly = True
        '
        '
        '
        Me.txtCantIngresada.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtCantIngresada.Size = New System.Drawing.Size(244, 24)
        Me.txtCantIngresada.TabIndex = 124
        Me.txtCantIngresada.ThemeName = "VisualStudio2012Light"
        '
        'txtCantMasisa
        '
        Me.txtCantMasisa.AutoSize = False
        Me.txtCantMasisa.Location = New System.Drawing.Point(118, 200)
        Me.txtCantMasisa.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtCantMasisa.Multiline = True
        Me.txtCantMasisa.Name = "txtCantMasisa"
        Me.txtCantMasisa.ReadOnly = True
        '
        '
        '
        Me.txtCantMasisa.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtCantMasisa.Size = New System.Drawing.Size(244, 24)
        Me.txtCantMasisa.TabIndex = 123
        Me.txtCantMasisa.ThemeName = "VisualStudio2012Light"
        '
        'txtFecha
        '
        Me.txtFecha.AutoSize = False
        Me.txtFecha.Location = New System.Drawing.Point(118, 171)
        Me.txtFecha.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtFecha.Multiline = True
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        '
        '
        '
        Me.txtFecha.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtFecha.Size = New System.Drawing.Size(117, 24)
        Me.txtFecha.TabIndex = 122
        Me.txtFecha.ThemeName = "VisualStudio2012Light"
        '
        'txtLocal
        '
        Me.txtLocal.AutoSize = False
        Me.txtLocal.Location = New System.Drawing.Point(118, 142)
        Me.txtLocal.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtLocal.Multiline = True
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.ReadOnly = True
        '
        '
        '
        Me.txtLocal.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtLocal.Size = New System.Drawing.Size(244, 24)
        Me.txtLocal.TabIndex = 126
        Me.txtLocal.ThemeName = "VisualStudio2012Light"
        '
        'txtOrganizador
        '
        Me.txtOrganizador.AutoSize = False
        Me.txtOrganizador.Location = New System.Drawing.Point(118, 113)
        Me.txtOrganizador.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtOrganizador.Multiline = True
        Me.txtOrganizador.Name = "txtOrganizador"
        Me.txtOrganizador.ReadOnly = True
        '
        '
        '
        Me.txtOrganizador.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtOrganizador.Size = New System.Drawing.Size(244, 24)
        Me.txtOrganizador.TabIndex = 121
        Me.txtOrganizador.ThemeName = "VisualStudio2012Light"
        '
        'lblCodigo
        '
        Me.lblCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblCodigo.Location = New System.Drawing.Point(115, 36)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(99, 13)
        Me.lblCodigo.TabIndex = 120
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "ORIGEN:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "CANT. MASISA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "ORGANIZADOR:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(69, 149)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(43, 13)
        Me.Label36.TabIndex = 116
        Me.Label36.Text = "LOCAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "FECHA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "TEMA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "CANT. INGRESADA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "CÓDIGO"
        '
        'FrmListadoCapacitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 550)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvCapacitacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListadoCapacitacion"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "MBCORP"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.dgvCapacitacion.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCapacitacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.txtOrigenOtro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExpositor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantIngresada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantMasisa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrganizador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCapacitacion As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnAgregar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnModificar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnEliminar As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtExpositor As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtOrigen As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtTema As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCantIngresada As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCantMasisa As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtFecha As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtLocal As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtOrganizador As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOrigenOtro As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

