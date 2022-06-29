<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNameBox = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNumberOne = New System.Windows.Forms.TextBox()
        Me.txtNumberTwo = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AccessibleName = "lblName"
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'txtNameBox
        '
        Me.txtNameBox.AccessibleName = "NameBox"
        Me.txtNameBox.Location = New System.Drawing.Point(55, 10)
        Me.txtNameBox.Name = "txtNameBox"
        Me.txtNameBox.Size = New System.Drawing.Size(207, 20)
        Me.txtNameBox.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(12, 56)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnMessage
        '
        Me.btnMessage.Location = New System.Drawing.Point(93, 56)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(75, 23)
        Me.btnMessage.TabIndex = 3
        Me.btnMessage.Text = "M&essage"
        Me.btnMessage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(174, 56)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "  E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNumberOne
        '
        Me.txtNumberOne.AccessibleName = "NameBox"
        Me.txtNumberOne.Location = New System.Drawing.Point(16, 121)
        Me.txtNumberOne.Name = "txtNumberOne"
        Me.txtNumberOne.Size = New System.Drawing.Size(62, 20)
        Me.txtNumberOne.TabIndex = 5
        '
        'txtNumberTwo
        '
        Me.txtNumberTwo.AccessibleName = "NameBox"
        Me.txtNumberTwo.Location = New System.Drawing.Point(112, 121)
        Me.txtNumberTwo.Name = "txtNumberTwo"
        Me.txtNumberTwo.Size = New System.Drawing.Size(62, 20)
        Me.txtNumberTwo.TabIndex = 6
        '
        'txtResult
        '
        Me.txtResult.AccessibleName = "NameBox"
        Me.txtResult.Location = New System.Drawing.Point(199, 121)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(57, 20)
        Me.txtResult.TabIndex = 7
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(84, 119)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(22, 23)
        Me.btnPlus.TabIndex = 8
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AccessibleName = "lblName"
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtNumberTwo)
        Me.Controls.Add(Me.txtNumberOne)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtNameBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNameBox As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnMessage As Button
    Friend WithEvents btnExit As Button

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNameBox.TextChanged

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        txtNameBox.Text = "Hello " & txtNameBox.Text
    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        MessageBox.Show("Hi " & txtNameBox.Text,
                   "Hello")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Friend WithEvents txtNumberOne As TextBox
    Friend WithEvents txtNumberTwo As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnPlus As Button
    Friend WithEvents Label2 As Label

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Try
            Dim num1 As Decimal = CDec(txtNumberOne.Text)
            Dim num2 As Decimal = CDec(txtNumberTwo.Text)
            Dim sum As Decimal = num1 + num2
            txtResult.Text = sum
            'Catch ex As System.InvalidCastException
            ' MessageBox.Show("Use a number", "Error")
        Catch ex As Exception
            MessageBox.Show("An error occoured", "Error")
        End Try
    End Sub
End Class
