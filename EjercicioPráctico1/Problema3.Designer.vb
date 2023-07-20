<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Problema3
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
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        Panel1 = New Panel()
        Label13 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        DataGridView2 = New DataGridView()
        Productos = New DataGridViewTextBoxColumn()
        Ventas = New DataGridViewTextBoxColumn()
        Precio = New DataGridViewTextBoxColumn()
        Total = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(179, 157)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(13, 157)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(332, 157)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Label13)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(799, 111)
        Panel1.TabIndex = 4
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.White
        Label13.Location = New Point(262, 41)
        Label13.Name = "Label13"
        Label13.Size = New Size(315, 37)
        Label13.TabIndex = 19
        Label13.Text = "Compañía de Refrescos"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlLight
        Button1.Location = New Point(612, 124)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 33)
        Button1.TabIndex = 5
        Button1.Text = "Limpiar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlLight
        Button2.Location = New Point(710, 124)
        Button2.Name = "Button2"
        Button2.Size = New Size(78, 33)
        Button2.TabIndex = 6
        Button2.Text = "Finalizar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ControlLight
        Button3.Location = New Point(510, 124)
        Button3.Name = "Button3"
        Button3.Size = New Size(78, 33)
        Button3.TabIndex = 10
        Button3.Text = "Registrar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Productos, Ventas, Precio, Total})
        DataGridView2.Location = New Point(0, 249)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(799, 314)
        DataGridView2.TabIndex = 12
        ' 
        ' Productos
        ' 
        Productos.HeaderText = "Productos"
        Productos.Name = "Productos"
        ' 
        ' Ventas
        ' 
        Ventas.HeaderText = "Ventas"
        Ventas.Name = "Ventas"
        ' 
        ' Precio
        ' 
        Precio.HeaderText = "Precio"
        Precio.Name = "Precio"
        ' 
        ' Total
        ' 
        Total.HeaderText = "Total"
        Total.Name = "Total"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 15)
        Label1.TabIndex = 13
        Label1.Text = "Tipo de Refresco :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(179, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 15)
        Label2.TabIndex = 14
        Label2.Text = "Cant. de Ventas :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(334, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 15
        Label3.Text = "Precio :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(421, 213)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 16
        Label4.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(12, 183)
        Label5.Name = "Label5"
        Label5.Size = New Size(15, 19)
        Label5.TabIndex = 17
        Label5.Text = "*"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(179, 183)
        Label6.Name = "Label6"
        Label6.Size = New Size(15, 19)
        Label6.TabIndex = 18
        Label6.Text = "*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(332, 183)
        Label7.Name = "Label7"
        Label7.Size = New Size(15, 19)
        Label7.TabIndex = 19
        Label7.Text = "*"
        ' 
        ' Problema3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 561)
        ControlBox = False
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(TextBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximumSize = New Size(816, 600)
        MinimumSize = New Size(816, 600)
        Name = "Problema3"
        Text = "Compañia de Refrescos"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Productos As DataGridViewTextBoxColumn
    Friend WithEvents Ventas As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
