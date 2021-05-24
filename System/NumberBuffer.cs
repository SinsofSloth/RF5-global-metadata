[IsByRefLikeAttribute] // RVA: 0x1286E0 Offset: 0x1287E1 VA: 0x1286E0
[ObsoleteAttribute] // RVA: 0x1286E0 Offset: 0x1287E1 VA: 0x1286E0
internal struct NumberBuffer // TypeDefIndex: 4376
{
	// Fields
	public int Scale; // 0x0
	public bool IsNegative; // 0x4
	private byte _b0; // 0x5
	private byte _b1; // 0x6
	private byte _b2; // 0x7
	private byte _b3; // 0x8
	private byte _b4; // 0x9
	private byte _b5; // 0xA
	private byte _b6; // 0xB
	private byte _b7; // 0xC
	private byte _b8; // 0xD
	private byte _b9; // 0xE
	private byte _b10; // 0xF
	private byte _b11; // 0x10
	private byte _b12; // 0x11
	private byte _b13; // 0x12
	private byte _b14; // 0x13
	private byte _b15; // 0x14
	private byte _b16; // 0x15
	private byte _b17; // 0x16
	private byte _b18; // 0x17
	private byte _b19; // 0x18
	private byte _b20; // 0x19
	private byte _b21; // 0x1A
	private byte _b22; // 0x1B
	private byte _b23; // 0x1C
	private byte _b24; // 0x1D
	private byte _b25; // 0x1E
	private byte _b26; // 0x1F
	private byte _b27; // 0x20
	private byte _b28; // 0x21
	private byte _b29; // 0x22
	private byte _b30; // 0x23
	private byte _b31; // 0x24
	private byte _b32; // 0x25
	private byte _b33; // 0x26
	private byte _b34; // 0x27
	private byte _b35; // 0x28
	private byte _b36; // 0x29
	private byte _b37; // 0x2A
	private byte _b38; // 0x2B
	private byte _b39; // 0x2C
	private byte _b40; // 0x2D
	private byte _b41; // 0x2E
	private byte _b42; // 0x2F
	private byte _b43; // 0x30
	private byte _b44; // 0x31
	private byte _b45; // 0x32
	private byte _b46; // 0x33
	private byte _b47; // 0x34
	private byte _b48; // 0x35
	private byte _b49; // 0x36
	private byte _b50; // 0x37

	// Properties
	public Span<byte> Digits { get; }
	public byte* UnsafeDigits { get; }
	public int NumDigits { get; }

	// Methods

	// RVA: 0x20A20 Offset: 0x20B21 VA: 0x20A20
	public Span<byte> get_Digits() { }

	// RVA: 0x20A90 Offset: 0x20B91 VA: 0x20A90
	public byte* get_UnsafeDigits() { }

	// RVA: 0x20AE0 Offset: 0x20BE1 VA: 0x20AE0
	public int get_NumDigits() { }

	// RVA: 0x20AF0 Offset: 0x20BF1 VA: 0x20AF0 Slot: 3
	public override string ToString() { }
}

