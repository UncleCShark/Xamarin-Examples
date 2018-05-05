using System;
using Xamarin.Forms;

using Xamarin.Forms.Xaml;

namespace XamlClock
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamlClockPage
    {
        public XamlClockPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        bool OnTimerTick()
        {
            DateTime dt = DateTime.Now;
            timeLabel.Text = dt.ToString("T");
            dateLabel.Text = dt.ToString("D");
            return true;
        }
    }
}
