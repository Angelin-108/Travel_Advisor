Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Runtime.Intrinsics.Arm
Public Class userPage
    Dim id As String
    Dim mycon As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TravelAdvisor;Integrated Security=True;Pooling=False")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Me.Hide()
        TravelDetails.Show()
        GuideDetails.rd1.Checked = False
        GuideDetails.rd2.Checked = False
        TravelDetails.txt1.Clear()
        TravelDetails.cmb1.Text = String.Empty
        TravelDetails.cmb2.Text = String.Empty
        TravelDetails.cmb3.Text = String.Empty
        TravelDetails.cmb4.Text = String.Empty
        TravelDetails.cmb5.Text = String.Empty
        TravelDetails.rb1.Checked = False
        TravelDetails.rb2.Checked = False
        CusDetails.txtb1.Clear()
        CusDetails.txtb2.Clear()
        CusDetails.txtb4.Clear()
        CusDetails.txtb5.Clear()
        CusDetails.pintxt.Clear()
        CusDetails.citycmb.Text = String.Empty
        CusDetails.cmb1.Text = String.Empty
        CusDetails.cmb2.Text = String.Empty
        CusDetails.dtp.Text = String.Empty
    End Sub
    Private Sub hstyLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles hstyLink.LinkClicked
        id = CusDetails.txtb3.Text
        mycon.Open()
        Dim cmd As New SqlCommand("Select email,First_name,Last_name,Mobile_Number,Pickup_location,Pickup_Date,Pickup_Time,City_to_Travel,Travel_Type,No_Of_Seats,Car_Model,Duration,No_of_Passengers,Fare,Status from BookingDetails where email = '" & CusDetails.txtb3.Text & "' order by Pickup_Date ", mycon)
        Try
            cmd.ExecuteNonQuery()
            Dim ad As New SqlDataAdapter
            ad.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            ad.Fill(dt)
            Form2.DataGridView1.DataSource = dt
            mycon.Close()
            Form2.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub userPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
    End Sub
End Class