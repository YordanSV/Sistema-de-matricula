Imports Microsoft.VisualBasic.ApplicationServices

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


            Dim listaCursos As New List(Of Carreras.Curso) From {
                New Carreras.Curso("12", 3, "matematica", 3, 60, 10, 15, grados2, True, 10000),
                New Carreras.Curso("12", 4, "ciencias", 3, 65, 15, 20, grados2, True, 10000),
                New Carreras.Curso("12", 5, "matematica", 3, 70, 10, 15, grados2, True, 10000)
            }

            Dim carrera As New Carreras.Carrera("TI", "Tecnologias de informacion", True, listaCursos, grados2)
            carrera.Register("C:\Users\AMD RYZEN 5 2400G\source\repos\YordanSV\Sistema-de-matricula\Datos\Carreras.xml")



        End Sub


    End Class
End Namespace
