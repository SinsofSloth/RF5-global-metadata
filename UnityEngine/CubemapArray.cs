[NativeHeaderAttribute] // RVA: 0xC5A30 Offset: 0xC5B31 VA: 0xC5A30
public sealed class CubemapArray : Texture // TypeDefIndex: 2947
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x2B03D00 Offset: 0x2B03E01 VA: 0x2B03D00 Slot: 10
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xD4400 Offset: 0xD4501 VA: 0xD4400
	// RVA: 0x2B03D50 Offset: 0x2B03E51 VA: 0x2B03D50
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2B03DD0 Offset: 0x2B03ED1 VA: 0x2B03DD0
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2B03EC0 Offset: 0x2B03FC1 VA: 0x2B03EC0
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD4440 Offset: 0xD4541 VA: 0xD4440
	// RVA: 0x2B03F70 Offset: 0x2B04071 VA: 0x2B03F70
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2B04010 Offset: 0x2B04111 VA: 0x2B04010
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2B04160 Offset: 0x2B04261 VA: 0x2B04160
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2B04300 Offset: 0x2B04401 VA: 0x2B04300
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x2B04330 Offset: 0x2B04431 VA: 0x2B04330
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }
}

