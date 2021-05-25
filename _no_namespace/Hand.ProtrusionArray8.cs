[DefaultMemberAttribute] // RVA: 0x15A9D0 Offset: 0x15AAD1 VA: 0x15A9D0
public struct Hand.ProtrusionArray8 : IList<Protrusion>, ICollection<Protrusion>, IEnumerable<Protrusion>, IEnumerable // TypeDefIndex: 11503
{
	// Fields
	private const int _Length = 8;
	private Protrusion _value0; // 0x0
	private Protrusion _value1; // 0x8
	private Protrusion _value2; // 0x10
	private Protrusion _value3; // 0x18
	private Protrusion _value4; // 0x20
	private Protrusion _value5; // 0x28
	private Protrusion _value6; // 0x30
	private Protrusion _value7; // 0x38

	// Properties
	public int Length { get; }
	public Protrusion Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x39EC20 Offset: 0x39ED21 VA: 0x39EC20
	public int get_Length() { }

	// RVA: 0x39EC30 Offset: 0x39ED31 VA: 0x39EC30 Slot: 4
	public Protrusion get_Item(int index) { }

	// RVA: 0x39ED10 Offset: 0x39EE11 VA: 0x39ED10 Slot: 5
	public void set_Item(int index, Protrusion value) { }

	// RVA: 0x39EE00 Offset: 0x39EF01 VA: 0x39EE00 Slot: 9
	public int get_Count() { }

	// RVA: 0x39EE10 Offset: 0x39EF11 VA: 0x39EE10 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x39EE20 Offset: 0x39EF21 VA: 0x39EE20 Slot: 13
	public bool Contains(Protrusion item) { }

	// RVA: 0x39EE30 Offset: 0x39EF31 VA: 0x39EE30 Slot: 6
	public int IndexOf(Protrusion item) { }

	// RVA: 0x39EE40 Offset: 0x39EF41 VA: 0x39EE40 Slot: 14
	public void CopyTo(Protrusion[] array, int arrayIndex) { }

	// RVA: 0x39EE50 Offset: 0x39EF51 VA: 0x39EE50 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7180 Offset: 0x1B7281 VA: 0x1B7180
	// RVA: 0x39EE60 Offset: 0x39EF61 VA: 0x39EE60 Slot: 16
	public IEnumerator<Protrusion> GetEnumerator() { }

	// RVA: 0x39EF30 Offset: 0x39F031 VA: 0x39EF30 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x39F000 Offset: 0x39F101 VA: 0x39F000 Slot: 11
	public void Add(Protrusion item) { }

	// RVA: 0x39F010 Offset: 0x39F111 VA: 0x39F010 Slot: 12
	public void Clear() { }

	// RVA: 0x39F020 Offset: 0x39F121 VA: 0x39F020 Slot: 7
	public void Insert(int index, Protrusion item) { }

	// RVA: 0x39F030 Offset: 0x39F131 VA: 0x39F030 Slot: 15
	public bool Remove(Protrusion item) { }

	// RVA: 0x39F040 Offset: 0x39F141 VA: 0x39F040 Slot: 8
	public void RemoveAt(int index) { }
}

