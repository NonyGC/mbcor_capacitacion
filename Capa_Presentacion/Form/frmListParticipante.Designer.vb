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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListParticipante))
        Me.dtgParticipantes = New Telerik.WinControls.UI.RadGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.dtgParticipantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgParticipantes.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgParticipantes
        '
        Me.dtgParticipantes.AutoScroll = True
        Me.dtgParticipantes.AutoSizeRows = True
        Me.dtgParticipantes.Location = New System.Drawing.Point(36, 56)
        '
        '
        '
        Me.dtgParticipantes.MasterTemplate.AllowAddNewRow = False
        Me.dtgParticipantes.MasterTemplate.AllowDeleteRow = False
        Me.dtgParticipantes.MasterTemplate.AllowSearchRow = True
        GridViewTextBoxColumn1.FieldName = "codigo"
        GridViewTextBoxColumn1.HeaderText = "CODIGO"
        GridViewTextBoxColumn1.Name = "CODIGO"
        GridViewTextBoxColumn1.Width = 100
        GridViewTextBoxColumn2.FieldName = "apellido_pat"
        GridViewTextBoxColumn2.HeaderText = "AP. PATERNO"
        GridViewTextBoxColumn2.Name = "column1"
        GridViewTextBoxColumn2.Width = 150
        GridViewTextBoxColumn3.FieldName = "apellido_mat"
        GridViewTextBoxColumn3.HeaderText = "AP. MATERNO"
        GridViewTextBoxColumn3.Name = "column2"
        GridViewTextBoxColumn3.Width = 150
        GridViewTextBoxColumn4.FieldName = "nombres"
        GridViewTextBoxColumn4.HeaderText = "NOMBRES"
        GridViewTextBoxColumn4.Name = "column3"
        GridViewTextBoxColumn4.Width = 150
        GridViewTextBoxColumn5.FieldName = "fecha_nacimiento"
        GridViewTextBoxColumn5.HeaderText = "F. NACIMIENTO"
        GridViewTextBoxColumn5.Name = "column4"
        GridViewTextBoxColumn5.Width = 80
        GridViewTextBoxColumn6.FieldName = "dni_ce"
        GridViewTextBoxColumn6.HeaderText = "DNI/CE"
        GridViewTextBoxColumn6.Name = "column5"
        GridViewTextBoxColumn6.Width = 80
        GridViewTextBoxColumn7.FieldName = "tel_fijo"
        GridViewTextBoxColumn7.HeaderText = "FIJO"
        GridViewTextBoxColumn7.Name = "column6"
        GridViewTextBoxColumn7.Width = 100
        GridViewTextBoxColumn8.FieldName = "tel_mol"
        GridViewTextBoxColumn8.HeaderText = "MOVIL"
        GridViewTextBoxColumn8.Name = "column7"
        GridViewTextBoxColumn8.Width = 100
        GridViewTextBoxColumn9.FieldName = "ope_movil"
        GridViewTextBoxColumn9.HeaderText = "OPE. MOVIL"
        GridViewTextBoxColumn9.Name = "column8"
        GridViewTextBoxColumn9.Width = 80
        GridViewTextBoxColumn10.FieldName = "email"
        GridViewTextBoxColumn10.HeaderText = "EMAIL"
        GridViewTextBoxColumn10.Name = "column9"
        GridViewTextBoxColumn10.Width = 300
        Me.dtgParticipantes.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10})
        Me.dtgParticipantes.MasterTemplate.EnablePaging = True
        Me.dtgParticipantes.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dtgParticipantes.Name = "dtgParticipantes"
        Me.dtgParticipantes.ReadOnly = True
        Me.dtgParticipantes.Size = New System.Drawing.Size(924, 524)
        Me.dtgParticipantes.TabIndex = 0
        Me.dtgParticipantes.ThemeName = "VisualStudio2012Light"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(-5, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1019, 21)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "LISTADO DE PARTICIPANTES REGISTRADOS"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmListParticipante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 629)
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
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgParticipantes As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class

