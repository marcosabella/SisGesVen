Imports System.Data
Imports System.Data.OleDb
Public Class Proveedores

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region

#Region "Variables tabla proveedor"
    Dim _idProveedor As Integer
    Dim _idTipo_persona As Integer
    Dim _razon_social As String
    Dim _cuit As String
    Dim _iibb As String
    Dim _idCodDocumento As Integer
    Dim _idCondIva As Integer
#End Region
#Region "Variables tabla Domicilio_x_proveedor "
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
    Dim _idLocalidad As Integer
    Dim _localidad As String
    Dim _cp As String
#End Region
#Region "Variables tabla Responsable_x_proveedor"
    Dim _idResponsable As Integer
    Dim _nombreResponsable As String
    Dim _telefono As String
#End Region
#Region "Variables tabla Compra proveedor"
    Dim _idCompraProveedores As Integer
    Dim _montoCompra As Double
    Dim _fechaCompra As Date
    Dim _comprobanteCompra As String
    Dim _idComprobante As Integer
#End Region

#Region "Propiedades Proveedor"
    Public Property idProveedor() As Integer
        Get
            Return _idProveedor
        End Get
        Set(ByVal value As Integer)
            _idProveedor = value
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
    Public Property razon_social() As String
        Get
            Return _razon_social
        End Get
        Set(ByVal value As String)
            _razon_social = value
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
    Public Property iibb() As String
        Get
            Return _iibb
        End Get
        Set(ByVal value As String)
            _iibb = value
        End Set
    End Property
    Public Property idCodDocumento() As Integer
        Get
            Return _idCodDocumento
        End Get
        Set(ByVal value As Integer)
            _idCodDocumento = value
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


#End Region
#Region "Propiedades Domicilio_x_proveedor"
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
    Public Property idLocalidad() As Integer
        Get
            Return _idLocalidad
        End Get
        Set(ByVal value As Integer)
            _idLocalidad = value
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

    Public Property localidad() As String
        Get
            Return _localidad
        End Get
        Set(ByVal value As String)
            _localidad = value
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
    Public Property nombreResponsable() As String
        Get
            Return _nombreResponsable
        End Get
        Set(ByVal value As String)
            _nombreResponsable = value
        End Set
    End Property
    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

#End Region
#Region "Propiedades ComraProveedor"
    Public Property idCompraProveedores() As Integer
        Get
            Return _idCompraProveedores
        End Get
        Set(ByVal value As Integer)
            _idCompraProveedores = value
        End Set
    End Property
    Public Property monto() As Double
        Get
            Return _montoCompra
        End Get
        Set(ByVal value As Double)
            _montoCompra = value
        End Set
    End Property
    Public Property fecha() As Date
        Get
            Return _fechaCompra
        End Get
        Set(ByVal value As Date)
            _fechaCompra = value
        End Set
    End Property
    Public Property comprobanteCompra() As String
        Get
            Return _comprobanteCompra
        End Get
        Set(ByVal value As String)
            _comprobanteCompra = value
        End Set
    End Property

    Public Property idComprobante() As Integer
        Get
            Return _idComprobante
        End Get
        Set(ByVal value As Integer)
            _idComprobante = value
        End Set
    End Property
#End Region

