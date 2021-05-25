[DefaultMemberAttribute] // RVA: 0x15AB90 Offset: 0x15AC91 VA: 0x15AB90
public struct TouchScreenState1.TouchStateArray1 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable // TypeDefIndex: 11592
{
	// Fields
	private const int _Length = 1;
	private TouchState _value0; // 0x0

	// Properties
	public int Length { get; }
	public TouchState Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x3856E0 Offset: 0x3857E1 VA: 0x3856E0
	public int get_Length() { }

	// RVA: 0x3856F0 Offset: 0x3857F1 VA: 0x3856F0 Slot: 4
	public TouchState get_Item(int index) { }

	// RVA: 0x385790 Offset: 0x385891 VA: 0x385790 Slot: 5
	public void set_Item(int index, TouchState value) { }

	// RVA: 0x385850 Offset: 0x385951 VA: 0x385850 Slot: 9
	public int get_Count() { }

	// RVA: 0x385860 Offset: 0x385961 VA: 0x385860 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x385870 Offset: 0x385971 VA: 0x385870 Slot: 13
	public bool Contains(TouchState item) { }

	// RVA: 0x385960 Offset: 0x385A61 VA: 0x385960 Slot: 6
	public int IndexOf(TouchState item) { }

	// RVA: 0x385A50 Offset: 0x385B51 VA: 0x385A50 Slot: 14
	public void CopyTo(TouchState[] array, int arrayIndex) { }

	// RVA: 0x385A60 Offset: 0x385B61 VA: 0x385A60 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7490 Offset: 0x1B7591 VA: 0x1B7490
	// RVA: 0x385AF0 Offset: 0x385BF1 VA: 0x385AF0 Slot: 16
	public IEnumerator<TouchState> GetEnumerator() { }

	// RVA: 0x385BA0 Offset: 0x385CA1 VA: 0x385BA0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x385C50 Offset: 0x385D51 VA: 0x385C50 Slot: 11
	public void Add(TouchState item) { }

	// RVA: 0x385C60 Offset: 0x385D61 VA: 0x385C60 Slot: 12
	public void Clear() { }

	// RVA: 0x385C70 Offset: 0x385D71 VA: 0x385C70 Slot: 7
	public void Insert(int index, TouchState item) { }

	// RVA: 0x385C80 Offset: 0x385D81 VA: 0x385C80 Slot: 15
	public bool Remove(TouchState item) { }

	// RVA: 0x385C90 Offset: 0x385D91 VA: 0x385C90 Slot: 8
	public void RemoveAt(int index) { }
}

