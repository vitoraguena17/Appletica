<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_selectCadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btn_selectAluno = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_selectAtletica = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btn_selectLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Projeto_InterV2.My.Resources.Resources.Logo_Apptletica
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-33, -1)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(152, 94)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'btn_selectAluno
        '
        Me.btn_selectAluno.Animated = True
        Me.btn_selectAluno.AutoRoundedCorners = True
        Me.btn_selectAluno.BorderRadius = 18
        Me.btn_selectAluno.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_selectAluno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_selectAluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_selectAluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_selectAluno.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_selectAluno.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_selectAluno.ForeColor = System.Drawing.Color.White
        Me.btn_selectAluno.Location = New System.Drawing.Point(135, 67)
        Me.btn_selectAluno.Name = "btn_selectAluno"
        Me.btn_selectAluno.Size = New System.Drawing.Size(188, 39)
        Me.btn_selectAluno.TabIndex = 1
        Me.btn_selectAluno.Text = "ALUNO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ou"
        '
        'btn_selectAtletica
        '
        Me.btn_selectAtletica.Animated = True
        Me.btn_selectAtletica.AutoRoundedCorners = True
        Me.btn_selectAtletica.BorderRadius = 18
        Me.btn_selectAtletica.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_selectAtletica.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_selectAtletica.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_selectAtletica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_selectAtletica.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_selectAtletica.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_selectAtletica.ForeColor = System.Drawing.Color.White
        Me.btn_selectAtletica.Location = New System.Drawing.Point(135, 152)
        Me.btn_selectAtletica.Name = "btn_selectAtletica"
        Me.btn_selectAtletica.Size = New System.Drawing.Size(188, 39)
        Me.btn_selectAtletica.TabIndex = 3
        Me.btn_selectAtletica.Text = "ATLETICA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Selecione uma opção"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(406, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(29, 25)
        Me.Guna2ControlBox1.TabIndex = 5
        '
        'btn_selectLogin
        '
        Me.btn_selectLogin.Animated = True
        Me.btn_selectLogin.AutoRoundedCorners = True
        Me.btn_selectLogin.BorderColor = System.Drawing.Color.Transparent
        Me.btn_selectLogin.BorderRadius = 13
        Me.btn_selectLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_selectLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_selectLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_selectLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_selectLogin.FillColor = System.Drawing.Color.Transparent
        Me.btn_selectLogin.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_selectLogin.ForeColor = System.Drawing.Color.Black
        Me.btn_selectLogin.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_right_arrow_50
        Me.btn_selectLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btn_selectLogin.Location = New System.Drawing.Point(301, 197)
        Me.btn_selectLogin.Name = "btn_selectLogin"
        Me.btn_selectLogin.Size = New System.Drawing.Size(134, 28)
        Me.btn_selectLogin.TabIndex = 6
        Me.btn_selectLogin.Text = "LOGIN"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'frm_selectCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(447, 237)
        Me.Controls.Add(Me.btn_selectLogin)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_selectAtletica)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_selectAluno)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_selectCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_selectCadastro"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btn_selectAluno As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_selectAtletica As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_selectLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
