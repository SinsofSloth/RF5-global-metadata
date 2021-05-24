[FlagsAttribute] // RVA: 0xC89B0 Offset: 0xC8AB1 VA: 0xC89B0
public enum CullingOptions // TypeDefIndex: 3320
{
	// Fields
	public int value__; // 0x0
	public const CullingOptions None = 0;
	public const CullingOptions ForceEvenIfCameraIsNotActive = 1;
	public const CullingOptions OcclusionCull = 2;
	public const CullingOptions NeedsLighting = 4;
	public const CullingOptions NeedsReflectionProbes = 8;
	public const CullingOptions Stereo = 16;
	public const CullingOptions DisablePerObjectCulling = 32;
	public const CullingOptions ShadowCasters = 64;
}

