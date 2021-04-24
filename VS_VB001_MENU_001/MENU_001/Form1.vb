Imports MENU_001.My.Resources

Public Class frmMENU
    Private x, y As Integer
    Private newpoint As Point
    Private Sub Fechar_Click(sender As Object, e As EventArgs) Handles Fechar.Click
        Me.Close()
    End Sub

    Private Sub Fechar_MouseHover(sender As Object, e As EventArgs) Handles Fechar.MouseHover
        Fechar.BackgroundImage = Resources.FecharHover
    End Sub

    Private Sub Fechar_MouseLeave(sender As Object, e As EventArgs) Handles Fechar.MouseLeave
        Fechar.BackgroundImage = Resources.Fechar
    End Sub

    Private Sub Maximizar_MouseHover(sender As Object, e As EventArgs) Handles Maximizar.MouseHover
        Maximizar.BackgroundImage = Resources.MaximizarHover
    End Sub

    Private Sub Maximizar_MouseLeave(sender As Object, e As EventArgs) Handles Maximizar.MouseLeave
        Maximizar.BackgroundImage = Resources.Maximizar
    End Sub

    Private Sub Minimizar_MouseHover(sender As Object, e As EventArgs) Handles Minimizar.MouseHover
        Minimizar.BackgroundImage = Resources.MinimizarHover
    End Sub

    Private Sub Minimizar_MouseLeave(sender As Object, e As EventArgs) Handles Minimizar.MouseLeave
        Minimizar.BackgroundImage = Resources.Minimizar
    End Sub

    Private Sub Maximizar_Click(sender As Object, e As EventArgs) Handles Maximizar.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BarraTopo_Paint(sender As Object, e As PaintEventArgs) Handles BarraTopo.Paint

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class
