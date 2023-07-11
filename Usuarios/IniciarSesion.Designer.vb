<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniciarSesion
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
        Button1 = New Button()
        txtContrasena = New TextBox()
        txtCarnet = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(135, 164)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 23)
        Button1.TabIndex = 0
        Button1.Text = "Iniciar Sesion"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Location = New Point(135, 124)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(100, 23)
        txtContrasena.TabIndex = 1
        ' 
        ' txtCarnet
        ' 
        txtCarnet.Location = New Point(135, 80)
        txtCarnet.Name = "txtCarnet"
        txtCarnet.Size = New Size(100, 23)
        txtCarnet.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(165, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 4
        Label1.Text = "Carnet"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(155, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 5
        Label2.Text = "Contraseña"
        ' 
        ' IniciarSesion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(374, 317)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtCarnet)
        Controls.Add(txtContrasena)
        Controls.Add(Button1)
        Name = "IniciarSesion"
        Text = "IniciarSesion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtCarnet As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
