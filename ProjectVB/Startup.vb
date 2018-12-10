Module Startup
    '#####################################################
    'APPLICATION CONSTANTS & VARIABLES

    '/////////////////////////////////////////////////////
    'ERROR
    Friend Const ERROR_CUSTOM_DIALOG As Boolean = True
    Friend fTrapErrors As Boolean

    '/////////////////////////////////////////////////////
    'DATABASE
    Friend fDatabase As CS_Database_ADONET
    'Friend Const DATABASE_IDENTIFIER = "{932374D6-96EC-4296-8E93-252004B280DF}"
    '#####################################################

    Public Sub Main()
        Dim StartTime As Date

        '/////////////////////////////////////////////////////
        'ALLOW ONLY ONE INSTANCE
        'If My.Applicat Then
        '    ActivatePrevInstance()
        '    Exit Sub
        'End If

        Cursor.Current = Cursors.AppStarting

        fTrapErrors = True

        StartTime = Now

        Debug.Print(My.Application.Log.DefaultFileLogWriter.FullLogFileName)
        My.Application.Log.WriteEntry("*** Application Starts ***", TraceEventType.Information)

        Splash.Show()

        '/////////////////////////////////////////////////////
        'DATABASE OPEN - START
        fDatabase = New CS_Database_ADONET
        fDatabase.DataSource = My.Settings.DBConnection_Datasource
        fDatabase.CreateConnectionString(My.Settings.DBConnection_Provider)

        If Not fDatabase.Connect Then
            Splash.Close()
            Splash = Nothing
            Exit Sub
        End If
        'DATABASE OPEN - END
        '/////////////////////////////////////////////////////

        '        If pIsCompiled Then
        Do While DateDiff("s", StartTime, Now) < 4
            Application.DoEvents()
        Loop
        '        End If

        MainForm.Show()

        Splash.Close()
        Splash.Dispose()

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
