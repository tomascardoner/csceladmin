Module Startup

#Region "Declarations"

    Friend Const ERROR_CUSTOM_DIALOG As Boolean = True
    Friend fTrapErrors As Boolean

    Friend fDatabase As CS_Database_ADONET

#End Region

    Public Sub Main()
        Dim StartTime As Date

        Cursor.Current = Cursors.AppStarting

        fTrapErrors = True

        StartTime = Now

        Debug.Print(My.Application.Log.DefaultFileLogWriter.FullLogFileName)
        My.Application.Log.WriteEntry("*** Application Starts ***", TraceEventType.Information)

        formSplash.Show()

        '/////////////////////////////////////////////////////
        'DATABASE OPEN - START
        fDatabase = New CS_Database_ADONET
        fDatabase.DataSource = My.Settings.DBConnection_Datasource
        fDatabase.CreateConnectionString(My.Settings.DBConnection_Provider)

        If Not fDatabase.Connect Then
            formSplash.Close()
            formSplash = Nothing
            Exit Sub
        End If
        'DATABASE OPEN - END
        '/////////////////////////////////////////////////////

        '        If pIsCompiled Then
        Do While DateDiff("s", StartTime, Now) < 4
            Application.DoEvents()
        Loop
        '        End If

        formMain.Show()

        formSplash.Close()
        formSplash.Dispose()

        Cursor.Current = Cursors.Default

        Application.Run()
    End Sub

    Friend Sub TerminateApplication()
        Static Running As Boolean

        If Running Then
            Exit Sub
        End If

        Running = True
        CS_Form.CloseAll()

        If Not fDatabase Is Nothing Then
            fDatabase.Disconnect()
            fDatabase = Nothing
        End If

        My.Application.Log.WriteEntry("*** Application Terminate ***", TraceEventType.Information)
        Running = False

        Application.Exit()
    End Sub
End Module
