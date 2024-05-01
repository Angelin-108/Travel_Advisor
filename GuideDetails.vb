Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class GuideDetails
    Dim mycon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TravelAdvisor;Integrated Security=True;Pooling=False")
    Public city As String
    Public dates As String
    Public time As String
    Public status As String
    Public selectedValue As String
    Public ploc As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rd1.Checked = True Then
            rd2.Checked = False
            Me.Hide()
            Cardno.Show()
            Exit Sub
        ElseIf rd2.Checked = True Then
            rd1.Checked = False
            Button1.Text = "Not Paid"
            status = Button1.Text
        Else
            MessageBox.Show("Please select any one payment option")
        End If
        status = "Not Paid"
        mycon.Open()
        Dim mycmd As New SqlCommand("Insert into BookingDetails(email,First_name,Last_name,Gender,Mobile_Number,Pickup_location,Pickup_Date,Pickup_Time,City_to_Travel,Travel_Type,No_of_Seats,Car_Model,Duration,No_Of_Passengers,Fare,Payment_Mode,Status) Values ('" & CusDetails.txtb3.Text & "','" & CusDetails.txtb1.Text & "','" & CusDetails.txtb2.Text & "','" & CusDetails.cmb1.Text & "','" & CusDetails.txtb4.Text & "','" & CusDetails.ploc & "','" & CusDetails.dtp.Text & "','" & CusDetails.cmb2.Text & "','" & TravelDetails.cmb2.Text & "','" & TravelDetails.selectedVal & "','" & TravelDetails.cmb3.Text & "','" & TravelDetails.cmb4.Text & "','" & TravelDetails.cmb5.Text & "','" & TravelDetails.txt1.Text & "','" & Label13.Text & "', '" & selectedValue & "','" & status & "')", mycon)
        Try
            mycmd.ExecuteNonQuery()
            mycon.Close()
            MsgBox("Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MessageBox.Show("Payment has been done successfully!")
        Me.Hide()
        MessageBox.Show("THANKS FOR CHOOSING OUR SERVICE!")
        MessageBox.Show("The OTP and Guide details will be sent to your registered mobile number through WhatsApp and SMS, 30 minutes before the pick up time ")
        userPage.hstyLink.Visible = True
        Form2.Label1.Visible = False
        Form2.DataGridView1.Visible = True
        userPage.Show()
        Me.Hide()
        'userPage.hstyLink.Text = "History"
        Form2.DataGridView1.Visible = True
        Form2.Label1.Visible = False
        userPage.Show()
        'ThankYouPage.Show()
        Exit Sub
        Me.Hide()
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rd1.CheckedChanged
        selectedValue = DirectCast(sender, RadioButton).Text
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form2.Show()
    End Sub
    Private Sub rd2_CheckedChanged(sender As Object, e As EventArgs) Handles rd2.CheckedChanged
        selectedValue = DirectCast(sender, RadioButton).Text
    End Sub
    Private Sub GuideDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class