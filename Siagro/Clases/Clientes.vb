Imports System.Data
Imports System.Data.OleDb
Public Class Clientes

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region

#Region "Variables tabla cliente"
    Dim _idCliente As Integer
    Dim _idTipo_persona As Integer
    Dim _nombre As String
    Dim _apellido As String
    Dim _apellido_materno As String
    Dim _fecha_nacimiento As String
    Dim _cuit As String
    Dim _mes_cierre_ejercicio As String
    Dim _idActividad_promovida As Integer
    Dim _idCondIva As Integer
    Dim _mail As String
#End Region
#Region "Variables tabla Domicilio_x_cliente "
    Dim _idDomicilio As Integer
    'Dim _idCliente As Integer
    Dim _idTipo_Domicilio As Integer
    Dim _calle As String
    Dim _numero As String
    Dim _sector As String
    Dim _torre As String
    Dim _piso As String
    Dim _dpto As String
    Dim _manzana As String
    Dim _localidad As String
    Dim _cp As String
#End Region
#Region "Variables tabla Actividades_x_cliente"
    Dim _idActividad_x_cliente As Integer
    Dim _idTipo_actividad As Integer
    Dim _idCodigo_actividad As Integer
#End Region
#Region "Variables tabla Claves_bancarias_x_cliente"
    Dim _idClave_bancaria As Integer
    Dim _cbu As String
#End Region
#Region "Variables tabla Responsable_x_cliente"
    Dim _idResponsable As Integer
    Dim _nombreResponsable As String
    Dim _pais As String
    Dim _dniResponsable As Integer
#End Region

#Region "Propiedades Cliente"
    Public Property idCliente() As Integer
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property
    Public Property idTipo_persona() As Integer
        Get
            Return _idTipo_persona
        End Get
        Set(ByVal value As Integer)
            _idTipo_persona = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Public Property apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property
    Public Property apellido_materno() As String
        Get
            Return _apellido_materno
        End Get
        Set(ByVal value As String)
            _apellido_materno = value
        End Set
    End Property
    Public Property fecha_nacimiento() As String
        Get
            Return _fecha_nacimiento
        End Get
        Set(ByVal value As String)
            _fecha_nacimiento = value
        End Set
    End Property
    Public Property cuit() As String
        Get
            Return _cuit
        End Get
        Set(ByVal value As String)
            _cuit = value
        End Set
    End Property
    Public Property mes_cierre_ejercicio() As String
        Get
            Return _mes_cierre_ejercicio
        End Get
        Set(ByVal value As String)
            _mes_cierre_ejercicio = value
        End Set
    End Property
    Public Property idActividad_promovida() As Integer
        Get
            Return _idActividad_promovida
        End Get
        Set(ByVal value As Integer)
            _idActividad_promovida = value
        End Set
    End Property
    Public Property idCondIva() As Integer
        Get
            Return _idCondIva
        End Get
        Set(ByVal value As Integer)
            _idCondIva = value
        End Set
    End Property
    Public Property mail() As String
        Get
            Return _mail
        End Get
        Set(ByVal value As String)
            _mail = value
        End Set
    End Property
#End Region
#Region "Propiedades Domicilio_x_cliente"
    Public Property idDomicilio() As Integer
        Get
            Return _idDomicilio
        End Get
        Set(ByVal value As Integer)
            _idDomicilio = value
        End Set
    End Property
    Public Property idTipo_domicilio() As Integer
        Get
            Return _idTipo_Domicilio
        End Get
        Set(ByVal value As Integer)
            _idTipo_Domicilio = value
        End Set
    End Property
    Public Property calle() As String
        Get
            Return _calle
        End Get
        Set(ByVal value As String)
            _calle = value
        End Set
    End Property
    Public Property numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property
    Public Property sector() As String
        Get
            Return _sector
        End Get
        Set(ByVal value As String)
            _sector = value
        End Set
    End Property
    Public Property torre() As String
        Get
            Return _torre
        End Get
        Set(ByVal value As String)
            _torre = value
        End Set
    End Property
    Public Property piso() As String
        Get
            Return _piso
        End Get
        Set(ByVal value As String)
            _piso = value
        End Set
    End Property
    Public Property dpto() As String
        Get
            Return _dpto
        End Get
        Set(ByVal value As String)
            _dpto = value
        End Set
    End Property
    Public Property manzana() As String
        Get
            Return _manzana
        End Get
        Set(ByVal value As String)
            _manzana = value
        End Set
    End Property
    Public Property localidad() As String
        Get
            Return _localidad
        End Get
        Set(ByVal value As String)
            _localidad = value
        End Set
    End Property
    Public Property cp() As String
        Get
            Return _cp
        End Get
        Set(ByVal value As String)
            _cp = value
        End Set
    End Property
