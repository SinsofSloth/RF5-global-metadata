public struct DirectoryEntry // TypeDefIndex: 11653
{
	// Fields
	public string name; // 0x0
	private byte _reserved0; // 0x8
	private byte _reserved1; // 0x9
	private byte _reserved2; // 0xA
	private sbyte _entryType; // 0xB
	private byte _reserved3; // 0xC
	private byte _reserved4; // 0xD
	private byte _reserved5; // 0xE
	private long fileSize; // 0x10

	// Properties
	public EntryType entryType { get; set; }

	// Methods

	// RVA: 0x363B10 Offset: 0x363C11 VA: 0x363B10
	public EntryType get_entryType() { }

	// RVA: 0x363B20 Offset: 0x363C21 VA: 0x363B20
	public void set_entryType(EntryType value) { }

	// RVA: 0x363B30 Offset: 0x363C31 VA: 0x363B30 Slot: 3
	public override string ToString() { }
}

