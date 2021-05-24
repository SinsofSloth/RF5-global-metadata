[Serializable]
internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver // TypeDefIndex: 1162
{
	// Fields
	private static object s_lock; // 0x0

	// Properties
	public virtual string ChannelName { get; }
	public virtual int ChannelPriority { get; }
	public virtual object ChannelData { get; }

	// Methods

	// RVA: 0x1740130 Offset: 0x1740231 VA: 0x1740130
	internal static void RegisterCrossAppDomainChannel() { }

	// RVA: 0x17402B0 Offset: 0x17403B1 VA: 0x17402B0 Slot: 9
	public virtual string get_ChannelName() { }

	// RVA: 0x1740300 Offset: 0x1740401 VA: 0x1740300 Slot: 10
	public virtual int get_ChannelPriority() { }

	// RVA: 0x1740310 Offset: 0x1740411 VA: 0x1740310 Slot: 11
	public virtual object get_ChannelData() { }

	// RVA: 0x1740440 Offset: 0x1740541 VA: 0x1740440 Slot: 12
	public virtual void StartListening(object data) { }

	// RVA: 0x1740450 Offset: 0x1740551 VA: 0x1740450 Slot: 13
	public virtual IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	// RVA: 0x17402A0 Offset: 0x17403A1 VA: 0x17402A0
	public void .ctor() { }

	// RVA: 0x17408D0 Offset: 0x17409D1 VA: 0x17408D0
	private static void .cctor() { }
}

