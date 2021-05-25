internal class CStreamWriter : StreamWriter // TypeDefIndex: 699
{
	// Fields
	private TermInfoDriver driver; // 0x68

	// Methods

	// RVA: 0x189CFE0 Offset: 0x189D0E1 VA: 0x189CFE0
	public void .ctor(Stream stream, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x189D2A0 Offset: 0x189D3A1 VA: 0x189D2A0 Slot: 13
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x189D820 Offset: 0x189D921 VA: 0x189D820 Slot: 11
	public override void Write(char val) { }

	// RVA: 0x189DAA0 Offset: 0x189DBA1 VA: 0x189DAA0
	public void InternalWriteString(string val) { }

	// RVA: 0x189D9D0 Offset: 0x189DAD1 VA: 0x189D9D0
	public void InternalWriteChar(char val) { }

	// RVA: 0x189DCF0 Offset: 0x189DDF1 VA: 0x189DCF0
	public void InternalWriteChars(char[] buffer, int n) { }

	// RVA: 0x189DDD0 Offset: 0x189DED1 VA: 0x189DDD0 Slot: 12
	public override void Write(char[] val) { }

	// RVA: 0x189DE00 Offset: 0x189DF01 VA: 0x189DE00 Slot: 15
	public override void Write(string val) { }
}

