<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.btn_AGV1 = New System.Windows.Forms.Button()
        Me.btn_AGV2 = New System.Windows.Forms.Button()
        Me.btn_AGV3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbDate = New System.Windows.Forms.Label()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.btn_AGV4 = New System.Windows.Forms.Button()
        Me.btn_LAM1 = New System.Windows.Forms.Button()
        Me.btn_1LAM1 = New System.Windows.Forms.Button()
        Me.btn1_AGV4 = New System.Windows.Forms.Button()
        Me.btn1_AGV3 = New System.Windows.Forms.Button()
        Me.btn1_AGV2 = New System.Windows.Forms.Button()
        Me.btn1_AGV1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_Lanp1 = New System.Windows.Forms.Label()
        Me.lb_Lanp2 = New System.Windows.Forms.Label()
        Me.lb_Lanp3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn2_AGV4 = New System.Windows.Forms.Button()
        Me.btn2_AGV3 = New System.Windows.Forms.Button()
        Me.btn2_AGV2 = New System.Windows.Forms.Button()
        Me.btn2_AGV1 = New System.Windows.Forms.Button()
        Me.btn_2LAM1 = New System.Windows.Forms.Button()
        Me.lb_Lanp4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn3_AGV4 = New System.Windows.Forms.Button()
        Me.btn3_AGV3 = New System.Windows.Forms.Button()
        Me.btn3_AGV2 = New System.Windows.Forms.Button()
        Me.btn3_AGV1 = New System.Windows.Forms.Button()
        Me.btn_3LAM1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DATE1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIME1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGV1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DETAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDisconnector = New System.Windows.Forms.Button()
        Me.btnconnector = New System.Windows.Forms.Button()
        Me.co = New System.Windows.Forms.Label()
        Me.combbaud = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.combport = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnP03 = New System.Windows.Forms.Button()
        Me.btnP01 = New System.Windows.Forms.Button()
        Me.btnEf11 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Btnselect = New System.Windows.Forms.Button()
        Me.txtFilepath = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_AGV1
        '
        Me.btn_AGV1.Location = New System.Drawing.Point(206, 20)
        Me.btn_AGV1.Name = "btn_AGV1"
        Me.btn_AGV1.Size = New System.Drawing.Size(55, 24)
        Me.btn_AGV1.TabIndex = 1
        Me.btn_AGV1.Text = "AGV1"
        Me.btn_AGV1.UseVisualStyleBackColor = True
        '
        'btn_AGV2
        '
        Me.btn_AGV2.Location = New System.Drawing.Point(206, 50)
        Me.btn_AGV2.Name = "btn_AGV2"
        Me.btn_AGV2.Size = New System.Drawing.Size(55, 24)
        Me.btn_AGV2.TabIndex = 2
        Me.btn_AGV2.Text = "AGV2"
        Me.btn_AGV2.UseVisualStyleBackColor = True
        '
        'btn_AGV3
        '
        Me.btn_AGV3.Location = New System.Drawing.Point(206, 80)
        Me.btn_AGV3.Name = "btn_AGV3"
        Me.btn_AGV3.Size = New System.Drawing.Size(55, 24)
        Me.btn_AGV3.TabIndex = 3
        Me.btn_AGV3.Text = "AGV3"
        Me.btn_AGV3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'lbDate
        '
        Me.lbDate.AutoSize = True
        Me.lbDate.Location = New System.Drawing.Point(439, 20)
        Me.lbDate.Name = "lbDate"
        Me.lbDate.Size = New System.Drawing.Size(36, 13)
        Me.lbDate.TabIndex = 4
        Me.lbDate.Text = "DATE"
        '
        'lbTime
        '
        Me.lbTime.AutoSize = True
        Me.lbTime.Location = New System.Drawing.Point(543, 20)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(33, 13)
        Me.lbTime.TabIndex = 5
        Me.lbTime.Text = "TIME"
        '
        'btn_AGV4
        '
        Me.btn_AGV4.Location = New System.Drawing.Point(206, 110)
        Me.btn_AGV4.Name = "btn_AGV4"
        Me.btn_AGV4.Size = New System.Drawing.Size(55, 24)
        Me.btn_AGV4.TabIndex = 6
        Me.btn_AGV4.Text = "AGV4"
        Me.btn_AGV4.UseVisualStyleBackColor = True
        '
        'btn_LAM1
        '
        Me.btn_LAM1.Location = New System.Drawing.Point(21, 21)
        Me.btn_LAM1.Name = "btn_LAM1"
        Me.btn_LAM1.Size = New System.Drawing.Size(40, 23)
        Me.btn_LAM1.TabIndex = 7
        Me.btn_LAM1.UseVisualStyleBackColor = True
        '
        'btn_1LAM1
        '
        Me.btn_1LAM1.Location = New System.Drawing.Point(21, 164)
        Me.btn_1LAM1.Name = "btn_1LAM1"
        Me.btn_1LAM1.Size = New System.Drawing.Size(40, 24)
        Me.btn_1LAM1.TabIndex = 11
        Me.btn_1LAM1.UseVisualStyleBackColor = True
        '
        'btn1_AGV4
        '
        Me.btn1_AGV4.Location = New System.Drawing.Point(206, 254)
        Me.btn1_AGV4.Name = "btn1_AGV4"
        Me.btn1_AGV4.Size = New System.Drawing.Size(57, 24)
        Me.btn1_AGV4.TabIndex = 18
        Me.btn1_AGV4.Text = "AGV4"
        Me.btn1_AGV4.UseVisualStyleBackColor = True
        '
        'btn1_AGV3
        '
        Me.btn1_AGV3.Location = New System.Drawing.Point(206, 224)
        Me.btn1_AGV3.Name = "btn1_AGV3"
        Me.btn1_AGV3.Size = New System.Drawing.Size(55, 24)
        Me.btn1_AGV3.TabIndex = 17
        Me.btn1_AGV3.Text = "AGV3"
        Me.btn1_AGV3.UseVisualStyleBackColor = True
        '
        'btn1_AGV2
        '
        Me.btn1_AGV2.Location = New System.Drawing.Point(206, 194)
        Me.btn1_AGV2.Name = "btn1_AGV2"
        Me.btn1_AGV2.Size = New System.Drawing.Size(55, 24)
        Me.btn1_AGV2.TabIndex = 16
        Me.btn1_AGV2.Text = "AGV2"
        Me.btn1_AGV2.UseVisualStyleBackColor = True
        '
        'btn1_AGV1
        '
        Me.btn1_AGV1.Location = New System.Drawing.Point(206, 163)
        Me.btn1_AGV1.Name = "btn1_AGV1"
        Me.btn1_AGV1.Size = New System.Drawing.Size(55, 25)
        Me.btn1_AGV1.TabIndex = 15
        Me.btn1_AGV1.Text = "AGV1"
        Me.btn1_AGV1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "1030"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "1019"
        '
        'lb_Lanp1
        '
        Me.lb_Lanp1.AutoSize = True
        Me.lb_Lanp1.Location = New System.Drawing.Point(86, 31)
        Me.lb_Lanp1.Name = "lb_Lanp1"
        Me.lb_Lanp1.Size = New System.Drawing.Size(39, 13)
        Me.lb_Lanp1.TabIndex = 21
        Me.lb_Lanp1.Text = "Label3"
        '
        'lb_Lanp2
        '
        Me.lb_Lanp2.AutoSize = True
        Me.lb_Lanp2.Location = New System.Drawing.Point(86, 175)
        Me.lb_Lanp2.Name = "lb_Lanp2"
        Me.lb_Lanp2.Size = New System.Drawing.Size(39, 13)
        Me.lb_Lanp2.TabIndex = 22
        Me.lb_Lanp2.Text = "Label3"
        '
        'lb_Lanp3
        '
        Me.lb_Lanp3.AutoSize = True
        Me.lb_Lanp3.Location = New System.Drawing.Point(84, 312)
        Me.lb_Lanp3.Name = "lb_Lanp3"
        Me.lb_Lanp3.Size = New System.Drawing.Size(39, 13)
        Me.lb_Lanp3.TabIndex = 32
        Me.lb_Lanp3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(164, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "1033"
        '
        'btn2_AGV4
        '
        Me.btn2_AGV4.Location = New System.Drawing.Point(204, 391)
        Me.btn2_AGV4.Name = "btn2_AGV4"
        Me.btn2_AGV4.Size = New System.Drawing.Size(57, 26)
        Me.btn2_AGV4.TabIndex = 30
        Me.btn2_AGV4.Text = "AGV4"
        Me.btn2_AGV4.UseVisualStyleBackColor = True
        '
        'btn2_AGV3
        '
        Me.btn2_AGV3.Location = New System.Drawing.Point(204, 361)
        Me.btn2_AGV3.Name = "btn2_AGV3"
        Me.btn2_AGV3.Size = New System.Drawing.Size(57, 24)
        Me.btn2_AGV3.TabIndex = 29
        Me.btn2_AGV3.Text = "AGV3"
        Me.btn2_AGV3.UseVisualStyleBackColor = True
        '
        'btn2_AGV2
        '
        Me.btn2_AGV2.Location = New System.Drawing.Point(204, 331)
        Me.btn2_AGV2.Name = "btn2_AGV2"
        Me.btn2_AGV2.Size = New System.Drawing.Size(57, 24)
        Me.btn2_AGV2.TabIndex = 28
        Me.btn2_AGV2.Text = "AGV2"
        Me.btn2_AGV2.UseVisualStyleBackColor = True
        '
        'btn2_AGV1
        '
        Me.btn2_AGV1.Location = New System.Drawing.Point(204, 300)
        Me.btn2_AGV1.Name = "btn2_AGV1"
        Me.btn2_AGV1.Size = New System.Drawing.Size(57, 25)
        Me.btn2_AGV1.TabIndex = 27
        Me.btn2_AGV1.Text = "AGV1"
        Me.btn2_AGV1.UseVisualStyleBackColor = True
        '
        'btn_2LAM1
        '
        Me.btn_2LAM1.Location = New System.Drawing.Point(19, 301)
        Me.btn_2LAM1.Name = "btn_2LAM1"
        Me.btn_2LAM1.Size = New System.Drawing.Size(40, 24)
        Me.btn_2LAM1.TabIndex = 23
        Me.btn_2LAM1.UseVisualStyleBackColor = True
        '
        'lb_Lanp4
        '
        Me.lb_Lanp4.AutoSize = True
        Me.lb_Lanp4.Location = New System.Drawing.Point(86, 452)
        Me.lb_Lanp4.Name = "lb_Lanp4"
        Me.lb_Lanp4.Size = New System.Drawing.Size(39, 13)
        Me.lb_Lanp4.TabIndex = 42
        Me.lb_Lanp4.Text = "Label3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(164, 503)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "1040"
        '
        'btn3_AGV4
        '
        Me.btn3_AGV4.Location = New System.Drawing.Point(206, 531)
        Me.btn3_AGV4.Name = "btn3_AGV4"
        Me.btn3_AGV4.Size = New System.Drawing.Size(57, 27)
        Me.btn3_AGV4.TabIndex = 40
        Me.btn3_AGV4.Text = "AGV4"
        Me.btn3_AGV4.UseVisualStyleBackColor = True
        '
        'btn3_AGV3
        '
        Me.btn3_AGV3.Location = New System.Drawing.Point(206, 503)
        Me.btn3_AGV3.Name = "btn3_AGV3"
        Me.btn3_AGV3.Size = New System.Drawing.Size(57, 22)
        Me.btn3_AGV3.TabIndex = 39
        Me.btn3_AGV3.Text = "AGV3"
        Me.btn3_AGV3.UseVisualStyleBackColor = True
        '
        'btn3_AGV2
        '
        Me.btn3_AGV2.Location = New System.Drawing.Point(206, 471)
        Me.btn3_AGV2.Name = "btn3_AGV2"
        Me.btn3_AGV2.Size = New System.Drawing.Size(57, 26)
        Me.btn3_AGV2.TabIndex = 38
        Me.btn3_AGV2.Text = "AGV2"
        Me.btn3_AGV2.UseVisualStyleBackColor = True
        '
        'btn3_AGV1
        '
        Me.btn3_AGV1.Location = New System.Drawing.Point(206, 440)
        Me.btn3_AGV1.Name = "btn3_AGV1"
        Me.btn3_AGV1.Size = New System.Drawing.Size(57, 25)
        Me.btn3_AGV1.TabIndex = 37
        Me.btn3_AGV1.Text = "AGV1"
        Me.btn3_AGV1.UseVisualStyleBackColor = True
        '
        'btn_3LAM1
        '
        Me.btn_3LAM1.Location = New System.Drawing.Point(21, 441)
        Me.btn_3LAM1.Name = "btn_3LAM1"
        Me.btn_3LAM1.Size = New System.Drawing.Size(40, 24)
        Me.btn_3LAM1.TabIndex = 33
        Me.btn_3LAM1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DATE1, Me.TIME1, Me.AGV1, Me.DETAIL})
        Me.DataGridView1.Location = New System.Drawing.Point(404, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(439, 622)
        Me.DataGridView1.TabIndex = 43
        '
        'DATE1
        '
        Me.DATE1.HeaderText = "DATE"
        Me.DATE1.Name = "DATE1"
        '
        'TIME1
        '
        Me.TIME1.HeaderText = "TIME"
        Me.TIME1.Name = "TIME1"
        '
        'AGV1
        '
        Me.AGV1.HeaderText = "AGV no"
        Me.AGV1.Name = "AGV1"
        '
        'DETAIL
        '
        Me.DETAIL.HeaderText = "DETAIL"
        Me.DETAIL.Name = "DETAIL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(267, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "AGV Tag IN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "AGV Tag RUN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "AGV Tag STOP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(276, 446)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "AGV Tag OUT"
        '
        'btnDisconnector
        '
        Me.btnDisconnector.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisconnector.Location = New System.Drawing.Point(1126, 78)
        Me.btnDisconnector.Name = "btnDisconnector"
        Me.btnDisconnector.Size = New System.Drawing.Size(136, 30)
        Me.btnDisconnector.TabIndex = 53
        Me.btnDisconnector.Text = "Disconnector"
        Me.btnDisconnector.UseVisualStyleBackColor = True
        '
        'btnconnector
        '
        Me.btnconnector.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconnector.Location = New System.Drawing.Point(1126, 26)
        Me.btnconnector.Name = "btnconnector"
        Me.btnconnector.Size = New System.Drawing.Size(136, 30)
        Me.btnconnector.TabIndex = 52
        Me.btnconnector.Text = "Connecter"
        Me.btnconnector.UseVisualStyleBackColor = True
        '
        'co
        '
        Me.co.AutoSize = True
        Me.co.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.co.Location = New System.Drawing.Point(921, 80)
        Me.co.Name = "co"
        Me.co.Size = New System.Drawing.Size(59, 20)
        Me.co.TabIndex = 51
        Me.co.Text = "BAUD"
        '
        'combbaud
        '
        Me.combbaud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combbaud.FormattingEnabled = True
        Me.combbaud.Location = New System.Drawing.Point(986, 77)
        Me.combbaud.Name = "combbaud"
        Me.combbaud.Size = New System.Drawing.Size(125, 28)
        Me.combbaud.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(894, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "COM Port"
        '
        'combport
        '
        Me.combport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combport.FormattingEnabled = True
        Me.combport.Location = New System.Drawing.Point(986, 28)
        Me.combport.Name = "combport"
        Me.combport.Size = New System.Drawing.Size(125, 28)
        Me.combport.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1122, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 20)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Data Recvice"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1069, 138)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(193, 64)
        Me.TextBox1.TabIndex = 54
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnP03
        '
        Me.btnP03.Location = New System.Drawing.Point(1078, 466)
        Me.btnP03.Name = "btnP03"
        Me.btnP03.Size = New System.Drawing.Size(97, 36)
        Me.btnP03.TabIndex = 57
        Me.btnP03.Text = "A01/P03/P05"
        Me.btnP03.UseVisualStyleBackColor = True
        '
        'btnP01
        '
        Me.btnP01.Location = New System.Drawing.Point(1078, 398)
        Me.btnP01.Name = "btnP01"
        Me.btnP01.Size = New System.Drawing.Size(97, 36)
        Me.btnP01.TabIndex = 58
        Me.btnP01.Text = "A01/P01"
        Me.btnP01.UseVisualStyleBackColor = True
        '
        'btnEf11
        '
        Me.btnEf11.Location = New System.Drawing.Point(1078, 329)
        Me.btnEf11.Name = "btnEf11"
        Me.btnEf11.Size = New System.Drawing.Size(97, 36)
        Me.btnEf11.TabIndex = 59
        Me.btnEf11.Text = "EF11"
        Me.btnEf11.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1039, 278)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(199, 24)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "รุ่นรถที่กำลังจัด picking"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox3.Controls.Add(Me.btnExport)
        Me.GroupBox3.Controls.Add(Me.Btnselect)
        Me.GroupBox3.Controls.Add(Me.txtFilepath)
        Me.GroupBox3.Location = New System.Drawing.Point(903, 544)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(335, 128)
        Me.GroupBox3.TabIndex = 335
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Export to Excel"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(193, 69)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(113, 29)
        Me.btnExport.TabIndex = 330
        Me.btnExport.Text = "Export to excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'Btnselect
        '
        Me.Btnselect.Location = New System.Drawing.Point(22, 69)
        Me.Btnselect.Name = "Btnselect"
        Me.Btnselect.Size = New System.Drawing.Size(147, 29)
        Me.Btnselect.TabIndex = 330
        Me.Btnselect.Text = "Select  your file path."
        Me.Btnselect.UseVisualStyleBackColor = True
        '
        'txtFilepath
        '
        Me.txtFilepath.Enabled = False
        Me.txtFilepath.Location = New System.Drawing.Point(22, 21)
        Me.txtFilepath.Name = "txtFilepath"
        Me.txtFilepath.Size = New System.Drawing.Size(284, 20)
        Me.txtFilepath.TabIndex = 329
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 717)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnP03)
        Me.Controls.Add(Me.btnP01)
        Me.Controls.Add(Me.btnEf11)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnDisconnector)
        Me.Controls.Add(Me.btnconnector)
        Me.Controls.Add(Me.co)
        Me.Controls.Add(Me.combbaud)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.combport)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lb_Lanp4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn3_AGV4)
        Me.Controls.Add(Me.btn3_AGV3)
        Me.Controls.Add(Me.btn3_AGV2)
        Me.Controls.Add(Me.btn3_AGV1)
        Me.Controls.Add(Me.btn_3LAM1)
        Me.Controls.Add(Me.lb_Lanp3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn2_AGV4)
        Me.Controls.Add(Me.btn2_AGV3)
        Me.Controls.Add(Me.btn2_AGV2)
        Me.Controls.Add(Me.btn2_AGV1)
        Me.Controls.Add(Me.btn_2LAM1)
        Me.Controls.Add(Me.lb_Lanp2)
        Me.Controls.Add(Me.lb_Lanp1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn1_AGV4)
        Me.Controls.Add(Me.btn1_AGV3)
        Me.Controls.Add(Me.btn1_AGV2)
        Me.Controls.Add(Me.btn1_AGV1)
        Me.Controls.Add(Me.btn_1LAM1)
        Me.Controls.Add(Me.btn_LAM1)
        Me.Controls.Add(Me.btn_AGV4)
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.lbDate)
        Me.Controls.Add(Me.btn_AGV3)
        Me.Controls.Add(Me.btn_AGV2)
        Me.Controls.Add(Me.btn_AGV1)
        Me.Name = "Form1"
        Me.Text = "DEMO_AGV_Monitor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_AGV1 As Button
    Friend WithEvents btn_AGV2 As Button
    Friend WithEvents btn_AGV3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbDate As Label
    Friend WithEvents lbTime As Label
    Friend WithEvents btn_AGV4 As Button
    Friend WithEvents btn_LAM1 As Button
    Friend WithEvents btn_1LAM1 As Button
    Friend WithEvents btn1_AGV4 As Button
    Friend WithEvents btn1_AGV3 As Button
    Friend WithEvents btn1_AGV2 As Button
    Friend WithEvents btn1_AGV1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_Lanp1 As Label
    Friend WithEvents lb_Lanp2 As Label
    Friend WithEvents lb_Lanp3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn2_AGV4 As Button
    Friend WithEvents btn2_AGV3 As Button
    Friend WithEvents btn2_AGV2 As Button
    Friend WithEvents btn2_AGV1 As Button
    Friend WithEvents btn_2LAM1 As Button
    Friend WithEvents lb_Lanp4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn3_AGV4 As Button
    Friend WithEvents btn3_AGV3 As Button
    Friend WithEvents btn3_AGV2 As Button
    Friend WithEvents btn3_AGV1 As Button
    Friend WithEvents btn_3LAM1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DATE1 As DataGridViewTextBoxColumn
    Friend WithEvents TIME1 As DataGridViewTextBoxColumn
    Friend WithEvents AGV1 As DataGridViewTextBoxColumn
    Friend WithEvents DETAIL As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDisconnector As Button
    Friend WithEvents btnconnector As Button
    Friend WithEvents co As Label
    Friend WithEvents combbaud As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents combport As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnP03 As Button
    Friend WithEvents btnP01 As Button
    Friend WithEvents btnEf11 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnExport As Button
    Friend WithEvents Btnselect As Button
    Friend WithEvents txtFilepath As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
