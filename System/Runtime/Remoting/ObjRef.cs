[ComVisibleAttribute] // RVA: 0xB0A80 Offset: 0xB0B81 VA: 0xB0A80
[Serializable]
public class ObjRef : IObjectReference, ISerializable // TypeDefIndex: 1109
{
	// Fields
	private IChannelInfo channel_info; // 0x10
	private string uri; // 0x18
	private IRemotingTypeInfo typeInfo; // 0x20
	private IEnvoyInfo envoyInfo; // 0x28
	private int flags; // 0x30
	private Type _serverType; // 0x38
	private static int MarshalledObjectRef; // 0x0
	private static int WellKnowObjectRef; // 0x4

	// Properties
	internal bool IsReferenceToWellKnow { get; }
	public virtual IChannelInfo ChannelInfo { get; }
	public virtual IEnvoyInfo EnvoyInfo { get; set; }
	public virtual IRemotingTypeInfo TypeInfo { get; set; }
	public virtual string URI { get; set; }
	internal Type ServerType { get; }

	// Methods

	// RVA: 0x175CFD0 Offset: 0x175D0D1 VA: 0x175CFD0
	public void .ctor() { }

	// RVA: 0x175D0D0 Offset: 0x175D1D1 VA: 0x175D0D0
	internal void .ctor(string uri, IChannelInfo cinfo) { }

	// RVA: 0x174F0D0 Offset: 0x174F1D1 VA: 0x174F0D0
	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo) { }

	// RVA: 0x1750460 Offset: 0x1750561 VA: 0x1750460
	internal byte[] SerializeType() { }

	// RVA: 0x175D120 Offset: 0x175D221 VA: 0x175D120
	internal void .ctor(Type type, string url, object remoteChannelData) { }

	// RVA: 0x175D240 Offset: 0x175D341 VA: 0x175D240
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x175D6D0 Offset: 0x175D7D1 VA: 0x175D6D0
	internal bool get_IsReferenceToWellKnow() { }

	[ReliabilityContractAttribute] // RVA: 0xB93F0 Offset: 0xB94F1 VA: 0xB93F0
	// RVA: 0x175D750 Offset: 0x175D851 VA: 0x175D750 Slot: 6
	public virtual IChannelInfo get_ChannelInfo() { }

	// RVA: 0x175D760 Offset: 0x175D861 VA: 0x175D760 Slot: 7
	public virtual IEnvoyInfo get_EnvoyInfo() { }

	// RVA: 0x175D770 Offset: 0x175D871 VA: 0x175D770 Slot: 8
	public virtual void set_EnvoyInfo(IEnvoyInfo value) { }

	// RVA: 0x175D780 Offset: 0x175D881 VA: 0x175D780 Slot: 9
	public virtual IRemotingTypeInfo get_TypeInfo() { }

	// RVA: 0x175D790 Offset: 0x175D891 VA: 0x175D790 Slot: 10
	public virtual void set_TypeInfo(IRemotingTypeInfo value) { }

	// RVA: 0x175D7A0 Offset: 0x175D8A1 VA: 0x175D7A0 Slot: 11
	public virtual string get_URI() { }

	// RVA: 0x175D7B0 Offset: 0x175D8B1 VA: 0x175D7B0 Slot: 12
	public virtual void set_URI(string value) { }

	// RVA: 0x175D7C0 Offset: 0x175D8C1 VA: 0x175D7C0 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x175D930 Offset: 0x175DA31 VA: 0x175D930 Slot: 14
	public virtual object GetRealObject(StreamingContext context) { }

	// RVA: 0x175D000 Offset: 0x175D101 VA: 0x175D000
	internal void UpdateChannelInfo() { }

	// RVA: 0x175D9F0 Offset: 0x175DAF1 VA: 0x175D9F0
	internal Type get_ServerType() { }

	// RVA: 0x175DB40 Offset: 0x175DC41 VA: 0x175DB40
	private static void .cctor() { }
}

