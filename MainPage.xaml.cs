using System;
using Xamarin.Forms;

namespace XAMARIN_FORMULARIO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGenerarCVClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text;
            string apellido = ApellidoEntry.Text;
            string email = EmailEntry.Text;
            string universidad = UniversidadEntry.Text;
            string carrera = CarreraEntry.Text;
            string telefono = TelefonoEntry.Text;

            CVStackLayout.Children.Clear();

            CVStackLayout.Children.Add(new Label
            {
                Text = "Curriculum Vitae",
                Style = (Style)Resources["TitleLabelStyle"]
            });
            CVStackLayout.Children.Add(new Label
            {
                Text = $"Nombre: {nombre}",
                Style = (Style)Resources["CVLabelStyle"]
            });
            CVStackLayout.Children.Add(new Label
            {
                Text = $"Apellido: {apellido}",
                Style = (Style)Resources["CVLabelStyle"]
            });
            CVStackLayout.Children.Add(new Label
            {
                Text = $"Email: {email}",
                Style = (Style)Resources["CVLabelStyle"]
            });
            CVStackLayout.Children.Add(new Label
            {
                Text = $"Universidad: {universidad}",
                Style = (Style)Resources["CVLabelStyle"]
            });
            CVStackLayout.Children.Add(new Label
            {
                Text = $"Carrera: {carrera}",
                Style = (Style)Resources["CVLabelStyle"]
            });
            CVStackLayout.Children.Add(new Label
            {
                Text = $"Teléfono: {telefono}",
                Style = (Style)Resources["CVLabelStyle"]
            });
        }
    }
}
