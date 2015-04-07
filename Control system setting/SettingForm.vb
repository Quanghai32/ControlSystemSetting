Imports System.Data.SqlClient

Public Class SettingForm

    Private myAdapter() As SqlDataAdapter
    Private myDataset() As DataSet

    Private myTableName() As String = New String() {"AGV", "EndDevices", "HostXbee", "LineGroup", "Part", "StartPoint", "CrossTable", "AGVGroup", "ParkPoint", "WorkingTime"}
    Private myDgv() As DataGridView

    Private TableSIZE As Integer

    Public SQLstrConn As String = "Data Source=" + My.Computer.Name + "\SQLEXPRESS;Integrated Security=True"
    Public SQLcon As SqlConnection

    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQLcon = New SqlConnection(SQLstrConn)
        SQLcon.Open()

        myDgv = New DataGridView() {dgvAGV, dgvEndDevices, dgvHostXbee, dgvLineGroup, dgvPart, dgvStartPoint, dgvCrossPoint, dgvAGVGroup, dgvParkPoint, dgvWorkingTime}

        TableSIZE = myTableName.Count
        myAdapter = New SqlDataAdapter(TableSIZE - 1) {}
        myDataset = New DataSet(TableSIZE - 1) {}

        For i As Byte = 0 To TableSIZE - 1
            ReadData(myAdapter(i), myDataset(i), myTableName(i))
            myDgv(i).DataSource = myDataset(i)
            myDgv(i).DataMember = myTableName(i)
        Next
    End Sub

    Private Sub ReadData(ByRef adapter As SqlDataAdapter, ByRef ds As DataSet, ByVal TableName As String)
        adapter = New SqlDataAdapter("SELECT * FROM " + TableName, SQLcon)
        ds = New DataSet
        adapter.Fill(ds, TableName)
    End Sub
    Private Sub WriteData(ByRef adapter As SqlDataAdapter, ByRef ds As DataSet, ByVal TableName As String)
        Dim objCommandBuilder As New SqlCommandBuilder(adapter)
        adapter.Update(ds, TableName)
        objCommandBuilder.Dispose()
    End Sub
    Private Sub butSettingOK_Click(sender As Object, e As EventArgs) Handles butSettingOK.Click
        For i As Byte = 0 To TableSIZE - 1
            WriteData(myAdapter(i), myDataset(i), myTableName(i))
        Next
        Environment.Exit(0)
    End Sub

    Private Sub butSettingCancel_Click(sender As Object, e As EventArgs) Handles butSettingCancel.Click
        Close()
    End Sub
End Class