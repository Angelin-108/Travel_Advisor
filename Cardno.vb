Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.ComponentModel
Imports System.Runtime.InteropServices.JavaScript.JSType
Public Class Cardno
    Dim mycon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TravelAdvisor;Integrated Security=True;Pooling=False")
    Public status As String
    Dim mycmd As String
    Dim allowednos As String = "0123456789"
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
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And DateTimePicker1.Text = "" Then
            Exit Sub
        ElseIf vld(TextBox1, TextBox2, TextBox3, DateTimePicker1) = False Then
            Exit Sub
        End If
        If TextBox1.TextLength = 16 Then
        Else
            MessageBox.Show("Please enter the Valid Digit")
        End If
        If TextBox3.TextLength = 3 Then
        Else
            MessageBox.Show("Please enter valid CVV Number")
        End If
        status = "Paid"
        mycon.Open()
        Dim mcmd As New SqlCommand("Insert into BookingDetails(email,First_name,Last_name,Gender,Mobile_Number,Pickup_location,Pickup_Date,Pickup_Time,City_to_Travel,Travel_Type,No_of_Seats,Car_Model,Duration,No_Of_Passengers,Fare,Payment_Mode,Status) Values ('" & CusDetails.txtb3.Text & "','" & CusDetails.txtb1.Text & "','" & CusDetails.txtb2.Text & "','" & CusDetails.cmb1.Text & "','" & CusDetails.txtb4.Text & "','" & CusDetails.txtb5.Text & "','" & CusDetails.dtp.Text & "','" & CusDetails.cmb2.Text & "','" & TravelDetails.cmb2.Text & "','" & TravelDetails.selectedVal & "','" & TravelDetails.cmb3.Text & "','" & TravelDetails.cmb4.Text & "','" & TravelDetails.cmb5.Text & "','" & TravelDetails.txt1.Text & "','" & GuideDetails.Label13.Text & "', '" & GuideDetails.selectedValue & "','" & status & "')", mycon)
        Try
            mcmd.ExecuteNonQuery()
            mycon.Close()
            MsgBox("Payment has been done successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'MessageBox.Show("Payment has been done successfully!")
        Me.Hide()
        MessageBox.Show("THANKS FOR CHOOSING OUR SERVICE!")
        MessageBox.Show("The OTP and Guide details will be sent to your registered mobile number through WhatsApp and SMS, 30 minutes before the pick up time ")
        userPage.hstyLink.Visible = True
        Form2.Label1.Visible = False
        Form2.DataGridView1.Visible = True
        userPage.Show()
        TextBox1.Clear()
    End Sub
    Private Sub Cardno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            ErrorProvider1.SetError(TextBox1, "Invalid Number!")
        End If
    End Sub
    Private Sub DateTimePicker1_Validating(sender As Object, e As CancelEventArgs) Handles DateTimePicker1.Validating
        If DateTimePicker1.Value < DateTime.Now.ToShortDateString Then
            MessageBox.Show("Please check the Expiration Date")
            e.Cancel = True
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.TextLength = 16) Then
            ErrorProvider1.SetError(TextBox1, "")
        Else
            ErrorProvider1.SetError(TextBox1, "Card Number should contain sixteen Digits number")
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            ErrorProvider1.SetError(TextBox2, "Please enter your valid Cardholder Name")
        Else
            ErrorProvider1.SetError(TextBox2, "")
        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not TextBox3.TextLength = 16 And Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            ErrorProvider1.SetError(TextBox3, "Please enter valid CVV Number")
        End If
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If (TextBox3.TextLength = 3) Then
            ErrorProvider1.SetError(TextBox3, "")
        Else
            ErrorProvider1.SetError(TextBox3, "CVV Number should contain three digit numbers")
        End If
    End Sub
End Class