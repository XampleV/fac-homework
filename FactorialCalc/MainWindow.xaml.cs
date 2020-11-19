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

namespace FactorialCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void xCalculateBtn_Click(object sender, RoutedEventArgs e)
        {

            Factorial();
            Permutations();
            Combinations();
        }

        public void Factorial()
        {
            double number = 0;
            int factorial = 1;
            Double.TryParse(xNumber.Text, out number);

            // Forumala to determine Factorial
            for (int x = 1; x <= number; x++)
            {
                factorial = factorial * x;
            }

            // Display Answer
            xResponeBlock.Text = ($"{number}! =");
            xResponeBlock.FontSize = 24;
            xAnswerBlock.Text = factorial.ToString();
        }



        public void Permutations()
        {
            //TODO: Write Formulate to out put the permutation of 2 numbers. Be sure to utilize the code from the Factorial() above to help you solve the problem. 
            double num = 0;
            double r = 0;
            double top;
            Double.TryParse(xNObjects.Text, out num);
            top = num;
            Double.TryParse(xRSample.Text, out r);
            for (int x = 1; x < num; x++)
            {
                top = top * x;
            }
            double toF = num - r;
            for (int y = 1; y < toF; y++)
            {
                toF = toF * y;
            }
            double final = top / toF;
            xPermutationAnswer.Text = (final.ToString());
        }


    public double fac(double number)
        {
            int facc = 1;
            for (int x = 1; x <= number; x++)
            {
                facc = facc * x;
            }
            return facc;


        }

        public void Combinations()
        {
            //TODO: Write Formulate to out put the combination of 2 numbers. Be sure to utilize the code from the Factorial() above to help you solve the problem.\
            double num = 0;
            double r = 0;
            Double.TryParse(xNObjects.Text, out num);
            Double.TryParse(xRSample.Text, out r);
            double toF = num - r;

            double nf = fac(num);
            double rf = fac(r);
            double mf = fac(toF);

            double final = nf / (rf * mf);



            xCombinationAnswer.Text = (final.ToString());
            //




        }



        private void xExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
