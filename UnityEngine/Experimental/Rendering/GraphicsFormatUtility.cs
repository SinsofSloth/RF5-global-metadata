[NativeHeaderAttribute] // RVA: 0xC9310 Offset: 0xC9411 VA: 0xC9310
[NativeHeaderAttribute] // RVA: 0xC9310 Offset: 0xC9411 VA: 0xC9310
[NativeHeaderAttribute] // RVA: 0xC9310 Offset: 0xC9411 VA: 0xC9310
public class GraphicsFormatUtility // TypeDefIndex: 3392
{
	// Methods

	// RVA: 0x2B03710 Offset: 0x2B03811 VA: 0x2B03710
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0xDB300 Offset: 0xDB401 VA: 0xDB300
	// RVA: 0x2B0BEE0 Offset: 0x2B0BFE1 VA: 0x2B0BEE0
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x2B0BF30 Offset: 0x2B0C031 VA: 0x2B0BF30
	public static TextureFormat GetTextureFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xDB340 Offset: 0xDB441 VA: 0xDB340
	// RVA: 0x2B0BF80 Offset: 0x2B0C081 VA: 0x2B0BF80
	private static TextureFormat GetTextureFormat_Native_GraphicsFormat(GraphicsFormat format) { }

	// RVA: 0x2B0BFD0 Offset: 0x2B0C0D1 VA: 0x2B0BFD0
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunctionAttribute] // RVA: 0xDB380 Offset: 0xDB481 VA: 0xDB380
	// RVA: 0x2B0C020 Offset: 0x2B0C121 VA: 0x2B0C020
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x2B0C070 Offset: 0x2B0C171 VA: 0x2B0C070
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunctionAttribute] // RVA: 0xDB390 Offset: 0xDB491 VA: 0xDB390
	// RVA: 0x2B0C0E0 Offset: 0x2B0C1E1 VA: 0x2B0C0E0
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xDB3D0 Offset: 0xDB4D1 VA: 0xDB3D0
	// RVA: 0x2B0C130 Offset: 0x2B0C231 VA: 0x2B0C130
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[FreeFunctionAttribute] // RVA: 0xDB410 Offset: 0xDB511 VA: 0xDB410
	// RVA: 0x2B0C180 Offset: 0x2B0C281 VA: 0x2B0C180
	internal static bool IsCompressedTextureFormat(TextureFormat format) { }

	// RVA: 0x2B03760 Offset: 0x2B03861 VA: 0x2B03760
	public static bool IsCrunchFormat(TextureFormat format) { }
}

