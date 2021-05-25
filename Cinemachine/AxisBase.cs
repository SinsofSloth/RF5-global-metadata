[Serializable]
public struct AxisBase // TypeDefIndex: 4831
{
	// Fields
	[NoSaveDuringPlayAttribute] // RVA: 0x134600 Offset: 0x134701 VA: 0x134600
	[TooltipAttribute] // RVA: 0x134600 Offset: 0x134701 VA: 0x134600
	public float m_Value; // 0x0
	[TooltipAttribute] // RVA: 0x134650 Offset: 0x134751 VA: 0x134650
	public float m_MinValue; // 0x4
	[TooltipAttribute] // RVA: 0x134690 Offset: 0x134791 VA: 0x134690
	public float m_MaxValue; // 0x8
	[TooltipAttribute] // RVA: 0x1346D0 Offset: 0x1347D1 VA: 0x1346D0
	public bool m_Wrap; // 0xC

	// Methods

	// RVA: 0xD6C0 Offset: 0xD7C1 VA: 0xD6C0
	public void Validate() { }
}

