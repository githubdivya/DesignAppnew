Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Imports System
Imports System.Web
Imports DesignApp
Imports NICFrameWork.LibCommon
Imports Microsoft.ApplicationBlocks.Data

Public Class Scheme

    Inherits SchemeGeneral
#Region "Member Variable"

    'Scheme Registration Variables
    Private mSchemeCode As Integer = 0
    Private mDeptID As Integer = 0
    Private mHODID As Integer = 0
    Private mSectorID As Integer = 0
    Private mSubSector As String = String.Empty
    Private mSchemeName As String = String.Empty
    Private mSchemeNameGu As String = String.Empty
    Private mCatid As Integer = 0
    Private mSchemeTypeId As Int16 = 0
    Private mSchemeEffDate As Nullable(Of Date)
    Private mSchemeValidDate As Nullable(Of Date)
    Private mStatus As Boolean = False
    Private mScTargetArea As String = String.Empty
    Private mDeptStack As ArrayList
    Private mdServiceType As Integer = 0

    Private mRCPSACT As Boolean = False

    Private mSddays As Int16 = 0
    Private mSdguj As String = String.Empty
    Private mSdeng As String = String.Empty

    Private mGRAdays As Int16 = 0
    Private mGRAguj As String = String.Empty
    Private mGRAeng As String = String.Empty

    Private mApp1days As Int16 = 0
    Private mApp1guj As String = String.Empty
    Private mApp1eng As String = String.Empty

    Private mApp2days As Int16 = 0
    Private mApp2guj As String = String.Empty
    Private mApp2eng As String = String.Empty

    Private mUserId As Integer = 0
    Private mOfficeId As Integer = 0
    'Scheme Implementing Body Variables

    Private mDesigId As Integer = 0
    Private mTalukaCd As String = String.Empty
    Private mDistCd As String = String.Empty
    Private mOfficeTypeAt As String = String.Empty
    Private mOfficeTYpeId As Integer = 0
    Private mOfficeTypeDeptId As Integer = 0
    Private mAddress As String = String.Empty
    Private mMileStone As String = String.Empty
    Private mPhoneO1 As String = String.Empty
    Private mPhoneO2 As String = String.Empty
    Private mGSWAN As String = String.Empty
    Private mPhoneR As String = String.Empty
    Private mMobile As String = String.Empty
    'Scheme Sponsored variables


    'Scheme General Parameter variables
    Private mConDays As String = String.Empty
    Private mGender As String = String.Empty

    Private mAgeForm As Integer = 0
    Private mAgeTo As Integer = 0
    Private mNationality As String = String.Empty
    Private mIncomeGrID As Integer = 0
    Private mOccupID As Integer = 0
    Private mEduID As Integer = 0
    Private mGradeId As Integer = 0
    Private mTrial As Integer = 0
    Private mNoFamilyMembers As Integer = 0
    Private mSocioEcoID As Int32 = 0
    Private mReligionId As Integer = 0
    Private mScAssValue As Integer = 0
    Private mGenCaste As Integer = 0
    Private mIndIncLimit As Decimal = 0.0
    Private mFamIncLimit As Decimal = 0.0

    'Scheme Applicable Variables
    Private mScAppTo As ArrayList
    Private mScAppArea As ArrayList

    'Scheme Budgetary Parameter variabels
    Private mBudgSecID As String = String.Empty
    Private mBudgDemNo As String = String.Empty
    Private mBudgMajorHead As String = String.Empty
    Private mBudgSubMajorHead As String = String.Empty
    Private mBudgMinorHead As String = String.Empty
    Private mBudgSubHead As String = String.Empty
    Private mBudgObjHead As String = String.Empty
    Private mBudgSchemeCode As String = String.Empty
    Private mSchemePlan As Char = String.Empty

    'Scheme BenfitType variables
    Private mBenefits As String = String.Empty
    Private mBenifitsGuj As String = String.Empty

    Private mScBFType As ArrayList

    'Scheme Details variables
    Private mGistOfScheme As String = String.Empty
    Private mGistOfSchemeEn As String = String.Empty
    Private mGistkeyword As String = String.Empty
    Private mRemark As String = String.Empty

    'Scheme Appliaction form variables
    Private mAppFormType As String = String.Empty
    Private mAppFormCost As Decimal = 0.0
    Private mAppFormSubTo As String = String.Empty
    Private mAppFormAvaiFrom As String = String.Empty

    Private mFormId As Int64 = 0
    Private mAttachment As ArrayList

    'Scheme ACT & GR variables
    Private mScAct As ArrayList
    Private mScGR As ArrayList




    Private mCasteID As Integer = 0


    Private mScShortName As String = String.Empty



    'Private mSchemeBFTID As Integer = 0
    Private mSchemePhoto As Image = Nothing
    Private mScBFPhoto As Image = Nothing


