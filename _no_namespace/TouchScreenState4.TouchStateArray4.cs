[DefaultMemberAttribute] // RVA: 0x15AC50 Offset: 0x15AD51 VA: 0x15AC50
public struct TouchScreenState4.TouchStateArray4 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11601
{
	// Fields
	private const int _Length = 4;
	private TouchState _value0; // 0x0
	private TouchState _value1; // 0x28
	private TouchState _value2; // 0x50
	private TouchState _value3; // 0x78

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x3884C0 Offset: 0x3885C1 VA: 0x3884C0
	public int get_Length() { }

	// RVA: 0x3884D0 Offset: 0x3885D1 VA: 0x3884D0 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x3885E0 Offset: 0x3886E1 VA: 0x3885E0 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x388710 Offset: 0x388811 VA: 0x388710 Slot: 9
	public int get_Count() { }

	// RVA: 0x388720 Offset: 0x388821 VA: 0x388720 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x388730 Offset: 0x388831 VA: 0x388730 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x388770 Offset: 0x388871 VA: 0x388770 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x3887B0 Offset: 0x3888B1 VA: 0x3887B0 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x3887C0 Offset: 0x3888C1 VA: 0x3887C0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B75E0 Offset: 0x1B76E1 VA: 0x1B75E0
	// RVA: 0x3887D0 Offset: 0x3888D1 VA: 0x3887D0 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x388870 Offset: 0x388971 VA: 0x388870 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x388910 Offset: 0x388A11 VA: 0x388910 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x388920 Offset: 0x388A21 VA: 0x388920 Slot: 12
	public void Clear() { }

	// RVA: 0x388930 Offset: 0x388A31 VA: 0x388930 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x388940 Offset: 0x388A41 VA: 0x388940 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x388950 Offset: 0x388A51 VA: 0x388950 Slot: 8
	public void RemoveAt(int index) { }
}

