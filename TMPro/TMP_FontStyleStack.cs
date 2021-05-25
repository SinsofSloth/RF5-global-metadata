public struct TMP_FontStyleStack // TypeDefIndex: 5875
{
	// Fields
	public byte bold; // 0x0
	public byte italic; // 0x1
	public byte underline; // 0x2
	public byte strikethrough; // 0x3
	public byte highlight; // 0x4
	public byte superscript; // 0x5
	public byte subscript; // 0x6
	public byte uppercase; // 0x7
	public byte lowercase; // 0x8
	public byte smallcaps; // 0x9

	// Methods

	// RVA: 0x2C90 Offset: 0x2D91 VA: 0x2C90
	public void Clear() { }

	// RVA: 0x2CA0 Offset: 0x2DA1 VA: 0x2CA0
	public byte Add(FontStyles style) { }

	// RVA: 0x2D90 Offset: 0x2E91 VA: 0x2D90
	public byte Remove(FontStyles style) { }
}

