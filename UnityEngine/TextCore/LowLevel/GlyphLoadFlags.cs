[FlagsAttribute] // RVA: 0x100C30 Offset: 0x100D31 VA: 0x100C30
[UsedByNativeCodeAttribute] // RVA: 0x100C30 Offset: 0x100D31 VA: 0x100C30
public enum GlyphLoadFlags // TypeDefIndex: 3685
{
	// Fields
	public int value__; // 0x0
	public const GlyphLoadFlags LOAD_DEFAULT = 0;
	public const GlyphLoadFlags LOAD_NO_SCALE = 1;
	public const GlyphLoadFlags LOAD_NO_HINTING = 2;
	public const GlyphLoadFlags LOAD_RENDER = 4;
	public const GlyphLoadFlags LOAD_NO_BITMAP = 8;
	public const GlyphLoadFlags LOAD_FORCE_AUTOHINT = 32;
	public const GlyphLoadFlags LOAD_MONOCHROME = 4096;
	public const GlyphLoadFlags LOAD_NO_AUTOHINT = 32768;
	public const GlyphLoadFlags LOAD_COMPUTE_METRICS = 2097152;
	public const GlyphLoadFlags LOAD_BITMAP_METRICS_ONLY = 4194304;
}

