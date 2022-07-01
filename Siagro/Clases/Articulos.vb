Imports System.Data
Imports System.Data.OleDb
Public Class Articulos

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region

#Region "Atributos"
    Dim _idArticulo As Integer
    Dim _codigo_barras As String
    Dim _descripcion As String
    Dim _idProveedor As Integer
    Dim _idRubro As Integer
    Dim _idMarca As Integer
    Dim _costo As Double
    Dim _iva As Double
    Dim _utilidad As Double
    Dim _descuento As Double
    Dim _stock As Integer
    Dim _comentario As String
    Dim _moneda As String


#End Region

#Region "Propiedades"

    Public Property idArticulo() As Integer
        Get
            Return _idArticulo
        End Get
        Set(ByVal value As Integer)
            _idArticulo = value
        End Set
    End Property

    Public Property codigo_barras() As String
        Get
            Return _codigo_barras
        End Get
        Set(ByVal value As String)
            _codigo_barras = value
        End Set
    End Property

    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property moneda() As String
        Get
            Return _moneda
        End Get
        Set(ByVal value As String)
            _moneda = value
        End Set
    End Property

    Public Property idProveedor() As Integer
        Get
            Return _idProveedor
        End Get
        Set(ByVal value As Integer)
            _idProveedor = value
        End Set
    End Property

    Public Property idRubro() As Integer
        Get
            Return _idRubro
        End Get
        Set(ByVal value As Integer)
            _idRubro = value
        End Set
    End Property

    Public Property idMarca() As Integer
        Get
            Return _idMarca
        End Get
        Set(ByVal value As Integer)
            _idMarca = value
        End Set
    End Property

    Public Property costo() As Double
        Get
            Return _costo
        End Get
        Set(ByVal value As Double)
            _costo = value
        End Set
    End Property

    Public Property iva() As Double
        Get
            Return _iva
        End Get
        Set(ByVal value As Double)
            _iva = value
        End Set
    End Property

    Public Property utilidad() As Double
        Get
            Return _utilidad
        End Get
        Set(ByVal value As Double)
            _utilidad = value
        End Set
    End Property

    Public Property descuento() As Double
        Get
            Return _descuento
        End Get
        Set(ByVal value As Double)
            _descuento = value
        End Set
    End Property

    Public Property stock() As Integer
        Get
            Return _stock
        End Get
        Set(ByVal value As Integer)
            _stock = value
        End Set
    End Property

    Public Property comentario() As String
        Get
            Return _comentario
        End Get
        Set(ByVal value As String)
            _comentario = value
        End Set
    End Property

#End Region

