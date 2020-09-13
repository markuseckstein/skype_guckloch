using System;
using System.Windows.Controls;

namespace Skype_Guckloch.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);

        Page GetPage(string key);
    }
}
