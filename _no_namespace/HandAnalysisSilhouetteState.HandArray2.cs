[DefaultMemberAttribute] // RVA: 0x15AA90 Offset: 0x15AB91 VA: 0x15AA90
public struct HandAnalysisSilhouetteState.HandArray2 : IList<Hand>, ICollection<Hand>, IEnumerable<Hand>, IEnumerable // TypeDefIndex: 11511
{
	// Fields
	private const int _Length = 2;
	private Hand _value0; // 0x0
	private Hand _value1; // 0x104

	// Properties
	public int Length { get; }
	public Hand Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x39F210 Offset: 0x39F311 VA: 0x39F210
	public int get_Length() { }

	// RVA: 0x39F220 Offset: 0x39F321 VA: 0x39F220 Slot: 4
	public Hand get_Item(int index) { }

	// RVA: 0x39F2C0 Offset: 0x39F3C1 VA: 0x39F2C0 Slot: 5
	public void set_Item(int index, Hand value) { }

	// RVA: 0x39F380 Offset: 0x39F481 VA: 0x39F380 Slot: 9
	public int get_Count() { }

	// RVA: 0x39F390 Offset: 0x39F491 VA: 0x39F390 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x39F3A0 Offset: 0x39F4A1 VA: 0x39F3A0 Slot: 13
	public bool Contains(Hand item) { }

	// RVA: 0x39F4A0 Offset: 0x39F5A1 VA: 0x39F4A0 Slot: 6
	public int IndexOf(Hand item) { }

	// RVA: 0x39F5B0 Offset: 0x39F6B1 VA: 0x39F5B0 Slot: 14
	public void CopyTo(Hand[] array, int arrayIndex) { }

	// RVA: 0x39F5C0 Offset: 0x39F6C1 VA: 0x39F5C0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B72D0 Offset: 0x1B73D1 VA: 0x1B72D0
	// RVA: 0x39F680 Offset: 0x39F781 VA: 0x39F680 Slot: 16
	public IEnumerator<Hand> GetEnumerator() { }

	// RVA: 0x39F720 Offset: 0x39F821 VA: 0x39F720 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x39F7C0 Offset: 0x39F8C1 VA: 0x39F7C0 Slot: 11
	public void Add(Hand item) { }

	// RVA: 0x39F7D0 Offset: 0x39F8D1 VA: 0x39F7D0 Slot: 12
	public void Clear() { }

	// RVA: 0x39F7E0 Offset: 0x39F8E1 VA: 0x39F7E0 Slot: 7
	public void Insert(int index, Hand item) { }

	// RVA: 0x39F7F0 Offset: 0x39F8F1 VA: 0x39F7F0 Slot: 15
	public bool Remove(Hand item) { }

	// RVA: 0x39F800 Offset: 0x39F901 VA: 0x39F800 Slot: 8
	public void RemoveAt(int index) { }
}

