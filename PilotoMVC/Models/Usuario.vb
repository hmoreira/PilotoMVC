Imports System.Data.Entity
Imports System

Namespace PilotoMVC.Testes

    Public Class Usuario

        Private _ID As Integer

        Public Property ID As Integer

            Get
                Return _ID
            End Get
            Set(value As Integer)
                _ID = value
            End Set
        End Property

        Private _Login As String
        Public Property Login As String

            Get
                Return _Login
            End Get
            Set(value As String)
                _Login = value
            End Set
        End Property

        Private _Senha As String
        Public Property Senha As String

            Get
                Return _Senha
            End Get
            Set(value As String)
                _Senha = value
            End Set
        End Property

    End Class

    Public Class UsuarioDBContext
        Inherits DbContext

        Private _Usuarios As DbSet(Of Usuario)
        Public Property Usuarios As DbSet(Of Usuario)
            Get
                Return _Usuarios
            End Get
            Set(value As DbSet(Of Usuario))
                _Usuarios = value
            End Set
        End Property

    End Class

End Namespace





