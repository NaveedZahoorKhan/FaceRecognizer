using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.Windows;

namespace FaceRecognizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Capture cap = new Capture();
            myImage.Image = cap.QueryFrame();
            CascadeClassifier csClassfier = new CascadeClassifier(Application.Current.Current);

        }
    }
}
