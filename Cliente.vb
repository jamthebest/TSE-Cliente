Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports System.IO
Imports System.Data.SqlClient

Public Class Cliente
#Region "VARIABLES"
    Private conectado As Boolean = False
    Private funciones As New Funciones
    Private Stm As Stream 'Utilizado para enviar datos al Servidor y recibir datos del mismo 
    Private m_IPDelHost As String 'Direccion del objeto de la clase Servidor 
    Private m_PuertoDelHost As String 'Puerto donde escucha el objeto de la clase Servidor 
    Dim tcpClnt As TcpClient
    Private Usuario As User 'Instancia del Usuario
    Public cliente As VenCliente
#End Region

#Region "EVENTOS"
    Public Event ConexionTerminada()
    Public Event DatosRecibidos(ByVal datos As String, ByVal sonido As Byte())
    Public Event RespuestaLogin(ByVal respuesta As Solicitud)
    Public Event RespuestaCrearRegistro(ByVal respuesta As Solicitud)
    Public Event RespuestaMensaje(ByVal respuesta As String)
    Public Event RespuestaUsers(ByVal respuesta As ArrayList)
    Public Event RespuestaObtener(ByVal respuesta As ArrayList, ByVal tabla As String)
#End Region

#Region "PROPIEDADES"
    Public Property IPDelHost() As String
        Get
            IPDelHost = m_IPDelHost
        End Get
        Set(ByVal Value As String)
            m_IPDelHost = Value
        End Set
    End Property

    Public Property PuertoDelHost() As String
        Get
            PuertoDelHost = m_PuertoDelHost
        End Get
        Set(ByVal Value As String)
            m_PuertoDelHost = Value
        End Set
    End Property

    Public Property UserDelHost() As User
        Get
            UserDelHost = Usuario
        End Get
        Set(ByVal Value As User)
            Usuario = Value
        End Set
    End Property
#End Region

#Region "METODOS"
    Public Sub Conectar()
        Dim tcpThd As Thread 'Se encarga de escuchar mensajes enviados por el Servidor 

        tcpClnt = New TcpClient()
        'Me conecto al objeto de la clase Servidor, 
        '  determinado por las propiedades IPDelHost y PuertoDelHost
        tcpClnt.Connect(IPDelHost, PuertoDelHost)
        Stm = tcpClnt.GetStream()
        conectado = True

        'Creo e inicio un thread para que escuche los mensajes enviados por el Servidor 
        tcpThd = New Thread(AddressOf LeerSocket)
        tcpThd.Start()
    End Sub

    Public Sub Desconectar()
        conectado = False
        tcpClnt.Close()
    End Sub

    Public Function Estado() As Boolean
        Return conectado
    End Function

    Public Sub EnviarDatos(ByVal Datos As String)
        Dim mens As String = Datos & "?"
        Dim mensaje As String = mens
        While Encoding.ASCII.GetBytes(mens).Length > 1024
            mens = mens.Substring(0, mens.Length - 1024)
        End While
        
        While (Encoding.ASCII.GetBytes(mens).Length < 1024)
            mens = mens & "?"
            mensaje = mensaje & "?"
        End While

        Dim BufferDeEscritura() As Byte = New Byte(Encoding.ASCII.GetBytes(mensaje).Length) {}
        BufferDeEscritura = Encoding.ASCII.GetBytes(mensaje)
        
        If Not (Stm Is Nothing) Then
            'Envio los datos al Servidor
            Stm.Write(BufferDeEscritura, 0, BufferDeEscritura.Length)
        End If
    End Sub
#End Region

#Region "FUNCIONES PRIVADAS"
    Private Sub LeerSocket()
        Dim BufferDeLectura() As Byte
        While True
            Try
                BufferDeLectura = New Byte(1023) {}
                'Me quedo esperando a que llegue algun mensaje 
                Dim men As String = ""
                'Genero el evento DatosRecibidos, ya que se han recibido datos desde el Servidor 
                Do
                    'Me quedo esperando a que llegue algun mensaje 
                    Stm.Read(BufferDeLectura, 0, BufferDeLectura.Length)
                    men &= Encoding.ASCII.GetString(BufferDeLectura)
                Loop While Not men.Last.ToString.Equals("?") 'And men.Length < 300000
                'MsgBox("Tama�o: " & Encoding.ASCII.GetBytes(men).Length)

                Dim y As String = men.Last
                Do While y.Equals("?")
                    men = men.Substring(0, men.Length - 1)
                    y = men.Last
                Loop
                'MsgBox("Tama�o: " & Encoding.ASCII.GetBytes(men).Length)
                Dim x As String = funciones.decryptString(men)
                'Dim md5 As String = x.Substring(x.IndexOf("?XXXJAMXXX?"))
                x = x.Substring(0, x.IndexOf("?XXXJAMXXX?"))
                Dim solicitud As Solicitud = funciones.DesSerializar(x, 1)
                Select Case solicitud.TipoSolicitud
                    Case 1
                        RaiseEvent RespuestaLogin(solicitud)
                    Case 2
                        RaiseEvent RespuestaCrearRegistro(solicitud)
                    Case 3
                        RaiseEvent RespuestaUsers(solicitud.ArgumentosSolicitud)
                    Case 4
                        RaiseEvent RespuestaObtener(solicitud.ArgumentosSolicitud, solicitud.MensajeSolicitud)
                    Case 5
                        RaiseEvent RespuestaMensaje(solicitud.MensajeSolicitud)
                    Case Else

                End Select

            Catch e As Exception
                Debug.WriteLine("Error: " + e.Message)
                Exit While
            End Try
        End While
        'Finalizo la conexion, por lo tanto genero el evento correspondiente 
        RaiseEvent ConexionTerminada()
    End Sub
#End Region
End Class

