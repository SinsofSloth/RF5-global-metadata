internal class ServerObjectReplySink : IMessageSink // TypeDefIndex: 1234
{
	// Fields
	private IMessageSink _replySink; // 0x10
	private ServerIdentity _identity; // 0x18

	// Methods

	// RVA: 0x175BA70 Offset: 0x175BB71 VA: 0x175BA70
	public void .ctor(ServerIdentity identity, IMessageSink replySink) { }

	// RVA: 0x175BAC0 Offset: 0x175BBC1 VA: 0x175BAC0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x175BBD0 Offset: 0x175BCD1 VA: 0x175BBD0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

