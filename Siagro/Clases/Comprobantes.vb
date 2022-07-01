Imports System.Data
Imports System.Data.OleDb
Public Class Comprobantes

#Region "acceso a datos"

    Dim oSqlConnection As OleDbConnection
    Dim oSqlDataAdapter As OleDbDataAdapter
    Dim oSqlCommand As OleDbCommand
    Dim oDataSet As DataSet
    Dim oDataTable As DataTable
    Dim strConection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BDsiagro.mdb;Persist Security Info=False"

#End Region

#Region "atributos comprobantes"

    Dim _idProveedor As Integer
    Dim _idComprador As Integer
    Dim _nroComprobante As Integer
    Dim _idTipoComprobante As Integer
    Dim _fechaEmision As Date
    Dim _idDetalleComprobante As Integer
    Dim _ImporteNetoGravado As Double
    Dim _importe27 As Double
    Dim _importe21 As Double
    Dim _importe105 As Double
    Dim _importe5 As Double
    Dim _importe25 As Double
    Dim _importe0 As Double
    Dim _importeOtrosTributos As Double
    Dim _importeTotal As Double
    Dim _perImpuestosGanancias As Double
    Dim _perIVA As Double
    Dim _perIIBB As Double
    Dim _impuestosInternos As Double
    Dim _impuestosMunicipales As Double

#End Region

#Region "propiedades"

    Property idProveedor() As Integer
        Get
            Return _idProveedor
        End Get
        Set(value As Integer)
            _idProveedor = value
        End Set
    End Property

    Property idComprador() As Integer
        Get
            Return _idComprador
        End Get
        Set(value As Integer)
            _idComprador = value
        End Set
    End Property

    Property nroComprobante() As Integer
        Get
            Return _nroComprobante
        End Get
        Set(value As Integer)
            _nroComprobante = value
        End Set
    End Property

    Property idTipoComprobante() As Integer
        Get
            Return _idTipoComprobante
        End Get
        Set(value As Integer)
            _idTipoComprobante = value
        End Set
    End Property

    Property fechaEmision() As Date
        Get
            Return _fechaEmision
        End Get
        Set(value As Date)
            _fechaEmision = value
        End Set
    End Property

    Property idDetalleComporobante As Integer
        Get
            Return _idDetalleComprobante
        End Get
        Set(value As Integer)
            _idDetalleComprobante = value
        End Set
    End Property

    Property importeNetoGravado() As Double
        Get
            Return _ImporteNetoGravado
        End Get
        Set(value As Double)
            _ImporteNetoGravado = value
        End Set
    End Property

    Property importe27() As Double
        Get
            Return _importe27
        End Get
        Set(value As Double)
            _importe27 = value
        End Set
    End Property

    Property importe21() As Double
        Get
            Return _importe21
        End Get
        Set(value As Double)
            _importe21 = value
        End Set
    End Property

    Property importe105() As Double
        Get
            Return _importe105
        End Get
        Set(value As Double)
            _importe105 = value
        End Set
    End Property

    Property importe5() As Double
        Get
            Return _importe5
        End Get
        Set(value As Double)
            _importe5 = value
        End Set
    End Property

    Property importe25() As Double
        Get
            Return _importe25
        End Get
        Set(value As Double)
            _importe25 = value
        End Set
    End Property

    Property importe0() As Double
        Get
            Return _importe0
        End Get
        Set(value As Double)
            _importe0 = value
        End Set
    End Property

    Property importeOtrosTributos() As Double
        Get
            Return _importeOtrosTributos
        End Get
        Set(value As Double)
            _importeOtrosTributos = value
        End Set
    End Property

    Property importeTotal() As Double
        Get
            Return _importeTotal
        End Get
        Set(value As Double)
            _importeTotal = value
        End Set
    End Property

    Property perImpuestosGanancias() As Double
        Get
            Return _perImpuestosGanancias
        End Get
        Set(value As Double)
            _perImpuestosGanancias = value
        End Set
    End Property

    Property perIVA() As Double
        Get
            Return _perIVA
        End Get
        Set(value As Double)
            _perIVA = value
        End Set
    End Property

    Property perIIBB() As Double
        Get
            Return _perIIBB
        End Get
        Set(value As Double)
            _perIIBB = value
        End Set
    End Property

    Property impuestosInternos() As Double
        Get
            Return _impuestosInternos
        End Get
        Set(value As Double)
            _impuestosInternos = value
        End Set
    End Property

    Property impuestosMunicipales() As Double
        Get
            Return _impuestosMunicipales
        End Get
        Set(value As Double)
            _impuestosMunicipales = value
        End Set
    End Property

#End Region

#Region "métodos"



#End Region
End Class
