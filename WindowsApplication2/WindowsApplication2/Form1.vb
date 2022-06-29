Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim num = 12.2
        TextBox1.Text = TypeName(num)

        Dim txtOutput As String = "Abs(-12): " & Math.Abs(-12) & Environment.NewLine

        txtOutput &= "Ceiling of 4.5: " & Math.Ceiling(4.5) & Environment.NewLine


        Dim strin As String = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaig"
        txtOutput &= "Sting size: " & strin.Length & Environment.NewLine
        txtOutput &= "1st 3 char: " & strin.Substring(0, 3) & Environment.NewLine
        txtOutput &= "1Changed string: " & strin.Replace("string", "new string") & Environment.NewLine
        Dim decnum As Decimal = 31231231.123123124
        txtOutput &= "Value: " & String.Format("{0:n3}", decnum) & Environment.NewLine
        txtOutput &= "Value: " & String.Format("{0:c}", decnum) & Environment.NewLine
        txtOutput &= "Value: " & String.Format("{0:00000.00}", decnum) & Environment.NewLine
        txtOutput &= "Is i in the string: " & InStr(1, strin, "i", CompareMethod.Text) & Environment.NewLine

        Dim arrayEmployees(0 To 2) As String
        arrayEmployees(0) = "Eric"
        arrayEmployees(1) = "Akio"
        arrayEmployees(2) = "Adriano"

        Dim joinString As String = Join(arrayEmployees, ", ")
        txtOutput &= "Employees: " & arrayEmployees(2) & Environment.NewLine




        TextBox1.Text = txtOutput


    End Sub
End Class
