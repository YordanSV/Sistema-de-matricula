<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModificacionEstudintes
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
        TablaEstudiantes = New DataGridView()
        Label10 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtDireccion = New TextBox()
        txtFechaNacimiento = New TextBox()
        txtCorreoElectronico = New TextBox()
        txtCarnet = New TextBox()
        txtTelefono = New TextBox()
        txtNombreCompleto = New TextBox()
        txtIdentificacion = New TextBox()
        btnRegistrarCurso = New Button()
        txtCarreras = New TextBox()
        CType(TablaEstudiantes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TablaEstudiantes
        ' 
        TablaEstudiantes.AllowUserToOrderColumns = True
        TablaEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TablaEstudiantes.Location = New Point(126, 146)
        TablaEstudiantes.Name = "TablaEstudiantes"
        TablaEstudiantes.RowTemplate.Height = 25
        TablaEstudiantes.Size = New Size(1219, 425)
        TablaEstudiantes.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(727, 9)
        Label10.Name = "Label10"
        Label10.Size = New Size(106, 15)
        Label10.TabIndex = 46
        Label10.Text = "Código de carreras"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(1016, 73)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 15)
        Label8.TabIndex = 44
        Label8.Text = "Direccion"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(864, 73)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 15)
        Label7.TabIndex = 43
        Label7.Text = "Fecha Nacimiento"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(719, 73)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 15)
        Label6.TabIndex = 42
        Label6.Text = "Correo electronico"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(593, 64)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 15)
        Label5.TabIndex = 41
        Label5.Text = "Telefono"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(406, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 15)
        Label4.TabIndex = 40
        Label4.Text = "Nombre Completo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(273, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 38
        Label2.Text = "Identificacion"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(150, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 37
        Label1.Text = "Carnet"
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(967, 91)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(153, 23)
        txtDireccion.TabIndex = 32
        ' 
        ' txtFechaNacimiento
        ' 
        txtFechaNacimiento.Location = New Point(864, 91)
        txtFechaNacimiento.Name = "txtFechaNacimiento"
        txtFechaNacimiento.Size = New Size(97, 23)
        txtFechaNacimiento.TabIndex = 31
        ' 
        ' txtCorreoElectronico
        ' 
        txtCorreoElectronico.Location = New Point(719, 91)
        txtCorreoElectronico.Name = "txtCorreoElectronico"
        txtCorreoElectronico.Size = New Size(139, 23)
        txtCorreoElectronico.TabIndex = 30
        ' 
        ' txtCarnet
        ' 
        txtCarnet.Location = New Point(126, 91)
        txtCarnet.Name = "txtCarnet"
        txtCarnet.Size = New Size(118, 23)
        txtCarnet.TabIndex = 29
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(576, 91)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(97, 23)
        txtTelefono.TabIndex = 28
        ' 
        ' txtNombreCompleto
        ' 
        txtNombreCompleto.Location = New Point(376, 91)
        txtNombreCompleto.Name = "txtNombreCompleto"
        txtNombreCompleto.Size = New Size(167, 23)
        txtNombreCompleto.TabIndex = 27
        ' 
        ' txtIdentificacion
        ' 
        txtIdentificacion.Location = New Point(264, 91)
        txtIdentificacion.Name = "txtIdentificacion"
        txtIdentificacion.Size = New Size(97, 23)
        txtIdentificacion.TabIndex = 26
        ' 
        ' btnRegistrarCurso
        ' 
        btnRegistrarCurso.Location = New Point(610, 27)
        btnRegistrarCurso.Name = "btnRegistrarCurso"
        btnRegistrarCurso.Size = New Size(91, 23)
        btnRegistrarCurso.TabIndex = 25
        btnRegistrarCurso.Text = "Agregar"
        btnRegistrarCurso.UseVisualStyleBackColor = True
        ' 
        ' txtCarreras
        ' 
        txtCarreras.Location = New Point(727, 27)
        txtCarreras.Name = "txtCarreras"
        txtCarreras.Size = New Size(106, 23)
        txtCarreras.TabIndex = 33
        ' 
        ' FormModificacionEstudintes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1449, 648)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtCarreras)
        Controls.Add(txtDireccion)
        Controls.Add(txtFechaNacimiento)
        Controls.Add(txtCorreoElectronico)
        Controls.Add(txtCarnet)
        Controls.Add(txtTelefono)
        Controls.Add(txtNombreCompleto)
        Controls.Add(txtIdentificacion)
        Controls.Add(btnRegistrarCurso)
        Controls.Add(TablaEstudiantes)
        Name = "FormModificacionEstudintes"
        Text = "FormModificacionEstudintes"
        CType(TablaEstudiantes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TablaEstudiantes As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtFechaNacimiento As TextBox
    Friend WithEvents txtCorreoElectronico As TextBox
    Friend WithEvents txtCarnet As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents btnRegistrarCurso As Button
    Friend WithEvents txtCarreras As TextBox
End Class
