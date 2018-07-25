using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ScrollBarCustomisation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.Items.Add("A");
            this.Items.Add("B");
            this.Items.Add("C");
            this.Items.Add("D");
            this.Items.Add("E");
            this.Items.Add("F");
            this.Items.Add("G");
            this.Items.Add("H");
            this.Items.Add("I");
            this.Items.Add("J");
            this.Items.Add("K");
            this.Items.Add("L");
            this.Items.Add("M");
            this.Items.Add("N");
            this.Items.Add("O");
            this.Items.Add("P");
            this.Items.Add("Q");
            this.Items.Add("R");
            this.Items.Add("S");
            this.Items.Add("T");
            this.Items.Add("U");
            this.Items.Add("V");
            this.Items.Add("W");
            this.Items.Add("X");
            this.Items.Add("Y");
            this.Items.Add("Z");

            //master
        }

        public List<string> Items = new List<string>();
    }
}