#Region "Métodos Clientes"

    'Función para guardar nuevo proveedor
    Public Function nuevoProveedor(ByRef objProveedor As Proveedores) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Proveedores (idTipo_persona,razon_social,cuit,iibb,idCodDocumento,idCondIva) Values (" & objProveedor.idTipo_persona & ",'" & objProveedor.razon_social & "','" & objProveedor.cuit & "','" & objProveedor.iibb & "'," & objProveedor.idCodDocumento & "," & objProveedor.idCondIva & ")"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el Nuevo Proveedor")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nuevo Cliente con Exito!")
        Return True
    End Function
    'Funcion para buscar último Cliente
    Public Function buscarUltimoProveedor() As DataSet
        Try
            Dim cadena As String
            cadena = "select max(idProveedor) from Proveedores "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Función para guardar nuevo domicilio x cliente
    Public Sub nuevoDomicilio_x_proveedor(ByRef objProveedor As Proveedores)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Domicilio_x_proveedor (idProveedor,idTipo_domicilio,calle,numero,sector,torre, piso, dpto, manzana, localidad,cp) Values (" _
            & objProveedor.idProveedor & "," & objProveedor.idTipo_domicilio & ",'" & objProveedor.calle & "','" & objProveedor.numero & "','" & objProveedor.sector & "','" & objProveedor.torre & "','" _
            & objProveedor.piso & "','" & objProveedor.dpto & "','" & objProveedor.manzana & "','" & objProveedor.localidad & "','" & objProveedor.cp & "')"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el Nuevo Proveedor")
            Exit Sub
        End Try
        'MsgBox("Se registró nuevo Domicilio con Exito!")
    End Sub
    'Función para guardar nuevo Responsable_x_proveedor
    Public Sub nuevoResponsable_x_proveedor(ByRef objProveedor As Proveedores)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Responsable_x_proveedor (idProveedor,nombreResponsable, telefono) Values (" & objProveedor.idProveedor & ",'" & objProveedor.nombreResponsable & "','" & objProveedor.telefono & "')"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el Nuevo Proveedor")
            Exit Sub
        End Try
        'MsgBox("Se registró nuev Responsable_x_cliente con Exito!")
    End Sub

    'Funcion para buscar todos Cliente
    Public Function buscarProveedores() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Proveedores where idProveedor > 1 order by razon_social asc"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para buscar cleinte por descripcion
    Public Function buscarProveedoresXdescripcion(ByVal parametro As String) As DataSet
        Try
            Dim cadena As String
            If parametro <> "" Then
                cadena = "select * from Proveedores where trim(razon_social) like '" & parametro & "%' and idProveedor > 1 order by razon_social asc"
            Else
                cadena = "select * from Proveedores where idProveedor > 1 order by razon_social asc"
            End If

            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para buscar cliente por id
    Public Function buscarProveedoresXid(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Proveedores where idProveedor = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para buscar domicilio por id de cliente
    Public Function buscarDomicilioXidProveedor(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Domicilio_x_proveedor where idProveedor = " & id
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
            cadena = "select * from Domicilio_x_proveedor where idDomicilio = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


    'Funcion para buscar Responsable_x_cliente por id de cliente
    Public Function buscarReponsableXidProveedor(ByVal id As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Responsable_x_proveedor where idProveedor = " & id
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
            cadena = "select * from Responsable_x_proveedor where idResponsable = " & id
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    'Funcion para Clientes por Código
    Public Function borrarProveedor(ByVal idProveedor As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Proveedores where idProveedor = " & idProveedor
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el Proveedor")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function
    'Funcion para Clientes por Código
    Public Function borrarDomicilioXproveedor(ByVal idProveedor As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Domicilio_x_proveedor where idProveedor = " & idProveedor
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el Proveedor")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function
    'Funcion para Clientes por Código
    Public Function borrarResponsableXproveedor(ByVal idProveedor As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Responsable_x_proveedor where idProveedor = " & idProveedor
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el Proveedor")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function


    'Función para modificar cliente
    Public Function modificarProveedor(ByRef objProveedor As Proveedores) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update Proveedores set idTipo_persona = " & objProveedor.idTipo_persona & " ,razon_social = '" & objProveedor.razon_social & "',cuit= '" & objProveedor.cuit & "',iibb = '" & objProveedor.iibb & "', idCodDocumento = " & objProveedor.idCodDocumento & ",idCondIva= " & objProveedor.idCondIva & " where idProveedor = " & objProveedor.idProveedor
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

#End Region

#Region "Metodos"

    'Función para guardar nuevo proveedor


    'Función para modificar Proveedor


    'Funcion para buscar Proveedor por código
    Public Function buscarProveedor(ByVal idProveedor As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Proveedores where idProveedor =  " & idProveedor
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar Proveedor por Nombre
    Public Function buscarProveedorXnombre(ByVal parametro As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Proveedores where razon_social like '%" & parametro & "%'"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar todos los Proveedores
    Public Function buscarProveredores() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Proveedores "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para borrar Proveedores por Código
    Public Function borrarProveedores(ByVal idProveedor As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Proveedores where idProveedor = " & idProveedor
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el Proveedor")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function

    'Funcion para buscar Proveedor por Nombre
    Public Function validarNombreRepetido(ByVal parametro As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Proveedores where razon_social = '" & parametro & "'"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function




    'Funcion para buscar último Proveedor

    Public Function buscarPagosXProveedor(ByVal idProveedor As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from PagosProveedores where idProveedor = " & idProveedor
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


    Public Function buscarPagosProveedoresXid(ByVal idPago As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from PagosProveedores where idPago = " & idPago
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
#End Region

#Region "Métodos Compra Proveedor"
    Public Function buscarComprasPorProveedor(ByVal idProveedor As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from CompraProveedor where idProveedor = " & idProveedor
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function
    Public Function buscarComprasPorID(ByVal idCompraProveedor As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from CompraProveedor where idCompraProveedores = " & idCompraProveedor
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Sub nuevaCompra(ByRef objProveedores As Proveedores)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into CompraProveedor (idProveedor,fecha,monto,numeroComprobante,idComprobante) Values (" & objProveedores.idProveedor & ",'" & objProveedores.fecha & "', '" & objProveedores.monto & "', '" & objProveedores.comprobanteCompra & "', " & objProveedores.idComprobante & ")"
            'CadenaSQL = ""
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar la compra")

        End Try


    End Sub

    Public Sub modificarCompra(ByRef objProveedor As Proveedores)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update CompraProveedor set monto ='" & objProveedor.monto & "' ,numeroComprobante = '" & objProveedor.comprobanteCompra & "' ,idComprobante = '" & objProveedor.idComprobante & "' where idcompraProveedores = " & objProveedor.idCompraProveedores
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar la compra")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos del pago con Exito!")
    End Sub

    Public Function borrarCompraProveedores(ByVal id As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from CompraProveedor where idCompraProveedores = " & id
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar la compra")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function
#End Region
End Class
