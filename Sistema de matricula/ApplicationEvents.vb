Imports System.IO
Imports Carreras
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.Devices
Imports Usuarios

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' **NEW** ApplyApplicationDefaults: Raised when the application queries default values to be set for the application.

    ' Example:
    ' Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
    '
    '   ' Setting the application-wide default Font:
    '   e.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
    '
    '   ' Setting the HighDpiMode for the Application:
    '   e.HighDpiMode = HighDpiMode.PerMonitorV2
    '
    '   ' If a splash dialog is used, this sets the minimum display time:
    '   e.MinimumSplashScreenDisplayTime = 4000
    ' End Sub

    Partial Friend Class MyApplication



        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim grados1 As New List(Of String) From {"Bachillerato"}
            Dim grados2 As New List(Of String) From {"Bachillerato", "Maestria"}
            Dim grados3 As New List(Of String) From {"Bachillerato", "Maestria", "Doctorado"}
            Dim routeCarreras As String = "C:\Users\yorda\OneDrive\Documentos\CUC\II Cuatrimestre 2023\Programación II\Sistema de matricula\Datos\Carreras.xml"
            Dim routeAdministradores As String = "C:\Users\yorda\OneDrive\Documentos\CUC\II Cuatrimestre 2023\Programación II\Sistema de matricula\Datos\Administradores.xml"
            Dim routeEstudiantes As String = "C:\Users\yorda\OneDrive\Documentos\CUC\II Cuatrimestre 2023\Programación II\Sistema de matricula\Datos\Estudiantes.xml"


            Dim cursosTI As New List(Of Carreras.Curso) From {
                New Carreras.Curso("TI001", 1, "Introducción a la Programación", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("TI002", 1, "Bases de Datos", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("TI003", 1, "Redes de Computadoras", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("TI004", 2, "Programación Avanzada", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI005", 2, "Seguridad Informática", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI006", 2, "Big Data Analytics", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI007", 3, "Desarrollo Web", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI008", 3, "Inteligencia Artificial", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI009", 3, "Análisis de Datos", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI010", 4, "Desarrollo de Aplicaciones Móviles", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI011", 4, "Criptografía", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI012", 4, "Data Science", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI013", 5, "Desarrollo de Software", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI014", 5, "Seguridad en Redes", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI015", 5, "Análisis de Big Data", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI016", 6, "Desarrollo de Sistemas Distribuidos", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI017", 6, "Seguridad en la Nube", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("TI018", 6, "Análisis de Datos Avanzado", 4, 75, 10, 20, grados2, "True", 12000)
            }

            Dim cursosEnfermeria As New List(Of Carreras.Curso) From {
                New Carreras.Curso("ENF001", 1, "Anatomía Humana", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("ENF002", 1, "Farmacología", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("ENF003", 1, "Primeros Auxilios", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("ENF004", 2, "Enfermería en Salud Mental", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF005", 2, "Enfermería Pediátrica", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF006", 2, "Enfermería Geriátrica", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF007", 3, "Enfermería Materno-Infantil", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF008", 3, "Enfermería Comunitaria", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF009", 3, "Ética y Legislación en Enfermería", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF010", 4, "Enfermería en Cuidados Críticos", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF011", 4, "Enfermería Oncológica", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF012", 4, "Enfermería en Salud Pública", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF013", 5, "Enfermería en Urgencias", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF014", 5, "Enfermería Quirúrgica", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF015", 5, "Investigación en Enfermería", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF016", 6, "Gestión en Enfermería", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF017", 6, "Enfermería Familiar y Comunitaria", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ENF018", 6, "Enfermería en Cuidados Paliativos", 4, 75, 10, 20, grados2, "True", 12000)
            }

            Dim cursosMedicina As New List(Of Carreras.Curso) From {
                New Carreras.Curso("MED001", 1, "Anatomía Humana", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("MED002", 1, "Fisiología Humana", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("MED003", 1, "Bioquímica", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("MED004", 2, "Farmacología", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED005", 2, "Microbiología", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED006", 2, "Histología", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED007", 3, "Patología General", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED008", 3, "Semiología Médica", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED009", 3, "Bioética", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED010", 4, "Medicina Interna", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED011", 4, "Pediatría", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED012", 4, "Ginecología y Obstetricia", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED013", 5, "Cirugía General", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED014", 5, "Psiquiatría", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED015", 5, "Medicina Preventiva", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED016", 6, "Radiología", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED017", 6, "Dermatología", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("MED018", 6, "Medicina Legal", 4, 75, 10, 20, grados2, "True", 12000)
            }

            Dim cursosAdmin As New List(Of Carreras.Curso) From {
                New Carreras.Curso("ADM001", 1, "Introducción a la Administración", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("ADM002", 1, "Contabilidad Financiera", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("ADM003", 1, "Economía", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("ADM004", 2, "Administración de Recursos Humanos", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM005", 2, "Finanzas Corporativas", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM006", 2, "Gestión de Proyectos", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM007", 3, "Administración Pública", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM008", 3, "Mercadotecnia", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM009", 3, "Evaluación deProyectos", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM010", 4, "Administración Estratégica", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM011", 4, "Finanzas Internacionales", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM012", 4, "Derecho Empresarial", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM013", 5, "Gestión de Operaciones", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM014", 5, "Administración de la Calidad", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM015", 5, "Finanzas Personales", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM016", 6, "Emprendimiento", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM017", 6, "Negocios Internacionales", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("ADM018", 6, "Ética Empresarial", 4, 75, 10, 20, grados2, "True", 12000)
            }

            Dim cursosDerecho As New List(Of Carreras.Curso) From {
                New Carreras.Curso("DER001", 1, "Introducción al Derecho", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("DER002", 1, "Derecho Civil", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("DER003", 1, "Derecho Penal", 3, 70, 10, 20, grados2, "True", 10000),
                New Carreras.Curso("DER004", 2, "Derecho Administrativo", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER005", 2, "Derecho Laboral", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER006", 2, "Derecho Internacional", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER007", 3, "Derecho Mercantil", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER008", 3, "Derecho Constitucional", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER009", 3, "Derecho Procesal", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER010", 4, "Derecho de Familia", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER011", 4, "Derecho Tributario", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER012", 4, "Derecho Ambiental", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER013", 5, "Derecho de Propiedad Intelectual", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER014", 5, "Derecho de la Competencia", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER015", 5, "Derechos Humanos", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER016", 6, "Derecho Notarial", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER017", 6, "Derecho Procesal Penal", 4, 75, 10, 20, grados2, "True", 12000),
                New Carreras.Curso("DER018", 6, "Derecho de la Seguridad Social", 4, 75, 10, 20, grados2, "True", 12000)
            }

            ' Creación de las carreras
            Dim carreraTI As New Carrera("TI", "Tecnologías de Información", True, cursosTI, grados2)
            Dim carreraEnfermeria As New Carrera("ENF", "Enfermería", True, cursosEnfermeria, grados2)
            Dim carreraMedicina As New Carrera("MED", "Medicina General", True, cursosMedicina, grados2)
            Dim carreraAdmin As New Carrera("ADM", "Administración de Empresas", True, cursosAdmin, grados2)
            Dim carreraDerecho As New Carrera("DER", "Derecho", True, cursosDerecho, grados2)

            File.WriteAllText(routeCarreras, String.Empty)

            carreraTI.Register(routeCarreras)
            carreraEnfermeria.Register(routeCarreras)
            carreraMedicina.Register(routeCarreras)
            carreraAdmin.Register(routeCarreras)
            carreraDerecho.Register(routeCarreras)




            Dim Administrador1 As New Administrador(204944, "207920892", "Yordan Salazar", "3545334", "yordan@", "2003-02-04", "estadio fello", "holamundo")
            Dim Administrador2 As New Administrador(354546, "43543545", "Danilo Salazar", "3545334", "danilo@", "2001-02-04", "parque", "holamundo")
            Dim Administrador3 As New Administrador(996465, "67767676", "Andrey Guzman", "3545334", "andrey@", "2004-10-04", "estadio fello", "holamundo")

            Administrador1.Register(routeAdministradores)
            Administrador2.Register(routeAdministradores)
            Administrador3.Register(routeAdministradores)






            Dim carrerasDeMichael = New List(Of Carreras.Carrera)
            carrerasDeMichael.Add(carreraAdmin)
            carrerasDeMichael.Add(carreraTI)

            Dim carrerasDeNataly = New List(Of Carreras.Carrera)
            carrerasDeNataly.Add(carreraEnfermeria)
            carrerasDeNataly.Add(carreraMedicina)

            Dim carrerasDeGretel = New List(Of Carreras.Carrera)
            carrerasDeGretel.Add(carreraDerecho)

            Dim estudianteMichael As New Estudiante(204944, "207920892", "Michael Salazar", "3545334", "Michael@", "2003-02-04", "estadio fello", carrerasDeMichael)
            Dim estudianteNataly As New Estudiante(354546, "43543545", "Nataly Salazar", "645454", "Nataly@", "2001-02-04", "parque", carrerasDeNataly)
            Dim estudianteGretel As New Estudiante(996465, "67767676", "Gretel Guzman", "43554", "Gretel@", "2004-10-04", "estadio fello", carrerasDeGretel)

            estudianteMichael.Register(routeEstudiantes)
            estudianteNataly.Register(routeEstudiantes)
            estudianteGretel.Register(routeEstudiantes)


        End Sub
    End Class
End Namespace
