<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        MenuStrip1 = New MenuStrip()
        Problema2ToolStripMenuItem = New ToolStripMenuItem()
        Problema1ToolStripMenuItem1 = New ToolStripMenuItem()
        Problema2ToolStripMenuItem1 = New ToolStripMenuItem()
        Problema3ToolStripMenuItem = New ToolStripMenuItem()
        SoporteToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.GripMargin = New Padding(2)
        MenuStrip1.Items.AddRange(New ToolStripItem() {Problema2ToolStripMenuItem, SoporteToolStripMenuItem})
        MenuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(0)
        MenuStrip1.Size = New Size(834, 19)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Problema2ToolStripMenuItem
        ' 
        Problema2ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Problema1ToolStripMenuItem1, Problema2ToolStripMenuItem1, Problema3ToolStripMenuItem})
        Problema2ToolStripMenuItem.Name = "Problema2ToolStripMenuItem"
        Problema2ToolStripMenuItem.Size = New Size(76, 19)
        Problema2ToolStripMenuItem.Text = "Programas"
        ' 
        ' Problema1ToolStripMenuItem1
        ' 
        Problema1ToolStripMenuItem1.Name = "Problema1ToolStripMenuItem1"
        Problema1ToolStripMenuItem1.Size = New Size(134, 22)
        Problema1ToolStripMenuItem1.Text = "Problema 1"
        ' 
        ' Problema2ToolStripMenuItem1
        ' 
        Problema2ToolStripMenuItem1.Name = "Problema2ToolStripMenuItem1"
        Problema2ToolStripMenuItem1.Size = New Size(134, 22)
        Problema2ToolStripMenuItem1.Text = "Problema 2"
        ' 
        ' Problema3ToolStripMenuItem
        ' 
        Problema3ToolStripMenuItem.Name = "Problema3ToolStripMenuItem"
        Problema3ToolStripMenuItem.Size = New Size(134, 22)
        Problema3ToolStripMenuItem.Text = "Problema 3"
        ' 
        ' SoporteToolStripMenuItem
        ' 
        SoporteToolStripMenuItem.Name = "SoporteToolStripMenuItem"
        SoporteToolStripMenuItem.Size = New Size(60, 19)
        SoporteToolStripMenuItem.Text = "Soporte"
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.AutoSize = True
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel1.Location = New Point(0, 19)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(834, 392)
        Panel1.TabIndex = 5
        ' 
        ' MenuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(834, 411)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MaximumSize = New Size(850, 450)
        MdiChildrenMinimizedAnchorBottom = False
        MinimumSize = New Size(850, 450)
        Name = "MenuPrincipal"
        RightToLeft = RightToLeft.No
        Text = "Menu Principal"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Problema2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Problema2ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SoporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Problema3ToolStripMenuItem As ToolStripMenuItem
End Class
