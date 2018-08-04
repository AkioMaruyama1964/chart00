using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls.DataVisualization.Charting;


namespace chart00
{
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1() {
            InitializeComponent();
            showColumnChart();

            line01.DataContext = valueList01;
            line02.DataContext = valueList02;
            _chart.Title = "Hoge chart";
            //line01.DependentRangeAxis.DependentAxes.Max = 500;
        }

        public List<KeyValuePair<string, int>> valueList01 = new List<KeyValuePair<string, int>>();
        public List<KeyValuePair<string, int>> valueList02 = new List<KeyValuePair<string, int>>();

        //List<KeyValuePair<string, int>> valueList = new List<KeyValuePair<string, int>>();
        private void showColumnChart() {
            //List<KeyValuePair<string, int>> valueList = new List<KeyValuePair<string, int>>();
            valueList01.Add(new KeyValuePair<string, int>("Jan.", 60));
            valueList01.Add(new KeyValuePair<string, int>("Feb.", 10));
            valueList01.Add(new KeyValuePair<string, int>("Mar.", 10));
            valueList01.Add(new KeyValuePair<string, int>("Apr.", 30));
            valueList01.Add(new KeyValuePair<string, int>("May",  1));
            valueList01.Add(new KeyValuePair<string, int>("Jun.", 2));
            valueList01.Add(new KeyValuePair<string, int>("Jul.", 0));
            valueList01.Add(new KeyValuePair<string, int>("Aug.", 5));
            valueList01.Add(new KeyValuePair<string, int>("Sep.", 80));
            valueList01.Add(new KeyValuePair<string, int>("Oct.", 30));
            valueList01.Add(new KeyValuePair<string, int>("Nov.", 5));
            valueList01.Add(new KeyValuePair<string, int>("Dec.", 15));

            valueList02.Add(new KeyValuePair<string, int>("Jan.", 10));
            valueList02.Add(new KeyValuePair<string, int>("Feb.", 20));
            valueList02.Add(new KeyValuePair<string, int>("Mar.", 110));
            valueList02.Add(new KeyValuePair<string, int>("Apr.", 3));
            valueList02.Add(new KeyValuePair<string, int>("May", 10));
            valueList02.Add(new KeyValuePair<string, int>("Jun.", 22));
            valueList02.Add(new KeyValuePair<string, int>("Jul.", 33));
            valueList02.Add(new KeyValuePair<string, int>("Aug.", 4));
            valueList02.Add(new KeyValuePair<string, int>("Sep.", 8));
            valueList02.Add(new KeyValuePair<string, int>("Oct.", 330));
            valueList02.Add(new KeyValuePair<string, int>("Nov.", 51));
            valueList02.Add(new KeyValuePair<string, int>("Dec.", 15));

        }
    }
}