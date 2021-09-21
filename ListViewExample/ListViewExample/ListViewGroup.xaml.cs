using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        ObservableCollection<PersonaList> personas = new ObservableCollection<PersonaList>();

        public ListViewGroup()
        {
            InitializeComponent();
            PersonaView.ItemsSource = personas;

            personas.Add(new PersonaList(Cabecera: "A")
            {
                new Persona() { Name = "Anthony", LastName = "Quito" },
                new Persona() { Name = "Alonso", LastName = "Fernández" }
            });


            personas.Add(new PersonaList(Cabecera: "M")
            {
                new Persona() { Name = "Mordekaiser", LastName = "Infernum" },
                new Persona() { Name = "Manki", LastName = "Villalobos" },
                new Persona() { Name = "Moriarty", LastName = "Long" }
            });
        }
    }
}