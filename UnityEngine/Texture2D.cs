[NativeHeaderAttribute] // RVA: 0xC58E0 Offset: 0xC59E1 VA: 0xC58E0
[UsedByNativeCodeAttribute] // RVA: 0xC58E0 Offset: 0xC59E1 VA: 0xC58E0
[NativeHeaderAttribute] // RVA: 0xC58E0 Offset: 0xC59E1 VA: 0xC58E0
public sealed class Texture2D : Texture // TypeDefIndex: 2943
{
	// Properties
	public TextureFormat format { get; }
	[StaticAccessorAttribute] // RVA: 0xDEC10 Offset: 0xDED11 VA: 0xDEC10
	public static Texture2D whiteTexture { get; }
	[StaticAccessorAttribute] // RVA: 0xDEC50 Offset: 0xDED51 VA: 0xDEC50
	public static Texture2D blackTexture { get; }
	[StaticAccessorAttribute] // RVA: 0xDEC90 Offset: 0xDED91 VA: 0xDEC90
	public static Texture2D redTexture { get; }
	[StaticAccessorAttribute] // RVA: 0xDECD0 Offset: 0xDEDD1 VA: 0xDECD0
	public static Texture2D grayTexture { get; }
	[StaticAccessorAttribute] // RVA: 0xDED10 Offset: 0xDEE11 VA: 0xDED10
	public static Texture2D linearGrayTexture { get; }
	[StaticAccessorAttribute] // RVA: 0xDED50 Offset: 0xDEE51 VA: 0xDED50
	public static Texture2D normalTexture { get; }
	public override bool isReadable { get; }
	internal bool isPreProcessed { get; }
	public bool streamingMipmaps { get; }
	public int streamingMipmapsPriority { get; }
	public int requestedMipmapLevel { get; set; }
	public int minimumMipmapLevel { get; set; }
	internal bool loadAllMips { get; set; }
	public int calculatedMipmapLevel { get; }
	public int desiredMipmapLevel { get; }
	public int loadingMipmapLevel { get; }
	public int loadedMipmapLevel { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xD3240 Offset: 0xD3341 VA: 0xD3240
	// RVA: 0x2A31740 Offset: 0x2A31841 VA: 0x2A31740
	public TextureFormat get_format() { }

	// RVA: 0x2A31790 Offset: 0x2A31891 VA: 0x2A31790
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x2A317D0 Offset: 0x2A318D1 VA: 0x2A317D0
	public static Texture2D get_blackTexture() { }

	// RVA: 0x2A31810 Offset: 0x2A31911 VA: 0x2A31810
	public static Texture2D get_redTexture() { }

	// RVA: 0x2A31850 Offset: 0x2A31951 VA: 0x2A31850
	public static Texture2D get_grayTexture() { }

	// RVA: 0x2A31890 Offset: 0x2A31991 VA: 0x2A31890
	public static Texture2D get_linearGrayTexture() { }

	// RVA: 0x2A318D0 Offset: 0x2A319D1 VA: 0x2A318D0
	public static Texture2D get_normalTexture() { }

	// RVA: 0x2A31910 Offset: 0x2A31A11 VA: 0x2A31910
	public void Compress(bool highQuality) { }

	[FreeFunctionAttribute] // RVA: 0xD3280 Offset: 0xD3381 VA: 0xD3280
	// RVA: 0x2A31960 Offset: 0x2A31A61 VA: 0x2A31960
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x2A319F0 Offset: 0x2A31AF1 VA: 0x2A319F0
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x2A31AE0 Offset: 0x2A31BE1 VA: 0x2A31AE0 Slot: 10
	public override bool get_isReadable() { }

	[NativeNameAttribute] // RVA: 0xD32C0 Offset: 0xD33C1 VA: 0xD32C0
	// RVA: 0x2A31B30 Offset: 0x2A31C31 VA: 0x2A31B30
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeNameAttribute] // RVA: 0xD3300 Offset: 0xD3401 VA: 0xD3300
	// RVA: 0x2A31B90 Offset: 0x2A31C91 VA: 0x2A31B90
	private bool ResizeImpl(int width, int height) { }

	[NativeNameAttribute] // RVA: 0xD3340 Offset: 0xD3441 VA: 0xD3340
	// RVA: 0x2A31BF0 Offset: 0x2A31CF1 VA: 0x2A31BF0
	private void SetPixelImpl(int image, int x, int y, Color color) { }

	[NativeNameAttribute] // RVA: 0xD3380 Offset: 0xD3481 VA: 0xD3380
	// RVA: 0x2A31CE0 Offset: 0x2A31DE1 VA: 0x2A31CE0
	private Color GetPixelImpl(int image, int x, int y) { }

