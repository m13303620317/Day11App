using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Day11App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Window.Current.VisibilityChanged += WindowVisibilityChangedEventHandler;
            //Application.Current.Suspending += new SuspendingEventHandler(App_Suspending);
            Application.Current.Resuming += new EventHandler<Object>(App_Resuming);
        }

        void WindowVisibilityChangedEventHandler(System.Object sender, Windows.UI.Core.VisibilityChangedEventArgs e)
        {
            // Perform operations that should take place when the application becomes visible rather than
            // when it is prelaunched, such as building a what's new feed
            System.Diagnostics.Debug.WriteLine("Visibility changed!");
        }

        async void App_Suspending(
        Object sender,
        Windows.ApplicationModel.SuspendingEventArgs e)
        {
            // TODO: This is the time to save app data in case the process is terminated.
        }

        private void App_Resuming(Object sender, Object e)
        {
            // TODO: Refresh network data, perform UI updates, and reacquire resources like cameras, I/O devices, etc.
            System.Diagnostics.Debug.WriteLine("App resuming!");
        }
    }
}
