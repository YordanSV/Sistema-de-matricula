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
        TablaCursos.Location = New Point(97, 41)
        TablaCursos.Name = "TablaCursos"
        TablaCursos.RowTemplate.Height = 25
        TablaCursos.Size = New Size(943, 347)
        TablaCursos.TabIndex = 0
        ' 
        ' btnRegistrarCurso
        ' 
        btnRegistrarCurso.Location = New Point(0, 8)
        btnRegistrarCurso.Name = "btnRegistrarCurso"
        btnRegistrarCurso.Size = New Size(91, 28)
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
        txtCourseCode.Location = New Point(183, 12)
        txtCourseCode.Name = "txtCourseCode"
        txtCourseCode.Size = New Size(74, 23)
        txtCourseCode.TabIndex = 3
        ' 
        ' txtCourseName
        ' 
        txtCourseName.Location = New Point(263, 12)
        txtCourseName.Name = "txtCourseName"
        txtCourseName.Size = New Size(67, 23)
        txtCourseName.TabIndex = 4
        ' 
        ' txtCredits
        ' 
        txtCredits.Location = New Point(336, 13)
        txtCredits.Name = "txtCredits"
        txtCredits.Size = New Size(76, 23)
        txtCredits.TabIndex = 5
        ' 
        ' txtMinNote
        ' 
        txtMinNote.Location = New Point(418, 13)
        txtMinNote.Name = "txtMinNote"
        txtMinNote.Size = New Size(100, 23)
        txtMinNote.TabIndex = 6
        ' 
        ' txtMinStudents
        ' 
        txtMinStudents.Location = New Point(524, 13)
        txtMinStudents.Name = "txtMinStudents"
        txtMinStudents.Size = New Size(100, 23)
        txtMinStudents.TabIndex = 7
        ' 
        ' txtMaxStudents
        ' 
        txtMaxStudents.Location = New Point(630, 13)
        txtMaxStudents.Name = "txtMaxStudents"
        txtMaxStudents.Size = New Size(100, 23)
        txtMaxStudents.TabIndex = 8
        ' 
        ' txtDegrees
        ' 
        txtDegrees.Location = New Point(736, 13)
        txtDegrees.Name = "txtDegrees"
        txtDegrees.Size = New Size(100, 23)
        txtDegrees.TabIndex = 9
        ' 
        ' txtCourseCost
        ' 
        txtCourseCost.Location = New Point(948, 13)
        txtCourseCost.Name = "txtCourseCost"
        txtCourseCost.Size = New Size(100, 23)
        txtCourseCost.TabIndex = 11
        ' 
        ' cmbSemester
        ' 
        cmbSemester.FormattingEnabled = True
        cmbSemester.Location = New Point(97, 12)
        cmbSemester.Name = "cmbSemester"
        cmbSemester.Size = New Size(80, 23)
        cmbSemester.TabIndex = 12
        ' 
        ' cmbActive
        ' 
        cmbActive.FormattingEnabled = True
        cmbActive.Location = New Point(857, 13)
        cmbActive.Name = "cmbActive"
        cmbActive.Size = New Size(60, 23)
        cmbActive.TabIndex = 13
        ' 
        ' txtCarreraCode
        ' 
        txtCarreraCode.Location = New Point(-9, 77)
        txtCarreraCode.Name = "txtCarreraCode"
        txtCarreraCode.Size = New Size(100, 23)
        txtCarreraCode.TabIndex = 14
        ' 
        ' FormModificacionCursos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 595)
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
