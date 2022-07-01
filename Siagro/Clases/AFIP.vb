Imports System.Data
Imports System.Data.OleDb
Public Class AFIP

#Region "Atributos"
    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    ' Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\AFIP.mdb"
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"


#End Region

#Region "Métodos Tabla Actividades"

    'Funcion para buscar actividades por código
    Public Function buscarActividades() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from actividad"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar actividad por descripcion
    Public Function buscarActividadXdescripcion(ByVal parametro As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from actividad where descripcion like '%" & parametro & "%'"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar actividad por descripcion
    Public Function buscarActividadXcodigo(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from actividad where id =" & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


#End Region

#Region "Métodos Tabla Localidad, Provincia y Departamente"
    'Funcion para buscar provincias 
    Public Function buscarProvincias() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from provincias"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar provincias 
    'Public Function buscarProvinciasXid(ByVal id As Integer) As DataSet
    '    Try
    '        Dim cadena As String
    '        cadena = "select * from provincias where idProvincia = " & id
    '        oSqlConnection = New OleDbConnection(strConection)
    '        oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
    '        oDataSet = New DataSet
    '        oSqlDataAdapter.Fill(oDataSet)
    '        Return oDataSet
    '    Catch ex As Exception

    '    End Try

    'End Function

    'Funcion para buscar localidad por descripcion
    'Public Function buscarLocalidadXdescripcion(ByVal parametro As String) As DataSet
    '    Try
    '        Dim cadena As String
    '        cadena = "select * from Localidades where Nombre like '" & parametro & "%'"
    '        oSqlConnection = New OleDbConnection(strConection)
    '        oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
    '        oDataSet = New DataSet
    '        oSqlDataAdapter.Fill(oDataSet)
    '        Return oDataSet
    '    Catch ex As Exception

    '    End Try

    'End Function


    'Funcion para buscar localidad por descripcion
    Public Function buscarLocalidad() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Localidades"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar localidad por descripcion
    Public Function buscarLocalidadXid(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Localidades where idLocalidad = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar localidad por descripcion
    'Public Function buscarDptoXLocalidad(ByVal id As Integer) As DataSet
    '    Try
    '        Dim cadena As String
    '        cadena = "select * from Partidos where idPartido = " & id
    '        oSqlConnection = New OleDbConnection(strConection)
    '        oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
    '        oDataSet = New DataSet
    '        oSqlDataAdapter.Fill(oDataSet)
    '        Return oDataSet
    '    Catch ex As Exception

    '    End Try

    'End Function

    Public Function buscarLocalidadXdescripcion(ByVal parametro As String) As DataSet
        Try
            Dim cadena As String
            'cadena = "select * from Localidades where nombre like '" & parametro & "%'"
            'oSqlConnection = New SqlConnection(strConection)
            cadena = " Select Localidades.Nombre, Partidos.Nombre, Provincias.Nombre, Localidades.cp " &
                    "From Localidades, Partidos, Provincias " &
                    "Where Localidades.Nombre  like '" & parametro & "%'" &
                    "and Localidades.idPartido = Partidos.idPartido " &
                    "And Partidos.idProvincia = Provincias.idProvincia "

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarDptoXLocalidad(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "Select idPartido, Nombre, idProvincia From Partidos Where idPartido = " & id & " Group By idPartido, Nombre, idProvincia"
            'cadena = "Select * From Partidos Where idPartido = " & id
            'oSqlConnection = New SqlConnection(strConection)
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarProvinciasXid(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = " Select * From Provincias Where idProvincia = " & id
            'oSqlConnection = New SqlConnection(strConection)
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
#End Region

#Region "Métodos Tabla Cond Iva"

    Public Function buscarCondIva() As DataSet
        Try
            Dim cadena As String
            cadena = "Select * From CondIva"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarCondIvaXcodigo(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "Select * From CondIva Where idCondicion = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


#End Region

#Region "Métodos Tabla Cod. Documento"

    Public Function buscarCodDocumento() As DataSet
        Try
            Dim cadena As String
            cadena = "Select * From Documentos"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarCodDocumentosXcodigo(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "Select * From Documentos Where Codigo = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function verificarCodDocumentosEsCuit(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = " Select * From Documentos Where Codigo = " & id & " And EsCuit = True"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


#End Region

#Region "Métodos Tabla Comprobantes"

    Public Function buscarComprobantesCompra() As DataSet
        Try
            Dim cadena As String
            cadena = "Select * From Comprobantes Where COMPRAS = 'X'"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarComprobantesCompraXid(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Comprobantes where Codigo = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


    Public Function buscarComprobantesVenta() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Comprobantes where VENTAS = 'X'"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarComprobantesVentaXid(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Comprobantes where Codigo = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
 


#End Region

#Region "Métodos Tabla Monedas"

    Public Function buscarMonedas() As DataSet
        Try
            Dim cadena As String
            cadena = "select CODIGO, (CODIGO + ' - ' + DESCRIPCION) as DESCRIPCION from Monedas "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarMonedasXidCodigo(ByVal id As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select CODIGO, (CODIGO + ' - ' + DESCRIPCION) as DESCRIPCION from Monedas where CODIGO ='" & id & "'"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function



#End Region

#Region "Métodos Tabla Codigo_OperacionCompra"

    Public Function buscarCodigoOperacion() As DataSet
        Try
            Dim cadena As String
            cadena = "select idCodigoOperacion, (Codigo + ' - ' + Descripcion) as Descripcion from Codigo_OperacionCompra "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarCodigoOperacionXcodigo(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select idCodigoOperacion, (Codigo + ' - ' + Descripcion) as Descripcion from Codigo_OperacionCompra where idCodigoOperacion =  " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarCodigoOperacionXcodigoExp(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select idCodigoOperacion, Codigo,Descripcion from Codigo_OperacionCompra where idCodigoOperacion =  " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

#End Region

#Region "Métodos Tabla Codigo_OperacionVenta"

    Public Function buscarCodigoOperacionVenta() As DataSet
        Try
            Dim cadena As String
            cadena = "select idCodigoOperacion, (Codigo + ' - ' + Descripcion) as Descripcion from Codigo_OperacionVenta "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarCodigoOperacionVentaXcodigo(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select idCodigoOperacion, (Codigo + ' - ' + Descripcion) as Descripcion from Codigo_OperacionVenta where idCodigoOperacion =  " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarCodigoOperacionVentaXcodigoExp(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select idCodigoOperacion, Codigo,Descripcion from Codigo_OperacionVenta where idCodigoOperacion =  " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

#End Region

#Region "Métodos Tabla alicuota"

    Public Function buscarAlicuotas() As DataSet
        Try
            Dim cadena As String
            cadena = "select *  from Alicuotas "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarAlicuotasXid(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select *  from Alicuotas where Codigo = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function




#End Region

#Region "Métodos Tabla Plan Cuentas"

    Public Function buscarPlan() As DataSet
        Try
            Dim cadena As String
            cadena = "select idPlan_Cuenta, UCASE(descripcion) from Plan_Cuenta "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarPlan_CuentaXid(ByVal id As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select idPlan_Cuenta, UCASE(descripcion) as descripcion from Plan_Cuenta where idPlan_Cuenta =" & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function



#End Region

    Public Function validarcuit(ByVal mk_p_nro As String) As Boolean
        Dim mk_suma As Integer
        Dim mk_valido As String
        mk_p_nro = mk_p_nro.Replace("-", "")
        If IsNumeric(mk_p_nro) Then
            If mk_p_nro.Length <> 11 Then
                mk_valido = False
            Else
                mk_suma = 0
                mk_suma += CInt(mk_p_nro.Substring(0, 1)) * 5
                mk_suma += CInt(mk_p_nro.Substring(1, 1)) * 4
                mk_suma += CInt(mk_p_nro.Substring(2, 1)) * 3
                mk_suma += CInt(mk_p_nro.Substring(3, 1)) * 2
                mk_suma += CInt(mk_p_nro.Substring(4, 1)) * 7
                mk_suma += CInt(mk_p_nro.Substring(5, 1)) * 6
                mk_suma += CInt(mk_p_nro.Substring(6, 1)) * 5
                mk_suma += CInt(mk_p_nro.Substring(7, 1)) * 4
                mk_suma += CInt(mk_p_nro.Substring(8, 1)) * 3
                mk_suma += CInt(mk_p_nro.Substring(9, 1)) * 2
                mk_suma += CInt(mk_p_nro.Substring(10, 1)) * 1
            End If

            If Math.Round(mk_suma / 11, 0) = (mk_suma / 11) Then
                mk_valido = True
            Else
                mk_valido = False
            End If
        Else
            mk_valido = False
        End If
        Return (mk_valido)
    End Function



    Public Function TA() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from TA"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


    Public Sub modificarTA(ByRef ta As String, ByVal token As String, ByVal sign As String)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update TA set ta = '" & ta & "', token ='" & token & "', sign = '" & sign & "'"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar el TA")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos del Articulo con Exito!")
    End Sub

    Public Sub insetarCaeXfactura(ByVal cae As String, ByVal vtoCae As String, ByVal idVenta As Integer, ByVal idVentaAfip As Integer)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "insert into CaeXventa (cae, vtoCae,idVenta,idVentaAfip) values ('" & cae & "', '" & vtoCae & "'," & idVenta & "," & idVentaAfip & ")"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido insertar el CAE en la base de datos")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos del Articulo con Exito!")
    End Sub


    Public Function buscarCaeXfactura(ByVal idVenta As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from CaeXventa where idVenta = " & idVenta
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarCodComprobante(ByVal idComprobante As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Comprobantes where Codigo = " & idComprobante
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

End Class
