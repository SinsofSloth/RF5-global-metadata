[DefaultMemberAttribute] // RVA: 0x15AC90 Offset: 0x15AD91 VA: 0x15AC90
public struct TouchScreenState5.TouchStateArray5 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11604
{
	// Fields
	private const int _Length = 5;
	private TouchState _value0; // 0x0
	private TouchState _value1; // 0x28
	private TouchState _value2; // 0x50
	private TouchState _value3; // 0x78
	private TouchState _value4; // 0xA0

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x3889A0 Offset: 0x388AA1 VA: 0x3889A0
	public int get_Length() { }

	// RVA: 0x3889B0 Offset: 0x388AB1 VA: 0x3889B0 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x388AE0 Offset: 0x388BE1 VA: 0x388AE0 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x388C30 Offset: 0x388D31 VA: 0x388C30 Slot: 9
	public int get_Count() { }

	// RVA: 0x388C40 Offset: 0x388D41 VA: 0x388C40 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x388C50 Offset: 0x388D51 VA: 0x388C50 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x388C90 Offset: 0x388D91 VA: 0x388C90 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x388CD0 Offset: 0x388DD1 VA: 0x388CD0 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x388CE0 Offset: 0x388DE1 VA: 0x388CE0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7650 Offset: 0x1B7751 VA: 0x1B7650
	// RVA: 0x388CF0 Offset: 0x388DF1 VA: 0x388CF0 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x388D90 Offset: 0x388E91 VA: 0x388D90 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x388E30 Offset: 0x388F31 VA: 0x388E30 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x388E40 Offset: 0x388F41 VA: 0x388E40 Slot: 12
	public void Clear() { }

	// RVA: 0x388E50 Offset: 0x388F51 VA: 0x388E50 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x388E60 Offset: 0x388F61 VA: 0x388E60 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x388E70 Offset: 0x388F71 VA: 0x388E70 Slot: 8
	public void RemoveAt(int index) { }
}

