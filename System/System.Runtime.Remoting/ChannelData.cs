internal class ChannelData // TypeDefIndex: 1112
{
	// Fields
	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal string DelayLoadAsClientChannel; // 0x28
	private ArrayList _serverProviders; // 0x30
	private ArrayList _clientProviders; // 0x38
	private Hashtable _customProperties; // 0x40

	// Properties
	internal ArrayList ServerProviders { get; }
	public ArrayList ClientProviders { get; }
	public Hashtable CustomProperties { get; }

	// Methods

	// RVA: 0x173B390 Offset: 0x173B491 VA: 0x173B390
	internal ArrayList get_ServerProviders() { }

	// RVA: 0x173B420 Offset: 0x173B521 VA: 0x173B420
	public ArrayList get_ClientProviders() { }

	// RVA: 0x173B4B0 Offset: 0x173B5B1 VA: 0x173B4B0
	public Hashtable get_CustomProperties() { }

	// RVA: 0x173B540 Offset: 0x173B641 VA: 0x173B540
	public void CopyFrom(ChannelData other) { }

	// RVA: 0x173C0C0 Offset: 0x173C1C1 VA: 0x173C0C0
	public void .ctor() { }
}

