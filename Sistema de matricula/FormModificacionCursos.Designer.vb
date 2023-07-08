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
        cmbSemester = New ComboBox()
        cmbActive = New ComboBox()
        txtCarreraCode = New TextBox()
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
        txtCourseCode.Text = "Código"
        ' 
        ' txtCourseName
        ' 
        txtCourseName.Location = New Point(234, 77)
        txtCourseName.Name = "txtCourseName"
        txtCourseName.Size = New Size(97, 23)
        txtCourseName.TabIndex = 4
        txtCourseName.Text = "Nombre"
        ' 
        ' txtCredits
        ' 
        txtCredits.Location = New Point(337, 77)
        txtCredits.Name = "txtCredits"
        txtCredits.Size = New Size(97, 23)
        txtCredits.TabIndex = 5
        txtCredits.Text = "Créditos"
        ' 
        ' txtMinNote
        ' 
        txtMinNote.Location = New Point(440, 77)
        txtMinNote.Name = "txtMinNote"
        txtMinNote.Size = New Size(97, 23)
        txtMinNote.TabIndex = 6
        txtMinNote.Text = "Min Nota"
        ' 
        ' txtMinStudents
        ' 
        txtMinStudents.Location = New Point(543, 77)
        txtMinStudents.Name = "txtMinStudents"
        txtMinStudents.Size = New Size(97, 23)
        txtMinStudents.TabIndex = 7
        txtMinStudents.Text = "Min Estudiantes"
        ' 
        ' txtMaxStudents
        ' 
        txtMaxStudents.Location = New Point(646, 77)
        txtMaxStudents.Name = "txtMaxStudents"
        txtMaxStudents.Size = New Size(97, 23)
        txtMaxStudents.TabIndex = 8
        txtMaxStudents.Text = "Max Estudiantes"
        ' 
        ' txtDegrees
        ' 
        txtDegrees.Location = New Point(749, 77)
        txtDegrees.Name = "txtDegrees"
        txtDegrees.Size = New Size(97, 23)
        txtDegrees.TabIndex = 9
        txtDegrees.Text = "Grados"
        ' 
        ' txtCourseCost
        ' 
        txtCourseCost.Location = New Point(955, 77)
        txtCourseCost.Name = "txtCourseCost"
        txtCourseCost.Size = New Size(97, 23)
        txtCourseCost.TabIndex = 11
        txtCourseCost.Text = "10000"
        ' 
        ' cmbSemester
        ' 
        cmbSemester.FormattingEnabled = True
        cmbSemester.Location = New Point(5, 77)
        cmbSemester.Name = "cmbSemester"
        cmbSemester.Size = New Size(120, 23)
        cmbSemester.TabIndex = 12
        cmbSemester.Text = "Número Semestre"
        ' 
        ' cmbActive
        ' 
        cmbActive.FormattingEnabled = True
        cmbActive.Location = New Point(852, 77)
        cmbActive.Name = "cmbActive"
        cmbActive.Size = New Size(97, 23)
        cmbActive.TabIndex = 13
        cmbActive.Text = "Estado"
        ' 
        ' txtCarreraCode
        ' 
        txtCarreraCode.Location = New Point(472, 24)
        txtCarreraCode.Name = "txtCarreraCode"
        txtCarreraCode.Size = New Size(112, 23)
        txtCarreraCode.TabIndex = 14
        txtCarreraCode.Text = "Código Semestre"
        ' 
        ' FormModificacionCursos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1536, 595)
        Controls.Add(txtCarreraCode)
        Controls.Add(cmbActive)
        Controls.Add(cmbSemester)
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
    Friend WithEvents txtCarreraCode As TextBox
End Class
