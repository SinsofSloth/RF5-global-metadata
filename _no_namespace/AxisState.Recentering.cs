[DocumentationSortingAttribute] // RVA: 0x12F550 Offset: 0x12F651 VA: 0x12F550
[Serializable]
public struct AxisState.Recentering // TypeDefIndex: 4811
{
	// Fields
	[TooltipAttribute] // RVA: 0x135EE0 Offset: 0x135FE1 VA: 0x135EE0
	public bool m_enabled; // 0x0
	[TooltipAttribute] // RVA: 0x135F20 Offset: 0x136021 VA: 0x135F20
	public float m_WaitTime; // 0x4
	[TooltipAttribute] // RVA: 0x135F60 Offset: 0x136061 VA: 0x135F60
	public float m_RecenteringTime; // 0x8
	private float mLastAxisInputTime; // 0xC
	private float mRecenteringVelocity; // 0x10
	[SerializeField] // RVA: 0x135FA0 Offset: 0x1360A1 VA: 0x135FA0
	[HideInInspector] // RVA: 0x135FA0 Offset: 0x1360A1 VA: 0x135FA0
	[FormerlySerializedAsAttribute] // RVA: 0x135FA0 Offset: 0x1360A1 VA: 0x135FA0
	private int m_LegacyHeadingDefinition; // 0x14
	[SerializeField] // RVA: 0x136000 Offset: 0x136101 VA: 0x136000
	[HideInInspector] // RVA: 0x136000 Offset: 0x136101 VA: 0x136000
	[FormerlySerializedAsAttribute] // RVA: 0x136000 Offset: 0x136101 VA: 0x136000
	private int m_LegacyVelocityFilterStrength; // 0x18

	// Methods

	// RVA: 0xD9B0 Offset: 0xDAB1 VA: 0xD9B0
	public void .ctor(bool enabled, float waitTime, float recenteringTime) { }

	// RVA: 0xD9D0 Offset: 0xDAD1 VA: 0xD9D0
	public void Validate() { }

	// RVA: 0xDA70 Offset: 0xDB71 VA: 0xDA70
	public void CopyStateFrom(ref AxisState.Recentering other) { }

	// RVA: 0xDA90 Offset: 0xDB91 VA: 0xDA90
	public void CancelRecentering() { }

	// RVA: 0xDAA0 Offset: 0xDBA1 VA: 0xDAA0
	public void RecenterNow() { }

	// RVA: 0xDAB0 Offset: 0xDBB1 VA: 0xDAB0
	public void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget) { }

	// RVA: 0xDAC0 Offset: 0xDBC1 VA: 0xDAC0
	internal bool LegacyUpgrade(ref int heading, ref int velocityFilter) { }
}

