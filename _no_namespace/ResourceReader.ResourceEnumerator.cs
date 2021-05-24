internal sealed class ResourceReader.ResourceEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 506
{
	// Fields
	private ResourceReader _reader; // 0x10
	private bool _currentIsValid; // 0x18
	private int _currentName; // 0x1C
	private int _dataPosition; // 0x20

	// Properties
	public object Key { get; }
	public object Current { get; }
	internal int DataPosition { get; }
	public DictionaryEntry Entry { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x17FAFB0 Offset: 0x17FB0B1 VA: 0x17FAFB0
	internal void .ctor(ResourceReader reader) { }

	// RVA: 0x17FE6F0 Offset: 0x17FE7F1 VA: 0x17FE6F0 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x17FE760 Offset: 0x17FE861 VA: 0x17FE760 Slot: 4
	public object get_Key() { }

	// RVA: 0x17FE840 Offset: 0x17FE941 VA: 0x17FE840 Slot: 8
	public object get_Current() { }

	// RVA: 0x17FEC20 Offset: 0x17FED21 VA: 0x17FEC20
	internal int get_DataPosition() { }

	// RVA: 0x17FE8B0 Offset: 0x17FE9B1 VA: 0x17FE8B0 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x17FEC30 Offset: 0x17FED31 VA: 0x17FEC30 Slot: 5
	public object get_Value() { }

	// RVA: 0x17FED00 Offset: 0x17FEE01 VA: 0x17FED00 Slot: 9
	public void Reset() { }
}