	[NativeNameAttribute] // RVA: 0xD33C0 Offset: 0xD34C1 VA: 0xD33C0
	// RVA: 0x2A31DE0 Offset: 0x2A31EE1 VA: 0x2A31DE0
	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	[FreeFunctionAttribute] // RVA: 0xD3400 Offset: 0xD3501 VA: 0xD3400
	// RVA: 0x2A31EE0 Offset: 0x2A31FE1 VA: 0x2A31EE0
	private bool ResizeWithFormatImpl(int width, int height, TextureFormat format, bool hasMipMap) { }

	[FreeFunctionAttribute] // RVA: 0xD3450 Offset: 0xD3551 VA: 0xD3450
	// RVA: 0x2A31F50 Offset: 0x2A32051 VA: 0x2A31F50
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunctionAttribute] // RVA: 0xD34A0 Offset: 0xD35A1 VA: 0xD34A0
	// RVA: 0x2A32040 Offset: 0x2A32141 VA: 0x2A32040
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunctionAttribute] // RVA: 0xD34F0 Offset: 0xD35F1 VA: 0xD34F0
	// RVA: 0x2A320E0 Offset: 0x2A321E1 VA: 0x2A320E0
	private bool LoadRawTextureDataImpl(IntPtr data, int size) { }

	[FreeFunctionAttribute] // RVA: 0xD3540 Offset: 0xD3641 VA: 0xD3540
	// RVA: 0x2A32140 Offset: 0x2A32241 VA: 0x2A32140
	private bool LoadRawTextureDataImplArray(byte[] data) { }

	[FreeFunctionAttribute] // RVA: 0xD3590 Offset: 0xD3691 VA: 0xD3590
	// RVA: 0x2A32190 Offset: 0x2A32291 VA: 0x2A32190
	private bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[FreeFunctionAttribute] // RVA: 0xD35E0 Offset: 0xD36E1 VA: 0xD35E0
	// RVA: 0x2A32210 Offset: 0x2A32311 VA: 0x2A32210
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	// RVA: 0x2A32290 Offset: 0x2A32391 VA: 0x2A32290
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x2A322E0 Offset: 0x2A323E1 VA: 0x2A322E0
	private long GetRawImageDataSize() { }

	[FreeFunctionAttribute] // RVA: 0xD3630 Offset: 0xD3731 VA: 0xD3630
	// RVA: 0x2A32330 Offset: 0x2A32431 VA: 0x2A32330
	private static void GenerateAtlasImpl(Vector2[] sizes, int padding, int atlasSize, [Out] Rect[] rect) { }

	// RVA: 0x2A323A0 Offset: 0x2A324A1 VA: 0x2A323A0
	internal bool get_isPreProcessed() { }

	// RVA: 0x2A323F0 Offset: 0x2A324F1 VA: 0x2A323F0
	public bool get_streamingMipmaps() { }

	// RVA: 0x2A32440 Offset: 0x2A32541 VA: 0x2A32440
	public int get_streamingMipmapsPriority() { }

	[FreeFunctionAttribute] // RVA: 0xD3670 Offset: 0xD3771 VA: 0xD3670
	// RVA: 0x2A32490 Offset: 0x2A32591 VA: 0x2A32490
	public int get_requestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0xD36C0 Offset: 0xD37C1 VA: 0xD36C0
	// RVA: 0x2A324E0 Offset: 0x2A325E1 VA: 0x2A324E0
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0xD3710 Offset: 0xD3811 VA: 0xD3710
	// RVA: 0x2A32530 Offset: 0x2A32631 VA: 0x2A32530
	public int get_minimumMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0xD3760 Offset: 0xD3861 VA: 0xD3760
	// RVA: 0x2A32580 Offset: 0x2A32681 VA: 0x2A32580
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunctionAttribute] // RVA: 0xD37B0 Offset: 0xD38B1 VA: 0xD37B0
	// RVA: 0x2A325D0 Offset: 0x2A326D1 VA: 0x2A325D0
	internal bool get_loadAllMips() { }

	[FreeFunctionAttribute] // RVA: 0xD3800 Offset: 0xD3901 VA: 0xD3800
	// RVA: 0x2A32620 Offset: 0x2A32721 VA: 0x2A32620
	internal void set_loadAllMips(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xD3850 Offset: 0xD3951 VA: 0xD3850
	// RVA: 0x2A32670 Offset: 0x2A32771 VA: 0x2A32670
	public int get_calculatedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0xD38A0 Offset: 0xD39A1 VA: 0xD38A0
	// RVA: 0x2A326C0 Offset: 0x2A327C1 VA: 0x2A326C0
	public int get_desiredMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0xD38F0 Offset: 0xD39F1 VA: 0xD38F0
	// RVA: 0x2A32710 Offset: 0x2A32811 VA: 0x2A32710
	public int get_loadingMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0xD3940 Offset: 0xD3A41 VA: 0xD3940
	// RVA: 0x2A32760 Offset: 0x2A32861 VA: 0x2A32760
	public int get_loadedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0xD3990 Offset: 0xD3A91 VA: 0xD3990
	// RVA: 0x2A327B0 Offset: 0x2A328B1 VA: 0x2A327B0
	public void ClearRequestedMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0xD39E0 Offset: 0xD3AE1 VA: 0xD39E0
	// RVA: 0x2A32800 Offset: 0x2A32901 VA: 0x2A32800
	public bool IsRequestedMipmapLevelLoaded() { }

	[FreeFunctionAttribute] // RVA: 0xD3A30 Offset: 0xD3B31 VA: 0xD3A30
	// RVA: 0x2A32850 Offset: 0x2A32951 VA: 0x2A32850
	public void ClearMinimumMipmapLevel() { }

	[FreeFunctionAttribute] // RVA: 0xD3A80 Offset: 0xD3B81 VA: 0xD3A80
	// RVA: 0x2A328A0 Offset: 0x2A329A1 VA: 0x2A328A0
	public void UpdateExternalTexture(IntPtr nativeTex) { }

	[FreeFunctionAttribute] // RVA: 0xD3AD0 Offset: 0xD3BD1 VA: 0xD3AD0
	// RVA: 0x2A328F0 Offset: 0x2A329F1 VA: 0x2A328F0
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0xD3B20 Offset: 0xD3C21 VA: 0xD3B20
	// RVA: 0x2A32950 Offset: 0x2A32A51 VA: 0x2A32950
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[FreeFunctionAttribute] // RVA: 0xD3B70 Offset: 0xD3C71 VA: 0xD3B70
	// RVA: 0x2A329E0 Offset: 0x2A32AE1 VA: 0x2A329E0
	public byte[] GetRawTextureData() { }

	[FreeFunctionAttribute] // RVA: 0xD3BC0 Offset: 0xD3CC1 VA: 0xD3BC0
	// RVA: 0x2A32A30 Offset: 0x2A32B31 VA: 0x2A32A30
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	// RVA: 0x2A32AB0 Offset: 0x2A32BB1 VA: 0x2A32AB0
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) { }

	[FreeFunctionAttribute] // RVA: 0xD3C10 Offset: 0xD3D11 VA: 0xD3C10
	// RVA: 0x2A32B30 Offset: 0x2A32C31 VA: 0x2A32B30
	public Color32[] GetPixels32(int miplevel) { }

	// RVA: 0x2A32B80 Offset: 0x2A32C81 VA: 0x2A32B80
	public Color32[] GetPixels32() { }

	[FreeFunctionAttribute] // RVA: 0xD3C60 Offset: 0xD3D61 VA: 0xD3C60
	// RVA: 0x2A32BD0 Offset: 0x2A32CD1 VA: 0x2A32BD0
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { }

	// RVA: 0x2A32C40 Offset: 0x2A32D41 VA: 0x2A32C40
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize) { }

	// RVA: 0x2A32CB0 Offset: 0x2A32DB1 VA: 0x2A32CB0
	public Rect[] PackTextures(Texture2D[] textures, int padding) { }

	// RVA: 0x2A32D10 Offset: 0x2A32E11 VA: 0x2A32D10
	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x2A32EC0 Offset: 0x2A32FC1 VA: 0x2A32EC0
	public void .ctor(int width, int height, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2A32F90 Offset: 0x2A33091 VA: 0x2A32F90
	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x2A33040 Offset: 0x2A33141 VA: 0x2A33040
	public void .ctor(int width, int height, GraphicsFormat format, int mipCount, TextureCreationFlags flags) { }

	// RVA: 0x2A330D0 Offset: 0x2A331D1 VA: 0x2A330D0
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex) { }

	// RVA: 0x2A332B0 Offset: 0x2A333B1 VA: 0x2A332B0
	public void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x2A33340 Offset: 0x2A33441 VA: 0x2A33340
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x2A333E0 Offset: 0x2A334E1 VA: 0x2A333E0
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x2A33470 Offset: 0x2A33571 VA: 0x2A33470
	public void .ctor(int width, int height) { }

	// RVA: 0x2A33510 Offset: 0x2A33611 VA: 0x2A33510
	public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex) { }

	// RVA: 0x2A33610 Offset: 0x2A33711 VA: 0x2A33610
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x2A33700 Offset: 0x2A33801 VA: 0x2A33700
	public void SetPixel(int x, int y, Color color, int mipLevel) { }

	// RVA: 0x2A337F0 Offset: 0x2A338F1 VA: 0x2A337F0
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	// RVA: 0x2A338D0 Offset: 0x2A339D1 VA: 0x2A338D0
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	// RVA: 0x2A339B0 Offset: 0x2A33AB1 VA: 0x2A339B0
	public void SetPixels(Color[] colors, int miplevel) { }

	// RVA: 0x2A33AB0 Offset: 0x2A33BB1 VA: 0x2A33AB0
	public void SetPixels(Color[] colors) { }

	// RVA: 0x2A33BA0 Offset: 0x2A33CA1 VA: 0x2A33BA0
	public Color GetPixel(int x, int y) { }

	// RVA: 0x2A33C70 Offset: 0x2A33D71 VA: 0x2A33C70
	public Color GetPixel(int x, int y, int mipLevel) { }

	// RVA: 0x2A33D50 Offset: 0x2A33E51 VA: 0x2A33D50
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x2A33E20 Offset: 0x2A33F21 VA: 0x2A33E20
	public Color GetPixelBilinear(float u, float v, int mipLevel) { }

	// RVA: 0x2A33F00 Offset: 0x2A34001 VA: 0x2A33F00
	public void LoadRawTextureData(IntPtr data, int size) { }

	// RVA: 0x2A34050 Offset: 0x2A34151 VA: 0x2A34050
	public void LoadRawTextureData(byte[] data) { }

	// RVA: -1 Offset: -1
	public void LoadRawTextureData<T>(NativeArray<T> data) { }

	// RVA: -1 Offset: -1
	public void SetPixelData<T>(T[] data, int mipLevel, int sourceDataStartIndex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E9E10 Offset: 0x23E9F11 VA: 0x23E9E10
	|-Texture2D.SetPixelData<object>
	*/

	// RVA: -1 Offset: -1
	public void SetPixelData<T>(NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0) { }

	// RVA: -1 Offset: -1
	public NativeArray<T> GetRawTextureData<T>() { }

	// RVA: 0x2A34190 Offset: 0x2A34291 VA: 0x2A34190
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x2A34240 Offset: 0x2A34341 VA: 0x2A34240
	public void Apply(bool updateMipmaps) { }

	// RVA: 0x2A342F0 Offset: 0x2A343F1 VA: 0x2A342F0
	public void Apply() { }

	// RVA: 0x2A34390 Offset: 0x2A34491 VA: 0x2A34390
	public bool Resize(int width, int height) { }

	// RVA: 0x2A34440 Offset: 0x2A34541 VA: 0x2A34440
	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x2A34500 Offset: 0x2A34601 VA: 0x2A34500
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD3CB0 Offset: 0xD3DB1 VA: 0xD3CB0
	// RVA: 0x2A345F0 Offset: 0x2A346F1 VA: 0x2A345F0
	public void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x2A34600 Offset: 0x2A34701 VA: 0x2A34600
	public static bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results) { }

	// RVA: 0x2A34790 Offset: 0x2A34891 VA: 0x2A34790
	public void SetPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x2A347F0 Offset: 0x2A348F1 VA: 0x2A347F0
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x2A34850 Offset: 0x2A34951 VA: 0x2A34850
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	// RVA: 0x2A348E0 Offset: 0x2A349E1 VA: 0x2A348E0
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	// RVA: 0x2A34970 Offset: 0x2A34A71 VA: 0x2A34970
	public Color[] GetPixels(int miplevel) { }

	// RVA: 0x2A34A10 Offset: 0x2A34B11 VA: 0x2A34A10
	public Color[] GetPixels() { }

	// RVA: 0x2A31C70 Offset: 0x2A31D71 VA: 0x2A31C70
	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	// RVA: 0x2A31D70 Offset: 0x2A31E71 VA: 0x2A31D70
	private void GetPixelImpl_Injected(int image, int x, int y, out Color ret) { }

	// RVA: 0x2A31E70 Offset: 0x2A31F71 VA: 0x2A31E70
	private void GetPixelBilinearImpl_Injected(int image, float u, float v, out Color ret) { }

	// RVA: 0x2A31FD0 Offset: 0x2A320D1 VA: 0x2A31FD0
	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }
}

