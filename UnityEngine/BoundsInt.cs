[UsedByNativeCodeAttribute] // RVA: 0xC47B0 Offset: 0xC48B1 VA: 0xC47B0
public struct BoundsInt : IEquatable<BoundsInt> // TypeDefIndex: 2858
{
	// Fields
	private Vector3Int m_Position; // 0x0
	private Vector3Int m_Size; // 0xC

	// Properties
	public Vector3Int position { get; set; }
	public Vector3Int size { get; set; }

	// Methods

	// RVA: 0x37BF40 Offset: 0x37C041 VA: 0x37BF40
	public Vector3Int get_position() { }

	// RVA: 0x37BF50 Offset: 0x37C051 VA: 0x37BF50
	public void set_position(Vector3Int value) { }

	// RVA: 0x37BF60 Offset: 0x37C061 VA: 0x37BF60
	public Vector3Int get_size() { }

	// RVA: 0x37BF70 Offset: 0x37C071 VA: 0x37BF70
	public void set_size(Vector3Int value) { }

	// RVA: 0x37BF80 Offset: 0x37C081 VA: 0x37BF80
	public void .ctor(Vector3Int position, Vector3Int size) { }

	// RVA: 0x37BFA0 Offset: 0x37C0A1 VA: 0x37BFA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x37BFB0 Offset: 0x37C0B1 VA: 0x37BFB0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37C070 Offset: 0x37C171 VA: 0x37C070 Slot: 4
	public bool Equals(BoundsInt other) { }

	// RVA: 0x37C0E0 Offset: 0x37C1E1 VA: 0x37C0E0 Slot: 2
	public override int GetHashCode() { }
}

