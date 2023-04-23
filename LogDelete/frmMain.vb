Option Explicit On
'Option Strict On


Imports System.Threading    '// Imports Threading Namespace
Imports System.Runtime.InteropServices

Public Class frmMain

    Private m_oTable As New DataTable("Table")
    Private m_curRow As Integer
    Private oThread As Thread

    Private Sub FormSize_Resize()

        Dim lFormWidth As Long
        Dim lFormHeight As Long

        lFormWidth = Me.Width - 15
        lFormHeight = Me.Height - 15

        grbMenu.Left = 3
        grbMenu.Top = -4
        grbMenu.Width = lFormWidth - 8

        btnStop.Left = grbMenu.Width - btnStop.Width - 5
        btnStart.Left = btnStop.Left - btnStart.Width - 5

        tabLogDelete.Left = grbMenu.Left
        tabLogDelete.Top = grbMenu.Top + grbMenu.Height + 2
        tabLogDelete.Width = lFormWidth - 5
        tabLogDelete.Height = lFormHeight - grbMenu.Top - grbMenu.Height - 30

        '// Adjust size for history tab's controller 
        grbLog.Left = 5
        grbLog.Top = 6
        grbLog.Width = tabLogDelete.Width - 20

        txtLogPath.Left = 6
        txtLogPath.Top = 18
        txtLogPath.Width = grbLog.Width - 12

        lstHistory.Left = grbLog.Left
        lstHistory.Top = grbLog.Top + grbLog.Height + 4
        lstHistory.Width = grbLog.Width
        lstHistory.Height = tabLogDelete.Height - grbLog.Top - grbLog.Height - grbFullLog.Height - 40

        grbFullLog.Left = 5
        grbFullLog.Top = lstHistory.Top + lstHistory.Height + 4
        grbFullLog.Width = tabLogDelete.Width - 20

        txtFullPath.Left = 6
        txtFullPath.Top = 18
        txtFullPath.Width = grbFullLog.Width - 12

        '// Adjust size for configuration tab's controller 
        grdLists.Left = 5
        grdLists.Top = 5
        grdLists.Width = lFormWidth - grbSetPath.Width - 32
        grdLists.Height = tabLogDelete.Height - btnAdd.Height - 42

        grbSetPath.Left = grdLists.Left + grdLists.Width + 5
        grbSetPath.Top = 1
        grbSetDay.Left = grbSetPath.Left
        grbSetDay.Top = grbSetPath.Top + grbSetPath.Height + 5

        grbSetExt.Left = grbSetPath.Left
        grbSetExt.Top = grbSetDay.Top + grbSetDay.Height + 5
        grbSetTime.Left = grbSetPath.Left
        grbSetTime.Top = grbSetExt.Top + grbSetExt.Height + 5

        btnAdd.Left = grdLists.Left
        btnAdd.Top = grdLists.Top + grdLists.Height + 5
        btnAdd.Width = (grdLists.Width / 2) - 2

        btnDelete.Left = btnAdd.Left + btnAdd.Width + 4
        btnDelete.Top = btnAdd.Top
        btnDelete.Width = btnAdd.Width

        'btnSave.Width = btnAdd.Width
        btnSave.Left = tabLogDelete.Width - btnSave.Width - 17
        btnSave.Top = btnAdd.Top

    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        On Error Resume Next

        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            Me.Hide()
            'NotifyIcon1.BalloonTipText = "LogDelete"
            'NotifyIcon1.ShowBalloonTip(500)
            Exit Sub
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Exit Sub
        End If

        Call FormSize_Resize()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Process.GetProcessesByName("LogDelete").Count > 1 Then
            MessageBox.Show("LogDelete is already running", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()
            Exit Sub
        End If

        NotifyIcon1.BalloonTipText = "LogDelete"
        NotifyIcon1.Text = "LogDelete"
        'NotifyIcon1.ShowBalloonTip(500)
        gsubCreateContextMenu()

        m_curRow = 1

        Call psubTableInit()
        Call gsubLoadXML()
        Call psubLoadList()
        Call psubGetSystemValues()
        Call psubGetListValues(m_curRow)

        'Call gsubSetDoubleBuffered(lstHistory, True)    '// Avoid flickering of listview controller

        'SetStyle(&H22010, True)
        'SetStyle(ControlStyles.OptimizedDoubleBuffer Or
        'ControlStyles.AllPaintingInWmPaint Or
        'ControlStyles.ResizeRedraw, True)

        'SetStyle(ControlStyles.DoubleBuffer, True)
        'SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        'SetStyle(ControlStyles.UserPaint, True)

        If gnAutoRun > 0 Then
            Call btnStart_Click(Nothing, Nothing)
        End If

    End Sub

    Public Sub gsubCreateContextMenu()

        'Define New Context Menu and Menu Item 
        Dim contextMenu As New ContextMenu
        Dim menuItem1 As New MenuItem("Exit")
        Dim menuItem2 As New MenuItem("Show")

        contextMenu.MenuItems.Add(menuItem1)
        contextMenu.MenuItems.Add(menuItem2)

        ' Associate context menu with Notify Icon 
        NotifyIcon1.ContextMenu = contextMenu

        'Add functionality for menu Item click 
        AddHandler menuItem1.Click, AddressOf menuItem1_Click
        AddHandler menuItem2.Click, AddressOf menuItem2_Click

    End Sub

    '// Exit tray button
    Private Sub menuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Try
            If gbStart = True Then
                gbStart = False
                oThread.Abort()
            End If

            Me.Close()

        Catch ex As Exception

        End Try

    End Sub

    '// Show tray button
    Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Try
            If gbStart = True Then
                gbStart = False
                oThread.Abort()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub psubTableInit()
        m_oTable.Columns.Add("ID", GetType(Integer))
        m_oTable.Columns.Add("List Name", GetType(String))
        grdLists.DataSource = m_oTable
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Call psubRunPath()

        If gbStart = False Then

            Try
                lstHistory.Items.Clear()
                Call gsubSetLogInfo("Processing Start")
                Call psubRunDateClear()

                oThread = New Thread(AddressOf psubWorkThread)
                gbStart = True
                oThread.Start()
            Catch ex As Exception
                MsgBox("Can't start a thread" & vbCrLf & ex.Message)
            End Try

        End If

    End Sub

    '// change the date to yesterday in batches so that it can be processed in the thread.
    Private Sub psubRunDateClear()

        Dim nIndex As Integer

        For nIndex = 1 To MAX_ARRAY
            gFileList(nIndex).nRunDate = Today.AddDays(-1).ToString("yyyyMMdd")   'Today.AddDays(-1)
        Next

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        Call psubRunPath()

        If gbStart = True Then
            Try
                gbStart = False
                oThread.Abort()
                Call gsubSetLogInfo("Processing Stop")
            Catch ex As Exception
                MsgBox("Can't stop a thread" & vbCrLf & ex.Message)
            End Try
        End If

    End Sub

    Private Sub psubWorkThread()

        Dim nIndex As Integer
        Dim nHour As Integer
        Dim nPrivIndex As Integer

        Dim nCurDate = Today.ToString("yyyyMMdd")

        While (gbStart)

            nHour = DateTime.Now.ToString("HH")

            If gnRunTime(nHour) > 0 Then

                nIndex = nIndex Mod 20
                nIndex += 1

                If gFileList(nIndex).strPath <> "" Then

                    If gFileList(nIndex).nRunDate < nCurDate Then

                        If (Me.InvokeRequired) Then
                            Me.Invoke(Sub()

                                          If nPrivIndex <> nIndex Then
                                              nPrivIndex = nIndex
                                              Call gsubSetLogInfo("Starting to work on " & gFileList(nIndex).strList)
                                          End If

                                          Call psubRunPath(nIndex, True)
                                          Call gsubSearch(nIndex, gFileList(nIndex).strPath)
                                          Call psubRunPath(nIndex)
                                          txtFullPath.Text = ""
                                      End Sub)
                        End If

                        gFileList(nIndex).nRunDate = nCurDate

                    End If

                End If

                Application.DoEvents()

                End If

            'Call gsubSetLogInfo("Finished woking on " & gFileList(nIndex).strList)

            Thread.Sleep(3000)

            If (Me.InvokeRequired) Then
                Me.Invoke(Sub()
                              txtLogPath.Text = "Idle"
                          End Sub)
            End If

        End While

    End Sub

    Private Sub psubRunPath(Optional ByVal nIndex As Integer = 0, Optional ByVal bStart As Boolean = False)

        If bStart Then
            txtLogPath.Text = gFileList(nIndex).strList & " : " & gFileList(nIndex).strPath
        Else
            txtLogPath.Text = gFileList(nIndex).strList & IIf(nIndex > 0, " : Done", "")
        End If

    End Sub

    Private Sub psubLoadList()

        Dim nIndex As Integer

        m_oTable.Clear()
        grdLists.DataSource = m_oTable
        grdLists.DataSource = Nothing

        For nIndex = 1 To MAX_ARRAY
            If String.IsNullOrEmpty(gFileList(nIndex).strList) = True Then
                Exit For
            Else
                Call psubAddList(nIndex, gFileList(nIndex).strList)
            End If
        Next

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim strValue As String
        Dim nIndex As Integer

        strValue = InputBox("Please put the log title", "Log Title", "Enter a title")

        If String.IsNullOrEmpty(strValue) = True Then
            Exit Sub
        End If

        nIndex = grdLists.Rows.Count + 1
        Call psubAddList(nIndex, strValue)

        Call gsubSaveData()
        Call gsubSaveXML()
        Call gsubLoadXML()
        Call psubLoadList()

        Call MsgBox("Done")

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If gbStart = True Then
            MessageBox.Show("Please stop processing, retry it again.")
            Exit Sub
        End If

        If grdLists.Rows.Count > 0 Then

            grdLists.Rows.RemoveAt(m_curRow - 1)

            Call gsubValueClear(m_curRow)
            Call gsubSaveData()
            Call gsubSaveXML()
            Call gsubLoadXML()
            Call psubLoadList()

            Call MsgBox("Done")

        End If
    End Sub

    Private Sub psubCtrlClear()

        gFileList(m_curRow).strList = ""
        txtPath.Text = ""

        rdoExpire1.Checked = False
        rdoExpire3.Checked = False
        rdoExpire7.Checked = False
        rdoExpire14.Checked = False
        rdoExpire30.Checked = False
        rdoExpire60.Checked = False
        rdoExpire90.Checked = False
        rdoExpire180.Checked = False
        rdoExpire7.Checked = False

        chkAll.Checked = False
        chkFLD.Checked = False
        chkTXT.Checked = False
        chkPDF.Checked = False
        chkXLS.Checked = False
        chkINI.Checked = False
        chkMDB.Checked = False
        chkZIP.Checked = False
        chkJPG.Checked = False
        chkPNG.Checked = False
        chkTRN.Checked = False
        chkBAK.Checked = False

    End Sub

    Private Sub psubAddList(ByVal nIndex As Integer, ByVal strList As String)

        m_oTable.Rows.Add(nIndex, strList)
        grdLists.DataSource = m_oTable

        grdLists.Columns(0).Width = 40
        grdLists.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdLists.Columns(1).Width = 160

        gFileList(nIndex).strList = strList

    End Sub

    Private Sub psubGetSystemValues()

        chkAutoRun.Checked = gnAutoRun

        chkTime01.Checked = gnRunTime(1)
        chkTime02.Checked = gnRunTime(2)
        chkTime03.Checked = gnRunTime(3)
        chkTime04.Checked = gnRunTime(4)
        chkTime05.Checked = gnRunTime(5)
        chkTime06.Checked = gnRunTime(6)
        chkTime07.Checked = gnRunTime(7)
        chkTime08.Checked = gnRunTime(8)
        chkTime09.Checked = gnRunTime(9)
        chkTime10.Checked = gnRunTime(10)
        chkTime11.Checked = gnRunTime(11)
        chkTime12.Checked = gnRunTime(12)
        chkTime13.Checked = gnRunTime(13)
        chkTime14.Checked = gnRunTime(14)
        chkTime15.Checked = gnRunTime(15)
        chkTime16.Checked = gnRunTime(16)
        chkTime17.Checked = gnRunTime(17)
        chkTime18.Checked = gnRunTime(18)
        chkTime19.Checked = gnRunTime(19)
        chkTime20.Checked = gnRunTime(20)
        chkTime21.Checked = gnRunTime(21)
        chkTime22.Checked = gnRunTime(22)
        chkTime23.Checked = gnRunTime(23)
        chkTime24.Checked = gnRunTime(0)

    End Sub

    Private Sub psubSetSystemValues()

        gnAutoRun = Math.Abs(CInt(chkAutoRun.Checked))

        gnRunTime(1) = Math.Abs(CInt(chkTime01.Checked))
        gnRunTime(2) = Math.Abs(CInt(chkTime02.Checked))
        gnRunTime(3) = Math.Abs(CInt(chkTime03.Checked))
        gnRunTime(4) = Math.Abs(CInt(chkTime04.Checked))
        gnRunTime(5) = Math.Abs(CInt(chkTime05.Checked))
        gnRunTime(6) = Math.Abs(CInt(chkTime06.Checked))
        gnRunTime(7) = Math.Abs(CInt(chkTime07.Checked))
        gnRunTime(8) = Math.Abs(CInt(chkTime08.Checked))
        gnRunTime(9) = Math.Abs(CInt(chkTime09.Checked))
        gnRunTime(10) = Math.Abs(CInt(chkTime10.Checked))
        gnRunTime(11) = Math.Abs(CInt(chkTime11.Checked))
        gnRunTime(12) = Math.Abs(CInt(chkTime12.Checked))
        gnRunTime(13) = Math.Abs(CInt(chkTime13.Checked))
        gnRunTime(14) = Math.Abs(CInt(chkTime14.Checked))
        gnRunTime(15) = Math.Abs(CInt(chkTime15.Checked))
        gnRunTime(16) = Math.Abs(CInt(chkTime16.Checked))
        gnRunTime(17) = Math.Abs(CInt(chkTime17.Checked))
        gnRunTime(18) = Math.Abs(CInt(chkTime18.Checked))
        gnRunTime(19) = Math.Abs(CInt(chkTime19.Checked))
        gnRunTime(20) = Math.Abs(CInt(chkTime20.Checked))
        gnRunTime(21) = Math.Abs(CInt(chkTime21.Checked))
        gnRunTime(22) = Math.Abs(CInt(chkTime22.Checked))
        gnRunTime(23) = Math.Abs(CInt(chkTime23.Checked))
        gnRunTime(0) = Math.Abs(CInt(chkTime24.Checked))

    End Sub

    Private Sub psubGetListValues(ByVal nIndex As Integer)

        txtPath.Text = gFileList(nIndex).strPath

        Select Case gFileList(nIndex).nIsDate
            Case -1 : rdoExpire1.Checked = True
            Case 3 : rdoExpire3.Checked = True
            Case 7 : rdoExpire7.Checked = True
            Case 14 : rdoExpire14.Checked = True
            Case 30 : rdoExpire30.Checked = True
            Case 60 : rdoExpire60.Checked = True
            Case 90 : rdoExpire90.Checked = True
            Case 180 : rdoExpire180.Checked = True
            Case Else : rdoExpire7.Checked = True
        End Select

        chkAll.Checked = gFileList(nIndex).nExtAll
        chkFLD.Checked = gFileList(nIndex).nExtFLD
        chkTXT.Checked = gFileList(nIndex).nExtTXT
        chkPDF.Checked = gFileList(nIndex).nExtPDF
        chkXLS.Checked = gFileList(nIndex).nExtXLS
        chkINI.Checked = gFileList(nIndex).nExtINI
        chkMDB.Checked = gFileList(nIndex).nExtMDB
        chkZIP.Checked = gFileList(nIndex).nExtZIP
        chkJPG.Checked = gFileList(nIndex).nExtJPG
        chkPNG.Checked = gFileList(nIndex).nExtPNG
        chkTRN.Checked = gFileList(nIndex).nExtTRN
        chkBAK.Checked = gFileList(nIndex).nExtBAK

    End Sub

    Private Sub psubSetListValus(ByVal nIndex As Integer)

        gFileList(nIndex).strPath = txtPath.Text
        gFileList(nIndex).nExtAll = Math.Abs(CInt(chkAll.Checked))
        gFileList(nIndex).nExtFLD = Math.Abs(CInt(chkFLD.Checked))
        gFileList(nIndex).nExtTXT = Math.Abs(CInt(chkTXT.Checked))
        gFileList(nIndex).nExtPDF = Math.Abs(CInt(chkPDF.Checked))
        gFileList(nIndex).nExtXLS = Math.Abs(CInt(chkXLS.Checked))
        gFileList(nIndex).nExtINI = Math.Abs(CInt(chkINI.Checked))
        gFileList(nIndex).nExtMDB = Math.Abs(CInt(chkMDB.Checked))
        gFileList(nIndex).nExtZIP = Math.Abs(CInt(chkZIP.Checked))
        gFileList(nIndex).nExtJPG = Math.Abs(CInt(chkJPG.Checked))
        gFileList(nIndex).nExtPNG = Math.Abs(CInt(chkPNG.Checked))
        gFileList(nIndex).nExtTRN = Math.Abs(CInt(chkTRN.Checked))
        gFileList(nIndex).nExtBAK = Math.Abs(CInt(chkBAK.Checked))

        If rdoExpire1.Checked Then gFileList(nIndex).nIsDate = -1
        If rdoExpire3.Checked Then gFileList(nIndex).nIsDate = 3
        If rdoExpire7.Checked Then gFileList(nIndex).nIsDate = 7
        If rdoExpire14.Checked Then gFileList(nIndex).nIsDate = 14
        If rdoExpire30.Checked Then gFileList(nIndex).nIsDate = 30
        If rdoExpire60.Checked Then gFileList(nIndex).nIsDate = 60
        If rdoExpire90.Checked Then gFileList(nIndex).nIsDate = 90
        If rdoExpire180.Checked Then gFileList(nIndex).nIsDate = 180

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call psubSetSystemValues()
        Call psubSetListValus(m_curRow)
        Call gsubSaveXML()
        Call MsgBox("Done")
    End Sub

    Private Sub btnPath_Click(sender As Object, e As EventArgs) Handles btnPath.Click

        Dim fbd As FolderBrowserDialog

        fbd = New FolderBrowserDialog

        fbd.Description = "Select the folder in which you want to delete the log file"

        'fbd.SelectedPath = "C:\ADO Lessons\Fundamental"
        fbd.ShowNewFolderButton = False

        If fbd.ShowDialog() = DialogResult.OK Then
            txtPath.Text = fbd.SelectedPath
        End If

    End Sub

    Private Sub grdLists_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdLists.CellMouseClick

        If e.RowIndex >= 0 Then

            Dim nRow As DataGridViewRow = grdLists.Rows(e.RowIndex)

            m_curRow = nRow.Cells(0).Value.ToString

            Call psubGetListValues(m_curRow)
        End If

    End Sub

End Class

