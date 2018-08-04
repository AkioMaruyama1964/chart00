using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace chart00
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
 

        public ObservableCollection<Point> Points { get; set; }
        public ObservableCollection<Point> Points2 { get; set; }

        public MainWindow() {
            InitializeComponent();

            Points = new ObservableCollection<Point>();
            Points2 = new ObservableCollection<Point>();

            Points.Add(new Point { X = 0, Y = 0 });
            Points.Add(new Point { X = 1, Y = 5 });
            Points.Add(new Point { X = 2, Y = 7 });
            Points.Add(new Point { X = 3, Y = 14 });
            Points.Add(new Point { X = 4, Y = 10 });
            Points.Add(new Point { X = 5, Y = 12 });
            Points.Add(new Point { X = 6, Y = 7 });
            Points.Add(new Point { X = 7, Y = 18 });
            Points.Add(new Point { X = 8, Y = 18 });
            Points.Add(new Point { X = 9, Y = 10 });
            Points.Add(new Point { X = 10, Y = 14 });

            Points2.Add(new Point { X = 0, Y = 8 });
            Points2.Add(new Point { X = 2, Y = 3 });
            Points2.Add(new Point { X = 6, Y = 10 });
            Points2.Add(new Point { X = 10, Y = 5 });
            Points2.Add(new Point { X = 4, Y = 0 });

            this.DataContext = this;
        }
    }
}
