using Microsoft.JSInterop;

namespace BlazorCrash.Web.Extensions;
public static class IJSRuntimeExtensions
{
    public static async Task ToastrSuccess(this IJSRuntime js, string message)
    {
        await js.InvokeVoidAsync("showtoastr", "success", message);
    }

    public static async Task ToastrError(this IJSRuntime js, string message)
    {
        await js.InvokeVoidAsync("showtoastr", "error", message);
    }
}
