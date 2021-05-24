[UsedByNativeCodeAttribute] // RVA: 0x106500 Offset: 0x106601 VA: 0x106500
public struct XRNodeState // TypeDefIndex: 3721
{
	// Fields
	private XRNode m_Type; // 0x0
	private AvailableTrackingData m_AvailableFields; // 0x4
	private Vector3 m_Position; // 0x8
	private Quaternion m_Rotation; // 0x14
	private Vector3 m_Velocity; // 0x24
	private Vector3 m_AngularVelocity; // 0x30
	private Vector3 m_Acceleration; // 0x3C
	private Vector3 m_AngularAcceleration; // 0x48
	private int m_Tracked; // 0x54
	private ulong m_UniqueID; // 0x58

	// Properties
	public ulong uniqueID { set; }
	public XRNode nodeType { set; }
	public bool tracked { set; }

	// Methods

	// RVA: 0x26300 Offset: 0x26401 VA: 0x26300
	public void set_uniqueID(ulong value) { }

	// RVA: 0x26310 Offset: 0x26411 VA: 0x26310
	public void set_nodeType(XRNode value) { }

	// RVA: 0x26320 Offset: 0x26421 VA: 0x26320
	public void set_tracked(bool value) { }
}

