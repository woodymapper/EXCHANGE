using System.Xml.Linq;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<string,float> _rates = new Dictionary<string,float>();



        private void pobierz_Click(object sender, EventArgs e)
        {
            XDocument api = XDocument.Load("http://api.nbp.pl/api/exchangerates/tables/a/?format=xml");

            // DebugWindow.Text = api.ToString();

            var rates = api.Descendants("Rate");
            _rates.Clear();
        
        foreach (var rate in rates)
            {
                string code =  rate.Element("Code").Value;
                float mid = float.Parse(rate.Element("Mid").Value, System.Globalization.CultureInfo.InvariantCulture);


                _rates.Add(code, mid);

            }

            //DebugWindow.Text = _rates.ToString();

            USDTextBox.Text = _rates["USD"].ToString();
            EURTextBox.Text = _rates["EUR"].ToString();
            HUFTextBox.Text = _rates["HUF"].ToString();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3HUN_Click(object sender, EventArgs e)
        {

        }

        private void Exchange(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            string code = radio.Text;
                float pln = float.Parse(textBox1.Text);
            float exchanged = pln / _rates[code];
            TextCount.Text = exchanged.ToString();
        }
    }
}