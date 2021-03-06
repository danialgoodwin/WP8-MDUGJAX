// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   PageCS.tt
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyToolkit.Paging;
using Newtonsoft.Json;
using WPAppStudio;
using WPAppStudio.Entities;
using WPAppStudio.Helpers;
using WPAppStudio.Ioc;
using WPAppStudio.Localization;
using WPAppStudio.Repositories;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.ViewModel;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.View
{
    /// <summary>
    /// Phone application page for info_Info.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class info_Info : PhoneApplicationPage
    {
        /// <summary>
        /// Initializes the phone application page for info_Info and all its components.
        /// </summary>
        public info_Info()
        {
            InitializeComponent();
            if (Resources.Contains("Panoramainfo_Info0AppBar"))
            {
                PhonePage.SetApplicationBar(this, Resources["Panoramainfo_Info0AppBar"] as BindableApplicationBar);

                // Add menu item in Applicationbar
                ApplicationBarMenuItem menuItem1 = new ApplicationBarMenuItem();
                menuItem1.Text = "about";
                ApplicationBar.MenuItems.Add(menuItem1);
                menuItem1.Click += new EventHandler(menuItemAbout_Click);
            }
		}
		
        private void panoramainfo_Info_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {		
			InitializeAppBarpanoramainfo_Info(Panoramainfo_Info.SelectedItem as PanoramaItem);
        }
		
		private void InitializeAppBarpanoramainfo_Info(PanoramaItem panoramaItem)        
        {
			if (Resources.Contains(panoramaItem.Name + "AppBar"))
			{
				PhonePage.SetApplicationBar(this, Resources[panoramaItem.Name + "AppBar"] as BindableApplicationBar);            
				ApplicationBar.IsVisible = true;
            }
            else if (ApplicationBar != null)
            {
                //ApplicationBar.IsVisible = false;
                //ApplicationBar = new ApplicationBar();

                PhonePage.SetApplicationBar(this, Resources[panoramaItem.Name + "AppBar"] as BindableApplicationBar);  
                ApplicationBar.Mode = ApplicationBarMode.Minimized;
                ApplicationBar.IsVisible = true;
                ApplicationBar.IsMenuEnabled = true;
            }
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/YourLastAboutDialog;component/AboutPage.xaml", UriKind.Relative));
        }
 
        /// <summary>
        /// Called when the page becomes the active page.
        /// </summary>
        /// <param name="e">Contains information about the navigation done.</param>
        protected override  void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
		
            Links_ListListControl.SelectedItem = null;
		
            Upcoming_ListListControl.SelectedItem = null;
		
            PhotoAlbum_NewsListControl.SelectedItem = null;
		
            SponsorsMenuControl.SelectedItem = null;
		}
    }
}
