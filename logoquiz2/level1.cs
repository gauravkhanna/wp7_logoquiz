using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace logoquiz2
{
    public class globalapplication
    {
        public static bool isdark;
        public globalapplication()
        {
            isdark = true;
        }
    }
    public class logos_each
    {
        public int check;
        public string mains;
        public string[] answer;
        public string[] hints;
        public string throaway;
        public string more;
        public static int current;
    }
    
}
