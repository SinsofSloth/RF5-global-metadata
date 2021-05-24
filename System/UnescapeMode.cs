[FlagsAttribute] // RVA: 0xBBE10 Offset: 0xBBF11 VA: 0xBBE10
internal enum UnescapeMode // TypeDefIndex: 1747
{
	// Fields
	public int value__; // 0x0
	public const UnescapeMode CopyOnly = 0;
	public const UnescapeMode Escape = 1;
	public const UnescapeMode Unescape = 2;
	public const UnescapeMode EscapeUnescape = 3;
	public const UnescapeMode V1ToStringFlag = 4;
	public const UnescapeMode UnescapeAll = 8;
	public const UnescapeMode UnescapeAllOrThrow = 24;
}

