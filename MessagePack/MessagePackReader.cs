[IsByRefLikeAttribute] // RVA: 0x139210 Offset: 0x139311 VA: 0x139210
[ObsoleteAttribute] // RVA: 0x139210 Offset: 0x139311 VA: 0x139210
public struct MessagePackReader // TypeDefIndex: 5135
{
	// Fields
	private SequenceReader<byte> reader; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x139900 Offset: 0x139A01 VA: 0x139900
	private CancellationToken <CancellationToken>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x139910 Offset: 0x139A11 VA: 0x139910
	private int <Depth>k__BackingField; // 0x98

	// Properties
	public CancellationToken CancellationToken { get; set; }
	public int Depth { get; set; }
	public ReadOnlySequence<byte> Sequence { get; }
	public SequencePosition Position { get; }
	public long Consumed { get; }
	public bool End { get; }
	public bool IsNil { get; }
	public MessagePackType NextMessagePackType { get; }
	public byte NextCode { get; }

	// Methods

	// RVA: 0x6810 Offset: 0x6911 VA: 0x6810
	public void .ctor(ReadOnlyMemory<byte> memory) { }

	// RVA: 0x6900 Offset: 0x6A01 VA: 0x6900
	public void .ctor(in ReadOnlySequence<byte> readOnlySequence) { }

	[CompilerGeneratedAttribute] // RVA: 0x139FE0 Offset: 0x13A0E1 VA: 0x139FE0
	// RVA: 0x69E0 Offset: 0x6AE1 VA: 0x69E0
	public CancellationToken get_CancellationToken() { }

