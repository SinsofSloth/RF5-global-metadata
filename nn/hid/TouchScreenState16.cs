public struct TouchScreenState16 // TypeDefIndex: 11636
{
	// Fields
	public const int TouchCount = 16;
	public long samplingNumber; // 0x0
	public int count; // 0x8
	private int _reserved; // 0xC
	public TouchScreenState16.TouchStateArray16 touches; // 0x10

	// Methods

	// RVA: 0x387500 Offset: 0x387601 VA: 0x387500
	public void SetDefault() { }
}

