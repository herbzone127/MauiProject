using MauiApp3;
using MauiApp3.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;

[assembly: Dependency(typeof(FullScreenService))]
namespace MauiApp3
{
    public partial class FullScreenService : IFullScreenService
    {
        public bool TryFullScreen()
        {

            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            var view = ApplicationView.TryUnsnapToFullscreen();
            return view;
        }
    }
}
