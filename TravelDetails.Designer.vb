<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TravelDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        cmb3 = New ComboBox()
        cmb5 = New ComboBox()
        cmb4 = New ComboBox()
        txt1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        rb1 = New RadioButton()
        rb2 = New RadioButton()
        cmb1 = New ComboBox()
        Label9 = New Label()
        cmb2 = New ComboBox()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(36, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 3
        Label4.Text = "no of seats"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(373, 35)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 15)
        Label5.TabIndex = 4
        Label5.Text = "Car Type"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(374, 171)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 5
        Label6.Text = "Duration"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(374, 103)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 15)
        Label7.TabIndex = 6
        Label7.Text = "No of passengers"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.Location = New Point(301, 293)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 10
        Button1.Text = "Book"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cmb3
        ' 
        cmb3.FormattingEnabled = True
        cmb3.Items.AddRange(New Object() {"4 seats", "8 seats", "12 seats"})
        cmb3.Location = New Point(53, 221)
        cmb3.Name = "cmb3"
        cmb3.Size = New Size(121, 23)
        cmb3.TabIndex = 13
        cmb3.Tag = "Please select the number of car seats"
        ' 
        ' cmb5
        ' 
        cmb5.FormattingEnabled = True
        cmb5.Items.AddRange(New Object() {"3 - 4 hours", "4 - 5 hours", "5 - 6 hours", "6 - 7 hours", "7 - 8 hours"})
        cmb5.Location = New Point(393, 194)
        cmb5.Name = "cmb5"
        cmb5.Size = New Size(121, 23)
        cmb5.TabIndex = 14
        cmb5.Tag = "Please select the duration of travel"
        ' 
        ' cmb4
        ' 
        cmb4.FormattingEnabled = True
        cmb4.Location = New Point(390, 53)
        cmb4.Name = "cmb4"
        cmb4.Size = New Size(121, 23)
        cmb4.TabIndex = 19
        cmb4.Tag = "Please select the car model that you would like to travel"
        ' 
        ' txt1
        ' 
        txt1.Location = New Point(393, 121)
        txt1.Name = "txt1"
        txt1.Size = New Size(100, 23)
        txt1.TabIndex = 22
        txt1.Tag = "Please first enter the number of passenger"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 24
        Label2.Text = "City"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 25
        Label3.Tag = "Please select any one option"
        Label3.Text = "Travel Type"
        ' 
        ' rb1
        ' 
        rb1.AutoSize = True
        rb1.Location = New Point(53, 126)
        rb1.Name = "rb1"
        rb1.Size = New Size(128, 19)
        rb1.TabIndex = 26
        rb1.TabStop = True
        rb1.Text = "Guide and Car [AC]"
        rb1.UseVisualStyleBackColor = True
        ' 
        ' rb2
        ' 
        rb2.AutoSize = True
        rb2.Location = New Point(53, 151)
        rb2.Name = "rb2"
        rb2.Size = New Size(154, 19)
        rb2.TabIndex = 27
        rb2.TabStop = True
        rb2.Text = "Guide and Car [Non AC]"
        rb2.UseVisualStyleBackColor = True
        ' 
        ' cmb1
        ' 
        cmb1.FormattingEnabled = True
        cmb1.Items.AddRange(New Object() {"Chennai", "Madurai", "Kanyakumari", "Pondicherry", "Ooty"})
        cmb1.Location = New Point(53, 53)
        cmb1.Name = "cmb1"
        cmb1.Size = New Size(121, 23)
        cmb1.TabIndex = 28
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(13, -1)
        Label9.Name = "Label9"
        Label9.Size = New Size(213, 15)
        Label9.TabIndex = 29
        Label9.Text = "Select the car details which you want"
        ' 
        ' cmb2
        ' 
        cmb2.FormattingEnabled = True
        cmb2.Items.AddRange(New Object() {"Chennai", "Madurai", "Pondicherry", "Kanyakumari", "Ooty"})
        cmb2.Location = New Point(53, 53)
        cmb2.Name = "cmb2"
        cmb2.Size = New Size(121, 23)
        cmb2.TabIndex = 30
        cmb2.Tag = "Select the city to Travel"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' TravelDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(800, 450)
        Controls.Add(cmb2)
        Controls.Add(Label9)
        Controls.Add(rb2)
        Controls.Add(rb1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txt1)
        Controls.Add(cmb4)
        Controls.Add(cmb5)
        Controls.Add(cmb3)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "TravelDetails"
        Text = "Form4"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtb2 As TextBox
    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb3 As ComboBox
    Friend WithEvents cmb4 As ComboBox
    Friend WithEvents cmb5 As ComboBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents cmb2 As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    'Friend WithEvents cmb1 As ComboBox
End Class
