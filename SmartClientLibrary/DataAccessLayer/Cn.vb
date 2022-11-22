Public Class Cn
    Private cnDefault As String

    Public Sub New()
        'staging
        ' cnDefault = "Data Source=172.17.29.228,1433\DIGIGUJINST2;Initial Catalog=RCPSDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
        'live
        cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
        'local
        '  cnDefault = "Data Source=10.154.2.54,1433\S16d;Initial Catalog=RCPSDB;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"
    End Sub
    Public Function NewConnectionString(ByVal dbGroup As enumDBGroup) As String
        Select Case dbGroup
            Case enumDBGroup.RCPSAdminDB 'RCPSAdmindb
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSAdmindb;User ID=RCPSAdmindb;Password=atvt@RCPSAdmindb;language=british english;Pooling=true"
            Case enumDBGroup.RCPSArchivalDB 'RCPSphotodbarchive
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSphotodbarchive;User ID=RCPSphotodbarchive;Password=atvt@RCPSphotodbarchive;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.RCPSCitizenDB 'RCPSDB
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.RCPSFileDB 'RCPSTableDB
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSTableDB;User ID=RCPSTableDB;Password=atvt@RCPSTableDB;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.RCPSLogDB 'RCPSLog
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSLog;User ID=RCPSLog;Password=atvt@RCPSLog;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.RCPSOfficeDB 'RCPSDB
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSDB;User ID=rcps;Password=atvt@rcps;language=british english;Pooling=true"
            Case enumDBGroup.RCPSDisposeDB 'RCPSDisposeDB
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSDisposeDB;User ID=RCPSDisposeDB;Password=atvt@RCPSDisposeDB;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.RCPSPhotoDB 'RCPSPhotoDB
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSPhotoDB;User ID=RCPSPhotoDB;Password=atvt@RCPSPhotoDB;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.RCPSSMS 'RCPSPhotoDB
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSCitizenLogdb;User ID=RCPSCitizenLogdb;Password=atvt@RCPSCitizenLogdb;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.SJED
                cnDefault = "Data Source=172.17.29.76,1453\DIGIGUJINST3;Initial Catalog=SJEDB;User ID=SJED;Password=atvt@sjeddb;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.PostMatric20182019
                cnDefault = "Data Source=172.17.29.76,1453\DIGIGUJINST3;Initial Catalog=PostMatric20182019;User ID=SJED;Password=atvt@sjeddb;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.PostMatric20172018
                cnDefault = "Data Source=172.17.29.76,1453\DIGIGUJINST3;Initial Catalog=SJEDB;User ID=SJED;Password=atvt@sjeddb;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.CitizenLogin
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSUserDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.RCPSCitizenDBTran
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSCitizendb;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.SchemePortal
                cnDefault = "Data Source=172.17.31.210,1440\ATVT;Initial Catalog=SchemePortal;User ID=a2zservice;Password=A2zservice@324;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.PanchayatDB
                '  cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=PanchayatDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
                cnDefault = "Data Source=172.17.30.151,1433;Initial Catalog=PanchayatDB;User ID=agri;Password=Atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.RCPSDB
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.GramPanchayatDB
                '  cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=PanchayatDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
                cnDefault = "Data Source=172.17.30.151,1433;Initial Catalog=GramPanchayatDB;User ID=agri;Password=Atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.CommonDBSimpleMode
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=CommonDBSimpleMode;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
            Case enumDBGroup.CommonDBPanchayat
                cnDefault = "Data Source=172.17.30.151,1433;Initial Catalog=CommonDBSimpleMode_PanchayatDB;User ID=CommonPanchayatDB;Password=Atvt@CommonPanchayatDB;language=british english;Connect Timeout=0;Pooling=true"
            Case Else 'RCPSDB
                cnDefault = "Data Source=172.17.29.227,1433\DIGIGUJINST1;Initial Catalog=RCPSDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
        End Select
        Return cnDefault
    End Function

    ' local

    'Public Function NewConnectionString(ByVal dbGroup As enumDBGroup) As String
    '    Select Case dbGroup
    '        Case enumDBGroup.RCPSAdminDB
    '            cnDefault = "Data Source=10.154.2.54,1433\S16d;Initial Catalog=RCPSAdmindb;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.RCPSArchivalDB
    '            cnDefault = "Data Source=10.154.2.54,1433\S16d;Initial Catalog=RCPSDB;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.RCPSCitizenDB
    '            cnDefault = "Data Source=10.154.2.54,1433\S16d;Initial Catalog=RCPSDB;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.RCPSFileDB
    '            cnDefault = "Data Source=10.154.2.54,1433\S16d;Initial Catalog=RCPSDB;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.RCPSLogDB
    '            cnDefault = "Data Source=10.154.2.54,1433\S16d;Initial Catalog=RCPSDB;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"

    '        Case enumDBGroup.RCPSOfficeDB
    '            cnDefault = "Data Source=10.154.2.54,1433\S16d;Initial Catalog=RCPSDB;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.RCPSPhotoDB
    '            cnDefault = "Data Source=10.154.2.54,1433\S16d;Initial Catalog=RCPSDB;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.RCPSSMS 'RCPSPhotoDB
    '            cnDefault = "Data Source=10.154.2.54,1433\S16d;Initial Catalog=RCPSCitizenLogdb;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.RCPSDB
    '            cnDefault = "Data Source=10.154.2.54,1433\S16d;Initial Catalog=RCPSDB;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.SJED
    '            cnDefault = "Data Source=10.154.2.54,1433\S16d;Initial Catalog=SJEDB;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"
    '       Case enumDBGroup.PostMatric20182019
    '            cnDefault = "Data Source=172.17.29.76,1453\DIGIGUJINST3;Initial Catalog=PostMatric20182019;User ID=SJED;Password=atvt@sjeddb;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.PostMatric20172018
    '            cnDefault = "Data Source=172.17.29.76,1453\DIGIGUJINST3;Initial Catalog=SJEDB;User ID=SJED;Password=atvt@sjeddb;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.CitizenLogin
    '            cnDefault = "Data Source=10.154.2.54,1433\s16d;Initial Catalog=RCPSUserDB;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.RCPSCitizenDBTran
    '            cnDefault = "Data Source=10.154.2.54,1433\s16d;Initial Catalog=RCPSCitizendb;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"
    'Case enumDBGroup.SchemePortal
    '           cnDefault = "Data Source=10.154.2.54,1433\s16d;Initial Catalog=SchemePortal;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"
    '        Case Else
    '            cnDefault = "Data Source=10.154.2.54,1433\S16d;Initial Catalog=RCPSDB;User ID=sa;Password=sa@123;language=british english;Connect Timeout=0;Pooling=true"

    '    End Select
    '    Return cnDefault
    'End Function


    'staging
    'Public Function NewConnectionString(ByVal dbGroup As enumDBGroup) As String
    '    Select Case dbGroup
    '        Case enumDBGroup.RCPSAdminDB 'RCPSAdmindb
    '            cnDefault = "Data Source=172.17.29.228,1443\DIGIGUJINST2;Initial Catalog=RCPSAdmindb;User ID=rcps;Password=atvt@rcps;language=british english;Pooling=true"
    '        Case enumDBGroup.RCPSArchivalDB 'RCPSphotodbarchive
    '            cnDefault = "Data Source=172.17.29.228,1443\DIGIGUJINST2;Initial Catalog=RCPSphotodbarchive;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.RCPSCitizenDB 'RCPSDB
    '            cnDefault = "Data Source=172.17.29.228,1443\DIGIGUJINST2;Initial Catalog=RCPSDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.RCPSFileDB 'RCPSTableDB
    '            cnDefault = "Data Source=172.17.29.228,1443\DIGIGUJINST2;Initial Catalog=RCPSTableDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.RCPSLogDB 'RCPSLog
    '            cnDefault = "Data Source=172.17.29.228,1443\DIGIGUJINST2;Initial Catalog=RCPSLog;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.RCPSOfficeDB 'RCPSDB
    '            cnDefault = "Data Source=172.17.29.228,1443\DIGIGUJINST2;Initial Catalog=RCPSDB;User ID=rcps;Password=atvt@rcps;language=british english;Pooling=true"
    '        Case enumDBGroup.RCPSDisposeDB 'RCPSDisposeDB
    '            cnDefault = "Data Source=172.17.29.228,1443\DIGIGUJINST2;Initial Catalog=RCPSDisposeDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.RCPSPhotoDB 'RCPSPhotoDB
    '            cnDefault = "Data Source=172.17.29.228,1443\DIGIGUJINST2;Initial Catalog=RCPSPhotoDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
    '        Case enumDBGroup.SJED
    '            cnDefault = "Data Source=172.17.29.228,1443\DIGIGUJINST2;Initial Catalog=SJEDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
    '        Case Else 'RCPSDB
    '            cnDefault = "Data Source=172.17.29.228,1443\DIGIGUJINST2;Initial Catalog=RCPSDB;User ID=rcps;Password=atvt@rcps;language=british english;Connect Timeout=0;Pooling=true"
    '    End Select
    '    Return cnDefault
    'End Function
End Class
