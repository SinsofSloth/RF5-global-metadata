public struct StringOptions : IPlugOptions // TypeDefIndex: 5046
{
	// Fields
	public bool richTextEnabled; // 0x0
	public ScrambleMode scrambleMode; // 0x4
	public char[] scrambledChars; // 0x8
	internal int startValueStrippedLength; // 0x10
	internal int changeValueStrippedLength; // 0x14

	// Methods

	// RVA: 0x16C20 Offset: 0x16D21 VA: 0x16C20 Slot: 4
	public void Reset() { }
}

