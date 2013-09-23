// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   NavigationService.tt
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using WPAppStudio.Controls;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.ViewModel.Base;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.Services
{
    /// <summary>
    /// Implementation of a navigation service.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public class NavigationService : INavigationService
    {
        private static readonly IDictionary<Type, string> ViewModelRouting = new Dictionary<Type, string>()
        {
            { typeof(Iinfo_InfoViewModel), "/View/info_Info.xaml" },
            { typeof(IPhotoAlbum_DetailViewModel), "/View/PhotoAlbum_Detail.xaml" },
            { typeof(Iupcoming_DetailViewModel), "/View/upcoming_Detail.xaml" },
            { typeof(IlinksAboutThisPlace1ViewModel), "/View/linksAboutThisPlace1.xaml" },
        };

        private object _navigationContext;

        /// <summary>
        /// Generic method to navigate to a viewmodel
        /// </summary>
        /// <typeparam name="TDestinationViewModel">ViewModel type</typeparam>
        public void NavigateTo<TDestinationViewModel>()
        {
            var rootFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            rootFrame.Navigate(new Uri(ViewModelRouting[typeof(TDestinationViewModel)], UriKind.Relative));
        }

        /// <summary>
        /// Generic method to navigate to a viewmodel passing a navigation context
        /// </summary>
        /// <typeparam name="TDestinationViewModel">ViewModel type</typeparam>
        /// <param name="navigationContext">Parameters passed to target ViewModel</param>
        public void NavigateTo<TDestinationViewModel>(object navigationContext)
        {
            this._navigationContext = navigationContext;

            var rootFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            rootFrame.Navigated += new NavigatedEventHandler(Page_Navigated);
            rootFrame.Navigate(new Uri(ViewModelRouting[typeof(TDestinationViewModel)], UriKind.Relative));
        }
			
        /// <summary>
        /// Generic method to navigate to a menu item target
        /// </summary>        
        /// <param name="menuItem">Selected menu item</param>			
        public void NavigateTo(MenuItemData menuItem)
        {
            var rootFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            if(menuItem.Target != null)
                rootFrame.Navigate(new Uri(menuItem.Target, UriKind.Relative));
            else if (menuItem.TargetUrl != null)
				NavigateTo(new Uri(menuItem.TargetUrl));
                
        }
		
		/// <summary>
        /// Generic method to navigate to a uri
        /// </summary>        
        /// <param name="uri">Target uri</param>			
        public void NavigateTo(Uri uri)
        {
            new WebBrowserTask { Uri = uri }.Show();
        }

		/// <summary>
        /// Go back in the navigation stack.
        /// </summary>
        public void NavigateBack()
        {
            var rootFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

		/// <summary>
        /// Go back in the navigation stack passing a navigation context.
        /// </summary>
        public void NavigateBack(object navigationContext)
        {
            this._navigationContext = navigationContext;

            var rootFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            if (rootFrame.CanGoBack)
            {
                rootFrame.Navigated += new NavigatedEventHandler(Page_Navigated);
                rootFrame.GoBack();
            }
        }

        private void Page_Navigated(object sender, NavigationEventArgs e)
        {
            var rootFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            rootFrame.Navigated -= Page_Navigated;

            // Pásale los parámetros a su vista-modelo
            ((e.Content as PhoneApplicationPage).DataContext as INavigable).NavigationContext = this._navigationContext;
        }

		/// <summary>
        /// Remove all items in navigation stack.
        /// </summary>
        public void ClearNavigationHistory()
        {
            var rootFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            while (rootFrame.RemoveBackEntry() != null) ;
        }
		
		/// <summary>
        /// Get URI view corresponding to a ViewModel 
        /// </summary>
        public string GetUri(Type type)
        {
            return ViewModelRouting[type];
        }
    }
}
