Public Class Animal
    Public Height As Decimal = 0.0
    Public Weight As Decimal = 0.0
    Public Speed As Decimal = 0.0

    Private Name As String

    Public ReadOnly Property GetName() As String
        Get
            Return Name
        End Get
    End Property

    Public Sub SetName(value As String)
        If IsNumeric(value) Then
            MessageBox.Show("Error", "Put a numerical value")
        Else
            Name = value
        End If
    End Sub

    Public Sub New(Optional ht As Decimal = 0.0,
                   Optional wt As Decimal = 0.0,
                   Optional spd As Decimal = 0.0,
                   Optional nam As String = "No name")
        Height = ht
        Weight = wt
        Speed = spd
        Name = nam

    End Sub
End Class
