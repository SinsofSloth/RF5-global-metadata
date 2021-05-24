[ComVisibleAttribute] // RVA: 0xB1130 Offset: 0xB1231 VA: 0xB1130
[Serializable]
public sealed class LogicalCallContext : ISerializable, ICloneable // TypeDefIndex: 1190
{
	// Fields
	private static Type s_callContextType; // 0x0
	private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";
	private Hashtable m_Datastore; // 0x10
	private CallContextRemotingData m_RemotingData; // 0x18
	private CallContextSecurityData m_SecurityData; // 0x20
	private object m_HostContext; // 0x28
	private bool m_IsCorrelationMgr; // 0x30
	private Header[] _sendHeaders; // 0x38
	private Header[] _recvHeaders; // 0x40

	// Properties
	public bool HasInfo { get; }
	private bool HasUserData { get; }
	private Hashtable Datastore { get; }

	// Methods

	// RVA: 0x17540B0 Offset: 0x17541B1 VA: 0x17540B0
	internal void .ctor() { }

	// RVA: 0x17540C0 Offset: 0x17541C1 VA: 0x17540C0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17544F0 Offset: 0x17545F1 VA: 0x17544F0 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1754860 Offset: 0x1754961 VA: 0x1754860 Slot: 5
	public object Clone() { }

	// RVA: 0x1755060 Offset: 0x1755161 VA: 0x1755060
	internal void Merge(LogicalCallContext lc) { }

	// RVA: 0x174F740 Offset: 0x174F841 VA: 0x174F740
	public bool get_HasInfo() { }

	// RVA: 0x1754830 Offset: 0x1754931 VA: 0x1754830
	private bool get_HasUserData() { }

	// RVA: 0x1754460 Offset: 0x1754561 VA: 0x1754460
	private Hashtable get_Datastore() { }

	// RVA: 0x17553A0 Offset: 0x17554A1 VA: 0x17553A0
	private static void .cctor() { }
}

