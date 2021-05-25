internal class UnexceptionalStreamReader : StreamReader // TypeDefIndex: 696
{
	// Fields
	private static bool[] newline; // 0x0
	private static char newlineChar; // 0x8

	// Methods

	// RVA: 0x18B8680 Offset: 0x18B8781 VA: 0x18B8680
	private static void .cctor() { }

	// RVA: 0x18B8730 Offset: 0x18B8831 VA: 0x18B8730
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x18B8810 Offset: 0x18B8911 VA: 0x18B8810 Slot: 8
	public override int Peek() { }

	// RVA: 0x18B88E0 Offset: 0x18B89E1 VA: 0x18B88E0 Slot: 9
	public override int Read() { }

	// RVA: 0x18B89B0 Offset: 0x18B8AB1 VA: 0x18B89B0 Slot: 10
	public override int Read([In] [Out] char[] dest_buffer, int index, int count) { }

	// RVA: 0x18B8C90 Offset: 0x18B8D91 VA: 0x18B8C90
	private bool CheckEOL(char current) { }

	// RVA: 0x18B8E90 Offset: 0x18B8F91 VA: 0x18B8E90 Slot: 12
	public override string ReadLine() { }

	// RVA: 0x18B8F60 Offset: 0x18B9061 VA: 0x18B8F60 Slot: 11
	public override string ReadToEnd() { }
}

