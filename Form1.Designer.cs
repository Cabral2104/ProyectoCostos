namespace ProyectoCostos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabTabla = new System.Windows.Forms.TabControl();
            this.tabDeterminacionDeProduccion = new System.Windows.Forms.TabPage();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduccionTerminada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProducciónEquivalente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceso2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avance2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduccionEquivalente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduccionProcesada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculodeCostosUnitariosPromedio = new System.Windows.Forms.TabPage();
            this.btncalcular2 = new System.Windows.Forms.Button();
            this.dtgCostosUniPromedio = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValuaciondeInventarioFinal = new System.Windows.Forms.TabPage();
            this.btnCalcular3 = new System.Windows.Forms.Button();
            this.dtgValuaciónInvFinal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValuacionProduccionTerminada = new System.Windows.Forms.TabPage();
            this.btnCalcular4 = new System.Windows.Forms.Button();
            this.dtgValuacionProducTerminada = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRecibo = new System.Windows.Forms.TabPage();
            this.lblALESCA = new System.Windows.Forms.Label();
            this.lblOrdenProduccion = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblEspecificaciones = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtEspecificaciones = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.lblFechaExxpidición = new System.Windows.Forms.Label();
            this.lblFechadeIniciacion = new System.Windows.Forms.Label();
            this.lblFechaDescargadadeEntrega = new System.Windows.Forms.Label();
            this.lblFechadeTerminación = new System.Windows.Forms.Label();
            this.dtpFechadePedido = new System.Windows.Forms.DateTimePicker();
            this.dtpFechadeEpedificacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechadeIniciacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDescargadadeEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpFechadeTerminacion = new System.Windows.Forms.DateTimePicker();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.lblMateriaPrimaDirecta = new System.Windows.Forms.Label();
            this.lblManoObraDirecta = new System.Windows.Forms.Label();
            this.lblCostoPrimario = new System.Windows.Forms.Label();
            this.lblCargosIndirectos = new System.Windows.Forms.Label();
            this.lblCostodeProduccion = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblUnitario = new System.Windows.Forms.Label();
            this.lblTotalMateriaPrimaDirecta = new System.Windows.Forms.Label();
            this.lblTotalManoObraDirecta = new System.Windows.Forms.Label();
            this.lblTotalCostoPrimario = new System.Windows.Forms.Label();
            this.lblTotalCargosIndirectos = new System.Windows.Forms.Label();
            this.lblTotalCostosdeProduccion = new System.Windows.Forms.Label();
            this.lblUnitarioMateriaPrimaDirecta = new System.Windows.Forms.Label();
            this.lblManoObraDirectaUnitario = new System.Windows.Forms.Label();
            this.lblCostoPrimoUnitario = new System.Windows.Forms.Label();
            this.lblUnitarioCargosIndirectos = new System.Windows.Forms.Label();
            this.lblUnitarioCostosdeProducción = new System.Windows.Forms.Label();
            this.lblExpedidopor = new System.Windows.Forms.Label();
            this.txxtExpedidopor = new System.Windows.Forms.TextBox();
            this.lblCalculadapor = new System.Windows.Forms.Label();
            this.txtCalculadapor = new System.Windows.Forms.TextBox();
            this.lblContabilizadapor = new System.Windows.Forms.Label();
            this.txtContabilizadapor = new System.Windows.Forms.TextBox();
            this.btnImprimirRecibo = new System.Windows.Forms.Button();
            this.tabTabla.SuspendLayout();
            this.tabDeterminacionDeProduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CalculodeCostosUnitariosPromedio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCostosUniPromedio)).BeginInit();
            this.ValuaciondeInventarioFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValuaciónInvFinal)).BeginInit();
            this.ValuacionProduccionTerminada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValuacionProducTerminada)).BeginInit();
            this.tabRecibo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTabla
            // 
            this.tabTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTabla.Controls.Add(this.tabDeterminacionDeProduccion);
            this.tabTabla.Controls.Add(this.CalculodeCostosUnitariosPromedio);
            this.tabTabla.Controls.Add(this.ValuaciondeInventarioFinal);
            this.tabTabla.Controls.Add(this.ValuacionProduccionTerminada);
            this.tabTabla.Controls.Add(this.tabRecibo);
            this.tabTabla.Location = new System.Drawing.Point(12, 12);
            this.tabTabla.Name = "tabTabla";
            this.tabTabla.SelectedIndex = 0;
            this.tabTabla.Size = new System.Drawing.Size(1107, 477);
            this.tabTabla.TabIndex = 0;
            // 
            // tabDeterminacionDeProduccion
            // 
            this.tabDeterminacionDeProduccion.AccessibleName = "tabDeterminacionDeProduccion";
            this.tabDeterminacionDeProduccion.Controls.Add(this.btnCalcular);
            this.tabDeterminacionDeProduccion.Controls.Add(this.dataGridView1);
            this.tabDeterminacionDeProduccion.Location = new System.Drawing.Point(4, 22);
            this.tabDeterminacionDeProduccion.Name = "tabDeterminacionDeProduccion";
            this.tabDeterminacionDeProduccion.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeterminacionDeProduccion.Size = new System.Drawing.Size(1099, 451);
            this.tabDeterminacionDeProduccion.TabIndex = 0;
            this.tabDeterminacionDeProduccion.Text = "DeterminacionDeProducción";
            this.tabDeterminacionDeProduccion.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(979, 349);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 50);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Cálcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Concepto,
            this.ProduccionTerminada,
            this.Proceso,
            this.Avance,
            this.ProducciónEquivalente,
            this.Proceso2,
            this.Avance2,
            this.ProduccionEquivalente2,
            this.ProduccionProcesada});
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 428);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // ProduccionTerminada
            // 
            this.ProduccionTerminada.HeaderText = "Producción Terminada";
            this.ProduccionTerminada.Name = "ProduccionTerminada";
            // 
            // Proceso
            // 
            this.Proceso.HeaderText = "Proceso";
            this.Proceso.Name = "Proceso";
            // 
            // Avance
            // 
            this.Avance.HeaderText = "%Avance";
            this.Avance.Name = "Avance";
            // 
            // ProducciónEquivalente
            // 
            this.ProducciónEquivalente.HeaderText = "Producción Equivalente";
            this.ProducciónEquivalente.Name = "ProducciónEquivalente";
            // 
            // Proceso2
            // 
            this.Proceso2.HeaderText = "Proceso";
            this.Proceso2.Name = "Proceso2";
            // 
            // Avance2
            // 
            this.Avance2.HeaderText = "%Avance";
            this.Avance2.Name = "Avance2";
            // 
            // ProduccionEquivalente2
            // 
            this.ProduccionEquivalente2.HeaderText = "Producción Equivalente";
            this.ProduccionEquivalente2.Name = "ProduccionEquivalente2";
            // 
            // ProduccionProcesada
            // 
            this.ProduccionProcesada.HeaderText = "Producción Procesada";
            this.ProduccionProcesada.Name = "ProduccionProcesada";
            // 
            // CalculodeCostosUnitariosPromedio
            // 
            this.CalculodeCostosUnitariosPromedio.AccessibleDescription = "CalculodeCostosUnitariosPromedio";
            this.CalculodeCostosUnitariosPromedio.AccessibleName = "CalculodeCostosUnitariosPromedio";
            this.CalculodeCostosUnitariosPromedio.Controls.Add(this.btncalcular2);
            this.CalculodeCostosUnitariosPromedio.Controls.Add(this.dtgCostosUniPromedio);
            this.CalculodeCostosUnitariosPromedio.Location = new System.Drawing.Point(4, 22);
            this.CalculodeCostosUnitariosPromedio.Name = "CalculodeCostosUnitariosPromedio";
            this.CalculodeCostosUnitariosPromedio.Padding = new System.Windows.Forms.Padding(3);
            this.CalculodeCostosUnitariosPromedio.Size = new System.Drawing.Size(1099, 451);
            this.CalculodeCostosUnitariosPromedio.TabIndex = 1;
            this.CalculodeCostosUnitariosPromedio.Text = "Cálculo de Costos Unitarios Promedio";
            this.CalculodeCostosUnitariosPromedio.UseVisualStyleBackColor = true;
            // 
            // btncalcular2
            // 
            this.btncalcular2.Location = new System.Drawing.Point(959, 232);
            this.btncalcular2.Name = "btncalcular2";
            this.btncalcular2.Size = new System.Drawing.Size(110, 61);
            this.btncalcular2.TabIndex = 2;
            this.btncalcular2.Text = "Cálcular";
            this.btncalcular2.UseVisualStyleBackColor = true;
            this.btncalcular2.Click += new System.EventHandler(this.btncalcular2_Click);
            // 
            // dtgCostosUniPromedio
            // 
            this.dtgCostosUniPromedio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCostosUniPromedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCostosUniPromedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dtgCostosUniPromedio.Location = new System.Drawing.Point(6, 3);
            this.dtgCostosUniPromedio.Name = "dtgCostosUniPromedio";
            this.dtgCostosUniPromedio.Size = new System.Drawing.Size(845, 428);
            this.dtgCostosUniPromedio.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Concepto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Inventario Inicial";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Costo Incurrido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Inventario Inicial";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Producción Procesada";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Total";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Costo Unitario Promedio";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // ValuaciondeInventarioFinal
            // 
            this.ValuaciondeInventarioFinal.AccessibleName = "ValuaciondeInventarioFinal";
            this.ValuaciondeInventarioFinal.Controls.Add(this.btnCalcular3);
            this.ValuaciondeInventarioFinal.Controls.Add(this.dtgValuaciónInvFinal);
            this.ValuaciondeInventarioFinal.Location = new System.Drawing.Point(4, 22);
            this.ValuaciondeInventarioFinal.Name = "ValuaciondeInventarioFinal";
            this.ValuaciondeInventarioFinal.Padding = new System.Windows.Forms.Padding(3);
            this.ValuaciondeInventarioFinal.Size = new System.Drawing.Size(1099, 451);
            this.ValuaciondeInventarioFinal.TabIndex = 2;
            this.ValuaciondeInventarioFinal.Text = "Valuación de Inventario Final";
            this.ValuaciondeInventarioFinal.UseVisualStyleBackColor = true;
            // 
            // btnCalcular3
            // 
            this.btnCalcular3.Location = new System.Drawing.Point(858, 209);
            this.btnCalcular3.Name = "btnCalcular3";
            this.btnCalcular3.Size = new System.Drawing.Size(130, 72);
            this.btnCalcular3.TabIndex = 3;
            this.btnCalcular3.Text = "Cálcular";
            this.btnCalcular3.UseVisualStyleBackColor = true;
            this.btnCalcular3.Click += new System.EventHandler(this.btnCalcular3_Click);
            // 
            // dtgValuaciónInvFinal
            // 
            this.dtgValuaciónInvFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgValuaciónInvFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgValuaciónInvFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dtgValuaciónInvFinal.Location = new System.Drawing.Point(328, 17);
            this.dtgValuaciónInvFinal.Name = "dtgValuaciónInvFinal";
            this.dtgValuaciónInvFinal.Size = new System.Drawing.Size(444, 428);
            this.dtgValuaciónInvFinal.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Concepto";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Unidades Equivalentes";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Costo Unitario Primario";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Total";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // ValuacionProduccionTerminada
            // 
            this.ValuacionProduccionTerminada.AccessibleName = "ValuacionProduccionTerminada";
            this.ValuacionProduccionTerminada.Controls.Add(this.btnCalcular4);
            this.ValuacionProduccionTerminada.Controls.Add(this.dtgValuacionProducTerminada);
            this.ValuacionProduccionTerminada.Location = new System.Drawing.Point(4, 22);
            this.ValuacionProduccionTerminada.Name = "ValuacionProduccionTerminada";
            this.ValuacionProduccionTerminada.Padding = new System.Windows.Forms.Padding(3);
            this.ValuacionProduccionTerminada.Size = new System.Drawing.Size(1099, 451);
            this.ValuacionProduccionTerminada.TabIndex = 3;
            this.ValuacionProduccionTerminada.Text = "Valuación de Producción Terminada";
            this.ValuacionProduccionTerminada.UseVisualStyleBackColor = true;
            // 
            // btnCalcular4
            // 
            this.btnCalcular4.Location = new System.Drawing.Point(862, 180);
            this.btnCalcular4.Name = "btnCalcular4";
            this.btnCalcular4.Size = new System.Drawing.Size(140, 78);
            this.btnCalcular4.TabIndex = 4;
            this.btnCalcular4.Text = "Cálcular";
            this.btnCalcular4.UseVisualStyleBackColor = true;
            this.btnCalcular4.Click += new System.EventHandler(this.btnCalcular4_Click);
            // 
            // dtgValuacionProducTerminada
            // 
            this.dtgValuacionProducTerminada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgValuacionProducTerminada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgValuacionProducTerminada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dtgValuacionProducTerminada.Location = new System.Drawing.Point(327, 11);
            this.dtgValuacionProducTerminada.Name = "dtgValuacionProducTerminada";
            this.dtgValuacionProducTerminada.Size = new System.Drawing.Size(444, 428);
            this.dtgValuacionProducTerminada.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Concepto";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Unidades Terminadas";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Costo Unitario Primario";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Total";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // tabRecibo
            // 
            this.tabRecibo.AccessibleName = "Recibo";
            this.tabRecibo.Controls.Add(this.btnImprimirRecibo);
            this.tabRecibo.Controls.Add(this.txtContabilizadapor);
            this.tabRecibo.Controls.Add(this.lblContabilizadapor);
            this.tabRecibo.Controls.Add(this.txtCalculadapor);
            this.tabRecibo.Controls.Add(this.lblCalculadapor);
            this.tabRecibo.Controls.Add(this.txxtExpedidopor);
            this.tabRecibo.Controls.Add(this.lblExpedidopor);
            this.tabRecibo.Controls.Add(this.lblUnitarioCostosdeProducción);
            this.tabRecibo.Controls.Add(this.lblUnitarioCargosIndirectos);
            this.tabRecibo.Controls.Add(this.lblCostoPrimoUnitario);
            this.tabRecibo.Controls.Add(this.lblManoObraDirectaUnitario);
            this.tabRecibo.Controls.Add(this.lblUnitarioMateriaPrimaDirecta);
            this.tabRecibo.Controls.Add(this.lblTotalCostosdeProduccion);
            this.tabRecibo.Controls.Add(this.lblTotalCargosIndirectos);
            this.tabRecibo.Controls.Add(this.lblTotalCostoPrimario);
            this.tabRecibo.Controls.Add(this.lblTotalManoObraDirecta);
            this.tabRecibo.Controls.Add(this.lblTotalMateriaPrimaDirecta);
            this.tabRecibo.Controls.Add(this.lblUnitario);
            this.tabRecibo.Controls.Add(this.lblTotal);
            this.tabRecibo.Controls.Add(this.lblCosto);
            this.tabRecibo.Controls.Add(this.lblCostodeProduccion);
            this.tabRecibo.Controls.Add(this.lblCargosIndirectos);
            this.tabRecibo.Controls.Add(this.lblCostoPrimario);
            this.tabRecibo.Controls.Add(this.lblManoObraDirecta);
            this.tabRecibo.Controls.Add(this.lblMateriaPrimaDirecta);
            this.tabRecibo.Controls.Add(this.lblConcepto);
            this.tabRecibo.Controls.Add(this.dtpFechadeTerminacion);
            this.tabRecibo.Controls.Add(this.dtpFechaDescargadadeEntrega);
            this.tabRecibo.Controls.Add(this.dtpFechadeIniciacion);
            this.tabRecibo.Controls.Add(this.dtpFechadeEpedificacion);
            this.tabRecibo.Controls.Add(this.dtpFechadePedido);
            this.tabRecibo.Controls.Add(this.lblFechadeTerminación);
            this.tabRecibo.Controls.Add(this.lblFechaDescargadadeEntrega);
            this.tabRecibo.Controls.Add(this.lblFechadeIniciacion);
            this.tabRecibo.Controls.Add(this.lblFechaExxpidición);
            this.tabRecibo.Controls.Add(this.lblFechaPedido);
            this.tabRecibo.Controls.Add(this.txtUnidad);
            this.tabRecibo.Controls.Add(this.txtCantidad);
            this.tabRecibo.Controls.Add(this.txtEspecificaciones);
            this.tabRecibo.Controls.Add(this.txtProducto);
            this.tabRecibo.Controls.Add(this.txtCliente);
            this.tabRecibo.Controls.Add(this.lblUnidad);
            this.tabRecibo.Controls.Add(this.lblCantidad);
            this.tabRecibo.Controls.Add(this.lblEspecificaciones);
            this.tabRecibo.Controls.Add(this.lblProducto);
            this.tabRecibo.Controls.Add(this.lblCliente);
            this.tabRecibo.Controls.Add(this.lblOrdenProduccion);
            this.tabRecibo.Controls.Add(this.lblALESCA);
            this.tabRecibo.Location = new System.Drawing.Point(4, 22);
            this.tabRecibo.Name = "tabRecibo";
            this.tabRecibo.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecibo.Size = new System.Drawing.Size(1099, 451);
            this.tabRecibo.TabIndex = 4;
            this.tabRecibo.Text = "Recibo";
            this.tabRecibo.UseVisualStyleBackColor = true;
            // 
            // lblALESCA
            // 
            this.lblALESCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALESCA.Location = new System.Drawing.Point(436, 3);
            this.lblALESCA.Name = "lblALESCA";
            this.lblALESCA.Size = new System.Drawing.Size(144, 31);
            this.lblALESCA.TabIndex = 0;
            this.lblALESCA.Text = "ALESCA. S.A";
            this.lblALESCA.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOrdenProduccion
            // 
            this.lblOrdenProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenProduccion.Location = new System.Drawing.Point(398, 25);
            this.lblOrdenProduccion.Name = "lblOrdenProduccion";
            this.lblOrdenProduccion.Size = new System.Drawing.Size(218, 23);
            this.lblOrdenProduccion.TabIndex = 1;
            this.lblOrdenProduccion.Text = "Orden de Producción";
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(28, 81);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(59, 23);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblProducto
            // 
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(28, 107);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(69, 23);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Producto";
            // 
            // lblEspecificaciones
            // 
            this.lblEspecificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecificaciones.Location = new System.Drawing.Point(29, 133);
            this.lblEspecificaciones.Name = "lblEspecificaciones";
            this.lblEspecificaciones.Size = new System.Drawing.Size(127, 23);
            this.lblEspecificaciones.TabIndex = 4;
            this.lblEspecificaciones.Text = "Especificaciones";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(29, 159);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 23);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblUnidad
            // 
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(29, 185);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(64, 23);
            this.lblUnidad.TabIndex = 6;
            this.lblUnidad.Text = "Unidad";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(162, 80);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(172, 20);
            this.txtCliente.TabIndex = 7;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(162, 106);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(172, 20);
            this.txtProducto.TabIndex = 8;
            // 
            // txtEspecificaciones
            // 
            this.txtEspecificaciones.Location = new System.Drawing.Point(162, 132);
            this.txtEspecificaciones.Name = "txtEspecificaciones";
            this.txtEspecificaciones.Size = new System.Drawing.Size(172, 20);
            this.txtEspecificaciones.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(162, 158);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(172, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(162, 184);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(172, 20);
            this.txtUnidad.TabIndex = 11;
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPedido.Location = new System.Drawing.Point(489, 77);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(127, 23);
            this.lblFechaPedido.TabIndex = 12;
            this.lblFechaPedido.Text = "Fecha de Pedido";
            // 
            // lblFechaExxpidición
            // 
            this.lblFechaExxpidición.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaExxpidición.Location = new System.Drawing.Point(489, 100);
            this.lblFechaExxpidición.Name = "lblFechaExxpidición";
            this.lblFechaExxpidición.Size = new System.Drawing.Size(156, 23);
            this.lblFechaExxpidición.TabIndex = 13;
            this.lblFechaExxpidición.Text = "Fecha de Epedición";
            // 
            // lblFechadeIniciacion
            // 
            this.lblFechadeIniciacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechadeIniciacion.Location = new System.Drawing.Point(489, 123);
            this.lblFechadeIniciacion.Name = "lblFechadeIniciacion";
            this.lblFechadeIniciacion.Size = new System.Drawing.Size(145, 23);
            this.lblFechadeIniciacion.TabIndex = 14;
            this.lblFechadeIniciacion.Text = "Fecha de Iniciación";
            // 
            // lblFechaDescargadadeEntrega
            // 
            this.lblFechaDescargadadeEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDescargadadeEntrega.Location = new System.Drawing.Point(489, 146);
            this.lblFechaDescargadadeEntrega.Name = "lblFechaDescargadadeEntrega";
            this.lblFechaDescargadadeEntrega.Size = new System.Drawing.Size(223, 23);
            this.lblFechaDescargadadeEntrega.TabIndex = 15;
            this.lblFechaDescargadadeEntrega.Text = "Fecha Descargada de Entrega";
            // 
            // lblFechadeTerminación
            // 
            this.lblFechadeTerminación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechadeTerminación.Location = new System.Drawing.Point(489, 169);
            this.lblFechadeTerminación.Name = "lblFechadeTerminación";
            this.lblFechadeTerminación.Size = new System.Drawing.Size(165, 23);
            this.lblFechadeTerminación.TabIndex = 16;
            this.lblFechadeTerminación.Text = "Fecha de Terminación";
            // 
            // dtpFechadePedido
            // 
            this.dtpFechadePedido.Location = new System.Drawing.Point(725, 73);
            this.dtpFechadePedido.Name = "dtpFechadePedido";
            this.dtpFechadePedido.Size = new System.Drawing.Size(200, 20);
            this.dtpFechadePedido.TabIndex = 17;
            // 
            // dtpFechadeEpedificacion
            // 
            this.dtpFechadeEpedificacion.Location = new System.Drawing.Point(725, 96);
            this.dtpFechadeEpedificacion.Name = "dtpFechadeEpedificacion";
            this.dtpFechadeEpedificacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechadeEpedificacion.TabIndex = 18;
            // 
            // dtpFechadeIniciacion
            // 
            this.dtpFechadeIniciacion.Location = new System.Drawing.Point(725, 119);
            this.dtpFechadeIniciacion.Name = "dtpFechadeIniciacion";
            this.dtpFechadeIniciacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechadeIniciacion.TabIndex = 19;
            // 
            // dtpFechaDescargadadeEntrega
            // 
            this.dtpFechaDescargadadeEntrega.Location = new System.Drawing.Point(725, 142);
            this.dtpFechaDescargadadeEntrega.Name = "dtpFechaDescargadadeEntrega";
            this.dtpFechaDescargadadeEntrega.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDescargadadeEntrega.TabIndex = 20;
            // 
            // dtpFechadeTerminacion
            // 
            this.dtpFechadeTerminacion.Location = new System.Drawing.Point(725, 165);
            this.dtpFechadeTerminacion.Name = "dtpFechadeTerminacion";
            this.dtpFechadeTerminacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechadeTerminacion.TabIndex = 21;
            // 
            // lblConcepto
            // 
            this.lblConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(94, 224);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(100, 23);
            this.lblConcepto.TabIndex = 22;
            this.lblConcepto.Text = "Concepto";
            // 
            // lblMateriaPrimaDirecta
            // 
            this.lblMateriaPrimaDirecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaPrimaDirecta.Location = new System.Drawing.Point(29, 257);
            this.lblMateriaPrimaDirecta.Name = "lblMateriaPrimaDirecta";
            this.lblMateriaPrimaDirecta.Size = new System.Drawing.Size(170, 23);
            this.lblMateriaPrimaDirecta.TabIndex = 23;
            this.lblMateriaPrimaDirecta.Text = "Materia Prima Directa";
            // 
            // lblManoObraDirecta
            // 
            this.lblManoObraDirecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManoObraDirecta.Location = new System.Drawing.Point(29, 280);
            this.lblManoObraDirecta.Name = "lblManoObraDirecta";
            this.lblManoObraDirecta.Size = new System.Drawing.Size(170, 23);
            this.lblManoObraDirecta.TabIndex = 24;
            this.lblManoObraDirecta.Text = "Mano de Obra Directa";
            // 
            // lblCostoPrimario
            // 
            this.lblCostoPrimario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoPrimario.Location = new System.Drawing.Point(29, 303);
            this.lblCostoPrimario.Name = "lblCostoPrimario";
            this.lblCostoPrimario.Size = new System.Drawing.Size(170, 23);
            this.lblCostoPrimario.TabIndex = 25;
            this.lblCostoPrimario.Text = "Costo Primo";
            // 
            // lblCargosIndirectos
            // 
            this.lblCargosIndirectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargosIndirectos.Location = new System.Drawing.Point(29, 326);
            this.lblCargosIndirectos.Name = "lblCargosIndirectos";
            this.lblCargosIndirectos.Size = new System.Drawing.Size(170, 23);
            this.lblCargosIndirectos.TabIndex = 26;
            this.lblCargosIndirectos.Text = "Cargos Indirectos";
            // 
            // lblCostodeProduccion
            // 
            this.lblCostodeProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostodeProduccion.Location = new System.Drawing.Point(29, 349);
            this.lblCostodeProduccion.Name = "lblCostodeProduccion";
            this.lblCostodeProduccion.Size = new System.Drawing.Size(170, 23);
            this.lblCostodeProduccion.TabIndex = 27;
            this.lblCostodeProduccion.Text = "Costo de Producción";
            // 
            // lblCosto
            // 
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(579, 192);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(55, 24);
            this.lblCosto.TabIndex = 28;
            this.lblCosto.Text = "Costo";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(437, 224);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 23);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "Total";
            // 
            // lblUnitario
            // 
            this.lblUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitario.Location = new System.Drawing.Point(721, 224);
            this.lblUnitario.Name = "lblUnitario";
            this.lblUnitario.Size = new System.Drawing.Size(100, 23);
            this.lblUnitario.TabIndex = 30;
            this.lblUnitario.Text = "Unitario";
            // 
            // lblTotalMateriaPrimaDirecta
            // 
            this.lblTotalMateriaPrimaDirecta.Location = new System.Drawing.Point(414, 247);
            this.lblTotalMateriaPrimaDirecta.Name = "lblTotalMateriaPrimaDirecta";
            this.lblTotalMateriaPrimaDirecta.Size = new System.Drawing.Size(100, 22);
            this.lblTotalMateriaPrimaDirecta.TabIndex = 31;
            this.lblTotalMateriaPrimaDirecta.Text = ".";
            // 
            // lblTotalManoObraDirecta
            // 
            this.lblTotalManoObraDirecta.Location = new System.Drawing.Point(414, 281);
            this.lblTotalManoObraDirecta.Name = "lblTotalManoObraDirecta";
            this.lblTotalManoObraDirecta.Size = new System.Drawing.Size(100, 22);
            this.lblTotalManoObraDirecta.TabIndex = 32;
            this.lblTotalManoObraDirecta.Text = ".";
            // 
            // lblTotalCostoPrimario
            // 
            this.lblTotalCostoPrimario.Location = new System.Drawing.Point(414, 304);
            this.lblTotalCostoPrimario.Name = "lblTotalCostoPrimario";
            this.lblTotalCostoPrimario.Size = new System.Drawing.Size(100, 22);
            this.lblTotalCostoPrimario.TabIndex = 33;
            this.lblTotalCostoPrimario.Text = ".";
            // 
            // lblTotalCargosIndirectos
            // 
            this.lblTotalCargosIndirectos.Location = new System.Drawing.Point(414, 327);
            this.lblTotalCargosIndirectos.Name = "lblTotalCargosIndirectos";
            this.lblTotalCargosIndirectos.Size = new System.Drawing.Size(100, 22);
            this.lblTotalCargosIndirectos.TabIndex = 34;
            this.lblTotalCargosIndirectos.Text = ".";
            // 
            // lblTotalCostosdeProduccion
            // 
            this.lblTotalCostosdeProduccion.Location = new System.Drawing.Point(414, 350);
            this.lblTotalCostosdeProduccion.Name = "lblTotalCostosdeProduccion";
            this.lblTotalCostosdeProduccion.Size = new System.Drawing.Size(100, 22);
            this.lblTotalCostosdeProduccion.TabIndex = 35;
            this.lblTotalCostosdeProduccion.Text = ".";
            // 
            // lblUnitarioMateriaPrimaDirecta
            // 
            this.lblUnitarioMateriaPrimaDirecta.Location = new System.Drawing.Point(705, 247);
            this.lblUnitarioMateriaPrimaDirecta.Name = "lblUnitarioMateriaPrimaDirecta";
            this.lblUnitarioMateriaPrimaDirecta.Size = new System.Drawing.Size(100, 22);
            this.lblUnitarioMateriaPrimaDirecta.TabIndex = 36;
            this.lblUnitarioMateriaPrimaDirecta.Text = ".";
            // 
            // lblManoObraDirectaUnitario
            // 
            this.lblManoObraDirectaUnitario.Location = new System.Drawing.Point(705, 280);
            this.lblManoObraDirectaUnitario.Name = "lblManoObraDirectaUnitario";
            this.lblManoObraDirectaUnitario.Size = new System.Drawing.Size(100, 22);
            this.lblManoObraDirectaUnitario.TabIndex = 37;
            this.lblManoObraDirectaUnitario.Text = ".";
            // 
            // lblCostoPrimoUnitario
            // 
            this.lblCostoPrimoUnitario.Location = new System.Drawing.Point(705, 307);
            this.lblCostoPrimoUnitario.Name = "lblCostoPrimoUnitario";
            this.lblCostoPrimoUnitario.Size = new System.Drawing.Size(100, 22);
            this.lblCostoPrimoUnitario.TabIndex = 38;
            this.lblCostoPrimoUnitario.Text = ".";
            // 
            // lblUnitarioCargosIndirectos
            // 
            this.lblUnitarioCargosIndirectos.Location = new System.Drawing.Point(705, 330);
            this.lblUnitarioCargosIndirectos.Name = "lblUnitarioCargosIndirectos";
            this.lblUnitarioCargosIndirectos.Size = new System.Drawing.Size(100, 22);
            this.lblUnitarioCargosIndirectos.TabIndex = 39;
            this.lblUnitarioCargosIndirectos.Text = ".";
            // 
            // lblUnitarioCostosdeProducción
            // 
            this.lblUnitarioCostosdeProducción.Location = new System.Drawing.Point(705, 353);
            this.lblUnitarioCostosdeProducción.Name = "lblUnitarioCostosdeProducción";
            this.lblUnitarioCostosdeProducción.Size = new System.Drawing.Size(100, 22);
            this.lblUnitarioCostosdeProducción.TabIndex = 40;
            this.lblUnitarioCostosdeProducción.Text = ".";
            // 
            // lblExpedidopor
            // 
            this.lblExpedidopor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpedidopor.Location = new System.Drawing.Point(27, 412);
            this.lblExpedidopor.Name = "lblExpedidopor";
            this.lblExpedidopor.Size = new System.Drawing.Size(109, 23);
            this.lblExpedidopor.TabIndex = 41;
            this.lblExpedidopor.Text = "Expedida por:";
            // 
            // txxtExpedidopor
            // 
            this.txxtExpedidopor.Location = new System.Drawing.Point(142, 412);
            this.txxtExpedidopor.Name = "txxtExpedidopor";
            this.txxtExpedidopor.Size = new System.Drawing.Size(172, 20);
            this.txxtExpedidopor.TabIndex = 42;
            // 
            // lblCalculadapor
            // 
            this.lblCalculadapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadapor.Location = new System.Drawing.Point(334, 409);
            this.lblCalculadapor.Name = "lblCalculadapor";
            this.lblCalculadapor.Size = new System.Drawing.Size(114, 23);
            this.lblCalculadapor.TabIndex = 43;
            this.lblCalculadapor.Text = "Calculada por:";
            // 
            // txtCalculadapor
            // 
            this.txtCalculadapor.Location = new System.Drawing.Point(454, 411);
            this.txtCalculadapor.Name = "txtCalculadapor";
            this.txtCalculadapor.Size = new System.Drawing.Size(172, 20);
            this.txtCalculadapor.TabIndex = 44;
            // 
            // lblContabilizadapor
            // 
            this.lblContabilizadapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContabilizadapor.Location = new System.Drawing.Point(663, 409);
            this.lblContabilizadapor.Name = "lblContabilizadapor";
            this.lblContabilizadapor.Size = new System.Drawing.Size(142, 23);
            this.lblContabilizadapor.TabIndex = 45;
            this.lblContabilizadapor.Text = "Contabilizada por:";
            // 
            // txtContabilizadapor
            // 
            this.txtContabilizadapor.Location = new System.Drawing.Point(811, 411);
            this.txtContabilizadapor.Name = "txtContabilizadapor";
            this.txtContabilizadapor.Size = new System.Drawing.Size(172, 20);
            this.txtContabilizadapor.TabIndex = 46;
            // 
            // btnImprimirRecibo
            // 
            this.btnImprimirRecibo.Location = new System.Drawing.Point(1018, 408);
            this.btnImprimirRecibo.Name = "btnImprimirRecibo";
            this.btnImprimirRecibo.Size = new System.Drawing.Size(75, 23);
            this.btnImprimirRecibo.TabIndex = 47;
            this.btnImprimirRecibo.Text = "Imprimir";
            this.btnImprimirRecibo.UseVisualStyleBackColor = true;
            this.btnImprimirRecibo.Click += new System.EventHandler(this.btnImprimirRecibo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 501);
            this.Controls.Add(this.tabTabla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabTabla.ResumeLayout(false);
            this.tabDeterminacionDeProduccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CalculodeCostosUnitariosPromedio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCostosUniPromedio)).EndInit();
            this.ValuaciondeInventarioFinal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgValuaciónInvFinal)).EndInit();
            this.ValuacionProduccionTerminada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgValuacionProducTerminada)).EndInit();
            this.tabRecibo.ResumeLayout(false);
            this.tabRecibo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTabla;
        private System.Windows.Forms.TabPage tabDeterminacionDeProduccion;
        private System.Windows.Forms.TabPage CalculodeCostosUnitariosPromedio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduccionTerminada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProducciónEquivalente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avance2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduccionEquivalente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduccionProcesada;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dtgCostosUniPromedio;
        private System.Windows.Forms.Button btncalcular2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TabPage ValuaciondeInventarioFinal;
        private System.Windows.Forms.Button btnCalcular3;
        private System.Windows.Forms.DataGridView dtgValuaciónInvFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TabPage ValuacionProduccionTerminada;
        private System.Windows.Forms.Button btnCalcular4;
        private System.Windows.Forms.DataGridView dtgValuacionProducTerminada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.TabPage tabRecibo;
        private System.Windows.Forms.Label lblALESCA;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblOrdenProduccion;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtEspecificaciones;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblEspecificaciones;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DateTimePicker dtpFechadeTerminacion;
        private System.Windows.Forms.DateTimePicker dtpFechaDescargadadeEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechadeIniciacion;
        private System.Windows.Forms.DateTimePicker dtpFechadeEpedificacion;
        private System.Windows.Forms.DateTimePicker dtpFechadePedido;
        private System.Windows.Forms.Label lblFechadeTerminación;
        private System.Windows.Forms.Label lblFechaDescargadadeEntrega;
        private System.Windows.Forms.Label lblFechadeIniciacion;
        private System.Windows.Forms.Label lblFechaExxpidición;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.Label lblCostodeProduccion;
        private System.Windows.Forms.Label lblCargosIndirectos;
        private System.Windows.Forms.Label lblCostoPrimario;
        private System.Windows.Forms.Label lblManoObraDirecta;
        private System.Windows.Forms.Label lblMateriaPrimaDirecta;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Label lblTotalCostosdeProduccion;
        private System.Windows.Forms.Label lblTotalCargosIndirectos;
        private System.Windows.Forms.Label lblTotalCostoPrimario;
        private System.Windows.Forms.Label lblTotalManoObraDirecta;
        private System.Windows.Forms.Label lblTotalMateriaPrimaDirecta;
        private System.Windows.Forms.Label lblUnitario;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblUnitarioCostosdeProducción;
        private System.Windows.Forms.Label lblUnitarioCargosIndirectos;
        private System.Windows.Forms.Label lblCostoPrimoUnitario;
        private System.Windows.Forms.Label lblManoObraDirectaUnitario;
        private System.Windows.Forms.Label lblUnitarioMateriaPrimaDirecta;
        private System.Windows.Forms.Label lblExpedidopor;
        private System.Windows.Forms.Button btnImprimirRecibo;
        private System.Windows.Forms.TextBox txtContabilizadapor;
        private System.Windows.Forms.Label lblContabilizadapor;
        private System.Windows.Forms.TextBox txtCalculadapor;
        private System.Windows.Forms.Label lblCalculadapor;
        private System.Windows.Forms.TextBox txxtExpedidopor;
    }
}

