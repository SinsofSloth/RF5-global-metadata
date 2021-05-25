[DefaultMemberAttribute] // RVA: 0x15AA50 Offset: 0x15AB51 VA: 0x15AA50
public struct HandAnalysisSilhouetteState.ShapeArray16 : IList<Shape>, ICollection<Shape>, IEnumerable<Shape>, IEnumerable // TypeDefIndex: 11509
{
	// Fields
	private const int _Length = 16;
	private Shape _value0; // 0x0
	private Shape _value1; // 0x14
	private Shape _value2; // 0x28
	private Shape _value3; // 0x3C
	private Shape _value4; // 0x50
	private Shape _value5; // 0x64
	private Shape _value6; // 0x78
	private Shape _value7; // 0x8C
	private Shape _value8; // 0xA0
	private Shape _value9; // 0xB4
	private Shape _value10; // 0xC8
	private Shape _value11; // 0xDC
	private Shape _value12; // 0xF0
	private Shape _value13; // 0x104
	private Shape _value14; // 0x118
	private Shape _value15; // 0x12C

	// Properties
	public int Length { get; }
	public Shape Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x39F810 Offset: 0x39F911 VA: 0x39F810
	public int get_Length() { }

	// RVA: 0x39F820 Offset: 0x39F921 VA: 0x39F820 Slot: 4
	public Shape get_Item(int index) { }

	// RVA: 0x39F830 Offset: 0x39F931 VA: 0x39F830 Slot: 5
	public void set_Item(int index, Shape value) { }

	// RVA: 0x39F870 Offset: 0x39F971 VA: 0x39F870 Slot: 9
	public int get_Count() { }

	// RVA: 0x39F880 Offset: 0x39F981 VA: 0x39F880 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x39F890 Offset: 0x39F991 VA: 0x39F890 Slot: 13
	public bool Contains(Shape item) { }

	// RVA: 0x39F930 Offset: 0x39FA31 VA: 0x39F930 Slot: 6
	public int IndexOf(Shape item) { }

	// RVA: 0x39F9E0 Offset: 0x39FAE1 VA: 0x39F9E0 Slot: 14
	public void CopyTo(Shape[] array, int arrayIndex) { }

	// RVA: 0x39F9F0 Offset: 0x39FAF1 VA: 0x39F9F0 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1B7260 Offset: 0x1B7361 VA: 0x1B7260
	// RVA: 0x39FA00 Offset: 0x39FB01 VA: 0x39FA00 Slot: 16
	public IEnumerator<Shape> GetEnumerator() { }

	// RVA: 0x39FAA0 Offset: 0x39FBA1 VA: 0x39FAA0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x39FB40 Offset: 0x39FC41 VA: 0x39FB40 Slot: 11
	public void Add(Shape item) { }

	// RVA: 0x39FB50 Offset: 0x39FC51 VA: 0x39FB50 Slot: 12
	public void Clear() { }

	// RVA: 0x39FB60 Offset: 0x39FC61 VA: 0x39FB60 Slot: 7
	public void Insert(int index, Shape item) { }

	// RVA: 0x39FB70 Offset: 0x39FC71 VA: 0x39FB70 Slot: 15
	public bool Remove(Shape item) { }

	// RVA: 0x39FB80 Offset: 0x39FC81 VA: 0x39FB80 Slot: 8
	public void RemoveAt(int index) { }
}

