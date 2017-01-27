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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListParticipante))
        Me.dtgParticipantes = New Telerik.WinControls.UI.RadGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnEliminar = New Telerik.WinControls.UI.RadButton()
        Me.btnModificar = New Telerik.WinControls.UI.RadButton()
        Me.btnAgregar = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.dtgParticipantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgParticipantes.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgParticipantes
        '
        Me.dtgParticipantes.AutoScroll = True
        Me.dtgParticipantes.AutoSizeRows = True
        Me.dtgParticipantes.Location = New System.Drawing.Point(38, 99)
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
        GridViewTextBoxColumn5.FieldName = "fecha_nacimiento"
        GridViewTextBoxColumn5.HeaderText = "F. NACIMIENTO"
        GridViewTextBoxColumn5.Name = "fecha_nacimiento"
        GridViewTextBoxColumn5.Width = 80
        GridViewTextBoxColumn6.FieldName = "dni_ce"
        GridViewTextBoxColumn6.HeaderText = "DNI/CE"
        GridViewTextBoxColumn6.Name = "dni_ce"
        GridViewTextBoxColumn6.Width = 80
        GridViewTextBoxColumn7.FieldName = "direccion"
        GridViewTextBoxColumn7.HeaderText = "DIRECCIÓN"
        GridViewTextBoxColumn7.IsVisible = False
        GridViewTextBoxColumn7.Name = "direccion"
        GridViewTextBoxColumn8.FieldName = "ubigeo"
        GridViewTextBoxColumn8.HeaderText = "UBIGEO"
        GridViewTextBoxColumn8.IsVisible = False
        GridViewTextBoxColumn8.Name = "ubigeo"
        GridViewTextBoxColumn9.FieldName = "tel_fijo"
        GridViewTextBoxColumn9.HeaderText = "FIJO"
        GridViewTextBoxColumn9.Name = "tel_fijo"
        GridViewTextBoxColumn9.Width = 100
        GridViewTextBoxColumn10.FieldName = "tel_mol"
        GridViewTextBoxColumn10.HeaderText = "MOVIL"
        GridViewTextBoxColumn10.Name = "tel_mol"
        GridViewTextBoxColumn10.Width = 100
        GridViewTextBoxColumn11.FieldName = "ope_movil"
        GridViewTextBoxColumn11.HeaderText = "OPE. MOVIL"
        GridViewTextBoxColumn11.Name = "ope_movil"
        GridViewTextBoxColumn11.Width = 80
        GridViewTextBoxColumn12.FieldName = "email"
        GridViewTextBoxColumn12.HeaderText = "EMAIL"
        GridViewTextBoxColumn12.Name = "email"
        GridViewTextBoxColumn12.Width = 300
        GridViewTextBoxColumn13.FieldName = "estado_civ"
        GridViewTextBoxColumn13.HeaderText = "ESTADO CIVIL"
        GridViewTextBoxColumn13.IsVisible = False
        GridViewTextBoxColumn13.Name = "estado_civ"
        GridViewTextBoxColumn14.FieldName = "profe_ocupa"
        GridViewTextBoxColumn14.HeaderText = "PROFE/OFICIO"
        GridViewTextBoxColumn14.IsVisible = False
        GridViewTextBoxColumn14.Name = "profe_ocupa"
        Me.dtgParticipantes.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewTextBoxColumn11, GridViewTextBoxColumn12, GridViewTextBoxColumn13, GridViewTextBoxColumn14})
        Me.dtgParticipantes.MasterTemplate.EnablePaging = True
        Me.dtgParticipantes.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dtgParticipantes.Name = "dtgParticipantes"
        Me.dtgParticipantes.ReadOnly = True
        Me.dtgParticipantes.Size = New System.Drawing.Size(924, 435)
        Me.dtgParticipantes.TabIndex = 0
        Me.dtgParticipantes.ThemeName = "VisualStudio2012Light"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(-2, -3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1015, 21)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "LISTADO DE PARTICIPANTES REGISTRADOS"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(810, 55)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(151, 24)
        Me.btnEliminar.TabIndex = 86
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.ThemeName = "VisualStudio2012Light"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(652, 55)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(151, 24)
        Me.btnModificar.TabIndex = 85
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.ThemeName = "VisualStudio2012Light"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(494, 55)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(151, 24)
        Me.btnAgregar.TabIndex = 84
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.ThemeName = "VisualStudio2012Light"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(38, 55)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(151, 24)
        Me.RadButton1.TabIndex = 87
        Me.RadButton1.Text = "ACTUALIZAR"
        Me.RadButton1.ThemeName = "VisualStudio2012Light"
        '
        'FrmListParticipante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 565)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtgParticipantes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListParticipante"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "MBCORP"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.dtgParticipantes.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgParticipantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgParticipantes As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnModificar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAgregar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class

