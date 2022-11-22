Imports System.Math
Public Enum enmWebService
    Receipt = 1
    Audit = 2
    ConfigParam = 3
    Lookup = 4
    Location = 5
    Device = 6
    Attachment = 9
    FYear = 10
    HeadPo = 11
    Delivery = 12
    SMS = 13
    PendingMamlatdar = 14
    Receiving = 15
    Approve = 16
    Outward = 17
    Search = 18


    AffiWidow = 84
    AffiSolvancy = 95
    AffiReady = 85
    AffiRationCardComp = 96
    AffiRationCard = 86
    AffiNameChange = 97
    AffiLoan = 98
    AffiLeavingCerti = 99
    AffiIncomeNonCreamyLayer = 120
    AffiIncome = 83
    AffiHouse = 100
    AffiCaste = 87
    AffiBDChange = 101
    ArmLicence = 107
    HotelLicence = 92
    MPKBYAgency = 89
    NSCAgency = 90
    StampVendorLicence = 94
    WriterLicence = 93

    Cast = 8
    SCST = 65
    OBC = 64
    Income = 63
    NonCreamyLayer = 82
    EBC = 81
    ReligiouMinority = 79
    Residence = 66
    SeniorCitizen = 77
    PermDomicile = 76
    Character = 78
    Divorce = 331
    Remarriage = 332
    Widow = 80
    OldAge = 68
    Solvancy = 102
    Farmer = 19
    Nominee = 71
    NomineeDetail = 711
    ''' ----- for common
    Photo = 999
    SMSSend = 1000
    AffidaviteReports = 1001
    CertificateReports = 1002
    RenewalReports = 1004
    MisReports = 1005
    PrintMenu = 1003
    Menu = 1006
End Enum
    Public Enum enmApplicationMode
        Offline = 0
        Online = 1
    End Enum
    Public Enum enmParameterMode
        View = 0
        Insert = 1
        Update = 2
        Amend = 3
    End Enum
    Public Enum enmCustomRole
        IGR = 1
        IR = 2
        SR = 3
        CCRA = 4
        SS = 5
        DC = 6
        Clerk = 7
        [Operator] = 8
        Guest = 9
    End Enum
    Public Class cGlobal
        Public Shared Function Round100(ByVal amt As Double) As Double
            Dim I As Double
            Dim j As Double
            Dim tmpamt As Double
            tmpamt = amt
            amt = Round(amt, 0)
            I = amt - Int(amt / 100) * 100
            j = amt - I
            If I > 0 Or tmpamt > amt Then
                j = j + 100
            End If
            Round100 = j
        End Function

    End Class

