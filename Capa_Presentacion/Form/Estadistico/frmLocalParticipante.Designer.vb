<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalParticipante
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocalParticipante))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgvLocalParticipante = New Telerik.WinControls.UI.RadGridView()
        CType(Me.dgvLocalParticipante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLocalParticipante.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(-3, -2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(614, 21)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "CANTIDAD PARTICIPANTES POR LOCAL"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvLocalParticipante
        '
        Me.dgvLocalParticipante.Location = New System.Drawing.Point(43, 45)
        '
        '
        '
        Me.dgvLocalParticipante.MasterTemplate.AllowAddNewRow = False
        Me.dgvLocalParticipante.MasterTemplate.AllowSearchRow = True
        Me.dgvLocalParticipante.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn1.FieldName = "codcap"
        GridViewTextBoxColumn1.HeaderText = "CODIGO"
        GridViewTextBoxColumn1.Name = "codcap"
        GridViewTextBoxColumn1.Width = 60
        GridViewTextBoxColumn2.FieldName = "nombre"
        GridViewTextBoxColumn2.HeaderText = "LOCAL"
        GridViewTextBoxColumn2.Name = "nombre"
        GridViewTextBoxColumn2.Width = 299
        GridViewTextBoxColumn3.FieldName = "fecha"
        GridViewTextBoxColumn3.HeaderText = "FECHA"
        GridViewTextBoxColumn3.Name = "fecha"
        GridViewTextBoxColumn3.Width = 80
        GridViewTextBoxColumn4.FieldName = "cantidad"
        GridViewTextBoxColumn4.HeaderText = "CANTIDAD"
        GridViewTextBoxColumn4.Name = "cantidad"
        GridViewTextBoxColumn4.Width = 70
        Me.dgvLocalParticipante.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4})
        Me.dgvLocalParticipante.MasterTemplate.EnableGrouping = False
        Me.dgvLocalParticipante.MasterTemplate.EnablePaging = True
        Me.dgvLocalParticipante.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.dgvLocalParticipante.Name = "dgvLocalParticipante"
        Me.dgvLocalParticipante.ReadOnly = True
        Me.dgvLocalParticipante.Size = New System.Drawing.Size(525, 352)
        Me.dgvLocalParticipante.TabIndex = 84
        Me.dgvLocalParticipante.Text = "RadGridView1"
        Me.dgvLocalParticipante.ThemeName = "VisualStudio2012Light"
        '
        'frmLocalParticipante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 431)
        Me.Controls.Add(Me.dgvLocalParticipante)
        Me.Controls.Add(Me.Label15)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLocalParticipante"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.dgvLocalParticipante.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLocalParticipante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgvLocalParticipante As Telerik.WinControls.UI.RadGridView
End Class

