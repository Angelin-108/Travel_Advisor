Imports System.Data.OleDb
Imports System.Net
Imports System.Runtime.Intrinsics.Arm
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class TravelDetails
    Public mul As New Integer
    Public selectedVal As String
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ErrorProvider1.SetError(ctl(i), ctl(i).tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmb2.SelectedItem = "" And cmb3.SelectedItem = "" And cmb4.SelectedItem = "" And cmb5.SelectedItem = "" And txt1.Text = "" Then
            MessageBox.Show("Please enter the field")
            txt1.Focus()
            Exit Sub
        ElseIf vld(cmb2, cmb3, cmb4, cmb5, txt1) = False Then
            Exit Sub
        End If
        If rb1.Checked = True Or rb2.Checked = True Then
            Me.Hide()
            CusDetails.Show()
            Exit Sub
        Else
            ErrorProvider1.SetError(Label3, "Please select any one option")
            Me.Show()
            'MessageBox.Show("Please select any one payment option")
        End If
        'If cmb2.SelectedItem = "" Then
        'MessageBox.Show("Select the city to Travel")
        'End If
        'If cmb3.Text = "" Then
        'MessageBox.Show("Please choose the number of car's seats")
        'cmb3.Focus()
        'Exit Sub
        'End If
        'If cmb4.Text = "" Then
        'MessageBox.Show("Please choose the car model that you would like to travel ")
        'cmb4.Focus()
        'Exit Sub
        'End If
        'If txt1.Text = "" Then
        'MessageBox.Show("Please first enter the number of passenger")
        'cmb5.Enabled = False
        'txt1.Focus()
        'Exit Sub
        'End If
        'If cmb5.Text = "" Then
        'MessageBox.Show("Please select the duration of travel ")
        'cmb5.Focus()
        'Exit Sub
        'End If
        '' Me.Show()
        'Else
        'Me.Hide()
        'CusDetails.Show()
        '' End If
        GuideDetails.Label4.Text = selectedVal
        GuideDetails.Label5.Text = cmb3.SelectedItem
        GuideDetails.Label3.Text = cmb4.SelectedItem
    End Sub
    Private Sub cmb3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb5.SelectedIndexChanged
        If txt1.Text = "" Then
            cmb5.SelectedIndex = -1
            MsgBox("Please first enter the Number of passengers")
            Exit Sub
        End If
        If rb1.Checked = True And cmb5.Text = "3 - 4 hours" Then
            mul = txt1.Text * 5000
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        ElseIf rb1.Checked = True And cmb5.Text = "4 - 5 hours" Then
            mul = txt1.Text * 6000
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        ElseIf rb1.Checked = True And cmb5.Text = "5 - 6 hours" Then
            mul = txt1.Text * 7000
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        ElseIf rb1.Checked = True And cmb5.Text = "6 - 7 hours" Then
            mul = txt1.Text * 8000
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        ElseIf rb1.Checked = True And cmb5.Text = "7 - 8 hours" Then
            mul = txt1.Text * 9000
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        ElseIf rb1.Checked = True And cmb5.Text = "8 - 9 hours" Then
            mul = txt1.Text * 10000
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        ElseIf rb1.Checked = True And cmb5.Text = "9 - 10 hours" Then
            mul = txt1.Text * 11000
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        ElseIf rb1.Checked = True And cmb5.Text = "10 - 11 hours" Then
            mul = txt1.Text * 12000
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        ElseIf rb1.Checked = True And cmb5.Text = "11 - 12 hours" Then
            mul = txt1.Text * 13000
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        ElseIf rb2.Checked = True And cmb5.Text = "3 - 4 hours" Then
            mul = txt1.Text * 2500
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        ElseIf rb2.Checked = True And cmb5.Text = "4 - 5 hours" Then
            mul = txt1.Text * 3500
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        ElseIf rb2.Checked = True And cmb5.Text = "5 - 6 hours" Then
            mul = txt1.Text * 4500
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        ElseIf rb2.Checked = True And cmb5.Text = "6 - 7 hours" Then
            mul = txt1.Text * 5500
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        ElseIf rb2.Checked = True And cmb5.Text = "7 - 8 hours" Then
            mul = txt1.Text * 6500
            GuideDetails.Label13.Text = "₹" & mul
            Exit Sub
        End If
    End Sub
    Private Sub cmb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb3.SelectedIndexChanged
        cmb4.Items.Clear()
        If cmb3.SelectedItem = "4 seats" Then
            cmb4.Items.Add("Maruti Suzuki Swift")
            cmb4.Items.Add("Tata Tiago")
            Exit Sub
        ElseIf cmb3.SelectedItem = "8 seats" Then
            cmb4.Items.Add("Maruti Suzuki Ertiga")
            cmb4.Items.Add("Innova")
            cmb4.Items.Add("Xylo")
            Exit Sub
        ElseIf cmb3.SelectedItem = "12 seats" Then
            cmb4.Items.Add("Force Motors Traveller")
            cmb4.Items.Add("Mahindra Tourister")
            Exit Sub
        End If
    End Sub
    Private Sub TravelDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        selectedVal = DirectCast(sender, RadioButton).Text
    End Sub
    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        selectedVal = DirectCast(sender, RadioButton).Text
    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged
        If cmb3.SelectedItem = "4 seats" And txt1.Text > 5 Then
            MessageBox.Show("The number of passengers are higher than the selected number of car seats.Please select more seats")
            'Me.Show()
            Exit Sub
        End If
        'Else
        If cmb3.SelectedItem = "8 seats" And txt1.Text > 8 Then
            MessageBox.Show("The number of passengers are higher than the selected number of car seats.Please select valid car seats")
            'Me.Show()
            Exit Sub
        End If
        'Else
        If cmb3.SelectedItem = "12 seats" And txt1.Text > 13 Then
            MessageBox.Show("The number of passengers are higher than the selected number of car seats.Please select valid car seats")
            'Me.Show()
            Exit Sub
        End If
        'Else
        If txt1.Text = 0 Then
            MessageBox.Show("Invalid Number")
            'Me.Show()
            Exit Sub
        End If
    End Sub
End Class