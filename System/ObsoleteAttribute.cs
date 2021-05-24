[ComVisibleAttribute] // RVA: 0xAC4B0 Offset: 0xAC5B1 VA: 0xAC4B0
[AttributeUsageAttribute] // RVA: 0xAC4B0 Offset: 0xAC5B1 VA: 0xAC4B0
[Serializable]
public sealed class ObsoleteAttribute : Attribute // TypeDefIndex: 290
{
	// Fields
	private string _message; // 0x10
	private bool _error; // 0x18

	// Properties
	public string Message { get; }

	// Methods

	// RVA: 0x18EBB30 Offset: 0x18EBC31 VA: 0x18EBB30
	public void .ctor() { }

	// RVA: 0x18EBB70 Offset: 0x18EBC71 VA: 0x18EBB70
	public void .ctor(string message) { }

	// RVA: 0x18EBBB0 Offset: 0x18EBCB1 VA: 0x18EBBB0
	public void .ctor(string message, bool error) { }

	// RVA: 0x18EBC00 Offset: 0x18EBD01 VA: 0x18EBC00
	public string get_Message() { }
}

