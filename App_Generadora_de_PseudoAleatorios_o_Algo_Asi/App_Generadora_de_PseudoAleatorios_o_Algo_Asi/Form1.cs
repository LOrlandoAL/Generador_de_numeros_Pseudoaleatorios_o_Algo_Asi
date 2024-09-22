using MathNet.Numerics.Distributions;
using MathNet.Numerics.Statistics;

namespace App_Generadora_de_PseudoAleatorios_o_Algo_Asi
{
    public partial class Form1 : Form
    {
        public List<Double> random = new List<Double>();
        public Form1()
        {
            InitializeComponent();
            lblProdMedSemilla2.Visible = false;
            txtProdMedSemilla2.Visible = false;
            txtConstante.Visible = false;
            lblConstante.Visible = false;
        }

        private void btnGenerarPseudo_Click(object sender, EventArgs e)
        {
            if (rdbCuaMed.Checked)
            {
                CuadradosMedios();
                realizarPruebas();
            }
            else if (rdbProMe.Checked)
            {
                ProductosMedios();
                realizarPruebas();
            }
            else if (rdbMulCons.Checked)
            {
                MultiplicadorConstante();
                realizarPruebas();
            }
        }

        private void CuadradosMedios()
        {
            try
            {
                int semilla = Convert.ToInt32(txtSemillaGen.Text);
                int tamSemilla = txtSemillaGen.Text.Length;
                int cantidad = (int)npdCuantosNum.Value;

                int[] numGenerados = new int[cantidad];

                if (tamSemilla <= 3)
                {
                    MessageBox.Show("La semilla debe tener más de 3 dígitos.");
                    return;
                }

                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad de números pseudoaleatorios que se quiere generar debe ser mayor a 0");
                    return;
                }

                random.Clear();

                for (int i = 0; i < cantidad; i++)
                {
                    long semCuadrada = (long)semilla * semilla;
                    string cuadradoStr = semCuadrada.ToString();
                    int tamCuadSem = cuadradoStr.Length;

                    int posicionInicio = (tamCuadSem - tamSemilla) / 2;

                    if (posicionInicio < 0 || posicionInicio + tamSemilla > tamCuadSem)
                    {
                        MessageBox.Show("No se puede extraer el número de la posición calculada.");
                        return;
                    }

                    string pseudonumero = cuadradoStr.Substring(posicionInicio, tamSemilla);
                    semilla = Convert.ToInt32(pseudonumero);
                    numGenerados[i] = semilla;
                    Double guardar = semilla;
                    while (guardar > 1)
                    {
                        guardar /= 10;
                    }
                    random.Add(guardar);
                }

                txtNumGen.Text = string.Join(", ", numGenerados);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos para la semilla.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("El número ingresado es demasiado grande o pequeño.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}");
            }
        }

