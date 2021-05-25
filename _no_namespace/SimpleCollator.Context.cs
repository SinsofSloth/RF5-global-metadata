internal struct SimpleCollator.Context // TypeDefIndex: 39
{
	// Fields
	public readonly CompareOptions Option; // 0x0
	public readonly byte* NeverMatchFlags; // 0x8
	public readonly byte* AlwaysMatchFlags; // 0x10
	public byte* Buffer1; // 0x18
	public byte* Buffer2; // 0x20
	public int PrevCode; // 0x28
	public byte* PrevSortKey; // 0x30

	// Methods

	// RVA: 0x11130 Offset: 0x11231 VA: 0x11130
	public void .ctor(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1) { }
}

