﻿Public Class NewUser
    Dim WithEvents WinSockCliente As New Cliente
    Private tool As ToolTip = New ToolTip()

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim funcion As New Funciones
        Dim txtuser As String = txtUsuario.Text
        Dim tstpass As String = txtPassword.Text
        Try
            Dim dts As New Datos

            dts.nomusuario = txtUsuario.Text
            dts.passusuario = funcion.MD5Encrypt(txtPassword.Text)
            If funcion.nuevoCliente(dts, WinSockCliente) = True Then
                Dim Principal As New VenCliente
                Principal.Inicio(New User(txtUsuario.Text), WinSockCliente, New Login)
                Principal.Show()
                Me.Close()
            Else
                MsgBox("Error al crear usuario" + vbCrLf, MsgBoxStyle.Critical)
                txtPassword.Clear()
                txtUsuario.Clear()
            End If

        Catch ex As Exception
            MsgBox("Error al Crear Usuario: " & ex.Message)
        End Try
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Public Sub Inicio(ByVal socket As Cliente)
        WinSockCliente = socket
    End Sub

    Private Sub NewUser_Exit(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        WinSockCliente.Desconectar()
    End Sub

    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tool.SetToolTip(Me.cmdAceptar, "Aceptar")
        tool.SetToolTip(Me.cmdSalir, "Salir")
    End Sub
End Class