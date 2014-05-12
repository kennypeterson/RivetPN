Public Class main
    'model length is the length of the rivet in the model, with a full head
    Private oModelLength As Decimal
    'physical length is the length of the rivey physically, before the head is drawn
    Private oPhysicalLength As Decimal
    'The nominal size of the rivet head
    Private oHeadDiameter As Decimal
    'the physical thickness of the two or materials that the rivet is passing through, 
    'to make sure the rivet is long enough to both pass the 1.5D rule and have a full head.
    Private oMaterialThickness As Decimal
    'material used is the amount of rivet length needed to create a full head.
    Private oMaterialUsed As Decimal


    Sub main()

        oModelLength = oHeadDiameter * 1.5

        If oModelLength < oMaterialThickness + oMaterialUsed Then
            ReDim oModelLength as 
        End If

    End Sub
End Class