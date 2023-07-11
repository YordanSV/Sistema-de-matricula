<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModificacionCursos
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
        components = New ComponentModel.Container()
        TablaCursos = New DataGridView()
        btnRegistrarCurso = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        txtCourseCode = New TextBox()
        txtCourseName = New TextBox()
        txtCredits = New TextBox()
        txtMinNote = New TextBox()
        txtMinStudents = New TextBox()
        txtMaxStudents = New TextBox()
        txtDegrees = New TextBox()
        txtCourseCost = New TextBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        cmbNumSemester = New ComboBox()
        cmbActive = New ComboBox()
        cmbCarreraCode = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        CType(TablaCursos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TablaCursos
        ' 
        TablaCursos.AllowUserToOrderColumns = True
        TablaCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TablaCursos.Location = New Point(12, 106)
        TablaCursos.Name = "TablaCursos"
        TablaCursos.RowTemplate.Height = 25
        TablaCursos.Size = New Size(1460, 416)
        TablaCursos.TabIndex = 0
        ' 
        ' btnRegistrarCurso
        ' 
        btnRegistrarCurso.Location = New Point(375, 24)
        btnRegistrarCurso.Name = "btnRegistrarCurso"
        btnRegistrarCurso.Size = New Size(91, 23)
        btnRegistrarCurso.TabIndex = 2
        btnRegistrarCurso.Text = "Agregar"
        btnRegistrarCurso.UseVisualStyleBackColor = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' txtCourseCode
        ' 
        txtCourseCode.Location = New Point(131, 77)
        txtCourseCode.Name = "txtCourseCode"
        txtCourseCode.Size = New Size(97, 23)
        txtCourseCode.TabIndex = 3
        ' 
        ' txtCourseName
        ' 
        txtCourseName.Location = New Point(234, 77)
        txtCourseName.Name = "txtCourseName"
        txtCourseName.Size = New Size(97, 23)
        txtCourseName.TabIndex = 4
        ' 
        ' txtCredits
        ' 
        txtCredits.Location = New Point(337, 77)
        txtCredits.Name = "txtCredits"
        txtCredits.Size = New Size(97, 23)
        txtCredits.TabIndex = 5
        ' 
        ' txtMinNote
        ' 
        txtMinNote.Location = New Point(440, 77)
        txtMinNote.Name = "txtMinNote"
        txtMinNote.Size = New Size(97, 23)
        txtMinNote.TabIndex = 6
        ' 
        ' txtMinStudents
        ' 
        txtMinStudents.Location = New Point(543, 77)
        txtMinStudents.Name = "txtMinStudents"
        txtMinStudents.Size = New Size(97, 23)
        txtMinStudents.TabIndex = 7
        ' 
        ' txtMaxStudents
        ' 
        txtMaxStudents.Location = New Point(646, 77)
        txtMaxStudents.Name = "txtMaxStudents"
        txtMaxStudents.Size = New Size(97, 23)
        txtMaxStudents.TabIndex = 8
        ' 
        ' txtDegrees
        ' 
        txtDegrees.Location = New Point(749, 77)
        txtDegrees.Name = "txtDegrees"
        txtDegrees.Size = New Size(97, 23)
        txtDegrees.TabIndex = 9
        ' 
        ' txtCourseCost
        ' 
        txtCourseCost.Location = New Point(910, 77)
        txtCourseCost.Name = "txtCourseCost"
        txtCourseCost.Size = New Size(10, 23)
        txtCourseCost.TabIndex = 11
        txtCourseCost.Text = "10000"
        ' 
        ' cmbNumSemester
        ' 
        cmbNumSemester.FormattingEnabled = True
        cmbNumSemester.Location = New Point(12, 77)
        cmbNumSemester.Name = "cmbNumSemester"
        cmbNumSemester.Size = New Size(109, 23)
        cmbNumSemester.TabIndex = 12
        ' 
        ' cmbActive
        ' 
        cmbActive.FormattingEnabled = True
        cmbActive.Location = New Point(852, 77)
        cmbActive.Name = "cmbActive"
        cmbActive.Size = New Size(97, 23)
        cmbActive.TabIndex = 13
        ' 
        ' cmbCarreraCode
        ' 
        cmbCarreraCode.FormattingEnabled = True
        cmbCarreraCode.Location = New Point(481, 24)
        cmbCarreraCode.Name = "cmbCarreraCode"
        cmbCarreraCode.Size = New Size(121, 23)
        cmbCarreraCode.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 15)
        Label1.TabIndex = 15
        Label1.Text = "Número Semestre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(153, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 15)
        Label2.TabIndex = 16
        Label2.Text = "Código"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(255, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 17
        Label3.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(355, 59)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 18
        Label4.Text = "Créditos"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(460, 59)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 19
        Label5.Text = "Min Nota"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(543, 59)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 15)
        Label6.TabIndex = 20
        Label6.Text = "Min Estudiantes"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(646, 59)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 15)
        Label7.TabIndex = 21
        Label7.Text = "Max Estudiantes"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(775, 59)
        Label8.Name = "Label8"
        Label8.Size = New Size(44, 15)
        Label8.TabIndex = 22
        Label8.Text = "Grados"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(878, 59)
        Label9.Name = "Label9"
        Label9.Size = New Size(42, 15)
        Label9.TabIndex = 23
        Label9.Text = "Estado"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(492, 6)
        Label10.Name = "Label10"
        Label10.Size = New Size(101, 15)
        Label10.TabIndex = 24
        Label10.Text = "Código de carrera"
        ' 
        ' FormModificacionCursos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 595)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbCarreraCode)
        Controls.Add(cmbActive)
        Controls.Add(cmbNumSemester)
        Controls.Add(txtCourseCost)
        Controls.Add(txtDegrees)
        Controls.Add(txtMaxStudents)
        Controls.Add(txtMinStudents)
        Controls.Add(txtMinNote)
        Controls.Add(txtCredits)
        Controls.Add(txtCourseName)
        Controls.Add(txtCourseCode)
        Controls.Add(btnRegistrarCurso)
        Controls.Add(TablaCursos)
        Name = "FormModificacionCursos"
        Text = "FormModificacionCursos"
        CType(TablaCursos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TablaCursos As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cantCreditos As DataGridViewTextBoxColumn
    Friend WithEvents minNota As DataGridViewTextBoxColumn
    Friend WithEvents cantMinEstudiantes As DataGridViewTextBoxColumn
    Friend WithEvents cantMaxEstudiantes As DataGridViewTextBoxColumn
    Friend WithEvents grados As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents costo As DataGridViewTextBoxColumn
    Friend WithEvents btnRegistrarCurso As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtCourseCode As TextBox
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents txtCredits As TextBox
    Friend WithEvents txtMinNote As TextBox
    Friend WithEvents txtMinStudents As TextBox
    Friend WithEvents txtMaxStudents As TextBox
    Friend WithEvents txtDegrees As TextBox
    Friend WithEvents txtCourseCost As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents cmbActive As ComboBox
    Friend WithEvents cmbNumSemester As ComboBox
    Friend WithEvents cmbCarreraCode As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
