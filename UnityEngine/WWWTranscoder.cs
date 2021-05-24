[VisibleToOtherModulesAttribute] // RVA: 0x104AC0 Offset: 0x104BC1 VA: 0x104AC0
internal class WWWTranscoder // TypeDefIndex: 3706
{
	// Fields
	private static byte[] ucHexChars; // 0x0
	private static byte[] lcHexChars; // 0x8
	private static byte urlEscapeChar; // 0x10
	private static byte[] urlSpace; // 0x18
	private static byte[] dataSpace; // 0x20
	private static byte[] urlForbidden; // 0x28
	private static byte qpEscapeChar; // 0x30
	private static byte[] qpSpace; // 0x38
	private static byte[] qpForbidden; // 0x40

	// Methods

	// RVA: 0x1BBE040 Offset: 0x1BBE141 VA: 0x1BBE040
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x1BBE100 Offset: 0x1BBE201 VA: 0x1BBE100
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x1BBE570 Offset: 0x1BBE671 VA: 0x1BBE570
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x1BBE180 Offset: 0x1BBE281 VA: 0x1BBE180
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x1BBE610 Offset: 0x1BBE711 VA: 0x1BBE610
	private static void .cctor() { }
}

