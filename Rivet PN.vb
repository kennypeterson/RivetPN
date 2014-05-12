Imports Inventor

Public Class main

    Private oShankDiameter As Decimal = NominalDia
    Private oMaterialThickness As Decimal 'still don't know how to obtain this info from the assembly
    Private oRivetModelLength As Decimal = Length
    Private oRivetPNLength As Double
    Private oRivetSuggestedLength As Decimal
    Private oAcceptableDifference As Decimal = 0.562
    Private oMaterialUsed As Decimal = MaterialUsed
    Private oEndDashNumber As String 'create array? for dash lengths


    Sub main()

        oRivetSuggestedLength = oShankDiameter * 1.5
        oRivetModelLength = oMaterialThickness

        'the first two if statements test the length of the rivet to make sure it won't be too long or too short
        If oRivetPNLength > oAcceptableDifference + oRivetSuggestedLength Then
            '(show warning that rivet is going to be too long to have an appropriately sized head)
        ElseIf oRivetPNLength < oRivetSuggestedLength Then
            '(show warning message that rivet may be too short)
        Else
            '
        End If


    End Sub

End Class