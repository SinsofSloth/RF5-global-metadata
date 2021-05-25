internal class ClientContextTerminatorSink : IMessageSink // TypeDefIndex: 1203
{
	// Fields
	private Context _context; // 0x10

	// Methods

	// RVA: 0x1747BF0 Offset: 0x1747CF1 VA: 0x1747BF0
	public void .ctor(Context ctx) { }

	// RVA: 0x17508E0 Offset: 0x17509E1 VA: 0x17508E0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1750B30 Offset: 0x1750C31 VA: 0x1750B30 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

