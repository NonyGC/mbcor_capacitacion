<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporte_Parti_EmaCel
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboDepartamento = New Telerik.WinControls.UI.RadDropDownList()
        Me.cboProvincia = New Telerik.WinControls.UI.RadDropDownList()
        Me.cboDistrito = New Telerik.WinControls.UI.RadDropDownList()
        Me.GroupBox3.SuspendLayout()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cboDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDistrito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadCheckBox1)
        Me.GroupBox3.Controls.Add(Me.RadCheckBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(33, 89)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(102, 55)
        Me.GroupBox3.TabIndex = 118
        Me.GroupBox3.TabStop = False
        '
        'RadCheckBox1
        '
        Me.RadCheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadCheckBox1.Location = New System.Drawing.Point(16, 14)
        Me.RadCheckBox1.Name = "RadCheckBox1"
        Me.RadCheckBox1.Size = New System.Drawing.Size(67, 18)
        Me.RadCheckBox1.TabIndex = 114
        Me.RadCheckBox1.Text = "CORREO"
        Me.RadCheckBox1.ThemeName = "VisualStudio2012Light"
        '
        'RadCheckBox2
        '
        Me.RadCheckBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadCheckBox2.Location = New System.Drawing.Point(16, 33)
        Me.RadCheckBox2.Name = "RadCheckBox2"
        Me.RadCheckBox2.Size = New System.Drawing.Size(68, 18)
        Me.RadCheckBox2.TabIndex = 114
        Me.RadCheckBox2.Text = "CELULAR"
        Me.RadCheckBox2.ThemeName = "VisualStudio2012Light"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboDepartamento)
        Me.GroupBox1.Controls.Add(Me.cboProvincia)
        Me.GroupBox1.Controls.Add(Me.cboDistrito)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 55)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "UBIGEO"
        '
        'cboDepartamento
        '
        Me.cboDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDepartamento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepartamento.Location = New System.Drawing.Point(22, 17)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.NullText = "DEPARTAMENTO"
        Me.cboDepartamento.Size = New System.Drawing.Size(115, 28)
        Me.cboDepartamento.TabIndex = 107
        Me.cboDepartamento.ThemeName = "VisualStudio2012Light"
        '
        'cboProvincia
        '
        Me.cboProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProvincia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia.Location = New System.Drawing.Point(143, 17)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.NullText = "PROVINCIA"
        Me.cboProvincia.Size = New System.Drawing.Size(115, 28)
        Me.cboProvincia.TabIndex = 108
        Me.cboProvincia.ThemeName = "VisualStudio2012Light"
        '
        'cboDistrito
        '
        Me.cboDistrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDistrito.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDistrito.Location = New System.Drawing.Point(264, 17)
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.NullText = "DISTRITO"
        Me.cboDistrito.Size = New System.Drawing.Size(157, 28)
        Me.cboDistrito.TabIndex = 109
        Me.cboDistrito.ThemeName = "VisualStudio2012Light"
        '
        'FrmReporte_Parti_EmaCel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 444)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmReporte_Parti_EmaCel"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "FrmReporte_Parti_EmaCel"
        Me.ThemeName = "VisualStudio2012Light"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cboDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDistrito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadCheckBox1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox2 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboDepartamento As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cboProvincia As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cboDistrito As Telerik.WinControls.UI.RadDropDownList
End Class

