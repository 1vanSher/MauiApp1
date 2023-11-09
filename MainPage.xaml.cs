using MauiApp1.Platforms.Android;
namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public List<radiotable> Music { get; set; }

        public MainPage()
        {
            InitializeComponent();
            //this.BindingContext = this;
            //Music = Connect.Db.GetAll();
            

        }

        public void add(object sender, EventArgs e)
        {
            string label = lol.Text;

            if (label != "" && label != " ")
            {
                Connect.Db.Save(new radiotable {songer = "sss", song = "ddd", time = "fff" });
                lol.Text = "";
                
                Music = Connect.Db.GetAll();
                MusicList.ItemsSource = Music;
            }
        }
    }
}