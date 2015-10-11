Public Class Form1
    Dim angka As Integer
    Dim cek As Byte
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If (cekIsi()) Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text &= "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If (cekIsi()) Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text &= "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If (cekIsi()) Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text &= "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If (cekIsi()) Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text &= "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If (cekIsi()) Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text &= "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If (cekIsi()) Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text &= "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If (cekIsi()) Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text &= "7"
        End If
    End Sub

    Private Sub pls_Click(sender As Object, e As EventArgs) Handles pls.Click
        If (Me.cek = 1) Then
            Me.angka -= Convert.ToInt32(TextBox1.Text)
        Else
            Me.angka += Convert.ToInt32(TextBox1.Text)
        End If
        TextBox1.Text = Me.angka.ToString
        Me.cek = 2

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If (cekIsi()) Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text &= "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If (cekIsi()) Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text &= "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If (cekIsi()) Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text &= "0"
        End If
    End Sub
    Private Function cekIsi()
        If (TextBox1.Text.Equals("0") Or Me.cek > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.angka = 0 Or Me.cek = 2) Then
            Me.angka += Convert.ToInt32(TextBox1.Text)
        Else
            Me.angka -= Convert.ToInt32(TextBox1.Text)
        End If
        TextBox1.Text = Me.angka.ToString
        Me.cek = 1
    End Sub

    Private Sub hasil_Click(sender As Object, e As EventArgs) Handles hasil.Click
        Select Case Me.cek
            Case 1
                TextBox1.Text = Convert.ToString(Me.angka - Convert.ToInt32(TextBox1.Text))
            Case 2
                TextBox1.Text = Convert.ToString(Me.angka + Convert.ToInt32(TextBox1.Text))
        End Select
        Me.angka = 0
    End Sub

    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click
        TextBox1.Text = "0"
        Me.angka = 0
        Me.cek = 0
    End Sub
End Class
