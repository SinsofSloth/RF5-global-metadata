[FlagsAttribute] // RVA: 0x141480 Offset: 0x141581 VA: 0x141480
internal enum LogLevel // TypeDefIndex: 5953
{
	// Fields
	public int value__; // 0x0
	public const LogLevel None = 0;
	public const LogLevel Error = 1;
	public const LogLevel Warning = 2;
	public const LogLevel Info = 4;
	public const LogLevel Default = 3;
	public const LogLevel All = 255;
}

