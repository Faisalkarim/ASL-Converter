Imports System.Speech.Recognition
Public Class Form2
    Public Shared Function ResizeImage(ByVal InputImage As Image) As Image
        Return New Bitmap(InputImage, New Size(92, 110))
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private WithEvents listener As New SpeechRecognizer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listener.LoadGrammar(New DictationGrammar)
    End Sub

    Private Sub listener_SpeechRecognized(sender As Object, e As SpeechRecognizedEventArgs) Handles listener.SpeechRecognized
        TextBox1.Text = e.Result.Text
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'System.Diagnostics.Debug.WriteLine(My.Resources.ResourceManager.GetObject("A"))
        Dim s As String
        s = TextBox1.Text
        Dim ships(10) As PictureBox
        ships(0) = PictureBox1
        ships(0).Visible = False
        ships(1) = PictureBox2
        ships(1).Visible = False
        ships(2) = PictureBox3
        ships(2).Visible = False
        ships(3) = PictureBox4
        ships(3).Visible = False
        ships(4) = PictureBox5
        ships(4).Visible = False
        ships(5) = PictureBox6
        ships(5).Visible = False
        ships(6) = PictureBox7
        ships(6).Visible = False
        ships(7) = PictureBox8
        ships(7).Visible = False
        ships(8) = PictureBox9
        ships(8).Visible = False
        ships(9) = PictureBox10
        ships(9).Visible = False

        For i = 0 To s.Length - 1
            Dim cha As Char
            cha = s.Chars(i)

            If (cha = " ") Then

                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("blank"))


            End If

            If (cha = "a" Or cha = "A") Then


                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("A"))




            End If

            If (cha = "b" Or cha = "B") Then

                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("B"))
            End If
            If (cha = "c" Or cha = "C") Then


                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("C"))



            End If

            If (cha = "d" Or cha = "D") Then

                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("D"))
            End If
            If (cha = "e" Or cha = "E") Then


                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("E"))



            End If

            If (cha = "f" Or cha = "F") Then

                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("F"))
            End If
            If (cha = "g" Or cha = "G") Then


                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("G"))



            End If

            If (cha = "h" Or cha = "H") Then

                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("H"))
            End If
            If (cha = "i" Or cha = "I") Then


                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("I"))



            End If

            If (cha = "j" Or cha = "J") Then

                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("J"))
            End If
            If (cha = "k" Or cha = "K") Then


                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("K"))



            End If

            If (cha = "l" Or cha = "L") Then

                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("L"))
            End If
            If (cha = "m" Or cha = "M") Then


                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("M"))



            End If

            If (cha = "n" Or cha = "N") Then

                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("N"))
            End If
            If (cha = "o" Or cha = "O") Then


                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("O"))



            End If

            If (cha = "p" Or cha = "P") Then

                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("P"))
            End If
            If (cha = "q" Or cha = "Q") Then


                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("Q"))



            End If

            If (cha = "r" Or cha = "R") Then

                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("R"))
            End If
            If (cha = "s" Or cha = "S") Then


                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("S"))



            End If

            If (cha = "t" Or cha = "T") Then

                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("T"))
            End If
            If (cha = "u" Or cha = "U") Then


                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("U"))



            End If

            If (cha = "v" Or cha = "V") Then

                ships(i).Visible = True
                ships(i).Image = My.Resources.ResourceManager.GetObject("V")
            End If
            If (cha = "w" Or cha = "W") Then


                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("W"))



            End If

            If (cha = "x" Or cha = "X") Then

                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("X"))
            End If
            If (cha = "y" Or cha = "Y") Then


                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("Y"))



            End If

            If (cha = "z" Or cha = "Z") Then

                ships(i).Visible = True
                ships(i).Image = ResizeImage(My.Resources.ResourceManager.GetObject("Z"))
            End If
        Next
        Exit Sub
        Application.Exit()
    End Sub
End Class