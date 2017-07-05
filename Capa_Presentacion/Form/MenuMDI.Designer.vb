<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuMDI
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
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.gestionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrmParticipante = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrmParticipanteEvento = New System.Windows.Forms.ToolStripMenuItem()
        Me.reporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrmParticipanteList = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 476)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(849, 26)
        Me.RadStatusStrip1.TabIndex = 2
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        Me.RadStatusStrip1.ThemeName = "VisualStudio2012Light"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gestionarToolStripMenuItem, Me.reporteToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(849, 24)
        Me.menuStrip1.TabIndex = 7
        Me.menuStrip1.Text = "menuStrip1"
        '
        'gestionarToolStripMenuItem
        '
        Me.gestionarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FrmParticipante, Me.FrmParticipanteEvento})
        Me.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem"
        Me.gestionarToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.gestionarToolStripMenuItem.Text = "Gestionar"
        '
        'FrmParticipante
        '
        Me.FrmParticipante.Name = "FrmParticipante"
        Me.FrmParticipante.Size = New System.Drawing.Size(180, 22)
        Me.FrmParticipante.Tag = "FrmParticipante"
        Me.FrmParticipante.Text = "Participante General"
        '
        'FrmParticipanteEvento
        '
        Me.FrmParticipanteEvento.Name = "FrmParticipanteEvento"
        Me.FrmParticipanteEvento.Size = New System.Drawing.Size(180, 22)
        Me.FrmParticipanteEvento.Tag = "FrmParticipanteEvento"
        Me.FrmParticipanteEvento.Text = "Participante Evento"
        '
        'reporteToolStripMenuItem
        '
        Me.reporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FrmParticipanteList})
        Me.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem"
        Me.reporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.reporteToolStripMenuItem.Text = "Reporte"
        '
        'FrmParticipanteList
        '
        Me.FrmParticipanteList.Name = "FrmParticipanteList"
        Me.FrmParticipanteList.Size = New System.Drawing.Size(178, 22)
        Me.FrmParticipanteList.Tag = "FrmParticipanteList"
        Me.FrmParticipanteList.Text = "Listado Participante"
        '
        'toolStrip1
        '
        Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(849, 25)
        Me.toolStrip1.TabIndex = 8
        Me.toolStrip1.Text = "toolStrip1"
        '
        'MenuMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 502)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MenuMDI"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "MenuMDI"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents gestionarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents FrmParticipante As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents FrmParticipanteEvento As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents reporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents FrmParticipanteList As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
End Class

