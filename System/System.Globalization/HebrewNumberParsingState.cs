internal enum HebrewNumberParsingState // TypeDefIndex: 721
{
	// Fields
	public int value__; // 0x0
	public const HebrewNumberParsingState InvalidHebrewNumber = 0;
	public const HebrewNumberParsingState NotHebrewDigit = 1;
	public const HebrewNumberParsingState FoundEndOfHebrewNumber = 2;
	public const HebrewNumberParsingState ContinueParsing = 3;
}

