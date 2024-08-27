Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1



    Dim Operator_seclector As Boolean = False
    Dim operators As Decimal

    Dim ProgressBar1
    Dim Increment

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Plus.Click



    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles One.Click
        If TextBox2.Text <> "1 " Then
            TextBox2.Text += "1"
        Else
            TextBox2.Text = "1"
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Two.Click
        If TextBox2.Text <> "2 " Then
            TextBox2.Text += "2"
        Else
            TextBox2.Text = "2"
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Times.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Devide.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Nine.Click
        If TextBox2.Text <> "9" Then
            TextBox2.Text += "9"
        Else
            TextBox2.Text = "9"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Six.Click
        If TextBox2.Text <> "6" Then
            TextBox2.Text += "6"
        Else
            TextBox2.Text = "6"
        End If
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles zero.Click, Plus.Click
        If TextBox2.Text <> "0 " Then
            TextBox2.Text += "0"
        Else
            TextBox2.Text = "0"
        End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Minus.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Equals.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Eight.Click
        If TextBox2.Text <> "8" Then
            TextBox2.Text += "8"
        Else
            TextBox2.Text = "8"
        End If
    End Sub

    Private Sub three_Click(sender As Object, e As EventArgs) Handles three.Click
        If TextBox2.Text <> "3" Then
            TextBox2.Text += "3"
        Else
            TextBox2.Text = "3"
        End If

    End Sub

    Private Sub Five_Click(sender As Object, e As EventArgs) Handles Five.Click
        If TextBox2.Text <> "5" Then
            TextBox2.Text += "5"
        Else
            TextBox2.Text = "5"
        End If
    End Sub

    Private Sub Four_Click(sender As Object, e As EventArgs) Handles Four.Click
        If TextBox2.Text <> "4" Then
            TextBox2.Text += "4"
        Else
            TextBox2.Text = "4"
        End If
    End Sub

    Private Sub Seven_Click(sender As Object, e As EventArgs) Handles Seven.Click
        If TextBox2.Text <> "7" Then
            TextBox2.Text += "7"
        Else
            TextBox2.Text = "7"
        End If
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub
End Class
