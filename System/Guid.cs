[ComVisibleAttribute] // RVA: 0xAC070 Offset: 0xAC171 VA: 0xAC070
[Serializable]
public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid> // TypeDefIndex: 251
{
	// Fields
	public static readonly Guid Empty; // 0x0
	private int _a; // 0x0
	private short _b; // 0x4
	private short _c; // 0x6
	private byte _d; // 0x8
	private byte _e; // 0x9
	private byte _f; // 0xA
	private byte _g; // 0xB
	private byte _h; // 0xC
	private byte _i; // 0xD
	private byte _j; // 0xE
	private byte _k; // 0xF
	private static object _rngAccess; // 0x10
	private static RandomNumberGenerator _rng; // 0x18
	private static RandomNumberGenerator _fastRng; // 0x20

	// Methods

	// RVA: 0x153A0 Offset: 0x154A1 VA: 0x153A0
	public void .ctor(byte[] b) { }

	// RVA: 0x153B0 Offset: 0x154B1 VA: 0x153B0
	public void .ctor(int a, short b, short c, byte[] d) { }

	// RVA: 0x153C0 Offset: 0x154C1 VA: 0x153C0
	public void .ctor(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	// RVA: 0x15400 Offset: 0x15501 VA: 0x15400
	public void .ctor(string g) { }

	// RVA: 0x19CDFC0 Offset: 0x19CE0C1 VA: 0x19CDFC0
	public static Guid Parse(string input) { }

	// RVA: 0x19CE120 Offset: 0x19CE221 VA: 0x19CE120
	public static bool TryParse(string input, out Guid result) { }

	// RVA: 0x19CDB50 Offset: 0x19CDC51 VA: 0x19CDB50
	private static bool TryParseGuid(string g, Guid.GuidStyles flags, ref Guid.GuidResult result) { }

	// RVA: 0x19CE710 Offset: 0x19CE811 VA: 0x19CE710
	private static bool TryParseGuidWithHexPrefix(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x19CED80 Offset: 0x19CEE81 VA: 0x19CED80
	private static bool TryParseGuidWithNoStyle(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x19CE270 Offset: 0x19CE371 VA: 0x19CE270
	private static bool TryParseGuidWithDashes(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x19CF5B0 Offset: 0x19CF6B1 VA: 0x19CF5B0
	private static bool StringToShort(string str, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x19CF810 Offset: 0x19CF911 VA: 0x19CF810
	private static bool StringToShort(string str, int* parsePos, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x19CF510 Offset: 0x19CF611 VA: 0x19CF510
	private static bool StringToInt(string str, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x19CF760 Offset: 0x19CF861 VA: 0x19CF760
	private static bool StringToInt(string str, ref int parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x19CF8D0 Offset: 0x19CF9D1 VA: 0x19CF8D0
	private static bool StringToInt(string str, int* parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x19CF6C0 Offset: 0x19CF7C1 VA: 0x19CF6C0
	private static bool StringToLong(string str, ref int parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x19CFB00 Offset: 0x19CFC01 VA: 0x19CFB00
	private static bool StringToLong(string str, int* parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x19CF250 Offset: 0x19CF351 VA: 0x19CF250
	private static string EatAllWhitespace(string str) { }

	// RVA: 0x19CF3E0 Offset: 0x19CF4E1 VA: 0x19CF3E0
	private static bool IsHexPrefix(string str, int i) { }

	// RVA: 0x15410 Offset: 0x15511 VA: 0x15410
	public byte[] ToByteArray() { }

	// RVA: 0x15420 Offset: 0x15521 VA: 0x15420 Slot: 3
	public override string ToString() { }

	// RVA: 0x15470 Offset: 0x15571 VA: 0x15470 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x154A0 Offset: 0x155A1 VA: 0x154A0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x154B0 Offset: 0x155B1 VA: 0x154B0 Slot: 7
	public bool Equals(Guid g) { }

	// RVA: 0x155B0 Offset: 0x156B1 VA: 0x155B0
	private int GetResult(uint me, uint them) { }

	// RVA: 0x155C0 Offset: 0x156C1 VA: 0x155C0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x155D0 Offset: 0x156D1 VA: 0x155D0 Slot: 6
	public int CompareTo(Guid value) { }

	// RVA: 0x19D0C60 Offset: 0x19D0D61 VA: 0x19D0C60
	public static bool op_Equality(Guid a, Guid b) { }

	// RVA: 0x155E0 Offset: 0x156E1 VA: 0x155E0
	public string ToString(string format) { }

	// RVA: 0x19D0D20 Offset: 0x19D0E21 VA: 0x19D0D20
	private static char HexToChar(int a) { }

	// RVA: 0x19D0D40 Offset: 0x19D0E41 VA: 0x19D0D40
	private static int HexsToChars(char* guidChars, int offset, int a, int b) { }

	// RVA: 0x19D0DD0 Offset: 0x19D0ED1 VA: 0x19D0DD0
	private static int HexsToChars(char* guidChars, int offset, int a, int b, bool hex) { }

	// RVA: 0x155F0 Offset: 0x156F1 VA: 0x155F0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x19D0F40 Offset: 0x19D1041 VA: 0x19D0F40
	public static Guid NewGuid() { }

	// RVA: 0x19D1150 Offset: 0x19D1251 VA: 0x19D1150
	private static void .cctor() { }
}

