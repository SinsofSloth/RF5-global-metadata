internal sealed class Bounds2D // TypeDefIndex: 5947
{
	// Fields
	public Vector2 center; // 0x10
	[SerializeField] // RVA: 0x1419B0 Offset: 0x141AB1 VA: 0x1419B0
	private Vector2 m_Size; // 0x18
	[SerializeField] // RVA: 0x1419C0 Offset: 0x141AC1 VA: 0x1419C0
	private Vector2 m_Extents; // 0x20

	// Properties
	public Vector2 size { get; }

	// Methods

	// RVA: 0x1A909E0 Offset: 0x1A90AE1 VA: 0x1A909E0
	public Vector2 get_size() { }

	// RVA: 0x1A909F0 Offset: 0x1A90AF1 VA: 0x1A909F0
	public void .ctor() { }

	// RVA: 0x1A90A80 Offset: 0x1A90B81 VA: 0x1A90A80
	public void SetWithPoints(IList<Vector2> points, IList<int> indexes) { }

	// RVA: 0x1A91040 Offset: 0x1A91141 VA: 0x1A91040
	public static Vector2 Center(IList<Vector2> points, IList<int> indexes) { }

	// RVA: 0x1A91500 Offset: 0x1A91601 VA: 0x1A91500 Slot: 3
	public override string ToString() { }
}

