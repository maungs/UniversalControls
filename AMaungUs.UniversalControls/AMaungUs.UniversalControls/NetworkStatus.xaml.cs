using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace AMaungUs.UniversalControls
{
    public sealed partial class NetworkStatus : UserControl
    {
        public NetworkStatus()
        {
            this.InitializeComponent();
        }

        private bool _IsActive;

        public bool IsActive
        {
            get
            {
                if (_IsActive == false)
                    txtIP.Foreground = new SolidColorBrush(Colors.SlateGray);
                txtSymbol.Foreground = new SolidColorBrush(Colors.SlateGray);
                return _IsActive;
            }
            set
            {
                _IsActive = value;
                if (_IsActive)
                {
                    txtIP.Foreground = new SolidColorBrush(Colors.GreenYellow);
                    txtSymbol.Foreground = new SolidColorBrush(Colors.GreenYellow);
                }
                else
                {
                    txtIP.Foreground = new SolidColorBrush(Colors.SlateGray);
                    txtSymbol.Foreground = new SolidColorBrush(Colors.SlateGray);
                }
            }
        }

        private string _IPAddress;

        public string IPAddress
        {
            get { return _IPAddress; }
            set
            {
                _IPAddress = value;
                txtIP.Text = _IPAddress;
            }
        }
    }
}
