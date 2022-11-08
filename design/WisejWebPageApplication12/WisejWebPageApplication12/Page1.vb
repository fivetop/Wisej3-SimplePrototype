Imports System
Imports Wisej.Web
Imports Wisej.Web.Ext.NavigationBar

Public Class Page1

    Dim current As NavigationBarItem
    Dim Transp As Integer = 0

    Private Sub Reset()
        For Each item As NavigationBarItem In NavigationBar1.Items
            item.BackColor = Drawing.Color.Transparent
        Next item
    End Sub

    Private Sub NavigationBar1_ItemClick(sender As Object, e As Ext.NavigationBar.NavigationBarItemClickEventArgs) Handles NavigationBar1.ItemClick
        current = e.Item
        Reset()
        Transp = 255
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Transp -= 15
        If Transp > 0 Then
            current.BackColor = Drawing.Color.FromArgb(Transp, 200, 200, 200)
        Else
            current.BackColor = Drawing.Color.Transparent
            Timer1.Enabled = False
        End If
    End Sub
End Class
