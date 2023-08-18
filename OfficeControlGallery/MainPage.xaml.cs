using Microcharts;

using SkiaSharp;

namespace OfficeControlGallery
{
    public partial class MainPage : ContentPage
    {
        ChartEntry[] entries = new[]
        {
            new ChartEntry(112)
            { 
                Label="Windows",
                ValueLabel="112",
                Color=SKColor.Parse("#129032") 
            },
            new ChartEntry(212)
            {
                Label="Android",
                ValueLabel="212",
                Color=SKColor.Parse("#123109")
            },
            new ChartEntry(100)
            {
                Label="IOS",
                ValueLabel="100",
                Color=SKColor.Parse("#121032")
            },
            new ChartEntry(80)
            {
                Label="Mac",
                ValueLabel="80",
                Color=SKColor.Parse("#123909")
            },
        };

        public MainPage()
        {
            InitializeComponent();
            chartView1.Chart = new BarChart { Entries = entries };
            chartView2.Chart= new LineChart { Entries = entries };
        }
    }
}