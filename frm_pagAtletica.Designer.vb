<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_pagAtletica
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pagAtletica))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.pn_gestao = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_organizarTreino = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_reuniao = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_sairGestao = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_vendas = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_financeiro = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_organizarEvento = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.btn_show = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.btn_hide = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btn_pnTreinos = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_pnReunioes = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_pnEventos = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pn_gestao.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(842, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(29, 25)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(807, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(29, 25)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'pn_gestao
        '
        Me.pn_gestao.BackColor = System.Drawing.Color.LightGray
        Me.pn_gestao.BorderColor = System.Drawing.Color.Transparent
        Me.pn_gestao.Controls.Add(Me.btn_organizarTreino)
        Me.pn_gestao.Controls.Add(Me.btn_reuniao)
        Me.pn_gestao.Controls.Add(Me.btn_sairGestao)
        Me.pn_gestao.Controls.Add(Me.btn_vendas)
        Me.pn_gestao.Controls.Add(Me.btn_financeiro)
        Me.pn_gestao.Controls.Add(Me.btn_organizarEvento)
        Me.pn_gestao.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Transition1.SetDecoration(Me.pn_gestao, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pn_gestao.Dock = System.Windows.Forms.DockStyle.Left
        Me.pn_gestao.Location = New System.Drawing.Point(0, 0)
        Me.pn_gestao.Name = "pn_gestao"
        Me.pn_gestao.Size = New System.Drawing.Size(184, 429)
        Me.pn_gestao.TabIndex = 2
        '
        'btn_organizarTreino
        '
        Me.btn_organizarTreino.Animated = True
        Me.btn_organizarTreino.BorderColor = System.Drawing.Color.LightGray
        Me.btn_organizarTreino.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btn_organizarTreino, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_organizarTreino.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_organizarTreino.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_organizarTreino.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_organizarTreino.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_organizarTreino.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_organizarTreino.FillColor = System.Drawing.Color.Empty
        Me.btn_organizarTreino.FillColor2 = System.Drawing.Color.Empty
        Me.btn_organizarTreino.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_organizarTreino.ForeColor = System.Drawing.Color.White
        Me.btn_organizarTreino.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_organizarTreino.HoverState.FillColor2 = System.Drawing.Color.LightGray
        Me.btn_organizarTreino.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_organizarTreino.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_sport_48
        Me.btn_organizarTreino.Location = New System.Drawing.Point(-14, 184)
        Me.btn_organizarTreino.Name = "btn_organizarTreino"
        Me.btn_organizarTreino.Size = New System.Drawing.Size(198, 41)
        Me.btn_organizarTreino.TabIndex = 8
        Me.btn_organizarTreino.Text = "Organização de treinos"
        '
        'btn_reuniao
        '
        Me.btn_reuniao.Animated = True
        Me.btn_reuniao.BorderColor = System.Drawing.Color.LightGray
        Me.btn_reuniao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btn_reuniao, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_reuniao.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_reuniao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_reuniao.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_reuniao.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_reuniao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_reuniao.FillColor = System.Drawing.Color.Empty
        Me.btn_reuniao.FillColor2 = System.Drawing.Color.Empty
        Me.btn_reuniao.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_reuniao.ForeColor = System.Drawing.Color.White
        Me.btn_reuniao.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_reuniao.HoverState.FillColor2 = System.Drawing.Color.LightGray
        Me.btn_reuniao.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_reuniao.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_team_24
        Me.btn_reuniao.Location = New System.Drawing.Point(-4, 136)
        Me.btn_reuniao.Name = "btn_reuniao"
        Me.btn_reuniao.Size = New System.Drawing.Size(188, 41)
        Me.btn_reuniao.TabIndex = 7
        Me.btn_reuniao.Text = "Organização de reuniões"
        '
        'btn_sairGestao
        '
        Me.btn_sairGestao.Animated = True
        Me.btn_sairGestao.BorderColor = System.Drawing.Color.LightGray
        Me.btn_sairGestao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btn_sairGestao, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_sairGestao.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_sairGestao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_sairGestao.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_sairGestao.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_sairGestao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_sairGestao.FillColor = System.Drawing.Color.Empty
        Me.btn_sairGestao.FillColor2 = System.Drawing.Color.Empty
        Me.btn_sairGestao.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_sairGestao.ForeColor = System.Drawing.Color.White
        Me.btn_sairGestao.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_sairGestao.HoverState.FillColor2 = System.Drawing.Color.LightGray
        Me.btn_sairGestao.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_sairGestao.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_exit_50
        Me.btn_sairGestao.Location = New System.Drawing.Point(-9, 367)
        Me.btn_sairGestao.Name = "btn_sairGestao"
        Me.btn_sairGestao.Size = New System.Drawing.Size(78, 41)
        Me.btn_sairGestao.TabIndex = 6
        Me.btn_sairGestao.Text = "Sair"
        '
        'btn_vendas
        '
        Me.btn_vendas.Animated = True
        Me.btn_vendas.BorderColor = System.Drawing.Color.LightGray
        Me.btn_vendas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btn_vendas, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_vendas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_vendas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_vendas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_vendas.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_vendas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_vendas.FillColor = System.Drawing.Color.Empty
        Me.btn_vendas.FillColor2 = System.Drawing.Color.Empty
        Me.btn_vendas.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_vendas.ForeColor = System.Drawing.Color.White
        Me.btn_vendas.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_vendas.HoverState.FillColor2 = System.Drawing.Color.LightGray
        Me.btn_vendas.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_vendas.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_sales_30
        Me.btn_vendas.Location = New System.Drawing.Point(-100, 276)
        Me.btn_vendas.Name = "btn_vendas"
        Me.btn_vendas.Size = New System.Drawing.Size(284, 41)
        Me.btn_vendas.TabIndex = 4
        Me.btn_vendas.Text = "Vendas"
        '
        'btn_financeiro
        '
        Me.btn_financeiro.Animated = True
        Me.btn_financeiro.BorderColor = System.Drawing.Color.LightGray
        Me.btn_financeiro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btn_financeiro, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_financeiro.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_financeiro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_financeiro.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_financeiro.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_financeiro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_financeiro.FillColor = System.Drawing.Color.Empty
        Me.btn_financeiro.FillColor2 = System.Drawing.Color.Empty
        Me.btn_financeiro.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_financeiro.ForeColor = System.Drawing.Color.White
        Me.btn_financeiro.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_financeiro.HoverState.FillColor2 = System.Drawing.Color.LightGray
        Me.btn_financeiro.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_financeiro.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_financial_30
        Me.btn_financeiro.Location = New System.Drawing.Point(-87, 233)
        Me.btn_financeiro.Name = "btn_financeiro"
        Me.btn_financeiro.Size = New System.Drawing.Size(271, 41)
        Me.btn_financeiro.TabIndex = 3
        Me.btn_financeiro.Text = "Financeiro"
        '
        'btn_organizarEvento
        '
        Me.btn_organizarEvento.Animated = True
        Me.btn_organizarEvento.BorderColor = System.Drawing.Color.LightGray
        Me.btn_organizarEvento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btn_organizarEvento, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_organizarEvento.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_organizarEvento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_organizarEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_organizarEvento.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_organizarEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_organizarEvento.FillColor = System.Drawing.Color.Empty
        Me.btn_organizarEvento.FillColor2 = System.Drawing.Color.Empty
        Me.btn_organizarEvento.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_organizarEvento.ForeColor = System.Drawing.Color.White
        Me.btn_organizarEvento.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_organizarEvento.HoverState.FillColor2 = System.Drawing.Color.LightGray
        Me.btn_organizarEvento.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_organizarEvento.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_outline_30
        Me.btn_organizarEvento.Location = New System.Drawing.Point(-8, 89)
        Me.btn_organizarEvento.Name = "btn_organizarEvento"
        Me.btn_organizarEvento.Size = New System.Drawing.Size(192, 41)
        Me.btn_organizarEvento.TabIndex = 1
        Me.btn_organizarEvento.Text = "Organização de eventos"
        '
        'Guna2PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = Global.Projeto_InterV2.My.Resources.Resources.APPTLETICA_LOGO_NOME
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-6, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(196, 59)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'btn_show
        '
        Me.btn_show.Animated = True
        Me.btn_show.BackColor = System.Drawing.Color.Transparent
        Me.btn_show.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btn_show, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_show.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_show.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_show.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_show.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_show.FillColor = System.Drawing.Color.White
        Me.btn_show.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_show.ForeColor = System.Drawing.Color.White
        Me.btn_show.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_more_than_50
        Me.btn_show.ImageSize = New System.Drawing.Size(10, 10)
        Me.btn_show.Location = New System.Drawing.Point(19, 331)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_show.Size = New System.Drawing.Size(35, 34)
        Me.btn_show.TabIndex = 8
        Me.btn_show.UseTransparentBackground = True
        '
        'btn_hide
        '
        Me.btn_hide.Animated = True
        Me.btn_hide.BackColor = System.Drawing.Color.Transparent
        Me.btn_hide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btn_hide, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_hide.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_hide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_hide.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_hide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_hide.FillColor = System.Drawing.Color.White
        Me.btn_hide.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_hide.ForeColor = System.Drawing.Color.White
        Me.btn_hide.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_arrow_30
        Me.btn_hide.ImageSize = New System.Drawing.Size(10, 10)
        Me.btn_hide.Location = New System.Drawing.Point(166, 331)
        Me.btn_hide.Name = "btn_hide"
        Me.btn_hide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_hide.Size = New System.Drawing.Size(35, 34)
        Me.btn_hide.TabIndex = 7
        Me.btn_hide.UseTransparentBackground = True
        '
        'Guna2PictureBox2
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox2.Image = Global.Projeto_InterV2.My.Resources.Resources.Logo_Apptletica__1_
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(474, 59)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(362, 315)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 19
        Me.Guna2PictureBox2.TabStop = False
        '
        'btn_pnTreinos
        '
        Me.btn_pnTreinos.Animated = True
        Me.btn_pnTreinos.AutoRoundedCorners = True
        Me.btn_pnTreinos.BorderRadius = 22
        Me.Guna2Transition1.SetDecoration(Me.btn_pnTreinos, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_pnTreinos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_pnTreinos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_pnTreinos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_pnTreinos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_pnTreinos.FillColor = System.Drawing.Color.LightGray
        Me.btn_pnTreinos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_pnTreinos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_pnTreinos.Location = New System.Drawing.Point(229, 252)
        Me.btn_pnTreinos.Name = "btn_pnTreinos"
        Me.btn_pnTreinos.Size = New System.Drawing.Size(219, 46)
        Me.btn_pnTreinos.TabIndex = 18
        Me.btn_pnTreinos.Text = "GERENCIAR TREINOS"
        '
        'btn_pnReunioes
        '
        Me.btn_pnReunioes.Animated = True
        Me.btn_pnReunioes.AutoRoundedCorners = True
        Me.btn_pnReunioes.BorderRadius = 22
        Me.Guna2Transition1.SetDecoration(Me.btn_pnReunioes, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_pnReunioes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_pnReunioes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_pnReunioes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_pnReunioes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_pnReunioes.FillColor = System.Drawing.Color.LightGray
        Me.btn_pnReunioes.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_pnReunioes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_pnReunioes.Location = New System.Drawing.Point(229, 190)
        Me.btn_pnReunioes.Name = "btn_pnReunioes"
        Me.btn_pnReunioes.Size = New System.Drawing.Size(219, 46)
        Me.btn_pnReunioes.TabIndex = 17
        Me.btn_pnReunioes.Text = "GERENCIAR REUNIÕES"
        '
        'btn_pnEventos
        '
        Me.btn_pnEventos.Animated = True
        Me.btn_pnEventos.AutoRoundedCorners = True
        Me.btn_pnEventos.BorderRadius = 22
        Me.Guna2Transition1.SetDecoration(Me.btn_pnEventos, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_pnEventos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_pnEventos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_pnEventos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_pnEventos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_pnEventos.FillColor = System.Drawing.Color.LightGray
        Me.btn_pnEventos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_pnEventos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_pnEventos.Location = New System.Drawing.Point(229, 125)
        Me.btn_pnEventos.Name = "btn_pnEventos"
        Me.btn_pnEventos.Size = New System.Drawing.Size(219, 46)
        Me.btn_pnEventos.TabIndex = 16
        Me.btn_pnEventos.Text = "GERENCIAR EVENTOS"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 161.4213!
        Me.DataGridViewImageColumn1.HeaderText = "Editar Evento"
        Me.DataGridViewImageColumn1.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_config_50
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 172
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.FillWeight = 155.173!
        Me.DataGridViewImageColumn2.HeaderText = "Excluir Evento"
        Me.DataGridViewImageColumn2.Image = Global.Projeto_InterV2.My.Resources.Resources.icons8_delete_30
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 172
        '
        'frm_pagAtletica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(883, 429)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.btn_pnTreinos)
        Me.Controls.Add(Me.btn_pnReunioes)
        Me.Controls.Add(Me.btn_pnEventos)
        Me.Controls.Add(Me.btn_show)
        Me.Controls.Add(Me.btn_hide)
        Me.Controls.Add(Me.pn_gestao)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_pagAtletica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_pagAtletica"
        Me.pn_gestao.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents pn_gestao As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_organizarEvento As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_financeiro As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_vendas As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_sairGestao As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_hide As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents btn_show As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents btn_reuniao As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2DataGridViewStyler1 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents Guna2DataGridViewStyler2 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents btn_organizarTreino As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2DataGridViewStyler3 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents Guna2DataGridViewStyler4 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_pnTreinos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_pnReunioes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_pnEventos As Guna.UI2.WinForms.Guna2Button
End Class
