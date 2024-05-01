<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CityCar
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
        Label1 = New Label()
        Label2 = New Label()
        rb1 = New RadioButton()
        rb5 = New RadioButton()
        rb3 = New RadioButton()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 15)
        Label1.TabIndex = 0
        Label1.Text = "City"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 2
        Label2.Text = "CarType"
        ' 
        ' rb1
        ' 
        rb1.AutoSize = True
        rb1.Location = New Point(74, 112)
        rb1.Name = "rb1"
        rb1.Size = New Size(150, 19)
        rb1.TabIndex = 3
        rb1.TabStop = True
        rb1.Text = "Guide and Car With AC"
        rb1.UseVisualStyleBackColor = True
        ' 
        ' rb5
        ' 
        rb5.AutoSize = True
        rb5.Location = New Point(74, 150)
        rb5.Name = "rb5"
        rb5.Size = New Size(174, 19)
        rb5.TabIndex = 4
        rb5.TabStop = True
        rb5.Text = "Guide and Car with Non AC"
        rb5.UseVisualStyleBackColor = True
        ' 
        ' rb3
        ' 
        rb3.AutoSize = True
        rb3.Location = New Point(74, 187)
        rb3.Name = "rb3"
        rb3.Size = New Size(86, 19)
        rb3.TabIndex = 5
        rb3.TabStop = True
        rb3.Text = "Only Guide"
        rb3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(266, 187)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Nxt"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CityCar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(rb3)
        Controls.Add(rb5)
        Controls.Add(rb1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Name = "CityCar"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb5 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents Button1 As Button
End Class
