[FlagsAttribute] // RVA: 0xC5640 Offset: 0xC5741 VA: 0xC5640
public enum RenderTextureCreationFlags // TypeDefIndex: 2925
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureCreationFlags MipMap = 1;
	public const RenderTextureCreationFlags AutoGenerateMips = 2;
	public const RenderTextureCreationFlags SRGB = 4;
	public const RenderTextureCreationFlags EyeTexture = 8;
	public const RenderTextureCreationFlags EnableRandomWrite = 16;
	public const RenderTextureCreationFlags CreatedFromScript = 32;
	public const RenderTextureCreationFlags AllowVerticalFlip = 128;
	public const RenderTextureCreationFlags NoResolvedColorSurface = 256;
	public const RenderTextureCreationFlags DynamicallyScalable = 1024;
	public const RenderTextureCreationFlags BindMS = 2048;
}

