using R3;
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

namespace R3WpfTest
{
    public partial class MainWindow : Window
    {
        IDisposable disposable;

        public MainWindow()
        {
            InitializeComponent();

            var d1 = Observable.EveryValueChanged(this, x => x.Width).Subscribe(x => WidthText.Text = x.ToString());
            var d2 = Observable.EveryValueChanged(this, x => x.Height).Subscribe(x => HeightText.Text = x.ToString());

            disposable = Disposable.Combine(d1, d2);
        }

        protected override void OnClosed(EventArgs e)
        {
            disposable.Dispose();
        }
    }
}