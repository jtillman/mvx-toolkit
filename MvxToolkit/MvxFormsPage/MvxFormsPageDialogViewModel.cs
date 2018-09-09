using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MvxToolkit.MvxFormsPage
{

    public class MvxPageOption
    {
        public const string MvxContentPageType = "MvxContentPage";
        public const string MvxTabbedPageType = "MvxTabbedPage";
        public const string MvxMasterDetailPageType = "MvxMasterDetailPage";
        public const string MvxCarouselPageType = "MvxCarouselPage";


        public string DisplayName { get; set; }
        public string ViewType { get; set; }
        public string Attribute { get; set; }
    }

    public class MvxFormsPageWizardViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MvxPageOption> PageTypes { get; } = new ObservableCollection<MvxPageOption>
        {
            new MvxPageOption
            {
                DisplayName = "Mvx Content Page",
                ViewType = MvxPageOption.MvxContentPageType,
                Attribute =  "[MvxContentPagePresentation(WrapInNavigationPage = true, NoHistory = false)]"
            },
            new MvxPageOption
            {
                DisplayName = "Mvx Tabbed Page Root",
                ViewType = MvxPageOption.MvxTabbedPageType,
                Attribute = "[MvxTabbedPagePresentation(TabbedPosition.Root, NoHistory = true)]"
            },
            new MvxPageOption
            {
                DisplayName = "Mvx Tabbed Page",
                ViewType = MvxPageOption.MvxContentPageType,
                Attribute = "[MvxTabbedPagePresentation(WrapInNavigationPage = false)]"
            },
            new MvxPageOption
            {
                DisplayName = "Mvx Modal Page",
                ViewType = MvxPageOption.MvxContentPageType,
                Attribute = "[MvxModalPresentation(WrapInNavigationPage = true)]"
            },
            new MvxPageOption
            {
                DisplayName = "Mvx Master Detail Page",
                ViewType = MvxPageOption.MvxMasterDetailPageType,
                Attribute = "[MvxMasterDetailPagePresentation(MasterDetailPosition.Root, WrapInNavigationPage = false)]"
            },
            new MvxPageOption
            {
                DisplayName = "Mvx Carousel Page Root",
                ViewType = MvxPageOption.MvxCarouselPageType,
                Attribute = "[MvxCarouselPagePresentation(CarouselPosition.Root, NoHistory = true)]"
            },
            new MvxPageOption
            {
                DisplayName = "Mvx Carousel Page",
                ViewType = MvxPageOption.MvxContentPageType,
                Attribute = "[MvxCarouselPagePresentation(CarouselPosition.Root, NoHistory = true)]"
            }
        };

        private MvxPageOption _pageType;
        public MvxPageOption PageType
        {
            get => _pageType;
            set => SetProperty(ref _pageType, value);
        }

        private string _viewName;
        public string ViewName
        {
            get => _viewName;
            set => SetProperty(ref _viewName, value);
        }

        private string _viewModelName;
        public string ViewModelName
        {
            get => _viewModelName;
            set => SetProperty(ref _viewModelName, value);
        }

        public MvxFormsPageWizardViewModel(string viewName, string viewModelName) {
            PageType =PageTypes[0];
            ViewName = viewName;
            ViewModelName = viewModelName;
        }

        public bool SetProperty<T>(ref T property, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(property, value))
                return false;
            property = value;

            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
