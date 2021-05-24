[ComVisibleAttribute] // RVA: 0xAE840 Offset: 0xAE941 VA: 0xAE840
public class BinaryReader : IDisposable // TypeDefIndex: 634
{
	// Fields
	private Stream m_stream; // 0x10
	private byte[] m_buffer; // 0x18
	private Decoder m_decoder; // 0x20
	private byte[] m_charBytes; // 0x28
	private char[] m_singleChar; // 0x30
	private char[] m_charBuffer; // 0x38
	private int m_maxCharsSize; // 0x40
	private bool m_2BytesPerChar; // 0x44
	private bool m_isMemoryStream; // 0x45
	private bool m_leaveOpen; // 0x46

	// Properties
	public virtual Stream BaseStream { get; }

	// Methods

	// RVA: 0x19D11D0 Offset: 0x19D12D1 VA: 0x19D11D0
	public void .ctor(Stream input) { }

	// RVA: 0x19D14D0 Offset: 0x19D15D1 VA: 0x19D14D0
	public void .ctor(Stream input, Encoding encoding) { }

	// RVA: 0x19D1250 Offset: 0x19D1351 VA: 0x19D1250
	public void .ctor(Stream input, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x19D14E0 Offset: 0x19D15E1 VA: 0x19D14E0 Slot: 5
	public virtual Stream get_BaseStream() { }

	// RVA: 0x19D14F0 Offset: 0x19D15F1 VA: 0x19D14F0 Slot: 6
	public virtual void Close() { }

	// RVA: 0x19D1500 Offset: 0x19D1601 VA: 0x19D1500 Slot: 7
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x19D15B0 Offset: 0x19D16B1 VA: 0x19D15B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x19D15C0 Offset: 0x19D16C1 VA: 0x19D15C0 Slot: 8
	public virtual int Read() { }

	// RVA: 0x19D18D0 Offset: 0x19D19D1 VA: 0x19D18D0 Slot: 9
	public virtual bool ReadBoolean() { }

	// RVA: 0x19D1930 Offset: 0x19D1A31 VA: 0x19D1930 Slot: 10
	public virtual byte ReadByte() { }

	[CLSCompliantAttribute] // RVA: 0xB85D0 Offset: 0xB86D1 VA: 0xB85D0
	// RVA: 0x19D19A0 Offset: 0x19D1AA1 VA: 0x19D19A0 Slot: 11
	public virtual sbyte ReadSByte() { }

	// RVA: 0x19D1A00 Offset: 0x19D1B01 VA: 0x19D1A00 Slot: 12
	public virtual char ReadChar() { }

	// RVA: 0x19D1A50 Offset: 0x19D1B51 VA: 0x19D1A50 Slot: 13
	public virtual short ReadInt16() { }

	[CLSCompliantAttribute] // RVA: 0xB85F0 Offset: 0xB86F1 VA: 0xB85F0
	// RVA: 0x19D1AB0 Offset: 0x19D1BB1 VA: 0x19D1AB0 Slot: 14
	public virtual ushort ReadUInt16() { }

	// RVA: 0x19D1B10 Offset: 0x19D1C11 VA: 0x19D1B10 Slot: 15
	public virtual int ReadInt32() { }

	[CLSCompliantAttribute] // RVA: 0xB8610 Offset: 0xB8711 VA: 0xB8610
	// RVA: 0x19D1C20 Offset: 0x19D1D21 VA: 0x19D1C20 Slot: 16
	public virtual uint ReadUInt32() { }

	// RVA: 0x19D1CB0 Offset: 0x19D1DB1 VA: 0x19D1CB0 Slot: 17
	public virtual long ReadInt64() { }

	[CLSCompliantAttribute] // RVA: 0xB8630 Offset: 0xB8731 VA: 0xB8630
	// RVA: 0x19D1D80 Offset: 0x19D1E81 VA: 0x19D1D80 Slot: 18
	public virtual ulong ReadUInt64() { }

	// RVA: 0x19D1E50 Offset: 0x19D1F51 VA: 0x19D1E50 Slot: 19
	public virtual float ReadSingle() { }

	// RVA: 0x19D1E90 Offset: 0x19D1F91 VA: 0x19D1E90 Slot: 20
	public virtual double ReadDouble() { }

	// RVA: 0x19D1ED0 Offset: 0x19D1FD1 VA: 0x19D1ED0 Slot: 21
	public virtual Decimal ReadDecimal() { }

	// RVA: 0x19D2030 Offset: 0x19D2131 VA: 0x19D2030 Slot: 22
	public virtual string ReadString() { }

	// RVA: 0x19D23E0 Offset: 0x19D24E1 VA: 0x19D23E0
	private int InternalReadChars(char[] buffer, int index, int count) { }

	// RVA: 0x19D1600 Offset: 0x19D1701 VA: 0x19D1600
	private int InternalReadOneChar() { }

	// RVA: 0x19D26F0 Offset: 0x19D27F1 VA: 0x19D26F0 Slot: 23
	public virtual char[] ReadChars(int count) { }

	// RVA: 0x19D2850 Offset: 0x19D2951 VA: 0x19D2850 Slot: 24
	public virtual int Read(byte[] buffer, int index, int count) { }

	// RVA: 0x19D2A10 Offset: 0x19D2B11 VA: 0x19D2A10 Slot: 25
	public virtual byte[] ReadBytes(int count) { }

	// RVA: 0x19D2BB0 Offset: 0x19D2CB1 VA: 0x19D2BB0 Slot: 26
	protected virtual void FillBuffer(int numBytes) { }

	// RVA: 0x19D2310 Offset: 0x19D2411 VA: 0x19D2310
	protected internal int Read7BitEncodedInt() { }
}

