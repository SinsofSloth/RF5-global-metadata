internal struct GuidBits // TypeDefIndex: 5293
{
	// Fields
	public readonly Guid Value; // 0x0
	public readonly byte Byte0; // 0x0
	public readonly byte Byte1; // 0x1
	public readonly byte Byte2; // 0x2
	public readonly byte Byte3; // 0x3
	public readonly byte Byte4; // 0x4
	public readonly byte Byte5; // 0x5
	public readonly byte Byte6; // 0x6
	public readonly byte Byte7; // 0x7
	public readonly byte Byte8; // 0x8
	public readonly byte Byte9; // 0x9
	public readonly byte Byte10; // 0xA
	public readonly byte Byte11; // 0xB
	public readonly byte Byte12; // 0xC
	public readonly byte Byte13; // 0xD
	public readonly byte Byte14; // 0xE
	public readonly byte Byte15; // 0xF

	// Methods

	// RVA: 0x167E910 Offset: 0x167EA11 VA: 0x167E910
	private static ReadOnlySpan<byte> GetByteToHexStringHigh() { }

	// RVA: 0x167E980 Offset: 0x167EA81 VA: 0x167E980
	private static ReadOnlySpan<byte> GetByteToHexStringLow() { }

	// RVA: 0x6700 Offset: 0x6801 VA: 0x6700
	public void .ctor(ref Guid value) { }

	// RVA: 0x6710 Offset: 0x6811 VA: 0x6710
	public void .ctor(ReadOnlySpan<byte> utf8string) { }

	// RVA: 0x167F220 Offset: 0x167F321 VA: 0x167F220
	private static byte Parse(ReadOnlySpan<byte> bytes, int highOffset) { }

	// RVA: 0x167F3D0 Offset: 0x167F4D1 VA: 0x167F3D0
	private static byte SwitchParse(byte b) { }

	// RVA: 0x6750 Offset: 0x6851 VA: 0x6750
	public void Write(Span<byte> buffer) { }
}