#Region "Metodos"

    'Función para guardar nuevo articulo
    Public Sub nuevoArticulo(ByRef objArticulo As Articulos)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Insert Into Articulos (codigo_barras,descripcion,idProveedor,idRubro,idMarca,costo,iva,utilidad,descuento,stock,comentario,moneda) Values ('" & objArticulo.codigo_barras & "','" & objArticulo.descripcion & "'," & objArticulo.idProveedor & "," & objArticulo.idRubro & "," & objArticulo.idMarca & ",'" & objArticulo.costo & "','" & objArticulo.iva & "','" & objArticulo.utilidad & "','" & objArticulo.descuento & "'," & objArticulo.stock & ",'" & objArticulo.comentario & "','" & objArticulo.moneda & "')"
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido registrar el Nuevo Articulo")
            Exit Sub
        End Try
        'MsgBox("Se registró nuevo Articulo con Exito!")
    End Sub

    'Función para modificar Articulo
    Public Sub modificarArticulo(ByRef objArticulo As Articulos)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update Articulos set codigo_barras = '" & objArticulo.codigo_barras & "', descripcion ='" & objArticulo.descripcion & "', idProveedor = " & objArticulo.idProveedor & ", idRubro = " & objArticulo.idRubro & ", idMarca = " & objArticulo.idMarca & ", costo = '" & objArticulo.costo & "', iva = '" & objArticulo.iva & "', utilidad = '" & objArticulo.utilidad & "', descuento = '" & objArticulo.descuento & "', stock = " & objArticulo.stock & ", comentario = '" & objArticulo.comentario & "', moneda = '" & objArticulo.moneda & "' where idArticulo = " & objArticulo.idArticulo
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar el Articulo")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos del Articulo con Exito!")
    End Sub

    'Funcion para buscar Articulo por código
    Public Function buscarArticulo(ByVal idArticulo As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Articulos where idArticulo = " & idArticulo & " or codigo_barras like '%" & idArticulo & "%'"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


    Public Function buscarArticuloXcodigo(ByVal idArticulo As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Articulos where idArticulo = " & idArticulo
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar Articulo por código barras
    Public Function buscarArticuloCodigoBarras(ByVal idArticulo As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Articulos where codigo_barras like '%" & idArticulo & "%'"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


    'Funcion para buscar Articulo por descripcion
    Public Function buscarArticuloXdescripcion(ByVal parametro As String) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Articulos where descripcion like '" & parametro & "%' and codigo_barras <> ' '  order by descripcion asc"
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para buscar todos los Articulos
    Public Function buscarArticulos() As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Articulos where codigo_barras <> ' '  order by descripcion asc "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    'Funcion para borrar Articulos por Código
    Public Function borrarArticulos(ByVal idArticulos As Integer) As Boolean
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "delete from Articulos where idArticulo = " & idArticulos
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Eliminar el Articulo")
            Return False
            Exit Function
        End Try
        'MsgBox("Se registró nueva Alimento con Exito!")
        '    Return True
    End Function

    'Función para restar stock Articulo
    Public Sub restarStockArticulo(ByRef objArticulo As Articulos, ByVal cantidad As Integer)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update Articulos set stock = stock - " & cantidad & " where idArticulo = " & objArticulo.idArticulo
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            'MsgBox("Disculpe. No se ha podido Actualizar el Articulo")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos del Articulo con Exito!")
    End Sub

    'Función para sumar stock Articulo
    Public Sub sumarStockArticulo(ByRef objArticulo As Articulos, ByVal cantidad As Integer)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            CadenaSQL = "Update Articulos set stock = stock + " & cantidad & " where idArticulo = " & objArticulo.idArticulo
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
            oSqlConnection.Open()
            oSqlCommand.ExecuteNonQuery()
            oSqlConnection.Close()
        Catch ex As Exception
            'MsgBox("Disculpe. No se ha podido Actualizar el Articulo")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos del Articulo con Exito!")
    End Sub

    Public Function buscarUltimoCodArticulo() As DataSet
        Try
            Dim cadena As String
            cadena = "select max(idArticulo) from Articulos "
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Function buscarArticuloXdescripcionXrubro(ByVal parametro As String, ByVal rubro As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Articulos where (descripcion like '%" & parametro & "%' or codigo_barras = '" & parametro & "') and idRubro =  " & rubro
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function


    Public Function buscarArticulosXrubro(ByVal rubro As Integer) As DataSet
        Try
            Dim cadena As String
            cadena = "select * from Articulos where idRubro =  " & rubro
            oSqlConnection = New OleDbConnection(strConection)
            oSqlDataAdapter = New OleDbDataAdapter(cadena, oSqlConnection)
            oDataSet = New DataSet
            oSqlDataAdapter.Fill(oDataSet)
            Return oDataSet
        Catch ex As Exception

        End Try

    End Function

    Public Sub modificarTodosPrecios(ByVal porc As Double, ByVal rubro As Integer)
        Try
            oSqlConnection = New OleDbConnection(strConection)
            Dim CadenaSQL As String
            If rubro = 0 Then
                CadenaSQL = "Update Articulos set costo = costo + (costo*('" & porc & "'/100))"
            Else
                CadenaSQL = "Update Articulos set costo = costo + (costo*('" & porc & "'/100)) where idRubro = " & rubro
            End If
            Dim oSqlCommand As New OleDbCommand(CadenaSQL, oSqlConnection)
                oSqlConnection.Open()
                oSqlCommand.ExecuteNonQuery()
                oSqlConnection.Close()
        Catch ex As Exception
            MsgBox("Disculpe. No se ha podido Actualizar el Articulo")
            Exit Sub
        End Try
        'MsgBox("Se Actualizaron los datos del Articulo con Exito!")
    End Sub
#End Region

End Class
