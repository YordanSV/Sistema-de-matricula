<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        RegistroModificacionCursosToolStripMenuItem = New ToolStripMenuItem()
        RegistroModificacionEstudiantesToolStripMenuItem = New ToolStripMenuItem()
        Button1 = New Button()
        Button2 = New Button()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {RegistroModificacionCursosToolStripMenuItem, RegistroModificacionEstudiantesToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(256, 48)
        ' 
        ' RegistroModificacionCursosToolStripMenuItem
        ' 
        RegistroModificacionCursosToolStripMenuItem.Name = "RegistroModificacionCursosToolStripMenuItem"
        RegistroModificacionCursosToolStripMenuItem.Size = New Size(255, 22)
        RegistroModificacionCursosToolStripMenuItem.Text = "Registro/Modificacion Cursos"
        ' 
        ' RegistroModificacionEstudiantesToolStripMenuItem
        ' 
        RegistroModificacionEstudiantesToolStripMenuItem.Name = "RegistroModificacionEstudiantesToolStripMenuItem"
        RegistroModificacionEstudiantesToolStripMenuItem.Size = New Size(255, 22)
        RegistroModificacionEstudiantesToolStripMenuItem.Text = "Registro/Modificacion Estudiantes"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(279, 99)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(446, 89)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 33)
        Button2.TabIndex = 2
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RegistroModificacionCursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroModificacionEstudiantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
