namespace kino
{
    public partial class MainPage : ContentPage
    {
        int cena = 0;
        int count=0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void kup(object sender, EventArgs e) {
            cena += 17;
            count++;
            wynik.Text = $"Cena wszystkich biletów {cena } zł " +
                $"Ilość biletów {count}";
        }
    }

}
