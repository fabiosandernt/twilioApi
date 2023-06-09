#pragma checksum "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ab9ecc262806b941b3b2a8afbaf23bd1bb8dc53"
// <auto-generated/>
#pragma warning disable 1591
namespace TwilioBlazorPhonecalls.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\_Imports.razor"
using TwilioBlazorPhonecalls.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\_Imports.razor"
using TwilioBlazorPhonecalls.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    public partial class Dialer : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dialer" + "\r\n    " + (
#nullable restore
#line 8 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
      hasIncomingConnection || isTwilioDeviceConnected ? "dialer--show-top" : ""

#line default
#line hidden
#nullable disable
            ) + "\r\n    " + (
#nullable restore
#line 9 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
      hasIncomingConnection ? "dialer--incoming-call" : ""

#line default
#line hidden
#nullable disable
            ) + "\r\n    " + (
#nullable restore
#line 10 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
      showDialer ? "dialer--show" : "dialer--hide"

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "show-hide-button" + " btn" + " " + (
#nullable restore
#line 11 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                                          showDialer ? "btn-secondary" : "btn-success"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                        () => showDialer = !showDialer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, 
#nullable restore
#line 13 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
          showDialer ? "hide" : "show"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, " phone <span class=\"oi oi-phone\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "p");
            __builder.AddAttribute(9, "class", "text-center text-light");
            __builder.AddContent(10, 
#nullable restore
#line 15 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                                        message != "" ?message : "Standing by"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "input-group w-100 mb-3");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "disabled", 
#nullable restore
#line 19 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                           !isTwilioDeviceReady || isTwilioDeviceConnected || hasIncomingConnection

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "class", "form-control text-center");
            __builder.AddAttribute(18, "placeholder", "Phone number");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                      dialNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dialNumber = __value, dialNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "input-group-append");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                              RemoveKey

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "disabled", 
#nullable restore
#line 25 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                                !isTwilioDeviceReady || isTwilioDeviceConnected || hasIncomingConnection || dialNumber.Length == 0

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddMarkupContent(29, "<span class=\"oi oi-delete\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "dial-pad clearfix w-100 mb-3");
#nullable restore
#line 33 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
         foreach (var dialKey in dialKeys)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                              () => PressKey(dialKey)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "class", "btn btn-dark");
            __builder.AddAttribute(36, "type", "button");
            __builder.AddAttribute(37, "disabled", 
#nullable restore
#line 36 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                                !isTwilioDeviceReady

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, 
#nullable restore
#line 37 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                 dialKey

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 39 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "btn-group w-100");
#nullable restore
#line 42 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
         if (hasIncomingConnection)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                              RejectCall

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "type", "button");
            __builder.AddAttribute(45, "class", "btn btn-danger w-50");
            __builder.AddMarkupContent(46, "\r\n                Reject\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                              AcceptCall

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "btn btn-success w-50");
            __builder.AddMarkupContent(52, "\r\n                Accept\r\n            ");
            __builder.CloseElement();
#nullable restore
#line 54 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                              EndCall

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "disabled", 
#nullable restore
#line 58 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                                !isTwilioDeviceReady || !isTwilioDeviceConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(56, "type", "button");
            __builder.AddAttribute(57, "class", "btn btn-danger w-50");
            __builder.AddMarkupContent(58, "\r\n                Hang up\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                              StartCall

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "disabled", 
#nullable restore
#line 64 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
                                !isTwilioDeviceReady || isTwilioDeviceConnected || dialNumber.Length == 0

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(63, "type", "button");
            __builder.AddAttribute(64, "class", "btn btn-success w-50");
            __builder.AddMarkupContent(65, "\r\n                Call\r\n            ");
            __builder.CloseElement();
#nullable restore
#line 69 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\Projects\TwilioBlazorPhoneCalls\TwilioBlazorPhonecalls.Client\Components\Dialer.razor"
      
    [JSInvokable]
    public void OnTwilioDeviceReady()
    {
        isTwilioDeviceReady = true;
        StateHasChanged();
    }

    [JSInvokable]
    public void OnTwilioDeviceError(string error)
    {
        message = error;
        logger.LogError(error);
        StateHasChanged();
    }

    [JSInvokable]
    public void OnTwilioDeviceConnected(string phoneNumber)
    {
        isTwilioDeviceConnected = true;
        hasIncomingConnection = false;
        message = $"Calling {phoneNumber}";
        StateHasChanged();
    }

    [JSInvokable]
    public void OnTwilioDeviceDisconnected()
    {
        isTwilioDeviceConnected = false;
        hasIncomingConnection = false;
        message = "";
        StateHasChanged();
    }

    [JSInvokable]
    public void OnTwilioDeviceIncomingConnection(string phoneNumber)
    {
        hasIncomingConnection = true;
        message = $"{phoneNumber} is calling you";
        StateHasChanged();
    }

    [JSInvokable]
    public void OnTwilioDeviceCanceled()
    {
        hasIncomingConnection = false;
        message = "";
        StateHasChanged();
    }

    private static readonly HttpClient httpClient = new HttpClient();

    private static readonly string dialKeys = "123456789*0#";
    private bool showDialer = false;
    private string message = "";
    private string dialNumber = "";
    private bool isTwilioDeviceReady = false;
    private bool isTwilioDeviceConnected = false;
    private bool hasIncomingConnection = false;
    private DotNetObjectReference<Dialer> dotNetObjectReference;
    private void PressKey(char key) => dialNumber += key;

    private void RemoveKey() => dialNumber = dialNumber.Remove(dialNumber.Length - 1);

    private async Task StartCall()
    {
        await js.InvokeVoidAsync("dialer.startCall", dialNumber);
    }

    private async Task EndCall()
    {
        await js.InvokeVoidAsync("dialer.endCall");
    }

    private async Task AcceptCall()
    {
        await js.InvokeVoidAsync("dialer.acceptCall");
    }

    private async Task RejectCall()
    {
        hasIncomingConnection = false;
        message = "";
        await js.InvokeVoidAsync("dialer.rejectCall");
    }

    protected override async Task OnInitializedAsync()
    {
        dotNetObjectReference = DotNetObjectReference.Create(this);
        await js.InvokeVoidAsync("dialer.setDotNetObjectReference", dotNetObjectReference);
        await js.InvokeVoidAsync("dialer.setupTwilioEvents");
        var jwtToken = await GetTwilioAuthenticationTokenAsync();
        await js.InvokeVoidAsync("dialer.setupTwilioDevice", jwtToken);
    }


    private async Task<string> GetTwilioAuthenticationTokenAsync()
    {
        var jwtToken = await httpClient.GetStringAsync("https://localhost:5003/token");
        return jwtToken;
    }


    // IAsyncDisposable isn't supported in Blazor .NET Core 3.1, but will be in future versions
    // for now use IDisposable and fire and forget a task to call dialer.destroy
    public void Dispose()
    {
        js.InvokeVoidAsync("dialer.destroy");
        dotNetObjectReference?.Dispose();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Dialer> logger { get; set; }
    }
}
#pragma warning restore 1591
