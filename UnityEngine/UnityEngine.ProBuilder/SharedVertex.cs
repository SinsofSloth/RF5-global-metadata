[DefaultMemberAttribute] // RVA: 0x1416A0 Offset: 0x1417A1 VA: 0x1416A0
[Serializable]
public sealed class SharedVertex : ICollection<int>, IEnumerable<int>, IEnumerable // TypeDefIndex: 5973
{
	// Fields
	[SerializeField] // RVA: 0x142190 Offset: 0x142291 VA: 0x142190
	[FormerlySerializedAsAttribute] // RVA: 0x142190 Offset: 0x142291 VA: 0x142190
	[FormerlySerializedAsAttribute] // RVA: 0x142190 Offset: 0x142291 VA: 0x142190
	private int[] m_Vertices; // 0x10

	// Properties
	public int Item { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1AA4120 Offset: 0x1AA4221 VA: 0x1AA4120
	public void .ctor(IEnumerable<int> indexes) { }

	// RVA: 0x1A98120 Offset: 0x1A98221 VA: 0x1A98120
	public void .ctor(SharedVertex sharedVertex) { }

	// RVA: 0x1A971C0 Offset: 0x1A972C1 VA: 0x1A971C0
	public int get_Item(int i) { }

	// RVA: 0x1AA22C0 Offset: 0x1AA23C1 VA: 0x1AA22C0 Slot: 11
	public IEnumerator<int> GetEnumerator() { }

	// RVA: 0x1AA41E0 Offset: 0x1AA42E1 VA: 0x1AA41E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AA4240 Offset: 0x1AA4341 VA: 0x1AA4240 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1AA1AE0 Offset: 0x1AA1BE1 VA: 0x1AA1AE0 Slot: 6
	public void Add(int item) { }

	// RVA: 0x1AA42F0 Offset: 0x1AA43F1 VA: 0x1AA42F0 Slot: 7
	public void Clear() { }

	// RVA: 0x1AA4350 Offset: 0x1AA4451 VA: 0x1AA4350 Slot: 8
	public bool Contains(int item) { }

	// RVA: 0x1AA43C0 Offset: 0x1AA44C1 VA: 0x1AA43C0 Slot: 9
	public void CopyTo(int[] array, int arrayIndex) { }

	// RVA: 0x1AA43E0 Offset: 0x1AA44E1 VA: 0x1AA43E0 Slot: 10
	public bool Remove(int item) { }

	// RVA: 0x1A97200 Offset: 0x1A97301 VA: 0x1A97200 Slot: 4
	public int get_Count() { }

	// RVA: 0x1AA4490 Offset: 0x1AA4591 VA: 0x1AA4490 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x1A982B0 Offset: 0x1A983B1 VA: 0x1A982B0
	public static void GetSharedVertexLookup(IList<SharedVertex> sharedVertices, Dictionary<int, int> lookup) { }

	// RVA: 0x1A987A0 Offset: 0x1A988A1 VA: 0x1A987A0
	internal static SharedVertex[] ToSharedVertices(IEnumerable<KeyValuePair<int, int>> lookup) { }

	// RVA: 0x1AA44B0 Offset: 0x1AA45B1 VA: 0x1AA44B0
	private static SharedVertex[] ToSharedVertices(List<List<int>> list) { }

	// RVA: 0x1A9CCF0 Offset: 0x1A9CDF1 VA: 0x1A9CCF0
	public static SharedVertex[] GetSharedVerticesWithPositions(IList<Vector3> positions) { }

	// RVA: 0x1AA16B0 Offset: 0x1AA17B1 VA: 0x1AA16B0
	internal static void SetCoincident(ref Dictionary<int, int> lookup, IEnumerable<int> vertices) { }
}

