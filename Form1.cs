using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCostos
{
    public partial class Form1 : Form
    {
        private float PTMateriales, PTManoObra, PTGfabricacion, ProcesoMateriales, ProcesoManoObra, ProcesoGFabricacion, AvanceMateriales, AvanceManoObra, AvanceGfabricacion, ProcesoMateriales2, ProcesoManoObra2, ProcesoGFabricacion2, AvanceMateriales2, AvanceManoObra2, AvanceGFabricacion2;

        private void btnImprimirRecibo_Click(object sender, EventArgs e)
        {
            string informacionCompleta = $"{lblALESCA.Text} \n\n{lblOrdenProduccion.Text}\n\n{"Cliente: " + txtCliente.Text + "     "} {dtpFechadePedido.Text}\n\n{"Producto: "+ txtProducto.Text + "     "} {dtpFechadeEpedificacion.Text + "     "}\n\n{"Especificaciones: "+ txtEspecificaciones.Text + "     "} {dtpFechadeIniciacion.Text}\n\n{"Cantidad: "+ txtCantidad.Text + "     "} {dtpFechaDescargadadeEntrega.Text}\n\n{"Unidad: "+ txtUnidad.Text + "     "} {dtpFechadeTerminacion.Text}\n\n{lblConcepto.Text + "     "} {lblCosto.Text}\n\n{"     "} {lblTotal.Text + "     "} {lblUnitario.Text}\n\n{lblMateriaPrimaDirecta.Text + "     "} {lblTotalMateriaPrimaDirecta.Text + "     "}{lblUnitarioMateriaPrimaDirecta.Text}\n\n{lblManoObraDirecta.Text + "     "}{lblTotalManoObraDirecta.Text + "     "}{lblManoObraDirectaUnitario.Text}\n\n{lblCostoPrimario.Text + "     "}{lblTotalCostoPrimario.Text + "     "}{lblCostoPrimoUnitario.Text}\n\n{lblCargosIndirectos.Text + "     "}{lblTotalCargosIndirectos.Text + "     "}{lblUnitarioCargosIndirectos.Text}\n\n{lblCostodeProduccion.Text + "     "}{lblTotalCostosdeProduccion.Text + "     "}{lblUnitarioCostosdeProducción.Text}\n\n{" Expedida por: " + txxtExpedidopor.Text} {"      Calculada por: " + txtCalculadapor.Text}{"      Contabilizada por: " + txtContabilizadapor.Text}";
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Crear la ruta completa del archivo
            string rutaArchivo = Path.Combine(escritorio, "informacion.txt");
            GuardarEnArchivo(rutaArchivo, informacionCompleta);
        }
        private void GuardarEnArchivo(string ruta, string informacion)
        {
            try
            {
                // Escribe la información en el archivo
                using (StreamWriter sw = new StreamWriter(ruta, true))
                {
                    sw.WriteLine(informacion);
                }

                MessageBox.Show("Información guardada correctamente en el archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la información: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private float PEMateriales, PEManoObra, PEGFabricacion, PEMateriales2, PEManoObra2, PEGFabricacion2, PPMateriales, PPManoObra, PPGFabricacion;
        private float InventarioInicialMateriales, MaaterialesCostoIncurrido, TotalMaterialesCU, InventarioInicial2Materiales, ProduccionPorocesadaMateriales, Total2MaterialesCU, CostoUnitarioPromedioMateriales, InventarioInicialManoObra, CostoIncurridoManoObra, TotalManoObra, InventarioInicial2ManoObra, ProduccionProcesadaManoObra, Total2ManoObra, CostoUnitarioPromedioManoObra, InventarioInicialGFabricacion, CostoIncurridoGFabricacion, TotalGFabricacion, InventarioInicial2GFabricacion, ProduccionProcesadaGFabricacion, Total2GFabricacion, CostoUnitarioPromedioGFabricacion, SumaCosto;
        private float UnidadesEquivalentesMats, CUPMateriales, MaterialesTotal, ManoObraUnidadesEquivalentes, CUPManoObra, ManoObraTotal, GFabricacionUnidadesEquivalentes, CUPGFabricacion, GFabricacionTotal, SumaTotalIF;
        private float UnidadesTerminadasMats, cupMateriales, MaterialesTotalV, UnidadesTerminadasManoObra, cupManoObra, ManoObraTotalV, UnidadesTerminadasGFabricacion, cupGFabricacion, GFabricacionTotalV,sumaTotalValuacion;
        private void btnCalcular4_Click(object sender, EventArgs e)
        {
            UnidadesTerminadasMats = PTMateriales;
            dtgValuacionProducTerminada.Rows[0].Cells[1].Value = UnidadesTerminadasMats;
            cupMateriales = CostoUnitarioPromedioMateriales;
            dtgValuacionProducTerminada.Rows[0].Cells[2].Value = cupMateriales;
            MaterialesTotalV = UnidadesTerminadasMats * cupMateriales;
            dtgValuacionProducTerminada.Rows[0].Cells[3].Value = MaterialesTotalV;
            UnidadesTerminadasManoObra = PTManoObra;
            dtgValuacionProducTerminada.Rows[1].Cells[1].Value = UnidadesTerminadasManoObra;
            cupManoObra = CostoUnitarioPromedioManoObra;
            dtgValuacionProducTerminada.Rows[1].Cells[2].Value = cupManoObra;
            ManoObraTotalV = UnidadesTerminadasManoObra * cupManoObra;
            dtgValuacionProducTerminada.Rows[1].Cells[3].Value = ManoObraTotalV;
            UnidadesTerminadasGFabricacion = PTGfabricacion;
            dtgValuacionProducTerminada.Rows[2].Cells[1].Value = UnidadesTerminadasGFabricacion;
            cupGFabricacion = CostoUnitarioPromedioGFabricacion;
            dtgValuacionProducTerminada.Rows[2].Cells[2].Value = cupGFabricacion;
            GFabricacionTotalV = UnidadesTerminadasGFabricacion * cupGFabricacion;
            dtgValuacionProducTerminada.Rows[2].Cells[3].Value = GFabricacionTotalV;
            sumaTotalValuacion = MaterialesTotalV + ManoObraTotalV + GFabricacionTotalV;
            dtgValuacionProducTerminada.Rows[3].Cells[3].Value = sumaTotalValuacion;

            lblTotalMateriaPrimaDirecta.Text = MaterialesTotalV.ToString();
            lblTotalManoObraDirecta.Text = ManoObraTotalV.ToString();
            lblTotalCargosIndirectos.Text = GFabricacionTotalV.ToString();
            lblTotalCostoPrimario.Text = (MaterialesTotalV + ManoObraTotalV).ToString();
            lblTotalCostosdeProduccion.Text = ((MaterialesTotalV + ManoObraTotalV) + (GFabricacionTotalV)).ToString();
            lblUnitarioMateriaPrimaDirecta.Text = cupMateriales.ToString();
            lblManoObraDirectaUnitario.Text = cupManoObra.ToString();
            lblUnitarioCargosIndirectos.Text = cupGFabricacion.ToString();
            lblCostoPrimoUnitario.Text = (cupMateriales + cupManoObra).ToString();
            lblUnitarioCostosdeProducción.Text = ((cupMateriales + cupManoObra) + (cupGFabricacion)).ToString();

            tabTabla.TabPages[3].Controls.Add(dtgValuacionProducTerminada);
        }

       

        private void btnCalcular3_Click(object sender, EventArgs e)
        {
            UnidadesEquivalentesMats = PEMateriales;
            dtgValuaciónInvFinal.Rows[0].Cells[1].Value = UnidadesEquivalentesMats;
            CUPMateriales = CostoUnitarioPromedioMateriales;
            dtgValuaciónInvFinal.Rows[0].Cells[2].Value = CUPMateriales;
            MaterialesTotal = UnidadesEquivalentesMats * CUPMateriales;
            dtgValuaciónInvFinal.Rows[0].Cells[3].Value = MaterialesTotal;
            ManoObraUnidadesEquivalentes = PEManoObra;
            dtgValuaciónInvFinal.Rows[1].Cells[1].Value = ManoObraUnidadesEquivalentes;
            CUPManoObra = CostoUnitarioPromedioManoObra;
            dtgValuaciónInvFinal.Rows[1].Cells[2].Value = CUPManoObra;
            ManoObraTotal = ManoObraUnidadesEquivalentes * CUPManoObra;
            dtgValuaciónInvFinal.Rows[1].Cells[3].Value = ManoObraTotal;
            GFabricacionUnidadesEquivalentes = PEGFabricacion;
            dtgValuaciónInvFinal.Rows[2].Cells[1].Value = GFabricacionUnidadesEquivalentes;
            CUPGFabricacion = CostoUnitarioPromedioGFabricacion;
            dtgValuaciónInvFinal.Rows[2].Cells[2].Value = CUPGFabricacion;
            GFabricacionTotal = GFabricacionUnidadesEquivalentes * CUPGFabricacion;
            dtgValuaciónInvFinal.Rows[2].Cells[3].Value = GFabricacionTotal;
            SumaTotalIF = MaterialesTotal + ManoObraTotal + GFabricacionTotal;
            dtgValuaciónInvFinal.Rows[3].Cells[3].Value = SumaTotalIF; 

            tabTabla.TabPages[2].Controls.Add(dtgValuaciónInvFinal);
        }

       
        private void btncalcular2_Click(object sender, EventArgs e)
        {
            TotalMaterialesCU = InventarioInicialMateriales + MaaterialesCostoIncurrido;
            dtgCostosUniPromedio.Rows[0].Cells[3].Value = TotalMaterialesCU;
            InventarioInicial2Materiales = PEMateriales2;
            dtgCostosUniPromedio.Rows[0].Cells[4].Value = InventarioInicial2Materiales;
            ProduccionPorocesadaMateriales = PPMateriales;
            dtgCostosUniPromedio.Rows[0].Cells[5].Value = ProduccionPorocesadaMateriales;
            Total2MaterialesCU = InventarioInicial2Materiales + ProduccionPorocesadaMateriales;
            dtgCostosUniPromedio.Rows[0].Cells[6].Value = Total2MaterialesCU;
            CostoUnitarioPromedioMateriales = TotalMaterialesCU / Total2MaterialesCU;
            dtgCostosUniPromedio.Rows[0].Cells[7].Value = CostoUnitarioPromedioMateriales;
            TotalManoObra = InventarioInicialManoObra + CostoIncurridoManoObra;
            dtgCostosUniPromedio.Rows[1].Cells[3].Value = TotalManoObra;
            InventarioInicial2ManoObra = PEManoObra2;
            dtgCostosUniPromedio.Rows[1].Cells[4].Value = InventarioInicial2ManoObra;
            ProduccionProcesadaManoObra = PPManoObra;
            dtgCostosUniPromedio.Rows[1].Cells[5].Value = ProduccionProcesadaManoObra;
            Total2ManoObra = InventarioInicial2ManoObra + ProduccionProcesadaManoObra;
            dtgCostosUniPromedio.Rows[1].Cells[6].Value = Total2ManoObra;
            CostoUnitarioPromedioManoObra = TotalManoObra / Total2ManoObra;
            dtgCostosUniPromedio.Rows[1].Cells[7].Value = CostoUnitarioPromedioManoObra;
            TotalGFabricacion = InventarioInicialGFabricacion + CostoIncurridoGFabricacion;
            dtgCostosUniPromedio.Rows[2].Cells[3].Value = TotalGFabricacion;
            InventarioInicial2GFabricacion = PEGFabricacion2;
            dtgCostosUniPromedio.Rows[2].Cells[4].Value = InventarioInicial2GFabricacion;
            ProduccionProcesadaGFabricacion = PPGFabricacion;
            dtgCostosUniPromedio.Rows[2].Cells[5].Value = ProduccionProcesadaGFabricacion;
            Total2GFabricacion = InventarioInicial2GFabricacion + ProduccionProcesadaGFabricacion;
            dtgCostosUniPromedio.Rows[2].Cells[6].Value = Total2GFabricacion;
            CostoUnitarioPromedioGFabricacion = TotalGFabricacion / Total2GFabricacion;
            dtgCostosUniPromedio.Rows[2].Cells[7].Value = CostoUnitarioPromedioGFabricacion;
            SumaCosto = TotalMaterialesCU + TotalManoObra + TotalGFabricacion;
            dtgCostosUniPromedio.Rows[3].Cells[3].Value = SumaCosto;
           
            tabTabla.TabPages[1].Controls.Add(dtgCostosUniPromedio);
        }


        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add();  // Agrega la primera fila
            dataGridView1.Rows.Add();  // Agrega la segunda fila
            dataGridView1.Rows.Add();  // Agrega la tercera fila
            dataGridView1.Rows[0].Cells[0].Value = "Materiales";
            dataGridView1.Rows[1].Cells[0].Value = "Mano de Obra";
            dataGridView1.Rows[2].Cells[0].Value = "G. Fabricación";
            dtgCostosUniPromedio.Rows.Add();
            dtgCostosUniPromedio.Rows.Add();
            dtgCostosUniPromedio.Rows.Add();
            dtgCostosUniPromedio.Rows.Add();
            dtgCostosUniPromedio.Rows[0].Cells[0].Value = "Materiales";
            dtgCostosUniPromedio.Rows[1].Cells[0].Value = "Mano de Obra";
            dtgCostosUniPromedio.Rows[2].Cells[0].Value = "G. Fabricación";
            dtgCostosUniPromedio.Rows[3].Cells[0].Value = "Suma Costos";
            dtgValuaciónInvFinal.Rows.Add();
            dtgValuaciónInvFinal.Rows.Add();
            dtgValuaciónInvFinal.Rows.Add();
            dtgValuaciónInvFinal.Rows.Add();
            dtgValuaciónInvFinal.Rows[0].Cells[0].Value = "Materiales";
            dtgValuaciónInvFinal.Rows[1].Cells[0].Value = "Mano de Obra";
            dtgValuaciónInvFinal.Rows[2].Cells[0].Value = "G.Fabricación";
            dtgValuaciónInvFinal.Rows[3].Cells[0].Value = "";
            dtgValuacionProducTerminada.Rows.Add();
            dtgValuacionProducTerminada.Rows.Add();
            dtgValuacionProducTerminada.Rows.Add();
            dtgValuacionProducTerminada.Rows.Add();
            dtgValuacionProducTerminada.Rows[0].Cells[0].Value = "Materiales";
            dtgValuacionProducTerminada.Rows[1].Cells[0].Value = "Mano de Obra";
            dtgValuacionProducTerminada.Rows[2].Cells[0].Value = "G. Fabricación";
            dtgValuacionProducTerminada.Rows[3].Cells[0].Value = "";


            //dataGridView1.Rows[0].Cells[4].Value = "G. Fabricación";
            dataGridView1.CellEndEdit += (sender, e) =>
            {
                int fila = e.RowIndex;
                int columna = e.ColumnIndex;

                if (columna == 1)
                {
                    DataGridViewCell cell = dataGridView1.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float doble))
                    {
                        switch (fila)
                        {
                            case 0:
                                PTMateriales = doble;
                                break;
                            case 1:
                                PTManoObra = doble;
                                break;
                            case 2:
                                PTGfabricacion = doble;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }
                }
            };

            // Agregar el DataGridView al formulario
            this.Controls.Add(dataGridView1);

            dataGridView1.CellEndEdit += (sender, e) =>
            {
                int fila = e.RowIndex;
                int columna = e.ColumnIndex;

                if (columna == 2)
                {
                    DataGridViewCell cell = dataGridView1.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float doble))
                    {
                        switch (fila)
                        {
                            case 0:
                                ProcesoMateriales = doble;
                                break;
                            case 1:
                                ProcesoManoObra = doble;
                                break;
                            case 2:
                                ProcesoGFabricacion = doble;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }
                }
            };

            // Agregar el DataGridView al formulario
            this.Controls.Add(dataGridView1);
           
            dataGridView1.CellEndEdit += (sender, e) =>
            {
                int fila = e.RowIndex;
                int columna = e.ColumnIndex;

                if (columna == 3)
                {
                    DataGridViewCell cell = dataGridView1.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float doble))
                    {
                        switch (fila)
                        {
                            case 0:
                                AvanceMateriales = doble;
                                break;
                            case 1:
                                AvanceManoObra = doble;
                                break;
                            case 2:
                                AvanceGfabricacion = doble;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }
                }
            };

            // Agregar el DataGridView al formulario
            this.Controls.Add(dataGridView1);

            dataGridView1.CellEndEdit += (sender, e) =>
            {
                int fila = e.RowIndex;
                int columna = e.ColumnIndex;

                if (columna == 5)
                {
                    DataGridViewCell cell = dataGridView1.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float doble))
                    {
                        switch (fila)
                        {
                            case 0:
                                ProcesoMateriales2 = doble;
                                break;
                            case 1:
                                ProcesoManoObra2 = doble;
                                break;
                            case 2:
                                ProcesoGFabricacion2 = doble;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }
                }
            };
            // Agregar el DataGridView al formulario
            this.Controls.Add(dataGridView1);

            dataGridView1.CellEndEdit += (sender, e) =>
            {
                int fila = e.RowIndex;
                int columna = e.ColumnIndex;

                if (columna == 6)
                {
                    DataGridViewCell cell = dataGridView1.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float doble))
                    {
                        switch (fila)
                        {
                            case 0:
                                AvanceMateriales2 = doble;
                                break;
                            case 1:
                                AvanceManoObra2 = doble;
                                break;
                            case 2:
                                AvanceGFabricacion2 = doble;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }
                }
            };

            dtgCostosUniPromedio.CellEndEdit += (sender, e) =>
            {
                int fila = e.RowIndex;
                int columna = e.ColumnIndex;
                

                if (columna == 1)
                {
                    DataGridViewCell cell = dtgCostosUniPromedio.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float doble))
                    {
                        switch (fila)
                        {
                            case 0:
                                InventarioInicialMateriales = doble;
                                break;
                            case 1:
                                InventarioInicialManoObra = doble;
                                break;
                            case 2:
                                InventarioInicialGFabricacion = doble;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }
                }
                else if (columna == 2)
                {
                    DataGridViewCell cell = dtgCostosUniPromedio.Rows[fila].Cells[columna];
                    string valorTexto = cell.Value?.ToString();

                    if (float.TryParse(valorTexto, out float doble))
                    {
                        switch (fila)
                        {
                            case 0:
                                MaaterialesCostoIncurrido = doble;
                                break;
                            case 1:
                                CostoIncurridoManoObra = doble;
                                break;
                            case 2:
                                CostoIncurridoGFabricacion = doble;
                                break;
                                // Añade más casos para manejar otras filas si es necesario
                        }
                    }
                    else
                    {
                        // Maneja aquí el caso en el que la entrada no sea un entero válido
                    }
                }
               
               
            };


            // Agregar el DataGridView al formulario
            this.Controls.Add(dataGridView1);
            tabTabla.TabPages[0].Controls.Add(dataGridView1);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            
           
            PEMateriales = ProcesoMateriales * AvanceMateriales;
            dataGridView1.Rows[0].Cells[4].Value = PEMateriales;
            PEManoObra = ProcesoManoObra * AvanceManoObra;
            dataGridView1.Rows[1].Cells[4].Value = PEManoObra;
            PEGFabricacion = ProcesoGFabricacion * AvanceGfabricacion;
            dataGridView1.Rows[2].Cells[4].Value = PEGFabricacion;
            PEMateriales2 = ProcesoMateriales2 * AvanceMateriales2;
            dataGridView1.Rows[0].Cells[7].Value = PEMateriales2;
            PEManoObra2 = ProcesoManoObra2 * AvanceManoObra2;
            dataGridView1.Rows[1].Cells[7].Value = PEManoObra2;
            PEGFabricacion2 = ProcesoGFabricacion2 * AvanceGFabricacion2;
            dataGridView1.Rows[2].Cells[7].Value = PEGFabricacion2;
            PPMateriales = PTMateriales + PEMateriales - PEMateriales2;
            dataGridView1.Rows[0].Cells[8].Value = PPMateriales;
            PPManoObra = PTManoObra + PEManoObra - PEManoObra2;
            dataGridView1.Rows[1].Cells[8].Value = PPManoObra;
            PPGFabricacion = PTGfabricacion + PEGFabricacion - PEGFabricacion2;
            dataGridView1.Rows[2].Cells[8].Value = PPGFabricacion;
            this.Controls.Add(dataGridView1);
            tabTabla.TabPages[0].Controls.Add(dataGridView1);


        }
        
    }
}
