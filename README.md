# Desktop Toast Microsoft.Extensions.Logging Adapter

Currently only works with the Desktop Toast [fork](https://github.com/CHDKUtil/DesktopToast).

## Usage

```C#
public async Task<bool> ShowToastAsync(ILoggerFactory loggerFactory)
{
    var request = new ToastRequest
    {
        ToastTitle = "DesktopToast WPF Sample",
        ToastBody = "This is a toast test.",
        ToastLogoFilePath = string.Format("file:///{0}", Path.GetFullPath("toast128.png")),
        ShortcutFileName = "DesktopToast.Wpf.lnk",
        ShortcutTargetFilePath = Assembly.GetExecutingAssembly().Location,
        AppId = "DesktopToast.Wpf",
    };

    var logger = new LoggerAdapter(loggerFactory);
    var result = await ToastManager.ShowAsync(request, logger: logger);

    return (result == ToastResult.Activated);
}
```

**Note:** The named parameter is required to correctly resolve the overload.

## MIT License

Copyright (c) 2017 Dmitry Shechtman

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
