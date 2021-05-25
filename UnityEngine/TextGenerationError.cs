[FlagsAttribute] // RVA: 0xE6E30 Offset: 0xE6F31 VA: 0xE6E30
internal enum TextGenerationError // TypeDefIndex: 3456
{
	// Fields
	public int value__; // 0x0
	public const TextGenerationError None = 0;
	public const TextGenerationError CustomSizeOnNonDynamicFont = 1;
	public const TextGenerationError CustomStyleOnNonDynamicFont = 2;
	public const TextGenerationError NoFont = 4;
}

