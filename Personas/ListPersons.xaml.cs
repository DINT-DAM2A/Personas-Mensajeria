using System.Windows.Controls;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para ListPersons.xaml
    /// </summary>
    public partial class ListPersons : UserControl
    {
        ListPersonsVM vm;
        public ListPersons()
        {
            InitializeComponent();
            vm = new ListPersonsVM();
            this.DataContext = vm;
        }
    }
}
