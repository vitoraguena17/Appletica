<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_entrar
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
        Me.btn_entrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label_esqueceu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.cb_visualizar = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btn_atletica = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_aluno = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_senha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
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
        'btn_entrar
        '
        Me.btn_entrar.Animated = True
        Me.btn_entrar.AutoRoundedCorners = True
        Me.btn_entrar.BorderRadius = 19
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_entrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_entrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_entrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_entrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_entrar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_entrar.ForeColor = System.Drawing.Color.White
        Me.btn_entrar.Location = New System.Drawing.Point(552, 236)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(228, 41)
        Me.btn_entrar.TabIndex = 4
        Me.btn_entrar.Text = "ENTRAR"
        '
        'Label_esqueceu
        '
        Me.Label_esqueceu.AutoSize = True
        Me.Label_esqueceu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_esqueceu.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_esqueceu.Location = New System.Drawing.Point(606, 280)
        Me.Label_esqueceu.Name = "Label_esqueceu"
        Me.Label_esqueceu.Size = New System.Drawing.Size(123, 19)
        Me.Label_esqueceu.TabIndex = 5
        Me.Label_esqueceu.Text = "Esqueceu a senha?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(633, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "LOGIN"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(842, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(29, 25)
        Me.Guna2ControlBox1.TabIndex = 9
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(807, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(29, 25)
        Me.Guna2ControlBox2.TabIndex = 10
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'cb_visualizar
        '
        Me.cb_visualizar.AutoSize = True
        Me.cb_visualizar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cb_visualizar.CheckedState.BorderRadius = 0
        Me.cb_visualizar.CheckedState.BorderThickness = 0
        Me.cb_visualizar.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cb_visualizar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cb_visualizar.Location = New System.Drawing.Point(545, 200)
        Me.cb_visualizar.Name = "cb_visualizar"
        Me.cb_visualizar.Size = New System.Drawing.Size(75, 17)
        Me.cb_visualizar.TabIndex = 11
        Me.cb_visualizar.Text = "Visualizar"
        Me.cb_visualizar.UncheckedState.BorderColor = System.Drawing.Color.Silver
        Me.cb_visualizar.UncheckedState.BorderRadius = 0
        Me.cb_visualizar.UncheckedState.BorderThickness = 0
        Me.cb_visualizar.UncheckedState.FillColor = System.Drawing.Color.Silver
        '
        'btn_atletica
        '
        Me.btn_atletica.Animated = True
        Me.btn_atletica.AutoRoundedCorners = True
        Me.btn_atletica.BorderColor = System.Drawing.Color.Transparent
        Me.btn_atletica.BorderRadius = 13
        Me.btn_atletica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_atletica.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_atletica.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_atletica.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_atletica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_atletica.FillColor = System.Drawing.Color.Transparent
        Me.btn_atletica.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_atletica.ForeColor = System.Drawing.Color.Black
        Me.btn_atletica.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_right_arrow_50
        Me.btn_atletica.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btn_atletica.Location = New System.Drawing.Point(552, 365)
        Me.btn_atletica.Name = "btn_atletica"
        Me.btn_atletica.Size = New System.Drawing.Size(228, 28)
        Me.btn_atletica.TabIndex = 7
        Me.btn_atletica.Text = "CADASTRO ATLETICA"
        '
        'btn_aluno
        '
        Me.btn_aluno.Animated = True
        Me.btn_aluno.AutoRoundedCorners = True
        Me.btn_aluno.BorderColor = System.Drawing.Color.Transparent
        Me.btn_aluno.BorderRadius = 12
        Me.btn_aluno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aluno.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_aluno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_aluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_aluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_aluno.FillColor = System.Drawing.Color.Transparent
        Me.btn_aluno.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_aluno.ForeColor = System.Drawing.Color.Black
        Me.btn_aluno.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_right_arrow_50
        Me.btn_aluno.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btn_aluno.Location = New System.Drawing.Point(550, 332)
        Me.btn_aluno.Name = "btn_aluno"
        Me.btn_aluno.Size = New System.Drawing.Size(228, 27)
        Me.btn_aluno.TabIndex = 6
        Me.btn_aluno.Text = "CADASTRO ALUNO"
        '
        'txt_senha
        '
        Me.txt_senha.Animated = True
        Me.txt_senha.BorderColor = System.Drawing.Color.Black
        Me.txt_senha.BorderRadius = 8
        Me.txt_senha.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.DefaultText = ""
        Me.txt_senha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_senha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_senha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_senha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_senha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_senha.ForeColor = System.Drawing.Color.Black
        Me.txt_senha.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_senha.IconLeft = Global.Projeto_InterV2.My.Resources.Resources.icons8_password_30
        Me.txt_senha.Location = New System.Drawing.Point(537, 162)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_senha.PlaceholderText = "Senha"
        Me.txt_senha.SelectedText = ""
        Me.txt_senha.Size = New System.Drawing.Size(269, 32)
        Me.txt_senha.TabIndex = 2
        '
        'txt_email
        '
        Me.txt_email.Animated = True
        Me.txt_email.BorderColor = System.Drawing.Color.Black
        Me.txt_email.BorderRadius = 8
        Me.txt_email.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.DefaultText = ""
        Me.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_email.ForeColor = System.Drawing.Color.Black
        Me.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.IconLeft = Global.Projeto_InterV2.My.Resources.Resources.icons8_email_30
        Me.txt_email.Location = New System.Drawing.Point(537, 114)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_email.PlaceholderText = "E-mail"
        Me.txt_email.SelectedText = ""
        Me.txt_email.Size = New System.Drawing.Size(269, 32)
        Me.txt_email.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Projeto_InterV2.My.Resources.Resources.Logo_Apptletica__1_
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(455, 413)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'frm_entrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(883, 429)
        Me.Controls.Add(Me.cb_visualizar)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_atletica)
        Me.Controls.Add(Me.btn_aluno)
        Me.Controls.Add(Me.Label_esqueceu)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_entrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents txt_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_senha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_entrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_aluno As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label_esqueceu As Label
    Friend WithEvents btn_atletica As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents cb_visualizar As Guna.UI2.WinForms.Guna2CheckBox
End Class
