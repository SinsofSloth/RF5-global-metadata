internal enum TokenType // TypeDefIndex: 250
{
	// Fields
	public int value__; // 0x0
	public const TokenType NumberToken = 1;
	public const TokenType YearNumberToken = 2;
	public const TokenType Am = 3;
	public const TokenType Pm = 4;
	public const TokenType MonthToken = 5;
	public const TokenType EndOfString = 6;
	public const TokenType DayOfWeekToken = 7;
	public const TokenType TimeZoneToken = 8;
	public const TokenType EraToken = 9;
	public const TokenType DateWordToken = 10;
	public const TokenType UnknownToken = 11;
	public const TokenType HebrewNumber = 12;
	public const TokenType JapaneseEraToken = 13;
	public const TokenType TEraToken = 14;
	public const TokenType IgnorableSymbol = 15;
	public const TokenType SEP_Unk = 256;
	public const TokenType SEP_End = 512;
	public const TokenType SEP_Space = 768;
	public const TokenType SEP_Am = 1024;
	public const TokenType SEP_Pm = 1280;
	public const TokenType SEP_Date = 1536;
	public const TokenType SEP_Time = 1792;
	public const TokenType SEP_YearSuff = 2048;
	public const TokenType SEP_MonthSuff = 2304;
	public const TokenType SEP_DaySuff = 2560;
	public const TokenType SEP_HourSuff = 2816;
	public const TokenType SEP_MinuteSuff = 3072;
	public const TokenType SEP_SecondSuff = 3328;
	public const TokenType SEP_LocalTimeMark = 3584;
	public const TokenType SEP_DateOrOffset = 3840;
	public const TokenType RegularTokenMask = 255;
	public const TokenType SeparatorTokenMask = 65280;
}

