using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaskervillesCount
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaskervillesCountPage : ContentPage
    {
        public BaskervillesCountPage()
        {
            InitializeComponent();

            int wordCount = countedLabel.WordCount;
            wordCountLabel.Text = wordCount + " words";
        }
    }
}
