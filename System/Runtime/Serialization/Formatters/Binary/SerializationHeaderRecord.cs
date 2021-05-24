internal sealed class SerializationHeaderRecord // TypeDefIndex: 1044
{
	// Fields
	internal int binaryFormatterMajorVersion; // 0x10
	internal int binaryFormatterMinorVersion; // 0x14
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x18
	internal int topId; // 0x1C
	internal int headerId; // 0x20
	internal int majorVersion; // 0x24
	internal int minorVersion; // 0x28

	// Methods

	// RVA: 0x150A9E0 Offset: 0x150AAE1 VA: 0x150A9E0
	internal void .ctor() { }

	// RVA: 0x150A9F0 Offset: 0x150AAF1 VA: 0x150A9F0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	// RVA: 0x150AA50 Offset: 0x150AB51 VA: 0x150AA50 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x150AB60 Offset: 0x150AC61 VA: 0x150AB60
	private static int GetInt32(byte[] buffer, int index) { }

	// RVA: 0x150ABE0 Offset: 0x150ACE1 VA: 0x150ABE0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x150ADC0 Offset: 0x150AEC1 VA: 0x150ADC0
	public void Dump() { }
}

