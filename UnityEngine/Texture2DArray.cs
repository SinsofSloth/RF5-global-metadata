[NativeHeaderAttribute] // RVA: 0xC59F0 Offset: 0xC5AF1 VA: 0xC59F0
public sealed class Texture2DArray : Texture // TypeDefIndex: 2946
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x2A34AA0 Offset: 0x2A34BA1 VA: 0x2A34AA0 Slot: 10
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xD43B0 Offset: 0xD44B1 VA: 0xD43B0
	// RVA: 0x2A34AF0 Offset: 0x2A34BF1 VA: 0x2A34AF0
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2A34B80 Offset: 0x2A34C81 VA: 0x2A34B80
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2A34C70 Offset: 0x2A34D71 VA: 0x2A34C70
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD43F0 Offset: 0xD44F1 VA: 0xD43F0
	// RVA: 0x2A34D50 Offset: 0x2A34E51 VA: 0x2A34D50
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2A34E00 Offset: 0x2A34F01 VA: 0x2A34E00
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2A34FB0 Offset: 0x2A350B1 VA: 0x2A34FB0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2A35190 Offset: 0x2A35291 VA: 0x2A35190
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x2A351C0 Offset: 0x2A352C1 VA: 0x2A351C0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }
}

