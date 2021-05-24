[ComVisibleAttribute] // RVA: 0xAEA60 Offset: 0xAEB61 VA: 0xAEA60
[Serializable]
public class StringReader : TextReader // TypeDefIndex: 666
{
	// Fields
	private string _s; // 0x18
	private int _pos; // 0x20
	private int _length; // 0x24

	// Methods

	// RVA: 0x18B5A90 Offset: 0x18B5B91 VA: 0x18B5A90
	public void .ctor(string s) { }

	// RVA: 0x18B5B70 Offset: 0x18B5C71 VA: 0x18B5B70 Slot: 7
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B5BA0 Offset: 0x18B5CA1 VA: 0x18B5BA0 Slot: 8
	public override int Peek() { }

	// RVA: 0x18B5C10 Offset: 0x18B5D11 VA: 0x18B5C10 Slot: 9
	public override int Read() { }

	// RVA: 0x18B5C90 Offset: 0x18B5D91 VA: 0x18B5C90 Slot: 10
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x18B5E90 Offset: 0x18B5F91 VA: 0x18B5E90 Slot: 11
	public override string ReadToEnd() { }

	// RVA: 0x18B5EF0 Offset: 0x18B5FF1 VA: 0x18B5EF0 Slot: 12
	public override string ReadLine() { }
}

