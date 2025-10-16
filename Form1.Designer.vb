<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnExit = New Button()
        btnTLRed = New Button()
        btnTLRedAmber = New Button()
        btnTLAmber = New Button()
        btnTLGreen = New Button()
        picTrafficLight = New PictureBox()
        btnTLChangeLight = New Button()
        btnTimerStart = New Button()
        btnTimerStop = New Button()
        CType(picTrafficLight, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(296, 249)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 0
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnTLRed
        ' 
        btnTLRed.Location = New Point(236, 31)
        btnTLRed.Name = "btnTLRed"
        btnTLRed.Size = New Size(135, 23)
        btnTLRed.TabIndex = 1
        btnTLRed.Text = "Red"
        btnTLRed.UseVisualStyleBackColor = True
        ' 
        ' btnTLRedAmber
        ' 
        btnTLRedAmber.Location = New Point(236, 60)
        btnTLRedAmber.Name = "btnTLRedAmber"
        btnTLRedAmber.Size = New Size(135, 23)
        btnTLRedAmber.TabIndex = 2
        btnTLRedAmber.Text = "Red/Amber"
        btnTLRedAmber.UseVisualStyleBackColor = True
        ' 
        ' btnTLAmber
        ' 
        btnTLAmber.Location = New Point(236, 118)
        btnTLAmber.Name = "btnTLAmber"
        btnTLAmber.Size = New Size(135, 23)
        btnTLAmber.TabIndex = 4
        btnTLAmber.Text = "Amber"
        btnTLAmber.UseVisualStyleBackColor = True
        ' 
        ' btnTLGreen
        ' 
        btnTLGreen.Location = New Point(236, 89)
        btnTLGreen.Name = "btnTLGreen"
        btnTLGreen.Size = New Size(135, 23)
        btnTLGreen.TabIndex = 3
        btnTLGreen.Text = "Green"
        btnTLGreen.UseVisualStyleBackColor = True
        ' 
        ' picTrafficLight
        ' 
        picTrafficLight.Image = My.Resources.Resources.red
        picTrafficLight.Location = New Point(12, 21)
        picTrafficLight.Name = "picTrafficLight"
        picTrafficLight.Size = New Size(153, 193)
        picTrafficLight.SizeMode = PictureBoxSizeMode.StretchImage
        picTrafficLight.TabIndex = 5
        picTrafficLight.TabStop = False
        ' 
        ' btnTLChangeLight
        ' 
        btnTLChangeLight.Location = New Point(236, 147)
        btnTLChangeLight.Name = "btnTLChangeLight"
        btnTLChangeLight.Size = New Size(135, 23)
        btnTLChangeLight.TabIndex = 6
        btnTLChangeLight.Text = "Change Light"
        btnTLChangeLight.UseVisualStyleBackColor = True
        ' 
        ' btnTimerStart
        ' 
        btnTimerStart.Location = New Point(236, 176)
        btnTimerStart.Name = "btnTimerStart"
        btnTimerStart.Size = New Size(135, 23)
        btnTimerStart.TabIndex = 7
        btnTimerStart.Text = "Start Timer"
        btnTimerStart.UseVisualStyleBackColor = True
        ' 
        ' btnTimerStop
        ' 
        btnTimerStop.Location = New Point(236, 205)
        btnTimerStop.Name = "btnTimerStop"
        btnTimerStop.Size = New Size(135, 23)
        btnTimerStop.TabIndex = 8
        btnTimerStop.Text = "Stop Timer"
        btnTimerStop.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(388, 284)
        Controls.Add(btnTimerStop)
        Controls.Add(btnTimerStart)
        Controls.Add(btnTLChangeLight)
        Controls.Add(picTrafficLight)
        Controls.Add(btnTLGreen)
        Controls.Add(btnTLAmber)
        Controls.Add(btnTLRedAmber)
        Controls.Add(btnTLRed)
        Controls.Add(btnExit)
        Name = "Form1"
        Text = "Form1"
        CType(picTrafficLight, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnTLRed As Button
    Friend WithEvents btnTLRedAmber As Button
    Friend WithEvents btnTLAmber As Button
    Friend WithEvents btnTLGreen As Button
    Friend WithEvents picTrafficLight As PictureBox
    Friend WithEvents btnTLChangeLight As Button
    Friend WithEvents btnTimerStart As Button
    Friend WithEvents btnTimerStop As Button

End Class
