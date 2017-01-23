<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLocal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAforo = New Telerik.WinControls.UI.RadSpinEditor()
        Me.txtDireccion = New Telerik.WinControls.UI.RadTextBox()
        Me.txtNombre = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCodigo = New Telerik.WinControls.UI.RadTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New Telerik.WinControls.UI.RadButton()
        Me.btnLimpiar = New Telerik.WinControls.UI.RadButton()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.cboDistrito = New Telerik.WinControls.UI.RadDropDownList()
        Me.cboProvincia = New Telerik.WinControls.UI.RadDropDownList()
        Me.cboDepartamento = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.txtAforo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDistrito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CÓDIGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DIRECCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "AFORO"
        '
        'txtAforo
        '
        Me.txtAforo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAforo.Location = New System.Drawing.Point(128, 155)
        Me.txtAforo.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtAforo.Name = "txtAforo"
        '
        '
        '
        Me.txtAforo.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtAforo.Size = New System.Drawing.Size(100, 24)
        Me.txtAforo.TabIndex = 4
        Me.txtAforo.TabStop = False
        Me.txtAforo.ThemeName = "VisualStudio2012Light"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(128, 90)
        Me.txtDireccion.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtDireccion.Name = "txtDireccion"
        '
        '
        '
        Me.txtDireccion.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtDireccion.Size = New System.Drawing.Size(506, 24)
        Me.txtDireccion.TabIndex = 5
        Me.txtDireccion.ThemeName = "VisualStudio2012Light"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(128, 63)
        Me.txtNombre.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtNombre.Name = "txtNombre"
        '
        '
        '
        Me.txtNombre.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtNombre.Size = New System.Drawing.Size(506, 24)
        Me.txtNombre.TabIndex = 6
        Me.txtNombre.ThemeName = "VisualStudio2012Light"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(128, 36)
        Me.txtCodigo.MinimumSize = New System.Drawing.Size(0, 24)
        Me.txtCodigo.Name = "txtCodigo"
        '
        '
        '
        Me.txtCodigo.RootElement.MinSize = New System.Drawing.Size(0, 24)
        Me.txtCodigo.Size = New System.Drawing.Size(100, 24)
        Me.txtCodigo.TabIndex = 7
        Me.txtCodigo.ThemeName = "ControlDefault"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(-3, -1)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(693, 21)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "REGISTRO DE LOCAL"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(351, 188)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(138, 31)
        Me.btnRegistrar.TabIndex = 35
        Me.btnRegistrar.Text = "REGISTRAR"
        Me.btnRegistrar.ThemeName = "VisualStudio2012Light"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(497, 188)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(137, 31)
        Me.btnLimpiar.TabIndex = 36
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.ThemeName = "VisualStudio2012Light"
        '
        'cboDistrito
        '
        Me.cboDistrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDistrito.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDistrito.Location = New System.Drawing.Point(447, 119)
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.NullText = "DISTRITO"
        Me.cboDistrito.Size = New System.Drawing.Size(187, 31)
        Me.cboDistrito.TabIndex = 96
        Me.cboDistrito.ThemeName = "VisualStudio2012Light"
        '
        'cboProvincia
        '
        Me.cboProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProvincia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia.Location = New System.Drawing.Point(282, 119)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.NullText = "PROVINCIA"
        Me.cboProvincia.Size = New System.Drawing.Size(150, 31)
        Me.cboProvincia.TabIndex = 95
        Me.cboProvincia.ThemeName = "VisualStudio2012Light"
        '
        'cboDepartamento
        '
        Me.cboDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDepartamento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepartamento.Location = New System.Drawing.Point(128, 119)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.NullText = "DEPARTAMENTO"
        Me.cboDepartamento.Size = New System.Drawing.Size(144, 31)
        Me.cboDepartamento.TabIndex = 94
        Me.cboDepartamento.ThemeName = "VisualStudio2012Light"
        '
        'frmLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 236)
        Me.Controls.Add(Me.cboDistrito)
        Me.Controls.Add(Me.cboProvincia)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtAforo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLocal"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.txtAforo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDistrito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAforo As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents txtDireccion As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtNombre As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCodigo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnLimpiar As Telerik.WinControls.UI.RadButton
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents cboDistrito As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cboProvincia As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cboDepartamento As Telerik.WinControls.UI.RadDropDownList
End Class

