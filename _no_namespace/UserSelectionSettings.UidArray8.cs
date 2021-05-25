[DefaultMemberAttribute] // RVA: 0x15AFD0 Offset: 0x15B0D1 VA: 0x15AFD0
public struct UserSelectionSettings.UidArray8 : IList<Uid>, ICollection<Uid>, IEnumerable<Uid>, IEnumerable // TypeDefIndex: 11715
{
	// Fields
	private const int _Length = 8;
	private Uid _value0; // 0x0
	private Uid _value1; // 0x10
	private Uid _value2; // 0x20
	private Uid _value3; // 0x30
	private Uid _value4; // 0x40
	private Uid _value5; // 0x50
	private Uid _value6; // 0x60
	private Uid _value7; // 0x70

	// Properties
	public int Length { get; }
	public Uid Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x361C30 Offset: 0x361D31 VA: 0x361C30
	public int get_Length() { }

	// RVA: 0x361C40 Offset: 0x361D41 VA: 0x361C40 Slot: 4
	public Uid get_Item(int index) { }

	// RVA: 0x361D50 Offset: 0x361E51 VA: 0x361D50 Slot: 5
	public void set_Item(int index, Uid value) { }

	// RVA: 0x361D60 Offset: 0x361E61 VA: 0x361D60 Slot: 9
	public int get_Count() { }

	// RVA: 0x361D70 Offset: 0x361E71 VA: 0x361D70 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x361D80 Offset: 0x361E81 VA: 0x361D80 Slot: 13
	public bool Contains(Uid item) { }

	// RVA: 0x361D90 Offset: 0x361E91 VA: 0x361D90 Slot: 6
	public int IndexOf(Uid item) { }

	// RVA: 0x361DA0 Offset: 0x361EA1 VA: 0x361DA0 Slot: 14
	public void CopyTo(Uid[] array, int arrayIndex) { }

	// RVA: 0x361DB0 Offset: 0x361EB1 VA: 0x361DB0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7C00 Offset: 0x1B7D01 VA: 0x1B7C00
	// RVA: 0x361DC0 Offset: 0x361EC1 VA: 0x361DC0 Slot: 16
	public IEnumerator<Uid> GetEnumerator() { }

	// RVA: 0x361EC0 Offset: 0x361FC1 VA: 0x361EC0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x361FC0 Offset: 0x3620C1 VA: 0x361FC0 Slot: 11
	public void Add(Uid item) { }

	// RVA: 0x361FD0 Offset: 0x3620D1 VA: 0x361FD0 Slot: 12
	public void Clear() { }

	// RVA: 0x361FE0 Offset: 0x3620E1 VA: 0x361FE0 Slot: 7
	public void Insert(int index, Uid item) { }

	// RVA: 0x361FF0 Offset: 0x3620F1 VA: 0x361FF0 Slot: 15
	public bool Remove(Uid item) { }

	// RVA: 0x362000 Offset: 0x362101 VA: 0x362000 Slot: 8
	public void RemoveAt(int index) { }
}

