[DefaultMemberAttribute] // RVA: 0x15AC10 Offset: 0x15AD11 VA: 0x15AC10
public struct TouchScreenState3.TouchStateArray3 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11598
{
	// Fields
	private const int _Length = 3;
	private TouchState _value0; // 0x0
	private TouchState _value1; // 0x28
	private TouchState _value2; // 0x50

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x387E90 Offset: 0x387F91 VA: 0x387E90
	public int get_Length() { }

	// RVA: 0x387EA0 Offset: 0x387FA1 VA: 0x387EA0 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x387F90 Offset: 0x388091 VA: 0x387F90 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x3880A0 Offset: 0x3881A1 VA: 0x3880A0 Slot: 9
	public int get_Count() { }

	// RVA: 0x3880B0 Offset: 0x3881B1 VA: 0x3880B0 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x3880C0 Offset: 0x3881C1 VA: 0x3880C0 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x388100 Offset: 0x388201 VA: 0x388100 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x388140 Offset: 0x388241 VA: 0x388140 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x388150 Offset: 0x388251 VA: 0x388150 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7570 Offset: 0x1B7671 VA: 0x1B7570
	// RVA: 0x388240 Offset: 0x388341 VA: 0x388240 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x388340 Offset: 0x388441 VA: 0x388340 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x388440 Offset: 0x388541 VA: 0x388440 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x388450 Offset: 0x388551 VA: 0x388450 Slot: 12
	public void Clear() { }

	// RVA: 0x388460 Offset: 0x388561 VA: 0x388460 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x388470 Offset: 0x388571 VA: 0x388470 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x388480 Offset: 0x388581 VA: 0x388480 Slot: 8
	public void RemoveAt(int index) { }
}

