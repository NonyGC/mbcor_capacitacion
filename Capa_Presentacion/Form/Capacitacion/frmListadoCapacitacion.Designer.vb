<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListadoCapacitacion
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoCapacitacion))
        Me.btnAgregar = New Telerik.WinControls.UI.RadButton()
        Me.btnEliminar = New Telerik.WinControls.UI.RadButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgvCapacitacion = New Telerik.WinControls.UI.RadGridView()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCapacitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCapacitacion.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(602, 44)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(151, 24)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.ThemeName = "VisualStudio2012Light"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(762, 44)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(151, 24)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.ThemeName = "VisualStudio2012Light"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(-4, -5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(956, 21)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "GESTIONAR CAPACITACIÓN"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvCapacitacion
        '
        Me.dgvCapacitacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCapacitacion.Location = New System.Drawing.Point(33, 74)
        '
        '
        '
        Me.dgvCapacitacion.MasterTemplate.AllowAddNewRow = False
        Me.dgvCapacitacion.MasterTemplate.AllowSearchRow = True
        GridViewTextBoxColumn1.FieldName = "codigo"
        GridViewTextBoxColumn1.HeaderText = "CODIGO"
        GridViewTextBoxColumn1.Name = "codigo"
        GridViewTextBoxColumn1.Width = 80
        GridViewTextBoxColumn2.FieldName = "origen"
        GridViewTextBoxColumn2.HeaderText = "ORIGEN"
        GridViewTextBoxColumn2.Name = "origen"
        GridViewTextBoxColumn2.Width = 150
        GridViewTextBoxColumn3.FieldName = "origOtro"
        GridViewTextBoxColumn3.HeaderText = "OTRO ORIGEN"
        GridViewTextBoxColumn3.Name = "origOtro"
        GridViewTextBoxColumn3.Width = 150
        GridViewTextBoxColumn4.FieldName = "organizador"
        GridViewTextBoxColumn4.HeaderText = "ORGANIZADOR"
        GridViewTextBoxColumn4.Name = "organizador"
        GridViewTextBoxColumn4.Width = 150
        GridViewTextBoxColumn5.FieldName = "lcod"
        GridViewTextBoxColumn5.HeaderText = "LCOD"
        GridViewTextBoxColumn5.IsVisible = False
        GridViewTextBoxColumn5.Name = "lcod"
        GridViewTextBoxColumn6.FieldName = "local"
        GridViewTextBoxColumn6.HeaderText = "LOCAL"
        GridViewTextBoxColumn6.Name = "local"
        GridViewTextBoxColumn6.Width = 300
        GridViewTextBoxColumn7.FieldName = "cantMasisa"
        GridViewTextBoxColumn7.HeaderText = "CANT. MASISA"
        GridViewTextBoxColumn7.Name = "cantMasisa"
        GridViewTextBoxColumn7.Width = 70
        GridViewTextBoxColumn8.FieldName = "cantIngresada"
        GridViewTextBoxColumn8.HeaderText = "CAN. INGRESADA"
        GridViewTextBoxColumn8.Name = "cantIngresada"
        GridViewTextBoxColumn8.Width = 70
        GridViewTextBoxColumn9.FieldName = "fecha"
        GridViewTextBoxColumn9.HeaderText = "FECHA"
        GridViewTextBoxColumn9.Name = "fecha"
        GridViewTextBoxColumn9.Width = 80
        GridViewTextBoxColumn10.FieldName = "tema"
        GridViewTextBoxColumn10.HeaderText = "TEMA"
        GridViewTextBoxColumn10.Name = "tema"
        GridViewTextBoxColumn10.Width = 200
        GridViewTextBoxColumn11.FieldName = "expositor"
        GridViewTextBoxColumn11.HeaderText = "EXPOSITOR"
        GridViewTextBoxColumn11.Name = "expositor"
        GridViewTextBoxColumn11.Width = 200
        Me.dgvCapacitacion.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewTextBoxColumn11})
        Me.dgvCapacitacion.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dgvCapacitacion.Name = "dgvCapacitacion"
        Me.dgvCapacitacion.ReadOnly = True
        Me.dgvCapacitacion.ShowGroupPanel = False
        Me.dgvCapacitacion.Size = New System.Drawing.Size(880, 389)
        Me.dgvCapacitacion.TabIndex = 89
        Me.dgvCapacitacion.ThemeName = "VisualStudio2012Light"
        '
        'FrmListadoCapacitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 495)
        Me.Controls.Add(Me.dgvCapacitacion)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(956, 528)
        Me.Name = "FrmListadoCapacitacion"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(956, 528)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MBCORP"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCapacitacion.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCapacitacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAgregar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnEliminar As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgvCapacitacion As Telerik.WinControls.UI.RadGridView
End Class

