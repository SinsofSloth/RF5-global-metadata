[IsByRefLikeAttribute] // RVA: 0x139260 Offset: 0x139361 VA: 0x139260
[ObsoleteAttribute] // RVA: 0x139260 Offset: 0x139361 VA: 0x139260
public struct MessagePackWriter // TypeDefIndex: 5165
{
	// Fields
	private BufferWriter writer; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x1399C0 Offset: 0x139AC1 VA: 0x1399C0
	private CancellationToken <CancellationToken>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x1399D0 Offset: 0x139AD1 VA: 0x1399D0
	private bool <OldSpec>k__BackingField; // 0x60

	// Properties
	public CancellationToken CancellationToken { get; set; }
	public bool OldSpec { get; set; }

	// Methods

	// RVA: 0x820 Offset: 0x921 VA: 0x820
	public void .ctor(IBufferWriter<byte> writer) { }

	// RVA: 0x8C0 Offset: 0x9C1 VA: 0x8C0
	internal void .ctor(SequencePool sequencePool, byte[] array) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A370 Offset: 0x13A471 VA: 0x13A370
	// RVA: 0x960 Offset: 0xA61 VA: 0x960
	public CancellationToken get_CancellationToken() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A380 Offset: 0x13A481 VA: 0x13A380
	// RVA: 0x970 Offset: 0xA71 VA: 0x970
	public void set_CancellationToken(CancellationToken value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A390 Offset: 0x13A491 VA: 0x13A390
	// RVA: 0x980 Offset: 0xA81 VA: 0x980
	public bool get_OldSpec() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A3A0 Offset: 0x13A4A1 VA: 0x13A3A0
	// RVA: 0x990 Offset: 0xA91 VA: 0x990
	public void set_OldSpec(bool value) { }

	// RVA: 0x9A0 Offset: 0xAA1 VA: 0x9A0
	public MessagePackWriter Clone(IBufferWriter<byte> writer) { }

	// RVA: 0xAB0 Offset: 0xBB1 VA: 0xAB0
	public void Flush() { }

	// RVA: 0xAC0 Offset: 0xBC1 VA: 0xAC0
	public void WriteNil() { }

	// RVA: 0xB70 Offset: 0xC71 VA: 0xB70
	public void WriteRaw(ReadOnlySpan<byte> rawMessagePackBlock) { }

	// RVA: 0xC60 Offset: 0xD61 VA: 0xC60
	public void WriteRaw(in ReadOnlySequence<byte> rawMessagePackBlock) { }

	// RVA: 0xC70 Offset: 0xD71 VA: 0xC70
	public void WriteArrayHeader(int count) { }

	// RVA: 0xC80 Offset: 0xD81 VA: 0xC80
	public void WriteArrayHeader(uint count) { }

	// RVA: 0xC90 Offset: 0xD91 VA: 0xC90
	public void WriteMapHeader(int count) { }

	// RVA: 0xCA0 Offset: 0xDA1 VA: 0xCA0
	public void WriteMapHeader(uint count) { }

	// RVA: 0xCB0 Offset: 0xDB1 VA: 0xCB0
	public void Write(byte value) { }

	// RVA: 0xCC0 Offset: 0xDC1 VA: 0xCC0
	public void WriteUInt8(byte value) { }

	// RVA: 0xD90 Offset: 0xE91 VA: 0xD90
	public void Write(sbyte value) { }

	// RVA: 0xDA0 Offset: 0xEA1 VA: 0xDA0
	public void WriteInt8(sbyte value) { }

	// RVA: 0xE70 Offset: 0xF71 VA: 0xE70
	public void Write(ushort value) { }

	// RVA: 0xE80 Offset: 0xF81 VA: 0xE80
	public void WriteUInt16(ushort value) { }

	// RVA: 0xE90 Offset: 0xF91 VA: 0xE90
	public void Write(short value) { }

	// RVA: 0xEA0 Offset: 0xFA1 VA: 0xEA0
	public void WriteInt16(short value) { }

	// RVA: 0xEB0 Offset: 0xFB1 VA: 0xEB0
	public void Write(uint value) { }

	// RVA: 0xEC0 Offset: 0xFC1 VA: 0xEC0
	public void WriteUInt32(uint value) { }

	// RVA: 0xED0 Offset: 0xFD1 VA: 0xED0
	public void Write(int value) { }

	// RVA: 0xEE0 Offset: 0xFE1 VA: 0xEE0
	public void WriteInt32(int value) { }

	// RVA: 0xEF0 Offset: 0xFF1 VA: 0xEF0
	public void Write(ulong value) { }

	// RVA: 0xF00 Offset: 0x1001 VA: 0xF00
	public void WriteUInt64(ulong value) { }

	// RVA: 0xF10 Offset: 0x1011 VA: 0xF10
	public void Write(long value) { }

	// RVA: 0xF20 Offset: 0x1021 VA: 0xF20
	public void WriteInt64(long value) { }

	// RVA: 0xF30 Offset: 0x1031 VA: 0xF30
	public void Write(bool value) { }

	// RVA: 0xFF0 Offset: 0x10F1 VA: 0xFF0
	public void Write(char value) { }

	// RVA: 0x1000 Offset: 0x1101 VA: 0x1000
	public void Write(float value) { }

	// RVA: 0x1010 Offset: 0x1111 VA: 0x1010
	public void Write(double value) { }

	// RVA: 0x1020 Offset: 0x1121 VA: 0x1020
	public void Write(DateTime dateTime) { }

	// RVA: 0x1030 Offset: 0x1131 VA: 0x1030
	public void Write(byte[] src) { }

	// RVA: 0x1040 Offset: 0x1141 VA: 0x1040
	public void Write(ReadOnlySpan<byte> src) { }

	// RVA: 0x1100 Offset: 0x1201 VA: 0x1100
	public void Write(in ReadOnlySequence<byte> src) { }

	// RVA: 0x1110 Offset: 0x1211 VA: 0x1110
	public void WriteBinHeader(int length) { }

	// RVA: 0x1120 Offset: 0x1221 VA: 0x1120
	public void WriteString(in ReadOnlySequence<byte> utf8stringBytes) { }

	// RVA: 0x1130 Offset: 0x1231 VA: 0x1130
	public void WriteString(ReadOnlySpan<byte> utf8stringBytes) { }

	// RVA: 0x11F0 Offset: 0x12F1 VA: 0x11F0
	public void WriteStringHeader(int byteCount) { }

	// RVA: 0x1200 Offset: 0x1301 VA: 0x1200
	public void Write(string value) { }

	// RVA: 0x1210 Offset: 0x1311 VA: 0x1210
	public void Write(ReadOnlySpan<char> value) { }

	// RVA: 0x1250 Offset: 0x1351 VA: 0x1250
	public void WriteExtensionFormatHeader(ExtensionHeader extensionHeader) { }

	// RVA: 0x1260 Offset: 0x1361 VA: 0x1260
	public void WriteExtensionFormat(ExtensionResult extensionData) { }

	// RVA: 0x12E0 Offset: 0x13E1 VA: 0x12E0
	public Span<byte> GetSpan(int length) { }

	// RVA: 0x12F0 Offset: 0x13F1 VA: 0x12F0
	public void Advance(int length) { }

	// RVA: 0x1300 Offset: 0x1401 VA: 0x1300
	internal void WriteBigEndian(ushort value) { }

	// RVA: 0x13C0 Offset: 0x14C1 VA: 0x13C0
	internal void WriteBigEndian(uint value) { }

	// RVA: 0x13D0 Offset: 0x14D1 VA: 0x13D0
	internal void WriteBigEndian(ulong value) { }

	// RVA: 0x1440 Offset: 0x1541 VA: 0x1440
	internal byte[] FlushAndGetArray() { }

	// RVA: 0x14EDCC0 Offset: 0x14EDDC1 VA: 0x14EDCC0
	private static void WriteBigEndian(short value, Span<byte> span) { }

	// RVA: 0x14EE680 Offset: 0x14EE781 VA: 0x14EE680
	private static void WriteBigEndian(int value, Span<byte> span) { }

	// RVA: 0x14EF3F0 Offset: 0x14EF4F1 VA: 0x14EF3F0
	private static void WriteBigEndian(long value, Span<byte> span) { }

	// RVA: 0x14ECD10 Offset: 0x14ECE11 VA: 0x14ECD10
	private static void WriteBigEndian(ushort value, Span<byte> span) { }

	// RVA: 0x14F17A0 Offset: 0x14F18A1 VA: 0x14F17A0
	private static void WriteBigEndian(ushort value, byte* span) { }

	// RVA: 0x14ECD90 Offset: 0x14ECE91 VA: 0x14ECD90
	private static void WriteBigEndian(uint value, Span<byte> span) { }

	// RVA: 0x14F17B0 Offset: 0x14F18B1 VA: 0x14F17B0
	private static void WriteBigEndian(uint value, byte* span) { }

	// RVA: 0x14EED30 Offset: 0x14EEE31 VA: 0x14EED30
	private static void WriteBigEndian(ulong value, Span<byte> span) { }

	// RVA: 0x14EF690 Offset: 0x14EF791 VA: 0x14EF690
	private static void WriteBigEndian(float value, Span<byte> span) { }

	// RVA: 0x14EF870 Offset: 0x14EF971 VA: 0x14EF870
	private static void WriteBigEndian(double value, Span<byte> span) { }

	// RVA: 0x1450 Offset: 0x1551 VA: 0x1450
	private ref byte WriteString_PrepareSpan(int characterLength, out int bufferSize, out int encodedBytesOffset) { }

	// RVA: 0x1460 Offset: 0x1561 VA: 0x1460
	private void WriteString_PostEncoding(byte* pBuffer, int estimatedOffset, int byteCount) { }

	// RVA: 0x14F1AE0 Offset: 0x14F1BE1 VA: 0x14F1AE0
	private static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }
}

