using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfControlsAndStuffOct23
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
    }


    //internal class ValueMinMaxToPointConverter5 : IMultiValueConverter
    //{
    //    public object Convert ( object [] values, Type targetType, object parameter, CultureInfo culture )
    //    {
    //        double value = (double)values [0];
    //        double minimum = (double)values [1];
    //        double maximum = (double)values [2];

    //        //  Convert value to 0 - 360.
    //        double current = (value / (maximum - minimum)) * 360;
    //        //  For a complete circle.
    //        if (current == 360)
    //            current = 359.999;
    //        //  Shift by 90 degrees, so zero is up.
    //        current = current - 90;
    //        //  Convert to radians.
    //        current = current * .0174532925199;
    //        //  Calculate the circle's point.
    //        double x = 10 + 10 * Math.Cos ( current );
    //        double y = 10 + 10 * Math.Sin ( current );
    //        return new Point ( x, y );

    //    }

    //    public object [] ConvertBack ( object value, Type [] targetTypes, object parameter, CultureInfo culture )
    //    {
    //        throw new NotImplementedException ();
    //    }
    //}
}
