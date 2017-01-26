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
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadTextBox8 = New Telerik.WinControls.UI.RadTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox7 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox6 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox5 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox4 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadTextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(288, 84)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(151, 24)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "AGREGAR"
        Me.RadButton1.ThemeName = "VisualStudio2012Light"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(445, 84)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(151, 24)
        Me.RadButton2.TabIndex = 2
        Me.RadButton2.Text = "MODIFICAR"
        Me.RadButton2.ThemeName = "VisualStudio2012Light"
        '
        'RadButton3
        '
        Me.RadButton3.Location = New System.Drawing.Point(602, 84)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(151, 24)
        Me.RadButton3.TabIndex = 2
        Me.RadButton3.Text = "ELIMINAR"
        Me.RadButton3.ThemeName = "VisualStudio2012Light"
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
        Me.RadPanel1.Controls.Add(Me.RadTextBox8)
        Me.RadPanel1.Controls.Add(Me.Label9)
        Me.RadPanel1.Controls.Add(Me.RadTextBox1)
        Me.RadPanel1.Controls.Add(Me.RadTextBox7)
        Me.RadPanel1.Controls.Add(Me.RadTextBox6)
        Me.RadPanel1.Controls.Add(Me.RadTextBox5)
        Me.RadPanel1.Controls.Add(Me.RadTextBox4)
        Me.RadPanel1.Controls.Add(Me.RadTextBox3)
        Me.RadPanel1.Controls.Add(Me.RadTextBox2)
        Me.RadPanel1.Controls.Add(Me.Label2)
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
        'RadTextBox8
        '
        Me.RadTextBox8.AutoSize = False
        Me.RadTextBox8.Location = New System.Drawing.Point(118, 262)
        Me.RadTextBox8.MinimumSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox8.Multiline = True
        Me.RadTextBox8.Name = "RadTextBox8"
        Me.RadTextBox8.ReadOnly = True
        '
        '
        '
        Me.RadTextBox8.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox8.Size = New System.Drawing.Size(244, 24)
        Me.RadTextBox8.TabIndex = 129
        Me.RadTextBox8.ThemeName = "VisualStudio2012Light"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "EXPOSITOR:"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.AutoSize = False
        Me.RadTextBox1.Location = New System.Drawing.Point(118, 58)
        Me.RadTextBox1.MinimumSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox1.Multiline = True
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.ReadOnly = True
        '
        '
        '
        Me.RadTextBox1.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox1.Size = New System.Drawing.Size(244, 24)
        Me.RadTextBox1.TabIndex = 127
        Me.RadTextBox1.ThemeName = "VisualStudio2012Light"
        '
        'RadTextBox7
        '
        Me.RadTextBox7.AutoSize = False
        Me.RadTextBox7.Location = New System.Drawing.Point(118, 232)
        Me.RadTextBox7.MinimumSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox7.Multiline = True
        Me.RadTextBox7.Name = "RadTextBox7"
        Me.RadTextBox7.ReadOnly = True
        '
        '
        '
        Me.RadTextBox7.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox7.Size = New System.Drawing.Size(244, 24)
        Me.RadTextBox7.TabIndex = 125
        Me.RadTextBox7.ThemeName = "VisualStudio2012Light"
        '
        'RadTextBox6
        '
        Me.RadTextBox6.AutoSize = False
        Me.RadTextBox6.Location = New System.Drawing.Point(118, 203)
        Me.RadTextBox6.MinimumSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox6.Multiline = True
        Me.RadTextBox6.Name = "RadTextBox6"
        Me.RadTextBox6.ReadOnly = True
        '
        '
        '
        Me.RadTextBox6.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox6.Size = New System.Drawing.Size(244, 24)
        Me.RadTextBox6.TabIndex = 124
        Me.RadTextBox6.ThemeName = "VisualStudio2012Light"
        '
        'RadTextBox5
        '
        Me.RadTextBox5.AutoSize = False
        Me.RadTextBox5.Location = New System.Drawing.Point(118, 174)
        Me.RadTextBox5.MinimumSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox5.Multiline = True
        Me.RadTextBox5.Name = "RadTextBox5"
        Me.RadTextBox5.ReadOnly = True
        '
        '
        '
        Me.RadTextBox5.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox5.Size = New System.Drawing.Size(244, 24)
        Me.RadTextBox5.TabIndex = 123
        Me.RadTextBox5.ThemeName = "VisualStudio2012Light"
        '
        'RadTextBox4
        '
        Me.RadTextBox4.AutoSize = False
        Me.RadTextBox4.Location = New System.Drawing.Point(118, 145)
        Me.RadTextBox4.MinimumSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox4.Multiline = True
        Me.RadTextBox4.Name = "RadTextBox4"
        Me.RadTextBox4.ReadOnly = True
        '
        '
        '
        Me.RadTextBox4.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox4.Size = New System.Drawing.Size(244, 24)
        Me.RadTextBox4.TabIndex = 122
        Me.RadTextBox4.ThemeName = "VisualStudio2012Light"
        '
        'RadTextBox3
        '
        Me.RadTextBox3.AutoSize = False
        Me.RadTextBox3.Location = New System.Drawing.Point(118, 116)
        Me.RadTextBox3.MinimumSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox3.Multiline = True
        Me.RadTextBox3.Name = "RadTextBox3"
        Me.RadTextBox3.ReadOnly = True
        '
        '
        '
        Me.RadTextBox3.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox3.Size = New System.Drawing.Size(244, 24)
        Me.RadTextBox3.TabIndex = 126
        Me.RadTextBox3.ThemeName = "VisualStudio2012Light"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.AutoSize = False
        Me.RadTextBox2.Location = New System.Drawing.Point(118, 87)
        Me.RadTextBox2.MinimumSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox2.Multiline = True
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.ReadOnly = True
        '
        '
        '
        Me.RadTextBox2.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.RadTextBox2.Size = New System.Drawing.Size(244, 24)
        Me.RadTextBox2.TabIndex = 121
        Me.RadTextBox2.ThemeName = "VisualStudio2012Light"
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Location = New System.Drawing.Point(115, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 120
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "ORIGEN:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "CANT. MASISA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "ORGANIZADOR:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(69, 123)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(43, 13)
        Me.Label36.TabIndex = 116
        Me.Label36.Text = "LOCAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "FECHA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "TEMA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 210)
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
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
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
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadTextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCapacitacion As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadTextBox8 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox7 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox6 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox5 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox4 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

