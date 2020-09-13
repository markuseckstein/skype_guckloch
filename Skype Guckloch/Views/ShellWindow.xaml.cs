using System.Windows.Controls;

using Skype_Guckloch.Contracts.Views;
using Skype_Guckloch.ViewModels;

using MahApps.Metro.Controls;

namespace Skype_Guckloch.Views
{
    public partial class ShellWindow : MetroWindow, IShellWindow
    {
        public ShellWindow(ShellViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        public Frame GetNavigationFrame()
            => shellFrame;

        public void ShowWindow()
            => Show();

        public void CloseWindow()
            => Close();
    }
}
