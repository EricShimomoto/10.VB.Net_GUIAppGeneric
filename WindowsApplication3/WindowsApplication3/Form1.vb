Public Class Form1
    Private Const PI As Decimal = 3.1415
    Private Enum season As Integer
        spring = 0
        summer = 1
        fall = 2
        winter = 3
    End Enum

    Public Structure Employee
        Public name As String
        Public position As String
        Public salary As String

        Public ReadOnly Property FullInfo() As String
            Get
                Return name & " is a " & position & " with a salary of: " & salary & Environment.NewLine
            End Get
        End Property

    End Structure

    Private Sub Btn_Apply_Click(sender As Object, e As EventArgs) Handles Btn_Apply.Click
        Dim txtOutput As String = ""

        Dim customers As New ArrayList
        customers.Add("Eric")
        customers.Add("Adriano")
        customers.Add("Felipe")

        txtOutput &= "Count :" & customers.Count & Environment.NewLine
        txtOutput &= "Capacity :" & customers.Capacity & Environment.NewLine
        customers.Insert(0, "tralalal")
        customers.Sort()

        For Each customer As String In customers
            txtOutput &= customer & Environment.NewLine
        Next

        Dim currentSeason As season = season.fall
        txtOutput &= currentSeason.ToString & Environment.NewLine

        Dim Eric As Employee
        Eric.name = "Eric Shimomoto"
        Eric.position = "Software Engineer"
        Eric.salary = 2500

        txtOutput &= Eric.FullInfo()

        TextBox1.Text = txtOutput



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtOutput As String = ""
        Dim dog As New Animal With {
            .Height = 88,
            .Weight = 100,
            .Speed = 100
        }

        dog.SetName("10")

        txtOutput &= "Dog name is: " & dog.GetName & Environment.NewLine

        TextBox1.Text = txtOutput



    End Sub
End Class
