'Name: Gabriel Whatley
'Date : 1/31/24
'Class: CPSC 3118 - Graphical User Interface Development - CRN:21416
'Instructor: Bruce Montgomery
'Program Description: Program that teaches the user how to pronouce numerals one through five in French.
Public Class frmNumbers

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        SetFrBox("un")
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        SetFrBox("deux")
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        SetFrBox("trois")
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        SetFrBox("quatre")
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        SetFrBox("cinq")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub SetFrBox(s As String) 'Sets the value of the text in textBoxFrench to the string supplied by the caller. If the text box is invisible, shows it.
        textBoxFrench.Text = s
        If textBoxFrench.Visible = False Then textBoxFrench.Visible = True
    End Sub
End Class
