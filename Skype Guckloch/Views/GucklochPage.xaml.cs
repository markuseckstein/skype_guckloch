using System.Windows.Controls;

using Skype_Guckloch.ViewModels;

namespace Skype_Guckloch.Views
{
    public partial class GucklochPage : Page
    {
        public GucklochPage(GucklochViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
