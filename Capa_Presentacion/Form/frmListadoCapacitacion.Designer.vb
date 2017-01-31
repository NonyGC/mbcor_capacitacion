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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoCapacitacion))
        Me.dgvCapacitacion = New Telerik.WinControls.UI.RadGridView()
        Me.btnAgregar = New Telerik.WinControls.UI.RadButton()
        Me.btnModificar = New Telerik.WinControls.UI.RadButton()
        Me.btnEliminar = New Telerik.WinControls.UI.RadButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.dgvCapacitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCapacitacion.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        GridViewTextBoxColumn6.Name = "cantMasisa"
        GridViewTextBoxColumn7.FieldName = "cantIngresada"
        GridViewTextBoxColumn7.HeaderText = "CANT.INGRESADA"
        GridViewTextBoxColumn7.Name = "cantIngresada"
        GridViewTextBoxColumn8.FieldName = "fecha"
        GridViewTextBoxColumn8.HeaderText = "FECHA"
        GridViewTextBoxColumn8.Name = "fecha"
        GridViewTextBoxColumn8.Width = 80
        GridViewTextBoxColumn9.FieldName = "tema"
        GridViewTextBoxColumn9.HeaderText = "TEMA"
        GridViewTextBoxColumn9.Name = "tema"
        GridViewTextBoxColumn9.Width = 150
        GridViewTextBoxColumn10.FieldName = "expositor"
        GridViewTextBoxColumn10.HeaderText = "EXPOSITOR"
        GridViewTextBoxColumn10.Name = "expositor"
        GridViewTextBoxColumn10.Width = 150
        Me.dgvCapacitacion.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10})
        Me.dgvCapacitacion.MasterTemplate.EnablePaging = True
        Me.dgvCapacitacion.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dgvCapacitacion.Name = "dgvCapacitacion"
        Me.dgvCapacitacion.ReadOnly = True
        Me.dgvCapacitacion.Size = New System.Drawing.Size(932, 418)
        Me.dgvCapacitacion.TabIndex = 0
        Me.dgvCapacitacion.ThemeName = "VisualStudio2012Light"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(499, 84)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(151, 24)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.ThemeName = "VisualStudio2012Light"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(656, 84)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(151, 24)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.ThemeName = "VisualStudio2012Light"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(813, 84)
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
        Me.Label15.Size = New System.Drawing.Size(1003, 21)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "GESTIONAR CAPACITACIÓN"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(34, 84)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(151, 24)
        Me.RadButton1.TabIndex = 88
        Me.RadButton1.Text = "ACTUALIZAR"
        Me.RadButton1.ThemeName = "VisualStudio2012Light"
        '
        'FrmListadoCapacitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 563)
        Me.Controls.Add(Me.RadButton1)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MBCORP"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.dgvCapacitacion.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCapacitacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCapacitacion As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnAgregar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnModificar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnEliminar As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class

