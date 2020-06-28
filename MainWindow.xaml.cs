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

namespace CompilerDesign
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

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Consists of a finite set of states with a set of transitions from state to state, for each input symbol there is exactly one transition out of each state");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Practice design problems ");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Remove redundancy amongst non final states");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NFA  DFA except each input symbol there is zero, one or more than one transition out of each state from Input symbol a:  Q0 -> Q1 & Q0->Q2 ");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Finite state machines with output  Moore and Mealy Machine ");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Regular expressions : Union, Concatination, and Closure ");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pumping Lemma : Regular language,   ");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Context free grammaer G=(V,T,P,S) , V: finite set of non terminals(variables), T finite set of terminals, P: finite set of production, S : start symbol ");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Push down automata, DFA + stack , use epsilon with symbol for push and pop ");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Turing Machine   ");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Universal Turing machine, Enumeration machine, halting problems ");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Linear Bound Automata ");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Transition is acceptable for symbol epsilon, you can combine FSA ");
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Convert CFG to Chomsky Normal form ");
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" The set of languages which are used by a turing machine is called RE languages ");
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("  Chomsky hierarchy  ");
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
