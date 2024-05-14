using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SignalSimulatorWinForm;

public partial class Form1 : Form
{
    double omega_0 = 1;
    double delta_t = 0.01;
    double N = 1000;
    int NMax = 2;
    double a0 = 1;
    double[] aValues;
    double[] bValues;
    List<TextBox> aTextBoxes = new List<TextBox>();
    List<TextBox> bTextBoxes = new List<TextBox>();



    public Form1()
    {
        InitializeComponent();
        aTextBoxes.Add(txt_a1);
        bTextBoxes.Add(txt_b1);
        aValues = new double[NMax + 1];
        bValues = new double[NMax + 1];


    }
    private void Form1_Load(object sender, EventArgs e)
    {
        txt_omega.Text = omega_0.ToString();
        txt_nmax.Text = NMax.ToString();
        txt_delta.Text = delta_t.ToString();
        txt_a0.Text = a0.ToString();
        txt_N.Text = N.ToString();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }
    private void button1_Click(object sender, EventArgs e)
    {
        UpdateABValues();
        List<PointData> points = new List<PointData>();
        try
        {
            using (StreamWriter outputFile = new StreamWriter("output.dat"))
            {
                for (int i = 1; i <= N; i++)
                {
                    double x = i * delta_t;
                    double y_value = FourierSeries(i, a0, aValues.ToList(), bValues.ToList(), NMax);
                    points.Add(new PointData { X = x, Y = y_value });

                    outputFile.WriteLine(x + " " + y_value);
                }
                string json = JsonConvert.SerializeObject(points);

                File.WriteAllText("output.json", json);
            }

            RedrawDiagram(points);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error writing to output.dat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
    }


    private TextBox CreateTextBox(string name)
    {
        TextBox textBox = new TextBox();
        textBox.Name = name;
        textBox.ForeColor = Color.Black;
        textBox.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, (byte)(0));
        textBox.Width = 150;
        textBox.Height = 50;
        textBox.Size = new Size(125, 35);
        return textBox;
    }
    int DisUnit = 1;
    private void button2_Click(object sender, EventArgs e)
    {
        TextBox txtA = CreateTextBox("txt_a" + (DisUnit + 1));
        TextBox txtB = CreateTextBox("txt_b" + (DisUnit + 1));
        this.Controls.Add(txtA);
        txtA.Location = new Point(txt_a1.Location.X, txt_a1.Location.Y + DisUnit * 50 + 50); // Position a2 textbox below default textbox
        txtA.ForeColor = Color.Black;
        txtA.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, (byte)(0));
        txtA.Width = 150;
        txtA.Height = 50;
        txtA.Size = new Size(125, 35);
        Label labelA = new Label();
        int labelOffset = 2;
        labelA.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular);

        labelA.Text = "A" + (DisUnit + 1); // Increment DisUnit by 1 for 1-based indexing
        labelA.Location = new Point(txtA.Location.X + txtA.Width / 2, txtA.Location.Y - labelA.Height - labelOffset);
        this.Controls.Add(labelA);
        this.Controls.Add(txtB);
        txtB.Location = new Point(txt_b1.Location.X, txt_b1.Location.Y + DisUnit * 50 + 50); // Position b2 textbox below a2 textbox
        txtB.ForeColor = Color.Black;
        txtB.Font = new Font("Agency FB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, (byte)(0));
        txtB.Width = 150;
        txtB.Height = 50;
        txtB.Size = new Size(125, 35);
        Label labelB = new Label();
        labelB.Font = new Font("Berlin Sans FB", 14.25F, FontStyle.Regular);
        labelB.Text = "B" + (DisUnit + 1); // Increment DisUnit by 1 for 1-based indexing
        labelB.Location = new Point(txtB.Location.X + txtB.Width / 2, txtB.Location.Y - labelB.Height - labelOffset); // Position label above txtB
        this.Controls.Add(labelB);
        double.TryParse(txtA.Text, out aValues[DisUnit - 1]); // Update aValues array
        double.TryParse(txtB.Text, out bValues[DisUnit - 1]);
        aTextBoxes.Add(txtA);
        bTextBoxes.Add(txtB);
        DisUnit++;

        if (DisUnit >= 5)
        {
            MessageBox.Show("Maximum limit reached. Cannot add more.");
            button2.Enabled = false;
            return;
        }

        UpdateABValues();
    }

    private void UpdateABValues()
    {
        for (int i = 0; i < aTextBoxes.Count; i++)
        {
            double.TryParse(aTextBoxes[i].Text, out aValues[i]);
            double.TryParse(bTextBoxes[i].Text, out bValues[i]);
        }
    }
    //private double An(int n)
    //{
    //    double sum = 0.0;
    //    for (int i = 0; i < aValues.Length; i++)
    //    {
    //        sum += aValues[i] * Math.Cos(n * omega_0 * (i + 1) * delta_t);
    //    }
    //    return (2.0 / N) * sum;
    //}

    // Method to calculate Fourier series coefficient b_n
    //private double Bn(int n)
    //{
    //    double sum = 0.0;
    //    for (int i = 0; i < bValues.Length; i++)
    //    {
    //        sum += bValues[i] * Math.Sin(n * omega_0 * (i + 1) * delta_t);
    //    }
    //    return (2.0 / N) * sum;
    //}


    private double FourierSeries(int i, double a0, List<double> a, List<double> b, int n_max)
    {
        double result = a0 / 2.0;
        for (int n = 1; n <= n_max; n++)
        {
            result += a[n - 1] * Math.Cos(n * omega_0 * i * delta_t) + b[n - 1] * Math.Sin(n * omega_0 * i * delta_t);
        }
        return result;
    }
    private void txt_b1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
        List<PointData> points = ReadPointsFromJson("output.json");
        RedrawDiagram(points);
    }

    private List<PointData> ReadPointsFromJson(string fileName)
    {
        List<PointData> points = new List<PointData>();

        try
        {
            string json = File.ReadAllText(fileName);
            points = JsonConvert.DeserializeObject<List<PointData>>(json);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error reading from " + fileName + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return points;
    }
    private void RedrawDiagram(List<PointData> points)
    {
        try
        {
            // Save the points to a temporary file
            string dataFilePath = "output_temp.dat";
            using (StreamWriter writer = new StreamWriter(dataFilePath))
            {
                foreach (var point in points)
                {
                    writer.WriteLine($"{point.X} {point.Y}");
                }
            }

            // Generate Gnuplot script
            string scriptFilePath = "plot_script.gnu";
            using (StreamWriter writer = new StreamWriter(scriptFilePath))
            {
                writer.WriteLine("set term wxt");
                writer.WriteLine("plot '" + dataFilePath + "' with lines");
                writer.WriteLine("pause mouse close");
            }

            // Launch Gnuplot process
            ProcessStartInfo startInfo = new ProcessStartInfo("gnuplot")
            {
                Arguments = scriptFilePath,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process gnuplotProcess = new Process();
            gnuplotProcess.StartInfo = startInfo;
            gnuplotProcess.Start();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error redrawing diagram: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


}

