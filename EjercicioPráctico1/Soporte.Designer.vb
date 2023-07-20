<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Soporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Soporte))
        Panel1 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.AutoScroll = True
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(834, 394)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(698, 408)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 15)
        Label1.TabIndex = 0
        Label1.Text = " © DK CODE 2023"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Soporte
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(834, 392)
        ControlBox = False
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Soporte"
        StartPosition = FormStartPosition.Manual
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
