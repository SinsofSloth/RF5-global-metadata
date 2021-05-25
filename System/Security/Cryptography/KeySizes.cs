[ComVisibleAttribute] // RVA: 0xAFD50 Offset: 0xAFE51 VA: 0xAFD50
public sealed class KeySizes // TypeDefIndex: 917
{
	// Fields
	private int m_minSize; // 0x10
	private int m_maxSize; // 0x14
	private int m_skipSize; // 0x18

	// Properties
	public int MinSize { get; }
	public int MaxSize { get; }
	public int SkipSize { get; }

	// Methods

	// RVA: 0x194F220 Offset: 0x194F321 VA: 0x194F220
	public int get_MinSize() { }

	// RVA: 0x194F230 Offset: 0x194F331 VA: 0x194F230
	public int get_MaxSize() { }

	// RVA: 0x194F240 Offset: 0x194F341 VA: 0x194F240
	public int get_SkipSize() { }

	// RVA: 0x1943630 Offset: 0x1943731 VA: 0x1943630
	public void .ctor(int minSize, int maxSize, int skipSize) { }

	// RVA: 0x194F250 Offset: 0x194F351 VA: 0x194F250
	internal bool IsLegal(int keySize) { }

	// RVA: 0x194F2A0 Offset: 0x194F3A1 VA: 0x194F2A0
	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }
}

