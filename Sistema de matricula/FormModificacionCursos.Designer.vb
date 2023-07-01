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
        TablaCursos = New DataGridView()
        TextBox1 = New TextBox()
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
        TablaCursos.Size = New Size(943, 512)
        TablaCursos.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(235, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' FormModificacionCursos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 595)
        Controls.Add(TextBox1)
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
    Friend WithEvents TextBox1 As TextBox
End Class
