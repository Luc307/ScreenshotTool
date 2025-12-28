using Microsoft.ML;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

namespace ScreenshotTool
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

        private void sendBtn_Click(object sender, RoutedEventArgs e)
        {
            sendBtn.Content = "Sent!";
            resultImage.Source = new BitmapImage(new Uri(filePathTextBox.Text));
            // new Uri wandelt aus einem string eine für den compiler verständliche "addresse", eine Uri
            // new BitmapImage wandelt die Uri in ein Bild um, das in WPF angezeigt werden kann
            // es sucht das Image erste am angegebenen Pfad, liest dann die Bilddaten (Binärcode, 0 und 1) aus und wandelt diese in ein Bild um
            // Stark vereinfachtes Schema
        }
    }
}