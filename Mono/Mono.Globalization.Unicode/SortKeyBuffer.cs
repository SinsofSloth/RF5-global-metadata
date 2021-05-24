internal class SortKeyBuffer // TypeDefIndex: 43
{
	// Fields
	private byte[] l1b; // 0x10
	private byte[] l2b; // 0x18
	private byte[] l3b; // 0x20
	private byte[] l4sb; // 0x28
	private byte[] l4tb; // 0x30
	private byte[] l4kb; // 0x38
	private byte[] l4wb; // 0x40
	private byte[] l5b; // 0x48
	private string source; // 0x50
	private int l1; // 0x58
	private int l2; // 0x5C
	private int l3; // 0x60
	private int l4s; // 0x64
	private int l4t; // 0x68
	private int l4k; // 0x6C
	private int l4w; // 0x70
	private int l5; // 0x74
	private int lcid; // 0x78
	private CompareOptions options; // 0x7C
	private bool processLevel2; // 0x80
	private bool frenchSort; // 0x81
	private bool frenchSorted; // 0x82

	// Methods

	// RVA: 0x1931C60 Offset: 0x1931D61 VA: 0x1931C60
	public void .ctor(int lcid) { }

	// RVA: 0x1938160 Offset: 0x1938261 VA: 0x1938160
	public void Reset() { }

	// RVA: 0x1931C70 Offset: 0x1931D71 VA: 0x1931C70
	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	// RVA: 0x1932CC0 Offset: 0x1932DC1 VA: 0x1932CC0
	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	// RVA: 0x1932E20 Offset: 0x1932F21 VA: 0x1932E20
	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	// RVA: 0x1932B10 Offset: 0x1932C11 VA: 0x1932B10
	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	// RVA: 0x1938260 Offset: 0x1938361 VA: 0x1938260
	private void AppendLevel5(byte category, byte lv1) { }

	// RVA: 0x1938170 Offset: 0x1938271 VA: 0x1938170
	private void AppendBufferPrimitive(byte value, ref byte[] buf, ref int bidx) { }

	// RVA: 0x19324E0 Offset: 0x19325E1 VA: 0x19324E0
	public SortKey GetResultAndReset() { }

	// RVA: 0x19389F0 Offset: 0x1938AF1 VA: 0x19389F0
	private int GetOptimizedLength(byte[] data, int len, byte defaultValue) { }

	// RVA: 0x1938310 Offset: 0x1938411 VA: 0x1938310
	public SortKey GetResult() { }
}

