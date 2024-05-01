Imports System.Data.OleDb

Public Class ThankYouPage
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Travel Advisor\BookingDetails.mdb")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        userPage.Show()
    End Sub

    Private Sub ThankYouPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        mycon.Open()
        Dim mycmd As New OleDbCommand("Insert into cusDetails(first_name,last_name,Mobile_Number,email,pickup_location,pickup_date,pickup_time,City_To_Travel,Travel_Type,No_Of_Seats,car_model,duration,No_Of_Passengers,fare,Payment_mode,status) Values ('" & CusDetails.txtb1.Text & "','" & CusDetails.txtb2.Text & "','" & CusDetails.txtb4.Text & "','" & CusDetails.txtb3.Text & "','" & CusDetails.txtb5.Text & "','" & CusDetails.dtp.Text & "','" & CusDetails.cmb2.Text & "','" & TravelDetails.cmb2.Text & "','" & TravelDetails.selectedVal & "','" & TravelDetails.cmb3.Text & "','" & TravelDetails.cmb4.Text & "','" & TravelDetails.cmb5.Text & "','" & TravelDetails.txt1.Text & "','" & TravelDetails.mul & "','" & GuideDetails.selectedValue & "','" & Button1.Text & "' )", mycon)
        Try
            mycmd.ExecuteNonQuery()
            MessageBox.Show("History updated")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'userdetailsstore
        userPage.hstyLink.Text = "History"
    End Sub
End Class