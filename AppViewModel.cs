using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmTester
{

    public class AppViewModel : ObservableObject
    {
        public AppViewModel() {}

        private System.Drawing.Color myColor = System.Drawing.Color.Red;
       
        public System.Drawing.Color MyColor
        {
            get => myColor;
            set => SetProperty(ref myColor, value);

        }

        private System.Windows.Media.Color myNewColor = System.Windows.Media.Colors.Lime;

        public System.Windows.Media.Color MyNewColor 
        {
            get => myNewColor;
            set => SetProperty(ref myNewColor, value);  
        }

    }
}
