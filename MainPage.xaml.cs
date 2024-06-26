namespace PagoSemanal
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryHT.Text)&& !string.IsNullOrEmpty(entryPH.Text))
            {
                double HT, PH, PS;
                HT = Convert.ToDouble(entryHT.Text);
                PH = Convert.ToDouble(entryPH.Text);
                PS = HT * PH;
                entryPS.Text = Convert.ToString(PS);
            }
        }
    }

}
