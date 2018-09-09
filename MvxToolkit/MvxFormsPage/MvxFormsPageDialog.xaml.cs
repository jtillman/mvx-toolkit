using Microsoft.VisualStudio.PlatformUI;

namespace MvxToolkit.MvxFormsPage
{
    /// <summary>
    /// Interaction logic for TemplateWizard.xaml
    /// </summary>
    public partial class MvxFormsPageDialog : DialogWindow
    {
        public MvxFormsPageWizardViewModel ViewModel
        {
            get => (MvxFormsPageWizardViewModel)DataContext;
            set => DataContext = value;
        }

        public MvxFormsPageDialog(string viewName = null, string viewModelName = null)
        {
            ViewModel = new MvxFormsPageWizardViewModel(viewName, viewModelName);
            InitializeComponent();
        }

        private void AddClicked(object sender, System.Windows.RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void CancelClicked(object sender, System.Windows.RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void listViewSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ViewModel.PageType = (MvxPageOption) optionListView.SelectedItem;
        }
    }
}
