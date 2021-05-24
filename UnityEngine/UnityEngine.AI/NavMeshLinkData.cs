public struct NavMeshLinkData // TypeDefIndex: 3778
{
	// Fields
	private Vector3 m_StartPosition; // 0x0
	private Vector3 m_EndPosition; // 0xC
	private float m_CostModifier; // 0x18
	private int m_Bidirectional; // 0x1C
	private float m_Width; // 0x20
	private int m_Area; // 0x24
	private int m_AgentTypeID; // 0x28

	// Properties
	public Vector3 startPosition { set; }
	public Vector3 endPosition { set; }
	public float costModifier { set; }
	public bool bidirectional { set; }
	public float width { set; }
	public int area { set; }
	public int agentTypeID { set; }

	// Methods

	// RVA: 0x23020 Offset: 0x23121 VA: 0x23020
	public void set_startPosition(Vector3 value) { }

	// RVA: 0x23030 Offset: 0x23131 VA: 0x23030
	public void set_endPosition(Vector3 value) { }

	// RVA: 0x23040 Offset: 0x23141 VA: 0x23040
	public void set_costModifier(float value) { }

	// RVA: 0x23050 Offset: 0x23151 VA: 0x23050
	public void set_bidirectional(bool value) { }

	// RVA: 0x23060 Offset: 0x23161 VA: 0x23060
	public void set_width(float value) { }

	// RVA: 0x23070 Offset: 0x23171 VA: 0x23070
	public void set_area(int value) { }

	// RVA: 0x23080 Offset: 0x23181 VA: 0x23080
	public void set_agentTypeID(int value) { }
}

