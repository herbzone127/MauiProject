using MauiApp3.Interface;
using MauiApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Dependency(typeof(FullScreenService))]
namespace MauiApp3
{
    public partial class FullScreenService : IFullScreenService
    {
        public bool TryFullScreen()
        {
            throw new NotImplementedException();
        }
    }
}
