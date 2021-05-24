[Serializable]
public struct ConsoleKeyInfo // TypeDefIndex: 200
{
	// Fields
	private char _keyChar; // 0x0
	private ConsoleKey _key; // 0x4
	private ConsoleModifiers _mods; // 0x8

	// Properties
	public char KeyChar { get; }
	public ConsoleKey Key { get; }

	// Methods

	// RVA: 0x372E60 Offset: 0x372F61 VA: 0x372E60
	public void .ctor(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

	// RVA: 0x372F50 Offset: 0x373051 VA: 0x372F50
	public char get_KeyChar() { }

	// RVA: 0x372F60 Offset: 0x373061 VA: 0x372F60
	public ConsoleKey get_Key() { }

	// RVA: 0x372F70 Offset: 0x373071 VA: 0x372F70 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x373060 Offset: 0x373161 VA: 0x373060
	public bool Equals(ConsoleKeyInfo obj) { }

	// RVA: 0x3730A0 Offset: 0x3731A1 VA: 0x3730A0 Slot: 2
	public override int GetHashCode() { }
}

