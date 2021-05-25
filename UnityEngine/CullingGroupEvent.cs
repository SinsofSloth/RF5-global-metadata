public struct CullingGroupEvent // TypeDefIndex: 2847
{
	// Fields
	private int m_Index; // 0x0
	private byte m_PrevState; // 0x4
	private byte m_ThisState; // 0x5

	// Properties
	public int index { get; }
	public bool isVisible { get; }
	public int currentDistance { get; }

	// Methods

	// RVA: 0x37C650 Offset: 0x37C751 VA: 0x37C650
	public int get_index() { }

	// RVA: 0x37C660 Offset: 0x37C761 VA: 0x37C660
	public bool get_isVisible() { }

	// RVA: 0x37C670 Offset: 0x37C771 VA: 0x37C670
	public int get_currentDistance() { }
}

