<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SaldoFacturaLabel As System.Windows.Forms.Label
        Dim _83_Cod_MonedaLabel As System.Windows.Forms.Label
        Dim FolioFiscalLabel As System.Windows.Forms.Label
        Dim NoPagosLabel As System.Windows.Forms.Label
        Me.CFDI_EncabezadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Production_AUXDataSet = New Complemento33.Production_AUXDataSet()
        Me.Vw_CFDI_FacturasConSaldoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbCtaOrdenante = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.InstrumentoMonetarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CFDI_ComplementoPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_CFDI_SadosFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCtaBeneficiario = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblRfcCtaBeneficiario = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txbRfcCtaOrdenante = New System.Windows.Forms.TextBox()
        Me.CFDI_BancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txbrpago = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtSeriefil = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txtfoliofil = New System.Windows.Forms.TextBox()
        Me.CFDI_EncabezadoTableAdapter = New Complemento33.Production_AUXDataSetTableAdapters.CFDI_EncabezadoTableAdapter()
        Me.Vw_CFDI_SadosFacturaTableAdapter = New Complemento33.Production_AUXDataSetTableAdapters.Vw_CFDI_SadosFacturaTableAdapter()
        Me.BancosTableAdapter = New Complemento33.Production_AUXDataSetTableAdapters.BancosTableAdapter()
        Me.CFDI_BancosTableAdapter = New Complemento33.Production_AUXDataSetTableAdapters.CFDI_BancosTableAdapter()
        Me.Vw_CFDI_FacturasConSaldoTableAdapter = New Complemento33.Production_AUXDataSetTableAdapters.Vw_CFDI_FacturasConSaldoTableAdapter()
        Me.CFDI_ComplementoPagoTableAdapter = New Complemento33.Production_AUXDataSetTableAdapters.CFDI_ComplementoPagoTableAdapter()
        Me.InstrumentoMonetarioTableAdapter = New Complemento33.Production_AUXDataSetTableAdapters.InstrumentoMonetarioTableAdapter()
        Me.CFDI_DetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CFDI_DetalleTableAdapter = New Complemento33.Production_AUXDataSetTableAdapters.CFDI_DetalleTableAdapter()
        Me._27_Serie_ComprobanteTextBox = New System.Windows.Forms.TextBox()
        Me._1_FolioTextBox = New System.Windows.Forms.TextBox()
        Me.SaldoFacturaTextBox = New System.Windows.Forms.TextBox()
        Me.lbPago = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.dgDoctosPagos = New System.Windows.Forms.DataGridView()
        Me.dgUUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgFolio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgTCambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgMPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgParcialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgImpPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgSaldoInsoluto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgElimina = New System.Windows.Forms.DataGridViewLinkColumn()
        Me._83_Cod_MonedaTextBox = New System.Windows.Forms.TextBox()
        Me.gbEmisor = New System.Windows.Forms.GroupBox()
        Me.rbArfin = New System.Windows.Forms.RadioButton()
        Me.rbFinagil = New System.Windows.Forms.RadioButton()
        Me.FolioFiscalTextBox = New System.Windows.Forms.TextBox()
        Me.NoPagosTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.lbMoneda = New System.Windows.Forms.Label()
        Me.lbTotalP = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.btnLoadXML = New System.Windows.Forms.Button()
        Me.fdBwCargaXML = New System.Windows.Forms.FolderBrowserDialog()
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaEmision = New System.Windows.Forms.Label()
        Me.chkSPEI = New System.Windows.Forms.CheckBox()
        Me.gbxSPEI = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOcultarSPEI = New System.Windows.Forms.Button()
        Me.txtSPEISello = New System.Windows.Forms.TextBox()
        Me.txtSPEICad = New System.Windows.Forms.TextBox()
        Me.txtSPEICert = New System.Windows.Forms.TextBox()
        Me.tsSerieFolio = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cbDatosBancarios = New System.Windows.Forms.CheckBox()
        Me.txtMails = New System.Windows.Forms.TextBox()
        Me.lbMails = New System.Windows.Forms.Label()
        SaldoFacturaLabel = New System.Windows.Forms.Label()
        _83_Cod_MonedaLabel = New System.Windows.Forms.Label()
        FolioFiscalLabel = New System.Windows.Forms.Label()
        NoPagosLabel = New System.Windows.Forms.Label()
        CType(Me.CFDI_EncabezadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Production_AUXDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_CFDI_FacturasConSaldoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstrumentoMonetarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDI_ComplementoPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_CFDI_SadosFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDI_BancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CFDI_DetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDoctosPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEmisor.SuspendLayout()
        Me.gbxSPEI.SuspendLayout()
        Me.tsSerieFolio.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaldoFacturaLabel
        '
        SaldoFacturaLabel.AutoSize = True
        SaldoFacturaLabel.Enabled = False
        SaldoFacturaLabel.Location = New System.Drawing.Point(667, 6)
        SaldoFacturaLabel.Name = "SaldoFacturaLabel"
        SaldoFacturaLabel.Size = New System.Drawing.Size(76, 13)
        SaldoFacturaLabel.TabIndex = 47
        SaldoFacturaLabel.Text = "Saldo Factura:"
        '
        '_83_Cod_MonedaLabel
        '
        _83_Cod_MonedaLabel.AutoSize = True
        _83_Cod_MonedaLabel.Enabled = False
        _83_Cod_MonedaLabel.Location = New System.Drawing.Point(561, 6)
        _83_Cod_MonedaLabel.Name = "_83_Cod_MonedaLabel"
        _83_Cod_MonedaLabel.Size = New System.Drawing.Size(49, 13)
        _83_Cod_MonedaLabel.TabIndex = 56
        _83_Cod_MonedaLabel.Text = "Moneda:"
        '
        'FolioFiscalLabel
        '
        FolioFiscalLabel.AutoSize = True
        FolioFiscalLabel.Enabled = False
        FolioFiscalLabel.Location = New System.Drawing.Point(985, 6)
        FolioFiscalLabel.Name = "FolioFiscalLabel"
        FolioFiscalLabel.Size = New System.Drawing.Size(62, 13)
        FolioFiscalLabel.TabIndex = 59
        FolioFiscalLabel.Text = "Folio Fiscal:"
        '
        'NoPagosLabel
        '
        NoPagosLabel.AutoSize = True
        NoPagosLabel.Enabled = False
        NoPagosLabel.Location = New System.Drawing.Point(773, 6)
        NoPagosLabel.Name = "NoPagosLabel"
        NoPagosLabel.Size = New System.Drawing.Size(57, 13)
        NoPagosLabel.TabIndex = 60
        NoPagosLabel.Text = "No Pagos:"
        '
        'CFDI_EncabezadoBindingSource
        '
        Me.CFDI_EncabezadoBindingSource.DataMember = "CFDI_Encabezado"
        Me.CFDI_EncabezadoBindingSource.DataSource = Me.Production_AUXDataSet
        '
        'Production_AUXDataSet
        '
        Me.Production_AUXDataSet.DataSetName = "Production_AUXDataSet"
        Me.Production_AUXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_CFDI_FacturasConSaldoBindingSource
        '
        Me.Vw_CFDI_FacturasConSaldoBindingSource.DataMember = "Vw_CFDI_FacturasConSaldo"
        Me.Vw_CFDI_FacturasConSaldoBindingSource.DataSource = Me.Production_AUXDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(432, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cuenta Ordenante"
        '
        'txbCtaOrdenante
        '
        Me.txbCtaOrdenante.Location = New System.Drawing.Point(435, 358)
        Me.txbCtaOrdenante.Name = "txbCtaOrdenante"
        Me.txbCtaOrdenante.Size = New System.Drawing.Size(116, 20)
        Me.txbCtaOrdenante.TabIndex = 15
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstrumentoMonetarioBindingSource, "SAT", True))
        Me.TextBox7.Location = New System.Drawing.Point(360, 316)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(25, 20)
        Me.TextBox7.TabIndex = 11
        '
        'InstrumentoMonetarioBindingSource
        '
        Me.InstrumentoMonetarioBindingSource.DataMember = "InstrumentoMonetario"
        Me.InstrumentoMonetarioBindingSource.DataSource = Me.Production_AUXDataSet
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1051, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 53)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Guardar Datos y Generar Factura"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre Banco Ordenante"
        '
        'CFDI_ComplementoPagoBindingSource
        '
        Me.CFDI_ComplementoPagoBindingSource.DataMember = "CFDI_ComplementoPago"
        Me.CFDI_ComplementoPagoBindingSource.DataSource = Me.Production_AUXDataSet
        '
        'Vw_CFDI_SadosFacturaBindingSource
        '
        Me.Vw_CFDI_SadosFacturaBindingSource.DataMember = "Vw_CFDI_SadosFactura"
        Me.Vw_CFDI_SadosFacturaBindingSource.DataSource = Me.Production_AUXDataSet
        '
        'CmbFormaPago
        '
        Me.CmbFormaPago.DataSource = Me.InstrumentoMonetarioBindingSource
        Me.CmbFormaPago.DisplayMember = "Titulo"
        Me.CmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFormaPago.FormattingEnabled = True
        Me.CmbFormaPago.Location = New System.Drawing.Point(133, 316)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.Size = New System.Drawing.Size(144, 21)
        Me.CmbFormaPago.TabIndex = 9
        Me.CmbFormaPago.ValueMember = "SAT"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.BancosBindingSource
        Me.ComboBox2.DisplayMember = "DescBanco"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(21, 407)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox2.TabIndex = 17
        Me.ComboBox2.ValueMember = "Banco"
        Me.ComboBox2.Visible = False
        '
        'BancosBindingSource
        '
        Me.BancosBindingSource.DataMember = "Bancos"
        Me.BancosBindingSource.DataSource = Me.Production_AUXDataSet
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(21, 316)
        Me.DateTimePicker1.MaxDate = New Date(2017, 11, 24, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2017, 11, 24, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(106, 20)
        Me.DateTimePicker1.TabIndex = 8
        Me.DateTimePicker1.Value = New Date(2017, 11, 24, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Fecha de Pago"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Forma de Pago"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Banco FINAGIL"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(285, 391)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Cuenta Beneficiario"
        Me.Label11.Visible = False
        '
        'lblCtaBeneficiario
        '
        Me.lblCtaBeneficiario.AutoSize = True
        Me.lblCtaBeneficiario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancosBindingSource, "Cuenta", True))
        Me.lblCtaBeneficiario.Location = New System.Drawing.Point(285, 410)
        Me.lblCtaBeneficiario.Name = "lblCtaBeneficiario"
        Me.lblCtaBeneficiario.Size = New System.Drawing.Size(41, 13)
        Me.lblCtaBeneficiario.TabIndex = 18
        Me.lblCtaBeneficiario.Text = "Cuenta"
        Me.lblCtaBeneficiario.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(432, 391)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "RFC Cta Beneficiario"
        Me.Label13.Visible = False
        '
        'lblRfcCtaBeneficiario
        '
        Me.lblRfcCtaBeneficiario.AutoSize = True
        Me.lblRfcCtaBeneficiario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BancosBindingSource, "RFC", True))
        Me.lblRfcCtaBeneficiario.Location = New System.Drawing.Point(432, 410)
        Me.lblRfcCtaBeneficiario.Name = "lblRfcCtaBeneficiario"
        Me.lblRfcCtaBeneficiario.Size = New System.Drawing.Size(31, 13)
        Me.lblRfcCtaBeneficiario.TabIndex = 19
        Me.lblRfcCtaBeneficiario.Text = "RFC "
        Me.lblRfcCtaBeneficiario.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(285, 342)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "RFC Cta Ordenante"
        Me.Label15.Visible = False
        '
        'txbRfcCtaOrdenante
        '
        Me.txbRfcCtaOrdenante.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txbRfcCtaOrdenante.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CFDI_BancosBindingSource, "RFC", True))
        Me.txbRfcCtaOrdenante.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_BancosBindingSource, "RFC", True))
        Me.txbRfcCtaOrdenante.Location = New System.Drawing.Point(288, 361)
        Me.txbRfcCtaOrdenante.Name = "txbRfcCtaOrdenante"
        Me.txbRfcCtaOrdenante.ReadOnly = True
        Me.txbRfcCtaOrdenante.Size = New System.Drawing.Size(132, 13)
        Me.txbRfcCtaOrdenante.TabIndex = 14
        Me.txbRfcCtaOrdenante.Text = "RFC"
        '
        'CFDI_BancosBindingSource
        '
        Me.CFDI_BancosBindingSource.DataMember = "CFDI_Bancos"
        Me.CFDI_BancosBindingSource.DataSource = Me.Production_AUXDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.CFDI_BancosBindingSource
        Me.ComboBox3.DisplayMember = "Nombre"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(21, 358)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox3.TabIndex = 13
        Me.ComboBox3.ValueMember = "SAT"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "1_Folio"
        Me.DataGridViewTextBoxColumn16.HeaderText = "1_Folio"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "27_Serie_Comprobante"
        Me.DataGridViewTextBoxColumn17.HeaderText = "27_Serie_Comprobante"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "42_Nombre_Receptor"
        Me.DataGridViewTextBoxColumn18.HeaderText = "42_Nombre_Receptor"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "43_RFC_Receptor"
        Me.DataGridViewTextBoxColumn19.HeaderText = "43_RFC_Receptor"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "54_Monto_SubTotal"
        Me.DataGridViewTextBoxColumn20.HeaderText = "54_Monto_SubTotal"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "55_Monto_IVA"
        Me.DataGridViewTextBoxColumn21.HeaderText = "55_Monto_IVA"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "56_Monto_Total"
        Me.DataGridViewTextBoxColumn31.HeaderText = "56_Monto_Total"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "SaldoFactura"
        Me.DataGridViewTextBoxColumn32.HeaderText = "SaldoFactura"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "FolioFiscal"
        Me.DataGridViewTextBoxColumn33.HeaderText = "FolioFiscal"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "30_Fecha"
        Me.DataGridViewTextBoxColumn34.HeaderText = "30_Fecha"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'txbrpago
        '
        Me.txbrpago.Location = New System.Drawing.Point(580, 358)
        Me.txbrpago.Name = "txbrpago"
        Me.txbrpago.Size = New System.Drawing.Size(116, 20)
        Me.txbrpago.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(577, 342)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 13)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Referencia Pago"
        '
        'TxtSeriefil
        '
        Me.TxtSeriefil.Location = New System.Drawing.Point(203, 22)
        Me.TxtSeriefil.Name = "TxtSeriefil"
        Me.TxtSeriefil.Size = New System.Drawing.Size(51, 20)
        Me.TxtSeriefil.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(200, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Serie"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(264, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Folio"
        '
        'Txtfoliofil
        '
        Me.Txtfoliofil.Location = New System.Drawing.Point(260, 22)
        Me.Txtfoliofil.Name = "Txtfoliofil"
        Me.Txtfoliofil.Size = New System.Drawing.Size(77, 20)
        Me.Txtfoliofil.TabIndex = 3
        '
        'CFDI_EncabezadoTableAdapter
        '
        Me.CFDI_EncabezadoTableAdapter.ClearBeforeFill = True
        '
        'Vw_CFDI_SadosFacturaTableAdapter
        '
        Me.Vw_CFDI_SadosFacturaTableAdapter.ClearBeforeFill = True
        '
        'BancosTableAdapter
        '
        Me.BancosTableAdapter.ClearBeforeFill = True
        '
        'CFDI_BancosTableAdapter
        '
        Me.CFDI_BancosTableAdapter.ClearBeforeFill = True
        '
        'Vw_CFDI_FacturasConSaldoTableAdapter
        '
        Me.Vw_CFDI_FacturasConSaldoTableAdapter.ClearBeforeFill = True
        '
        'CFDI_ComplementoPagoTableAdapter
        '
        Me.CFDI_ComplementoPagoTableAdapter.ClearBeforeFill = True
        '
        'InstrumentoMonetarioTableAdapter
        '
        Me.InstrumentoMonetarioTableAdapter.ClearBeforeFill = True
        '
        'CFDI_DetalleBindingSource
        '
        Me.CFDI_DetalleBindingSource.DataMember = "CFDI_Detalle"
        Me.CFDI_DetalleBindingSource.DataSource = Me.Production_AUXDataSet
        '
        'CFDI_DetalleTableAdapter
        '
        Me.CFDI_DetalleTableAdapter.ClearBeforeFill = True
        '
        '_27_Serie_ComprobanteTextBox
        '
        Me._27_Serie_ComprobanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CFDI_FacturasConSaldoBindingSource, "27_Serie_Comprobante", True))
        Me._27_Serie_ComprobanteTextBox.Enabled = False
        Me._27_Serie_ComprobanteTextBox.Location = New System.Drawing.Point(352, 22)
        Me._27_Serie_ComprobanteTextBox.Name = "_27_Serie_ComprobanteTextBox"
        Me._27_Serie_ComprobanteTextBox.Size = New System.Drawing.Size(100, 20)
        Me._27_Serie_ComprobanteTextBox.TabIndex = 46
        '
        '_1_FolioTextBox
        '
        Me._1_FolioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CFDI_FacturasConSaldoBindingSource, "1_Folio", True))
        Me._1_FolioTextBox.Enabled = False
        Me._1_FolioTextBox.Location = New System.Drawing.Point(458, 22)
        Me._1_FolioTextBox.Name = "_1_FolioTextBox"
        Me._1_FolioTextBox.Size = New System.Drawing.Size(100, 20)
        Me._1_FolioTextBox.TabIndex = 47
        '
        'SaldoFacturaTextBox
        '
        Me.SaldoFacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CFDI_FacturasConSaldoBindingSource, "SaldoFactura", True))
        Me.SaldoFacturaTextBox.Enabled = False
        Me.SaldoFacturaTextBox.Location = New System.Drawing.Point(670, 22)
        Me.SaldoFacturaTextBox.Name = "SaldoFacturaTextBox"
        Me.SaldoFacturaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SaldoFacturaTextBox.TabIndex = 48
        '
        'lbPago
        '
        Me.lbPago.AutoSize = True
        Me.lbPago.Enabled = False
        Me.lbPago.Location = New System.Drawing.Point(879, 6)
        Me.lbPago.Name = "lbPago"
        Me.lbPago.Size = New System.Drawing.Size(84, 13)
        Me.lbPago.TabIndex = 49
        Me.lbPago.Text = "Importe a pagar:"
        '
        'txtPago
        '
        Me.txtPago.Enabled = False
        Me.txtPago.Location = New System.Drawing.Point(882, 22)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(100, 20)
        Me.txtPago.TabIndex = 4
        '
        'dgDoctosPagos
        '
        Me.dgDoctosPagos.AllowUserToAddRows = False
        Me.dgDoctosPagos.AllowUserToDeleteRows = False
        Me.dgDoctosPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDoctosPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgUUID, Me.dgSerie, Me.dgFolio, Me.dgMoneda, Me.dgTCambio, Me.dgMPago, Me.dgParcialidad, Me.dgSaldo, Me.dgImpPago, Me.dgSaldoInsoluto, Me.dgElimina})
        Me.dgDoctosPagos.Location = New System.Drawing.Point(17, 90)
        Me.dgDoctosPagos.Name = "dgDoctosPagos"
        Me.dgDoctosPagos.ReadOnly = True
        Me.dgDoctosPagos.Size = New System.Drawing.Size(1199, 194)
        Me.dgDoctosPagos.TabIndex = 7
        '
        'dgUUID
        '
        Me.dgUUID.HeaderText = "UUID"
        Me.dgUUID.Name = "dgUUID"
        Me.dgUUID.ReadOnly = True
        '
        'dgSerie
        '
        Me.dgSerie.HeaderText = "Serie"
        Me.dgSerie.Name = "dgSerie"
        Me.dgSerie.ReadOnly = True
        '
        'dgFolio
        '
        Me.dgFolio.HeaderText = "Folio"
        Me.dgFolio.Name = "dgFolio"
        Me.dgFolio.ReadOnly = True
        '
        'dgMoneda
        '
        Me.dgMoneda.HeaderText = "Moneda"
        Me.dgMoneda.Name = "dgMoneda"
        Me.dgMoneda.ReadOnly = True
        Me.dgMoneda.Width = 50
        '
        'dgTCambio
        '
        Me.dgTCambio.HeaderText = "T Cambio"
        Me.dgTCambio.Name = "dgTCambio"
        Me.dgTCambio.ReadOnly = True
        '
        'dgMPago
        '
        Me.dgMPago.HeaderText = "M Pago"
        Me.dgMPago.Name = "dgMPago"
        Me.dgMPago.ReadOnly = True
        '
        'dgParcialidad
        '
        Me.dgParcialidad.HeaderText = "Parc"
        Me.dgParcialidad.Name = "dgParcialidad"
        Me.dgParcialidad.ReadOnly = True
        '
        'dgSaldo
        '
        Me.dgSaldo.HeaderText = "Saldo"
        Me.dgSaldo.Name = "dgSaldo"
        Me.dgSaldo.ReadOnly = True
        '
        'dgImpPago
        '
        Me.dgImpPago.HeaderText = "Imp a Pagar"
        Me.dgImpPago.Name = "dgImpPago"
        Me.dgImpPago.ReadOnly = True
        '
        'dgSaldoInsoluto
        '
        Me.dgSaldoInsoluto.HeaderText = "S Insol"
        Me.dgSaldoInsoluto.Name = "dgSaldoInsoluto"
        Me.dgSaldoInsoluto.ReadOnly = True
        '
        'dgElimina
        '
        Me.dgElimina.HeaderText = "Eliminar"
        Me.dgElimina.Name = "dgElimina"
        Me.dgElimina.ReadOnly = True
        Me.dgElimina.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgElimina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        '_83_Cod_MonedaTextBox
        '
        Me._83_Cod_MonedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CFDI_FacturasConSaldoBindingSource, "83_Cod_Moneda", True))
        Me._83_Cod_MonedaTextBox.Enabled = False
        Me._83_Cod_MonedaTextBox.Location = New System.Drawing.Point(564, 22)
        Me._83_Cod_MonedaTextBox.Name = "_83_Cod_MonedaTextBox"
        Me._83_Cod_MonedaTextBox.Size = New System.Drawing.Size(100, 20)
        Me._83_Cod_MonedaTextBox.TabIndex = 57
        '
        'gbEmisor
        '
        Me.gbEmisor.Controls.Add(Me.rbArfin)
        Me.gbEmisor.Controls.Add(Me.rbFinagil)
        Me.gbEmisor.Location = New System.Drawing.Point(17, 0)
        Me.gbEmisor.Name = "gbEmisor"
        Me.gbEmisor.Size = New System.Drawing.Size(155, 48)
        Me.gbEmisor.TabIndex = 58
        Me.gbEmisor.TabStop = False
        Me.gbEmisor.Text = "Emisor:"
        '
        'rbArfin
        '
        Me.rbArfin.AutoSize = True
        Me.rbArfin.Location = New System.Drawing.Point(88, 19)
        Me.rbArfin.Name = "rbArfin"
        Me.rbArfin.Size = New System.Drawing.Size(46, 17)
        Me.rbArfin.TabIndex = 1
        Me.rbArfin.Text = "Arfin"
        Me.rbArfin.UseVisualStyleBackColor = True
        '
        'rbFinagil
        '
        Me.rbFinagil.AutoSize = True
        Me.rbFinagil.Checked = True
        Me.rbFinagil.Location = New System.Drawing.Point(16, 19)
        Me.rbFinagil.Name = "rbFinagil"
        Me.rbFinagil.Size = New System.Drawing.Size(55, 17)
        Me.rbFinagil.TabIndex = 0
        Me.rbFinagil.TabStop = True
        Me.rbFinagil.Text = "Finagil"
        Me.rbFinagil.UseVisualStyleBackColor = True
        '
        'FolioFiscalTextBox
        '
        Me.FolioFiscalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CFDI_FacturasConSaldoBindingSource, "FolioFiscal", True))
        Me.FolioFiscalTextBox.Enabled = False
        Me.FolioFiscalTextBox.Location = New System.Drawing.Point(988, 22)
        Me.FolioFiscalTextBox.Name = "FolioFiscalTextBox"
        Me.FolioFiscalTextBox.Size = New System.Drawing.Size(236, 20)
        Me.FolioFiscalTextBox.TabIndex = 60
        '
        'NoPagosTextBox
        '
        Me.NoPagosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CFDI_FacturasConSaldoBindingSource, "NoPagos", True))
        Me.NoPagosTextBox.Enabled = False
        Me.NoPagosTextBox.Location = New System.Drawing.Point(776, 22)
        Me.NoPagosTextBox.Name = "NoPagosTextBox"
        Me.NoPagosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NoPagosTextBox.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(561, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Cliente:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_CFDI_FacturasConSaldoBindingSource, "42_Nombre_Receptor", True))
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(606, 51)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(414, 20)
        Me.TextBox2.TabIndex = 3
        '
        'cbMoneda
        '
        Me.cbMoneda.Enabled = False
        Me.cbMoneda.FormattingEnabled = True
        Me.cbMoneda.Items.AddRange(New Object() {"MXN", "USD"})
        Me.cbMoneda.Location = New System.Drawing.Point(435, 314)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(73, 21)
        Me.cbMoneda.TabIndex = 12
        Me.cbMoneda.Text = "MXN"
        '
        'lbMoneda
        '
        Me.lbMoneda.AutoSize = True
        Me.lbMoneda.Location = New System.Drawing.Point(436, 298)
        Me.lbMoneda.Name = "lbMoneda"
        Me.lbMoneda.Size = New System.Drawing.Size(49, 13)
        Me.lbMoneda.TabIndex = 63
        Me.lbMoneda.Text = "Moneda:"
        '
        'lbTotalP
        '
        Me.lbTotalP.AutoSize = True
        Me.lbTotalP.Location = New System.Drawing.Point(577, 319)
        Me.lbTotalP.Name = "lbTotalP"
        Me.lbTotalP.Size = New System.Drawing.Size(74, 13)
        Me.lbTotalP.TabIndex = 64
        Me.lbTotalP.Text = "Total Pago:  $"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(654, 319)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(13, 13)
        Me.lbTotal.TabIndex = 65
        Me.lbTotal.Text = "0"
        '
        'btnLoadXML
        '
        Me.btnLoadXML.Enabled = False
        Me.btnLoadXML.Location = New System.Drawing.Point(17, 54)
        Me.btnLoadXML.Name = "btnLoadXML"
        Me.btnLoadXML.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadXML.TabIndex = 5
        Me.btnLoadXML.Text = "Cargar XML"
        Me.btnLoadXML.UseVisualStyleBackColor = True
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.Location = New System.Drawing.Point(201, 57)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaEmision.TabIndex = 5
        '
        'lblFechaEmision
        '
        Me.lblFechaEmision.AutoSize = True
        Me.lblFechaEmision.Location = New System.Drawing.Point(120, 63)
        Me.lblFechaEmision.Name = "lblFechaEmision"
        Me.lblFechaEmision.Size = New System.Drawing.Size(78, 13)
        Me.lblFechaEmision.TabIndex = 67
        Me.lblFechaEmision.Text = "Fecha emisión:"
        '
        'chkSPEI
        '
        Me.chkSPEI.AutoSize = True
        Me.chkSPEI.Location = New System.Drawing.Point(288, 318)
        Me.chkSPEI.Name = "chkSPEI"
        Me.chkSPEI.Size = New System.Drawing.Size(56, 17)
        Me.chkSPEI.TabIndex = 10
        Me.chkSPEI.Text = "SPEI?"
        Me.chkSPEI.UseVisualStyleBackColor = True
        '
        'gbxSPEI
        '
        Me.gbxSPEI.Controls.Add(Me.Label6)
        Me.gbxSPEI.Controls.Add(Me.Label5)
        Me.gbxSPEI.Controls.Add(Me.Label3)
        Me.gbxSPEI.Controls.Add(Me.btnOcultarSPEI)
        Me.gbxSPEI.Controls.Add(Me.txtSPEISello)
        Me.gbxSPEI.Controls.Add(Me.txtSPEICad)
        Me.gbxSPEI.Controls.Add(Me.txtSPEICert)
        Me.gbxSPEI.Location = New System.Drawing.Point(399, 124)
        Me.gbxSPEI.Name = "gbxSPEI"
        Me.gbxSPEI.Size = New System.Drawing.Size(458, 142)
        Me.gbxSPEI.TabIndex = 72
        Me.gbxSPEI.TabStop = False
        Me.gbxSPEI.Text = "Datos SPEI:"
        Me.gbxSPEI.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Sello:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cadena:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Certificado:"
        '
        'btnOcultarSPEI
        '
        Me.btnOcultarSPEI.Location = New System.Drawing.Point(366, 111)
        Me.btnOcultarSPEI.Name = "btnOcultarSPEI"
        Me.btnOcultarSPEI.Size = New System.Drawing.Size(75, 23)
        Me.btnOcultarSPEI.TabIndex = 3
        Me.btnOcultarSPEI.Text = "Aceptar"
        Me.btnOcultarSPEI.UseVisualStyleBackColor = True
        '
        'txtSPEISello
        '
        Me.txtSPEISello.Location = New System.Drawing.Point(73, 81)
        Me.txtSPEISello.Multiline = True
        Me.txtSPEISello.Name = "txtSPEISello"
        Me.txtSPEISello.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSPEISello.Size = New System.Drawing.Size(368, 20)
        Me.txtSPEISello.TabIndex = 2
        '
        'txtSPEICad
        '
        Me.txtSPEICad.Location = New System.Drawing.Point(73, 55)
        Me.txtSPEICad.Multiline = True
        Me.txtSPEICad.Name = "txtSPEICad"
        Me.txtSPEICad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSPEICad.Size = New System.Drawing.Size(368, 20)
        Me.txtSPEICad.TabIndex = 1
        '
        'txtSPEICert
        '
        Me.txtSPEICert.Location = New System.Drawing.Point(73, 29)
        Me.txtSPEICert.Multiline = True
        Me.txtSPEICert.Name = "txtSPEICert"
        Me.txtSPEICert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSPEICert.Size = New System.Drawing.Size(368, 20)
        Me.txtSPEICert.TabIndex = 0
        '
        'tsSerieFolio
        '
        Me.tsSerieFolio.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsSerieFolio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.tsSerieFolio.Location = New System.Drawing.Point(0, 474)
        Me.tsSerieFolio.Name = "tsSerieFolio"
        Me.tsSerieFolio.Size = New System.Drawing.Size(1236, 25)
        Me.tsSerieFolio.TabIndex = 73
        Me.tsSerieFolio.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'cbDatosBancarios
        '
        Me.cbDatosBancarios.AutoSize = True
        Me.cbDatosBancarios.Checked = True
        Me.cbDatosBancarios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbDatosBancarios.Location = New System.Drawing.Point(580, 406)
        Me.cbDatosBancarios.Name = "cbDatosBancarios"
        Me.cbDatosBancarios.Size = New System.Drawing.Size(150, 17)
        Me.cbDatosBancarios.TabIndex = 30
        Me.cbDatosBancarios.Text = "Agregar Datos Bancarios?"
        Me.cbDatosBancarios.UseVisualStyleBackColor = True
        '
        'txtMails
        '
        Me.txtMails.Location = New System.Drawing.Point(765, 434)
        Me.txtMails.Multiline = True
        Me.txtMails.Name = "txtMails"
        Me.txtMails.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMails.Size = New System.Drawing.Size(436, 28)
        Me.txtMails.TabIndex = 74
        '
        'lbMails
        '
        Me.lbMails.AutoSize = True
        Me.lbMails.Location = New System.Drawing.Point(722, 437)
        Me.lbMails.Name = "lbMails"
        Me.lbMails.Size = New System.Drawing.Size(34, 13)
        Me.lbMails.TabIndex = 75
        Me.lbMails.Text = "Mails:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1236, 499)
        Me.Controls.Add(Me.lbMails)
        Me.Controls.Add(Me.txtMails)
        Me.Controls.Add(Me.cbDatosBancarios)
        Me.Controls.Add(Me.tsSerieFolio)
        Me.Controls.Add(Me.gbxSPEI)
        Me.Controls.Add(Me.chkSPEI)
        Me.Controls.Add(Me.lblFechaEmision)
        Me.Controls.Add(Me.dtpFechaEmision)
        Me.Controls.Add(Me.btnLoadXML)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.lbTotalP)
        Me.Controls.Add(Me.lbMoneda)
        Me.Controls.Add(Me.cbMoneda)
        Me.Controls.Add(NoPagosLabel)
        Me.Controls.Add(Me.NoPagosTextBox)
        Me.Controls.Add(FolioFiscalLabel)
        Me.Controls.Add(Me.FolioFiscalTextBox)
        Me.Controls.Add(Me.gbEmisor)
        Me.Controls.Add(_83_Cod_MonedaLabel)
        Me.Controls.Add(Me._83_Cod_MonedaTextBox)
        Me.Controls.Add(Me.txtPago)
        Me.Controls.Add(Me.lbPago)
        Me.Controls.Add(SaldoFacturaLabel)
        Me.Controls.Add(Me.SaldoFacturaTextBox)
        Me.Controls.Add(Me._1_FolioTextBox)
        Me.Controls.Add(Me._27_Serie_ComprobanteTextBox)
        Me.Controls.Add(Me.TxtSeriefil)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Txtfoliofil)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txbrpago)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.txbRfcCtaOrdenante)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblRfcCtaBeneficiario)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblCtaBeneficiario)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.CmbFormaPago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.txbCtaOrdenante)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.dgDoctosPagos)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de Complementos"
        CType(Me.CFDI_EncabezadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Production_AUXDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_CFDI_FacturasConSaldoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstrumentoMonetarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDI_ComplementoPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_CFDI_SadosFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDI_BancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CFDI_DetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDoctosPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEmisor.ResumeLayout(False)
        Me.gbEmisor.PerformLayout()
        Me.gbxSPEI.ResumeLayout(False)
        Me.gbxSPEI.PerformLayout()
        Me.tsSerieFolio.ResumeLayout(False)
        Me.tsSerieFolio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CFDI_EncabezadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txbCtaOrdenante As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Vw_CFDI_SadosFacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_CFDI_FacturasConSaldoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CFDI_ComplementoPagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents InstrumentoMonetarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents BancosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblCtaBeneficiario As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblRfcCtaBeneficiario As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txbRfcCtaOrdenante As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents CFDI_BancosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txbrpago As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtSeriefil As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Txtfoliofil As TextBox
    Friend WithEvents Production_AUXDataSet As Production_AUXDataSet
    Friend WithEvents CFDI_EncabezadoTableAdapter As Production_AUXDataSetTableAdapters.CFDI_EncabezadoTableAdapter
    Friend WithEvents Vw_CFDI_SadosFacturaTableAdapter As Production_AUXDataSetTableAdapters.Vw_CFDI_SadosFacturaTableAdapter
    Friend WithEvents BancosTableAdapter As Production_AUXDataSetTableAdapters.BancosTableAdapter
    Friend WithEvents CFDI_BancosTableAdapter As Production_AUXDataSetTableAdapters.CFDI_BancosTableAdapter
    Friend WithEvents Vw_CFDI_FacturasConSaldoTableAdapter As Production_AUXDataSetTableAdapters.Vw_CFDI_FacturasConSaldoTableAdapter
    Friend WithEvents CFDI_ComplementoPagoTableAdapter As Production_AUXDataSetTableAdapters.CFDI_ComplementoPagoTableAdapter
    Friend WithEvents InstrumentoMonetarioTableAdapter As Production_AUXDataSetTableAdapters.InstrumentoMonetarioTableAdapter
    Friend WithEvents CFDI_DetalleBindingSource As BindingSource
    Friend WithEvents CFDI_DetalleTableAdapter As Production_AUXDataSetTableAdapters.CFDI_DetalleTableAdapter
    Friend WithEvents _27_Serie_ComprobanteTextBox As TextBox
    Friend WithEvents _1_FolioTextBox As TextBox
    Friend WithEvents SaldoFacturaTextBox As TextBox
    Friend WithEvents lbPago As Label
    Friend WithEvents txtPago As TextBox
    Friend WithEvents dgDoctosPagos As DataGridView
    Friend WithEvents _83_Cod_MonedaTextBox As TextBox
    Friend WithEvents gbEmisor As GroupBox
    Friend WithEvents rbArfin As RadioButton
    Friend WithEvents rbFinagil As RadioButton
    Friend WithEvents FolioFiscalTextBox As TextBox
    Friend WithEvents NoPagosTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents cbMoneda As ComboBox
    Friend WithEvents lbMoneda As Label
    Friend WithEvents dgUUID As DataGridViewTextBoxColumn
    Friend WithEvents dgSerie As DataGridViewTextBoxColumn
    Friend WithEvents dgFolio As DataGridViewTextBoxColumn
    Friend WithEvents dgMoneda As DataGridViewTextBoxColumn
    Friend WithEvents dgTCambio As DataGridViewTextBoxColumn
    Friend WithEvents dgMPago As DataGridViewTextBoxColumn
    Friend WithEvents dgParcialidad As DataGridViewTextBoxColumn
    Friend WithEvents dgSaldo As DataGridViewTextBoxColumn
    Friend WithEvents dgImpPago As DataGridViewTextBoxColumn
    Friend WithEvents dgSaldoInsoluto As DataGridViewTextBoxColumn
    Friend WithEvents dgElimina As DataGridViewLinkColumn
    Friend WithEvents lbTotalP As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents btnLoadXML As Button
    Friend WithEvents fdBwCargaXML As FolderBrowserDialog
    Friend WithEvents dtpFechaEmision As DateTimePicker
    Friend WithEvents lblFechaEmision As Label
    Friend WithEvents chkSPEI As CheckBox
    Friend WithEvents gbxSPEI As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOcultarSPEI As Button
    Friend WithEvents txtSPEISello As TextBox
    Friend WithEvents txtSPEICad As TextBox
    Friend WithEvents txtSPEICert As TextBox
    Friend WithEvents tsSerieFolio As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cbDatosBancarios As CheckBox
    Friend WithEvents txtMails As TextBox
    Friend WithEvents lbMails As Label
End Class
