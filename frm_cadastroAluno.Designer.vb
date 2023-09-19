<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastroAluno
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cadastrar_aluno = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.cb_visualizar_aluno = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btn_loginAluno = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_confirmarSenha_aluno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_senha_aluno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_email_aluno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_nome_aluno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.cmb_selectAtletica = New Guna.UI2.WinForms.Guna2ComboBox()
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
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(842, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(29, 25)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(807, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(29, 25)
        Me.Guna2ControlBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(576, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CADASTRO ALUNO"
        '
        'btn_cadastrar_aluno
        '
        Me.btn_cadastrar_aluno.Animated = True
        Me.btn_cadastrar_aluno.AutoRoundedCorners = True
        Me.btn_cadastrar_aluno.BorderRadius = 22
        Me.btn_cadastrar_aluno.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cadastrar_aluno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cadastrar_aluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cadastrar_aluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cadastrar_aluno.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_cadastrar_aluno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_cadastrar_aluno.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar_aluno.Location = New System.Drawing.Point(553, 313)
        Me.btn_cadastrar_aluno.Name = "btn_cadastrar_aluno"
        Me.btn_cadastrar_aluno.Size = New System.Drawing.Size(239, 47)
        Me.btn_cadastrar_aluno.TabIndex = 8
        Me.btn_cadastrar_aluno.Text = "CADASTRAR"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'cb_visualizar_aluno
        '
        Me.cb_visualizar_aluno.AutoSize = True
        Me.cb_visualizar_aluno.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cb_visualizar_aluno.CheckedState.BorderRadius = 0
        Me.cb_visualizar_aluno.CheckedState.BorderThickness = 0
        Me.cb_visualizar_aluno.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cb_visualizar_aluno.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cb_visualizar_aluno.Location = New System.Drawing.Point(542, 228)
        Me.cb_visualizar_aluno.Name = "cb_visualizar_aluno"
        Me.cb_visualizar_aluno.Size = New System.Drawing.Size(75, 17)
        Me.cb_visualizar_aluno.TabIndex = 10
        Me.cb_visualizar_aluno.Text = "Visualizar"
        Me.cb_visualizar_aluno.UncheckedState.BorderColor = System.Drawing.Color.Silver
        Me.cb_visualizar_aluno.UncheckedState.BorderRadius = 0
        Me.cb_visualizar_aluno.UncheckedState.BorderThickness = 0
        Me.cb_visualizar_aluno.UncheckedState.FillColor = System.Drawing.Color.Silver
        '
        'btn_loginAluno
        '
        Me.btn_loginAluno.Animated = True
        Me.btn_loginAluno.AutoRoundedCorners = True
        Me.btn_loginAluno.BorderColor = System.Drawing.Color.Transparent
        Me.btn_loginAluno.BorderRadius = 12
        Me.btn_loginAluno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_loginAluno.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_loginAluno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_loginAluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_loginAluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_loginAluno.FillColor = System.Drawing.Color.Transparent
        Me.btn_loginAluno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_loginAluno.ForeColor = System.Drawing.Color.Black
        Me.btn_loginAluno.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_right_arrow_50
        Me.btn_loginAluno.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btn_loginAluno.Location = New System.Drawing.Point(751, 380)
        Me.btn_loginAluno.Name = "btn_loginAluno"
        Me.btn_loginAluno.Size = New System.Drawing.Size(94, 26)
        Me.btn_loginAluno.TabIndex = 9
        Me.btn_loginAluno.Text = "LOGIN"
        '
        'txt_confirmarSenha_aluno
        '
        Me.txt_confirmarSenha_aluno.Animated = True
        Me.txt_confirmarSenha_aluno.BorderColor = System.Drawing.Color.Black
        Me.txt_confirmarSenha_aluno.BorderRadius = 8
        Me.txt_confirmarSenha_aluno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_confirmarSenha_aluno.DefaultText = ""
        Me.txt_confirmarSenha_aluno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_confirmarSenha_aluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_confirmarSenha_aluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_confirmarSenha_aluno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_confirmarSenha_aluno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_confirmarSenha_aluno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_confirmarSenha_aluno.ForeColor = System.Drawing.Color.Black
        Me.txt_confirmarSenha_aluno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_confirmarSenha_aluno.IconLeft = Global.Projeto_InterV2.My.Resources.Resources.icons8_password_30
        Me.txt_confirmarSenha_aluno.Location = New System.Drawing.Point(533, 190)
        Me.txt_confirmarSenha_aluno.Name = "txt_confirmarSenha_aluno"
        Me.txt_confirmarSenha_aluno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_confirmarSenha_aluno.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_confirmarSenha_aluno.PlaceholderText = "Confirmar Senha"
        Me.txt_confirmarSenha_aluno.SelectedText = ""
        Me.txt_confirmarSenha_aluno.Size = New System.Drawing.Size(269, 32)
        Me.txt_confirmarSenha_aluno.TabIndex = 7
        '
        'txt_senha_aluno
        '
        Me.txt_senha_aluno.Animated = True
        Me.txt_senha_aluno.BorderColor = System.Drawing.Color.Black
        Me.txt_senha_aluno.BorderRadius = 8
        Me.txt_senha_aluno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha_aluno.DefaultText = ""
        Me.txt_senha_aluno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_senha_aluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_senha_aluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_senha_aluno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_senha_aluno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_senha_aluno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_senha_aluno.ForeColor = System.Drawing.Color.Black
        Me.txt_senha_aluno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_senha_aluno.IconLeft = Global.Projeto_InterV2.My.Resources.Resources.icons8_password_30
        Me.txt_senha_aluno.Location = New System.Drawing.Point(533, 152)
        Me.txt_senha_aluno.Name = "txt_senha_aluno"
        Me.txt_senha_aluno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_senha_aluno.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_senha_aluno.PlaceholderText = "Senha"
        Me.txt_senha_aluno.SelectedText = ""
        Me.txt_senha_aluno.Size = New System.Drawing.Size(269, 32)
        Me.txt_senha_aluno.TabIndex = 6
        '
        'txt_email_aluno
        '
        Me.txt_email_aluno.Animated = True
        Me.txt_email_aluno.BorderColor = System.Drawing.Color.Black
        Me.txt_email_aluno.BorderRadius = 8
        Me.txt_email_aluno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email_aluno.DefaultText = ""
        Me.txt_email_aluno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_email_aluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_email_aluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email_aluno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email_aluno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email_aluno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_email_aluno.ForeColor = System.Drawing.Color.Black
        Me.txt_email_aluno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email_aluno.IconLeft = Global.Projeto_InterV2.My.Resources.Resources.icons8_email_30
        Me.txt_email_aluno.Location = New System.Drawing.Point(533, 114)
        Me.txt_email_aluno.Name = "txt_email_aluno"
        Me.txt_email_aluno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email_aluno.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_email_aluno.PlaceholderText = "E-mail"
        Me.txt_email_aluno.SelectedText = ""
        Me.txt_email_aluno.Size = New System.Drawing.Size(269, 32)
        Me.txt_email_aluno.TabIndex = 5
        '
        'txt_nome_aluno
        '
        Me.txt_nome_aluno.Animated = True
        Me.txt_nome_aluno.BorderColor = System.Drawing.Color.Black
        Me.txt_nome_aluno.BorderRadius = 8
        Me.txt_nome_aluno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome_aluno.DefaultText = ""
        Me.txt_nome_aluno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_nome_aluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_nome_aluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nome_aluno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nome_aluno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nome_aluno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nome_aluno.ForeColor = System.Drawing.Color.Black
        Me.txt_nome_aluno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nome_aluno.IconLeft = Global.Projeto_InterV2.My.Resources.Resources.icons8_name_30
        Me.txt_nome_aluno.Location = New System.Drawing.Point(533, 76)
        Me.txt_nome_aluno.Name = "txt_nome_aluno"
        Me.txt_nome_aluno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nome_aluno.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_nome_aluno.PlaceholderText = "Nome Aluno"
        Me.txt_nome_aluno.SelectedText = ""
        Me.txt_nome_aluno.Size = New System.Drawing.Size(269, 32)
        Me.txt_nome_aluno.TabIndex = 4
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
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'cmb_selectAtletica
        '
        Me.cmb_selectAtletica.BackColor = System.Drawing.Color.Transparent
        Me.cmb_selectAtletica.BorderColor = System.Drawing.Color.Black
        Me.cmb_selectAtletica.BorderRadius = 8
        Me.cmb_selectAtletica.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_selectAtletica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_selectAtletica.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_selectAtletica.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_selectAtletica.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_selectAtletica.ForeColor = System.Drawing.Color.Black
        Me.cmb_selectAtletica.ItemHeight = 30
        Me.cmb_selectAtletica.Location = New System.Drawing.Point(533, 251)
        Me.cmb_selectAtletica.Name = "cmb_selectAtletica"
        Me.cmb_selectAtletica.Size = New System.Drawing.Size(269, 36)
        Me.cmb_selectAtletica.TabIndex = 11
        '
        'frm_cadastroAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(883, 429)
        Me.Controls.Add(Me.cmb_selectAtletica)
        Me.Controls.Add(Me.cb_visualizar_aluno)
        Me.Controls.Add(Me.btn_loginAluno)
        Me.Controls.Add(Me.btn_cadastrar_aluno)
        Me.Controls.Add(Me.txt_confirmarSenha_aluno)
        Me.Controls.Add(Me.txt_senha_aluno)
        Me.Controls.Add(Me.txt_email_aluno)
        Me.Controls.Add(Me.txt_nome_aluno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cadastroAluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cadastroAluno"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome_aluno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_email_aluno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_senha_aluno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_confirmarSenha_aluno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_cadastrar_aluno As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_loginAluno As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents cb_visualizar_aluno As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents cmb_selectAtletica As Guna.UI2.WinForms.Guna2ComboBox
End Class
