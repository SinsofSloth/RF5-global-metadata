[ComVisibleAttribute] // RVA: 0xB0F10 Offset: 0xB1011 VA: 0xB0F10
public interface IChannelSender : IChannel // TypeDefIndex: 1170
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { }
}

