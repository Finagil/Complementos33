Imports System.Xml
Public Class Form1
    Dim Spei As String = ""
    Dim SpeiCert As String = ""
    Dim SpeiCadOrg As String = ""
    Dim SpeiSello As String = ""
    Dim totalPago As Double = 0
    Private Sub CFDI_EncabezadoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CFDI_EncabezadoBindingSource.EndEdit()
        Me.CFDI_EncabezadoTableAdapter.Update(Me.Production_AUXDataSet.CFDI_Encabezado)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CFDI_BancosTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_Bancos)
        DateTimePicker1.MaxDate = Date.Now
        DateTimePicker1.MinDate = Date.Now.AddDays((Date.Now.Day - 1) * -1).AddMonths(-1)

        dtpFechaEmision.MaxDate = Date.Now
        dtpFechaEmision.MinDate = Date.Now.AddDays(-3)

        Dim vFolio As Integer
        Dim vSerie As String
        Dim vDocumento As String


        Me.BancosTableAdapter.Fill(Me.Production_AUXDataSet.Bancos)
        Me.InstrumentoMonetarioTableAdapter.Fill(Me.Production_AUXDataSet.InstrumentoMonetario)
        'Me.CFDI_ComplementoPagoTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_ComplementoPago)
        Me.Vw_CFDI_FacturasConSaldoTableAdapter.Fill(Me.Production_AUXDataSet.Vw_CFDI_FacturasConSaldo)
        Me.Vw_CFDI_SadosFacturaTableAdapter.FillVSaldo(Me.Production_AUXDataSet.Vw_CFDI_SadosFactura)

        'Me.CFDI_EncabezadoTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_Encabezado)

        If rbFinagil.Checked = True Then
            ToolStripLabel1.Text = "REP - " + CFDI_EncabezadoTableAdapter.SacaFolio.ToString
            txtMails.Text = "lgarcia@finagil.com.mx;elizabeth.romero@finagil.com.mx"
        Else
            ToolStripLabel1.Text = "REPA" + CFDI_EncabezadoTableAdapter.SacaFolioArfin.ToString
            txtMails.Text = "lgarcia@finagil.com.mx;lhernandez@finagil.com.mx;facelec@lamoderna.com.mx"
        End If
        limpiar_1()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim vFecha As String
        'vFecha = DateTimePicker1.Value

        Dim vAnio As String = DateTimePicker1.MinDate.Year
        Dim vMes As String = DateTimePicker1.MinDate.Month
        Dim vDia As String = DateTimePicker1.MinDate.Day
        Dim vfecha As String = vAnio.Trim + "/" + vMes.Trim + "/" + vDia.Trim + " T12:00:00"

        Dim vFolio As Integer
        Dim vSerie As String
        'Dim Spei As String = ""
        'Dim SpeiCert As String = ""
        'Dim SpeiCadOrg As String = ""
        'Dim SpeiSello As String = ""
        Dim vNumeroPago As String = ""

        '  ENCABEZADO
        Dim ROWheader As Production_AUXDataSet.CFDI_EncabezadoRow
        ROWheader = Production_AUXDataSet.CFDI_Encabezado.NewCFDI_EncabezadoRow()

        If rbFinagil.Checked = True Then
            ROWheader._1_Folio = CFDI_EncabezadoTableAdapter.SacaFolio()
            ROWheader._2_Nombre_Emisor = "FINAGIL S.A. DE C.V, SOFOM E.N.R"
            ROWheader._3_RFC_Emisor = "FIN940905AX7"
            ROWheader._4_Dom_Emisor_calle = "Leandro Valle"
            ROWheader._5_Dom_Emisor_noExterior = "402"
            ROWheader._6_Dom_Emisor_noInterior = ""
            ROWheader._7_Dom_Emisor_colonia = "Reforma y F.F.C.C"
            ROWheader._8_Dom_Emisor_localidad = "Toluca"
            ROWheader._9_Dom_Emisor_referencia = ""
            ROWheader._10_Dom_Emisor_municipio = "Toluca"
            ROWheader._11_Dom_Emisor_estado = "Estado de México"
            ROWheader._12_Dom_Emisor_pais = "México"
            ROWheader._13_Dom_Emisor_codigoPostal = "50070"

            ROWheader._26_Version = "3.3"
            ROWheader._27_Serie_Comprobante = "REP" ' "MDM"
            ROWheader._29_FormaPago = "" 'FormaPago '"27" '27 A satisfacción del acreedor
            ROWheader._30_Fecha = dtpFechaEmision.Value.Date.ToString("dd/MM/yyyy")
            ROWheader._31_Hora = dtpFechaEmision.Value.ToString("hh:mm:ss")
            ROWheader._41_Dom_LugarExpide_codigoPostal = "50070"

            ROWheader._42_Nombre_Receptor = TextBox2.Text ' CFDI_EncabezadoBindingSource.Current("_42_Nombre_Receptor")
            ROWheader._43_RFC_Receptor = Vw_CFDI_FacturasConSaldoBindingSource.Current("43_RFC_Receptor")

            ROWheader._54_Monto_SubTotal = 0
            ROWheader._55_Monto_IVA = 0
            ROWheader._56_Monto_Total = 0
            ROWheader._57_Estado = "1"
            ROWheader._58_TipoCFD = "FA"
            ROWheader._83_Cod_Moneda = "XXX"
            ROWheader._97_Condiciones_Pago = ""
            ROWheader._100_Letras_Monto_Total = ""
            ROWheader._113_Misc01 = "[CPG_FINAGIL]"
            ROWheader._114_Misc02 = ""
            ROWheader._132_Misc20 = "[CPG]"
            ROWheader._144_Misc32 = "P01"
            ROWheader._157_Misc45 = ""
            ROWheader._158_Misc46 = ""
            ROWheader._159_Misc47 = ""
            ROWheader._162_Misc50 = txtMails.Text.Trim
            ROWheader._167_RegimentFiscal = "601"
            ROWheader._180_LugarExpedicion = "50070"
            ROWheader._190_Metodo_Pago = ""
            ROWheader._191_Efecto_Comprobante = "P"
            ROWheader._192_Monto_TotalImp_Retenidos = 0
            ROWheader._193_Monto_TotalImp_Trasladados = 0
            ROWheader.Encabezado_Procesado = False
            Me.CFDI_EncabezadoTableAdapter.ConsumeFolio()
        Else
            ROWheader._1_Folio = CFDI_EncabezadoTableAdapter.SacaFolioArfin()
            ROWheader._2_Nombre_Emisor = "SERVICIOS ARFIN S.A. DE C.V."
            ROWheader._3_RFC_Emisor = "SAR951230N5A"
            ROWheader._4_Dom_Emisor_calle = "Leandro Valle"
            ROWheader._5_Dom_Emisor_noExterior = "402"
            ROWheader._6_Dom_Emisor_noInterior = ""
            ROWheader._7_Dom_Emisor_colonia = "Reforma y F.F.C.C"
            ROWheader._8_Dom_Emisor_localidad = "Toluca"
            ROWheader._9_Dom_Emisor_referencia = ""
            ROWheader._10_Dom_Emisor_municipio = "Toluca"
            ROWheader._11_Dom_Emisor_estado = "Estado de México"
            ROWheader._12_Dom_Emisor_pais = "México"
            ROWheader._13_Dom_Emisor_codigoPostal = "50070"

            ROWheader._26_Version = "3.3"
            ROWheader._27_Serie_Comprobante = "REPA" ' "MDM"
            ROWheader._29_FormaPago = "" 'FormaPago '"27" '27 A satisfacción del acreedor
            ROWheader._30_Fecha = dtpFechaEmision.Value.Date.ToString("dd/MM/yyyy")
            ROWheader._31_Hora = dtpFechaEmision.Value.ToString("hh:mm:ss")
            ROWheader._41_Dom_LugarExpide_codigoPostal = "50070"

            ROWheader._42_Nombre_Receptor = TextBox2.Text ' CFDI_EncabezadoBindingSource.Current("_42_Nombre_Receptor")
            ROWheader._43_RFC_Receptor = Vw_CFDI_FacturasConSaldoBindingSource.Current("43_RFC_Receptor")

            ROWheader._54_Monto_SubTotal = 0
            ROWheader._55_Monto_IVA = 0
            ROWheader._56_Monto_Total = 0
            ROWheader._57_Estado = "1"
            ROWheader._58_TipoCFD = "FA"
            ROWheader._83_Cod_Moneda = "XXX"
            ROWheader._97_Condiciones_Pago = ""
            ROWheader._100_Letras_Monto_Total = ""
            ROWheader._113_Misc01 = "[CPG_ARFIN]"
            ROWheader._114_Misc02 = ""
            ROWheader._132_Misc20 = "[CPG]"
            ROWheader._144_Misc32 = "P01"
            ROWheader._157_Misc45 = ""
            ROWheader._158_Misc46 = ""
            ROWheader._159_Misc47 = ""
            ROWheader._162_Misc50 = txtMails.Text.Trim
            ROWheader._167_RegimentFiscal = "601"
            ROWheader._180_LugarExpedicion = "50070"
            ROWheader._190_Metodo_Pago = ""
            ROWheader._191_Efecto_Comprobante = "P"
            ROWheader._192_Monto_TotalImp_Retenidos = 0
            ROWheader._193_Monto_TotalImp_Trasladados = 0
            ROWheader.Encabezado_Procesado = False
            Me.CFDI_EncabezadoTableAdapter.ConsumeFolioAr()
        End If

        Me.Production_AUXDataSet.CFDI_Encabezado.Rows.Add(ROWheader)
        Me.CFDI_EncabezadoTableAdapter.Update(Me.Production_AUXDataSet.CFDI_Encabezado)


        '  DETALLE
        Dim ROWdetail As Production_AUXDataSet.CFDI_DetalleRow
        ROWdetail = Production_AUXDataSet.CFDI_Detalle.NewCFDI_DetalleRow()

        ROWdetail._1_Linea_Descripcion = "Pago"
        ROWdetail._2_Linea_Cantidad = 1
        ROWdetail._3_Linea_Unidad = "ACT"
        ROWdetail._4_Linea_PrecioUnitario = 0
        ROWdetail._5_Linea_Importe = 0
        ROWdetail._16_Linea_Cod_Articulo = "84111506" 'Codigo ' Manejo de deuda

        ROWdetail.Detalle_Folio = ROWheader._1_Folio
        ROWdetail.Detalle_Serie = ROWheader._27_Serie_Comprobante

        Me.Production_AUXDataSet.CFDI_Detalle.Rows.Add(ROWdetail)
        Me.CFDI_DetalleTableAdapter.Update(Me.Production_AUXDataSet.CFDI_Detalle)

        '  COMPLEMENTO DE PAGO Registro 1
        Dim ROWcomplemento As Production_AUXDataSet.CFDI_ComplementoPagoRow
        ROWcomplemento = Production_AUXDataSet.CFDI_ComplementoPago.NewCFDI_ComplementoPagoRow()

        ROWcomplemento._1_DetalleAux_Tipo = "CPG"
        ROWcomplemento._2_DetalleAux_DescTipo = "Pagos"
        ROWcomplemento._3_DetalleAux_Misc01 = "HD"
        ROWcomplemento._4_DetalleAux_Misc02 = "1.0"
        ROWcomplemento._5_DetalleAux_Misc03 = DateTimePicker1.Value.Date.ToString("yyyy/MM/dd") + "T12:00:00" 'vfecha  ' DateTimePicker1.MinDate  '  Fecha en Formato  AAMMDD
        ROWcomplemento._6_DetalleAux_Misc04 = CmbFormaPago.SelectedValue
        ROWcomplemento._7_DetalleAux_Misc05 = cbMoneda.Text
        ROWcomplemento._8_DetalleAux_Misc06 = ""
        ROWcomplemento._9_DetalleAux_Misc07 = totalPago
        ROWcomplemento._10_DetalleAux_Misc08 = txbrpago.Text ' Referencia de Pago
        If TextBox7.Text = "03" And cbDatosBancarios.Checked = True Then
            ROWcomplemento._11_DetalleAux_Misc09 = txbRfcCtaOrdenante.Text '  RFC Cta Ordenante
            ROWcomplemento._12_DetalleAux_Misc10 = ComboBox3.Text  ' Nombre Banco Ordenante
        Else
            ROWcomplemento._11_DetalleAux_Misc09 = ""   '  RFC Cta Ordenante
            ROWcomplemento._12_DetalleAux_Misc10 = ""   ' Nombre Banco Ordenante
        End If

        ROWcomplemento._13_DetalleAux_Misc11 = " "      '  Este campo NO debe ir Vacio
        ROWcomplemento._18_DetalleAux_Misc16 = ""
        ROWcomplemento._19_DetalleAux_Folio = ROWheader._1_Folio
        ROWcomplemento._20_DetalleAux_Serie = ROWheader._27_Serie_Comprobante

        Me.Production_AUXDataSet.CFDI_ComplementoPago.Rows.Add(ROWcomplemento)
        Me.CFDI_ComplementoPagoTableAdapter.Update(Me.Production_AUXDataSet.CFDI_ComplementoPago)

        '  COMPLEMENTO DE PAGO  Registro 2
        ROWcomplemento = Production_AUXDataSet.CFDI_ComplementoPago.NewCFDI_ComplementoPagoRow()

        ROWcomplemento._1_DetalleAux_Tipo = "CPG"
        ROWcomplemento._2_DetalleAux_DescTipo = "Pago"
        ROWcomplemento._3_DetalleAux_Misc01 = "HD"
        If cbDatosBancarios.Checked = True Then
            ROWcomplemento._4_DetalleAux_Misc02 = txbCtaOrdenante.Text.Trim
            ROWcomplemento._5_DetalleAux_Misc03 = lblRfcCtaBeneficiario.Text.Trim 'txbCtaOrdenante.Text
            ROWcomplemento._6_DetalleAux_Misc04 = lblCtaBeneficiario.Text.Trim 'lblRfcCtaBeneficiario.Text
        Else
            ROWcomplemento._4_DetalleAux_Misc02 = ""
            ROWcomplemento._5_DetalleAux_Misc03 = ""
            ROWcomplemento._6_DetalleAux_Misc04 = ""
        End If
        ROWcomplemento._7_DetalleAux_Misc05 = Spei
        ROWcomplemento._8_DetalleAux_Misc06 = SpeiCert
        ROWcomplemento._9_DetalleAux_Misc07 = SpeiCadOrg
        ROWcomplemento._10_DetalleAux_Misc08 = SpeiSello
        ROWcomplemento._11_DetalleAux_Misc09 = ""
        ROWcomplemento._12_DetalleAux_Misc10 = ""
        ROWcomplemento._13_DetalleAux_Misc11 = "" '"0.0"       '  Este campo NO debe ir Vacio

        ROWcomplemento._18_DetalleAux_Misc16 = "" '  Este campo NO debe ir Vacio
        ROWcomplemento._19_DetalleAux_Folio = ROWheader._1_Folio
        ROWcomplemento._20_DetalleAux_Serie = ROWheader._27_Serie_Comprobante

        Me.Production_AUXDataSet.CFDI_ComplementoPago.Rows.Add(ROWcomplemento)
        Me.CFDI_ComplementoPagoTableAdapter.Update(Me.Production_AUXDataSet.CFDI_ComplementoPago)

        For Each row As DataGridViewRow In dgDoctosPagos.Rows
            '  COMPLEMENTO DE PAGO  Registro 3
            Dim cont As Integer = row.Index
            ROWcomplemento = Production_AUXDataSet.CFDI_ComplementoPago.NewCFDI_ComplementoPagoRow()

            ROWcomplemento._1_DetalleAux_Tipo = "CPG"
            ROWcomplemento._2_DetalleAux_DescTipo = "DoctoRelacionado"
            ROWcomplemento._3_DetalleAux_Misc01 = "HD"
            ROWcomplemento._4_DetalleAux_Misc02 = Me.dgDoctosPagos.Item("dgUUID", cont).Value 'txbIdDocumento.Text
            ROWcomplemento._5_DetalleAux_Misc03 = Me.dgDoctosPagos.Item("dgSerie", cont).Value
            ROWcomplemento._6_DetalleAux_Misc04 = Me.dgDoctosPagos.Item("dgFolio", cont).Value
            ROWcomplemento._7_DetalleAux_Misc05 = Me.dgDoctosPagos.Item("dgMoneda", cont).Value
            ROWcomplemento._8_DetalleAux_Misc06 = Me.dgDoctosPagos.Item("dgTCambio", cont).Value
            ROWcomplemento._9_DetalleAux_Misc07 = Me.dgDoctosPagos.Item("dgMPago", cont).Value

            ROWcomplemento._10_DetalleAux_Misc08 = Me.dgDoctosPagos.Item("dgParcialidad", cont).Value

            ROWcomplemento._11_DetalleAux_Misc09 = Me.dgDoctosPagos.Item("dgSaldo", cont).Value
            ROWcomplemento._12_DetalleAux_Misc10 = Me.dgDoctosPagos.Item("dgImpPago", cont).Value
            ROWcomplemento._13_DetalleAux_Misc11 = Me.dgDoctosPagos.Item("dgSaldoInsoluto", cont).Value
            ROWcomplemento._18_DetalleAux_Misc16 = ""   ' la tabla NO Acepta Capo Null
            ROWcomplemento._19_DetalleAux_Folio = ROWheader._1_Folio
            ROWcomplemento._20_DetalleAux_Serie = ROWheader._27_Serie_Comprobante

            Me.Production_AUXDataSet.CFDI_ComplementoPago.Rows.Add(ROWcomplemento)
            Me.CFDI_ComplementoPagoTableAdapter.Update(Me.Production_AUXDataSet.CFDI_ComplementoPago)
            Me.Vw_CFDI_SadosFacturaTableAdapter.FillVSaldo(Me.Production_AUXDataSet.Vw_CFDI_SadosFactura)
        Next

        ' COMPLEMENTO DE PAGO Registro de sustitución
        If lblUUIDSust.Text.Trim.Length > 0 And lblUUIDSust.Text.Trim <> "NE" Then
            ROWcomplemento = Production_AUXDataSet.CFDI_ComplementoPago.NewCFDI_ComplementoPagoRow()
            ROWcomplemento._1_DetalleAux_Tipo = "DR"
            ROWcomplemento._2_DetalleAux_DescTipo = "TipoRelacion"
            ROWcomplemento._3_DetalleAux_Misc01 = "04"
            ROWcomplemento._4_DetalleAux_Misc02 = lblUUIDSust.Text.Trim
            ROWcomplemento._5_DetalleAux_Misc03 = "" 'DateTimePicker1.Value.Date.ToString("yyyy/MM/dd") + "T12:00:00" 'vfecha  ' DateTimePicker1.MinDate  '  Fecha en Formato  AAMMDD
            ROWcomplemento._6_DetalleAux_Misc04 = "" 'CmbFormaPago.SelectedValue
            ROWcomplemento._7_DetalleAux_Misc05 = "" 'cbMoneda.Text
            ROWcomplemento._8_DetalleAux_Misc06 = ""
            ROWcomplemento._9_DetalleAux_Misc07 = "" 'totalPago
            ROWcomplemento._10_DetalleAux_Misc08 = "" 'txbrpago.Text ' Referencia de Pago
            ROWcomplemento._11_DetalleAux_Misc09 = "" 'txbRfcCtaOrdenante.Text '  RFC Cta Ordenante
            ROWcomplemento._12_DetalleAux_Misc10 = "" 'ComboBox3.Text  ' Nombre Banco Ordenante

            ROWcomplemento._13_DetalleAux_Misc11 = " "      '  Este campo NO debe ir Vacio
            ROWcomplemento._18_DetalleAux_Misc16 = ""
            ROWcomplemento._19_DetalleAux_Folio = ROWheader._1_Folio
            ROWcomplemento._20_DetalleAux_Serie = ROWheader._27_Serie_Comprobante

            Me.Production_AUXDataSet.CFDI_ComplementoPago.Rows.Add(ROWcomplemento)
            Me.CFDI_ComplementoPagoTableAdapter.Update(Me.Production_AUXDataSet.CFDI_ComplementoPago)
        ElseIf txtFolioSust.Text <> "" And lblUUIDSust.Text.Trim = "NE" Then
            MsgBox("Está intenatdo generar un CFDI con complemento de pago sustituyendo un comprobante previo sin folio fiscal, favor de verificar que la información sea correcta")
            limpiar_1()
            Exit Sub
        End If

        '*****************

        MsgBox("Se guardaron Datos de Factura en BD")
        dgDoctosPagos.Rows.Clear()
        Me.Vw_CFDI_FacturasConSaldoTableAdapter.Fill(Me.Production_AUXDataSet.Vw_CFDI_FacturasConSaldo)
        totalPago = 0

        limpiar_1()
        If rbFinagil.Checked = True Then
            ToolStripLabel1.Text = "REP - " + CFDI_EncabezadoTableAdapter.SacaFolio.ToString
            txtMails.Text = "lgarcia@finagil.com.mx;elizabeth.romero@finagil.com.mx"
        Else
            ToolStripLabel1.Text = "REPA" + CFDI_EncabezadoTableAdapter.SacaFolioArfin.ToString
            txtMails.Text = "lgarcia@finagil.com.mx;lhernandez@finagil.com.mx"
        End If

        '*********************
        'Me.CFDI_DetalleTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_Detalle)
        Me.InstrumentoMonetarioTableAdapter.Fill(Me.Production_AUXDataSet.InstrumentoMonetario)
        'Me.CFDI_ComplementoPagoTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_ComplementoPago)
        'Me.Vw_CFDI_FacturasConSaldoTableAdapter.Fill(Me.Production_AUXDataSet.Vw_CFDI_FacturasConSaldo)
        Me.CFDI_BancosTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_Bancos)
        'Me.BancosTableAdapter.Fill(Me.Production_AUXDataSet.Bancos)
        'Me.Vw_CFDI_SadosFacturaTableAdapter.FillVSaldo(Me.Production_AUXDataSet.Vw_CFDI_SadosFactura)
        'Me.CFDI_EncabezadoTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_Encabezado)
        'Me.Vw_CFDI_SadosFacturaTableAdapter.FillVSaldo(Me.Production_AUXDataSet.Vw_CFDI_SadosFactura)
        'Me.CFDI_BancosTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_Bancos)
        'Me.CFDI_ControlTimbresTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_ControlTimbres)
        DateTimePicker1.MaxDate = Date.Now
        DateTimePicker1.MinDate = Date.Now.AddDays((Date.Now.Day - 1) * -1).AddMonths(-1)

        dtpFechaEmision.MaxDate = Date.Now
        dtpFechaEmision.MinDate = Date.Now.AddDays(-3)


        Me.BancosTableAdapter.Fill(Me.Production_AUXDataSet.Bancos)
        Me.InstrumentoMonetarioTableAdapter.Fill(Me.Production_AUXDataSet.InstrumentoMonetario)
        'Me.CFDI_ComplementoPagoTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_ComplementoPago)
        Me.Vw_CFDI_FacturasConSaldoTableAdapter.Fill(Me.Production_AUXDataSet.Vw_CFDI_FacturasConSaldo)
        Me.Vw_CFDI_SadosFacturaTableAdapter.FillVSaldo(Me.Production_AUXDataSet.Vw_CFDI_SadosFactura)
        'Me.CFDI_ComplementoPagoTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_ComplementoPago)
        'Me.Vw_CFDI_SadosFacturaTableAdapter.FillVSaldo(Me.Production_AUXDataSet.Vw_CFDI_SadosFactura)
        'Me.CFDI_EncabezadoTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_Encabezado)


    End Sub



    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "03" Then
            Label10.Visible = True
            Label11.Visible = True
            lblCtaBeneficiario.Visible = True
            ComboBox2.Visible = True
            Label13.Visible = True
            lblRfcCtaBeneficiario.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label15.Visible = True
            txbCtaOrdenante.Visible = True
            txbRfcCtaOrdenante.Visible = True
        Else
            Label10.Visible = False
            Label11.Visible = False
            lblCtaBeneficiario.Visible = False
            lblCtaBeneficiario.Text = ""
            ComboBox2.Visible = False
            Label13.Visible = False
            lblRfcCtaBeneficiario.Visible = False
            lblRfcCtaBeneficiario.Text = ""
            Label1.Visible = False
            Label2.Visible = False
            Label15.Visible = False
            txbCtaOrdenante.Visible = False
            txbRfcCtaOrdenante.Visible = False
        End If
    End Sub


    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        NumerosyDecimal(sender, e)
    End Sub


    Private Sub txbMoneda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim vAnio As String = DateTimePicker1.MinDate.Year
        Dim vMes As String = DateTimePicker1.MinDate.Month
        Dim vDia As String = DateTimePicker1.MinDate.Day
        Dim vfechatc As String = vDia + "/" + vMes + "/" + vAnio

        Dim vTipoCambio As String
        Dim vMoneda As String
        vMoneda = cbMoneda.ValueMember
        vTipoCambio = CFDI_EncabezadoTableAdapter.SacaTipoCamnbio(vfechatc, vMoneda)
    End Sub

    Sub Filtros()

        If TxtSeriefil.Text.Length > 0 Then
            If Txtfoliofil.Text.Length > 0 Then
                Vw_CFDI_FacturasConSaldoBindingSource.Filter = "[27_Serie_Comprobante] like '" & TxtSeriefil.Text & "%' and [1_Folio] = " & Txtfoliofil.Text
            Else
                Vw_CFDI_FacturasConSaldoBindingSource.Filter = "[27_Serie_Comprobante] like '" & TxtSeriefil.Text & "%'"
            End If
        Else
            If Txtfoliofil.Text.Length > 0 Then
                Vw_CFDI_FacturasConSaldoBindingSource.Filter = "[27_Serie_Comprobante] = '" & TxtSeriefil.Text & "'"
            Else
                Vw_CFDI_FacturasConSaldoBindingSource.Filter = ""
            End If
        End If
        If Vw_CFDI_FacturasConSaldoBindingSource.Count = 0 Then
            MsgBox("La factura no existe...", MsgBoxStyle.Exclamation)
            limpiar_1()
            Me.txtPago.Enabled = False
            Me.TxtSeriefil.Focus()
        Else
            Me.txtPago.Enabled = True
        End If
        'Vw_CFDI_FacturasConSaldoBindingSource.RemoveFilter()

    End Sub

    Private Sub Txtfoliofil_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtfoliofil.KeyDown
        If e.KeyCode = Keys.Enter Then
            If rbArfin.Checked = True Then
                If TxtSeriefil.Text.ToUpper = "SA" Or TxtSeriefil.Text.ToUpper = "SAA" Or TxtSeriefil.Text.ToUpper = "S" Then
                    Filtros()
                    Me.txtPago.Focus()
                Else
                    MsgBox("La serie " + TxtSeriefil.Text.ToUpper + " no corresponde a la razón social de Servicios Arfin", MsgBoxStyle.Information)
                    limpiar_1()
                    Me.txtPago.Enabled = False
                    Me.TxtSeriefil.Focus()
                End If
            End If

            If rbFinagil.Checked = True Then
                If TxtSeriefil.Text.ToUpper = "B" Or TxtSeriefil.Text.ToUpper = "DV" Or TxtSeriefil.Text.ToUpper = "C" Then
                    Filtros()
                    Me.txtPago.Focus()
                Else
                    MsgBox("La serie " + TxtSeriefil.Text.ToUpper + " no corresponde a la razón social de Finagil", MsgBoxStyle.Information)
                    limpiar_1()
                    Me.txtPago.Enabled = False
                    Me.TxtSeriefil.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtPago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPago.KeyDown
        If e.KeyCode = Keys.Enter Then

            If ((txtPago.Text <> "") And (Val(txtPago.Text) <= Val(SaldoFacturaTextBox.Text))) Then
                dgDoctosPagos.Rows.Add(FolioFiscalTextBox.Text, _27_Serie_ComprobanteTextBox.Text, _1_FolioTextBox.Text, _83_Cod_MonedaTextBox.Text, "", "PPD", CFDI_ComplementoPagoTableAdapter.SacarNoPago(FolioFiscalTextBox.Text), Vw_CFDI_FacturasConSaldoBindingSource.Current("SaldoFactura"), txtPago.Text, CDec(SaldoFacturaTextBox.Text) - CDec(txtPago.Text), "Eliminar")
                limpiar_1()
                Me.TxtSeriefil.Focus()
                Me.txtPago.Enabled = False
            Else
                MsgBox("Cantidad debe ser Mayor a Cero y Menor o Igual al Saldo, NO SE REGISTRO EL PAGO")
            End If
        End If
    End Sub

    Sub limpiar_1()
        Me._27_Serie_ComprobanteTextBox.Text = ""
        Me._1_FolioTextBox.Text = ""
        Me._83_Cod_MonedaTextBox.Text = ""
        Me.SaldoFacturaTextBox.Text = ""
        Me.txtPago.Text = ""
        Me.TxtSeriefil.Text = ""
        Me.Txtfoliofil.Text = ""
        Me.NoPagosTextBox.Text = ""
        'Me.TextBox2.Text = ""
        Me.FolioFiscalTextBox.Text = ""
        Spei = ""
        SpeiCert = ""
        SpeiCadOrg = ""
        SpeiSello = ""

    End Sub

    Private Sub dgDoctosPagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDoctosPagos.CellContentClick
        If e.ColumnIndex = 10 Then
            Me.dgDoctosPagos.Rows.RemoveAt(e.RowIndex)
            Me.TxtSeriefil.Focus()
            Spei = "01"
            SpeiCert = txtSPEICert.Text
            SpeiCadOrg = txtSPEICad.Text
            SpeiSello = txtSPEISello.Text
        End If

    End Sub

    Private Sub dgDoctosPagos_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgDoctosPagos.RowStateChanged
        totalPago = 0
        For Each row As DataGridViewRow In Me.dgDoctosPagos.Rows
            totalPago += Val(row.Cells(8).Value)
            lbTotal.Text = totalPago.ToString
        Next
        If dgDoctosPagos.Rows.Count > 0 Then
            cbMoneda.Text = Me.dgDoctosPagos.Item("dgMoneda", 0).Value 'row.Cells(3).Value
        End If
    End Sub

    Private Sub rbFinagil_CheckedChanged(sender As Object, e As EventArgs) Handles rbFinagil.CheckedChanged
        btnLoadXML.Enabled = False
        dgDoctosPagos.Rows.Clear()
        'ToolStripLabel1.Text = "REP - " + CFDI_EncabezadoTableAdapter.SacaFolio
    End Sub

    Private Sub rbArfin_CheckedChanged(sender As Object, e As EventArgs) Handles rbArfin.CheckedChanged
        btnLoadXML.Enabled = True
        dgDoctosPagos.Rows.Clear()
        'ToolStripLabel1.Text = "REP - " + CFDI_EncabezadoTableAdapter.SacaFolioArfin
    End Sub

    Private Sub btnLoadXML_Click(sender As Object, e As EventArgs) Handles btnLoadXML.Click
        If fdBwCargaXML.ShowDialog = DialogResult.OK Then
            load_XML(fdBwCargaXML.SelectedPath)

            Me.Vw_CFDI_FacturasConSaldoTableAdapter.Fill(Me.Production_AUXDataSet.Vw_CFDI_FacturasConSaldo)
            limpiar_1()
        End If
    End Sub

    Public Sub load_XML(directorio As String)

        For Each archivo As String In My.Computer.FileSystem.GetFiles(directorio, FileIO.SearchOption.SearchTopLevelOnly, "*.xml")
            Dim ROWheader_XML As Production_AUXDataSet.CFDI_EncabezadoRow
            ROWheader_XML = Production_AUXDataSet.CFDI_Encabezado.NewCFDI_EncabezadoRow()
            Dim doc As XmlDataDocument
            doc = New XmlDataDocument
            doc.Load(archivo)
            Dim node1 As XmlNode

            node1 = doc.DocumentElement

            For Each node2 As XmlNode In node1.Attributes
                Select Case node2.Name
                    Case "Serie"
                        ROWheader_XML._27_Serie_Comprobante = node2.Value.ToString
                    Case "serie"
                        ROWheader_XML._27_Serie_Comprobante = node2.Value.ToString
                    Case "Folio"
                        ROWheader_XML._1_Folio = node2.Value.ToString
                    Case "folio"
                        ROWheader_XML._1_Folio = node2.Value.ToString
                    Case "Moneda"
                        ROWheader_XML._83_Cod_Moneda = node2.Value.ToString
                    Case "TipoCambio"
                        ROWheader_XML._177_Tasa_Divisa = node2.Value.ToString
                    Case "MetodoPago"
                        ROWheader_XML._190_Metodo_Pago = node2.Value.ToString
                    Case "metodoDePago"
                        ROWheader_XML._190_Metodo_Pago = node2.Value.ToString
                    Case "Fecha"
                        ROWheader_XML._30_Fecha = Convert.ToDateTime(node2.Value).ToString("dd/MM/yyyy")
                        ROWheader_XML._31_Hora = Convert.ToDateTime(node2.Value).ToString("hh:mm:ss")
                    Case "fecha"
                        ROWheader_XML._30_Fecha = Convert.ToDateTime(node2.Value).ToString("dd/MM/yyyy")
                        ROWheader_XML._31_Hora = Convert.ToDateTime(node2.Value).ToString("hh:mm:ss")
                    Case "Total"
                        ROWheader_XML._56_Monto_Total = CDbl(node2.Value)
                    Case "total"
                        ROWheader_XML._56_Monto_Total = CDbl(node2.Value)
                End Select
            Next

            For Each emisor As XmlNode In node1.ChildNodes
                If emisor.Name = "cfdi:Emisor" Then
                    For Each emisor_a As XmlNode In emisor.Attributes
                        Select Case emisor_a.Name
                            Case "Rfc"
                                ROWheader_XML._3_RFC_Emisor = emisor_a.Value.ToString
                            Case "Nombre"
                                ROWheader_XML._2_Nombre_Emisor = emisor_a.Value.ToString
                            Case "rfc"
                                ROWheader_XML._3_RFC_Emisor = emisor_a.Value.ToString
                            Case "nombre"
                                ROWheader_XML._2_Nombre_Emisor = emisor_a.Value.ToString
                            Case "RegimenFiscal"
                                ROWheader_XML._167_RegimentFiscal = emisor_a.Value.ToString
                        End Select
                    Next
                End If
            Next

            For Each receptor As XmlNode In node1.ChildNodes
                If receptor.Name = "cfdi:Receptor" Then
                    For Each receptor_a As XmlNode In receptor.Attributes
                        Select Case receptor_a.Name
                            Case "Rfc"
                                ROWheader_XML._43_RFC_Receptor = receptor_a.Value.ToString
                            Case "Nombre"
                                ROWheader_XML._42_Nombre_Receptor = receptor_a.Value.ToString
                            Case "rfc"
                                ROWheader_XML._43_RFC_Receptor = receptor_a.Value.ToString
                            Case "nombre"
                                ROWheader_XML._42_Nombre_Receptor = receptor_a.Value.ToString
                            Case "UsoCFDI"
                                ROWheader_XML._144_Misc32 = receptor_a.Value.ToString
                        End Select
                    Next
                End If
            Next

            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
            nsmgr.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            Dim nodeList As XmlNodeList
            Dim root As XmlElement = doc.DocumentElement

            nodeList = root.SelectNodes("//tfd:TimbreFiscalDigital/@UUID", nsmgr)
            Dim uuid As XmlNode
            For Each uuid In nodeList
                ROWheader_XML.Guid = uuid.Value.ToString
            Next

            ROWheader_XML._26_Version = "3.3"
            ROWheader_XML._57_Estado = "1"
            ROWheader_XML._58_TipoCFD = "FA"
            ROWheader_XML._191_Efecto_Comprobante = "I"
            ROWheader_XML.Encabezado_Procesado = True
            ROWheader_XML._29_FormaPago = "03"
            ROWheader_XML._190_Metodo_Pago = "PUE"

            'Agrega detalle de factura externa
            Dim ROWdetail_XML As Production_AUXDataSet.CFDI_DetalleRow
            ROWdetail_XML = Production_AUXDataSet.CFDI_Detalle.NewCFDI_DetalleRow()

            ROWdetail_XML._1_Linea_Descripcion = "detalle generico para facturas no emitidas en facturador externo"
            ROWdetail_XML._2_Linea_Cantidad = 1
            ROWdetail_XML._3_Linea_Unidad = "ACT"
            ROWdetail_XML._4_Linea_PrecioUnitario = 0
            ROWdetail_XML._5_Linea_Importe = 0
            ROWdetail_XML._16_Linea_Cod_Articulo = "01010101"
            ROWdetail_XML.Detalle_Folio = ROWheader_XML._1_Folio
            ROWdetail_XML.Detalle_Serie = ROWheader_XML._27_Serie_Comprobante
            Try
                If ROWheader_XML._27_Serie_Comprobante <> "S" And ROWheader_XML._3_RFC_Emisor <> "SAR951230N5A" Then
                    Me.Production_AUXDataSet.CFDI_Encabezado.Rows.Add(ROWheader_XML)
                    Me.CFDI_EncabezadoTableAdapter.Update(Me.Production_AUXDataSet.CFDI_Encabezado)

                    Me.Production_AUXDataSet.CFDI_Detalle.Rows.Add(ROWdetail_XML)
                    Me.CFDI_DetalleTableAdapter.Update(Me.Production_AUXDataSet.CFDI_Detalle)
                Else
                    MsgBox("RFC y Serie no permitidas", MsgBoxStyle.Exclamation)
                End If
                MsgBox("Proceso terminado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
            End Try

        Next
    End Sub

    Private Sub chkSPEI_CheckedChanged(sender As Object, e As EventArgs) Handles chkSPEI.CheckedChanged
        If chkSPEI.Checked = True Then
            gbxSPEI.Visible = True

        Else
            gbxSPEI.Visible = False
        End If
    End Sub

    Private Sub btnOcultarSPEI_Click(sender As Object, e As EventArgs) Handles btnOcultarSPEI.Click
        gbxSPEI.Visible = False
    End Sub

    Private Sub rbArfin_Click(sender As Object, e As EventArgs) Handles rbArfin.Click
        ToolStripLabel1.Text = "REPA - " + CFDI_EncabezadoTableAdapter.SacaFolioArfin.ToString
        txtMails.Text = "lgarcia@finagil.com.mx;lhernandez@finagil.com.mx"
    End Sub

    Private Sub rbFinagil_Click(sender As Object, e As EventArgs) Handles rbFinagil.Click
        ToolStripLabel1.Text = "REP - " + CFDI_EncabezadoTableAdapter.SacaFolio.ToString
        txtMails.Text = "lgarcia@finagil.com.mx;elizabeth.romero@finagil.com.mx"
    End Sub

    Private Sub cbDatosBancarios_CheckedChanged(sender As Object, e As EventArgs) Handles cbDatosBancarios.CheckedChanged
        If cbDatosBancarios.Checked = False Then
            ocultarDatosBancarios()
            ComboBox3.SelectedIndex = -1
        Else
            ComboBox3.DataSource = Production_AUXDataSet.Tables("CFDI_Bancos")
            ComboBox3.DisplayMember = "Nombre"
            ComboBox3.Enabled = True
            ComboBox2.Enabled = True
        End If
    End Sub

    Private Sub ocultarDatosBancarios()
        ComboBox3.Enabled = False
        txbRfcCtaOrdenante.Text = ""
        txbCtaOrdenante.Text = ""
        ComboBox2.Enabled = False
        lblCtaBeneficiario.Text = ""
        lblRfcCtaBeneficiario.Text = ""
    End Sub

    Private Sub ComboBox3_TextChanged(sender As Object, e As EventArgs) Handles ComboBox3.TextChanged
        If ComboBox3.Text.Length > 5 Then
            CFDI_BancosBindingSource.Filter = "Nombre like '" & ComboBox3.Text & "%'"
        End If
    End Sub

    Private Sub txtFolioSust_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFolioSust.KeyDown
        Dim taCFDTimbress As New Production_AUXDataSetTableAdapters.CFDI_ControlTimbresTableAdapter
        If e.KeyCode = Keys.Enter Then
            If rbArfin.Checked = True Then
                If txtSerieSust.Text.ToUpper = "REPA" Then
                    If txtFolioSust.Text.Length > 0 Then
                        lblUUIDSust.Text = taCFDTimbress.ObtieneUUID(txtFolioSust.Text.Trim, txtSerieSust.Text.Trim)
                        If lblUUIDSust.Text = "NE" Then
                            MsgBox("No existe folio fiscal")
                            Me.txtSerieSust.Focus()
                        End If
                    End If
                Else
                    MsgBox("La serie " + txtSerieSust.Text.ToUpper + " no corresponde a la razón social de Servicios Arfin", MsgBoxStyle.Information)
                    limpiar_1()
                    Me.txtSerieSust.Focus()
                End If
            End If

            If rbFinagil.Checked = True Then
                If txtSerieSust.Text.ToUpper = "REP" Then
                    If txtFolioSust.Text.Length > 0 Then
                        lblUUIDSust.Text = taCFDTimbress.ObtieneUUID(txtFolioSust.Text.Trim, txtSerieSust.Text.Trim)
                        If lblUUIDSust.Text = "NE" Then
                            MsgBox("No existe folio fiscal")
                            Me.txtSerieSust.Focus()
                        End If
                    End If
                Else
                    MsgBox("La serie " + txtSerieSust.Text.ToUpper + " no corresponde a la razón social de Finagil", MsgBoxStyle.Information)
                    limpiar_1()
                    Me.txtSerieSust.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Txtfoliofil_TextChanged(sender As Object, e As EventArgs) Handles Txtfoliofil.TextChanged

    End Sub

    'Sub Filtros2()
    '    If txtSerieSust.Text.Length > 0 Then
    '        If txtFolioSust.Text.Length > 0 Then
    '            CFDIControlTimbresBindingSource.Filter = "serie like '" & txtSerieSust.Text & "%' and folio = " & txtFolioSust.Text
    '        Else
    '            CFDIControlTimbresBindingSource.Filter = "serie like '" & txtSerieSust.Text & "%'"
    '        End If
    '    Else
    '        If txtFolioSust.Text.Length > 0 Then
    '            CFDIControlTimbresBindingSource.Filter = "serie = '" & txtSerieSust.Text & "'"
    '        Else
    '            CFDIControlTimbresBindingSource.Filter = ""
    '        End If
    '    End If
    '    If CFDIControlTimbresBindingSource.Count = 0 Then
    '        MsgBox("La factura no existe...", MsgBoxStyle.Exclamation)
    '        'limpiar_1()
    '        Me.txtSerieSust.Focus()
    '    End If

    'End Sub
End Class
