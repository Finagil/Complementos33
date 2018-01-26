Public Class Form1

    Private Sub CFDI_EncabezadoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CFDI_EncabezadoBindingSource.EndEdit()
        Me.CFDI_EncabezadoTableAdapter.Update(Me.Production_AUXDataSet.CFDI_Encabezado)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Production_AUXDataSet.CFDI_Bancos' Puede moverla o quitarla según sea necesario.
        Me.CFDI_BancosTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_Bancos)
        'TODO: esta línea de código carga datos en la tabla 'Production_AUXDataSet.Bancos' Puede moverla o quitarla según sea necesario.
        Me.BancosTableAdapter.Fill(Me.Production_AUXDataSet.Bancos)
        'TODO: esta línea de código carga datos en la tabla 'Production_AUXDataSet.Vw_CFDI_SadosFactura' Puede moverla o quitarla según sea necesario.
        Me.Vw_CFDI_SadosFacturaTableAdapter.FillVSaldo(Me.Production_AUXDataSet.Vw_CFDI_SadosFactura)
        'TODO: esta línea de código carga datos en la tabla 'Production_AUXDataSet.CFDI_Encabezado' Puede moverla o quitarla según sea necesario.
        Me.CFDI_EncabezadoTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_Encabezado)
        'TODO: This line of code loads data into the 'Production_AUXDataSet.Vw_CFDI_SadosFactura1' table. You can move, or remove it, as needed.
        Me.Vw_CFDI_SadosFacturaTableAdapter.FillVSaldo(Me.Production_AUXDataSet.Vw_CFDI_SadosFactura)
        'TODO: This line of code loads data into the 'Production_AUXDataSet.CFDI_Bancos' table. You can move, or remove it, as needed.
        Me.CFDI_BancosTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_Bancos)
        DateTimePicker1.MaxDate = Date.Now
        DateTimePicker1.MinDate = Date.Now.AddHours(-72)

        Dim vFolio As Integer
        Dim vSerie As String
        Dim vDocumento As String
        'Dim vNPago As String ' =  "0051253a-ac93-4422-ad15-44c3fe5e7dbf"

        vFolio = CFDI_EncabezadoTableAdapter.SacaFolio()
        TextBox1.Text = vFolio

        'tboxnpago.Text = CFDI_ComplementoPagoTableAdapter.SacarNoPago(TextBox10.Text)

        vSerie = "REP"
        TextBox8.Text = vSerie

        vDocumento = CFDI_EncabezadoTableAdapter.SacaDocumento(vFolio, vSerie)
        'TextBox10.Text = vDocumento

        'TODO: This line of code loads data into the 'Production_AUXDataSet.Bancos' table. You can move, or remove it, as needed.
        Me.BancosTableAdapter.Fill(Me.Production_AUXDataSet.Bancos)
        'TODO: This line of code loads data into the 'Production_AUXDataSet.InstrumentoMonetario' table. You can move, or remove it, as needed.
        Me.InstrumentoMonetarioTableAdapter.Fill(Me.Production_AUXDataSet.InstrumentoMonetario)
        'TODO: This line of code loads data into the 'Production_AUXDataSet.CFDI_ComplementoPago' table. You can move, or remove it, as needed.
        Me.CFDI_ComplementoPagoTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_ComplementoPago)
        'TODO: This line of code loads data into the 'Production_AUXDataSet.Vw_CFDI_FacturasConSaldo1' table. You can move, or remove it, as needed.
        Me.Vw_CFDI_FacturasConSaldoTableAdapter.Fill(Me.Production_AUXDataSet.Vw_CFDI_FacturasConSaldo)
        'TODO: This line of code loads data into the 'Production_AUXDataSet.Vw_CFDI_SadosFactura' table. You can move, or remove it, as needed.
        Me.Vw_CFDI_SadosFacturaTableAdapter.FillVSaldo(Me.Production_AUXDataSet.Vw_CFDI_SadosFactura)
        'TODO: This line of code loads data into the 'Production_AUXDataSet.CFDI_ComplementoPago' table. You can move, or remove it, as needed.
        Me.CFDI_ComplementoPagoTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_ComplementoPago)
        'TODO: This line of code loads data into the 'Production_AUXDataSet.Vw_CFDI_FacturasConSaldo' table. You can move, or remove it, as needed.
        ''Me.Vw_CFDI_FacturasConSaldoTableAdapter.Fill(Me.Production_AUXDataSet.Vw_CFDI_FacturasConSaldo)
        'TODO: This line of code loads data into the 'Production_AUXDataSet.Vw_CFDI_SadosFactura' table. You can move, or remove it, as needed.
        Me.Vw_CFDI_SadosFacturaTableAdapter.FillVSaldo(Me.Production_AUXDataSet.Vw_CFDI_SadosFactura)
        'TODO: This line of code loads data into the 'Production_AUXDataSet.CFDI_Encabezado' table. You can move, or remove it, as needed.
        Me.CFDI_EncabezadoTableAdapter.Fill(Me.Production_AUXDataSet.CFDI_Encabezado)
        'Me.CFDI_EncabezadoTableAdapter.FillBySaldo()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub


    Private Sub CFDI_EncabezadoBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim vFecha As String
        'vFecha = DateTimePicker1.Value

        Dim vAnio As String = DateTimePicker1.MinDate.Year
        Dim vMes As String = DateTimePicker1.MinDate.Month
        Dim vDia As String = DateTimePicker1.MinDate.Day
        Dim vfecha As String = vAnio + "/" + vMes + "/" + vDia + " T12:00:00"
        'MsgBox("Fecha: " + vfecha)

        If ((txbCPagar.Text <> "") And (Val(txbCPagar.Text) <= Val(txbSaldo.Text))) Then

            Dim vFolio As Integer
            Dim vSerie As String
            Dim Spei As String = ""
            Dim SpeiCert As String = ""
            Dim SpeiCadOrg As String = ""
            Dim SpeiSello As String = ""
            Dim vNumeroPago As String = ""

            vFolio = TextBox1.Text '16
            vSerie = TextBox8.Text  '"MDM3"

            'vFolio = CFDI_EncabezadoTableAdapter.SacaFolio()
            'TextBox1.Text = vFolio

            'vSerie = "REPMDM"
            '  ENCABEZADO
            Dim ROWheader As Production_AUXDataSet.CFDI_EncabezadoRow
            ROWheader = Production_AUXDataSet.CFDI_Encabezado.NewCFDI_EncabezadoRow()

            '        TasaIVACliente = taCli.SacaTasaIVACliente(Datos(1))
            ROWheader._1_Folio = vFolio  ' 18

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
            ROWheader._27_Serie_Comprobante = vSerie ' "MDM"
            ROWheader._29_FormaPago = "" 'FormaPago '"27" '27 A satisfacción del acreedor
            ROWheader._30_Fecha = DateTimePicker1.Value.Date.ToString("dd/MM/yyyy")
            ROWheader._31_Hora = DateTimePicker1.Value.ToString("hh:mm:ss")
            ROWheader._41_Dom_LugarExpide_codigoPostal = "50070"

            ROWheader._42_Nombre_Receptor = TextBox2.Text ' CFDI_EncabezadoBindingSource.Current("_42_Nombre_Receptor")
            ROWheader._43_RFC_Receptor = Vw_CFDI_FacturasConSaldoBindingSource.Current("43_RFC_Receptor")

            ROWheader._54_Monto_SubTotal = 0
            ROWheader._55_Monto_IVA = 0
            ROWheader._56_Monto_Total = 0
            ROWheader._57_Estado = "1"
            ROWheader._58_TipoCFD = "FA"
            ROWheader._83_Cod_Moneda = "XXX"
            ROWheader._113_Misc01 = "[CPG_FINAGIL]"
            'ROWheader._114_Misc02 = Vw_CFDI_FacturasConSaldoBindingSource.Current("114_Misc02")
            'ROWheader._115_Misc03 = Vw_CFDI_FacturasConSaldoBindingSource.Current("115_Misc03")
            ROWheader._132_Misc20 = "[CPG]"
            ROWheader._144_Misc32 = "P01"
            'ROWheader._162_Misc50 = Vw_CFDI_FacturasConSaldoBindingSource.Current("162_Misc50")
            ROWheader._167_RegimentFiscal = "601"
            ROWheader._180_LugarExpedicion = "50070"
            ROWheader._190_Metodo_Pago = ""
            ROWheader._191_Efecto_Comprobante = "P"

            Me.Production_AUXDataSet.CFDI_Encabezado.Rows.Add(ROWheader)
            Me.CFDI_EncabezadoTableAdapter.Update(Me.Production_AUXDataSet.CFDI_Encabezado)
            Me.CFDI_EncabezadoTableAdapter.ConsumeFolio()

            '  DETALLE
            '  ROWdetail = ProducDS.CFDI_Detalle.NewCFDI_DetalleRow

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
            Me.CfdI_DetalleTableAdapter.Update(Me.Production_AUXDataSet.CFDI_Detalle)

            '  COMPLEMENTO DE PAGO Registro 1
            Dim ROWcomplemento As Production_AUXDataSet.CFDI_ComplementoPagoRow
            ROWcomplemento = Production_AUXDataSet.CFDI_ComplementoPago.NewCFDI_ComplementoPagoRow()

            ROWcomplemento._1_DetalleAux_Tipo = "CPG"
            ROWcomplemento._2_DetalleAux_DescTipo = "Pagos"
            ROWcomplemento._3_DetalleAux_Misc01 = "HD"
            ROWcomplemento._4_DetalleAux_Misc02 = "1.0"
            ROWcomplemento._5_DetalleAux_Misc03 = vfecha  ' DateTimePicker1.MinDate  '  Fecha en Formato  AAMMDD
            ROWcomplemento._6_DetalleAux_Misc04 = CmbFormaPago.SelectedValue
            ROWcomplemento._7_DetalleAux_Misc05 = txbMoneda.Text
            ROWcomplemento._8_DetalleAux_Misc06 = ""
            ROWcomplemento._9_DetalleAux_Misc07 = txbCPagar.Text
            ROWcomplemento._10_DetalleAux_Misc08 = txbrpago.Text ' Referencia de Pago
            If TextBox7.Text = "03" Then
                ROWcomplemento._11_DetalleAux_Misc09 = txbRfcCtaOrdenante.Text '  RFC Cta Ordenante
                ROWcomplemento._12_DetalleAux_Misc10 = ComboBox3.Text  ' Nombre Banco Ordenante
            Else
                ROWcomplemento._11_DetalleAux_Misc09 = ""   '  RFC Cta Ordenante
                ROWcomplemento._12_DetalleAux_Misc10 = ""   ' Nombre Banco Ordenante
            End If

            ROWcomplemento._13_DetalleAux_Misc11 = " "      '  Este campo NO debe ir Vacio

            ROWcomplemento._18_DetalleAux_Misc16 = ""
            ROWcomplemento._19_DetalleAux_Folio = vFolio
            ROWcomplemento._20_DetalleAux_Serie = vSerie

            Me.Production_AUXDataSet.CFDI_ComplementoPago.Rows.Add(ROWcomplemento)
            Me.CFDI_ComplementoPagoTableAdapter.Update(Me.Production_AUXDataSet.CFDI_ComplementoPago)

            '  COMPLEMENTO DE PAGO  Registro 2
            ROWcomplemento = Production_AUXDataSet.CFDI_ComplementoPago.NewCFDI_ComplementoPagoRow()

            ROWcomplemento._1_DetalleAux_Tipo = "CPG"
            ROWcomplemento._2_DetalleAux_DescTipo = "Pago"
            ROWcomplemento._3_DetalleAux_Misc01 = "HD"
            ROWcomplemento._4_DetalleAux_Misc02 = ""
            ROWcomplemento._5_DetalleAux_Misc03 = "" 'txbCtaOrdenante.Text
            ROWcomplemento._6_DetalleAux_Misc04 = "" 'lblRfcCtaBeneficiario.Text
            ROWcomplemento._7_DetalleAux_Misc05 = "" 'lblCtaBeneficiario.Text
            ROWcomplemento._8_DetalleAux_Misc06 = Spei
            ROWcomplemento._9_DetalleAux_Misc07 = SpeiCert
            ROWcomplemento._10_DetalleAux_Misc08 = SpeiCadOrg
            ROWcomplemento._11_DetalleAux_Misc09 = SpeiSello
            ROWcomplemento._12_DetalleAux_Misc10 = ""
            ROWcomplemento._13_DetalleAux_Misc11 = "" '"0.0"       '  Este campo NO debe ir Vacio

            ROWcomplemento._18_DetalleAux_Misc16 = "" '  Este campo NO debe ir Vacio
            ROWcomplemento._19_DetalleAux_Folio = vFolio
            ROWcomplemento._20_DetalleAux_Serie = vSerie

            Me.Production_AUXDataSet.CFDI_ComplementoPago.Rows.Add(ROWcomplemento)
            Me.CFDI_ComplementoPagoTableAdapter.Update(Me.Production_AUXDataSet.CFDI_ComplementoPago)

            '  COMPLEMENTO DE PAGO  Registro 3
            ROWcomplemento = Production_AUXDataSet.CFDI_ComplementoPago.NewCFDI_ComplementoPagoRow()

            ROWcomplemento._1_DetalleAux_Tipo = "CPG"
            ROWcomplemento._2_DetalleAux_DescTipo = "DoctoRelacionado"
            ROWcomplemento._3_DetalleAux_Misc01 = "HD"
            ROWcomplemento._4_DetalleAux_Misc02 = txbIdDocumento.Text
            ROWcomplemento._5_DetalleAux_Misc03 = Vw_CFDI_FacturasConSaldoBindingSource.Current("27_Serie_Comprobante")
            ROWcomplemento._6_DetalleAux_Misc04 = Vw_CFDI_FacturasConSaldoBindingSource.Current("1_Folio")
            ROWcomplemento._7_DetalleAux_Misc05 = txbMoneda.Text
            ROWcomplemento._8_DetalleAux_Misc06 = " "
            ROWcomplemento._9_DetalleAux_Misc07 = "PPD"

            vNumeroPago = CFDI_ComplementoPagoTableAdapter.SacarNoPago(txbIdDocumento.Text)
            ROWcomplemento._10_DetalleAux_Misc08 = vNumeroPago ' "1" ' numero de pago se saca con query

            ROWcomplemento._11_DetalleAux_Misc09 = Vw_CFDI_FacturasConSaldoBindingSource.Current("SaldoFactura")
            ROWcomplemento._12_DetalleAux_Misc10 = txbCPagar.Text
            ROWcomplemento._13_DetalleAux_Misc11 = Vw_CFDI_FacturasConSaldoBindingSource.Current("SaldoFactura") - CDec(txbCPagar.Text)
            ROWcomplemento._18_DetalleAux_Misc16 = ""   ' la tabla NO Acepta Capo Null
            ROWcomplemento._19_DetalleAux_Folio = vFolio
            ROWcomplemento._20_DetalleAux_Serie = vSerie

            Me.Production_AUXDataSet.CFDI_ComplementoPago.Rows.Add(ROWcomplemento)
            Me.CFDI_ComplementoPagoTableAdapter.Update(Me.Production_AUXDataSet.CFDI_ComplementoPago)

            MsgBox("Se guardaron Datos de Factura en BD")
            Me.Vw_CFDI_SadosFacturaTableAdapter.FillVSaldo(Me.Production_AUXDataSet.Vw_CFDI_SadosFactura)
        Else
            MsgBox("Cantidad debe ser Mayor a Cero y Menor o Igual al Saldo, NO SE REGISTRO EL PAGO")
        End If

    End Sub

    Private Sub Vw_CFDI_FacturasConSaldoDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Vw_CFDI_FacturasConSaldoDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

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
            txbCPagar.Visible = True
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
            'TextBox6.Visible = False
            txbRfcCtaOrdenante.Visible = False
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Vw_CFDI_FacturasConSaldo1DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Vw_CFDI_FacturasConSaldo1DataGridView.CellContentClick

    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbCPagar.KeyPress
        NumerosyDecimal(sender, e)
    End Sub

    Private Sub txbCPagar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbCPagar.TextChanged

    End Sub

    Private Sub txbMoneda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbMoneda.TextChanged
        Dim vAnio As String = DateTimePicker1.MinDate.Year
        Dim vMes As String = DateTimePicker1.MinDate.Month
        Dim vDia As String = DateTimePicker1.MinDate.Day
        Dim vfechatc As String = vDia + "/" + vMes + "/" + vAnio

        Dim vTipoCambio As String
        Dim vMoneda As String
        vMoneda = txbMoneda.Text
        'MsgBox("Moneda De la factura: " + vMoneda)
        vTipoCambio = CFDI_EncabezadoTableAdapter.SacaTipoCamnbio(vfechatc, vMoneda)
        'MsgBox("Tipo de Cambio: " + vTipoCambio)
    End Sub

    Private Sub TxtSerriefil_TextChanged(sender As Object, e As EventArgs) Handles TxtSeriefil.TextChanged
        Filtros()
    End Sub

    Private Sub Txtfoliofil_TextChanged(sender As Object, e As EventArgs) Handles Txtfoliofil.TextChanged
        Filtros()
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
    End Sub
End Class
