using System.Windows.Controls;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class NewPerson : UserControl
    {
        private NewPersonVM vm;

        public NewPerson()
        {
            InitializeComponent();
            vm = new NewPersonVM();
            this.DataContext = vm;
        }
    }
}
