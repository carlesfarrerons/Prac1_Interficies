Public Class Form1
    Dim posicioInicialX
    Dim posicioInicialY
    Dim posicioFinalX
    Dim posicioFinalY
    Dim ratoli
    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick

        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Text = " "
            e.SuppressKeyPress = True

        ElseIf e.KeyCode = Keys.I Or e.KeyCode = Keys.L Then

            Me.Text = StrReverse(Me.Text)
            e.SuppressKeyPress = True

        End If

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        Me.Text = Me.Text + e.KeyChar

    End Sub
    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Me.Text = "altura: " + CStr(Size.Height) + " amplada: " + CStr(Size.Width)

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        posicioInicialX = e.X
        posicioInicialY = e.Y

    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        posicioFinalX = e.X
        posicioFinalY = e.Y
        If (e.Button = MouseButtons.Right) Then
            ratoli = "   DRETA"
        Else
            ratoli = "   ESQUERRA"
        End If
        Me.Text = "Inici X: " + CStr(posicioInicialX) + " Inici Y: " + CStr(posicioInicialY) + " Final X: " + CStr(posicioFinalX) + "Final Y: " + CStr(posicioFinalY) + ratoli

    End Sub
End Class
