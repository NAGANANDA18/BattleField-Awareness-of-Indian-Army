Imports System.Data.SqlClient

Module DatabaseConnection
    Public Conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\gowth\Documents\Visual Studio 2010\Projects\BattleField Awareness of Indian Army\BattleField Awareness of Indian Army\bin\Debug\ArmyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Public SessionUserRole As String
    Public SessionUsername As String
    Public SessionName As String
    Public SessionEmail As String
End Module
