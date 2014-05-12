'Imports Inventor
Imports System.Collections.Generic

Public Class dash1

    Implements IEquatable(Of dash1)

    Shared Property FirstDash As String
        Get
            Return m_firstdash
        End Get
        Set(value As String)
            m_firstdash = value
        End Set
    End Property

    Shared Property value1 As Decimal
        Get
            Return m_value1
        End Get
        Set(value As Decimal)
            m_value1 = value
        End Set
    End Property

    Private Shared Property m_firstdash As String

    Private Shared Property m_value1 As Decimal

    Public Function Equals1(other As dash1) As Boolean

    End Function
End Class

Public Class dash2

    Implements IEquatable(Of dash2)

    Shared Property secondDash As String
        Get
            Return m_seconddash
        End Get
        Set(value As String)
            m_seconddash = value
        End Set
    End Property

    Shared Property value2 As Decimal
        Get
            Return m_value2
        End Get
        Set(value As Decimal)
            m_value2 = value
        End Set
    End Property

    Private Shared Property m_seconddash As String

    Private Shared Property m_value2 As Decimal

    Public Function Equals1(other As dash2) As Boolean


    End Function
End Class

Public Class main
    Public Shared Sub partlist()
        Dim dash1 As New List(Of dash1)

        dash1.Add new dash1 With
            .dash1 = "-2"
            .value1 = 

    End Sub


    Private oShankDiameter As Decimal '= NominalDia
    Private oMaterialThickness As Decimal 'still don't know how to obtain this info from the assembly
    Private oRivetModelLength As Decimal '= Length
    Private oRivetPNLength As Double
    Private oRivetSuggestedLength As Decimal
    Private oAcceptableDifference As Decimal = 0.562
    Private oMaterialUsed As Decimal '= MaterialUsed
    Private oEndDashNumber As New List(Of String)
    Private oBasePN As String '= iProperties.Value("Project", "Part Number")
    Private oFirstDashNumber As New List(Of String)
    Private oCompletePN As String


    Sub main()

        oRivetSuggestedLength = oShankDiameter * 1.5
        oRivetModelLength = oMaterialThickness

        Dim parts As New List(Of main)


        'the first two if statements test the length of the rivet to make sure it won't be too long or too short
        If oRivetPNLength > oAcceptableDifference + oRivetSuggestedLength Then
            '(show warning that rivet is going to be too long to have an appropriately sized head)
        ElseIf oRivetPNLength < oRivetSuggestedLength Then
            '(show warning message that rivet may be too short)
        Else
            '
        End If

        'match concatenation to Inventor iPart table
        oCompletePN = oBasePN & oFirstDashNumber & oEndDashNumber


    End Sub

End Class