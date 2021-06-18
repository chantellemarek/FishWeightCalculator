'Author: Chantelle Marek
'Purpose: Class for frmFishLog
'Date: 03/09/2020

Option Explicit On
Option Strict On

Public Class Fish
    'FishLog Information

    Private cstrSpecies As String
    Private cstrWeight As Decimal
    Private cstrLength As Decimal
    Private cstrFishID As String
    Private cstrLocation As String
    Private cstrDate As String
    Private cstrTimeDay As String
    Private cstrWaterClarity As String
    Private cstrTechnique As String


    Public Property Species() As String
        Get
            Return cstrSpecies
        End Get
        Set(value As String)
            cstrSpecies = value
        End Set
    End Property

    Public Property Weight() As Decimal
        Get
            Return cstrWeight
        End Get
        Set(value As Decimal)
            cstrWeight = value
        End Set
    End Property

    Public Property Length() As Decimal
        Get
            Return cstrLength
        End Get
        Set(value As Decimal)
            cstrLength = value
        End Set
    End Property

    Public Property FishID() As String
        Get
            Return cstrFishID
        End Get
        Set(value As String)
            cstrFishID = value
        End Set
    End Property

    Public Property Location() As String
        Get
            Return cstrLocation
        End Get
        Set(value As String)
            cstrLocation = value
        End Set
    End Property

    Public Property DateFished() As String
        Get
            Return cstrDate
        End Get
        Set(value As String)
            cstrDate = value
        End Set
    End Property

    Public Property TimeDay() As String
        Get
            Return cstrTimeDay
        End Get
        Set(value As String)
            cstrTimeDay = value
        End Set
    End Property

    Public Property WaterClarity() As String
        Get
            Return cstrWaterClarity
        End Get
        Set(value As String)
            cstrWaterClarity = value
        End Set
    End Property

    Public Property Technique() As String
        Get
            Return cstrTechnique
        End Get
        Set(value As String)
            cstrTechnique = value
        End Set
    End Property

End Class
