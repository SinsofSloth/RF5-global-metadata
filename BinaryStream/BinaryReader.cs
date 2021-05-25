[DefaultMemberAttribute] // RVA: 0x14A7A0 Offset: 0x14A8A1 VA: 0x14A7A0
public class BinaryReader // TypeDefIndex: 10658
{
	// Fields
	protected byte[] data_; // 0x10
	protected int pos_; // 0x18
	private bool ready_; // 0x1C
	private StringBuilder builder_; // 0x20

	// Properties
	public bool Ready { get; }
	public int Size { get; }
	public int Pos { get; set; }
	public byte[] Data { get; }
	public byte Item { get; set; }

	// Methods

	// RVA: 0x22DF8B0 Offset: 0x22DF9B1 VA: 0x22DF8B0
	public void .ctor() { }

	// RVA: 0x22DF8F0 Offset: 0x22DF9F1 VA: 0x22DF8F0
	public void .ctor(byte[] data) { }

	// RVA: 0x22DF940 Offset: 0x22DFA41 VA: 0x22DF940
	public void .ctor(string name) { }

	// RVA: 0x22DFA20 Offset: 0x22DFB21 VA: 0x22DFA20
	public void SetData(byte[] data) { }

	// RVA: 0x22DFA60 Offset: 0x22DFB61 VA: 0x22DFA60
	public bool get_Ready() { }

	// RVA: 0x22DFA70 Offset: 0x22DFB71 VA: 0x22DFA70
	public int get_Size() { }

	// RVA: 0x22DFA90 Offset: 0x22DFB91 VA: 0x22DFA90
	public int get_Pos() { }

	// RVA: 0x22DFAA0 Offset: 0x22DFBA1 VA: 0x22DFAA0
	public void set_Pos(int value) { }

	// RVA: 0x22DFAE0 Offset: 0x22DFBE1 VA: 0x22DFAE0
	public byte[] GetBuffer() { }

	// RVA: 0x22DFAF0 Offset: 0x22DFBF1 VA: 0x22DFAF0
	public byte[] get_Data() { }

	// RVA: 0x22DFB00 Offset: 0x22DFC01 VA: 0x22DFB00
	public byte get_Item(int i) { }

	// RVA: 0x22DFB40 Offset: 0x22DFC41 VA: 0x22DFB40
	public void set_Item(int i, byte value) { }

	// RVA: 0x22DFB80 Offset: 0x22DFC81 VA: 0x22DFB80
	public bool GetBool() { }

	// RVA: 0x22DFBD0 Offset: 0x22DFCD1 VA: 0x22DFBD0
	public byte GetByte() { }

	// RVA: 0x22DFC20 Offset: 0x22DFD21 VA: 0x22DFC20
	public short GetShort() { }

	// RVA: 0x22DFC90 Offset: 0x22DFD91 VA: 0x22DFC90
	public ushort GetUShort() { }

	// RVA: 0x22DFD00 Offset: 0x22DFE01 VA: 0x22DFD00
	public int GetInt() { }

	// RVA: 0x22DFDB0 Offset: 0x22DFEB1 VA: 0x22DFDB0
	public uint GetUInt() { }

	// RVA: 0x22DFE60 Offset: 0x22DFF61 VA: 0x22DFE60
	public long GetLong() { }

	// RVA: 0x22DFF90 Offset: 0x22E0091 VA: 0x22DFF90
	public ulong GetULong() { }

	// RVA: 0x22E00C0 Offset: 0x22E01C1 VA: 0x22E00C0
	public float GetFloat() { }

	// RVA: 0x22E0190 Offset: 0x22E0291 VA: 0x22E0190
	public string GetString() { }

	// RVA: 0x22E02C0 Offset: 0x22E03C1 VA: 0x22E02C0
	public string GetStringAscii() { }

	// RVA: 0x22E03D0 Offset: 0x22E04D1 VA: 0x22E03D0
	public byte[] GetByteArray(int size) { }

	// RVA: 0x22E04C0 Offset: 0x22E05C1 VA: 0x22E04C0
	public char[] GetCharArray(int size) { }
}

