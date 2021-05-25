[DefaultMemberAttribute] // RVA: 0x15AB10 Offset: 0x15AC11 VA: 0x15AB10
public struct ControllerSupportArg.Color4u8Array8 : IList<Color4u8>, ICollection<Color4u8>, IEnumerable<Color4u8>, IEnumerable // TypeDefIndex: 11539
{
	// Fields
	private const int _Length = 8;
	private Color4u8 _value0; // 0x0
	private Color4u8 _value1; // 0x4
	private Color4u8 _value2; // 0x8
	private Color4u8 _value3; // 0xC
	private Color4u8 _value4; // 0x10
	private Color4u8 _value5; // 0x14
	private Color4u8 _value6; // 0x18
	private Color4u8 _value7; // 0x1C

	// Properties
	public int Length { get; }
	public Color4u8 Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x363FC0 Offset: 0x3640C1 VA: 0x363FC0
	public int get_Length() { }

	// RVA: 0x363FD0 Offset: 0x3640D1 VA: 0x363FD0 Slot: 4
	public Color4u8 get_Item(int index) { }

	// RVA: 0x3640B0 Offset: 0x3641B1 VA: 0x3640B0 Slot: 5
	public void set_Item(int index, Color4u8 value) { }

	// RVA: 0x3641F0 Offset: 0x3642F1 VA: 0x3641F0 Slot: 9
	public int get_Count() { }

	// RVA: 0x364200 Offset: 0x364301 VA: 0x364200 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x364210 Offset: 0x364311 VA: 0x364210 Slot: 13
	public bool Contains(Color4u8 item) { }

	// RVA: 0x364220 Offset: 0x364321 VA: 0x364220 Slot: 6
	public int IndexOf(Color4u8 item) { }

	// RVA: 0x364230 Offset: 0x364331 VA: 0x364230 Slot: 14
	public void CopyTo(Color4u8[] array, int arrayIndex) { }

	// RVA: 0x364240 Offset: 0x364341 VA: 0x364240 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B73B0 Offset: 0x1B74B1 VA: 0x1B73B0
	// RVA: 0x364250 Offset: 0x364351 VA: 0x364250 Slot: 16
	public IEnumerator<Color4u8> GetEnumerator() { }

	// RVA: 0x3642F0 Offset: 0x3643F1 VA: 0x3642F0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x364390 Offset: 0x364491 VA: 0x364390 Slot: 11
	public void Add(Color4u8 item) { }

	// RVA: 0x3643A0 Offset: 0x3644A1 VA: 0x3643A0 Slot: 12
	public void Clear() { }

	// RVA: 0x3643B0 Offset: 0x3644B1 VA: 0x3643B0 Slot: 7
	public void Insert(int index, Color4u8 item) { }

	// RVA: 0x3643C0 Offset: 0x3644C1 VA: 0x3643C0 Slot: 15
	public bool Remove(Color4u8 item) { }

	// RVA: 0x3643D0 Offset: 0x3644D1 VA: 0x3643D0 Slot: 8
	public void RemoveAt(int index) { }
}