#End Region
#Region "Property"
    Public Property SchemeCode() As Integer
        Get
            Return mSchemeCode
        End Get
        Set(ByVal value As Integer)
            mSchemeCode = value
        End Set
    End Property
    Public Property DeptID() As Integer
        Get
            Return mDeptID
        End Get
        Set(ByVal value As Integer)
            mDeptID = value
        End Set
    End Property
    Public Property HODID() As Integer
        Get
            Return mHODID
        End Get
        Set(ByVal value As Integer)
            mHODID = value
        End Set
    End Property
    Public Property DeptStack() As ArrayList
        Get
            Return mDeptStack
        End Get
        Set(ByVal value As ArrayList)
            mDeptStack = value
        End Set
    End Property
    Public Property Religion() As Integer
        Get
            Return mReligionId
        End Get
        Set(ByVal value As Integer)
            mReligionId = value
        End Set
    End Property
    Public Property SchemeAssistanceValue() As Integer
        Get
            Return mScAssValue
        End Get
        Set(ByVal value As Integer)
            mScAssValue = value
        End Set
    End Property
    Public Property SectorID() As Integer
        Get
            Return mSectorID
        End Get
        Set(ByVal value As Integer)
            mSectorID = value
        End Set
    End Property
    Public Property GenCaste() As Integer
        Get
            Return mGenCaste
        End Get
        Set(ByVal value As Integer)
            mGenCaste = value
        End Set
    End Property
    Public Property SubSector() As String
        Get
            Return mSubSector
        End Get
        Set(ByVal value As String)
            mSubSector = value
        End Set
    End Property
    Public Property SchemeName() As String
        Get
            Return mSchemeName & " "
        End Get
        Set(ByVal value As String)
            mSchemeName = value
        End Set
    End Property

    Public Property SchemeNameGu() As String
        Get
            Return mSchemeNameGu & " "
        End Get
        Set(ByVal value As String)
            mSchemeNameGu = value
        End Set
    End Property

    Public Property DesigID() As Integer
        Get
            Return mDesigId
        End Get
        Set(ByVal value As Integer)
            mDesigId = value
        End Set
    End Property
    Public Property TalukaCd() As String
        Get
            Return mTalukaCd
        End Get
        Set(ByVal value As String)
            mTalukaCd = value
        End Set
    End Property
    Public Property DistCd() As String
        Get
            Return mDistCd
        End Get
        Set(ByVal value As String)
            mDistCd = value
        End Set
    End Property
    Public Property OfficeTypeAt() As String
        Get
            Return mOfficeTypeAt
        End Get
        Set(ByVal value As String)
            mOfficeTypeAt = value
        End Set
    End Property
    Public Property OfficeTypeDeptId() As Integer
        Get
            Return mOfficeTypeDeptId
        End Get
        Set(ByVal value As Integer)
            mOfficeTypeDeptId = value
        End Set
    End Property
    Public Property OfficeTypeId() As Integer
        Get
            Return mOfficeTYpeId
        End Get
        Set(ByVal value As Integer)
            mOfficeTYpeId = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return mAddress
        End Get
        Set(ByVal value As String)
            mAddress = value
        End Set
    End Property
    Public Property MileStone() As String
        Get
            Return mMileStone
        End Get
        Set(ByVal value As String)
            mMileStone = value
        End Set
    End Property
    Public Property PhoneO1() As String
        Get
            Return mPhoneO1
        End Get
        Set(ByVal value As String)
            mPhoneO1 = value
        End Set
    End Property
    Public Property PhoneO2() As String
        Get
            Return mPhoneO2
        End Get
        Set(ByVal value As String)
            mPhoneO2 = value
        End Set
    End Property
    Public Property GSWAN() As String
        Get
            Return mGSWAN
        End Get
        Set(ByVal value As String)
            mGSWAN = value
        End Set
    End Property
    Public Property PhoneR() As String
        Get
            Return mPhoneR
        End Get
        Set(ByVal value As String)
            mPhoneR = value
        End Set
    End Property
    Public Property Mobile() As String
        Get
            Return mMobile
        End Get
        Set(ByVal value As String)
            mMobile = value
        End Set
    End Property
    Public Property ConDays() As String
        Get
            Return mConDays
        End Get
        Set(ByVal value As String)
            mConDays = value
        End Set
    End Property
    Public Property ReligionId() As Integer
        Get
            Return mReligionId
        End Get
        Set(ByVal value As Integer)
            mReligionId = value
        End Set
    End Property
    Public Property CasteID() As Integer
        Get
            Return mCasteID
        End Get
        Set(ByVal value As Integer)
            mCasteID = value
        End Set
    End Property
    Public Property Gender() As String
        Get
            Return mGender
        End Get
        Set(ByVal value As String)
            mGender = value
        End Set
    End Property
    Public Property SocioEcoId() As Int32
        Get
            Return mSocioEcoID
        End Get
        Set(ByVal value As Int32)
            mSocioEcoID = value
        End Set
    End Property
    Public Property AgeForm() As Integer
        Get
            Return mAgeForm
        End Get
        Set(ByVal value As Integer)
            mAgeForm = value
        End Set
    End Property
    Public Property AgeTo() As Integer
        Get
            Return mAgeTo
        End Get
        Set(ByVal value As Integer)
            mAgeTo = value
        End Set
    End Property
    Public Property Nationality() As String
        Get
            Return mNationality
        End Get
        Set(ByVal value As String)
            mNationality = value
        End Set
    End Property
    Public Property incomeGrID() As Integer
        Get
            Return mIncomeGrID
        End Get
        Set(ByVal value As Integer)
            mIncomeGrID = value
        End Set
    End Property
    Public Property OccupationId() As Integer
        Get
            Return mOccupID
        End Get
        Set(ByVal value As Integer)
            mOccupID = value
        End Set
    End Property
    Public Property IndividualIncome() As Decimal
        Get
            Return mIndIncLimit
        End Get
        Set(ByVal value As Decimal)
            mIndIncLimit = value
        End Set
    End Property
    Public Property FamilyIncome() As Decimal
        Get
            Return mFamIncLimit
        End Get
        Set(ByVal value As Decimal)
            mFamIncLimit = value
        End Set
    End Property
    Public Property EducaionID() As Integer
        Get
            Return mEduID
        End Get
        Set(ByVal value As Integer)
            mEduID = value
        End Set
    End Property
    Public Property GradeId() As Integer
        Get
            Return mGradeId
        End Get
        Set(ByVal value As Integer)
            mGradeId = value
        End Set
    End Property
    Public Property Trial() As Decimal
        Get
            Return mTrial
        End Get
        Set(ByVal value As Decimal)
            mTrial = value
        End Set
    End Property
    Public Property NoFamilyMemebers() As Integer
        Get
            Return mNoFamilyMembers
        End Get
        Set(ByVal value As Integer)
            mNoFamilyMembers = value
        End Set
    End Property
    Public Property ScAppTo() As ArrayList
        Get
            Return mScAppTo
        End Get
        Set(ByVal value As ArrayList)
            mScAppTo = value
        End Set
    End Property
    Public Property ScAppArea() As ArrayList
        Get
            Return mScAppArea
        End Get
        Set(ByVal value As ArrayList)
            mScAppArea = value
        End Set
    End Property
    Public Property BudgsecID() As String
        Get
            Return mBudgSecID
        End Get
        Set(ByVal value As String)
            mBudgSecID = value
        End Set
    End Property
    Public Property BudgDemNo() As String
        Get
            Return mBudgDemNo
        End Get
        Set(ByVal value As String)
            mBudgDemNo = value
        End Set
    End Property
    Public Property BudgMajorHead() As String
        Get
            Return mBudgMajorHead
        End Get
        Set(ByVal value As String)
            mBudgMajorHead = value
        End Set
    End Property
    Public Property BudgSubMajorHead() As String
        Get
            Return mBudgSubMajorHead
        End Get
        Set(ByVal value As String)
            mBudgSubMajorHead = value
        End Set
    End Property
    Public Property BudgMinorHead() As String
        Get
            Return mBudgMinorHead
        End Get
        Set(ByVal value As String)
            mBudgMinorHead = value
        End Set
    End Property
    Public Property BudgSubHead() As String
        Get
            Return mBudgSubHead
        End Get
        Set(ByVal value As String)
            mBudgSubHead = value
        End Set
    End Property
    Public Property BudgObjHead() As String
        Get
            Return mBudgObjHead
        End Get
        Set(ByVal value As String)
            mBudgObjHead = value
        End Set
    End Property
    Public Property BudgschemeCode() As String
        Get
            Return mBudgSchemeCode
        End Get
        Set(ByVal value As String)
            mBudgSchemeCode = value
        End Set
    End Property
    Public Property AppFormType() As String
        Get
            Return mAppFormType
        End Get
        Set(ByVal value As String)
            mAppFormType = value
        End Set
    End Property
    Public Property AppFormSubTo() As String
        Get
            Return mAppFormSubTo
        End Get
        Set(ByVal value As String)
            mAppFormSubTo = value
        End Set
    End Property
    Public Property AppFormCost() As Decimal
        Get
            Return mAppFormCost
        End Get
        Set(ByVal value As Decimal)
            mAppFormCost = value
        End Set
    End Property
    Public Property ScBFType() As ArrayList
        Get
            Return mScBFType
        End Get
        Set(ByVal value As ArrayList)
            mScBFType = value
        End Set
    End Property
    Public Property Benifits() As String
        Get
            Return mBenefits
        End Get
        Set(ByVal value As String)
            mBenefits = value
        End Set
    End Property
    Public Property BenifitsGuj() As String
        Get
            Return mBenifitsGuj
        End Get
        Set(ByVal value As String)
            mBenifitsGuj = value
        End Set
    End Property
    Public Property GistOfScheme() As String
        Get
            Return mGistOfScheme
        End Get
        Set(ByVal value As String)
            mGistOfScheme = value
        End Set
    End Property
    Public Property GistOfSchemeEn() As String
        Get
            Return mGistOfSchemeEn
        End Get
        Set(ByVal value As String)
            mGistOfSchemeEn = value
        End Set
    End Property
    Public Property Gistkeyword() As String
        Get
            Return mGistkeyword
        End Get
        Set(ByVal value As String)
            mGistkeyword = value
        End Set
    End Property
    Public Property SchemeEffDate() As Nullable(Of Date)
        Get
            Return mSchemeEffDate
        End Get
        Set(ByVal value As Nullable(Of Date))
            mSchemeEffDate = value
        End Set
    End Property
    Public Property SchemeValidDate() As Nullable(Of Date)
        Get
            Return mSchemeValidDate
        End Get
        Set(ByVal value As Nullable(Of Date))
            mSchemeValidDate = value
        End Set
    End Property
    Public Property status() As Boolean
        Get
            Return mStatus
        End Get
        Set(ByVal value As Boolean)
            mStatus = value
        End Set
    End Property
    Public Property RCPSACT() As Boolean
        Get
            Return mRCPSACT
        End Get
        Set(ByVal value As Boolean)
            mRCPSACT = value
        End Set
    End Property
    Public Property Sddays() As Int64
        Get
            Return mSddays
        End Get
        Set(ByVal value As Int64)
            mSddays = value
        End Set
    End Property
    Public Property Sdguj() As String
        Get
            Return mSdguj
        End Get
        Set(ByVal value As String)
            mSdguj = value
        End Set
    End Property
    Public Property Sdeng() As String
        Get
            Return mSdeng
        End Get
        Set(ByVal value As String)
            mSdeng = value
        End Set
    End Property
    Public Property GRAdays() As Int64
        Get
            Return mGRAdays
        End Get
        Set(ByVal value As Int64)
            mGRAdays = value
        End Set
    End Property
    Public Property GRAguj() As String
        Get
            Return mGRAguj
        End Get
        Set(ByVal value As String)
            mGRAguj = value
        End Set
    End Property
    Public Property GRAeng() As String
        Get
            Return mGRAeng
        End Get
        Set(ByVal value As String)
            mGRAeng = value
        End Set
    End Property
    Public Property App1days() As Int64
        Get
            Return mApp1days
        End Get
        Set(ByVal value As Int64)
            mApp1days = value
        End Set
    End Property
    Public Property App1guj() As String
        Get
            Return mApp1guj
        End Get
        Set(ByVal value As String)
            mApp1guj = value
        End Set
    End Property
    Public Property App1eng() As String
        Get
            Return mApp1eng
        End Get
        Set(ByVal value As String)
            mApp1eng = value
        End Set
    End Property
    Public Property App2days() As Int64
        Get
            Return mApp2days
        End Get
        Set(ByVal value As Int64)
            mApp2days = value
        End Set
    End Property
    Public Property App2guj() As String
        Get
            Return mApp2guj
        End Get
        Set(ByVal value As String)
            mApp2guj = value
        End Set
    End Property
    Public Property App2eng() As String
        Get
            Return mApp2eng
        End Get
        Set(ByVal value As String)
            mApp2eng = value
        End Set
    End Property
    Public Property UserId() As Integer
        Get
            Return mUserId
        End Get
        Set(ByVal value As Integer)
            mUserId = value
        End Set
    End Property
    Public Property OfficeId() As Integer
        Get
            Return mOfficeId
        End Get
        Set(ByVal value As Integer)
            mOfficeId = value
        End Set
    End Property
    Public Property Remark() As String
        Get
            Return mRemark
        End Get
        Set(ByVal value As String)
            mRemark = value
        End Set
    End Property
    Public Property FormId() As Int64
        Get
            Return mFormId
        End Get
        Set(ByVal value As Int64)
            mFormId = value
        End Set
    End Property
    Public Property dServiceType() As String
        Get
            Return mdServiceType
        End Get
        Set(ByVal value As String)
            mdServiceType = value
        End Set
    End Property
    Public Property ScTargetArea() As String
        Get
            Return mScTargetArea
        End Get
        Set(ByVal value As String)
            mScTargetArea = value
        End Set
    End Property
    Public Property AppFormAvaiFrom() As String
        Get
            Return mAppFormAvaiFrom
        End Get
        Set(ByVal value As String)
            mAppFormAvaiFrom = value
        End Set
    End Property

    Public Property CatId() As Integer
        Get
            Return mCatid
        End Get
        Set(ByVal value As Integer)
            mCatid = value
        End Set
    End Property
    Public Property SchemePlan() As Char
        Get
            Return mSchemePlan
        End Get
        Set(ByVal value As Char)
            mSchemePlan = value
        End Set
    End Property
    Public Property SchemeTypeId() As Int16
        Get
            Return mSchemeTypeId
        End Get
        Set(ByVal value As Int16)
            mSchemeTypeId = value
        End Set
    End Property
    Public Property SchemeAct() As ArrayList
        Get
            Return mScAct
        End Get
        Set(ByVal value As ArrayList)
            mScAct = value
        End Set
    End Property
    Public Property SchemeGR() As ArrayList
        Get
            Return mScGR
        End Get
        Set(ByVal value As ArrayList)
            mScGR = value
        End Set
    End Property
    Public Property Attachment() As ArrayList
        Get
            Return mAttachment
        End Get
        Set(ByVal value As ArrayList)
            mAttachment = value
        End Set
    End Property

