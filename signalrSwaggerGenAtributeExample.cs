// your method in a SignalR Hub
[SignalRMethod(description: "Your method description.")]
[return: SignalRReturn(typeof(Object), 200, "I used this decsription to point out that in this case, SignalRreturn documents the object the caller will receive, not the return type of the actual method.")]
public async Task SubscribeAsync([SignalRParam("The PonyId", typeof(Guid), false, false)] Guid id)
{
    // stuff you want to do first

    // Send the object to the caller
    var obj = new { Id = id, Name = "Pony" };
    await Clients.Caller.SendAsync("", obj, Context.ConnectionAborted);

    // more stuff
}
