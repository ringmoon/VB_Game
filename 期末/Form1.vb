Imports System.IO
Public Class Form1

    Dim card() As String = {"水精靈.jpg", "胖丁.jpg", "皮卡丘.jpg", "波克比.jpg", "櫻花.jpg", "波比.jpg", "迷糊.jpg", "小火龍.jpg", "小小可.jpg", "小小兔.jpg"}
    Dim guess1(9) As String
    Dim guess2(9) As String
    Dim num(9) As Integer
    Dim variance(19) As Integer
    Dim guess(19) As String
    Dim compare(1) As String
    Dim time As Integer = 5
    Dim count As Integer = 0
    Dim score As Integer = 0
    Dim amount As Integer = 0
    Dim a As Integer = 0
    Dim b As Integer = 0
    Dim success As Integer = 0
    Dim fail As Integer = 0
    Dim correct As Boolean = False
    Dim rank As Integer = 1
    Dim score_list(10) As Integer
    Dim f1 As New FileInfo("score_list.txt")
    Dim f2 As New FileInfo("score_list.txt")
    Dim f3 As New FileInfo("score_list.txt")
    Dim sr1 As StreamReader
    Dim sw1 As StreamWriter
    Dim sw2 As StreamWriter
    Sub first_set()
        Button1.Enabled = True
        Button2.Enabled = False
        Label7.Visible = False
        Label3.Text = "按開始進行遊戲"
        Dim i, j, rand As Integer
        For i = 0 To 9
again:
            Dim r As New Random()
            rand = r.Next(0, 10)
            guess1(i) = card(rand)
            guess2(i) = card(rand)
            num(i) = rand
            If i >= 1 Then
                For j = 1 To i
                    If num(i) = num(j - 1) Then
                        GoTo again
                    End If
                Next
            End If
        Next
        For i = 0 To 9
            guess(i) = guess1(i)
        Next
        For j = 0 To 9
            guess(j + 10) = guess2(j)
        Next
        For i = 0 To 19
