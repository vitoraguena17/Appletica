<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pagAluno
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_eventosAlunos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.nome_evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.local_evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao_evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_treinosAlunos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.nome_treino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_treino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.local_treino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao_treino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2DataGridViewStyler4 = New Guna.UI2.WinForms.Guna2DataGridViewStyler(Me.components)
        Me.btn_sairAluno = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        CType(Me.dgv_eventosAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_treinosAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(842, 12)
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
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(807, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(29, 25)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(326, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ÁREA DO ALUNO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgv_eventosAlunos
        '
        Me.dgv_eventosAlunos.AllowUserToAddRows = False
        Me.dgv_eventosAlunos.AllowUserToDeleteRows = False
        Me.dgv_eventosAlunos.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_eventosAlunos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_eventosAlunos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgv_eventosAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_eventosAlunos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_eventosAlunos.ColumnHeadersHeight = 15
        Me.dgv_eventosAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_eventosAlunos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nome_evento, Me.data_evento, Me.local_evento, Me.descricao_evento})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(232, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_eventosAlunos.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_eventosAlunos.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.dgv_eventosAlunos.Location = New System.Drawing.Point(112, 62)
        Me.dgv_eventosAlunos.Name = "dgv_eventosAlunos"
        Me.dgv_eventosAlunos.ReadOnly = True
        Me.dgv_eventosAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(232, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(232, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_eventosAlunos.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_eventosAlunos.RowHeadersVisible = False
        Me.dgv_eventosAlunos.Size = New System.Drawing.Size(655, 143)
        Me.dgv_eventosAlunos.TabIndex = 4
        Me.dgv_eventosAlunos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo
        Me.dgv_eventosAlunos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_eventosAlunos.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_eventosAlunos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgv_eventosAlunos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_eventosAlunos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_eventosAlunos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgv_eventosAlunos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.dgv_eventosAlunos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.dgv_eventosAlunos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_eventosAlunos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_eventosAlunos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_eventosAlunos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_eventosAlunos.ThemeStyle.HeaderStyle.Height = 15
        Me.dgv_eventosAlunos.ThemeStyle.ReadOnly = True
        Me.dgv_eventosAlunos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgv_eventosAlunos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_eventosAlunos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_eventosAlunos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_eventosAlunos.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_eventosAlunos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_eventosAlunos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'nome_evento
        '
        Me.nome_evento.HeaderText = "Nome do Evento"
        Me.nome_evento.Name = "nome_evento"
        Me.nome_evento.ReadOnly = True
        '
        'data_evento
        '
        Me.data_evento.HeaderText = "Data do Evento"
        Me.data_evento.Name = "data_evento"
        Me.data_evento.ReadOnly = True
        '
        'local_evento
        '
        Me.local_evento.HeaderText = "Local do Evento"
        Me.local_evento.Name = "local_evento"
        Me.local_evento.ReadOnly = True
        '
        'descricao_evento
        '
        Me.descricao_evento.HeaderText = "Descrição do Evento"
        Me.descricao_evento.Name = "descricao_evento"
        Me.descricao_evento.ReadOnly = True
        '
        'dgv_treinosAlunos
        '
        Me.dgv_treinosAlunos.AllowUserToAddRows = False
        Me.dgv_treinosAlunos.AllowUserToDeleteRows = False
        Me.dgv_treinosAlunos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_treinosAlunos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_treinosAlunos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgv_treinosAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_treinosAlunos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_treinosAlunos.ColumnHeadersHeight = 15
        Me.dgv_treinosAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_treinosAlunos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nome_treino, Me.data_treino, Me.local_treino, Me.descricao_treino})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(232, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_treinosAlunos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_treinosAlunos.GridColor = System.Drawing.Color.White
        Me.dgv_treinosAlunos.Location = New System.Drawing.Point(112, 231)
        Me.dgv_treinosAlunos.Name = "dgv_treinosAlunos"
        Me.dgv_treinosAlunos.ReadOnly = True
        Me.dgv_treinosAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(232, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(232, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_treinosAlunos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_treinosAlunos.RowHeadersVisible = False
        Me.dgv_treinosAlunos.Size = New System.Drawing.Size(655, 152)
        Me.dgv_treinosAlunos.TabIndex = 5
        Me.dgv_treinosAlunos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo
        Me.dgv_treinosAlunos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_treinosAlunos.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_treinosAlunos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgv_treinosAlunos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_treinosAlunos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_treinosAlunos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgv_treinosAlunos.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgv_treinosAlunos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.dgv_treinosAlunos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_treinosAlunos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_treinosAlunos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_treinosAlunos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_treinosAlunos.ThemeStyle.HeaderStyle.Height = 15
        Me.dgv_treinosAlunos.ThemeStyle.ReadOnly = True
        Me.dgv_treinosAlunos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgv_treinosAlunos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_treinosAlunos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_treinosAlunos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_treinosAlunos.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_treinosAlunos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_treinosAlunos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'nome_treino
        '
        Me.nome_treino.HeaderText = "Nome do Treino"
        Me.nome_treino.Name = "nome_treino"
        Me.nome_treino.ReadOnly = True
        '
        'data_treino
        '
        Me.data_treino.HeaderText = "Data do Treino"
        Me.data_treino.Name = "data_treino"
        Me.data_treino.ReadOnly = True
        '
        'local_treino
        '
        Me.local_treino.HeaderText = "Local do Treino"
        Me.local_treino.Name = "local_treino"
        Me.local_treino.ReadOnly = True
        '
        'descricao_treino
        '
        Me.descricao_treino.HeaderText = "Descrição do Treino"
        Me.descricao_treino.Name = "descricao_treino"
        Me.descricao_treino.ReadOnly = True
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
        Me.btn_sairAluno.Location = New System.Drawing.Point(778, 375)
        Me.btn_sairAluno.Name = "btn_sairAluno"
        Me.btn_sairAluno.Size = New System.Drawing.Size(93, 33)
        Me.btn_sairAluno.TabIndex = 6
        Me.btn_sairAluno.Text = "SAIR"
        Me.btn_sairAluno.UseTransparentBackground = True
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = Global.Projeto_InterV2.My.Resources.Resources.Logo_Apptletica
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(-37, 0)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(179, 105)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 2
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'frm_pagAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(883, 429)
        Me.Controls.Add(Me.btn_sairAluno)
        Me.Controls.Add(Me.dgv_treinosAlunos)
        Me.Controls.Add(Me.dgv_eventosAlunos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_pagAluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_pagAluno"
        CType(Me.dgv_eventosAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_treinosAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_treinosAlunos As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgv_eventosAlunos As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2DataGridViewStyler1 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents Guna2DataGridViewStyler2 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents btn_sairAluno As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents nome_evento As DataGridViewTextBoxColumn
    Friend WithEvents data_evento As DataGridViewTextBoxColumn
    Friend WithEvents local_evento As DataGridViewTextBoxColumn
    Friend WithEvents descricao_evento As DataGridViewTextBoxColumn
    Friend WithEvents nome_treino As DataGridViewTextBoxColumn
    Friend WithEvents data_treino As DataGridViewTextBoxColumn
    Friend WithEvents local_treino As DataGridViewTextBoxColumn
    Friend WithEvents descricao_treino As DataGridViewTextBoxColumn
    Friend WithEvents Guna2DataGridViewStyler3 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents Guna2DataGridViewStyler4 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents Guna2DataGridViewStyler5 As Guna.UI2.WinForms.Guna2DataGridViewStyler
End Class
