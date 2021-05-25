[ComVisibleAttribute] // RVA: 0xB1270 Offset: 0xB1371 VA: 0xB1270
public interface IMessageSink // TypeDefIndex: 1215
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

