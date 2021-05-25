[DefaultMemberAttribute] // RVA: 0x15AB50 Offset: 0x15AC51 VA: 0x15AB50
public struct GestureState.GesturePointArray4 : IList<GesturePoint>, ICollection<GesturePoint>, IEnumerable<GesturePoint>, IEnumerable // TypeDefIndex: 11555
{
	// Fields
	private const int _Length = 4;
	private GesturePoint _value0; // 0x0
	private GesturePoint _value1; // 0x8
	private GesturePoint _value2; // 0x10
	private GesturePoint _value3; // 0x18

	// Properties
	public int Length { get; }
	public GesturePoint Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x3646F0 Offset: 0x3647F1 VA: 0x3646F0
	public int get_Length() { }

	// RVA: 0x364700 Offset: 0x364801 VA: 0x364700 Slot: 4
	public GesturePoint get_Item(int index) { }

	// RVA: 0x3647C0 Offset: 0x3648C1 VA: 0x3647C0 Slot: 5
	public void set_Item(int index, GesturePoint value) { }

	// RVA: 0x364890 Offset: 0x364991 VA: 0x364890 Slot: 9
	public int get_Count() { }

	// RVA: 0x3648A0 Offset: 0x3649A1 VA: 0x3648A0 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x3648B0 Offset: 0x3649B1 VA: 0x3648B0 Slot: 13
	public bool Contains(GesturePoint item) { }

	// RVA: 0x3649A0 Offset: 0x364AA1 VA: 0x3649A0 Slot: 6
	public int IndexOf(GesturePoint item) { }

	// RVA: 0x364A90 Offset: 0x364B91 VA: 0x364A90 Slot: 14
	public void CopyTo(GesturePoint[] array, int arrayIndex) { }

	// RVA: 0x364AA0 Offset: 0x364BA1 VA: 0x364AA0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7420 Offset: 0x1B7521 VA: 0x1B7420
	// RVA: 0x364AB0 Offset: 0x364BB1 VA: 0x364AB0 Slot: 16
	public IEnumerator<GesturePoint> GetEnumerator() { }

	// RVA: 0x364B50 Offset: 0x364C51 VA: 0x364B50 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x364BF0 Offset: 0x364CF1 VA: 0x364BF0 Slot: 11
	public void Add(GesturePoint item) { }

	// RVA: 0x364C00 Offset: 0x364D01 VA: 0x364C00 Slot: 12
	public void Clear() { }

	// RVA: 0x364C10 Offset: 0x364D11 VA: 0x364C10 Slot: 7
	public void Insert(int index, GesturePoint item) { }

	// RVA: 0x364C20 Offset: 0x364D21 VA: 0x364C20 Slot: 15
	public bool Remove(GesturePoint item) { }

	// RVA: 0x364C30 Offset: 0x364D31 VA: 0x364C30 Slot: 8
	public void RemoveAt(int index) { }
}

