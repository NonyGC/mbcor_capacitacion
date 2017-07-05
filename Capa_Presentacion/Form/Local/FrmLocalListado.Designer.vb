<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLocalListado
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLocalListado))
        Me.dtgLocal = New Telerik.WinControls.UI.RadGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnEliminar = New Telerik.WinControls.UI.RadButton()
        Me.btnAgregar = New Telerik.WinControls.UI.RadButton()
        CType(Me.dtgLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgLocal.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgLocal
        '
        Me.dtgLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dtgLocal.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtgLocal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dtgLocal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgLocal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtgLocal.Location = New System.Drawing.Point(33, 71)
        '
        '
        '
        Me.dtgLocal.MasterTemplate.AllowAddNewRow = False
        Me.dtgLocal.MasterTemplate.AllowSearchRow = True
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "codigo"
        GridViewTextBoxColumn1.HeaderText = "CODIGO"
        GridViewTextBoxColumn1.Name = "codigo"
        GridViewTextBoxColumn1.Width = 98
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "nombre"
        GridViewTextBoxColumn2.HeaderText = "NOMBRE LOCAL"
        GridViewTextBoxColumn2.Name = "nombre"
        GridViewTextBoxColumn2.Width = 281
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "direccion"
        GridViewTextBoxColumn3.HeaderText = "DIRECCIÓN"
        GridViewTextBoxColumn3.Name = "direccion"
        GridViewTextBoxColumn3.Width = 309
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "aforo"
        GridViewTextBoxColumn4.HeaderText = "AFORO"
        GridViewTextBoxColumn4.Name = "aforo"
        GridViewTextBoxColumn4.Width = 53
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "ubigeo"
        GridViewTextBoxColumn5.HeaderText = "UBIGEO"
        GridViewTextBoxColumn5.Name = "ubigeo"
        GridViewTextBoxColumn5.Width = 96
        Me.dtgLocal.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5})
        Me.dtgLocal.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dtgLocal.Name = "dtgLocal"
        Me.dtgLocal.ReadOnly = True
        Me.dtgLocal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtgLocal.ShowGroupPanel = False
        Me.dtgLocal.Size = New System.Drawing.Size(851, 389)
        Me.dtgLocal.TabIndex = 93
        Me.dtgLocal.ThemeName = "VisualStudio2012Light"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(-2, -1)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(924, 21)
        Me.Label15.TabIndex = 92
        Me.Label15.Text = "GESTIONAR LOCAL"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(733, 41)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(151, 24)
        Me.btnEliminar.TabIndex = 91
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.ThemeName = "VisualStudio2012Light"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(574, 41)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(151, 24)
        Me.btnAgregar.TabIndex = 90
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.ThemeName = "VisualStudio2012Light"
        '
        'FrmLocalListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 492)
        Me.Controls.Add(Me.dtgLocal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLocalListado"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MBCORP"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.dtgLocal.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgLocal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgLocal As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAgregar As Telerik.WinControls.UI.RadButton
End Class

