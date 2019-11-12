
using System.Windows;
using System.Windows.Media;



namespace AlyTaloSovellus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Valot valot = new Valot();
        public SaunaStatus sauna = new SaunaStatus();
        public TermostaattiStatus maxTemp = new TermostaattiStatus();
        
        public MainWindow()
        {
            InitializeComponent();

           
        }

        public void btnOnOLohuone_Click(object sender, RoutedEventArgs e)
        {
            valot.setValoOnTrue();
            if (valot.valoOn == true)
            {
                btnOlohuoneValo.Background = Brushes.PaleGreen;
            }
           
            
        }

        public void btnOffOLohuone_Click(object sender, RoutedEventArgs e)
        {
            valot.setValoOff();
            if (valot.valoOn == false)
            {
                btnOlohuoneValo.Background = Brushes.Gray;
            }

            
        }

        public void btnOnKeitio_Click(object sender, RoutedEventArgs e)
        {
            
            valot.setValoOnTrue();

            if (valot.valoOn == true)
            { 
                btnKeitioValo.Background = Brushes.PaleGreen;
            }
           
            
        }

        public void btnOffKeitio_Click(object sender, RoutedEventArgs e)
        {
            
            valot.setValoOff();
            if (valot.valoOn == false)
            {
                btnKeitioValo.Background = Brushes.Gray;
            }

            
        }

        public void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtSlider1.Text = slider1.Value.ToString();

            if (slider1.Value > 0)
            {
                btnOlohuoneValo.Background = Brushes.PaleGreen;
            }
            else
            {
                btnOlohuoneValo.Background = Brushes.Gray;
            }
        }

        public void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtSlider2.Text = slider2.Value.ToString();

            if (slider2.Value > 0)
            {
                btnKeitioValo.Background = Brushes.PaleGreen;
            }
            else
            {
                btnKeitioValo.Background = Brushes.Gray;
            }
        }
        public void btnOnSauna_Click(object sender, RoutedEventArgs e)
        {
            sauna.setSaunaOnTrue();

            cgcSauna.CurrentValue = 80;

            btnValoSauna.Background = Brushes.PaleGreen;

            txtSauna.Text = "Sauna on päällä!";
                                             
        }

        public void btnOffSauna_Click(object sender, RoutedEventArgs e)
        {
            sauna.setSaunaOff();

            cgcSauna.CurrentValue = 20;

            btnValoSauna.Background = Brushes.Gray;
           
            txtSauna.Text = "";

        }

        public void btnVaihdaLampo_Click(object sender, RoutedEventArgs e)
        {
            txtlampo1.Text = txtlampo2.Text;
            txtlampo2.Text = "0";
          
        }

        public void cgcSauna_Loaded(object sender, RoutedEventArgs e)
        {
            cgcSauna.MaxValue = 100;
            cgcSauna.MinValue = 0;

        }

    }
}


