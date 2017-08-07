using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ARGBColorHelper
{
    class CustomColorView : INotifyPropertyChanged
    {
        private Color customColor;

        public Color CustomColor
        {
            get { return customColor; }
            set
            { customColor = value; }
        }

        public SolidColorBrush CustomBrush { get; set; }

        public CustomColorView()
        {
            CustomBrush = new SolidColorBrush()
            {
                Color = CustomColor
            };
        }


        public byte A
        {
            get { return CustomColor.A; }
            set
            {
                customColor.A = value;
                ChangeColor();
            }
        }

        public byte R
        {
            get { return CustomColor.R; }
            set
            {
                customColor.R = value;
                ChangeColor();
            }
        }

        public byte G
        {
            get { return CustomColor.G; }
            set
            {
                customColor.G = value;
                ChangeColor();
            }
        }

        public byte B
        {
            get { return CustomColor.B; }
            set
            {
                customColor.B = value;
                ChangeColor();
            }
        }

        public void ChangeColor()
        {
            CustomBrush.Color = CustomColor;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomBrush"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
