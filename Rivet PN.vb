'Imports Inventor
Imports System.Collections.Generic

Public Class dash1
    Public Function Equals1(other As dash1) As Boolean
        Return True
    End Function
    Public Property FirstDash As String
        Get
            Return m_firstdash
        End Get
        Set(value As String)
            m_firstdash = value
        End Set
    End Property

    Public Property value1 As Decimal
        Get
            Return m_value1
        End Get
        Set(value As Decimal)
            m_value1 = value
        End Set
    End Property

    Private Property m_firstdash As String

    Private Property m_value1 As Decimal

End Class

Public Class dash2
    Public Function Equals1(other As dash2) As Boolean
        Return True
    End Function

    Public Property secondDash As String
        Get
            Return m_seconddash
        End Get
        Set(value As String)
            m_seconddash = value
        End Set
    End Property

    Public Property value2 As Decimal
        Get
            Return m_value2
        End Get
        Set(value As Decimal)
            m_value2 = value
        End Set
    End Property

    Private Shared Property m_seconddash As String

    Private Shared Property m_value2 As Decimal

End Class

Public Class main
    Public Sub partlist()
        Dim dash1 As New List(Of dash1)

        dash1.Add(New dash1() With { _
            .FirstDash = "2", _
            .value1 = 0.062
            })

        dash1.Add(New dash1() With { _
            .FirstDash = "3", _
            .value1 = 0.094 _
            })

        dash1.Add(New dash1() With { _
            .FirstDash = "4", _
            .value1 = 0.125 _
            })

        dash1.Add(New dash1() With { _
            .FirstDash = "5", _
            .value1 = 0.156 _
            })

        dash1.Add(New dash1() With { _
            .FirstDash = "6", _
            .value1 = 0.187 _
            })

        dash1.Add(New dash1() With { _
            .FirstDash = "7", _
            .value1 = 0.219 _
            })

        dash1.Add(New dash1() With { _
            .FirstDash = "8", _
            .value1 = 0.25 _
            })

        dash1.Add(New dash1() With { _
            .FirstDash = "9", _
            .value1 = 0.312 _
            })

        dash1.Add(New dash1() With { _
            .FirstDash = "10", _
            .value1 = 0.375 _
            })

        Dim dash2 As New List(Of dash2)

        dash2.Add(New dash2() With { _
            .secondDash = "-2", _
            .value2 = 0.125 _
            })

        dash2.Add(New dash2() With { _
            .secondDash = "-3", _
            .value2 = 0.1875 _
            })

        dash2.Add(New dash2() With { _
            .secondDash = "-4", _
            .value2 = 0.25 _
            })

        dash2.Add(New dash2() With { _
            .secondDash = "-5", _
            .value2 = 0.3125 _
            })

        dash2.Add(New dash2() With { _
            .secondDash = "-6", _
            .value2 = 0.375 _
            })

        dash2.Add(New dash2() With { _
            .secondDash = "-7", _
            .value2 = 0.4375 _
            })

        dash2.Add(New dash2() With { _
            .secondDash = "-8", _
            .value2 = 0.5 _
            })

        dash2.Add(New dash2() With { _
            .secondDash = "-9", _
            .value2 = 0.5625 _
            })

        dash2.Add(New dash2() With { _
            .secondDash = "-10", _
            .value2 = 0.625 _
            })

        dash2.Add(New dash2() With { _
            .secondDash = "-12", _
            .value2 = 0.75 _
            })
    End Sub


    Private oShankDiameter As Decimal '= NominalDia
    Private oMaterialThickness As Decimal 'still don't know how to obtain this info from the assembly
    Private oRivetModelLength As Decimal '= Length
    Private oRivetPNLength As Double
    Private oRivetSuggestedLength As Decimal
    Private oAcceptableDifference As Decimal = 0.562
    Private oMaterialUsed As Decimal '= MaterialUsed
    Private oEndDashNumber As String
    Private oBasePN As String '= iProperties.Value("Project", "Part Number")
    Private oFirstDashNumber As String
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