#End Region
#Region "Propiedades Actividades_x_cliente"
    Public Property idActividad_x_cliente() As Integer
        Get
            Return _idActividad_x_cliente
        End Get
        Set(ByVal value As Integer)
            _idActividad_x_cliente = value
        End Set
    End Property
    Public Property idTipo_actividad() As Integer
        Get
            Return _idTipo_actividad
        End Get
        Set(ByVal value As Integer)
            _idTipo_actividad = value
        End Set
    End Property
    Public Property idCodigo_actividad() As Integer
        Get
            Return _idCodigo_actividad
        End Get
        Set(ByVal value As Integer)
            _idCodigo_actividad = value
        End Set
    End Property
#End Region
#Region "Propiedades Claves_bancarias_x_cliente"
    Public Property idClave_bancaria() As Integer
        Get
            Return _idClave_bancaria
        End Get
        Set(ByVal value As Integer)
            _idClave_bancaria = value
        End Set
    End Property
    Public Property cbu() As String
        Get
            Return _cbu
        End Get
        Set(ByVal value As String)
            _cbu = value
        End Set
    End Property

#End Region
#Region "Propiedades Responsable_x_cliente"
    Public Property idResponsable() As Integer
        Get
            Return _idResponsable
        End Get
        Set(ByVal value As Integer)
            _idResponsable = value
        End Set
    End Property
    Public Property dniResponsable() As Integer
        Get
            Return _dniResponsable
        End Get
        Set(ByVal value As Integer)
            _dniResponsable = value
        End Set
    End Property
    Public Property nombreResponsable() As String
        Get
            Return _nombreResponsable
        End Get
        Set(ByVal value As String)
            _nombreResponsable = value
        End Set
    End Property
    Public Property pais() As String
        Get
            Return _pais
        End Get
        Set(ByVal value As String)
            _pais = value
        End Set
    End Property

#End Region

