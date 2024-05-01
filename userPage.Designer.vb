<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userPage
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
        btn1 = New Button()
        hstyLink = New LinkLabel()
        lb1 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' btn1
        ' 
        btn1.BackColor = Color.SeaShell
        btn1.ForeColor = Color.Black
        btn1.Location = New Point(35, 179)
        btn1.Name = "btn1"
        btn1.Size = New Size(75, 23)
        btn1.TabIndex = 2
        btn1.Text = "Book Now"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' hstyLink
        ' 
        hstyLink.AutoSize = True
        hstyLink.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        hstyLink.LinkColor = Color.White
        hstyLink.Location = New Point(680, 20)
        hstyLink.Name = "hstyLink"
        hstyLink.Size = New Size(52, 15)
        hstyLink.TabIndex = 3
        hstyLink.TabStop = True
        hstyLink.Text = "History"
        ' 
        ' lb1
        ' 
        lb1.AutoSize = True
        lb1.BackColor = Color.Silver
        lb1.Location = New Point(301, 120)
        lb1.Name = "lb1"
        lb1.Size = New Size(0, 15)
        lb1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(235, 33)
        Label1.TabIndex = 7
        Label1.Text = "TRAVEL ADVISOR"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.SaddleBrown
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Snow
        Label2.Location = New Point(23, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(239, 42)
        Label2.TabIndex = 8
        Label2.Text = "Affordable Tour Package With" & vbCrLf & "Guide And Car"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(593, 20)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(50, 15)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Logout"
        ' 
        ' userPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(800, 450)
        Controls.Add(LinkLabel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lb1)
        Controls.Add(hstyLink)
        Controls.Add(btn1)
        ForeColor = Color.White
        Name = "userPage"
        Text = "userPage"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btn1 As Button
    Friend WithEvents hstyLink As LinkLabel
    Friend WithEvents lb1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
