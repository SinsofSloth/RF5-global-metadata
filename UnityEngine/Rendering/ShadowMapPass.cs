[FlagsAttribute] // RVA: 0xC85C0 Offset: 0xC86C1 VA: 0xC85C0
public enum ShadowMapPass // TypeDefIndex: 3283
{
	// Fields
	public int value__; // 0x0
	public const ShadowMapPass PointlightPositiveX = 1;
	public const ShadowMapPass PointlightNegativeX = 2;
	public const ShadowMapPass PointlightPositiveY = 4;
	public const ShadowMapPass PointlightNegativeY = 8;
	public const ShadowMapPass PointlightPositiveZ = 16;
	public const ShadowMapPass PointlightNegativeZ = 32;
	public const ShadowMapPass DirectionalCascade0 = 64;
	public const ShadowMapPass DirectionalCascade1 = 128;
	public const ShadowMapPass DirectionalCascade2 = 256;
	public const ShadowMapPass DirectionalCascade3 = 512;
	public const ShadowMapPass Spotlight = 1024;
	public const ShadowMapPass Pointlight = 63;
	public const ShadowMapPass Directional = 960;
	public const ShadowMapPass All = 2047;
}

