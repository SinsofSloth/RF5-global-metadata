[ComVisibleAttribute] // RVA: 0xB0810 Offset: 0xB0911 VA: 0xB0810
public struct SerializationEntry // TypeDefIndex: 1032
{
	// Fields
	private Type m_type; // 0x0
	private object m_value; // 0x8
	private string m_name; // 0x10

	// Properties
	public object Value { get; }
	public string Name { get; }

	// Methods

	// RVA: 0x1AF0 Offset: 0x1BF1 VA: 0x1AF0
	public object get_Value() { }

	// RVA: 0x1B00 Offset: 0x1C01 VA: 0x1B00
	public string get_Name() { }

	// RVA: 0x1B10 Offset: 0x1C11 VA: 0x1B10
	internal void .ctor(string entryName, object entryValue, Type entryType) { }
}

