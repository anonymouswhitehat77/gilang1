Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement



Public Class Form1
    Public Class lingkaran
        Public jari_jari As Single
        Const phi = 3.14

        Public Function luas_lingkaran() As Double
            Return phi * jari_jari * jari_jari
        End Function
        Public Function keliling_lingkaran() As Double
            Return 2 * phi * jari_jari * jari_jari
        End Function
    End Class
    Public Class tabung
        Public tinggi As Single
        Public jari_jari As Single
        Const phi = 3.14
        Public Function volume_tabung() As Double
            Return phi * jari_jari * jari_jari * tinggi
        End Function
    End Class
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        Dim objlingkaran As New lingkaran
        With objlingkaran
            .jari_jari = jari_jari.Text
            luas_lingakran.Text = .luas_lingkaran()
            keliling_lingkaran.Text = .keliling_lingkaran()
        End With
    End Sub

    Private Sub jari_jari_TextChanged(sender As Object, e As EventArgs) Handles jari_jari.TextChanged

    End Sub

    Private Sub hit_tabung_Click(sender As Object, e As EventArgs) Handles hit_tabung.Click
        Dim objtabung As New tabung
        With objtabung
            .tinggi = Tinggi.Text
            .jari_jari = jarijari.Text
            volume_tabung.Text = .volume_tabung
        End With
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
