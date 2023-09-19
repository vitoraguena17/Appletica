<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_organizarEvento
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
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2AnimateWindow2 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.btn_sairAluno = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_nomeEvento = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtp_dataEvento = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_criarEvento = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_descricaoEvento = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_localEvento = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
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
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(533, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(29, 25)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Projeto_InterV2.My.Resources.Resources.Logo_Apptletica
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-33, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(169, 102)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 7
        Me.Guna2PictureBox1.TabStop = False
        '
        'btn_sairAluno
        '
        Me.btn_sairAluno.Animated = True
        Me.btn_sairAluno.BackColor = System.Drawing.Color.Transparent
        Me.btn_sairAluno.BorderColor = System.Drawing.Color.Transparent
        Me.btn_sairAluno.BorderRadius = 8
        Me.btn_sairAluno.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_sairAluno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_sairAluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_sairAluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_sairAluno.FillColor = System.Drawing.Color.Transparent
        Me.btn_sairAluno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_sairAluno.ForeColor = System.Drawing.Color.Black
        Me.btn_sairAluno.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_exit_black_50
        Me.btn_sairAluno.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btn_sairAluno.Location = New System.Drawing.Point(504, 333)
        Me.btn_sairAluno.Name = "btn_sairAluno"
        Me.btn_sairAluno.Size = New System.Drawing.Size(93, 33)
        Me.btn_sairAluno.TabIndex = 11
        Me.btn_sairAluno.Text = "SAIR"
        Me.btn_sairAluno.UseTransparentBackground = True
        '
        'txt_nomeEvento
        '
        Me.txt_nomeEvento.Animated = True
        Me.txt_nomeEvento.BorderColor = System.Drawing.Color.Black
        Me.txt_nomeEvento.BorderRadius = 8
        Me.txt_nomeEvento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nomeEvento.DefaultText = ""
        Me.txt_nomeEvento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_nomeEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_nomeEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nomeEvento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_nomeEvento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nomeEvento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_nomeEvento.ForeColor = System.Drawing.Color.Black
        Me.txt_nomeEvento.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_nomeEvento.Location = New System.Drawing.Point(188, 90)
        Me.txt_nomeEvento.Name = "txt_nomeEvento"
        Me.txt_nomeEvento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_nomeEvento.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_nomeEvento.PlaceholderText = "Nome"
        Me.txt_nomeEvento.SelectedText = ""
        Me.txt_nomeEvento.Size = New System.Drawing.Size(230, 32)
        Me.txt_nomeEvento.TabIndex = 17
        '
        'dtp_dataEvento
        '
        Me.dtp_dataEvento.Animated = True
        Me.dtp_dataEvento.BorderRadius = 8
        Me.dtp_dataEvento.Checked = True
        Me.dtp_dataEvento.FillColor = System.Drawing.Color.White
        Me.dtp_dataEvento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtp_dataEvento.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtp_dataEvento.Location = New System.Drawing.Point(189, 135)
        Me.dtp_dataEvento.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_dataEvento.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_dataEvento.Name = "dtp_dataEvento"
        Me.dtp_dataEvento.Size = New System.Drawing.Size(230, 40)
        Me.dtp_dataEvento.TabIndex = 16
        Me.dtp_dataEvento.Value = New Date(2023, 5, 30, 14, 30, 6, 90)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 28)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "CRIAR EVENTO"
        '
        'btn_criarEvento
        '
        Me.btn_criarEvento.Animated = True
        Me.btn_criarEvento.AutoRoundedCorners = True
        Me.btn_criarEvento.BorderRadius = 19
        Me.btn_criarEvento.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_criarEvento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_criarEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_criarEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_criarEvento.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_criarEvento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_criarEvento.ForeColor = System.Drawing.Color.White
        Me.btn_criarEvento.Location = New System.Drawing.Point(189, 280)
        Me.btn_criarEvento.Name = "btn_criarEvento"
        Me.btn_criarEvento.Size = New System.Drawing.Size(228, 41)
        Me.btn_criarEvento.TabIndex = 14
        Me.btn_criarEvento.Text = "CRIAR EVENTO"
        '
        'txt_descricaoEvento
        '
        Me.txt_descricaoEvento.Animated = True
        Me.txt_descricaoEvento.BorderColor = System.Drawing.Color.Black
        Me.txt_descricaoEvento.BorderRadius = 8
        Me.txt_descricaoEvento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_descricaoEvento.DefaultText = ""
        Me.txt_descricaoEvento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_descricaoEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_descricaoEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_descricaoEvento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_descricaoEvento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_descricaoEvento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_descricaoEvento.ForeColor = System.Drawing.Color.Black
        Me.txt_descricaoEvento.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_descricaoEvento.Location = New System.Drawing.Point(189, 237)
        Me.txt_descricaoEvento.Name = "txt_descricaoEvento"
        Me.txt_descricaoEvento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_descricaoEvento.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_descricaoEvento.PlaceholderText = "Descrição"
        Me.txt_descricaoEvento.SelectedText = ""
        Me.txt_descricaoEvento.Size = New System.Drawing.Size(230, 32)
        Me.txt_descricaoEvento.TabIndex = 13
        '
        'txt_localEvento
        '
        Me.txt_localEvento.Animated = True
        Me.txt_localEvento.BorderColor = System.Drawing.Color.Black
        Me.txt_localEvento.BorderRadius = 8
        Me.txt_localEvento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_localEvento.DefaultText = ""
        Me.txt_localEvento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_localEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_localEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_localEvento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_localEvento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_localEvento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_localEvento.ForeColor = System.Drawing.Color.Black
        Me.txt_localEvento.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_localEvento.Location = New System.Drawing.Point(189, 190)
        Me.txt_localEvento.Name = "txt_localEvento"
        Me.txt_localEvento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_localEvento.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txt_localEvento.PlaceholderText = "Local"
        Me.txt_localEvento.SelectedText = ""
        Me.txt_localEvento.Size = New System.Drawing.Size(230, 32)
        Me.txt_localEvento.TabIndex = 12
        '
        'frm_organizarEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(609, 378)
        Me.Controls.Add(Me.txt_nomeEvento)
        Me.Controls.Add(Me.dtp_dataEvento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_criarEvento)
        Me.Controls.Add(Me.txt_descricaoEvento)
        Me.Controls.Add(Me.txt_localEvento)
        Me.Controls.Add(Me.btn_sairAluno)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_organizarEvento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_organizarEvento"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2AnimateWindow2 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents btn_sairAluno As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_nomeEvento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtp_dataEvento As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_criarEvento As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_descricaoEvento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_localEvento As Guna.UI2.WinForms.Guna2TextBox
End Class
