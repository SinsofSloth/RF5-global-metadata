internal class TermInfoReader // TypeDefIndex: 410
{
	// Fields
	private short boolSize; // 0x10
	private short numSize; // 0x12
	private short strOffsets; // 0x14
	private byte[] buffer; // 0x18
	private int booleansOffset; // 0x20

	// Methods

	// RVA: 0x2A6AC20 Offset: 0x2A6AD21 VA: 0x2A6AC20
	public void .ctor(string term, string filename) { }

	// RVA: 0x2A6AEC0 Offset: 0x2A6AFC1 VA: 0x2A6AEC0
	public void .ctor(string term, byte[] buffer) { }

	// RVA: 0x2A6FE60 Offset: 0x2A6FF61 VA: 0x2A6FE60
	private void ReadHeader(byte[] buffer, ref int position) { }

	// RVA: 0x2A700A0 Offset: 0x2A701A1 VA: 0x2A700A0
	private void ReadNames(byte[] buffer, ref int position) { }

	// RVA: 0x2A6BA90 Offset: 0x2A6BB91 VA: 0x2A6BA90
	public int Get(TermInfoNumbers number) { }

	// RVA: 0x2A6B940 Offset: 0x2A6BA41 VA: 0x2A6B940
	public string Get(TermInfoStrings tstr) { }

	// RVA: 0x2A6FB90 Offset: 0x2A6FC91 VA: 0x2A6FB90
	public byte[] GetStringBytes(TermInfoStrings tstr) { }

	// RVA: 0x2A70150 Offset: 0x2A70251 VA: 0x2A70150
	private short GetInt16(byte[] buffer, int offset) { }

	// RVA: 0x2A701B0 Offset: 0x2A702B1 VA: 0x2A701B0
	private string GetString(byte[] buffer, int offset) { }

	// RVA: 0x2A70240 Offset: 0x2A70341 VA: 0x2A70240
	private byte[] GetStringBytes(byte[] buffer, int offset) { }
}

