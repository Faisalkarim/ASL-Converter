Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub



    Private Sub BtM_Click(sender As Object, e As EventArgs) Handles BtZ.Click, BtY.Click, BtX.Click, BtW.Click, BtV.Click, BtU.Click, BtT.Click,
                                                                    BtS.Click, BtR.Click, BtQ.Click, BtP.Click, BtO.Click, BtN.Click, BtM.Click,
                                                                    BtL.Click, BtK.Click, BtJ.Click, BtI.Click, BtH.Click, BtG.Click, BtF.Click,
                                                                    BtE.Click, BtD.Click, BtC.Click, BtB.Click, BtA.Click
        TB1.Text = TB1.Text + Replace(sender.name, "Bt", "")


    End Sub



    Private Sub BtEnter_Click(sender As Object, e As EventArgs) Handles BtEnter.Click
        If sender Is BtEnter Then TB1.Text = TB1.Text & vbNewLine
    End Sub
    Private Sub BtBackspace_Click(sender As Object, e As EventArgs) Handles BtBackspace.Click
        If sender Is BtBackspace Then TB1.Text = TB1.Text.Substring(0, TB1.Text.Length - 1)
    End Sub
    Private Sub BtSpace_Click(sender As Object, e As EventArgs) Handles BtSpace.Click
        If sender Is BtSpace Then TB1.Text = TB1.Text & " "
    End Sub
    Private Sub BtClear_Click(sender As Object, e As EventArgs) Handles BtClear.Click
        If sender Is BtClear Then TB1.Text = TB1.Text.Substring(0, 0)
    End Sub

    Private Sub Redirect_Click(sender As Object, e As EventArgs) Handles Redirect.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SAPI As Object
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(TB1.Text)
        Exit Sub
    End Sub
End Class

