internal class DisposerReplySink : IMessageSink // TypeDefIndex: 1122
{
	// Fields
	private IMessageSink _next; // 0x10
	private IDisposable _disposable; // 0x18

	// Methods

	// RVA: 0x1749B40 Offset: 0x1749C41 VA: 0x1749B40
	public void .ctor(IMessageSink next, IDisposable disposable) { }

	// RVA: 0x1749B90 Offset: 0x1749C91 VA: 0x1749B90 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1749CC0 Offset: 0x1749DC1 VA: 0x1749CC0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

