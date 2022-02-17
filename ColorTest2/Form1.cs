namespace ColorTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertTemperature(object sender, EventArgs e)
        {
            var minTemperature = double.Parse(minTempTb.Text);
            var maxTemperature = double.Parse(maxTempTb.Text);

            var currentTemp = double.Parse(temperatureTb.Text);


            //Semplificazione da 0 a 200 gradi, serve rendere l'intervallo minTemp / maxTemp in 
            //un range 0 / 1
            var currentPerc = 1 - currentTemp / 200;

            percentageTb.Text = currentPerc + "%";

            hslTb.Text = $"hsl({currentPerc}, 100%, 50%)";

            var hsl = new Colors.HSL((int)Math.Floor(currentPerc * 240), 1.0f, 0.5f);

            var rgb = Colors.HSLToRGB(hsl);

            rgbTb.Text = $"{rgb.R} | {rgb.G} | {rgb.B}";
            rgbTb.BackColor = Color.FromArgb(rgb.R, rgb.G,rgb.B);
        }
    }
}