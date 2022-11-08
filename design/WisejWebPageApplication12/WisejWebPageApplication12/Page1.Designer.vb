<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page1
    Inherits Wisej.Web.Page

    'Overrides dispose to clean up the component list.
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Form Designer
    'It can be modified using the Wisej Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NavigationBar1 = New Wisej.Web.Ext.NavigationBar.NavigationBar()
        Me.NavigationBarItem1 = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.NavigationBarItem2 = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.NavigationBarItem3 = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.NavigationBarItem4 = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.NavigationBarItem5 = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.NavigationBarItem6 = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.NavigationBarItem7 = New Wisej.Web.Ext.NavigationBar.NavigationBarItem()
        Me.Timer1 = New Wisej.Web.Timer(Me.components)
        Me.SuspendLayout()
        '
        'NavigationBar1
        '
        Me.NavigationBar1.Dock = Wisej.Web.DockStyle.Left
        Me.NavigationBar1.Items.AddRange(New Wisej.Web.Ext.NavigationBar.NavigationBarItem() {Me.NavigationBarItem1, Me.NavigationBarItem2, Me.NavigationBarItem3, Me.NavigationBarItem4, Me.NavigationBarItem5, Me.NavigationBarItem6, Me.NavigationBarItem7})
        Me.NavigationBar1.Name = "NavigationBar1"
        Me.NavigationBar1.Size = New System.Drawing.Size(282, 460)
        Me.NavigationBar1.TabIndex = 0
        Me.NavigationBar1.Text = "NavigationBar1"
        '
        'NavigationBarItem1
        '
        Me.NavigationBarItem1.BackColor = System.Drawing.Color.Transparent
        Me.NavigationBarItem1.Name = "NavigationBarItem"
        '
        'NavigationBarItem2
        '
        Me.NavigationBarItem2.BackColor = System.Drawing.Color.Transparent
        Me.NavigationBarItem2.Name = "NavigationBarItem"
        '
        'NavigationBarItem3
        '
        Me.NavigationBarItem3.BackColor = System.Drawing.Color.Transparent
        Me.NavigationBarItem3.Name = "NavigationBarItem"
        '
        'NavigationBarItem4
        '
        Me.NavigationBarItem4.BackColor = System.Drawing.Color.Transparent
        Me.NavigationBarItem4.Name = "NavigationBarItem"
        '
        'NavigationBarItem5
        '
        Me.NavigationBarItem5.BackColor = System.Drawing.Color.Transparent
        Me.NavigationBarItem5.Name = "NavigationBarItem"
        '
        'NavigationBarItem6
        '
        Me.NavigationBarItem6.BackColor = System.Drawing.Color.FromName("@navbar-background")
        Me.NavigationBarItem6.Name = "NavigationBarItem"
        '
        'NavigationBarItem7
        '
        Me.NavigationBarItem7.BackColor = System.Drawing.Color.Transparent
        Me.NavigationBarItem7.Name = "NavigationBarItem"
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.NavigationBar1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(695, 460)
        Me.Text = "Page1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavigationBar1 As Ext.NavigationBar.NavigationBar
    Friend WithEvents NavigationBarItem1 As Ext.NavigationBar.NavigationBarItem
    Friend WithEvents NavigationBarItem2 As Ext.NavigationBar.NavigationBarItem
    Friend WithEvents NavigationBarItem3 As Ext.NavigationBar.NavigationBarItem
    Friend WithEvents NavigationBarItem4 As Ext.NavigationBar.NavigationBarItem
    Friend WithEvents NavigationBarItem5 As Ext.NavigationBar.NavigationBarItem
    Friend WithEvents NavigationBarItem6 As Ext.NavigationBar.NavigationBarItem
    Friend WithEvents NavigationBarItem7 As Ext.NavigationBar.NavigationBarItem
    Friend WithEvents Timer1 As Timer
End Class
