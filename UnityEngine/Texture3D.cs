[NativeHeaderAttribute] // RVA: 0xC59A0 Offset: 0xC5AA1 VA: 0xC59A0
[ExcludeFromPresetAttribute] // RVA: 0xC59A0 Offset: 0xC5AA1 VA: 0xC59A0
public sealed class Texture3D : Texture // TypeDefIndex: 2945
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x2A351F0 Offset: 0x2A352F1 VA: 0x2A351F0 Slot: 10
	public override bool get_isReadable() { }

	[FreeFunctionAttribute] // RVA: 0xD42C0 Offset: 0xD43C1 VA: 0xD42C0
	// RVA: 0x2A35240 Offset: 0x2A35341 VA: 0x2A35240
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2A352D0 Offset: 0x2A353D1 VA: 0x2A352D0
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[FreeFunctionAttribute] // RVA: 0xD4300 Offset: 0xD4401 VA: 0xD4300
	// RVA: 0x2A353C0 Offset: 0x2A354C1 VA: 0x2A353C0
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0xD4350 Offset: 0xD4451 VA: 0xD4350
	// RVA: 0x2A35420 Offset: 0x2A35521 VA: 0x2A35420
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x2A35480 Offset: 0x2A35581 VA: 0x2A35480
	public void SetPixels(Color[] colors) { }

	// RVA: 0x2A354E0 Offset: 0x2A355E1 VA: 0x2A354E0
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD43A0 Offset: 0xD44A1 VA: 0xD43A0
	// RVA: 0x2A355C0 Offset: 0x2A356C1 VA: 0x2A355C0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2A35670 Offset: 0x2A35771 VA: 0x2A35670
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2A35820 Offset: 0x2A35921 VA: 0x2A35820
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x2A35A00 Offset: 0x2A35B01 VA: 0x2A35A00
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2A35A20 Offset: 0x2A35B21 VA: 0x2A35A20
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x2A35AD0 Offset: 0x2A35BD1 VA: 0x2A35AD0
	public void Apply() { }
}

