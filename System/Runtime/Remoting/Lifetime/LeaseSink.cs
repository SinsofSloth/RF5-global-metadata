internal class LeaseSink : IMessageSink // TypeDefIndex: 1141
{
	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x1747D60 Offset: 0x1747E61 VA: 0x1747D60
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x174BC40 Offset: 0x174BD41 VA: 0x174BC40 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x174BFB0 Offset: 0x174C0B1 VA: 0x174BFB0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x174BD10 Offset: 0x174BE11 VA: 0x174BD10
	private void RenewLease(IMessage msg) { }
}

