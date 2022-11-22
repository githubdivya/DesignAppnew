Module General
    Public AddType As Integer
    Public SelectValueBank As Integer
    Public SelectValueBranch As Integer
    Public SchoolIdCommam As Integer
    Public Delegate Function DShowPanel(ByVal PanelId As Integer)
    Public DgShowPanel As DShowPanel
    Public Delegate Sub DBankBind()
    Public DgBankBind As DBankBind
    Public Delegate Sub DBranchBind()
    Public DgBranchBind As DBranchBind
    Public FlgIsLocal As Boolean
    Public ChkFlgSynchronization As Boolean
    Public ServerString As String

    Public Enum UserRoles As Short
        Super = 1
        Admin = 6
        Officer = 2
        Clerk = 3
        [Operator] = 4
        Employer = 5
    End Enum

    Public Enum Rights As Integer
        Add = 1
        Edit = 2
        Delete = 3
        Print = 4
        Copy = 5
        Export = 6
    End Enum
    Public Enum WeekDays As Integer
        Monday = 1
        Tuesday = 2
        Wednesday = 3
        Thursday = 4
        Friday = 5
        Saturday = 6
    End Enum

    Public Enum ActiveStatus As Short
        Active = 1
        InActive = 2
        All = 3
    End Enum
End Module
