<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_organizarReuniao
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
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nomeReuniao = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_localReuniao = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_descricaoReuniao = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_criarReuniao = New Guna.UI2.WinForms.Guna2Button()
        Me.dtp_dataReuniao = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btn_sairReuniao = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.Projeto_InterV2.My.Resources.Resources.Logo_Apptletica
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(-33, 2)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(169, 102)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 2
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CRIAR REUNIÃO"
        '
        'txt_nomeReuniao
        '
        Me.txt_nomeReuniao.Animated = True
        Me.txt_nomeReuniao.BorderColor = System.Drawing.Color.Black
        Me.txt_nomeReuniao.BorderRadius = 8
        Me.txt_nomeReuniao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nomeReuniao.DefaultText = ""
        Me.txt_nomeReuniao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_nomeReuniao.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_nomeReuniao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nomeReuniao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nomeReuniao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nomeReuniao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nomeReuniao.ForeColor = System.Drawing.Color.Black
        Me.txt_nomeReuniao.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nomeReuniao.Location = New System.Drawing.Point(182, 88)
        Me.txt_nomeReuniao.Name = "txt_nomeReuniao"
        Me.txt_nomeReuniao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nomeReuniao.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_nomeReuniao.PlaceholderText = "Nome"
        Me.txt_nomeReuniao.SelectedText = ""
        Me.txt_nomeReuniao.Size = New System.Drawing.Size(230, 32)
        Me.txt_nomeReuniao.TabIndex = 4
        '
        'txt_localReuniao
        '
        Me.txt_localReuniao.Animated = True
        Me.txt_localReuniao.BorderColor = System.Drawing.Color.Black
        Me.txt_localReuniao.BorderRadius = 8
        Me.txt_localReuniao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_localReuniao.DefaultText = ""
        Me.txt_localReuniao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_localReuniao.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_localReuniao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_localReuniao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_localReuniao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_localReuniao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_localReuniao.ForeColor = System.Drawing.Color.Black
        Me.txt_localReuniao.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_localReuniao.Location = New System.Drawing.Point(181, 185)
        Me.txt_localReuniao.Name = "txt_localReuniao"
        Me.txt_localReuniao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_localReuniao.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_localReuniao.PlaceholderText = "Local"
        Me.txt_localReuniao.SelectedText = ""
        Me.txt_localReuniao.Size = New System.Drawing.Size(230, 32)
        Me.txt_localReuniao.TabIndex = 5
        '
        'txt_descricaoReuniao
        '
        Me.txt_descricaoReuniao.Animated = True
        Me.txt_descricaoReuniao.BorderColor = System.Drawing.Color.Black
        Me.txt_descricaoReuniao.BorderRadius = 8
        Me.txt_descricaoReuniao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_descricaoReuniao.DefaultText = ""
        Me.txt_descricaoReuniao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_descricaoReuniao.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_descricaoReuniao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_descricaoReuniao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_descricaoReuniao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_descricaoReuniao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_descricaoReuniao.ForeColor = System.Drawing.Color.Black
        Me.txt_descricaoReuniao.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_descricaoReuniao.Location = New System.Drawing.Point(181, 232)
        Me.txt_descricaoReuniao.Name = "txt_descricaoReuniao"
        Me.txt_descricaoReuniao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_descricaoReuniao.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_descricaoReuniao.PlaceholderText = "Descrição"
        Me.txt_descricaoReuniao.SelectedText = ""
        Me.txt_descricaoReuniao.Size = New System.Drawing.Size(230, 32)
        Me.txt_descricaoReuniao.TabIndex = 6
        '
        'btn_criarReuniao
        '
        Me.btn_criarReuniao.Animated = True
        Me.btn_criarReuniao.AutoRoundedCorners = True
        Me.btn_criarReuniao.BorderRadius = 19
        Me.btn_criarReuniao.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_criarReuniao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_criarReuniao.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_criarReuniao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_criarReuniao.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_criarReuniao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_criarReuniao.ForeColor = System.Drawing.Color.White
        Me.btn_criarReuniao.Location = New System.Drawing.Point(182, 286)
        Me.btn_criarReuniao.Name = "btn_criarReuniao"
        Me.btn_criarReuniao.Size = New System.Drawing.Size(228, 41)
        Me.btn_criarReuniao.TabIndex = 7
        Me.btn_criarReuniao.Text = "CRIAR REUNIÃO"
        '
        'dtp_dataReuniao
        '
        Me.dtp_dataReuniao.Animated = True
        Me.dtp_dataReuniao.BorderRadius = 8
        Me.dtp_dataReuniao.Checked = True
        Me.dtp_dataReuniao.FillColor = System.Drawing.Color.White
        Me.dtp_dataReuniao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtp_dataReuniao.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtp_dataReuniao.Location = New System.Drawing.Point(181, 130)
        Me.dtp_dataReuniao.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_dataReuniao.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_dataReuniao.Name = "dtp_dataReuniao"
        Me.dtp_dataReuniao.Size = New System.Drawing.Size(230, 40)
        Me.dtp_dataReuniao.TabIndex = 9
        Me.dtp_dataReuniao.Value = New Date(2023, 5, 30, 14, 33, 41, 848)
        '
        'btn_sairReuniao
        '
        Me.btn_sairReuniao.Animated = True
        Me.btn_sairReuniao.BackColor = System.Drawing.Color.Transparent
        Me.btn_sairReuniao.BorderColor = System.Drawing.Color.Transparent
        Me.btn_sairReuniao.BorderRadius = 8
        Me.btn_sairReuniao.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_sairReuniao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_sairReuniao.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_sairReuniao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_sairReuniao.FillColor = System.Drawing.Color.Transparent
        Me.btn_sairReuniao.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_sairReuniao.ForeColor = System.Drawing.Color.Black
        Me.btn_sairReuniao.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_exit_black_50
        Me.btn_sairReuniao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btn_sairReuniao.Location = New System.Drawing.Point(504, 333)
        Me.btn_sairReuniao.Name = "btn_sairReuniao"
        Me.btn_sairReuniao.Size = New System.Drawing.Size(93, 33)
        Me.btn_sairReuniao.TabIndex = 10
        Me.btn_sairReuniao.Text = "SAIR"
        Me.btn_sairReuniao.UseTransparentBackground = True
        '
        'frm_organizarReuniao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(609, 378)
        Me.Controls.Add(Me.btn_sairReuniao)
        Me.Controls.Add(Me.dtp_dataReuniao)
        Me.Controls.Add(Me.btn_criarReuniao)
        Me.Controls.Add(Me.txt_descricaoReuniao)
        Me.Controls.Add(Me.txt_localReuniao)
        Me.Controls.Add(Me.txt_nomeReuniao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_organizarReuniao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_organizarReuniao"
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents dtp_dataReuniao As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btn_criarReuniao As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_descricaoReuniao As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_localReuniao As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_nomeReuniao As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_sairReuniao As Guna.UI2.WinForms.Guna2Button
End Class
