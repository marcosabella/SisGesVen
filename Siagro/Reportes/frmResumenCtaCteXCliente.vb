Imports System.Data
Imports System.Data.OleDb
Public Class frmResumenCtaCteXCliente
    Dim mandarMail As Boolean
    Dim id As Integer
#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlDataAdapter1 As OleDbDataAdapter
    Dim oSqlArticuloDataAdapter As OleDbDataAdapter
    Dim oSqlClienteDataAdapter As OleDbDataAdapter
    Dim oSqlComprobanteDataAdapter As OleDbDataAdapter
    Dim oSqlCondicionVentaDataAdapter As OleDbDataAdapter
    Dim oSqlCondIvaDataAdapter As OleDbDataAdapter
    Dim oSqlDetalleVentaDataAdapter As OleDbDataAdapter
    Dim oSqlVentasDataAdapter As OleDbDataAdapter
    Dim oSqlLocaldidadesDataAdapter As OleDbDataAdapter
    Dim oSqlDomicilio_x_clienteDataAdapter As OleDbDataAdapter
    Dim oSqlPagosDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"


    Public Sub New(ByVal mail As Boolean, ByVal idcliente As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        mandarMail = mail
        id = idcliente
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#End Region
    Private Sub frmResumenCtaCteXCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarReporte()
    End Sub

    Public Sub llenarReporte()
        Dim objClientes As New Clientes
        Dim cadenaCliente As String
        Dim cadenaPagos As String



        Dim informe As Object
        informe = New rpCtaCteXcliente
        Dim tituloInforme As New CrystalDecisions.Shared.ParameterField
        Dim paramtituloInforme As New CrystalDecisions.Shared.ParameterDiscreteValue

        cadenaCliente = "select * from Clientes"
        cadenaPagos = "select * from TempCtaCte order by FechaComprobante asc"

        oSqlConnection = New OleDbConnection(strConection)

        oSqlClienteDataAdapter = New OleDbDataAdapter(cadenaCliente, oSqlConnection)
        oSqlPagosDataAdapter = New OleDbDataAdapter(cadenaPagos, oSqlConnection)

        oDataSet = New dsParaReporte
        oSqlClienteDataAdapter.Fill(oDataSet, "Clientes")
        oSqlPagosDataAdapter.Fill(oDataSet, "TempCtaCte")

        'tituloInforme.ParameterFieldName = "tituloInforme" ' Este es el nombre del parametro en el crystal
        'paramtituloInforme.Value = "Resumen de Cuenta Corriente"


        'tituloInforme.CurrentValues.Add(paramtituloInforme)

        'Dim parametros As New CrystalDecisions.Shared.ParameterFields
        'parametros.Add(tituloInforme)


        informe.SetDataSource(oDataSet)
        'visorCtaCteXCliente.ReportSource = informe
        'visorCtaCteXCliente.ParameterFieldInfo = parametros
        'visorCtaCteXCliente.Refresh()

        'MsgBox(objClientes.buscarMail(id).Tables(0).Rows(0).Item("mail"))

        If mandarMail = True Then
            Dim objMail As New Mail
            objMail.textoCuerpo = "Resumen Cuenta Corriente"
            objMail.ExportToPDF(informe, "Resumen cuenta corriente.pdf", "Resumen Cuenta Corriente", LCase(objClientes.buscarMail(id).Tables(0).Rows(0).Item("mail").ToString))
            Me.Close()
        Else
            visorCtaCteXCliente.ReportSource = informe
            'visorCtaCteXCliente.ParameterFieldInfo = parametros
            'visorCtaCteXCliente.Refresh()

        End If

    End Sub


End Class