public class MeshUniqueVertices.UniqueVertex // TypeDefIndex: 9206
{
	// Fields
	private int m_nFixedX; // 0x10
	private int m_nFixedY; // 0x14
	private int m_nFixedZ; // 0x18
	private const float fDecimalMultiplier = 100000;

	// Methods

	// RVA: 0x1F57200 Offset: 0x1F57301 VA: 0x1F57200 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F572E0 Offset: 0x1F573E1 VA: 0x1F572E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1F56EA0 Offset: 0x1F56FA1 VA: 0x1F56EA0
	public void .ctor(Vector3 v3Vertex) { }

	// RVA: 0x1F57480 Offset: 0x1F57581 VA: 0x1F57480
	public Vector3 ToVertex() { }

	// RVA: 0x1F57540 Offset: 0x1F57641 VA: 0x1F57540
	public static bool op_Equality(MeshUniqueVertices.UniqueVertex a, MeshUniqueVertices.UniqueVertex b) { }

	// RVA: 0x1F57560 Offset: 0x1F57661 VA: 0x1F57560
	public static bool op_Inequality(MeshUniqueVertices.UniqueVertex a, MeshUniqueVertices.UniqueVertex b) { }

	// RVA: 0x1F57300 Offset: 0x1F57401 VA: 0x1F57300
	private void FromVertex(Vector3 vertex) { }

	// RVA: 0x1F57590 Offset: 0x1F57691 VA: 0x1F57590
	private int CoordToFixed(float fCoord) { }

	// RVA: 0x1F57510 Offset: 0x1F57611 VA: 0x1F57510
	private float FixedToCoord(int nFixed) { }
}

