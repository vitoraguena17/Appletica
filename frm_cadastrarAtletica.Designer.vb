<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastrarAtletica
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
        Me.btn_cadastrar_atletica = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btn_loginAtletica = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_confirmarSenha_atletica = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_senha_atletica = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_email_atletica = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_nome_atletica = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.cb_visualizar_atletica = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.cmb_instituicao = New Guna.UI2.WinForms.Guna2ComboBox()
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
        'btn_cadastrar_atletica
        '
        Me.btn_cadastrar_atletica.Animated = True
        Me.btn_cadastrar_atletica.AutoRoundedCorners = True
        Me.btn_cadastrar_atletica.BorderRadius = 22
        Me.btn_cadastrar_atletica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar_atletica.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cadastrar_atletica.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cadastrar_atletica.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cadastrar_atletica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cadastrar_atletica.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_cadastrar_atletica.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cadastrar_atletica.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar_atletica.Location = New System.Drawing.Point(553, 313)
        Me.btn_cadastrar_atletica.Name = "btn_cadastrar_atletica"
        Me.btn_cadastrar_atletica.Size = New System.Drawing.Size(239, 47)
        Me.btn_cadastrar_atletica.TabIndex = 5
        Me.btn_cadastrar_atletica.Text = "CADASTRAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(554, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CADASTRO ATLETICA"
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
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(842, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(29, 25)
        Me.Guna2ControlBox1.TabIndex = 8
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
        Me.Guna2ControlBox2.TabIndex = 9
        '
        'btn_loginAtletica
        '
        Me.btn_loginAtletica.Animated = True
        Me.btn_loginAtletica.AutoRoundedCorners = True
        Me.btn_loginAtletica.BorderRadius = 12
        Me.btn_loginAtletica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_loginAtletica.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_loginAtletica.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_loginAtletica.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_loginAtletica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_loginAtletica.FillColor = System.Drawing.Color.White
        Me.btn_loginAtletica.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_loginAtletica.ForeColor = System.Drawing.Color.Black
        Me.btn_loginAtletica.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_right_arrow_50
        Me.btn_loginAtletica.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btn_loginAtletica.Location = New System.Drawing.Point(751, 380)
        Me.btn_loginAtletica.Name = "btn_loginAtletica"
        Me.btn_loginAtletica.Size = New System.Drawing.Size(94, 26)
        Me.btn_loginAtletica.TabIndex = 7
        Me.btn_loginAtletica.Text = "LOGIN"
        '
        'txt_confirmarSenha_atletica
        '
        Me.txt_confirmarSenha_atletica.Animated = True
        Me.txt_confirmarSenha_atletica.BorderColor = System.Drawing.Color.Black
        Me.txt_confirmarSenha_atletica.BorderRadius = 8
        Me.txt_confirmarSenha_atletica.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txt_confirmarSenha_atletica.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_confirmarSenha_atletica.DefaultText = ""
        Me.txt_confirmarSenha_atletica.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_confirmarSenha_atletica.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_confirmarSenha_atletica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_confirmarSenha_atletica.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_confirmarSenha_atletica.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_confirmarSenha_atletica.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_confirmarSenha_atletica.ForeColor = System.Drawing.Color.Black
        Me.txt_confirmarSenha_atletica.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_confirmarSenha_atletica.IconLeft = Global.Projeto_InterV2.My.Resources.Resources.icons8_password_30
        Me.txt_confirmarSenha_atletica.Location = New System.Drawing.Point(533, 190)
        Me.txt_confirmarSenha_atletica.Name = "txt_confirmarSenha_atletica"
        Me.txt_confirmarSenha_atletica.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_confirmarSenha_atletica.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_confirmarSenha_atletica.PlaceholderText = "Confirmar Senha"
        Me.txt_confirmarSenha_atletica.SelectedText = ""
        Me.txt_confirmarSenha_atletica.Size = New System.Drawing.Size(269, 32)
        Me.txt_confirmarSenha_atletica.TabIndex = 4
        '
        'txt_senha_atletica
        '
        Me.txt_senha_atletica.Animated = True
        Me.txt_senha_atletica.BorderColor = System.Drawing.Color.Black
        Me.txt_senha_atletica.BorderRadius = 8
        Me.txt_senha_atletica.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txt_senha_atletica.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha_atletica.DefaultText = ""
        Me.txt_senha_atletica.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_senha_atletica.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_senha_atletica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_senha_atletica.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_senha_atletica.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_senha_atletica.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_senha_atletica.ForeColor = System.Drawing.Color.Black
        Me.txt_senha_atletica.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_senha_atletica.IconLeft = Global.Projeto_InterV2.My.Resources.Resources.icons8_password_30
        Me.txt_senha_atletica.Location = New System.Drawing.Point(533, 152)
        Me.txt_senha_atletica.Name = "txt_senha_atletica"
        Me.txt_senha_atletica.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha_atletica.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_senha_atletica.PlaceholderText = "Senha"
        Me.txt_senha_atletica.SelectedText = ""
        Me.txt_senha_atletica.Size = New System.Drawing.Size(269, 32)
        Me.txt_senha_atletica.TabIndex = 3
        '
        'txt_email_atletica
        '
        Me.txt_email_atletica.Animated = True
        Me.txt_email_atletica.BorderColor = System.Drawing.Color.Black
        Me.txt_email_atletica.BorderRadius = 8
        Me.txt_email_atletica.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txt_email_atletica.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email_atletica.DefaultText = ""
        Me.txt_email_atletica.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_email_atletica.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_email_atletica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email_atletica.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email_atletica.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email_atletica.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_email_atletica.ForeColor = System.Drawing.Color.Black
        Me.txt_email_atletica.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email_atletica.IconLeft = Global.Projeto_InterV2.My.Resources.Resources.icons8_email_30
        Me.txt_email_atletica.Location = New System.Drawing.Point(533, 114)
        Me.txt_email_atletica.Name = "txt_email_atletica"
        Me.txt_email_atletica.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email_atletica.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_email_atletica.PlaceholderText = "E-mail"
        Me.txt_email_atletica.SelectedText = ""
        Me.txt_email_atletica.Size = New System.Drawing.Size(269, 32)
        Me.txt_email_atletica.TabIndex = 2
        '
        'txt_nome_atletica
        '
        Me.txt_nome_atletica.Animated = True
        Me.txt_nome_atletica.BorderColor = System.Drawing.Color.Black
        Me.txt_nome_atletica.BorderRadius = 8
        Me.txt_nome_atletica.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txt_nome_atletica.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome_atletica.DefaultText = ""
        Me.txt_nome_atletica.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_nome_atletica.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_nome_atletica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nome_atletica.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nome_atletica.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nome_atletica.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nome_atletica.ForeColor = System.Drawing.Color.Black
        Me.txt_nome_atletica.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nome_atletica.IconLeft = Global.Projeto_InterV2.My.Resources.Resources.icons8_name_30
        Me.txt_nome_atletica.Location = New System.Drawing.Point(533, 76)
        Me.txt_nome_atletica.Name = "txt_nome_atletica"
        Me.txt_nome_atletica.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nome_atletica.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_nome_atletica.PlaceholderText = "Nome Atletica"
        Me.txt_nome_atletica.SelectedText = ""
        Me.txt_nome_atletica.Size = New System.Drawing.Size(269, 32)
        Me.txt_nome_atletica.TabIndex = 1
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
        'cb_visualizar_atletica
        '
        Me.cb_visualizar_atletica.AutoSize = True
        Me.cb_visualizar_atletica.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cb_visualizar_atletica.CheckedState.BorderRadius = 0
        Me.cb_visualizar_atletica.CheckedState.BorderThickness = 0
        Me.cb_visualizar_atletica.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cb_visualizar_atletica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cb_visualizar_atletica.Location = New System.Drawing.Point(542, 228)
        Me.cb_visualizar_atletica.Name = "cb_visualizar_atletica"
        Me.cb_visualizar_atletica.Size = New System.Drawing.Size(70, 17)
        Me.cb_visualizar_atletica.TabIndex = 10
        Me.cb_visualizar_atletica.Text = "Visualizar"
        Me.cb_visualizar_atletica.UncheckedState.BorderColor = System.Drawing.Color.Silver
        Me.cb_visualizar_atletica.UncheckedState.BorderRadius = 0
        Me.cb_visualizar_atletica.UncheckedState.BorderThickness = 0
        Me.cb_visualizar_atletica.UncheckedState.FillColor = System.Drawing.Color.Silver
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'cmb_instituicao
        '
        Me.cmb_instituicao.BackColor = System.Drawing.Color.Transparent
        Me.cmb_instituicao.BorderColor = System.Drawing.Color.Black
        Me.cmb_instituicao.BorderRadius = 8
        Me.cmb_instituicao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_instituicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_instituicao.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_instituicao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_instituicao.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_instituicao.ForeColor = System.Drawing.Color.Black
        Me.cmb_instituicao.ItemHeight = 30
        Me.cmb_instituicao.Items.AddRange(New Object() {"FATEC-SCS", "USP", "UFABC"})
        Me.cmb_instituicao.Location = New System.Drawing.Point(533, 251)
        Me.cmb_instituicao.Name = "cmb_instituicao"
        Me.cmb_instituicao.Size = New System.Drawing.Size(269, 36)
        Me.cmb_instituicao.TabIndex = 11
        '
        'frm_cadastrarAtletica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(883, 429)
        Me.Controls.Add(Me.cmb_instituicao)
        Me.Controls.Add(Me.cb_visualizar_atletica)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.btn_loginAtletica)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cadastrar_atletica)
        Me.Controls.Add(Me.txt_confirmarSenha_atletica)
        Me.Controls.Add(Me.txt_senha_atletica)
        Me.Controls.Add(Me.txt_email_atletica)
        Me.Controls.Add(Me.txt_nome_atletica)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cadastrarAtletica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cadastroAtletica"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txt_nome_atletica As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_email_atletica As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_senha_atletica As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_confirmarSenha_atletica As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_cadastrar_atletica As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents btn_loginAtletica As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents cb_visualizar_atletica As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents cmb_instituicao As Guna.UI2.WinForms.Guna2ComboBox
End Class
