<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.grbMenu = New System.Windows.Forms.GroupBox()
        Me.picTitle = New System.Windows.Forms.PictureBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.tabLogDelete = New System.Windows.Forms.TabControl()
        Me.tabHistory = New System.Windows.Forms.TabPage()
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.grbLog = New System.Windows.Forms.GroupBox()
        Me.txtLogPath = New System.Windows.Forms.TextBox()
        Me.tabConfiguration = New System.Windows.Forms.TabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grbSetTime = New System.Windows.Forms.GroupBox()
        Me.chkAutoRun = New System.Windows.Forms.CheckBox()
        Me.chkTime18 = New System.Windows.Forms.CheckBox()
        Me.chkTime23 = New System.Windows.Forms.CheckBox()
        Me.chkTime22 = New System.Windows.Forms.CheckBox()
        Me.chkTime21 = New System.Windows.Forms.CheckBox()
        Me.chkTime20 = New System.Windows.Forms.CheckBox()
        Me.chkTime19 = New System.Windows.Forms.CheckBox()
        Me.chkTime17 = New System.Windows.Forms.CheckBox()
        Me.chkTime16 = New System.Windows.Forms.CheckBox()
        Me.chkTime15 = New System.Windows.Forms.CheckBox()
        Me.chkTime24 = New System.Windows.Forms.CheckBox()
        Me.chkTime14 = New System.Windows.Forms.CheckBox()
        Me.chkTime13 = New System.Windows.Forms.CheckBox()
        Me.chkTime07 = New System.Windows.Forms.CheckBox()
        Me.chkTime12 = New System.Windows.Forms.CheckBox()
        Me.chkTime11 = New System.Windows.Forms.CheckBox()
        Me.chkTime10 = New System.Windows.Forms.CheckBox()
        Me.chkTime09 = New System.Windows.Forms.CheckBox()
        Me.chkTime08 = New System.Windows.Forms.CheckBox()
        Me.chkTime06 = New System.Windows.Forms.CheckBox()
        Me.chkTime05 = New System.Windows.Forms.CheckBox()
        Me.chkTime04 = New System.Windows.Forms.CheckBox()
        Me.chkTime03 = New System.Windows.Forms.CheckBox()
        Me.chkTime02 = New System.Windows.Forms.CheckBox()
        Me.chkTime01 = New System.Windows.Forms.CheckBox()
        Me.grbSetExt = New System.Windows.Forms.GroupBox()
        Me.chkPNG = New System.Windows.Forms.CheckBox()
        Me.chkMDB = New System.Windows.Forms.CheckBox()
        Me.chkBAK = New System.Windows.Forms.CheckBox()
        Me.chkTRN = New System.Windows.Forms.CheckBox()
        Me.chkJPG = New System.Windows.Forms.CheckBox()
        Me.chkZIP = New System.Windows.Forms.CheckBox()
        Me.chkINI = New System.Windows.Forms.CheckBox()
        Me.chkXLS = New System.Windows.Forms.CheckBox()
        Me.chkPDF = New System.Windows.Forms.CheckBox()
        Me.chkTXT = New System.Windows.Forms.CheckBox()
        Me.chkFLD = New System.Windows.Forms.CheckBox()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.grbSetDay = New System.Windows.Forms.GroupBox()
        Me.rdoExpire180 = New System.Windows.Forms.RadioButton()
        Me.rdoExpire90 = New System.Windows.Forms.RadioButton()
        Me.rdoExpire60 = New System.Windows.Forms.RadioButton()
        Me.rdoExpire30 = New System.Windows.Forms.RadioButton()
        Me.rdoExpire14 = New System.Windows.Forms.RadioButton()
        Me.rdoExpire7 = New System.Windows.Forms.RadioButton()
        Me.rdoExpire3 = New System.Windows.Forms.RadioButton()
        Me.rdoExpire1 = New System.Windows.Forms.RadioButton()
        Me.grbSetPath = New System.Windows.Forms.GroupBox()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grdLists = New System.Windows.Forms.DataGridView()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.grbMenu.SuspendLayout()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLogDelete.SuspendLayout()
        Me.tabHistory.SuspendLayout()
        Me.grbLog.SuspendLayout()
        Me.tabConfiguration.SuspendLayout()
        Me.grbSetTime.SuspendLayout()
        Me.grbSetExt.SuspendLayout()
        Me.grbSetDay.SuspendLayout()
        Me.grbSetPath.SuspendLayout()
        CType(Me.grdLists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbMenu
        '
        Me.grbMenu.Controls.Add(Me.picTitle)
        Me.grbMenu.Controls.Add(Me.btnStop)
        Me.grbMenu.Controls.Add(Me.btnStart)
        Me.grbMenu.Location = New System.Drawing.Point(-4, -4)
        Me.grbMenu.Name = "grbMenu"
        Me.grbMenu.Size = New System.Drawing.Size(830, 79)
        Me.grbMenu.TabIndex = 0
        Me.grbMenu.TabStop = False
        '
        'picTitle
        '
        Me.picTitle.Image = CType(resources.GetObject("picTitle.Image"), System.Drawing.Image)
        Me.picTitle.InitialImage = Nothing
        Me.picTitle.Location = New System.Drawing.Point(6, 10)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(573, 63)
        Me.picTitle.TabIndex = 26
        Me.picTitle.TabStop = False
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(712, 11)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(112, 62)
        Me.btnStop.TabIndex = 0
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(594, 11)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(112, 62)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'tabLogDelete
        '
        Me.tabLogDelete.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabLogDelete.Controls.Add(Me.tabHistory)
        Me.tabLogDelete.Controls.Add(Me.tabConfiguration)
        Me.tabLogDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tabLogDelete.Location = New System.Drawing.Point(5, 81)
        Me.tabLogDelete.Name = "tabLogDelete"
        Me.tabLogDelete.SelectedIndex = 0
        Me.tabLogDelete.Size = New System.Drawing.Size(827, 526)
        Me.tabLogDelete.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabLogDelete.TabIndex = 15
        '
        'tabHistory
        '
        Me.tabHistory.BackColor = System.Drawing.Color.AliceBlue
        Me.tabHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabHistory.Controls.Add(Me.lstHistory)
        Me.tabHistory.Controls.Add(Me.grbLog)
        Me.tabHistory.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabHistory.Location = New System.Drawing.Point(4, 25)
        Me.tabHistory.Name = "tabHistory"
        Me.tabHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHistory.Size = New System.Drawing.Size(819, 497)
        Me.tabHistory.TabIndex = 1
        Me.tabHistory.Text = "History"
        '
        'lstHistory
        '
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.HorizontalScrollbar = True
        Me.lstHistory.Location = New System.Drawing.Point(6, 61)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(785, 433)
        Me.lstHistory.TabIndex = 1
        '
        'grbLog
        '
        Me.grbLog.Controls.Add(Me.txtLogPath)
        Me.grbLog.Location = New System.Drawing.Point(6, 6)
        Me.grbLog.Name = "grbLog"
        Me.grbLog.Size = New System.Drawing.Size(785, 49)
        Me.grbLog.TabIndex = 0
        Me.grbLog.TabStop = False
        Me.grbLog.Text = "Processing Path"
        '
        'txtLogPath
        '
        Me.txtLogPath.Location = New System.Drawing.Point(6, 18)
        Me.txtLogPath.Name = "txtLogPath"
        Me.txtLogPath.Size = New System.Drawing.Size(773, 20)
        Me.txtLogPath.TabIndex = 0
        '
        'tabConfiguration
        '
        Me.tabConfiguration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabConfiguration.Controls.Add(Me.btnSave)
        Me.tabConfiguration.Controls.Add(Me.grbSetTime)
        Me.tabConfiguration.Controls.Add(Me.grbSetExt)
        Me.tabConfiguration.Controls.Add(Me.grbSetDay)
        Me.tabConfiguration.Controls.Add(Me.grbSetPath)
        Me.tabConfiguration.Controls.Add(Me.btnDelete)
        Me.tabConfiguration.Controls.Add(Me.btnAdd)
        Me.tabConfiguration.Controls.Add(Me.grdLists)
        Me.tabConfiguration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabConfiguration.Location = New System.Drawing.Point(4, 25)
        Me.tabConfiguration.Name = "tabConfiguration"
        Me.tabConfiguration.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConfiguration.Size = New System.Drawing.Size(819, 497)
        Me.tabConfiguration.TabIndex = 0
        Me.tabConfiguration.Text = "Configuration"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(600, 440)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(206, 37)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grbSetTime
        '
        Me.grbSetTime.Controls.Add(Me.chkAutoRun)
        Me.grbSetTime.Controls.Add(Me.chkTime18)
        Me.grbSetTime.Controls.Add(Me.chkTime23)
        Me.grbSetTime.Controls.Add(Me.chkTime22)
        Me.grbSetTime.Controls.Add(Me.chkTime21)
        Me.grbSetTime.Controls.Add(Me.chkTime20)
        Me.grbSetTime.Controls.Add(Me.chkTime19)
        Me.grbSetTime.Controls.Add(Me.chkTime17)
        Me.grbSetTime.Controls.Add(Me.chkTime16)
        Me.grbSetTime.Controls.Add(Me.chkTime15)
        Me.grbSetTime.Controls.Add(Me.chkTime24)
        Me.grbSetTime.Controls.Add(Me.chkTime14)
        Me.grbSetTime.Controls.Add(Me.chkTime13)
        Me.grbSetTime.Controls.Add(Me.chkTime07)
        Me.grbSetTime.Controls.Add(Me.chkTime12)
        Me.grbSetTime.Controls.Add(Me.chkTime11)
        Me.grbSetTime.Controls.Add(Me.chkTime10)
        Me.grbSetTime.Controls.Add(Me.chkTime09)
        Me.grbSetTime.Controls.Add(Me.chkTime08)
        Me.grbSetTime.Controls.Add(Me.chkTime06)
        Me.grbSetTime.Controls.Add(Me.chkTime05)
        Me.grbSetTime.Controls.Add(Me.chkTime04)
        Me.grbSetTime.Controls.Add(Me.chkTime03)
        Me.grbSetTime.Controls.Add(Me.chkTime02)
        Me.grbSetTime.Controls.Add(Me.chkTime01)
        Me.grbSetTime.Location = New System.Drawing.Point(260, 256)
        Me.grbSetTime.Name = "grbSetTime"
        Me.grbSetTime.Size = New System.Drawing.Size(546, 124)
        Me.grbSetTime.TabIndex = 21
        Me.grbSetTime.TabStop = False
        Me.grbSetTime.Text = "Running Time"
        '
        'chkAutoRun
        '
        Me.chkAutoRun.AutoSize = True
        Me.chkAutoRun.Location = New System.Drawing.Point(19, 98)
        Me.chkAutoRun.Name = "chkAutoRun"
        Me.chkAutoRun.Size = New System.Drawing.Size(73, 19)
        Me.chkAutoRun.TabIndex = 23
        Me.chkAutoRun.Text = "AutoRun"
        Me.chkAutoRun.UseVisualStyleBackColor = False
        '
        'chkTime18
        '
        Me.chkTime18.AutoSize = True
        Me.chkTime18.Location = New System.Drawing.Point(229, 66)
        Me.chkTime18.Name = "chkTime18"
        Me.chkTime18.Size = New System.Drawing.Size(40, 19)
        Me.chkTime18.TabIndex = 3
        Me.chkTime18.Text = "18"
        Me.chkTime18.UseVisualStyleBackColor = True
        '
        'chkTime23
        '
        Me.chkTime23.AutoSize = True
        Me.chkTime23.Location = New System.Drawing.Point(439, 66)
        Me.chkTime23.Name = "chkTime23"
        Me.chkTime23.Size = New System.Drawing.Size(40, 19)
        Me.chkTime23.TabIndex = 4
        Me.chkTime23.Text = "23"
        Me.chkTime23.UseVisualStyleBackColor = True
        '
        'chkTime22
        '
        Me.chkTime22.AutoSize = True
        Me.chkTime22.Location = New System.Drawing.Point(397, 66)
        Me.chkTime22.Name = "chkTime22"
        Me.chkTime22.Size = New System.Drawing.Size(40, 19)
        Me.chkTime22.TabIndex = 5
        Me.chkTime22.Text = "22"
        Me.chkTime22.UseVisualStyleBackColor = True
        '
        'chkTime21
        '
        Me.chkTime21.AutoSize = True
        Me.chkTime21.Location = New System.Drawing.Point(355, 66)
        Me.chkTime21.Name = "chkTime21"
        Me.chkTime21.Size = New System.Drawing.Size(40, 19)
        Me.chkTime21.TabIndex = 6
        Me.chkTime21.Text = "21"
        Me.chkTime21.UseVisualStyleBackColor = True
        '
        'chkTime20
        '
        Me.chkTime20.AutoSize = True
        Me.chkTime20.Location = New System.Drawing.Point(313, 66)
        Me.chkTime20.Name = "chkTime20"
        Me.chkTime20.Size = New System.Drawing.Size(40, 19)
        Me.chkTime20.TabIndex = 7
        Me.chkTime20.Text = "20"
        Me.chkTime20.UseVisualStyleBackColor = True
        '
        'chkTime19
        '
        Me.chkTime19.AutoSize = True
        Me.chkTime19.Location = New System.Drawing.Point(271, 66)
        Me.chkTime19.Name = "chkTime19"
        Me.chkTime19.Size = New System.Drawing.Size(40, 19)
        Me.chkTime19.TabIndex = 8
        Me.chkTime19.Text = "19"
        Me.chkTime19.UseVisualStyleBackColor = True
        '
        'chkTime17
        '
        Me.chkTime17.AutoSize = True
        Me.chkTime17.Location = New System.Drawing.Point(187, 66)
        Me.chkTime17.Name = "chkTime17"
        Me.chkTime17.Size = New System.Drawing.Size(40, 19)
        Me.chkTime17.TabIndex = 9
        Me.chkTime17.Text = "17"
        Me.chkTime17.UseVisualStyleBackColor = True
        '
        'chkTime16
        '
        Me.chkTime16.AutoSize = True
        Me.chkTime16.Location = New System.Drawing.Point(145, 66)
        Me.chkTime16.Name = "chkTime16"
        Me.chkTime16.Size = New System.Drawing.Size(40, 19)
        Me.chkTime16.TabIndex = 10
        Me.chkTime16.Text = "16"
        Me.chkTime16.UseVisualStyleBackColor = True
        '
        'chkTime15
        '
        Me.chkTime15.AutoSize = True
        Me.chkTime15.Location = New System.Drawing.Point(103, 66)
        Me.chkTime15.Name = "chkTime15"
        Me.chkTime15.Size = New System.Drawing.Size(40, 19)
        Me.chkTime15.TabIndex = 11
        Me.chkTime15.Text = "15"
        Me.chkTime15.UseVisualStyleBackColor = True
        '
        'chkTime24
        '
        Me.chkTime24.AutoSize = True
        Me.chkTime24.Location = New System.Drawing.Point(481, 66)
        Me.chkTime24.Name = "chkTime24"
        Me.chkTime24.Size = New System.Drawing.Size(40, 19)
        Me.chkTime24.TabIndex = 2
        Me.chkTime24.Text = "24"
        Me.chkTime24.UseVisualStyleBackColor = True
        '
        'chkTime14
        '
        Me.chkTime14.AutoSize = True
        Me.chkTime14.Location = New System.Drawing.Point(61, 66)
        Me.chkTime14.Name = "chkTime14"
        Me.chkTime14.Size = New System.Drawing.Size(40, 19)
        Me.chkTime14.TabIndex = 12
        Me.chkTime14.Text = "14"
        Me.chkTime14.UseVisualStyleBackColor = True
        '
        'chkTime13
        '
        Me.chkTime13.AutoSize = True
        Me.chkTime13.Location = New System.Drawing.Point(19, 66)
        Me.chkTime13.Name = "chkTime13"
        Me.chkTime13.Size = New System.Drawing.Size(40, 19)
        Me.chkTime13.TabIndex = 13
        Me.chkTime13.Text = "13"
        Me.chkTime13.UseVisualStyleBackColor = True
        '
        'chkTime07
        '
        Me.chkTime07.AutoSize = True
        Me.chkTime07.Location = New System.Drawing.Point(271, 34)
        Me.chkTime07.Name = "chkTime07"
        Me.chkTime07.Size = New System.Drawing.Size(33, 19)
        Me.chkTime07.TabIndex = 1
        Me.chkTime07.Text = "7"
        Me.chkTime07.UseVisualStyleBackColor = True
        '
        'chkTime12
        '
        Me.chkTime12.AutoSize = True
        Me.chkTime12.Location = New System.Drawing.Point(482, 34)
        Me.chkTime12.Name = "chkTime12"
        Me.chkTime12.Size = New System.Drawing.Size(40, 19)
        Me.chkTime12.TabIndex = 1
        Me.chkTime12.Text = "12"
        Me.chkTime12.UseVisualStyleBackColor = True
        '
        'chkTime11
        '
        Me.chkTime11.AutoSize = True
        Me.chkTime11.Location = New System.Drawing.Point(439, 34)
        Me.chkTime11.Name = "chkTime11"
        Me.chkTime11.Size = New System.Drawing.Size(40, 19)
        Me.chkTime11.TabIndex = 1
        Me.chkTime11.Text = "11"
        Me.chkTime11.UseVisualStyleBackColor = True
        '
        'chkTime10
        '
        Me.chkTime10.AutoSize = True
        Me.chkTime10.Location = New System.Drawing.Point(397, 34)
        Me.chkTime10.Name = "chkTime10"
        Me.chkTime10.Size = New System.Drawing.Size(40, 19)
        Me.chkTime10.TabIndex = 1
        Me.chkTime10.Text = "10"
        Me.chkTime10.UseVisualStyleBackColor = True
        '
        'chkTime09
        '
        Me.chkTime09.AutoSize = True
        Me.chkTime09.Location = New System.Drawing.Point(355, 34)
        Me.chkTime09.Name = "chkTime09"
        Me.chkTime09.Size = New System.Drawing.Size(33, 19)
        Me.chkTime09.TabIndex = 1
        Me.chkTime09.Text = "9"
        Me.chkTime09.UseVisualStyleBackColor = True
        '
        'chkTime08
        '
        Me.chkTime08.AutoSize = True
        Me.chkTime08.Location = New System.Drawing.Point(313, 34)
        Me.chkTime08.Name = "chkTime08"
        Me.chkTime08.Size = New System.Drawing.Size(33, 19)
        Me.chkTime08.TabIndex = 1
        Me.chkTime08.Text = "8"
        Me.chkTime08.UseVisualStyleBackColor = True
        '
        'chkTime06
        '
        Me.chkTime06.AutoSize = True
        Me.chkTime06.Location = New System.Drawing.Point(229, 34)
        Me.chkTime06.Name = "chkTime06"
        Me.chkTime06.Size = New System.Drawing.Size(33, 19)
        Me.chkTime06.TabIndex = 1
        Me.chkTime06.Text = "6"
        Me.chkTime06.UseVisualStyleBackColor = True
        '
        'chkTime05
        '
        Me.chkTime05.AutoSize = True
        Me.chkTime05.Location = New System.Drawing.Point(187, 34)
        Me.chkTime05.Name = "chkTime05"
        Me.chkTime05.Size = New System.Drawing.Size(33, 19)
        Me.chkTime05.TabIndex = 1
        Me.chkTime05.Text = "5"
        Me.chkTime05.UseVisualStyleBackColor = True
        '
        'chkTime04
        '
        Me.chkTime04.AutoSize = True
        Me.chkTime04.Location = New System.Drawing.Point(145, 34)
        Me.chkTime04.Name = "chkTime04"
        Me.chkTime04.Size = New System.Drawing.Size(33, 19)
        Me.chkTime04.TabIndex = 1
        Me.chkTime04.Text = "4"
        Me.chkTime04.UseVisualStyleBackColor = True
        '
        'chkTime03
        '
        Me.chkTime03.AutoSize = True
        Me.chkTime03.Location = New System.Drawing.Point(103, 34)
        Me.chkTime03.Name = "chkTime03"
        Me.chkTime03.Size = New System.Drawing.Size(33, 19)
        Me.chkTime03.TabIndex = 1
        Me.chkTime03.Text = "3"
        Me.chkTime03.UseVisualStyleBackColor = True
        '
        'chkTime02
        '
        Me.chkTime02.AutoSize = True
        Me.chkTime02.Location = New System.Drawing.Point(61, 34)
        Me.chkTime02.Name = "chkTime02"
        Me.chkTime02.Size = New System.Drawing.Size(33, 19)
        Me.chkTime02.TabIndex = 1
        Me.chkTime02.Text = "2"
        Me.chkTime02.UseVisualStyleBackColor = True
        '
        'chkTime01
        '
        Me.chkTime01.AutoSize = True
        Me.chkTime01.Location = New System.Drawing.Point(19, 34)
        Me.chkTime01.Name = "chkTime01"
        Me.chkTime01.Size = New System.Drawing.Size(33, 19)
        Me.chkTime01.TabIndex = 0
        Me.chkTime01.Text = "1"
        Me.chkTime01.UseVisualStyleBackColor = True
        '
        'grbSetExt
        '
        Me.grbSetExt.Controls.Add(Me.chkPNG)
        Me.grbSetExt.Controls.Add(Me.chkMDB)
        Me.grbSetExt.Controls.Add(Me.chkBAK)
        Me.grbSetExt.Controls.Add(Me.chkTRN)
        Me.grbSetExt.Controls.Add(Me.chkJPG)
        Me.grbSetExt.Controls.Add(Me.chkZIP)
        Me.grbSetExt.Controls.Add(Me.chkINI)
        Me.grbSetExt.Controls.Add(Me.chkXLS)
        Me.grbSetExt.Controls.Add(Me.chkPDF)
        Me.grbSetExt.Controls.Add(Me.chkTXT)
        Me.grbSetExt.Controls.Add(Me.chkFLD)
        Me.grbSetExt.Controls.Add(Me.chkAll)
        Me.grbSetExt.Location = New System.Drawing.Point(260, 137)
        Me.grbSetExt.Name = "grbSetExt"
        Me.grbSetExt.Size = New System.Drawing.Size(546, 103)
        Me.grbSetExt.TabIndex = 20
        Me.grbSetExt.TabStop = False
        Me.grbSetExt.Text = "File Extensions"
        '
        'chkPNG
        '
        Me.chkPNG.AutoSize = True
        Me.chkPNG.Location = New System.Drawing.Point(316, 69)
        Me.chkPNG.Name = "chkPNG"
        Me.chkPNG.Size = New System.Drawing.Size(52, 19)
        Me.chkPNG.TabIndex = 2
        Me.chkPNG.Text = "PNG"
        Me.chkPNG.UseVisualStyleBackColor = True
        '
        'chkMDB
        '
        Me.chkMDB.AutoSize = True
        Me.chkMDB.Location = New System.Drawing.Point(19, 69)
        Me.chkMDB.Name = "chkMDB"
        Me.chkMDB.Size = New System.Drawing.Size(54, 19)
        Me.chkMDB.TabIndex = 1
        Me.chkMDB.Text = "MDB"
        Me.chkMDB.UseVisualStyleBackColor = True
        '
        'chkBAK
        '
        Me.chkBAK.AutoSize = True
        Me.chkBAK.Location = New System.Drawing.Point(487, 69)
        Me.chkBAK.Name = "chkBAK"
        Me.chkBAK.Size = New System.Drawing.Size(49, 19)
        Me.chkBAK.TabIndex = 1
        Me.chkBAK.Text = "BAK"
        Me.chkBAK.UseVisualStyleBackColor = True
        '
        'chkTRN
        '
        Me.chkTRN.AutoSize = True
        Me.chkTRN.Location = New System.Drawing.Point(397, 69)
        Me.chkTRN.Name = "chkTRN"
        Me.chkTRN.Size = New System.Drawing.Size(51, 19)
        Me.chkTRN.TabIndex = 1
        Me.chkTRN.Text = "TRN"
        Me.chkTRN.UseVisualStyleBackColor = True
        '
        'chkJPG
        '
        Me.chkJPG.AutoSize = True
        Me.chkJPG.Location = New System.Drawing.Point(231, 69)
        Me.chkJPG.Name = "chkJPG"
        Me.chkJPG.Size = New System.Drawing.Size(49, 19)
        Me.chkJPG.TabIndex = 1
        Me.chkJPG.Text = "JPG"
        Me.chkJPG.UseVisualStyleBackColor = True
        '
        'chkZIP
        '
        Me.chkZIP.AutoSize = True
        Me.chkZIP.Location = New System.Drawing.Point(127, 69)
        Me.chkZIP.Name = "chkZIP"
        Me.chkZIP.Size = New System.Drawing.Size(44, 19)
        Me.chkZIP.TabIndex = 1
        Me.chkZIP.Text = "ZIP"
        Me.chkZIP.UseVisualStyleBackColor = True
        '
        'chkINI
        '
        Me.chkINI.AutoSize = True
        Me.chkINI.Location = New System.Drawing.Point(488, 34)
        Me.chkINI.Name = "chkINI"
        Me.chkINI.Size = New System.Drawing.Size(41, 19)
        Me.chkINI.TabIndex = 1
        Me.chkINI.Text = "INI"
        Me.chkINI.UseVisualStyleBackColor = True
        '
        'chkXLS
        '
        Me.chkXLS.AutoSize = True
        Me.chkXLS.Location = New System.Drawing.Point(397, 34)
        Me.chkXLS.Name = "chkXLS"
        Me.chkXLS.Size = New System.Drawing.Size(78, 19)
        Me.chkXLS.TabIndex = 1
        Me.chkXLS.Text = "XLS, CSV"
        Me.chkXLS.UseVisualStyleBackColor = True
        '
        'chkPDF
        '
        Me.chkPDF.AutoSize = True
        Me.chkPDF.Location = New System.Drawing.Point(317, 34)
        Me.chkPDF.Name = "chkPDF"
        Me.chkPDF.Size = New System.Drawing.Size(50, 19)
        Me.chkPDF.TabIndex = 1
        Me.chkPDF.Text = "PDF"
        Me.chkPDF.UseVisualStyleBackColor = True
        '
        'chkTXT
        '
        Me.chkTXT.AutoSize = True
        Me.chkTXT.Location = New System.Drawing.Point(231, 34)
        Me.chkTXT.Name = "chkTXT"
        Me.chkTXT.Size = New System.Drawing.Size(48, 19)
        Me.chkTXT.TabIndex = 1
        Me.chkTXT.Text = "TXT"
        Me.chkTXT.UseVisualStyleBackColor = True
        '
        'chkFLD
        '
        Me.chkFLD.AutoSize = True
        Me.chkFLD.Location = New System.Drawing.Point(127, 34)
        Me.chkFLD.Name = "chkFLD"
        Me.chkFLD.Size = New System.Drawing.Size(98, 19)
        Me.chkFLD.TabIndex = 1
        Me.chkFLD.Text = "Empty Folder"
        Me.chkFLD.UseVisualStyleBackColor = True
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(19, 34)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(102, 19)
        Me.chkAll.TabIndex = 0
        Me.chkAll.Text = "All Extensions"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'grbSetDay
        '
        Me.grbSetDay.Controls.Add(Me.rdoExpire180)
        Me.grbSetDay.Controls.Add(Me.rdoExpire90)
        Me.grbSetDay.Controls.Add(Me.rdoExpire60)
        Me.grbSetDay.Controls.Add(Me.rdoExpire30)
        Me.grbSetDay.Controls.Add(Me.rdoExpire14)
        Me.grbSetDay.Controls.Add(Me.rdoExpire7)
        Me.grbSetDay.Controls.Add(Me.rdoExpire3)
        Me.grbSetDay.Controls.Add(Me.rdoExpire1)
        Me.grbSetDay.Location = New System.Drawing.Point(260, 71)
        Me.grbSetDay.Name = "grbSetDay"
        Me.grbSetDay.Size = New System.Drawing.Size(546, 50)
        Me.grbSetDay.TabIndex = 19
        Me.grbSetDay.TabStop = False
        Me.grbSetDay.Text = "Leave files"
        '
        'rdoExpire180
        '
        Me.rdoExpire180.AutoSize = True
        Me.rdoExpire180.Location = New System.Drawing.Point(467, 19)
        Me.rdoExpire180.Name = "rdoExpire180"
        Me.rdoExpire180.Size = New System.Drawing.Size(74, 19)
        Me.rdoExpire180.TabIndex = 2
        Me.rdoExpire180.Text = "180 days"
        Me.rdoExpire180.UseVisualStyleBackColor = True
        '
        'rdoExpire90
        '
        Me.rdoExpire90.AutoSize = True
        Me.rdoExpire90.Location = New System.Drawing.Point(399, 19)
        Me.rdoExpire90.Name = "rdoExpire90"
        Me.rdoExpire90.Size = New System.Drawing.Size(67, 19)
        Me.rdoExpire90.TabIndex = 2
        Me.rdoExpire90.Text = "90 days"
        Me.rdoExpire90.UseVisualStyleBackColor = True
        '
        'rdoExpire60
        '
        Me.rdoExpire60.AutoSize = True
        Me.rdoExpire60.Location = New System.Drawing.Point(331, 19)
        Me.rdoExpire60.Name = "rdoExpire60"
        Me.rdoExpire60.Size = New System.Drawing.Size(67, 19)
        Me.rdoExpire60.TabIndex = 2
        Me.rdoExpire60.Text = "60 days"
        Me.rdoExpire60.UseVisualStyleBackColor = True
        '
        'rdoExpire30
        '
        Me.rdoExpire30.AutoSize = True
        Me.rdoExpire30.Location = New System.Drawing.Point(263, 19)
        Me.rdoExpire30.Name = "rdoExpire30"
        Me.rdoExpire30.Size = New System.Drawing.Size(67, 19)
        Me.rdoExpire30.TabIndex = 2
        Me.rdoExpire30.Text = "30 days"
        Me.rdoExpire30.UseVisualStyleBackColor = True
        '
        'rdoExpire14
        '
        Me.rdoExpire14.AutoSize = True
        Me.rdoExpire14.Location = New System.Drawing.Point(195, 19)
        Me.rdoExpire14.Name = "rdoExpire14"
        Me.rdoExpire14.Size = New System.Drawing.Size(67, 19)
        Me.rdoExpire14.TabIndex = 2
        Me.rdoExpire14.Text = "14 days"
        Me.rdoExpire14.UseVisualStyleBackColor = True
        '
        'rdoExpire7
        '
        Me.rdoExpire7.AutoSize = True
        Me.rdoExpire7.Checked = True
        Me.rdoExpire7.Location = New System.Drawing.Point(133, 19)
        Me.rdoExpire7.Name = "rdoExpire7"
        Me.rdoExpire7.Size = New System.Drawing.Size(60, 19)
        Me.rdoExpire7.TabIndex = 2
        Me.rdoExpire7.TabStop = True
        Me.rdoExpire7.Text = "7 days"
        Me.rdoExpire7.UseVisualStyleBackColor = True
        '
        'rdoExpire3
        '
        Me.rdoExpire3.AutoSize = True
        Me.rdoExpire3.Location = New System.Drawing.Point(71, 19)
        Me.rdoExpire3.Name = "rdoExpire3"
        Me.rdoExpire3.Size = New System.Drawing.Size(60, 19)
        Me.rdoExpire3.TabIndex = 1
        Me.rdoExpire3.Text = "3 days"
        Me.rdoExpire3.UseVisualStyleBackColor = True
        '
        'rdoExpire1
        '
        Me.rdoExpire1.AutoSize = True
        Me.rdoExpire1.Location = New System.Drawing.Point(14, 19)
        Me.rdoExpire1.Name = "rdoExpire1"
        Me.rdoExpire1.Size = New System.Drawing.Size(55, 19)
        Me.rdoExpire1.TabIndex = 0
        Me.rdoExpire1.Text = "None"
        Me.rdoExpire1.UseVisualStyleBackColor = True
        '
        'grbSetPath
        '
        Me.grbSetPath.Controls.Add(Me.btnPath)
        Me.grbSetPath.Controls.Add(Me.txtPath)
        Me.grbSetPath.Location = New System.Drawing.Point(260, 6)
        Me.grbSetPath.Name = "grbSetPath"
        Me.grbSetPath.Size = New System.Drawing.Size(546, 50)
        Me.grbSetPath.TabIndex = 18
        Me.grbSetPath.TabStop = False
        Me.grbSetPath.Text = "Directory Path"
        '
        'btnPath
        '
        Me.btnPath.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPath.Location = New System.Drawing.Point(481, 20)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(55, 21)
        Me.btnPath.TabIndex = 7
        Me.btnPath.Text = "· · ·"
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(11, 20)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(464, 21)
        Me.txtPath.TabIndex = 5
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(133, 440)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(122, 37)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(6, 440)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(122, 37)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grdLists
        '
        Me.grdLists.AllowUserToAddRows = False
        Me.grdLists.AllowUserToDeleteRows = False
        Me.grdLists.AllowUserToResizeColumns = False
        Me.grdLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdLists.Location = New System.Drawing.Point(6, 6)
        Me.grdLists.MultiSelect = False
        Me.grdLists.Name = "grdLists"
        Me.grdLists.ShowEditingIcon = False
        Me.grdLists.Size = New System.Drawing.Size(248, 428)
        Me.grdLists.TabIndex = 15
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 609)
        Me.Controls.Add(Me.tabLogDelete)
        Me.Controls.Add(Me.grbMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(840, 540)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log Delete"
        Me.grbMenu.ResumeLayout(False)
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLogDelete.ResumeLayout(False)
        Me.tabHistory.ResumeLayout(False)
        Me.grbLog.ResumeLayout(False)
        Me.grbLog.PerformLayout()
        Me.tabConfiguration.ResumeLayout(False)
        Me.grbSetTime.ResumeLayout(False)
        Me.grbSetTime.PerformLayout()
        Me.grbSetExt.ResumeLayout(False)
        Me.grbSetExt.PerformLayout()
        Me.grbSetDay.ResumeLayout(False)
        Me.grbSetDay.PerformLayout()
        Me.grbSetPath.ResumeLayout(False)
        Me.grbSetPath.PerformLayout()
        CType(Me.grdLists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbMenu As GroupBox
    Friend WithEvents tabLogDelete As TabControl
    Friend WithEvents tabConfiguration As TabPage
    Friend WithEvents grbSetTime As GroupBox
    Friend WithEvents chkTime18 As CheckBox
    Friend WithEvents chkTime23 As CheckBox
    Friend WithEvents chkTime22 As CheckBox
    Friend WithEvents chkTime21 As CheckBox
    Friend WithEvents chkTime20 As CheckBox
    Friend WithEvents chkTime19 As CheckBox
    Friend WithEvents chkTime17 As CheckBox
    Friend WithEvents chkTime16 As CheckBox
    Friend WithEvents chkTime15 As CheckBox
    Friend WithEvents chkTime24 As CheckBox
    Friend WithEvents chkTime14 As CheckBox
    Friend WithEvents chkTime13 As CheckBox
    Friend WithEvents chkTime07 As CheckBox
    Friend WithEvents chkTime12 As CheckBox
    Friend WithEvents chkTime11 As CheckBox
    Friend WithEvents chkTime10 As CheckBox
    Friend WithEvents chkTime09 As CheckBox
    Friend WithEvents chkTime08 As CheckBox
    Friend WithEvents chkTime06 As CheckBox
    Friend WithEvents chkTime05 As CheckBox
    Friend WithEvents chkTime04 As CheckBox
    Friend WithEvents chkTime03 As CheckBox
    Friend WithEvents chkTime02 As CheckBox
    Friend WithEvents chkTime01 As CheckBox
    Friend WithEvents grbSetExt As GroupBox
    Friend WithEvents chkMDB As CheckBox
    Friend WithEvents chkBAK As CheckBox
    Friend WithEvents chkTRN As CheckBox
    Friend WithEvents chkJPG As CheckBox
    Friend WithEvents chkZIP As CheckBox
    Friend WithEvents chkINI As CheckBox
    Friend WithEvents chkXLS As CheckBox
    Friend WithEvents chkPDF As CheckBox
    Friend WithEvents chkTXT As CheckBox
    Friend WithEvents chkFLD As CheckBox
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents grbSetDay As GroupBox
    Friend WithEvents rdoExpire180 As RadioButton
    Friend WithEvents rdoExpire90 As RadioButton
    Friend WithEvents rdoExpire60 As RadioButton
    Friend WithEvents rdoExpire30 As RadioButton
    Friend WithEvents rdoExpire14 As RadioButton
    Friend WithEvents rdoExpire3 As RadioButton
    Friend WithEvents rdoExpire1 As RadioButton
    Friend WithEvents grbSetPath As GroupBox
    Friend WithEvents btnPath As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents grdLists As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents lstHistory As ListBox
    Friend WithEvents grbLog As GroupBox
    Friend WithEvents txtLogPath As TextBox
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents chkPNG As CheckBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents rdoExpire7 As RadioButton
    Friend WithEvents picTitle As PictureBox
    Friend WithEvents tabHistory As TabPage
    Friend WithEvents chkAutoRun As CheckBox
End Class
