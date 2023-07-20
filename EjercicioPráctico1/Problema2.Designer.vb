<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Problema2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Problema2))
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btnExit = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel2 = New Panel()
        Label8 = New Label()
        Button2 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatStyle = FlatStyle.Popup
        btnExit.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(685, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(87, 44)
        btnExit.TabIndex = 21
        btnExit.Text = "Salir"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnExit)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.MaximumSize = New Size(782, 80)
        Panel1.MinimumSize = New Size(782, 80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(782, 80)
        Panel1.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(224, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(325, 37)
        Label1.TabIndex = 23
        Label1.Text = "Conversion de Monedas"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(286, 112)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 23
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(485, 112)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(202, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 25
        Label2.Text = "Convertir :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(443, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(13, 15)
        Label3.TabIndex = 26
        Label3.Text = "a"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(12, 115)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 29
        Label5.Text = "Cantidad :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(79, 112)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 30
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Location = New Point(632, 105)
        Button1.Name = "Button1"
        Button1.Size = New Size(41, 35)
        Button1.TabIndex = 31
        Button1.TextImageRelation = TextImageRelation.TextBeforeImage
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(79, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(17, 21)
        Label4.TabIndex = 32
        Label4.Text = "*"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(286, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(17, 21)
        Label6.TabIndex = 33
        Label6.Text = "*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(485, 138)
        Label7.Name = "Label7"
        Label7.Size = New Size(17, 21)
        Label7.TabIndex = 34
        Label7.Text = "*"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.Black
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(0, 203)
        Panel2.Margin = New Padding(0)
        Panel2.MaximumSize = New Size(783, 100)
        Panel2.MinimumSize = New Size(783, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(783, 100)
        Panel2.TabIndex = 35
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(347, 40)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 21)
        Label8.TabIndex = 36
        Label8.Text = "Label8"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(685, 99)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 44)
        Button2.TabIndex = 36
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Problema2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(784, 361)
        ControlBox = False
        Controls.Add(Button2)
        Controls.Add(Panel2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MaximumSize = New Size(800, 400)
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        MinimumSize = New Size(800, 391)
        Name = "Problema2"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Conversion de monedas"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
End Class
