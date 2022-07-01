Imports System.ComponentModel

Public Class Form1
    Public Shared cotizacionDolarOficial As Double
    Public Shared cotizacionDolarBlue As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim frmProveedores As New frmProveedores
        frmProveedores.Show()
    End Sub

    Private Sub tssClientes_Click(sender As Object, e As EventArgs) Handles tssClientes.Click
        Dim frmCliente As New frmCliente
        frmCliente.ShowDialog()
    End Sub

    Private Sub tssProveedores_Click(sender As Object, e As EventArgs) Handles tssProveedores.Click
        Dim frmProveedor As New frmProveedores
        frmProveedor.ShowDialog()
    End Sub

    Private Sub tssProductos_Click(sender As Object, e As EventArgs) Handles tssProductos.Click
        Dim frmProductos As New frmArticulo
        frmProductos.ShowDialog()
    End Sub

    Private Sub tssVentas_Click(sender As Object, e As EventArgs) Handles tssVentas.Click
        Dim frmVentas As New frmVentas
        frmVentas.ShowDialog()
        cotizacionDolar()
    End Sub

    Private Sub tssCtaCte_Click(sender As Object, e As EventArgs) Handles tssCtaCte.Click

    End Sub

    Private Sub tssPagos_Click(sender As Object, e As EventArgs)
        Dim frmPagos As New frmPagos
        frmPagos.ShowDialog()
    End Sub

    Private Sub tssCotizacionDolar_Click(sender As Object, e As EventArgs) Handles tssCotizacionDolar.Click
        Dim frmCotizacion As New frmCotizacionDolar
        frmCotizacion.ShowDialog()
        cotizacionDolar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim oDataSetValidarUsuario As New DataSet
        Dim frmLogin As New frmLogin
        frmLogin.ShowDialog()
        oDataSetValidarUsuario = frmLogin.oDataSetValidar
        validarPermisoUsuarios(oDataSetValidarUsuario)
        cotizacionDolar()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim frmReporteCliente As New frmListadoClientes
        frmReporteCliente.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim frmReporteArtiuclos As New frmListadoArticulos
        frmReporteArtiuclos.ShowDialog()
    End Sub

    Private Sub CtaCtesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CtaCtesToolStripMenuItem.Click
        'Dim frmListadoCtaCte As New frmListadoCtaCte
        Dim frmListadoCtaCte As New frmSaldoCtaCteClientes
        frmListadoCtaCte.ShowDialog()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Dim frmListadoVentas As New frmListadoVentas
        frmListadoVentas.ShowDialog()
    End Sub

    Private Sub tssSalir_Click(sender As Object, e As EventArgs) Handles tssSalir.Click
        Me.Close()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("¿Desea realmente cerrar la aplicación?", "SISTEMAS GESTIÓN DE VENTAS Y STOCK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            'If MessageBox.Show("¿Desea realizar copia de respaldo de su base de datos?", "SISTEMAS GESTIÓN DE VENTAS Y STOCK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            'Dim frmRespaldo As New frmRespaldoBD
            'frmRespaldo.ShowDialog()
            'Else
            '   e.Cancel = True
            'End If

            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim frmListadoProveedores As New frmListadoProveedores
        frmListadoProveedores.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tssListaPrecios.Click
        Dim frmBuscarProductos As New frmBuscarArticulos
        frmBuscarProductos.ShowDialog()
    End Sub

    Private Sub CtaCteClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CtaCteClientesToolStripMenuItem.Click
        Dim frmCtaCte As New frmCtaCte
        frmCtaCte.ShowDialog()
    End Sub

    Private Sub CtaCteProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CtaCteProveedoresToolStripMenuItem.Click
        Dim frmCtaCteProveedores As New frmCtaCteProveedores
        frmCtaCteProveedores.ShowDialog()
    End Sub

    Private Sub tssOT_Click(sender As Object, e As EventArgs) Handles tssOT.Click
        Dim frmOT As New frmOrdenTrabajo
        frmOT.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        'Dim frmCam As New WebcamForm
        'frmCam.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim frmUsuarios As New frmUsuario
        frmUsuarios.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim oDataSetValidarUsuario As New DataSet
        Dim frmLogin As New frmLogin
        frmLogin.ShowDialog()
        oDataSetValidarUsuario = frmLogin.oDataSetValidar
        validarPermisoUsuarios(oDataSetValidarUsuario)
    End Sub

    Private Sub validarPermisoUsuarios(ByVal oDataSetValidar As DataSet)
        tssConfiguracion.Enabled = oDataSetValidar.Tables(0).Rows(0).Item("configuracion")
        tssClientes.Enabled = oDataSetValidar.Tables(0).Rows(0).Item("clientes")
        tssProveedores.Enabled = oDataSetValidar.Tables(0).Rows(0).Item("proveedores")
        tssProductos.Enabled = oDataSetValidar.Tables(0).Rows(0).Item("productos")
        tssVentas.Enabled = oDataSetValidar.Tables(0).Rows(0).Item("ventas")
        tssOpcionCtaCte.Enabled = oDataSetValidar.Tables(0).Rows(0).Item("ctacte")
        tssListados.Enabled = oDataSetValidar.Tables(0).Rows(0).Item("listados")
        tssListaPrecios.Enabled = oDataSetValidar.Tables(0).Rows(0).Item("listaPrecios")
        Me.tssBarraInferiorUsuario.Text = "USUARIO: " & UCase(oDataSetValidar.Tables(0).Rows(0).Item("nombre"))
    End Sub

    Private Sub TarjetasDeCréditoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarjetasDeCréditoToolStripMenuItem.Click
        Dim frmTarjetas As New frmTarjetas
        frmTarjetas.ShowDialog()
    End Sub

    Private Sub tssDolar_Click(sender As Object, e As EventArgs) Handles tssDolar.Click
        Dim frmDolar As New frmCotizacionDolar
        frmDolar.ShowDialog()
    End Sub

    Private Sub CarteraChequesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarteraChequesToolStripMenuItem.Click
        Dim frmCarteraCheques As New frmCarteraCheque
        frmCarteraCheques.ShowDialog()
    End Sub

    Private Sub tssPresupuesto_Click(sender As Object, e As EventArgs) Handles tssPresupuesto.Click
        Dim frmPresupuestos As New frmPresupuestos
        frmPresupuestos.ShowDialog()
        cotizacionDolar()
    End Sub

    Public Sub cotizacionDolar()
        Dim oDataSet As New DataSet
        Dim objVentas As New Ventas
        'MsgBox(objVentas.ultimaCotización("U$D BLUE").Tables(0).Rows(0).Item(0))
        If IsDBNull(objVentas.ultimaCotización("U$D BLUE").Tables(0).Rows(0).Item(0)) Then
            lblBlue.Text = "S/C"
        Else
            cotizacionDolarBlue = objVentas.cotizaciónXid(objVentas.ultimaCotización("U$D BLUE").Tables(0).Rows(0).Item(0)).Tables(0).Rows(0).Item("monto").ToString

            lblBlue.Text = "U$D " & cotizacionDolarBlue
        End If

        If IsDBNull(objVentas.ultimaCotización("U$D OFICIAL").Tables(0).Rows(0).Item(0)) Then
            lblOficial.Text = "S/C"
        Else
            cotizacionDolarOficial = objVentas.cotizaciónXid(objVentas.ultimaCotización("U$D OFICIAL").Tables(0).Rows(0).Item(0)).Tables(0).Rows(0).Item("monto").ToString

            lblOficial.Text = "U$D " & cotizacionDolarOficial
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim frmRespaldo As New frmRespaldoBD
        frmRespaldo.ShowDialog()
    End Sub

    Private Sub tssCaja_Click(sender As Object, e As EventArgs) Handles tssCaja.Click
        Dim frmCaja As New frmCaja
        frmCaja.ShowDialog()
    End Sub

    Private Sub tssBusquedaComprobante_Click(sender As Object, e As EventArgs) Handles tssBusquedaComprobante.Click
        Dim frmBuscarComprobante As New frmBuscarVentas("ABRIRVENTA")
        frmBuscarComprobante.ShowDialog()
    End Sub
End Class
