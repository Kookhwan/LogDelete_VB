Imports System.IO
Imports System.Xml
Imports System.Reflection

Module functions

    Public gbStart As Boolean
    Public Const MAX_ARRAY = 20
    Public gnAutoRun As Integer
    Public gnRunTime(24) As Integer
    Public gFileList(MAX_ARRAY) As FileList

    Private mstrPath As String = "C:\LogDelete"         '// Directory which is located files
    Private mstrFile As String = "LogFileInfo.xml"      '// Configuration file

    '// Structure for file extension
    Public Structure FileList

        Public strList As String
        Public strPath As String
        Public nIsDate As Integer
        Public nExtAll As Integer
        Public nExtFLD As Integer
        Public nExtTXT As Integer
        Public nExtPDF As Integer
        Public nExtXLS As Integer
        Public nExtMDB As Integer
        Public nExtINI As Integer
        Public nExtZIP As Integer
        Public nExtJPG As Integer
        Public nExtPNG As Integer
        Public nExtTRN As Integer
        Public nExtBAK As Integer
        Public nRunDate As Integer

    End Structure

    '// Search for files and empty folders from all directories and subdirectories
    Public Sub gsubSearch(ByVal nIndex As Integer, ByVal strPath As String)

        If gbStart = False Then
            Exit Sub
        End If

        If Directory.Exists(strPath) Then

            '// Delete specific files from the Directory
            For Each filepath As String In Directory.GetFiles(strPath)
                If pfunValidation(nIndex, filepath) Then
                    Call psubSetHistory(filepath, "File")
                    File.Delete(filepath)
                End If
            Next

            '// Go to sub directories to find files
            For Each dir As String In Directory.GetDirectories(strPath)
                gsubSearch(nIndex, dir) '// Go to sub directory
            Next

            '// if strPath is not main directory, then keep processing
            If gFileList(nIndex).strPath <> strPath Then

                '// if there are no files and Directories, then delete a folder.
                If Directory.EnumerateFiles(strPath).Count = 0 And Directory.EnumerateDirectories(strPath).Count = 0 Then

                    If pfunValidation(nIndex, strPath) Then
                        '// Delete a Directory
                        Call psubSetHistory(strPath, "Folder")
                        Directory.Delete(strPath)
                    End If

                End If

            End If

        End If

    End Sub

    '// Check validate with date and extention name of the argument(path)
    Private Function pfunValidation(ByVal nIndex As Integer, ByVal strPath As String) As Boolean

        Dim objFileInfo As New FileInfo(strPath)
        Dim dtExpDate As Date
        Dim dtModDate As Date = objFileInfo.LastWriteTime   '// Get lastwritetime date from the path
        Dim bReturn As Boolean

        '// Get Expire date
        dtExpDate = Today.AddDays(-gFileList(nIndex).nIsDate)

        ''// if the lastwritetime is older than expire date, it should be deleted.
        If dtModDate < dtExpDate Then
            bReturn = True
        End If

        If bReturn Then
            '// if Extension_All flag is false, check valid extension to delete file or folder
            If gFileList(nIndex).nExtAll = 0 Then
                bReturn = pfunExtValid(nIndex, objFileInfo.Extension)
            End If
        End If

        pfunValidation = bReturn

        Application.DoEvents()

    End Function

    '// Check validate with extension name
    Private Function pfunExtValid(ByVal nIndex As Integer, ByVal strExtName As String) As Boolean

        Dim bReturn As Boolean = False

        Select Case LCase(strExtName)   '// make small character for extension name to compare properly
            Case ""
                bReturn = gFileList(nIndex).nExtFLD
            Case ".txt"
                bReturn = gFileList(nIndex).nExtTXT
            Case ".pdf"
                bReturn = gFileList(nIndex).nExtPDF
            Case ".xls", ".xlsx", ".csv"
                bReturn = gFileList(nIndex).nExtXLS
            Case ".ini"
                bReturn = gFileList(nIndex).nExtINI
            Case ".mdb"
                bReturn = gFileList(nIndex).nExtMDB
            Case ".zip"
                bReturn = gFileList(nIndex).nExtZIP
            Case ".jpg", ".gif"
                bReturn = gFileList(nIndex).nExtJPG
            Case ".png"
                bReturn = gFileList(nIndex).nExtPNG
            Case ".trn"
                bReturn = gFileList(nIndex).nExtTRN
            Case ".bak"
                bReturn = gFileList(nIndex).nExtBAK
        End Select

        pfunExtValid = bReturn

    End Function

    '// Adding history in the list box
    Public Sub psubSetHistory(ByVal strPath As String, ByVal strType As String)

        Dim objFileInfo As New FileInfo(strPath)
        Dim strMessage As String

        strMessage = ""
        strMessage = strMessage & "[" & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & "] "
        strMessage = strMessage & "File Path: " & objFileInfo.FullName & ", "
        strMessage = strMessage & "Type: " & strType & ", "
        strMessage = strMessage & "Last Modified: " & objFileInfo.LastWriteTime

        frmMain.lstHistory.Items.Insert(0, strMessage)

        If frmMain.lstHistory.Items.Count > 40000 Then
            frmMain.lstHistory.Items.RemoveAt(frmMain.lstHistory.Items.Count - 1)
        End If

    End Sub

    '// Saving values into XML file
    Public Sub gsubSaveXML()

        Dim nIndex As Integer
        Dim objWriter As New XmlTextWriter(mstrPath & "\" & mstrFile, System.Text.Encoding.UTF8)

        objWriter.WriteStartDocument(True)
        objWriter.Formatting = Formatting.Indented
        objWriter.Indentation = 2

        objWriter.WriteStartElement("System")

        '//////////////////////////////////////////////////////////////////////////////
        '// Save Environment Node
        objWriter.WriteStartElement("Environment")
        objWriter.WriteStartElement("AutoRun")
        objWriter.WriteString(gnAutoRun)
        objWriter.WriteEndElement()

        For nIndex = 0 To 23
            objWriter.WriteStartElement("RunTime_" & nIndex.ToString("D2"))
            objWriter.WriteString(gnRunTime(nIndex))
            objWriter.WriteEndElement()
        Next

        objWriter.WriteEndElement()
        '//////////////////////////////////////////////////////////////////////////////

        '//////////////////////////////////////////////////////////////////////////////
        '// Save Lists Node
        For nIndex = 1 To MAX_ARRAY

            objWriter.WriteStartElement("ListNo_" & nIndex.ToString("D2"))
            objWriter.WriteStartElement("ListName")
            objWriter.WriteString(gFileList(nIndex).strList)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Path")
            objWriter.WriteString(gFileList(nIndex).strPath)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Date")
            objWriter.WriteString(gFileList(nIndex).nIsDate)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Ext_ALL")
            objWriter.WriteString(gFileList(nIndex).nExtAll)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Ext_FLD")
            objWriter.WriteString(gFileList(nIndex).nExtFLD)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Ext_TXT")
            objWriter.WriteString(gFileList(nIndex).nExtTXT)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Ext_PDF")
            objWriter.WriteString(gFileList(nIndex).nExtPDF)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Ext_XLS")
            objWriter.WriteString(gFileList(nIndex).nExtXLS)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Ext_INI")
            objWriter.WriteString(gFileList(nIndex).nExtINI)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Ext_MDB")
            objWriter.WriteString(gFileList(nIndex).nExtMDB)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Ext_ZIP")
            objWriter.WriteString(gFileList(nIndex).nExtZIP)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Ext_JPG")
            objWriter.WriteString(gFileList(nIndex).nExtJPG)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Ext_PNG")
            objWriter.WriteString(gFileList(nIndex).nExtPNG)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Ext_TRN")
            objWriter.WriteString(gFileList(nIndex).nExtTRN)
            objWriter.WriteEndElement()
            objWriter.WriteStartElement("Ext_BAK")
            objWriter.WriteString(gFileList(nIndex).nExtBAK)
            objWriter.WriteEndElement()
            objWriter.WriteEndElement()
        Next
        '//////////////////////////////////////////////////////////////////////////////

        objWriter.WriteEndElement()
        objWriter.WriteEndDocument()

        objWriter.Close()

    End Sub

    '// Loading value from XML file
    Public Sub gsubLoadXML()

        Dim xmlDoc As New XmlDocument()
        Dim nIndex As Integer
        Dim objXml As XmlElement

        Call IsExistXmlFile()

        xmlDoc.Load(mstrPath & "\" & mstrFile)
        gnAutoRun = xmlDoc.SelectSingleNode("//System/Environment/AutoRun").InnerText

        For nIndex = 0 To 23
            objXml = xmlDoc.SelectSingleNode("//System/Environment/RunTime_" & nIndex.ToString("D2"))
            If IsNothing(objXml) = False Then gnRunTime(nIndex) = objXml.InnerText
        Next

        For nIndex = 1 To MAX_ARRAY
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/ListName")
            If IsNothing(objXml) = False Then gFileList(nIndex).strList = objXml.InnerText

            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Path")
            If IsNothing(objXml) = False Then gFileList(nIndex).strPath = objXml.InnerText
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Date")
            If IsNothing(objXml) = False Then gFileList(nIndex).nIsDate = objXml.InnerText
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Ext_ALL")
            If IsNothing(objXml) = False Then gFileList(nIndex).nExtAll = objXml.InnerText
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Ext_FLD")
            If IsNothing(objXml) = False Then gFileList(nIndex).nExtFLD = objXml.InnerText
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Ext_TXT")
            If IsNothing(objXml) = False Then gFileList(nIndex).nExtTXT = objXml.InnerText
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Ext_PDF")
            If IsNothing(objXml) = False Then gFileList(nIndex).nExtPDF = objXml.InnerText
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Ext_XLS")
            If IsNothing(objXml) = False Then gFileList(nIndex).nExtXLS = objXml.InnerText
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Ext_INI")
            If IsNothing(objXml) = False Then gFileList(nIndex).nExtINI = objXml.InnerText
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Ext_MDB")
            If IsNothing(objXml) = False Then gFileList(nIndex).nExtMDB = objXml.InnerText
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Ext_ZIP")
            If IsNothing(objXml) = False Then gFileList(nIndex).nExtZIP = objXml.InnerText
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Ext_JPG")
            If IsNothing(objXml) = False Then gFileList(nIndex).nExtJPG = objXml.InnerText
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Ext_PNG")
            If IsNothing(objXml) = False Then gFileList(nIndex).nExtPNG = objXml.InnerText
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Ext_TRN")
            If IsNothing(objXml) = False Then gFileList(nIndex).nExtTRN = objXml.InnerText
            objXml = xmlDoc.SelectSingleNode("//System/ListNo_" & nIndex.ToString("D2") & "/Ext_BAK")
            If IsNothing(objXml) = False Then gFileList(nIndex).nExtBAK = objXml.InnerText
        Next

    End Sub

    '// Save list values
    Public Sub gsubSaveData()

        Dim nCnt As Integer = 0
        Dim nIndex As Integer

        For nIndex = 1 To MAX_ARRAY

            If String.IsNullOrEmpty(gFileList(nIndex).strList) = False Then
                nCnt += 1
                If nCnt <> nIndex Then
                    gFileList(nCnt) = gFileList(nIndex)
                    Call gsubValueClear(nIndex)     '// Shifted value inititial
                End If
            End If
        Next

    End Sub

    '// list value clear
    Public Sub gsubValueClear(ByVal nIndex As Integer)

        gFileList(nIndex).strList = ""
        gFileList(nIndex).strPath = ""
        gFileList(nIndex).nIsDate = 0
        gFileList(nIndex).nExtAll = 0
        gFileList(nIndex).nExtFLD = 0
        gFileList(nIndex).nExtTXT = 0
        gFileList(nIndex).nExtPDF = 0
        gFileList(nIndex).nExtXLS = 0
        gFileList(nIndex).nExtMDB = 0
        gFileList(nIndex).nExtINI = 0
        gFileList(nIndex).nExtZIP = 0
        gFileList(nIndex).nExtJPG = 0
        gFileList(nIndex).nExtPNG = 0
        gFileList(nIndex).nExtTRN = 0
        gFileList(nIndex).nExtBAK = 0

    End Sub

    '// Check if xml file exist
    Private Sub IsExistXmlFile()

        If Not Directory.Exists(mstrPath) Then
            Directory.CreateDirectory(mstrPath)
        End If

        If Not File.Exists(mstrPath & "\" & mstrFile) = True Then
            Dim file As System.IO.FileStream
            file = System.IO.File.Create(mstrPath & "\" & mstrFile)
            file.Close()
            Call gsubSaveXML()
        End If

    End Sub

    Public Sub gsubSetDoubleBuffered(ctrl As Control, settings As Boolean)

        Dim dgvType As Type = ctrl.GetType()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(ctrl, settings, Nothing)

    End Sub

End Module

