[MovedFromAttribute] // RVA: 0x109290 Offset: 0x109391 VA: 0x109290
public struct NavMeshHit // TypeDefIndex: 3775
{
	// Fields
	private Vector3 m_Position; // 0x0
	private Vector3 m_Normal; // 0xC
	private float m_Distance; // 0x18
	private int m_Mask; // 0x1C
	private int m_Hit; // 0x20

	// Properties
	public Vector3 position { get; }
	public Vector3 normal { get; }
	public float distance { get; }

	// Methods

	// RVA: 0x22FF0 Offset: 0x230F1 VA: 0x22FF0
	public Vector3 get_position() { }

	// RVA: 0x23000 Offset: 0x23101 VA: 0x23000
	public Vector3 get_normal() { }

	// RVA: 0x23010 Offset: 0x23111 VA: 0x23010
	public float get_distance() { }
}