	[CompilerGeneratedAttribute] // RVA: 0x139FF0 Offset: 0x13A0F1 VA: 0x139FF0
	// RVA: 0x69F0 Offset: 0x6AF1 VA: 0x69F0
	public void set_CancellationToken(CancellationToken value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A000 Offset: 0x13A101 VA: 0x13A000
	// RVA: 0x6A00 Offset: 0x6B01 VA: 0x6A00
	public int get_Depth() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A010 Offset: 0x13A111 VA: 0x13A010
	// RVA: 0x6A10 Offset: 0x6B11 VA: 0x6A10
	public void set_Depth(int value) { }

	// RVA: 0x6A20 Offset: 0x6B21 VA: 0x6A20
	public ReadOnlySequence<byte> get_Sequence() { }

	// RVA: 0x6A80 Offset: 0x6B81 VA: 0x6A80
	public SequencePosition get_Position() { }

	// RVA: 0x6AD0 Offset: 0x6BD1 VA: 0x6AD0
	public long get_Consumed() { }

	// RVA: 0x6B20 Offset: 0x6C21 VA: 0x6B20
	public bool get_End() { }

	// RVA: 0x6B70 Offset: 0x6C71 VA: 0x6B70
	public bool get_IsNil() { }

	// RVA: 0x6BA0 Offset: 0x6CA1 VA: 0x6BA0
	public MessagePackType get_NextMessagePackType() { }

	// RVA: 0x6C20 Offset: 0x6D21 VA: 0x6C20
	public byte get_NextCode() { }

	// RVA: 0x6C30 Offset: 0x6D31 VA: 0x6C30
	public MessagePackReader Clone(in ReadOnlySequence<byte> readOnlySequence) { }

	// RVA: 0x6DB0 Offset: 0x6EB1 VA: 0x6DB0
	public MessagePackReader CreatePeekReader() { }

	// RVA: 0x6DC0 Offset: 0x6EC1 VA: 0x6DC0
	public void Skip() { }

	// RVA: 0x6DE0 Offset: 0x6EE1 VA: 0x6DE0
	internal bool TrySkip() { }

	// RVA: 0x6DF0 Offset: 0x6EF1 VA: 0x6DF0
	public Nil ReadNil() { }

	// RVA: 0x6E10 Offset: 0x6F11 VA: 0x6E10
	public bool TryReadNil() { }

	// RVA: 0x6EA0 Offset: 0x6FA1 VA: 0x6EA0
	public ReadOnlySequence<byte> ReadRaw(long length) { }

	// RVA: 0x6EB0 Offset: 0x6FB1 VA: 0x6EB0
	public ReadOnlySequence<byte> ReadRaw() { }

	// RVA: 0x6EC0 Offset: 0x6FC1 VA: 0x6EC0
	public int ReadArrayHeader() { }

	// RVA: 0x6ED0 Offset: 0x6FD1 VA: 0x6ED0
	public bool TryReadArrayHeader(out int count) { }

	// RVA: 0x6EE0 Offset: 0x6FE1 VA: 0x6EE0
	public int ReadMapHeader() { }

	// RVA: 0x6F70 Offset: 0x7071 VA: 0x6F70
	public bool TryReadMapHeader(out int count) { }

	// RVA: 0x6F80 Offset: 0x7081 VA: 0x6F80
	public bool ReadBoolean() { }

	// RVA: 0x7020 Offset: 0x7121 VA: 0x7020
	public char ReadChar() { }

	// RVA: 0x7030 Offset: 0x7131 VA: 0x7030
	public float ReadSingle() { }

	// RVA: 0x7040 Offset: 0x7141 VA: 0x7040
	public double ReadDouble() { }

	// RVA: 0x7050 Offset: 0x7151 VA: 0x7050
	public DateTime ReadDateTime() { }

	// RVA: 0x7060 Offset: 0x7161 VA: 0x7060
	public DateTime ReadDateTime(ExtensionHeader header) { }

	// RVA: 0x7070 Offset: 0x7171 VA: 0x7070
	public Nullable<ReadOnlySequence<byte>> ReadBytes() { }

	// RVA: 0x7080 Offset: 0x7181 VA: 0x7080
	public Nullable<ReadOnlySequence<byte>> ReadStringSequence() { }

	// RVA: 0x7090 Offset: 0x7191 VA: 0x7090
	public bool TryReadStringSpan(out ReadOnlySpan<byte> span) { }

	// RVA: 0x70A0 Offset: 0x71A1 VA: 0x70A0
	public string ReadString() { }

	// RVA: 0x70B0 Offset: 0x71B1 VA: 0x70B0
	public ExtensionHeader ReadExtensionFormatHeader() { }

	// RVA: 0x7140 Offset: 0x7241 VA: 0x7140
	public bool TryReadExtensionFormatHeader(out ExtensionHeader extensionHeader) { }

	// RVA: 0x7150 Offset: 0x7251 VA: 0x7150
	public ExtensionResult ReadExtensionFormat() { }

	// RVA: 0x16905F0 Offset: 0x16906F1 VA: 0x16905F0
	private static EndOfStreamException ThrowNotEnoughBytesException() { }

	// RVA: 0x168E460 Offset: 0x168E561 VA: 0x168E460
	private static EndOfStreamException ThrowNotEnoughBytesException(Exception innerException) { }

	// RVA: 0x168E0A0 Offset: 0x168E1A1 VA: 0x168E0A0
	private static Exception ThrowInvalidCode(byte code) { }

	// RVA: 0x168D740 Offset: 0x168D841 VA: 0x168D740
	private static void ThrowInsufficientBufferUnless(bool condition) { }

	// RVA: 0x7160 Offset: 0x7261 VA: 0x7160
	private int GetBytesLength() { }

	// RVA: 0x71A0 Offset: 0x72A1 VA: 0x71A0
	private bool TryGetBytesLength(out int length) { }

	// RVA: 0x71B0 Offset: 0x72B1 VA: 0x71B0
	private bool TryGetStringLengthInBytes(out int length) { }

	// RVA: 0x7260 Offset: 0x7361 VA: 0x7260
	private int GetStringLengthInBytes() { }

	// RVA: 0x7270 Offset: 0x7371 VA: 0x7270
	private bool TryGetStringLengthInBytesSlow(byte code, out int length) { }

	// RVA: 0x7280 Offset: 0x7381 VA: 0x7280
	private string ReadStringSlow(int byteLength) { }

	// RVA: 0x7290 Offset: 0x7391 VA: 0x7290
	private bool TrySkipNextArray() { }

	// RVA: 0x72A0 Offset: 0x73A1 VA: 0x72A0
	private bool TrySkipNextMap() { }

	// RVA: 0x7330 Offset: 0x7431 VA: 0x7330
	private bool TrySkip(int count) { }

	// RVA: 0x73A0 Offset: 0x74A1 VA: 0x73A0
	public byte ReadByte() { }

	// RVA: 0x73B0 Offset: 0x74B1 VA: 0x73B0
	public ushort ReadUInt16() { }

	// RVA: 0x73C0 Offset: 0x74C1 VA: 0x73C0
	public uint ReadUInt32() { }

	// RVA: 0x73D0 Offset: 0x74D1 VA: 0x73D0
	public ulong ReadUInt64() { }

	// RVA: 0x73E0 Offset: 0x74E1 VA: 0x73E0
	public sbyte ReadSByte() { }

	// RVA: 0x73F0 Offset: 0x74F1 VA: 0x73F0
	public short ReadInt16() { }

	// RVA: 0x7400 Offset: 0x7501 VA: 0x7400
	public int ReadInt32() { }

	// RVA: 0x7410 Offset: 0x7511 VA: 0x7410
	public long ReadInt64() { }
}

