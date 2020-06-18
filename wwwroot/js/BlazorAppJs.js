let blazorInterop = {};

blazorInterop.InvokeCMethod = function () {
    var promise = DotNet.invokeMethodAsync("BlazorApp1", "GetEmailFromName", "thang78");
    promise.then(email => alert(email));
}