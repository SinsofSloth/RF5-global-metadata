private class CrossContextChannel.ContextRestoreSink : IMessageSink // TypeDefIndex: 1149
{
	// Fields
	private IMessageSink _next; // 0x10
	private Context _context; // 0x18
	private IMessage _call; // 0x20

	// Methods

	// RVA: 0x1749320 Offset: 0x1749421 VA: 0x1749320
	public void .ctor(IMessageSink next, Context context, IMessage call) { }

	// RVA: 0x1749390 Offset: 0x1749491 VA: 0x1749390 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x17496B0 Offset: 0x17497B1 VA: 0x17496B0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