        private void ProductosMedios()
        {
            try
            {
                int semilla = Convert.ToInt32(txtSemillaGen.Text);
                int tamSemilla = txtSemillaGen.Text.Length;
                int semilla2 = Convert.ToInt32(txtProdMedSemilla2.Text);
                int tamSemilla2 = txtProdMedSemilla2.Text.Length;
                int cantidad = (int)npdCuantosNum.Value;
                int[] numGenerados = new int[cantidad];

                if (tamSemilla <= 3 || tamSemilla2 <= 3)
                {
                    MessageBox.Show("La semilla debe tener más de 3 dígitos.");
                    return;
                }
                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad de números pseudoaleatorios que se quiere generar debe ser mayor a 0");
                    return;
                }

                random.Clear();

                for (int i = 0; i < cantidad; i++)
                {
                    long y0 = semilla * semilla2;
                    String stry0 = y0.ToString();
                    int tamy0 = stry0.Length;

                    int posicionInicio = (tamy0 - tamSemilla) / 2;

                    if (posicionInicio < 0 || posicionInicio + tamSemilla > tamy0)
                    {
                        MessageBox.Show("No se puede extraer el número de la posición calculada.");
                        return;
                    }

                    string pseudonumero = stry0.Substring(posicionInicio, tamSemilla);
                    semilla = semilla2;
                    semilla2 = Convert.ToInt32(pseudonumero);
                    numGenerados[i] = semilla;
                    Double guardar = semilla;
                    while (guardar > 1)
                    {
                        guardar /= 10;
                    }
                    random.Add(guardar);
                }

                txtNumGen.Text = string.Join(Environment.NewLine, numGenerados);

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos para la semilla.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("El número ingresado es demasiado grande o pequeño.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}");
            }
        }

        private void MultiplicadorConstante()
        {
            try
            {
                int semilla = Convert.ToInt32(txtSemillaGen.Text);
                int tamSemilla = txtSemillaGen.Text.Length;
                int Constante = Convert.ToInt32(txtConstante.Text);
                int tamConstante = txtConstante.Text.Length;
                int cantidad = (int)npdCuantosNum.Value;
                int[] numGenerados = new int[cantidad];

                if (tamSemilla <= 3)
                {
                    MessageBox.Show("La semilla debe tener más de 3 dígitos.");
                    return;
                }
                if (tamConstante <= 3)
                {
                    MessageBox.Show("La constante debe tener más de 3 dígitos.");
                    return;
                }
                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad de números pseudoaleatorios que se quiere generar debe ser mayor a 0");
                    return;
                }

                random.Clear();

                for (int i = 0; i < cantidad; i++)
                {
                    long y0 = semilla * Constante;
                    String stry0 = y0.ToString();
                    int tamy0 = stry0.Length;

                    int posicionInicio = (tamy0 - tamSemilla) / 2;

                    if (posicionInicio < 0 || posicionInicio + tamSemilla > tamy0)
                    {
                        MessageBox.Show("No se puede extraer el número de la posición calculada.");
                        return;
                    }

                    string pseudonumero = stry0.Substring(posicionInicio, tamSemilla);
                    semilla = Convert.ToInt32(pseudonumero);
                    numGenerados[i] = semilla;
                    Double guardar = semilla;
                    while (guardar > 1)
                    {
                        guardar /= 10;
                    }
                    random.Add(guardar);
                }
                txtNumGen.Text = string.Join(Environment.NewLine, numGenerados);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos");
            }
            catch (OverflowException)
            {
                MessageBox.Show("El número ingresado es demasiado grande o pequeño.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}");
            }
        }

        private void rdbProMe_CheckedChanged(object sender, EventArgs e)
        {
            txtConstante.Visible = false;
            lblConstante.Visible = false;
            lblProdMedSemilla2.Visible = true;
            txtProdMedSemilla2.Visible = true;
        }

        private void rdbMulCons_CheckedChanged(object sender, EventArgs e)
        {
            txtConstante.Visible = true;
            lblConstante.Visible = true;
            lblProdMedSemilla2.Visible = false;
            txtProdMedSemilla2.Visible = false;
        }

        private void rdbCuaMed_CheckedChanged(object sender, EventArgs e)
        {
            lblProdMedSemilla2.Visible = false;
            txtProdMedSemilla2.Visible = false;
            txtConstante.Visible = false;
            lblConstante.Visible = false;
        }

        private void txtMedResu_TextChanged(object sender, EventArgs e)
        {

        }
        private void Media(Double porcentaje)
        {
            try
            {
                if (random.Count() <= 0)
                {
                    MessageBox.Show("Por favor, primero calcule los números aleatorios");
                    return;
                }
                Double suma = 0;
                Double porcentaje_acumulado = (((100.0 - porcentaje) / 2.0) + porcentaje) / 100.0;
                for (int i = 0; i < random.Count(); i++)
                {
                    suma += random[i];
                }
                Double media = (1.0 / random.Count()) * suma;
                Double calculo = Normal.InvCDF(0, 1, porcentaje_acumulado);
                Double limite_superior = (1.0 / 2.0) + (calculo) * (1.0 / Math.Sqrt(12 * random.Count()));
                Double limite_inferior = (1.0 / 2.0) - (calculo) * (1.0 / Math.Sqrt(12 * random.Count()));
                txtMedResu.Text = media.ToString();
                txtMedLS.Text = limite_superior.ToString();
                txtMedLI.Text = limite_inferior.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}");
            }
        }

        private void Varianza(Double porcentaje)
        {
            try
            {
                if (random.Count() <= 0)
                {
                    MessageBox.Show("Por favor, primero calcule los números aleatorios");
                    return;
                }
                Double varianza = Statistics.Variance(random);
                Double porcentaje_acumulado = (((100.0 - porcentaje) / 2.0) + porcentaje) / 100.0;
                Double limite_superior = ChiSquared.InvCDF(random.Count() - 1, porcentaje_acumulado) / (12.0 * (random.Count() - 1));
                Double limite_inferior = ChiSquared.InvCDF(random.Count() - 1, 1 - porcentaje_acumulado) / (12.0 * (random.Count() - 1));
                txtVariResul.Text = varianza.ToString();
                txtVariLS.Text = limite_superior.ToString();
                txtVariLI.Text = limite_inferior.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}");
            }
        }

        private void uniformityChecker(List<Double> numGenerados, Double porcentaje)
        {
            double porcentaje_acumulado = (((100.0 - porcentaje) / 2.0) + porcentaje) / 100.0;
            int n = numGenerados.Count, m = Convert.ToInt32(Math.Sqrt(n));
            double intervalo = 1.0 / m, inversaChi = ChiSquared.InvCDF(m - 1, porcentaje_acumulado), sumaChiCuadrado = 0.0;

            double[] limitesInferiores = new double[m], limitesSuperiores = new double[m], frecuenciasEsperadas = new double[m];
            double[] estaDisChi = new double[m];
            int[] frecuenciasObservadas = new int[m];
            
            // Calcular m Limites inferiores y superiores. //
            for (int i = 0; i < m; i++)
            {
                limitesInferiores[i] = Math.Round(i * intervalo,4);
                limitesSuperiores[i] = Math.Round((i + 1) * intervalo,4);
                frecuenciasEsperadas[i] = Math.Round((double)n / m,4);
            }
            // Contar la frecuencia de aparicion de los numeros dentro de los intervalos del row m//
            foreach (var num in numGenerados)
            {
                for (int i = 0; i < m; i++)
                {
                    if (num >= limitesInferiores[i] && num < limitesSuperiores[i])
                    {
                        frecuenciasObservadas[i]++;
                        break;
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                estaDisChi[i] = Math.Pow((frecuenciasEsperadas[i] - frecuenciasObservadas[i]), 2) / frecuenciasEsperadas[i];
                sumaChiCuadrado += estaDisChi[i];
            }

            // Agregacion de los valores calculados a la tabla. //
            dgvUniformidadRes.Rows.Clear();
            for (int i = 0; i < m; i++)
            {
                dgvUniformidadRes.Rows.Add(
                    limitesInferiores[i].ToString("F4"),
                    limitesSuperiores[i].ToString("F4"),
                    frecuenciasObservadas[i],
                    frecuenciasEsperadas[i],
                    estaDisChi[i]
                );
            }

            lblSumaChiCuadrado.Text = $"Suma Chi-Cuadrado: {sumaChiCuadrado:F4}";
            lblInversaChi.Text = $"Inversa Chi-Cuadrado: {inversaChi:F4}";
            
            // Comparación de resultados y mostracion. //
            if (sumaChiCuadrado < inversaChi)
            {
                lblResultado.Text = "No se rechaza la hipotesis nula";
                lblUniformidad.ForeColor = Color.Green;
            }
            else
            {
                lblResultado.Text = "Se rechaza la hipótesis nula.";
                lblUniformidad.ForeColor = Color.Red;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void realizarPruebas() {
            Double porcentaje = (Double)npdPorcentaje.Value;
            uniformityChecker(random, porcentaje);
            Media(porcentaje);
            Varianza(porcentaje);
        }

        private void lblCuantos_Click(object sender, EventArgs e)
        {

        }
    }
}