#Region "Métodos Clientes"

    'Función para guardar nuevo cliente
    Public Function nuevoCliente(ByRef objCliente As Clientes) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Clientes (idTipo_persona,nombre,apellido,apellido_materno,fecha_nacimiento,cuit,mes_cierre_ejercicio,idActividad_promovida, idIva,mail) Values (" & objCliente.idTipo_persona & ",'" & objCliente.nombre & "','" & objCliente.apellido & "','" & objCliente.apellido_materno & "','" & objCliente.fecha_nacimiento & "','" & objCliente.cuit & "','" & objCliente.mes_cierre_ejercicio & "'," & objCliente.idActividad_promovida & "," & objCliente.idCondIva & ",'" & objCliente.mail & "')"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el Nuevo Cliente")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nuevo Cliente con Exito!")
        Return True
    End Function
    'Funcion para buscar último Cliente
    Public Function buscarUltimoCliente() As DataSet
        Try
            Dim cadena As String
            cadena = "select max(idCliente) from Clientes "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Función para guardar nuevo domicilio x cliente
    Public Sub nuevoDomicilio_x_cliente(ByRef objCliente As Clientes)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Domicilio_x_cliente (idCliente,idTipo_domicilio,calle,numero,sector,torre, piso, dpto, manzana, localidad,cp) Values (" _
            & objCliente.idCliente & "," & objCliente.idTipo_domicilio & ",'" & objCliente.calle & "','" & objCliente.numero & "','" & objCliente.sector & "','" & objCliente.torre & "','" _
            & objCliente.piso & "','" & objCliente.dpto & "','" & objCliente.manzana & "','" & objCliente.localidad & "','" & objCliente.cp & "')"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el Nuevo Cliente")
            Exit Sub
        End Try
        'MsgBox("Se registró nuevo Domicilio con Exito!")
    End Sub
    'Función para guardar nueva Actividades_x_cliente
    Public Sub nuevoActividad_x_cliente(ByRef objCliente As Clientes)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Actividades_x_cliente (idCliente,idTipo_actividad,idCodigo_actividad) Values (" & objCliente.idCliente & "," & objCliente.idTipo_actividad & "," & objCliente.idCodigo_actividad & ")"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el Nuevo Cliente")
            Exit Sub
        End Try
        'MsgBox("Se registró nueva Actividad con Exito!")
    End Sub
    'Función para guardar nueva Claves_bancarias_x_cliente
    Public Sub nuevaClaves_bancarias_x_cliente(ByRef objCliente As Clientes)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Claves_bancarias_x_cliente (idCliente,cbu) Values (" & objCliente.idCliente & ",'" & objCliente.cbu & "')"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el Nuevo Cliente")
            Exit Sub
        End Try
        'MsgBox("Se registró nueva Clave bancaria con Exito!")
    End Sub
    'Función para guardar nuevo Responsable_x_cliente
    Public Sub nuevoResponsable_x_cliente(ByRef objCliente As Clientes)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Responsable_x_cliente (idCliente,nombre, pais, dni) Values (" & objCliente.idCliente & ",'" & objCliente.nombreResponsable & "','" & objCliente.pais & "'," & objCliente.dniResponsable & ")"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el Nuevo Cliente")
            Exit Sub
        End Try
        'MsgBox("Se registró nuev Responsable_x_cliente con Exito!")
    End Sub
    'Funcion para buscar todos Cliente
    Public Function buscarClientes() As DataSet
        Try
            Dim cadena As String
            cadena = "select idCliente, cuit, (apellido + ' ' + nombre) as Cliente from Clientes where borrar = false and trim(nombre) <> ' '  order by apellido asc "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para buscar cleinte por descripcion
    Public Function buscarClientesXdescripcion(ByVal parametro As String) As DataSet
        Try
            Dim cadena As String
            'cadena = "select idCliente, cuit, (trim(apellido) + ' ' + trim(nombre)) as cliente from Clientes where (trim(apellido) like '%" & parametro & "%' or trim(nombre) like '%" & parametro & "%') and borrar = false and trim(nombre) <> ' '  order by apellido asc"
            cadena = "select idCliente, cuit, (trim(apellido) + ' ' + trim(nombre)) as cliente from Clientes where (trim(apellido) + ' ' + trim(nombre)) like '%" & parametro & "%'  and borrar = false and trim(nombre) <> ' '  order by apellido asc"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para buscar cliente por id
    Public Function buscarClientesXid(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            If id = 1 Then
                cadena = "select * from Clientes where idCliente = " & id

            Else
                cadena = "select * from Clientes where idCliente = " & id & " and borrar = false"

            End If
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para buscar domicilio por id de cliente
    Public Function buscarDomicilioXidCliente(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Domicilio_x_cliente where idCliente = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para buscar domicilio por id de domicilio
    Public Function buscarDomicilioXidDomicilio(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Domicilio_x_cliente where idDomicilio = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para buscar actividad por id de cliente
    Public Function buscarActividadesXidCliente(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Actividades_x_cliente where idCliente = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para buscar actividad por id de actividad
    Public Function buscarActividadesXidActividad(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Actividades_x_cliente where idActividad_x_cliente = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para buscar Claves_bancarias_x_cliente por id de cliente
    Public Function buscarClavesBancariasXidCliente(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Claves_bancarias_x_cliente where idCliente = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para buscar Claves_bancarias_x_cliente por id de cliente
    Public Function buscarClavesBancariasXidClave(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Claves_bancarias_x_cliente where idClave_bancaria = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para buscar Responsable_x_cliente por id de cliente
    Public Function buscarReponsableXidCliente(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Responsable_x_cliente where idCliente = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para buscar Responsable_x_cliente por id de cliente
    Public Function buscarReponsableXidResponsable(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Responsable_x_cliente where idResponsable = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


    'Funcion para Clientes por Código
    Public Function borrarCliente(ByVal idCliente As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Clientes where idCliente = " & idCliente
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el Cliente")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function
    'Funcion para Clientes por Código
    Public Function borrarDomicilioXcliente(ByVal idCliente As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Domicilio_x_cliente where idCliente = " & idCliente
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el Cliente")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function
    'Funcion para Clientes por Código
    Public Function borrarActividadesXcliente(ByVal idCliente As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Actividades_x_cliente where idCliente = " & idCliente
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el Cliente")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function
    'Funcion para Clientes por Código
    Public Function borrarClavesXcliente(ByVal idCliente As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Claves_bancarias_x_cliente where idCliente = " & idCliente
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el Cliente")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function
    'Funcion para Clientes por Código
    Public Function borrarResponsableXcliente(ByVal idCliente As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Responsable_x_cliente where idCliente = " & idCliente
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el Cliente")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function

    'Función para modificar cliente
    Public Function modificarCliente(ByRef objCliente As Clientes) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update Clientes set idTipo_persona = " & objCliente.idTipo_persona & " ,nombre = '" & objCliente.nombre & "',apellido='" & objCliente.apellido & "',apellido_materno='" & objCliente.apellido_materno & "',fecha_nacimiento='" & objCliente.fecha_nacimiento & "',cuit= '" & objCliente.cuit & "',mes_cierre_ejercicio = '" & objCliente.mes_cierre_ejercicio & "',idActividad_promovida = " & objCliente.idActividad_promovida & ", idIva =  " & objCliente.idCondIva & ", mail = '" & objCliente.mail & "'  where idCliente = " & objCliente.idCliente
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Modificar el Cliente")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nuevo Cliente con Exito!")
        Return True
    End Function
    Public Function buscarClienteXnombre(ByVal parametro As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Clientes where razon_social like '%" & parametro & "%'  by apellido asc"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarCliente(ByVal idCliente As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Clientes where idCliente =  " & idCliente
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function resumenCtaCteCliente() As DataSet
        Try
            Dim cadena As String
            cadena = "SELECT v.idCliente, c.nombre + ' ' + c.apellido AS Expr1, SUM(v.monto) AS Expr2 FROM (Ventas v INNER JOIN Clientes c ON v.idCliente = c.IdCliente) GROUP BY v.idCliente, c.nombre + ' ' + c.apellido"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


    Public Function buscarMail(ByVal idCliente As Integer) As DataSet
        Try
            Dim cadena As String
            Dim mail As String
            cadena = "select mail from Clientes where idCliente = " & idCliente
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            ' mail = oDataSet.Tables(0).Rows(0).Item("mail").ToString
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
#End Region
End Class
