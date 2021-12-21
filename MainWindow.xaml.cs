using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab04___WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public class MetricUnit
    {
        public double Unit { set; get;}
        public double FootToMetr()
        {
            return Unit * 0.3048;
        }
        public double InchToMetr()
        {
            return FootToMetr()/12;
        }
        public double MileToMetr()
        {
            return 5280 * FootToMetr();
        }
        public double VerstaToMetr()
        {
            return Unit * 1066.8;
        }
    }
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private double inDataConvert(TextBox data)
        {
            double res;
            try
            {
                res = Convert.ToDouble(data.Text);
            }
            catch
            {
                res = 0;
            }
            return res;
        }
        private void CalcSum(TextBox rate, TextBox sum, TextBox res)
        {
            double rateValuta, sumValuta;
            rateValuta = inDataConvert(rate);
            sumValuta = inDataConvert(sum);

            double resValuta = rateValuta * sumValuta;
            res.Text = resValuta.ToString();
        }

        private void Button_Click_Dollar(object sender, RoutedEventArgs e)
        {
            CalcSum(rateD, sumD, resSumD);
        }

        private void Button_Click_Evro(object sender, RoutedEventArgs e)
        {
            CalcSum(rateE, sumE, resSumE);
        }

        private void Button_Click_Grivna(object sender, RoutedEventArgs e)
        {
            CalcSum(rateG, sumG, resSumG);
        }

        private void Button_Click_Drama(object sender, RoutedEventArgs e)
        {
            CalcSum(rateDr, sumDr, resSumDr);
        }

        private void Button_Click_Inch(object sender, RoutedEventArgs e)
        {
            MetricUnit calc = new MetricUnit();
            calc.Unit = inDataConvert(inchTxt);
            resInch.Text = calc.InchToMetr().ToString();
        }

        private void Button_Click_Foot(object sender, RoutedEventArgs e)
        {
            MetricUnit calc2 = new MetricUnit();
            calc2.Unit = inDataConvert(footTxt);
            resFoot.Text = calc2.FootToMetr().ToString();
        }

        private void Button_Click_Miles(object sender, RoutedEventArgs e)
        {
            MetricUnit calc3 = new MetricUnit();
            calc3.Unit = inDataConvert(mileTxt);
            resMile.Text = calc3.MileToMetr().ToString();
        }

        private void Button_Click_Versta(object sender, RoutedEventArgs e)
        {
            MetricUnit calc4 = new MetricUnit();
            calc4.Unit = inDataConvert(verstTxt);
            resVersta.Text = calc4.VerstaToMetr().ToString();
        }
    }
}
