[ExcludeFromPresetAttribute] // RVA: 0xC5950 Offset: 0xC5A51 VA: 0xC5950
[NativeHeaderAttribute] // RVA: 0xC5950 Offset: 0xC5A51 VA: 0xC5950
public sealed class Cubemap : Texture // TypeDefIndex: 2944
{
	// Properties
	public TextureFormat format { get; }
	public override bool isReadable { get; }
	public bool streamingMipmaps { get; }
	public int streamingMipmapsPriority { get; }
	public int requestedMipmapLevel { get; set; }
	internal bool loadAllMips { get; set; }
	public int desiredMipmapLevel { get; }
	public int loadingMipmapLevel { get; }
	public int loadedMipmapLevel { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xD3CC0 Offset: 0xD3DC1 VA: 0xD3CC0
	// RVA: 0x2B02680 Offset: 0x2B02781 VA: 0x2B02680
	public TextureFormat get_format() { }

	[FreeFunctionAttribute] // RVA: 0xD3D00 Offset: 0xD3E01 VA: 0xD3D00
	// RVA: 0x2B026D0 Offset: 0x2B027D1 VA: 0x2B026D0
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x2B02750 Offset: 0x2B02851 VA: 0x2B02750
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunctionAttribute] // RVA: 0xD3D40 Offset: 0xD3E41 VA: 0xD3D40
	// RVA: 0x2B02840 Offset: 0x2B02941 VA: 0x2B02840
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunctionAttribute] // RVA: 0xD3D90 Offset: 0xD3E91 VA: 0xD3D90
	// RVA: 0x2B028A0 Offset: 0x2B029A1 VA: 0x2B028A0
	public void UpdateExternalTexture(IntPtr nativeTexture) { }

	// RVA: 0x2B028F0 Offset: 0x2B029F1 VA: 0x2B028F0 Slot: 10
	public override bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0xD3DE0 Offset: 0xD3EE1 VA: 0xD3DE0
	// RVA: 0x2B02940 Offset: 0x2B02A41 VA: 0x2B02940
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute] // RVA: 0xD3E20 Offset: 0xD3F21 VA: 0xD3E20
	// RVA: 0x2B02A30 Offset: 0x2B02B31 VA: 0x2B02A30
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute] // RVA: 0xD3E60 Offset: 0xD3F61 VA: 0xD3E60
	// RVA: 0x2B02B30 Offset: 0x2B02C31 VA: 0x2B02B30
	public void SmoothEdges(int smoothRegionWidthInPixels) { }

	// RVA: 0x2B02B80 Offset: 0x2B02C81 VA: 0x2B02B80
	public void SmoothEdges() { }

	[FreeFunctionAttribute] // RVA: 0xD3EA0 Offset: 0xD3FA1 VA: 0xD3EA0
	// RVA: 0x2B02BD0 Offset: 0x2B02CD1 VA: 0x2B02BD0
	public Color[] GetPixels(CubemapFace face, int miplevel) { }

	// RVA: 0x2B02C30 Offset: 0x2B02D31 VA: 0x2B02C30
	public Color[] GetPixels(CubemapFace face) { }

	[FreeFunctionAttribute] // RVA: 0xD3EF0 Offset: 0xD3FF1 VA: 0xD3EF0
	// RVA: 0x2B02C90 Offset: 0x2B02D91 VA: 0x2B02C90
	public void SetPixels(Color[] colors, CubemapFace face, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0xD3F40 Offset: 0xD4041 VA: 0xD3F40
	// RVA: 0x2B02D00 Offset: 0x2B02E01 VA: 0x2B02D00
	private bool SetPixelDataImplArray(Array data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[FreeFunctionAttribute] // RVA: 0xD3F90 Offset: 0xD4091 VA: 0xD3F90
	// RVA: 0x2B02D90 Offset: 0x2B02E91 VA: 0x2B02D90
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	// RVA: 0x2B02E20 Offset: 0x2B02F21 VA: 0x2B02E20
	public void SetPixels(Color[] colors, CubemapFace face) { }

	// RVA: 0x2B02E80 Offset: 0x2B02F81 VA: 0x2B02E80
	public bool get_streamingMipmaps() { }

	// RVA: 0x2B02ED0 Offset: 0x2B02FD1 VA: 0x2B02ED0
	public int get_streamingMipmapsPriority() { }

	[FreeFunctionAttribute] // RVA: 0xD3FE0 Offset: 0xD40E1 VA: 0xD3FE0
	// RVA: 0x2B02F20 Offset: 0x2B03021 VA: 0x2B02F20
	public int get_requestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0xD4030 Offset: 0xD4131 VA: 0xD4030
	// RVA: 0x2B02F70 Offset: 0x2B03071 VA: 0x2B02F70
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0xD4080 Offset: 0xD4181 VA: 0xD4080
	// RVA: 0x2B02FC0 Offset: 0x2B030C1 VA: 0x2B02FC0
	internal bool get_loadAllMips() { }

	[FreeFunctionAttribute] // RVA: 0xD40D0 Offset: 0xD41D1 VA: 0xD40D0
	// RVA: 0x2B03010 Offset: 0x2B03111 VA: 0x2B03010
	internal void set_loadAllMips(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xD4120 Offset: 0xD4221 VA: 0xD4120
	// RVA: 0x2B03060 Offset: 0x2B03161 VA: 0x2B03060
	public int get_desiredMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0xD4170 Offset: 0xD4271 VA: 0xD4170
	// RVA: 0x2B030B0 Offset: 0x2B031B1 VA: 0x2B030B0
	public int get_loadingMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0xD41C0 Offset: 0xD42C1 VA: 0xD41C0
	// RVA: 0x2B03100 Offset: 0x2B03201 VA: 0x2B03100
	public int get_loadedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0xD4210 Offset: 0xD4311 VA: 0xD4210
	// RVA: 0x2B03150 Offset: 0x2B03251 VA: 0x2B03150
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0xD4260 Offset: 0xD4361 VA: 0xD4260
	// RVA: 0x2B031A0 Offset: 0x2B032A1 VA: 0x2B031A0
	public bool IsRequestedMipmapLevelLoaded() { }

	// RVA: 0x2B031F0 Offset: 0x2B032F1 VA: 0x2B031F0
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD42B0 Offset: 0xD43B1 VA: 0xD42B0
	// RVA: 0x2B03240 Offset: 0x2B03341 VA: 0x2B03240
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2B033B0 Offset: 0x2B034B1 VA: 0x2B033B0
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x2B035C0 Offset: 0x2B036C1 VA: 0x2B035C0
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x2B03420 Offset: 0x2B03521 VA: 0x2B03420
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x2B03790 Offset: 0x2B03891 VA: 0x2B03790
	internal void .ctor(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x2B037B0 Offset: 0x2B038B1 VA: 0x2B037B0
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2B03830 Offset: 0x2B03931 VA: 0x2B03830
	public static Cubemap CreateExternalTexture(int width, TextureFormat format, bool mipmap, IntPtr nativeTex) { }

	// RVA: -1 Offset: -1
	public void SetPixelData<T>(T[] data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E39F0 Offset: 0x23E3AF1 VA: 0x23E39F0
	|-Cubemap.SetPixelData<object>
	*/

	// RVA: -1 Offset: -1
	public void SetPixelData<T>(NativeArray<T> data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0) { }

	// RVA: 0x2B03920 Offset: 0x2B03A21 VA: 0x2B03920
	public void SetPixel(CubemapFace face, int x, int y, Color color) { }

	// RVA: 0x2B03A20 Offset: 0x2B03B21 VA: 0x2B03A20
	public Color GetPixel(CubemapFace face, int x, int y) { }

	// RVA: 0x2B03B00 Offset: 0x2B03C01 VA: 0x2B03B00
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x2B03BB0 Offset: 0x2B03CB1 VA: 0x2B03BB0
	public void Apply(bool updateMipmaps) { }

	// RVA: 0x2B03C60 Offset: 0x2B03D61 VA: 0x2B03C60
	public void Apply() { }

	// RVA: 0x2B029C0 Offset: 0x2B02AC1 VA: 0x2B029C0
	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	// RVA: 0x2B02AC0 Offset: 0x2B02BC1 VA: 0x2B02AC0
	private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) { }
}