replay:
            Dim r As New Random()
            rand = r.Next(0, 20)
            variance(i) = rand
            If i >= 1 Then
                For j = 1 To i
                    If variance(i) = variance(j - 1) Then
                        GoTo replay
                    End If
                Next
            End If
        Next
    End Sub
    Sub reset()
        Label3.Text = "按開始進行遊戲"
        PictureBox1.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox2.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox3.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox4.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox5.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox6.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox7.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox8.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox9.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox10.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox11.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox12.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox13.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox14.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox15.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox16.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox17.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox18.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox19.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox20.Image = Image.FromFile("神奇寶貝球.jpg")
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        PictureBox8.Visible = True
        PictureBox9.Visible = True
        PictureBox10.Visible = True
        PictureBox11.Visible = True
        PictureBox12.Visible = True
        PictureBox13.Visible = True
        PictureBox14.Visible = True
        PictureBox15.Visible = True
        PictureBox16.Visible = True
        PictureBox17.Visible = True
        PictureBox18.Visible = True
        PictureBox19.Visible = True
        PictureBox20.Visible = True
        amount = 0
        TextBox1.Text = amount
        score = 0
        TextBox2.Text = score
        fail = 0
        TextBox4.Text = 0
        success = 0
        TextBox3.Text = success
        count = 0
        a = 0
        b = 0
        PictureBox25.Visible = False
        Label6.Visible = False
        time = 5
        rank = 1
        Label7.Text = ""
    End Sub
    Sub begin()
        PictureBox1.Image = Image.FromFile(guess(variance(0)))
        PictureBox2.Image = Image.FromFile(guess(variance(1)))
        PictureBox3.Image = Image.FromFile(guess(variance(2)))
        PictureBox4.Image = Image.FromFile(guess(variance(3)))
        PictureBox5.Image = Image.FromFile(guess(variance(4)))
        PictureBox6.Image = Image.FromFile(guess(variance(5)))
        PictureBox7.Image = Image.FromFile(guess(variance(6)))
        PictureBox8.Image = Image.FromFile(guess(variance(7)))
        PictureBox9.Image = Image.FromFile(guess(variance(8)))
        PictureBox10.Image = Image.FromFile(guess(variance(9)))
        PictureBox11.Image = Image.FromFile(guess(variance(10)))
        PictureBox12.Image = Image.FromFile(guess(variance(11)))
        PictureBox13.Image = Image.FromFile(guess(variance(12)))
        PictureBox14.Image = Image.FromFile(guess(variance(13)))
        PictureBox15.Image = Image.FromFile(guess(variance(14)))
        PictureBox16.Image = Image.FromFile(guess(variance(15)))
        PictureBox17.Image = Image.FromFile(guess(variance(16)))
        PictureBox18.Image = Image.FromFile(guess(variance(17)))
        PictureBox19.Image = Image.FromFile(guess(variance(18)))
        PictureBox20.Image = Image.FromFile(guess(variance(19)))
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer1.Interval = 6000
        Timer2.Interval = 1000
        Label3.Enabled = True
        Label3.Text = "你還剩 6 秒鐘"
        Label3.ForeColor = Color.Red
        Button1.Enabled = False
        Button2.Enabled = True
    End Sub
    Sub fail_run()
        If correct = False Then
            If a = 1 Then
                PictureBox1.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 2 Then
                PictureBox2.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 3 Then
                PictureBox3.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 4 Then
                PictureBox4.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 5 Then
                PictureBox5.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 6 Then
                PictureBox6.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 7 Then
                PictureBox7.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 8 Then
                PictureBox8.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 9 Then
                PictureBox9.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 10 Then
                PictureBox10.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 11 Then
                PictureBox11.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 12 Then
                PictureBox12.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 13 Then
                PictureBox13.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 14 Then
                PictureBox14.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 15 Then
                PictureBox15.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 16 Then
                PictureBox16.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 17 Then
                PictureBox17.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 18 Then
                PictureBox18.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 19 Then
                PictureBox19.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 20 Then
                PictureBox20.Image = Image.FromFile("神奇寶貝球.jpg")
            End If
            If b = 1 Then
                PictureBox1.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 2 Then
                PictureBox2.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 3 Then
                PictureBox3.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 4 Then
                PictureBox4.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 5 Then
                PictureBox5.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 6 Then
                PictureBox6.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 7 Then
                PictureBox7.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 8 Then
                PictureBox8.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 9 Then
                PictureBox9.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 10 Then
                PictureBox10.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 11 Then
                PictureBox11.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 12 Then
                PictureBox12.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 13 Then
                PictureBox13.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 14 Then
                PictureBox14.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 15 Then
                PictureBox15.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 16 Then
                PictureBox16.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 17 Then
                PictureBox17.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 18 Then
                PictureBox18.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 19 Then
                PictureBox19.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf b = 20 Then
                PictureBox20.Image = Image.FromFile("神奇寶貝球.jpg")
            End If
        End If
        If correct = True Then
            If a = 1 Then
                PictureBox1.Visible = False
            ElseIf a = 2 Then
                PictureBox2.Visible = False
            ElseIf a = 3 Then
                PictureBox3.Visible = False
            ElseIf a = 4 Then
                PictureBox4.Visible = False
            ElseIf a = 5 Then
                PictureBox5.Visible = False
            ElseIf a = 6 Then
                PictureBox6.Visible = False
            ElseIf a = 7 Then
                PictureBox7.Visible = False
            ElseIf a = 8 Then
                PictureBox8.Visible = False
            ElseIf a = 9 Then
                PictureBox9.Visible = False
            ElseIf a = 10 Then
                PictureBox10.Visible = False
            ElseIf a = 11 Then
                PictureBox11.Visible = False
            ElseIf a = 12 Then
                PictureBox12.Visible = False
            ElseIf a = 13 Then
                PictureBox13.Visible = False
            ElseIf a = 14 Then
                PictureBox14.Visible = False
            ElseIf a = 15 Then
                PictureBox15.Visible = False
            ElseIf a = 16 Then
                PictureBox16.Visible = False
            ElseIf a = 17 Then
                PictureBox17.Visible = False
            ElseIf a = 18 Then
                PictureBox18.Visible = False
            ElseIf a = 19 Then
                PictureBox19.Visible = False
            ElseIf a = 20 Then
                PictureBox20.Visible = False
            End If
            If b = 1 Then
                PictureBox1.Visible = False
            ElseIf b = 2 Then
                PictureBox2.Visible = False
            ElseIf b = 3 Then
                PictureBox3.Visible = False
            ElseIf b = 4 Then
                PictureBox4.Visible = False
            ElseIf b = 5 Then
                PictureBox5.Visible = False
            ElseIf b = 6 Then
                PictureBox6.Visible = False
            ElseIf b = 7 Then
                PictureBox7.Visible = False
            ElseIf b = 8 Then
                PictureBox8.Visible = False
            ElseIf b = 9 Then
                PictureBox9.Visible = False
            ElseIf b = 10 Then
                PictureBox10.Visible = False
            ElseIf b = 11 Then
                PictureBox11.Visible = False
            ElseIf b = 12 Then
                PictureBox12.Visible = False
            ElseIf b = 13 Then
                PictureBox13.Visible = False
            ElseIf b = 14 Then
                PictureBox14.Visible = False
            ElseIf b = 15 Then
                PictureBox15.Visible = False
            ElseIf b = 16 Then
                PictureBox16.Visible = False
            ElseIf b = 17 Then
                PictureBox17.Visible = False
            ElseIf b = 18 Then
                PictureBox18.Visible = False
            ElseIf b = 19 Then
                PictureBox19.Visible = False
            ElseIf b = 20 Then
                PictureBox20.Visible = False
            End If
            correct = False
        End If
        a = 0
        b = 0
        count = 0
    End Sub
    Sub success_run()
        amount += 1
        TextBox1.Text = amount
        If b = a Then
            If a = 1 Then
                PictureBox1.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 2 Then
                PictureBox2.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 3 Then
                PictureBox3.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 4 Then
                PictureBox4.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 5 Then
                PictureBox5.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 6 Then
                PictureBox6.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 7 Then
                PictureBox7.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 8 Then
                PictureBox8.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 9 Then
                PictureBox9.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 10 Then
                PictureBox10.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 11 Then
                PictureBox11.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 12 Then
                PictureBox12.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 13 Then
                PictureBox13.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 14 Then
                PictureBox14.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 15 Then
                PictureBox15.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 16 Then
                PictureBox16.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 17 Then
                PictureBox17.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 18 Then
                PictureBox18.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 19 Then
                PictureBox19.Image = Image.FromFile("神奇寶貝球.jpg")
            ElseIf a = 20 Then
                PictureBox20.Image = Image.FromFile("神奇寶貝球.jpg")
            End If
            MessageBox.Show("請勿重複點選同個卡牌,扣10分!!", "警告")
            score -= 10
            TextBox2.Text = score
            a = 0
            b = 0
        Else
            If compare(count) = compare(count - 1) Then
                If success < 10 Then
                    Label3.Text = "居然被你猜對了 !!"
                End If
                score += 20
                TextBox2.Text = score
                success += 1
                TextBox3.Text = success
                correct = True
                If success = 10 Then
                    Label3.Text = "遊戲結束!!"
                    If a = 1 Then
                        PictureBox1.Visible = False
                    ElseIf a = 2 Then
                        PictureBox2.Visible = False
                    ElseIf a = 3 Then
                        PictureBox3.Visible = False
                    ElseIf a = 4 Then
                        PictureBox4.Visible = False
                    ElseIf a = 5 Then
                        PictureBox5.Visible = False
                    ElseIf a = 6 Then
                        PictureBox6.Visible = False
                    ElseIf a = 7 Then
                        PictureBox7.Visible = False
                    ElseIf a = 8 Then
                        PictureBox8.Visible = False
                    ElseIf a = 9 Then
                        PictureBox9.Visible = False
                    ElseIf a = 10 Then
                        PictureBox10.Visible = False
                    ElseIf a = 11 Then
                        PictureBox11.Visible = False
                    ElseIf a = 12 Then
                        PictureBox12.Visible = False
                    ElseIf a = 13 Then
                        PictureBox13.Visible = False
                    ElseIf a = 14 Then
                        PictureBox14.Visible = False
                    ElseIf a = 15 Then
                        PictureBox15.Visible = False
                    ElseIf a = 16 Then
                        PictureBox16.Visible = False
                    ElseIf a = 17 Then
                        PictureBox17.Visible = False
                    ElseIf a = 18 Then
                        PictureBox18.Visible = False
                    ElseIf a = 19 Then
                        PictureBox19.Visible = False
                    ElseIf a = 20 Then
                        PictureBox20.Visible = False
                    End If
                    If b = 1 Then
                        PictureBox1.Visible = False
                    ElseIf b = 2 Then
                        PictureBox2.Visible = False
                    ElseIf b = 3 Then
                        PictureBox3.Visible = False
                    ElseIf b = 4 Then
                        PictureBox4.Visible = False
                    ElseIf b = 5 Then
                        PictureBox5.Visible = False
                    ElseIf b = 6 Then
                        PictureBox6.Visible = False
                    ElseIf b = 7 Then
                        PictureBox7.Visible = False
                    ElseIf b = 8 Then
                        PictureBox8.Visible = False
                    ElseIf b = 9 Then
                        PictureBox9.Visible = False
                    ElseIf b = 10 Then
                        PictureBox10.Visible = False
                    ElseIf b = 11 Then
                        PictureBox11.Visible = False
                    ElseIf b = 12 Then
                        PictureBox12.Visible = False
                    ElseIf b = 13 Then
                        PictureBox13.Visible = False
                    ElseIf b = 14 Then
                        PictureBox14.Visible = False
                    ElseIf b = 15 Then
                        PictureBox15.Visible = False
                    ElseIf b = 16 Then
                        PictureBox16.Visible = False
                    ElseIf b = 17 Then
                        PictureBox17.Visible = False
                    ElseIf b = 18 Then
                        PictureBox18.Visible = False
                    ElseIf b = 19 Then
                        PictureBox19.Visible = False
                    ElseIf b = 20 Then
                        PictureBox20.Visible = False
                    End If
                    sr1 = f2.OpenText()
                    Dim i As Integer = 0
                    For i = 0 To 9
                        score_list(i) = sr1.ReadLine()
                    Next
                    sr1.Close()
                    If f2.Exists Then
                        sw2 = f3.CreateText()
                        sw2.Close()
                    End If
                    PictureBox25.Visible = True
                    Label7.Visible = True
                    Label6.Visible = True
                    score_list(10) = score
                    Array.Sort(score_list)
                    Array.Reverse(score_list)
                    For j = 0 To 9
                        Label7.Text &= "第 " & rank & " 名：" & score_list(j) & "分" & vbCrLf
                        rank += 1
                    Next
                    sw1 = f1.AppendText()
                    For j = 0 To 9
                        sw1.WriteLine(score_list(j))
                    Next
                    sw1.Flush()
                    sw1.Close()
                End If
            Else
                Label3.Text = "猜錯囉，加油!!"
                fail += 1
                TextBox4.Text = fail
                score -= 10
                TextBox2.Text = score
            End If
        End If
    End Sub
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Timer2.Enabled = False
        AxWindowsMediaPlayer1.settings.playCount = &H7FFFFFFF
        first_set()
    End Sub
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        begin()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If count < 2 Then
            compare(count) = guess(variance(0))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(0))
            fail_run()
        End If
        PictureBox1.Image = Image.FromFile(guess(variance(0)))
        If count = 0 Then
            a = 1
        End If
        If count = 1 Then
            b = 1
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If count < 2 Then
            compare(count) = guess(variance(1))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(1))
            fail_run()
        End If
        PictureBox2.Image = Image.FromFile(guess(variance(1)))
        If count = 0 Then
            a = 2
        End If
        If count = 1 Then
            b = 2
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If count < 2 Then
            compare(count) = guess(variance(2))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(2))
            fail_run()
        End If
        PictureBox3.Image = Image.FromFile(guess(variance(2)))
        If count = 0 Then
            a = 3
        End If
        If count = 1 Then
            b = 3
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If count < 2 Then
            compare(count) = guess(variance(3))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(3))
            fail_run()
        End If
        PictureBox4.Image = Image.FromFile(guess(variance(3)))
        If count = 0 Then
            a = 4
        End If
        If count = 1 Then
            b = 4
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If count < 2 Then
            compare(count) = guess(variance(15))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(15))
            fail_run()
        End If
        PictureBox16.Image = Image.FromFile(guess(variance(15)))
        If count = 0 Then
            a = 16
        End If
        If count = 1 Then
            b = 16
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If count < 2 Then
            compare(count) = guess(variance(16))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(16))
            fail_run()
        End If
        PictureBox17.Image = Image.FromFile(guess(variance(16)))
        If count = 0 Then
            a = 17
        End If
        If count = 1 Then
            b = 17
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        If count < 2 Then
            compare(count) = guess(variance(18))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(18))
            fail_run()
        End If
        PictureBox19.Image = Image.FromFile(guess(variance(18)))
        If count = 0 Then
            a = 19
        End If
        If count = 1 Then
            b = 19
            success_run()
        End If
        count += 1
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        reset()
        Label3.Text = "   遊戲開始 !!"
        Timer1.Enabled = False
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label3.Text = "你還剩 " & time & " 秒鐘"
        time -= 1
        If time = 0 Then
            Timer2.Enabled = False
        End If
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If count < 2 Then
            compare(count) = guess(variance(4))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(4))
            fail_run()
        End If
        PictureBox5.Image = Image.FromFile(guess(variance(4)))
        If count = 0 Then
            a = 5
        End If
        If count = 1 Then
            b = 5
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If count < 2 Then
            compare(count) = guess(variance(9))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(9))
            fail_run()
        End If
        PictureBox10.Image = Image.FromFile(guess(variance(9)))
        If count = 0 Then
            a = 10
        End If
        If count = 1 Then
            b = 10
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If count < 2 Then
            compare(count) = guess(variance(8))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(8))
            fail_run()
        End If
        PictureBox9.Image = Image.FromFile(guess(variance(8)))
        If count = 0 Then
            a = 9
        End If
        If count = 1 Then
            b = 9
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If count < 2 Then
            compare(count) = guess(variance(7))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(7))
            fail_run()
        End If
        PictureBox8.Image = Image.FromFile(guess(variance(7)))
        If count = 0 Then
            a = 8
        End If
        If count = 1 Then
            b = 8
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If count < 2 Then
            compare(count) = guess(variance(6))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(6))
            fail_run()
        End If
        PictureBox7.Image = Image.FromFile(guess(variance(6)))
        If count = 0 Then
            a = 7
        End If
        If count = 1 Then
            b = 7
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If count < 2 Then
            compare(count) = guess(variance(5))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(5))
            fail_run()
        End If
        PictureBox6.Image = Image.FromFile(guess(variance(5)))
        If count = 0 Then
            a = 6
        End If
        If count = 1 Then
            b = 6
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        If count < 2 Then
            compare(count) = guess(variance(14))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(14))
            fail_run()
        End If
        PictureBox15.Image = Image.FromFile(guess(variance(14)))
        If count = 0 Then
            a = 15
        End If
        If count = 1 Then
            b = 15
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If count < 2 Then
            compare(count) = guess(variance(13))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(13))
            fail_run()
        End If
        PictureBox14.Image = Image.FromFile(guess(variance(13)))
        If count = 0 Then
            a = 14
        End If
        If count = 1 Then
            b = 14
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        If count < 2 Then
            compare(count) = guess(variance(12))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(12))
            fail_run()
        End If
        PictureBox13.Image = Image.FromFile(guess(variance(12)))
        If count = 0 Then
            a = 13
        End If
        If count = 1 Then
            b = 13
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If count < 2 Then
            compare(count) = guess(variance(11))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(11))
            fail_run()
        End If
        PictureBox12.Image = Image.FromFile(guess(variance(11)))
        If count = 0 Then
            a = 12
        End If
        If count = 1 Then
            b = 12
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If count < 2 Then
            compare(count) = guess(variance(10))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(10))
            fail_run()
        End If
        PictureBox11.Image = Image.FromFile(guess(variance(10)))
        If count = 0 Then
            a = 11
        End If
        If count = 1 Then
            b = 11
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        If count < 2 Then
            compare(count) = guess(variance(19))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(19))
            fail_run()
        End If
        PictureBox20.Image = Image.FromFile(guess(variance(19)))
        If count = 0 Then
            a = 20
        End If
        If count = 1 Then
            b = 20
            success_run()
        End If
        count += 1
    End Sub
    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        If count < 2 Then
            compare(count) = guess(variance(17))
        End If
        If count = 2 Then
            compare(count - 2) = guess(variance(17))
            fail_run()
        End If
        PictureBox18.Image = Image.FromFile(guess(variance(17)))
        If count = 0 Then
            a = 18
        End If
        If count = 1 Then
            b = 18
            success_run()
        End If
        count += 1
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        first_set()
        reset()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
