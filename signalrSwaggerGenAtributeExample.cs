// your method in a SignalR Hub
[SignalRMethod(description: "Call this method to receive updates.")]
[return: SignalRReturn(typeof(Object), 200, "The object sent to the subscribed caller.")]
public async Task SubscribeAsync([SignalRParam("The PonyId", typeof(Guid), false, false)] Guid id)
{
    // stuff you want to do first

    // Send the object to the caller
    var obj = new { Id = id, Name = "Pony" };
    await Clients.Caller.SendAsync("", obj, Context.ConnectionAborted);

    // more stuff
}
