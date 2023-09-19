<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_organizarTreino
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
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nomeTreino = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_localTreino = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_descricaoTreino = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtp_dataTreino = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btn_sairTreino = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btn_criarTreino = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
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
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(568, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(29, 25)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(533, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(29, 25)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CRIAR TREINO"
        '
        'txt_nomeTreino
        '
        Me.txt_nomeTreino.Animated = True
        Me.txt_nomeTreino.BorderColor = System.Drawing.Color.Black
        Me.txt_nomeTreino.BorderRadius = 8
        Me.txt_nomeTreino.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nomeTreino.DefaultText = ""
        Me.txt_nomeTreino.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_nomeTreino.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_nomeTreino.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nomeTreino.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nomeTreino.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nomeTreino.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nomeTreino.ForeColor = System.Drawing.Color.Black
        Me.txt_nomeTreino.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nomeTreino.Location = New System.Drawing.Point(183, 90)
        Me.txt_nomeTreino.Name = "txt_nomeTreino"
        Me.txt_nomeTreino.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nomeTreino.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_nomeTreino.PlaceholderText = "Nome"
        Me.txt_nomeTreino.SelectedText = ""
        Me.txt_nomeTreino.Size = New System.Drawing.Size(230, 32)
        Me.txt_nomeTreino.TabIndex = 10
        '
        'txt_localTreino
        '
        Me.txt_localTreino.Animated = True
        Me.txt_localTreino.BorderColor = System.Drawing.Color.Black
        Me.txt_localTreino.BorderRadius = 8
        Me.txt_localTreino.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_localTreino.DefaultText = ""
        Me.txt_localTreino.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_localTreino.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_localTreino.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_localTreino.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_localTreino.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_localTreino.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_localTreino.ForeColor = System.Drawing.Color.Black
        Me.txt_localTreino.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_localTreino.Location = New System.Drawing.Point(183, 192)
        Me.txt_localTreino.Name = "txt_localTreino"
        Me.txt_localTreino.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_localTreino.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_localTreino.PlaceholderText = "Local"
        Me.txt_localTreino.SelectedText = ""
        Me.txt_localTreino.Size = New System.Drawing.Size(230, 32)
        Me.txt_localTreino.TabIndex = 11
        '
        'txt_descricaoTreino
        '
        Me.txt_descricaoTreino.Animated = True
        Me.txt_descricaoTreino.BorderColor = System.Drawing.Color.Black
        Me.txt_descricaoTreino.BorderRadius = 8
        Me.txt_descricaoTreino.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_descricaoTreino.DefaultText = ""
        Me.txt_descricaoTreino.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_descricaoTreino.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_descricaoTreino.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_descricaoTreino.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_descricaoTreino.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_descricaoTreino.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_descricaoTreino.ForeColor = System.Drawing.Color.Black
        Me.txt_descricaoTreino.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_descricaoTreino.Location = New System.Drawing.Point(183, 239)
        Me.txt_descricaoTreino.Name = "txt_descricaoTreino"
        Me.txt_descricaoTreino.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_descricaoTreino.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_descricaoTreino.PlaceholderText = "Descrição"
        Me.txt_descricaoTreino.SelectedText = ""
        Me.txt_descricaoTreino.Size = New System.Drawing.Size(230, 32)
        Me.txt_descricaoTreino.TabIndex = 12
        '
        'dtp_dataTreino
        '
        Me.dtp_dataTreino.Animated = True
        Me.dtp_dataTreino.BorderRadius = 8
        Me.dtp_dataTreino.Checked = True
        Me.dtp_dataTreino.FillColor = System.Drawing.Color.White
        Me.dtp_dataTreino.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtp_dataTreino.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtp_dataTreino.Location = New System.Drawing.Point(183, 137)
        Me.dtp_dataTreino.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_dataTreino.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_dataTreino.Name = "dtp_dataTreino"
        Me.dtp_dataTreino.Size = New System.Drawing.Size(230, 40)
        Me.dtp_dataTreino.TabIndex = 14
        Me.dtp_dataTreino.Value = New Date(2023, 5, 30, 14, 33, 41, 848)
        '
        'btn_sairTreino
        '
        Me.btn_sairTreino.Animated = True
        Me.btn_sairTreino.BackColor = System.Drawing.Color.Transparent
        Me.btn_sairTreino.BorderColor = System.Drawing.Color.Transparent
        Me.btn_sairTreino.BorderRadius = 8
        Me.btn_sairTreino.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_sairTreino.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_sairTreino.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_sairTreino.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_sairTreino.FillColor = System.Drawing.Color.Transparent
        Me.btn_sairTreino.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_sairTreino.ForeColor = System.Drawing.Color.Black
        Me.btn_sairTreino.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_exit_black_50
        Me.btn_sairTreino.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btn_sairTreino.Location = New System.Drawing.Point(504, 333)
        Me.btn_sairTreino.Name = "btn_sairTreino"
        Me.btn_sairTreino.Size = New System.Drawing.Size(93, 33)
        Me.btn_sairTreino.TabIndex = 15
        Me.btn_sairTreino.Text = "SAIR"
        Me.btn_sairTreino.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Projeto_InterV2.My.Resources.Resources.Logo_Apptletica
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-33, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(169, 102)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'btn_criarTreino
        '
        Me.btn_criarTreino.Animated = True
        Me.btn_criarTreino.AutoRoundedCorners = True
        Me.btn_criarTreino.BorderRadius = 19
        Me.btn_criarTreino.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_criarTreino.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_criarTreino.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_criarTreino.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_criarTreino.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_criarTreino.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_criarTreino.ForeColor = System.Drawing.Color.White
        Me.btn_criarTreino.Location = New System.Drawing.Point(5, 9)
        Me.btn_criarTreino.Name = "btn_criarTreino"
        Me.btn_criarTreino.Size = New System.Drawing.Size(228, 41)
        Me.btn_criarTreino.TabIndex = 13
        Me.btn_criarTreino.Text = "CRIAR TREINO"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btn_criarTreino)
        Me.Guna2Panel1.Location = New System.Drawing.Point(179, 284)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(244, 64)
        Me.Guna2Panel1.TabIndex = 16
        '
        'frm_organizarTreino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(609, 378)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btn_sairTreino)
        Me.Controls.Add(Me.dtp_dataTreino)
        Me.Controls.Add(Me.txt_descricaoTreino)
        Me.Controls.Add(Me.txt_localTreino)
        Me.Controls.Add(Me.txt_nomeTreino)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_organizarTreino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_organizarTreino"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents dtp_dataTreino As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txt_descricaoTreino As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_localTreino As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_nomeTreino As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_sairTreino As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_criarTreino As Guna.UI2.WinForms.Guna2Button
End Class
