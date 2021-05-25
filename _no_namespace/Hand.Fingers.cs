[DefaultMemberAttribute] // RVA: 0x15AA10 Offset: 0x15AB11 VA: 0x15AA10
public struct Hand.Fingers : IList<Finger>, ICollection<Finger>, IEnumerable<Finger>, IEnumerable // TypeDefIndex: 11505
{
	// Fields
	private const int _Length = 5;
	public Finger thumb; // 0x0
	public Finger index; // 0x1C
	public Finger middle; // 0x38
	public Finger ring; // 0x54
	public Finger little; // 0x70

	// Properties
	public int Length { get; }
	public Finger Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x38B4B0 Offset: 0x38B5B1 VA: 0x38B4B0
	public int get_Length() { }

	// RVA: 0x38B4C0 Offset: 0x38B5C1 VA: 0x38B4C0 Slot: 4
	public Finger get_Item(int index) { }

	// RVA: 0x38B5E0 Offset: 0x38B6E1 VA: 0x38B5E0 Slot: 5
	public void set_Item(int index, Finger value) { }

	// RVA: 0x38B740 Offset: 0x38B841 VA: 0x38B740 Slot: 9
	public int get_Count() { }

	// RVA: 0x38B750 Offset: 0x38B851 VA: 0x38B750 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x38B760 Offset: 0x38B861 VA: 0x38B760 Slot: 13
	public bool Contains(Finger item) { }

	// RVA: 0x38B7A0 Offset: 0x38B8A1 VA: 0x38B7A0 Slot: 6
	public int IndexOf(Finger item) { }

	// RVA: 0x38B7E0 Offset: 0x38B8E1 VA: 0x38B7E0 Slot: 14
	public void CopyTo(Finger[] array, int arrayIndex) { }

	// RVA: 0x38B7F0 Offset: 0x38B8F1 VA: 0x38B7F0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B71F0 Offset: 0x1B72F1 VA: 0x1B71F0
	// RVA: 0x38B800 Offset: 0x38B901 VA: 0x38B800 Slot: 16
	public IEnumerator<Finger> GetEnumerator() { }

	// RVA: 0x38B8A0 Offset: 0x38B9A1 VA: 0x38B8A0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x38B940 Offset: 0x38BA41 VA: 0x38B940 Slot: 11
	public void Add(Finger item) { }

	// RVA: 0x38B950 Offset: 0x38BA51 VA: 0x38B950 Slot: 12
	public void Clear() { }

	// RVA: 0x38B960 Offset: 0x38BA61 VA: 0x38B960 Slot: 7
	public void Insert(int index, Finger item) { }

	// RVA: 0x38B970 Offset: 0x38BA71 VA: 0x38B970 Slot: 15
	public bool Remove(Finger item) { }

	// RVA: 0x38B980 Offset: 0x38BA81 VA: 0x38B980 Slot: 8
	public void RemoveAt(int index) { }
}

