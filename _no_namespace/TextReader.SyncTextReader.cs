[Serializable]
internal sealed class TextReader.SyncTextReader : TextReader // TypeDefIndex: 670
{
	// Fields
	internal TextReader _in; // 0x18

	// Methods

	// RVA: 0x18B6AF0 Offset: 0x18B6BF1 VA: 0x18B6AF0
	internal void .ctor(TextReader t) { }

	// RVA: 0x18B6F70 Offset: 0x18B7071 VA: 0x18B6F70 Slot: 7
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B7040 Offset: 0x18B7141 VA: 0x18B7040 Slot: 8
	public override int Peek() { }

	// RVA: 0x18B7060 Offset: 0x18B7161 VA: 0x18B7060 Slot: 9
	public override int Read() { }

	// RVA: 0x18B7080 Offset: 0x18B7181 VA: 0x18B7080 Slot: 10
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x18B70A0 Offset: 0x18B71A1 VA: 0x18B70A0 Slot: 12
	public override string ReadLine() { }

	// RVA: 0x18B70C0 Offset: 0x18B71C1 VA: 0x18B70C0 Slot: 11
	public override string ReadToEnd() { }
}