#End Region
#Region "Fill DropDown Functions"
    Public Sub FillDept(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---વિભાગ પસંદ કરો---"
            FillDropDown(DDControl, FillDept(), "Dept", "DeptId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillDept(), "DeptE", "DeptId", strTemp)

        End If
    End Sub
    Public Sub FillDeptFrm1(ByRef DDControl As DropDownList, ByRef flag As String)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---વિભાગ પસંદ કરો---"
            FillDropDown(DDControl, FillDeptFrm1(flag), "Dept", "DeptId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillDeptFrm1(flag), "DeptE", "DeptId", strTemp)

        End If
    End Sub
    Public Sub FillGender(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો---"
            FillDropDown(DDControl, FillGender(), "GenderE", "GenderCode", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillGender(), "GenderE", "GenderCode", strTemp)

        End If
    End Sub
    Public Sub FillGenderfrm1(ByRef DDControl As DropDownList, ByRef flag As String)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો---"
            FillDropDown(DDControl, FillGenderfrm1(flag), "GenderE", "GenderCode", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillGenderfrm1(flag), "GenderE", "GenderCode", strTemp)

        End If
    End Sub
    Public Sub FillLifeEvents(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો---"
            FillDropDown(DDControl, FillEvents(), "EventNameE", "EventId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillEvents(), "EventNameE", "EventId", strTemp)

        End If
    End Sub
    Public Sub FillDept1(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---બધા વિભાગ ---"
            FillDropDown(DDControl, FillDept(), "Dept", "DeptId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillDept(), "DeptE", "DeptId", strTemp)

        End If

    End Sub

    Public Sub FillOffice(ByRef DDControl As DropDownList)
        FillDropDown(DDControl, FillOffice(), "Office", "OfficeId", "--- Select ---")
    End Sub
    Public Sub FillSector(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---સેકટર પસંદ કરો ---"
            FillDropDown(DDControl, FillSector(), "Sector", "SectorId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillSector(), "SectorE", "SectorId", strTemp)

        End If
    End Sub
    Public Sub FillSectorfrm1(ByRef DDControl As DropDownList, ByRef flag As String)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---સેકટર પસંદ કરો ---"
            FillDropDown(DDControl, FillSectorfrm1(flag), "Sector", "SectorId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillSectorfrm1(flag), "SectorE", "SectorId", strTemp)

        End If
    End Sub
    Public Sub FillHOD(ByRef DDControl As DropDownList, ByVal deptid As Integer, ByVal OfficeID As Integer)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "--- પસંદ કરો ---"
            FillDropDown(DDControl, FillHOD(deptid, OfficeID), "NameGu", "HODid", strTemp)
        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillHOD(deptid, OfficeID), "NameEn", "HODid", strTemp)

        End If
    End Sub
    Public Sub FillScType(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillScType(), "type", "SchemeTypeId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillScType(), "typeE", "SchemeTypeId", strTemp)

        End If

    End Sub
    Public Sub FillDesignation(ByRef DDControl As DropDownList)
        FillDropDown(DDControl, FillDesignation(), "Designation", "DesigId", "--- Select ---")
    End Sub
    Public Sub FillScCategory(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillScCategory(), "Category", "CatId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillScCategory(), "CategoryE", "CatId", strTemp)

        End If

    End Sub
    Public Sub FillIncomeGr(ByRef DDControl As DropDownList)
        FillDropDown1(DDControl, FillIncomeGr())

    End Sub
    Public Sub FillOccupation(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillOccupation(), "Occupation", "OccupId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillOccupation(), "Occupation_e", "OccupId", strTemp)

        End If

    End Sub
    Public Sub FillOccupation1(ByRef DDControl As DropDownList)
        FillDropDown2(DDControl, FillOccupation(), "Occupation", "Occup_cd")
    End Sub
    Public Sub FillEducation(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillEducation(), "education", "EduId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillEducation(), "education_e", "EduId", strTemp)

        End If

    End Sub
    Public Sub FillEducation1(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillEducation(), "education", "Edu_cd", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillEducation(), "education_e", "Edu_cd", strTemp)

        End If

    End Sub
    Public Sub FillScAppArea(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillScAppArea(), "Area", "AreaCode", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillScAppArea(), "AreaE", "AreaCode", strTemp)

        End If

    End Sub
    Public Sub FillGrade(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
        Else
            strTemp = "--- Select ---"
        End If

        FillDropDown(DDControl, FillGrade(), "Grade", "GradeId", strTemp)
    End Sub
    Public Sub FillSocioEco(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillSocioEco(), "SocioEcoPera", "SocioEcoId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillSocioEco(), "SocioEcoPeraE", "SocioEcoId", strTemp)
        End If

    End Sub
    Public Sub FillSocioEco1(ByRef DDControl As DropDownList)
        If Session("MyCulture") = "gu" Then
            FillDropDown2(DDControl, FillSocioEco(), "SocioEcoPera", "SocioEcoId")

        Else
            FillDropDown2(DDControl, FillSocioEco(), "SocioEcoPeraE", "SocioEcoId")

        End If
    End Sub
    Public Sub FillSponsored(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillSponsored(), "Sponsored", "SponsoredById", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillSponsored(), "SponsoredE", "SponsoredById", strTemp)

        End If

    End Sub
    Public Sub FillCaste(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillCaste(), "CasteE", "CasteId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillCaste(), "CasteG", "CasteId", strTemp)

        End If

    End Sub
    Public Sub FillCaste1frm1(ByRef DDControl As DropDownList, ByRef flag As String)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillCastefrm1(flag), "CasteE", "CasteCd", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillCastefrm1(flag), "CasteG", "CasteCd", strTemp)

        End If

    End Sub
    Public Sub FillCaste1(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillCaste(), "CasteE", "CasteCd", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillCaste(), "CasteG", "CasteCd", strTemp)

        End If

    End Sub
    Public Sub FillReligion(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillReligion(), "Religion", "ReligionId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillReligion(), "ReligionE", "ReligionId", strTemp)

        End If

    End Sub
    Public Sub FillReligion1(ByRef DDControl As DropDownList)
        FillDropDown2(DDControl, FillReligion(), "Religion", "ReligionId")
    End Sub
    Public Sub FillBFType(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillBFType(), "BenefitType", "SchemeBFTId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillBFType(), "BenefitTypeE", "SchemeBFTId", strTemp)

        End If

    End Sub
    Public Sub FillScAppTo(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillScAppTo(), "SchemeAppTo", "SchemeAppToId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillScAppTo(), "SchemeAppToE", "SchemeAppToId", strTemp)

        End If

    End Sub
    Public Sub FillAttachment(ByRef DDControl As DropDownList)
        Dim strTemp As String
        If Session("MyCulture") = "gu" Then
            strTemp = "---પસંદ કરો ---"
            FillDropDown(DDControl, FillScAppTo(), "AttachDetail", "AttachId", strTemp)

        Else
            strTemp = "--- Select ---"
            FillDropDown(DDControl, FillScAppTo(), "AttachDetailE", "AttachId", strTemp)

        End If

    End Sub
    'Public Sub FillDept(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillDept(), "Dept", "DeptId", "--- Select ---")
    'End Sub
    'Public Sub FillDept1(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillDept(), "Dept", "DeptId", "--- All ---")
    'End Sub
    'Public Sub FillOffice(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillOffice(), "Office", "OfficeId", "--- Select ---")
    'End Sub
    'Public Sub FillSector(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillSector(), "Sector", "SectorId", "--- Select ---")
    'End Sub
    'Public Sub FillScType(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillScType(), "type", "SchemeTypeId", "--- Select ---")
    'End Sub
    'Public Sub FillDesignation(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillDesignation(), "Designation", "DesigId", "--- Select ---")
    'End Sub
    'Public Sub FillScCategory(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillScCategory(), "Category", "CatId", "--- Select ---")
    'End Sub
    'Public Sub FillIncomeGr(ByRef DDControl As DropDownList)
    '    FillDropDown1(DDControl, FillIncomeGr())
    'End Sub
    'Public Sub FillOccupation(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillOccupation(), "Occupation", "OccupId", "--- Select ---")
    'End Sub
    'Public Sub FillOccupation1(ByRef DDControl As DropDownList)
    '    FillDropDown2(DDControl, FillOccupation(), "Occupation", "Occup_cd")
    'End Sub
    'Public Sub FillEducation(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillEducation(), "education", "EduId", "--- Select ---")
    'End Sub
    'Public Sub FillEducation1(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillEducation(), "education", "Edu_cd", "--- Select ---")
    'End Sub
    'Public Sub FillScAppArea(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillScAppArea(), "Area", "AreaCode", "--- Select ---")
    'End Sub
    'Public Sub FillGrade(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillGrade(), "Grade", "GradeId", "--- Select ---")
    'End Sub
    'Public Sub FillSocioEco(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillSocioEco(), "SocioEcoPera", "SocioEcoId", "--- Select ---")
    'End Sub
    'Public Sub FillSocioEco1(ByRef DDControl As DropDownList)
    '    FillDropDown2(DDControl, FillSocioEco(), "SocioEcoPera", "SocioEcoId")
    'End Sub
    'Public Sub FillSponsored(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillSponsored(), "Sponsored", "SponsoredById", "--- Select ---")
    'End Sub
    'Public Sub FillCaste(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillCaste(), "CasteE", "CasteId", "--- Select ---")
    'End Sub
    'Public Sub FillCaste1(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillCaste(), "CasteE", "CasteCd", "--- Select ---")
    'End Sub
    'Public Sub FillReligion(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillReligion(), "Religion", "ReligionId", "--- Select ---")
    'End Sub
    'Public Sub FillReligion1(ByRef DDControl As DropDownList)
    '    FillDropDown2(DDControl, FillReligion(), "Religion", "ReligionId")
    'End Sub
    'Public Sub FillBFType(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillBFType(), "BenefitType", "SchemeBFTId", "--- Select ---")
    'End Sub
    'Public Sub FillScAppTo(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillScAppTo(), "SchemeAppTo", "SchemeAppToId", "--- Select ---")
    'End Sub
    'Public Sub FillAttachment(ByRef DDControl As DropDownList)
    '    FillDropDown(DDControl, FillScAppTo(), "AttachDetail", "AttachId", "--- Select ---")
    'End Sub

    Public Sub FillOfficeType(ByRef DDControl As DropDownList)
        FillDropDownOfficeType(DDControl, FillOfficeType())
    End Sub
    Public Function FillDistrict() As Data.DataTable
        Dim sql As String
        sql = "Select_District"
        Return FillRecords(sql, CmdType.StoredProcedure)
    End Function
    Public Sub FillDistrict(ByRef DDControl As DropDownList)
        FillDropDown(DDControl, FillDistrict(), "district", "dist_cd", "--- Select ---")
    End Sub
    Public Function FillTaluka(ByVal id As Integer) As Data.DataTable
        Dim sql As String
        Dim param(0) As SqlParameter
        sql = "Select_Taluka"
        param(0) = New SqlParameter("@dist_cd", id)
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Sub FillTaluka(ByRef DDControl As DropDownList, ByVal id As Integer)
        FillDropDown(DDControl, FillTaluka(id), "taluka", "taluka_cd", "--- Select ---")
    End Sub
    Public Function FillReligion() As Data.DataTable
        Dim sql As String
        sql = "GetReligion"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillAttachment() As Data.DataTable

        Return FillRecords("GetAttachment", CmdType.StoredProcedure)
    End Function
    Public Function FillCaste() As Data.DataTable
        Dim sql As String
        sql = "GetCaste"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillCastefrm1(flag) As Data.DataTable
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@flag", flag)
        Dim sql As String
        sql = "GetCaste"
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function FillSponsored() As Data.DataTable
        Dim sql As String
        sql = "Select_SponsoredByMast"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillSocioEco() As Data.DataTable
        Dim sql As String
        sql = "Select_SocioEcoMast"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillBFType() As Data.DataTable
        Dim sql As String
        sql = "Select_SchemeBFTMast"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillAct(ByVal deptid As Integer) As Data.DataTable
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@deptid", deptid)
        Dim sql As String
        sql = "Select_ActSections"
        Return FillRecords(sql, CmdType.StoredProcedure, param)
        'Dim sql As String
        'sql = "Select_ActSections"
        'Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillGR(ByVal deptid As Integer, ByVal Flag As Integer) As Data.DataTable
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@deptid", deptid)
        param(1) = New SqlParameter("@Flag", Flag)
        Dim sql As String
        sql = "Select_GROrders"
        Return FillRecords(sql, CmdType.StoredProcedure, param)

    End Function
    Public Function FillGRgridData(ByVal deptid As Integer, ByVal Flag As Integer, ByVal ordertype As Integer) As Data.DataTable
        Dim param As SqlParameter() = New SqlParameter(2) {}
        param(0) = New SqlParameter("@deptid", deptid)
        param(1) = New SqlParameter("@Flag", Flag)
        param(2) = New SqlParameter("@ordertype", ordertype)
        Dim sql As String
        sql = "Select_GROrders"
        Return FillRecords(sql, CmdType.StoredProcedure, param)

    End Function
    Public Function gridforGrActdata(ByVal schemecode As Integer) As Data.DataTable
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@SchemeCode", schemecode)

        Dim sql As String
        sql = "get_GRActData"
        Return FillRecords(sql, CmdType.StoredProcedure, param)

    End Function
    Public Function get_LicenceGRActData(ByVal schemecode As Integer) As Data.DataTable
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@SchemeCode", schemecode)

        Dim sql As String
        sql = "get_LicenceGRActData"
        Return FillRecords(sql, CmdType.StoredProcedure, param)

    End Function

    Public Function DepartmentSelectById() As Data.DataTable
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@Id", Session("departmentid"))

        Dim sql As String
        sql = "Select_DeptMast"
        Return FillRecords(sql, CmdType.StoredProcedure, param)

    End Function

    Public Function FillGender() As Data.DataTable
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@gendercode", Session("gendercode"))

        Dim sql As String
        sql = "Select_GenderMaster"
        Return FillRecords(sql, CmdType.StoredProcedure, param)

    End Function
    Public Function FillGenderfrm1(flag) As Data.DataTable
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@gendercode", Session("gendercode"))
        param(1) = New SqlParameter("@flag", flag)

        Dim sql As String
        sql = "Select_GenderMaster"
        Return FillRecords(sql, CmdType.StoredProcedure, param)

    End Function

    Public Function FillEvents() As Data.DataTable
        Dim sql As String
        sql = "Select_LifeEventsMaster"
        Return FillRecords(sql, CmdType.StoredProcedure)

    End Function

    Public Function FillOfficeType() As Data.DataTable
        Dim sql As String
        sql = "Select_OfficeType"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillGrade() As Data.DataTable
        Dim sql As String
        sql = "Select_GradeMast"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillEducation() As Data.DataTable
        Dim sql As String
        sql = "Select_Education"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillOccupation() As Data.DataTable
        Dim sql As String
        sql = "Select_Occupation"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillIncomeGr() As Data.DataTable
        Dim sql As String
        sql = "Select_IncomeGrMast"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillDept() As Data.DataTable
        Dim sql As String
        sql = "Select_DeptMast"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillDeptfrm1(flag) As Data.DataTable
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@flag", flag)
        Dim sql As String
        sql = "Select_DeptMast"
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function FillOffice() As Data.DataTable
        Dim sql As String
        sql = "Select_OfficeMast"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillScCategory() As Data.DataTable
        Dim sql As String
        sql = "Select_Category"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillScType() As Data.DataTable
        Dim sql As String
        sql = "Select_SchemeTypeMast"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillSector() As Data.DataTable
        Dim sql As String
        sql = "Select_SectorMast"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillSectorfrm1(flag As String) As Data.DataTable
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@flag", flag)

        Dim sql As String
        sql = "Select_SectorMast"
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function FillHOD(ByVal deptid As Integer, ByVal OfficeID As Integer) As Data.DataTable
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@deptid", deptid)
        param(1) = New SqlParameter("@OfficeID", OfficeID)
        Dim sql As String
        sql = "Select_HODMast"
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function FillDesignation() As Data.DataTable
        Dim sql As String
        sql = "Select_Designation"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function FillScAppArea() As Data.DataTable
        Dim sql As String
        sql = "Select_SchemeAppAreaMast"
        Return FillRecords(sql, CmdType.QueryText)
    End Function

    Public Function FillScAppTo() As Data.DataTable
        Dim sql As String
        sql = "Select_SchemeAppTo_byId"
        Return FillRecords(sql, CmdType.QueryText)
    End Function
    Public Function GetDeptStack(ByVal SchemeCode As Integer) As DataTable
        Dim sql As String
        Dim param(0) As SqlParameter
        sql = "Select_DeptStack"
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function GetScBFT(ByVal SchemeCode As Integer) As DataTable
        Dim sql As String
        Dim param(0) As SqlParameter
        sql = "Select_SchemeBFT"
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function GetScAppArea(ByVal SchemeCode As Integer) As DataTable
        Dim sql As String
        Dim param(0) As SqlParameter
        sql = "Select_SchemeAppArea"
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function GetScAppto(ByVal SchemeCode As Integer) As DataTable
        Dim sql As String
        Dim param(0) As SqlParameter
        sql = "Select_SchemeAppto_fill"
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function GetActTran(ByVal SchemeCode As Integer) As DataTable
        Dim sql As String
        Dim param(0) As SqlParameter
        sql = "Select_ActTran"
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function GetGRTran(ByVal SchemeCode As Integer) As DataTable
        Dim sql As String
        Dim param(0) As SqlParameter
        sql = "Select_GRTran"
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function

    Public Function GetLicenceAct(ByVal DepartmentLicenceID As Integer) As DataTable
        Dim sql As String
        Dim param(0) As SqlParameter
        sql = "SelectLicenceActMaster"
        param(0) = New SqlParameter("@DepartmentLicenceID", DepartmentLicenceID)
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function GetLicenceGr(ByVal DepartmentLicenceID As Integer) As DataTable
        Dim sql As String
        Dim param(0) As SqlParameter
        sql = "SelectLicenceGrMaster"
        param(0) = New SqlParameter("@DepartmentLicenceID", DepartmentLicenceID)
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function GetAttachTran(ByVal SchemeCode As Integer) As DataTable
        Dim sql As String
        Dim param(0) As SqlParameter
        sql = "Select_Attachment"
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function GetAttachTran_licence(ByVal LicenceId As Integer) As DataTable
        Dim sql As String
        Dim param(0) As SqlParameter
        sql = "Select_Licence"
        param(0) = New SqlParameter("@Id", LicenceId)
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function GetScOffDetail(ByVal id As Integer) As DataTable
        Dim param(0) As SqlParameter
        param(0) = New SqlParameter("@SchemeCode", id)
        Return FillRecords("GetScOfficeDetail", CmdType.StoredProcedure, param)
    End Function
    Public Function GetSponsoredBy(ByVal SchemeCode As Integer) As DataSet
        Dim sql As String
        Dim param(0) As SqlParameter
        sql = "Select_SponsoredBy"
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        Return FillRecords1(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function GetAppFeesCriteria(ByVal SchemeCode As Integer) As DataSet
        Dim sql As String
        Dim param(0) As SqlParameter
        'sql = "Select * from tblAppFeesCriteria where SchemeCode=@SchemeCode"
        sql = "Select_AppFeesCriteria"
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        Return FillRecords1(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function GetSponsoredBy1(ByVal SchemeCode As Integer) As DataTable
        Dim sql As String
        Dim param(0) As SqlParameter
        sql = "Select_SponsoredBy"
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        Return FillRecords(sql, CmdType.StoredProcedure, param)
    End Function
#End Region
#Region "Procedures & functions"
    Public Function AddScReg() As Integer
        Dim param As SqlParameter() = New SqlParameter(16) {}
        SetScRegParameter(param)
        Dim SchemeCode As Integer = Integer.Parse(ReturnValue("SaveScReg", CmdType.StoredProcedure, param).ToString())
        SaveDeptStack(SchemeCode)
        Return SchemeCode
    End Function
    Public Function ReturnFormId(ByVal SchemeCode As Integer) As Integer
        Dim FormId As Integer
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlClient.SqlParameter("@SchemeCode", SchemeCode)
        FormId = Integer.Parse(ReturnValue("GetFormId", CmdType.StoredProcedure, param))
        Return FormId
    End Function
    Public Function ReturnFormId_licence(ByVal LicenceId As Integer) As Integer
        Dim FormId As Integer
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlClient.SqlParameter("@LicenceId", LicenceId)
        FormId = Integer.Parse(ReturnValue("GetFormId_licence", CmdType.StoredProcedure, param))
        Return FormId
    End Function
    Public Sub UpdateScReg(ByVal SchemeCode As Integer)
        Dim param As SqlParameter() = New SqlParameter(16) {}
        SetScRegParameter(param)
        SaveDeptStack(SchemeCode)
        param(12) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("SaveScReg", CmdType.StoredProcedure, param)
    End Sub
    Public Sub AddScImp()
        Dim param As SqlParameter() = New SqlParameter(13) {}
        SetScConOfficeParameter(param)
        ExecuteCmd("SaveScImp1", CmdType.StoredProcedure, param)
    End Sub
    Public Sub UpdateScImp1(ByVal id As Integer)
        Dim param As SqlParameter() = New SqlParameter(14) {}
        SetScConOfficeParameter(param)
        param(14) = New SqlParameter("@ScConOfficeId", Data.SqlDbType.Int)
        param(14).Value = id
        ExecuteCmd("SaveScImp1", CmdType.StoredProcedure, param)
    End Sub
    Public Sub UpdateScImp(ByVal SchemeCode As Integer)
        Dim param As SqlParameter() = New SqlParameter(8) {}
        SetScImpParameter(param)
        'SetScConOfficeParameter(param)
        param(8) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("SaveScImp", CmdType.StoredProcedure, param)
    End Sub
    Public Sub DeleteConOffice(ByVal id As Integer)
        Dim sql As String = String.Empty
        sql = "Delete_SchemeContactOffice"
        Dim par() As SqlParameter = New SqlParameter(0) {}
        par(0) = New SqlParameter("@ScConOfficeId", id)
        ExecuteCmd(sql, CmdType.StoredProcedure, par)
    End Sub

    'Public Sub AddScBudgPara()
    '    Dim param As SqlParameter() = New SqlParameter(10) {}
    '    SetScRegParameter(param)
    '    ExecuteCmd("SaveScBudgPara", CmdType.StoredProcedure, param)
    'End Sub
    'Public Sub UpdateScBudgPara(ByVal SchemeCode As Integer)
    '    Dim param As SqlParameter() = New SqlParameter(10) {}
    '    SetScRegParameter(param)
    '    param(10) = New SqlParameter("@SchemeCode", SchemeCode)
    '    ExecuteCmd("SaveScBudgPara", CmdType.StoredProcedure, param)
    'End Sub
    Public Sub UpdateScGenPara(ByVal SchemeCode As Integer)
        Dim param As SqlParameter() = New SqlParameter(18) {}
        SetScGenParameter(param)
        param(18) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("SaveScGenPara", CmdType.StoredProcedure, param)
    End Sub
    Public Sub UpdateScGenPara_Licence(ByVal LicenceId As Integer)
        Dim param As SqlParameter() = New SqlParameter(18) {}
        SetScGenParameter(param)
        param(18) = New SqlParameter("@DepartmentLicenceID", LicenceId)
        ExecuteCmd("SaveScGenPara_Licence", CmdType.StoredProcedure, param)
    End Sub

    Public Sub SaveDeptStack(ByVal SchemeCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(2) {}
        par(0) = New SqlParameter("@SchemeCode", Data.SqlDbType.Int)
        par(1) = New SqlParameter("DeptId", Data.SqlDbType.Int)
        par(0).Value = SchemeCode
        For Each item As ListItem In DeptStack
            par(1).Value = Integer.Parse(item.Value)
            ExecuteCmd("SaveDeptStack", CmdType.StoredProcedure, par)
        Next
    End Sub
    Public Sub DeleteDeptStack(ByVal SchemeCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(2) {}
        par(0) = New SqlParameter("@SchemeCode", Data.SqlDbType.Int)
        par(0).Value = SchemeCode
        ExecuteCmd("DeleteDeptStack", CmdType.StoredProcedure, par)
    End Sub
    Public Sub UpdateScApplicable(ByVal SchemeCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(2) {}
        par(0) = New SqlParameter("@SchemeCode", Data.SqlDbType.Int)
        par(1) = New SqlParameter("SchemeAppToId", Data.SqlDbType.Int)
        par(0).Value = SchemeCode
        DeleteScAppToTran(SchemeCode)
        If Not ScAppTo Is Nothing Then
            For Each item As ListItem In ScAppTo
                par(1).Value = Integer.Parse(item.Value.ToString())
                ExecuteCmd("SaveScAppToTran", CmdType.StoredProcedure, par)
            Next
        End If
    End Sub
    Public Sub UpdateScACTTran(ByVal SchemeCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(2) {}
        par(0) = New SqlParameter("@SchemeCode", Data.SqlDbType.Int)
        par(1) = New SqlParameter("SectionId", Data.SqlDbType.Int)

        par(0).Value = SchemeCode
        DeleteScAct(SchemeCode)
        If Not SchemeAct Is Nothing Then
            For Each item As ListItem In SchemeAct
                par(1).Value = Integer.Parse(item.Value.ToString())
                ExecuteCmd("SaveACTTran", CmdType.StoredProcedure, par)
            Next
        End If
    End Sub
    Public Sub UpdateScGRTran(ByVal SchemeCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(2) {}
        par(0) = New SqlParameter("@SchemeCode", Data.SqlDbType.Int)
        par(1) = New SqlParameter("GROrderId", Data.SqlDbType.Int)
        par(0).Value = SchemeCode
        DeleteScGR(SchemeCode)
        If Not SchemeGR Is Nothing Then
            For Each item As ListItem In SchemeGR
                par(1).Value = Integer.Parse(item.Value.ToString())
                ExecuteCmd("SaveGRTran", CmdType.StoredProcedure, par)
            Next
        End If
    End Sub
    Public Sub UpdateGrActTranSave(ByVal SchemeCode As Integer, ByVal orderid As Integer, ByVal ordertype As Integer)
        Dim par() As SqlParameter = New SqlParameter(2) {}
        par(0) = New SqlParameter("@SchemeCode", Data.SqlDbType.Int)
        par(1) = New SqlParameter("@GROrderId", Data.SqlDbType.Int)
        par(2) = New SqlParameter("@ordertype", Data.SqlDbType.Int)

        par(0).Value = SchemeCode
        par(1).Value = orderid
        par(2).Value = ordertype
        ExecuteCmd("SaveGRTran", CmdType.StoredProcedure, par)

    End Sub
    Public Sub UpdateLicenceGrTranSave(ByVal SchemeCode As Integer, ByVal orderid As Integer, ByVal ordertype As Integer, ByVal createdby As Integer)
        Dim par() As SqlParameter = New SqlParameter(3) {}
        par(0) = New SqlParameter("@SchemeCode", Data.SqlDbType.Int)
        par(1) = New SqlParameter("@GROrderId", Data.SqlDbType.Int)
        par(2) = New SqlParameter("@ordertype", Data.SqlDbType.Int)
        par(3) = New SqlParameter("@createdby", Data.SqlDbType.Int)
        par(0).Value = SchemeCode
        par(1).Value = orderid
        par(2).Value = ordertype
        par(3).Value = createdby
        ExecuteCmd("SaveLicenceGrTran", CmdType.StoredProcedure, par)

    End Sub
    Public Sub deleteGrActTran(ByVal SchemeCode As Integer, ByVal orderid As Integer, ByVal ordertype As Integer)
        Dim par() As SqlParameter = New SqlParameter(2) {}
        par(0) = New SqlParameter("@SchemeCode", Data.SqlDbType.Int)
        par(1) = New SqlParameter("@GROrderId", Data.SqlDbType.Int)
        par(2) = New SqlParameter("@ordertype", Data.SqlDbType.Int)

        par(0).Value = SchemeCode
        par(1).Value = orderid
        par(2).Value = ordertype
        ExecuteCmd("DeleteGrActTran", CmdType.StoredProcedure, par)

    End Sub
    Public Sub DeleteLicenceGrActTran(ByVal SchemeCode As Integer, ByVal orderid As Integer, ByVal ordertype As Integer)
        Dim par() As SqlParameter = New SqlParameter(2) {}
        par(0) = New SqlParameter("@SchemeCode", Data.SqlDbType.Int)
        par(1) = New SqlParameter("@GROrderId", Data.SqlDbType.Int)
        par(2) = New SqlParameter("@ordertype", Data.SqlDbType.Int)

        par(0).Value = SchemeCode
        par(1).Value = orderid
        par(2).Value = ordertype
        ExecuteCmd("DeleteLicenceGrActTran", CmdType.StoredProcedure, par)

    End Sub

    Public Sub DeleteScAppToTran(ByVal SchemeCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(0) {}
        par(0) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("DeleteSchemeAppToTran", CmdType.StoredProcedure, par)
    End Sub
    Public Sub DeleteScGR(ByVal SchemeCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(0) {}
        par(0) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("DeleteGrTran", CmdType.StoredProcedure, par)
    End Sub
    Public Sub DeleteScAct(ByVal SchemeCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(0) {}
        par(0) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("DeleteActTran", CmdType.StoredProcedure, par)
    End Sub
    Public Sub DeleteScAppArea(ByVal SchemeCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(0) {}
        par(0) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("DeleteScAppArea", CmdType.StoredProcedure, par)
    End Sub
    Public Sub DeleteScBFTypeTran(ByVal SchemeCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(0) {}
        par(0) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("DeleteScBFTypeTran", CmdType.StoredProcedure, par)
    End Sub
    Public Sub DeleteScAttachTran(ByVal SchemeCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(0) {}
        par(0) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("DeleteScAttachTran", CmdType.StoredProcedure, par)
    End Sub
    Public Sub UpdateScApplicableArea(ByVal SchemeCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(2) {}
        par(0) = New SqlParameter("@SchemeCode", Data.SqlDbType.Int)
        par(1) = New SqlParameter("AreaCode", Data.SqlDbType.SmallInt)
        par(0).Value = SchemeCode
        DeleteScAppArea(SchemeCode)
        If Not ScAppArea Is Nothing Then
            For Each item As ListItem In ScAppArea
                par(1).Value = Integer.Parse(item.Value.ToString())
                ExecuteCmd("SaveScAppAreaTran", CmdType.StoredProcedure, par)
            Next
        End If
    End Sub
    Public Sub UpdateScBudget(ByVal SchemeCode As Integer)
        Dim param As SqlParameter() = New SqlParameter(10) {}
        SetScBudgPara(param)
        param(10) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("SaveScBudgPara", CmdType.StoredProcedure, param)
    End Sub
    Public Sub updateSchemeDetails(ByVal SchemeCode As Integer)
        Dim param As SqlParameter() = New SqlParameter(4) {}
        Call SetScDetails(param)
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("SaveScDetails", CmdType.StoredProcedure, param)
    End Sub
    Public Sub updateSchemeRCPSACT(ByVal SchemeCode As Integer)
        Dim param As SqlParameter() = New SqlParameter(14) {}
        Call SetScRCPS(param)
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("SaveScRCPS", CmdType.StoredProcedure, param)
    End Sub
    Public Sub updateSchemeBenefit(ByVal SchemeCode As Integer)
        Dim param As SqlParameter() = New SqlParameter(3) {}
        Call SetScBFType(param)
        param(1) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("SaveSchemeBFType", CmdType.StoredProcedure, param)
    End Sub
    Public Sub Add_Doc(ByVal b As Byte(), doctype As String, schemecode As String)
        Dim param As SqlParameter() = New SqlParameter(3) {}
        param(0) = New SqlParameter("@doc", SqlDbType.Image)
        param(1) = New SqlParameter("@doctype", doctype)
        param(2) = New SqlParameter("@schemecode", schemecode)

        param(0).Value = b
        param(1).Value = doctype
        param(2).Value = schemecode



        ExecuteCmd("SaveRCPSACTDocs", CmdType.StoredProcedure, param)
    End Sub
    Public Sub Add_Document(ByVal b As Byte(), doctype As String, id As String)
        Dim param As SqlParameter() = New SqlParameter(3) {}
        param(0) = New SqlParameter("@doc", SqlDbType.Image)
        param(1) = New SqlParameter("@doctype", doctype)
        param(2) = New SqlParameter("@DepartmentLicenceID", id)

        param(0).Value = b
        param(1).Value = doctype
        param(2).Value = id



        ExecuteCmd("SaveRCPSACTDocs_forLicence", CmdType.StoredProcedure, param)
    End Sub
    Public Function LoadRCPSDoc(ByVal schemecode As Integer, ByVal Type As String) As Byte()


        Dim param(2) As SqlClient.SqlParameter
        param(0) = New SqlClient.SqlParameter("schemecode", schemecode)
        param(1) = New SqlClient.SqlParameter("type", Type)

        'AndAlso IsDBNull(GetRecordRow("GetGrOrderDocById", CmdType.StoredProcedure, param).Item("GROrder"))
        If Not IsDBNull(GetRecordRow("GetRCPSDocById", CmdType.StoredProcedure, param).Item("RCPSdoc")) Then
            Return GetRecordRow("GetRCPSDocById", CmdType.StoredProcedure, param).Item("RCPSdoc")
        Else
            Return {}
        End If
    End Function
    Public Function LoadRCPSDoc_RCPS(ByVal id As Integer, ByVal Type As String) As Byte()


        Dim param(2) As SqlClient.SqlParameter
        param(0) = New SqlClient.SqlParameter("DepartmentLicenceID", id)
        param(1) = New SqlClient.SqlParameter("type", Type)

        'AndAlso IsDBNull(GetRecordRow("GetGrOrderDocById", CmdType.StoredProcedure, param).Item("GROrder"))
        If Not IsDBNull(GetRecordRow("GetRCPSDocById_Licence", CmdType.StoredProcedure, param).Item("RCPSdoc")) Then
            Return GetRecordRow("GetRCPSDocById_Licence", CmdType.StoredProcedure, param).Item("RCPSdoc")
        Else
            Return {}
        End If
    End Function
    Public Sub UpdateScBenefit(ByVal SchemeCode As Integer)
        'Dim param As SqlParameter() = New SqlParameter(1) {}
        Dim par() As SqlParameter = New SqlParameter(2) {}
        par(0) = New SqlParameter("@SchemeCode", Data.SqlDbType.Int)
        par(1) = New SqlParameter("@SchemeBFTId", Data.SqlDbType.SmallInt)
        par(0).Value = SchemeCode
        DeleteScBFTypeTran(SchemeCode)
        If Not ScBFType Is Nothing Then
            For Each item As ListItem In ScBFType
                par(1).Value = Integer.Parse(item.Value.ToString())
                ExecuteCmd("ScBFTypeTran", CmdType.StoredProcedure, par)
            Next
        End If
    End Sub
    Public Sub UpdateScAppForm(ByVal SchemeCode As Integer, ByVal DeptId As Integer)
        Dim param As SqlParameter() = New SqlParameter(7) {}
        Call SetScAppform(param)
        Call UpdateScAttachment(SchemeCode)
        param(4) = New SqlParameter("@SchemeCode", SchemeCode)
        param(5) = New SqlParameter("@FormId", Data.SqlDbType.BigInt)
        param(6) = New SqlParameter("@DeptId", DeptId)
        param(5).Value = ReturnFormId(SchemeCode)
        ExecuteCmd("SaveScApplicationForm", CmdType.StoredProcedure, param)
    End Sub
    Public Sub UpdateScApplicenceForm(ByVal LicenceId As Integer, ByVal DeptId As Integer)
        Dim param As SqlParameter() = New SqlParameter(7) {}
        Call SetScAppform(param)
        Call UpdateScAttachmentl(LicenceId)
        param(4) = New SqlParameter("@LicenceId", LicenceId)
        param(5) = New SqlParameter("@FormId", Data.SqlDbType.BigInt)
        param(6) = New SqlParameter("@DeptId", DeptId)
        param(5).Value = ReturnFormId_licence(LicenceId)
        ExecuteCmd("SaveScLicenceApplicationForm", CmdType.StoredProcedure, param)
    End Sub
    Public Sub UpdateScAttachment(ByVal SchemeCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(2) {}
        par(0) = New SqlParameter("@SchemeCode", Data.SqlDbType.Int)
        par(1) = New SqlParameter("@AttachId", Data.SqlDbType.SmallInt)
        par(0).Value = SchemeCode
        DeleteScAttachTran(SchemeCode)

        If Not Attachment Is Nothing Then
            For Each item As ListItem In Attachment
                par(1).Value = Integer.Parse(item.Value.ToString())
                ExecuteCmd("ScAttachTran", CmdType.StoredProcedure, par)
            Next
        End If
    End Sub
    Public Sub UpdateScAttachmentl(ByVal LicenceCode As Integer)
        Dim par() As SqlParameter = New SqlParameter(2) {}
        par(0) = New SqlParameter("@LicenceCode", Data.SqlDbType.Int)
        par(1) = New SqlParameter("@AttachId", Data.SqlDbType.SmallInt)
        par(0).Value = LicenceCode
        'DeleteScAttachTran(SchemeCode)

        If Not Attachment Is Nothing Then
            For Each item As ListItem In Attachment
                par(1).Value = Integer.Parse(item.Value.ToString())
                ExecuteCmd("SP_ScAttachTran_licence", CmdType.StoredProcedure, par)
            Next
        End If
    End Sub
    Public Sub SaveSponsoredByTran(ByVal SchemeCode As Integer, ByVal SponsoredById As Integer, ByVal Share As Decimal)
        Dim param As SqlParameter() = New SqlParameter(3) {}
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        param(1) = New SqlParameter("@SponsoredById", SponsoredById)
        param(2) = New SqlParameter("@Share", Share)
        ExecuteCmd("SaveSponsoredByTran", CmdType.StoredProcedure, param)
    End Sub
    Public Sub UpdateSponsoredByTran(ByVal Id As Integer, ByVal SchemeCode As Integer, ByVal SponsoredById As Integer, ByVal Share As Decimal)
        Dim param As SqlParameter() = New SqlParameter(4) {}
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        param(1) = New SqlParameter("@SponsoredById", SponsoredById)
        param(2) = New SqlParameter("@Share", Share)
        param(3) = New SqlParameter("@Id", Id)
        ExecuteCmd("Update tblSponsoredBy set SchemeCode=@SchemeCode,SponsoredById=@SponsoredById,Share=@Share where Id=@Id", CmdType.QueryText, param)
    End Sub
    Public Sub DeleteSponsoredByTran(ByVal id As Integer)
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@Id", SqlDbType.Int)
        param(0).Value = id
        ExecuteCmd("Delete from tblSponsoredBy where Id=@Id", CmdType.QueryText, param)
    End Sub
    Public Sub DeleteAppFeesCri(ByVal AppFeesCriteriaId As Integer)
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@AppFeesCriteriaId", SqlDbType.Int)
        param(0).Value = AppFeesCriteriaId
        ExecuteCmd("Delete from tblAppFeesCriteria where AppFeesCriteriaId=@AppFeesCriteriaId", CmdType.QueryText, param)
    End Sub
    Public Sub DeleteSponsoredByTran1(ByVal SchemeCode As Integer)
        Dim param As SqlParameter() = New SqlParameter(1) {}
        param(0) = New SqlParameter("@SchemeCode", SqlDbType.Int)
        param(0).Value = SchemeCode
        ExecuteCmd("DeleteSponsoredByTran1", CmdType.StoredProcedure, param)
    End Sub
    Public Sub SaveAppFeeCriTran(ByVal SchemeCode As Integer, ByVal CasteId As Integer, ByVal Age As Integer, ByVal AppFees As Decimal)
        Dim param As SqlParameter() = New SqlParameter(3) {}
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        param(1) = New SqlParameter("@CasteId", CasteId)
        param(2) = New SqlParameter("@Age", Age)
        param(3) = New SqlParameter("@AppFees", AppFees)
        ExecuteCmd("SaveAppFeeCriTran", CmdType.StoredProcedure, param)
    End Sub
    '    Public Sub SaveAppFeeCriTran_Licence(ByVal SchemeCode As Integer, ByVal AppFees As Decimal)
    '        Dim param As SqlParameter() = New SqlParameter(3) {}
    '        param(0) = New SqlParameter("@SchemeCode", SchemeCode)

    'param(1) = New SqlParameter("@AppFees", AppFees)
    '        ExecuteCmd("SaveAppFeeCriTran", CmdType.StoredProcedure, param)
    '    End Sub
    Public Sub DeleteAppFeeCriTran(ByVal SchemeCode As Integer)
        Dim param As SqlParameter() = New SqlParameter(0) {}
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("DeleteAppFeeCriTran", CmdType.StoredProcedure, param)
    End Sub
    Public Sub FetchSummary(ByVal DeptId As Integer)
        Dim totsc, govsc, censc, govcen, open, sc, st, obc, bpl, women, children, farmers, SmallFarmers, Disabled, panchayat, ScholarShip, Income, SerF, SerP As Integer
        Dim param As SqlParameter() = New SqlParameter(0) {}
        param(0) = New SqlParameter("@DeptId", DeptId)
        'Dim sql, sql1, sql2, sql3, sql4, sql5, sql6, sql7, sql8, sql9, sql10, sql11, sql12, sql13, sql14, sql15, sql16, sql17, sql18 As String

        totsc = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP", param)

        govsc = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP1", param)

        censc = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP2", param)

        govcen = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP3", param)

        open = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP4", param)

        sc = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP5", param)

        st = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP6", param)

        obc = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP7", param)

        bpl = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP8", param)

        women = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP9", param)

        children = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP10", param)

        farmers = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP11", param)

        SmallFarmers = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP12", param)

        Disabled = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP13", param)

        panchayat = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP14", param)

        ScholarShip = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP15", param)

        Income = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP16", param)

        SerF = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP17", param)

        SerP = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP18", param)
        Session("Summary") = totsc & "," & govsc & "," & censc & "," & govcen & "," & open & "," & sc & "," & st & "," & obc & "," & bpl & "," & women & "," & children & "," & farmers & "," & SmallFarmers & "," & Disabled & "," & panchayat & "," & ScholarShip & "," & Income & "," & SerF & "," & SerP
    End Sub

    Public Sub FetchSummary1()
        Dim totsc, govsc, censc, govcen, open, sc, st, obc, bpl, women, children, farmers, SmallFarmers, Disabled, panchayat, ScholarShip, Income, SerF, SerP As Integer
        ' Dim param As SqlParameter() = New SqlParameter(0) {}
        'param(0) = New SqlParameter("@DeptId", DeptId)
        'Dim sql, sql1, sql2, sql3, sql4, sql5, sql6, sql7, sql8, sql9, sql10, sql11, sql12, sql13, sql14, sql15, sql16, sql17, sql18 As String

        totsc = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP")

        govsc = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP1")

        censc = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP2")

        govcen = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP3")

        open = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP4")

        sc = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP5")

        st = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP6")

        obc = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP7")

        bpl = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP8")

        women = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP9")

        children = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP10")

        farmers = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP11")

        SmallFarmers = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP12")

        Disabled = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP13")

        panchayat = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP14")

        ScholarShip = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP15")

        Income = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP16")

        SerF = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP17")

        SerP = SqlHelper.ExecuteScalar(getConnectionString(), CommandType.StoredProcedure, "GetSummarySP18")
        Session("Summary") = totsc & "," & govsc & "," & censc & "," & govcen & "," & open & "," & sc & "," & st & "," & obc & "," & bpl & "," & women & "," & children & "," & farmers & "," & SmallFarmers & "," & Disabled & "," & panchayat & "," & ScholarShip & "," & Income & "," & SerF & "," & SerP
    End Sub
#End Region
#Region "Functions"
    Public Function IsExistSchemeName(ByVal SchemeName As String) As Boolean
        Dim sql As String
        sql = "Select_SchemeMast_byName"
        Dim param(1) As SqlClient.SqlParameter
        Dim i As Integer
        param(0) = New SqlClient.SqlParameter("@SchemeName", SchemeName)
        i = ReturnValue(sql, CmdType.StoredProcedure, param)
        If i > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function LoadScheme(ByVal SchemeCode As Integer, ByVal DeptId As Integer) As Data.DataRow
        Dim sql As String = "Select_SchemeMast"
        Dim param(3) As SqlClient.SqlParameter
        param(0) = New SqlClient.SqlParameter("@SchemeCode", SchemeCode)
        param(1) = New SqlClient.SqlParameter("@DeptId", DeptId)
        param(2) = New SqlClient.SqlParameter("@flag", 1)
        Return GetRecordRow(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function LoadLicence(ByVal LicenceId As Integer, ByVal DeptId As Integer) As Data.DataRow
        Dim sql As String = "Select_LicenceMast"
        Dim param(3) As SqlClient.SqlParameter
        param(0) = New SqlClient.SqlParameter("@LicenceId", LicenceId)
        param(1) = New SqlClient.SqlParameter("@DeptId", DeptId)
        param(2) = New SqlClient.SqlParameter("@flag", 1)
        Return GetRecordRow(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function LoadOffice(ByVal id As Integer) As Data.DataRow
        Dim sql As String = "Select_SchemeContactOffice_byId"
        Dim param(1) As SqlClient.SqlParameter
        param(0) = New SqlClient.SqlParameter("@ScConOfficeId", id)
        Return GetRecordRow(sql, CmdType.StoredProcedure, param)
    End Function
    Public Function fillgrid() As Data.DataTable
        Dim sql As String = "Select_SchemeMast"
        Return FillRecords(sql, CmdType.StoredProcedure)
    End Function
#End Region
#Region "Private Procedures & Functions"
    Public Sub SetScAppform(ByRef param As SqlParameter())
        param(0) = New SqlParameter("@AppFormType", Data.SqlDbType.Char, 2)
        param(1) = New SqlParameter("@AppFormCost", Data.SqlDbType.Decimal, 18)
        param(2) = New SqlParameter("@AppFormSubTo", Data.SqlDbType.NVarChar, 500)
        param(3) = New SqlParameter("@AppFormAvaiFrom", Data.SqlDbType.NVarChar, 500)

        param(0).Value = mAppFormType
        param(1).Value = mAppFormCost
        param(2).Value = mAppFormSubTo
        param(3).Value = mAppFormAvaiFrom

    End Sub
    Public Sub SetScBFType(ByRef param As SqlParameter())
        param(0) = New SqlParameter("@Benifits", Data.SqlDbType.NVarChar, 4000)
        param(2) = New SqlParameter("@BenifitsGuj", Data.SqlDbType.NVarChar, 4000)
        param(0).Value = mBenefits
        param(2).Value = mBenifitsGuj
    End Sub
    Public Sub SetScDetails(ByRef param As SqlParameter())
        param(1) = New SqlParameter("@GistOfScheme", Data.SqlDbType.NVarChar, 1000)
        param(2) = New SqlParameter("@GistOfSchemeEn", Data.SqlDbType.NVarChar, 1000)
        param(3) = New SqlParameter("@Remarks", Data.SqlDbType.NVarChar, 4000)
        param(4) = New SqlParameter("@keyword", Data.SqlDbType.NVarChar, 4000)
        param(1).Value = mGistOfScheme
        param(2).Value = mGistOfSchemeEn
        param(3).Value = mRemark
        param(4).Value = mGistkeyword

    End Sub
    Public Sub SetScRCPS(ByRef param As SqlParameter())
        param(1) = New SqlParameter("@RCPSACT", Data.SqlDbType.Bit)

        param(2) = New SqlParameter("@Sddays", Data.SqlDbType.Int)
        param(3) = New SqlParameter("@Sdguj", Data.SqlDbType.NVarChar, 1000)
        param(4) = New SqlParameter("@Sdeng", Data.SqlDbType.NVarChar, 1000)

        param(5) = New SqlParameter("@GRAdays", Data.SqlDbType.Int)
        param(6) = New SqlParameter("@GRAguj", Data.SqlDbType.NVarChar, 1000)
        param(7) = New SqlParameter("@GRAeng", Data.SqlDbType.NVarChar, 1000)

        param(8) = New SqlParameter("@App1days", Data.SqlDbType.Int)
        param(9) = New SqlParameter("@App1guj", Data.SqlDbType.NVarChar, 1000)
        param(10) = New SqlParameter("@App1eng", Data.SqlDbType.NVarChar, 1000)

        param(11) = New SqlParameter("@App2days", Data.SqlDbType.Int)
        param(12) = New SqlParameter("@App2guj", Data.SqlDbType.NVarChar, 1000)
        param(13) = New SqlParameter("@App2eng", Data.SqlDbType.NVarChar, 1000)

        param(1).Value = mRCPSACT

        param(2).Value = mSddays
        param(3).Value = mSdguj
        param(4).Value = mSdeng

        param(5).Value = mGRAdays
        param(6).Value = mGRAguj
        param(7).Value = mGRAeng

        param(8).Value = mApp1days
        param(9).Value = mApp1guj
        param(10).Value = mApp1eng

        param(11).Value = mApp2days
        param(12).Value = mApp2guj
        param(13).Value = mApp2eng

    End Sub
    Public Sub SetScRegParameter(ByRef param As SqlParameter())

        param(0) = New SqlParameter("@DeptId", Data.SqlDbType.Int)
        param(1) = New SqlParameter("@SectorId", Data.SqlDbType.SmallInt)
        param(2) = New SqlParameter("@SubSector", Data.SqlDbType.NVarChar, 1000)
        param(3) = New SqlParameter("@SchemeName", Data.SqlDbType.NVarChar, 1000)
        param(4) = New SqlParameter("@CatId ", Data.SqlDbType.Int)
        param(5) = New SqlParameter("@SchemeTypeId", Data.SqlDbType.TinyInt)
        param(6) = New SqlParameter("@SchemeTargetArea", Data.SqlDbType.Char, 2)
        param(7) = New SqlParameter("@SchemeEffDate", Data.SqlDbType.DateTime)
        param(8) = New SqlParameter("@SchemeValidDate", Data.SqlDbType.DateTime)
        param(9) = New SqlParameter("@Status", Data.SqlDbType.Bit)
        param(10) = New SqlParameter("@SchemeNameGu", Data.SqlDbType.NVarChar, 1000)
        param(11) = New SqlParameter("@HODId", Data.SqlDbType.Int)

        param(13) = New SqlParameter("@UserId", Data.SqlDbType.Int)
        param(14) = New SqlParameter("@OfficeId", Data.SqlDbType.Int)
        param(15) = New SqlParameter("@ServiceType", mdServiceType)

        param(0).Value = mDeptID
        param(1).Value = mSectorID
        param(2).Value = mSubSector
        param(3).Value = mSchemeName
        param(4).Value = mCatid
        param(5).Value = mSchemeTypeId
        param(6).Value = mScTargetArea
        param(7).Value = mSchemeEffDate
        param(8).Value = mSchemeValidDate
        param(9).Value = mStatus
        param(10).Value = mSchemeNameGu
        param(11).Value = mHODID
        param(13).Value = mUserId
        param(14).Value = mOfficeId
    End Sub
    Public Sub SetScImpParameter(ByRef param As SqlParameter())

        'param(0) = New SqlParameter("@DeptId", Data.SqlDbType.Int)
        'param(1) = New SqlParameter("@DeptId", Data.SqlDbType.Int)
        'param(2) = New SqlParameter("@OfficeTYpeId", Data.SqlDbType.Int)
        'param(3) = New SqlParameter("@OfficeTypeAt", Data.SqlDbType.Int)
        'param(4) = New SqlParameter("@DistCd", Data.SqlDbType.Int)
        'param(5) = New SqlParameter("@TalukaCd", Data.SqlDbType.Int)
        'param(6) = New SqlParameter("@Address", Data.SqlDbType.Int)
        'param(7) = New SqlParameter("@MileStone", Data.SqlDbType.Int)
        'param(8) = New SqlParameter("@OfficeTypeAt", Data.SqlDbType.NVarChar, 100)
        'param(9) = New SqlParameter("@ConPerPhR ", Data.SqlDbType.NVarChar, 15)
        'param(4) = New SqlParameter("@ConPerPhO", Data.SqlDbType.NVarChar, 15)
        'param(5) = New SqlParameter("@ConPerPhM", Data.SqlDbType.NVarChar, 15)
        'param(6) = New SqlParameter("@ConPerPhG", Data.SqlDbType.NVarChar, 15)



        'If mDesigId = 0 Then
        '    param(2).Value = DBNull.Value
        'Else
        '    param(2).Value = mDesigId
        'End If
        'param(0).Value = mSchemeCode
        'param(1).Value = mOfficeTypeDeptId
        'param(3).Value = mOfficeTypeAt
        'param(4).Value = mConPerPhO
        'param(5).Value = mconPerPhM
        'param(6).Value = mConPerPhG

    End Sub
    Public Sub SetScConOfficeParameter(ByRef param As SqlParameter())
        param(0) = New SqlParameter("@SchemeCode", Data.SqlDbType.Int)
        param(1) = New SqlParameter("@DeptId", Data.SqlDbType.Int)
        param(2) = New SqlParameter("@OfficeTYpeId", Data.SqlDbType.Int)
        param(3) = New SqlParameter("@OfficeTypeAt", Data.SqlDbType.Char, 1)
        param(4) = New SqlParameter("@DistCd", Data.SqlDbType.Char, 2)
        param(5) = New SqlParameter("@TalukaCd", Data.SqlDbType.Char, 3)
        param(6) = New SqlParameter("@Address", Data.SqlDbType.NVarChar, 500)
        param(7) = New SqlParameter("@MileStone", Data.SqlDbType.NVarChar, 200)
        param(8) = New SqlParameter("@Phone_O1", Data.SqlDbType.VarChar, 30)
        param(9) = New SqlParameter("@Phone_O2", Data.SqlDbType.VarChar, 30)
        param(10) = New SqlParameter("@GSWAN", Data.SqlDbType.VarChar, 30)
        param(11) = New SqlParameter("@Phone_R", Data.SqlDbType.VarChar, 30)
        param(12) = New SqlParameter("@Mobile", Data.SqlDbType.VarChar, 30)
        param(13) = New SqlParameter("@DesigID", Data.SqlDbType.Int)


        If mDesigId = 0 Then
            param(13).Value = DBNull.Value
        Else
            param(13).Value = mDesigId
        End If
        param(0).Value = mSchemeCode
        param(1).Value = mDeptID
        param(2).Value = mOfficeTYpeId
        param(3).Value = mOfficeTypeAt
        param(4).Value = mDistCd
        param(5).Value = mTalukaCd
        param(6).Value = mAddress
        param(7).Value = mMileStone
        param(8).Value = mPhoneO1
        param(9).Value = mPhoneO2
        param(10).Value = mGSWAN
        param(11).Value = mPhoneR
        param(12).Value = mMobile


    End Sub
    Public Sub SetScBudgPara(ByVal param As SqlParameter())

        param(0) = New SqlParameter("@DeptId", Data.SqlDbType.Int)
        param(1) = New SqlParameter("@BudgSecId", Data.SqlDbType.VarChar, 10)
        param(2) = New SqlParameter("@BudgDemNo", Data.SqlDbType.VarChar, 10)
        param(3) = New SqlParameter("@BudgMajorHead", Data.SqlDbType.VarChar, 10)
        param(4) = New SqlParameter("@BudgSubMajorHead", Data.SqlDbType.VarChar, 10)
        param(5) = New SqlParameter("@BudgMinorHead", Data.SqlDbType.VarChar, 10)
        param(6) = New SqlParameter("@BudgSubHead", Data.SqlDbType.VarChar, 10)
        param(7) = New SqlParameter("@BudgSchemeCode", Data.SqlDbType.VarChar, 10)
        param(8) = New SqlParameter("@SchemePlan", Data.SqlDbType.Char, 1)
        param(9) = New SqlParameter("@BudgObjHead", Data.SqlDbType.VarChar, 10)


        param(0).Value = mDeptID
        param(1).Value = mBudgSecID
        param(2).Value = mBudgDemNo
        param(3).Value = mBudgMajorHead
        param(4).Value = mBudgSubMajorHead
        param(5).Value = mBudgMinorHead
        param(6).Value = mBudgSubHead
        param(7).Value = mBudgSchemeCode
        param(8).Value = mSchemePlan
        param(9).Value = mBudgObjHead
    End Sub
    Public Sub SetScGenParameter(ByVal param As SqlParameter())

        param(0) = New SqlParameter("@DepartmentID", Data.SqlDbType.Int)
        param(1) = New SqlParameter("@ConDays", Data.SqlDbType.NVarChar, 200)
        param(2) = New SqlParameter("@Gender", Data.SqlDbType.Char, 2)
        param(3) = New SqlParameter("@AgeForm", Data.SqlDbType.Int)
        param(4) = New SqlParameter("@AgeTo", Data.SqlDbType.Int)
        param(5) = New SqlParameter("@Nationality", Data.SqlDbType.Char, 3)
        param(6) = New SqlParameter("@IncomeGrId", Data.SqlDbType.SmallInt)
        param(7) = New SqlParameter("@OccupId", Data.SqlDbType.Int)
        param(8) = New SqlParameter("@EduId", Data.SqlDbType.SmallInt)
        param(9) = New SqlParameter("@GradeId", Data.SqlDbType.SmallInt)
        param(10) = New SqlParameter("@Trial", Data.SqlDbType.SmallInt)
        param(11) = New SqlParameter("@NoFamilyMembers", Data.SqlDbType.SmallInt)
        param(12) = New SqlParameter("@SocioEcoId", SqlDbType.SmallInt)
        param(13) = New SqlParameter("@ReligionId", SqlDbType.Int)
        param(14) = New SqlParameter("@CasteId", SqlDbType.Int)
        param(15) = New SqlParameter("@SchemeAssistanceValue", SqlDbType.Int)
        param(16) = New SqlParameter("@IndIncLimit", SqlDbType.Decimal)
        param(17) = New SqlParameter("@FamIncLimit", SqlDbType.Decimal)

        param(0).Value = mDeptID
        param(1).Value = mConDays
        param(2).Value = mGender
        param(3).Value = mAgeForm
        param(4).Value = mAgeTo
        param(5).Value = mNationality
        param(6).Value = mIncomeGrID
        If mOccupID = 0 Then
            param(7).Value = DBNull.Value
        Else
            param(7).Value = mOccupID
        End If
        If mEduID = 0 Then
            param(8).Value = DBNull.Value
        Else
            param(8).Value = mEduID
        End If
        If mGradeId = 0 Then
            param(9).Value = DBNull.Value
        Else
            param(9).Value = mGradeId
        End If

        param(10).Value = mTrial
        param(11).Value = mNoFamilyMembers
        If mSocioEcoID = 0 Then
            param(12).Value = DBNull.Value
        Else
            param(12).Value = mSocioEcoID
        End If
        If mReligionId = 0 Then
            param(13).Value = DBNull.Value
        Else
            param(13).Value = mReligionId
        End If

        If mGenCaste = 0 Then
            param(14).Value = DBNull.Value
        Else
            param(14).Value = mGenCaste
        End If

        param(15).Value = mScAssValue
        param(16).Value = mIndIncLimit
        param(17).Value = mFamIncLimit
    End Sub
#End Region
    Public Function FillScGrid(ByVal DeptId As Integer, ByVal SectorId As Integer, ByVal SchemeTypeId As Integer, ByVal AreaCode As Integer) As Data.DataTable
        ' Dim param(1) As SqlClient.SqlParameter
        Dim param As SqlParameter() = New SqlParameter(4) {}
        Dim i As Integer
        param(0) = New SqlClient.SqlParameter("@DeptId", DeptId)
        param(1) = New SqlClient.SqlParameter("@SectorId", SectorId)
        param(2) = New SqlClient.SqlParameter("@SchemeTypeId", SchemeTypeId)
        param(3) = New SqlClient.SqlParameter("@AreaCode", AreaCode)



        Dim sql As String

        sql = "Select_SchemeMast"
        Return FillRecords(sql, CmdType.StoredProcedure, param)

        Return Nothing


    End Function
    Public Sub Delete(ByVal SchemeCode As Integer)
        Dim param As SqlParameter() = New SqlParameter(0) {}
        param(0) = New SqlParameter("@SchemeCode", SchemeCode)
        ExecuteCmd("Delete_SchemeMast", CmdType.StoredProcedure, param)
    End Sub
End Class
