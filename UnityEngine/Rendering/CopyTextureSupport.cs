[FlagsAttribute] // RVA: 0xC8600 Offset: 0xC8701 VA: 0xC8600
public enum CopyTextureSupport // TypeDefIndex: 3303
{
	// Fields
	public int value__; // 0x0
	public const CopyTextureSupport None = 0;
	public const CopyTextureSupport Basic = 1;
	public const CopyTextureSupport Copy3D = 2;
	public const CopyTextureSupport DifferentTypes = 4;
	public const CopyTextureSupport TextureToRT = 8;
	public const CopyTextureSupport RTToTexture = 16;
}

