Public Class Form1

    ' Setup '
    Dim TLState As String
    Private TLStateOpts As String() = {"red", "red_amber", "amber", "green"}

    ' Timer for automatic cycling '
    Private WithEvents cycleTimer As New Timer()

    ' Form load event to initialize the state and image '
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picTrafficLight.Image = My.Resources.red
        TLState = TLStateOpts(0)

        ' Configure the timer interval (e.g., 1 second = 1000ms) '
        cycleTimer.Interval = 2000
    End Sub

    ' Exit button '
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    ' Red light button '
    Private Sub btnTLRed_Click(sender As Object, e As EventArgs) Handles btnTLRed.Click
        picTrafficLight.Image = My.Resources.red
        TLState = TLStateOpts(0)
    End Sub

    ' Red/Amber light button '
    Private Sub btnTLRedAmber_Click(sender As Object, e As EventArgs) Handles btnTLRedAmber.Click
        picTrafficLight.Image = My.Resources.red_amber
        TLState = TLStateOpts(1)
    End Sub

    ' Green light button '
    Private Sub btnTLGreen_Click(sender As Object, e As EventArgs) Handles btnTLGreen.Click
        picTrafficLight.Image = My.Resources.green
        TLState = TLStateOpts(3)
    End Sub

    ' Amber light button '
    Private Sub btnTLAmber_Click(sender As Object, e As EventArgs) Handles btnTLAmber.Click
        picTrafficLight.Image = My.Resources.amber
        TLState = TLStateOpts(2)
    End Sub

    ' Change light button '
    Private Sub btnTLChangeLight_Click(sender As Object, e As EventArgs) Handles btnTLChangeLight.Click
        ChangeToNextLight()
    End Sub

    ' Timer Tick event handler '
    Private Sub cycleTimer_Tick(sender As Object, e As EventArgs) Handles cycleTimer.Tick
        ChangeToNextLight()
    End Sub

    ' Start Timer button '
    Private Sub btnTimerStart_Click(sender As Object, e As EventArgs) Handles btnTimerStart.Click
        cycleTimer.Start()
    End Sub

    ' Stop Timer button '
    Private Sub btnTimerStop_Click(sender As Object, e As EventArgs) Handles btnTimerStop.Click
        cycleTimer.Stop()
    End Sub

    ' Helper method to move to next light state '
    Private Sub ChangeToNextLight()
        Dim currentIndex As Integer = Array.IndexOf(TLStateOpts, TLState)
        If currentIndex = -1 Then currentIndex = 0
        Dim nextIndex As Integer = (currentIndex + 1) Mod TLStateOpts.Length

        Select Case TLStateOpts(nextIndex)
            Case "red"
                picTrafficLight.Image = My.Resources.red
            Case "red_amber"
                picTrafficLight.Image = My.Resources.red_amber
            Case "amber"
                picTrafficLight.Image = My.Resources.amber
            Case "green"
                picTrafficLight.Image = My.Resources.green
        End Select

        TLState = TLStateOpts(nextIndex)
    End Sub

End Class
