internal class CodePointIndexer // TypeDefIndex: 28
{
	// Fields
	private readonly CodePointIndexer.TableRange[] ranges; // 0x10
	public readonly int TotalCount; // 0x18
	private int defaultIndex; // 0x1C
	private int defaultCP; // 0x20

	// Methods

	// RVA: 0x192D690 Offset: 0x192D791 VA: 0x192D690
	public void .ctor(int[] starts, int[] ends, int defaultIndex, int defaultCP) { }

	// RVA: 0x192D860 Offset: 0x192D961 VA: 0x192D860
	public int ToIndex(int cp) { }
}

