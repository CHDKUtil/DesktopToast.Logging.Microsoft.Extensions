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

## License

* MIT License
