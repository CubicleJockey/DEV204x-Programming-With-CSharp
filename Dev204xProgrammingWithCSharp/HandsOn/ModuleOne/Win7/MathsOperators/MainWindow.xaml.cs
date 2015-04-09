using System;
using System.Windows;

namespace MathsOperators
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)addition.IsChecked)
                {
                    addValues();
                }
                else if ((bool)subtraction.IsChecked)
                {
                    subtractValues();
                }
                else if ((bool)multiplication.IsChecked)
                {
                    multiplyValues();
                }
                else if ((bool)division.IsChecked)
                {
                    divideValues();
                }
                else if ((bool)remainder.IsChecked)
                {
                    remainderValues();
                }
            }
            catch (Exception caught)
            {
                expression.Text = string.Empty;
                result.Text = caught.Message;
            }
        }

        private void addValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = (lhs + rhs);
            // TODO: Add rhs to lhs and store the result in outcome
            
            expression.Text = lhsOperand.Text + " + " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void subtractValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = (lhs - rhs);
            // TODO: Subtract rhs from lhs and store the result in outcome
            
            expression.Text = lhsOperand.Text + " - " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void multiplyValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = (lhs * rhs);
            // TODO: Multiply lhs by rhs and store the result in outcome
            
            expression.Text = lhsOperand.Text + " * " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void divideValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = (lhs / rhs);
            // TODO: Divide lhs by rhs and store the result in outcome
            
            expression.Text = lhsOperand.Text + " / " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void remainderValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = (lhs % rhs);
            // TODO: Work out the remainder after dividing lhs by rhs and store the result in outcome
            
            expression.Text = lhsOperand.Text + " % " + rhsOperand.Text;
            result.Text = outcome.ToString();
        }

        private void quitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
