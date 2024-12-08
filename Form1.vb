Public Class Form1
    Dim A As String
    Dim B As String
    Dim op = ""
    Private Sub B0_Click(sender As Object, e As EventArgs) Handles B0.Click
        If op = "" Then
            A = A + "0"
        Else
            B = B + "0"

        End If
        Text_affiche.Text = A + " " + op + "" + B
    End Sub

    Private Sub BTN13_Click(sender As Object, e As EventArgs) Handles BTN13.Click
        If Not A = " " Then
            op = "*"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub


    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        If op = "" Then
            A = A + "1"
        Else
            B = B + "1"

        End If
        Text_affiche.Text = A + " " + op + "" + B

    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        If op = "" Then
            A = A + "2"
        Else
            B = B + "2"

        End If
        Text_affiche.Text = A + " " + op + "" + B

    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If op = "" Then
            A = A + "3"
        Else
            B = B + "3"

        End If
        Text_affiche.Text = A + " " + op + "" + B

    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        If op = "" Then
            A = A + "4"
        Else
            B = B + "4"

        End If
        Text_affiche.Text = A + " " + op + "" + B

    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        If op = "" Then
            A = A + "5"
        Else
            B = B + "5"

        End If
        Text_affiche.Text = A + " " + op + "" + B

    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        If op = "" Then
            A = A + "6"
        Else
            B = B + "6"

        End If
        Text_affiche.Text = A + " " + op + "" + B

    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        If op = "" Then
            A = A + "7"
        Else
            B = B + "7"

        End If
        Text_affiche.Text = A + " " + op + "" + B

    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        If op = "" Then
            A = A + "8"
        Else
            B = B + "8"

        End If
        Text_affiche.Text = A + " " + op + "" + B

    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        If op = "" Then
            A = A + "9"
        Else
            B = B + "9"

        End If
        Text_affiche.Text = A + " " + op + "" + B

    End Sub

    Private Sub BTN11_Click(sender As Object, e As EventArgs) Handles BTN11.Click
        Dim test = True
        Dim res As Double
        If IsNumeric(A) And IsNumeric(B) And Not op = "" Then
            Dim va = Integer.Parse(A)
            Dim vb = Integer.Parse(B)
            If op = "+" Then
                res = va + vb
            ElseIf op = "-" Then
                res = va - vb
            ElseIf op = "*" Then
                res = va * vb
            ElseIf op = "/" And Not op = "" Then
                res = va / vb
            Else
                MessageBox.Show("a et b devient etre des entiers")
                test = False



            End If
            If test Then
                Text_affiche.Text = Text_affiche.Text + "=" + res.ToString
            End If

        End If

    End Sub

    Private Sub BTN14_Click(sender As Object, e As EventArgs) Handles BTN14.Click
        If Not A = " " Then
            op = "-"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub BTN15_Click(sender As Object, e As EventArgs) Handles BTN15.Click
        If Not A = " " Then
            op = "+"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub BTN16_Click(sender As Object, e As EventArgs) Handles BTN16.Click
        If Not A = " " Then
            op = "/"
        End If
        Text_affiche.Text = A + " " + op + " " + B
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN10_Click(sender As Object, e As EventArgs) Handles BTN10.Click
        Text_affiche.Text = ""
        A = ""
        B = ""
        op = ""
    End Sub
End Class
