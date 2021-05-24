[NativeHeaderAttribute] // RVA: 0xC5A70 Offset: 0xC5B71 VA: 0xC5A70
[NativeHeaderAttribute] // RVA: 0xC5A70 Offset: 0xC5B71 VA: 0xC5A70
[UsedByNativeCodeAttribute] // RVA: 0xC5A70 Offset: 0xC5B71 VA: 0xC5A70
[NativeHeaderAttribute] // RVA: 0xC5A70 Offset: 0xC5B71 VA: 0xC5A70
[NativeHeaderAttribute] // RVA: 0xC5A70 Offset: 0xC5B71 VA: 0xC5A70
public class RenderTexture : Texture // TypeDefIndex: 2948
{
	// Properties
	public override int width { get; set; }
	public override int height { get; set; }
	public override TextureDimension dimension { get; set; }
	[NativePropertyAttribute] // RVA: 0xDED90 Offset: 0xDEE91 VA: 0xDED90
	public GraphicsFormat graphicsFormat { get; set; }
	[NativePropertyAttribute] // RVA: 0xDEDD0 Offset: 0xDEED1 VA: 0xDEDD0
	public bool useMipMap { get; set; }
	[NativePropertyAttribute] // RVA: 0xDEE10 Offset: 0xDEF11 VA: 0xDEE10
	public bool sRGB { get; }
	[NativePropertyAttribute] // RVA: 0xDEE50 Offset: 0xDEF51 VA: 0xDEE50
	public VRTextureUsage vrUsage { get; set; }
	[NativePropertyAttribute] // RVA: 0xDEE90 Offset: 0xDEF91 VA: 0xDEE90
	public RenderTextureMemoryless memorylessMode { get; set; }
	public RenderTextureFormat format { get; set; }
	public GraphicsFormat stencilFormat { get; set; }
	public bool autoGenerateMips { get; set; }
	public int volumeDepth { get; set; }
	public int antiAliasing { get; set; }
	public bool bindTextureMS { get; set; }
	public bool enableRandomWrite { get; set; }
	public bool useDynamicScale { get; set; }
	public bool isPowerOfTwo { get; set; }
	public static RenderTexture active { get; set; }
	public RenderBuffer colorBuffer { get; }
	public RenderBuffer depthBuffer { get; }
	public int depth { get; set; }
	public RenderTextureDescriptor descriptor { get; set; }
	[ObsoleteAttribute] // RVA: 0xDEED0 Offset: 0xDEFD1 VA: 0xDEED0
	public bool isCubemap { get; set; }
	[ObsoleteAttribute] // RVA: 0xDEF10 Offset: 0xDF011 VA: 0xDEF10
	public bool isVolume { get; set; }
	[EditorBrowsableAttribute] // RVA: 0xDEF50 Offset: 0xDF051 VA: 0xDEF50
	[ObsoleteAttribute] // RVA: 0xDEF50 Offset: 0xDF051 VA: 0xDEF50
	public static bool enabled { get; set; }

	// Methods

	// RVA: 0x2B7D3E0 Offset: 0x2B7D4E1 VA: 0x2B7D3E0 Slot: 4
	public override int get_width() { }

	// RVA: 0x2B7D430 Offset: 0x2B7D531 VA: 0x2B7D430 Slot: 5
	public override void set_width(int value) { }

	// RVA: 0x2B7D480 Offset: 0x2B7D581 VA: 0x2B7D480 Slot: 6
	public override int get_height() { }

	// RVA: 0x2B7D4D0 Offset: 0x2B7D5D1 VA: 0x2B7D4D0 Slot: 7
	public override void set_height(int value) { }

	// RVA: 0x2B7D520 Offset: 0x2B7D621 VA: 0x2B7D520 Slot: 8
	public override TextureDimension get_dimension() { }

	// RVA: 0x2B7D570 Offset: 0x2B7D671 VA: 0x2B7D570 Slot: 9
	public override void set_dimension(TextureDimension value) { }

	// RVA: 0x2B7D5C0 Offset: 0x2B7D6C1 VA: 0x2B7D5C0
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x2B7D610 Offset: 0x2B7D711 VA: 0x2B7D610
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x2B7D660 Offset: 0x2B7D761 VA: 0x2B7D660
	public bool get_useMipMap() { }

	// RVA: 0x2B7D6B0 Offset: 0x2B7D7B1 VA: 0x2B7D6B0
	public void set_useMipMap(bool value) { }

	// RVA: 0x2B7D700 Offset: 0x2B7D801 VA: 0x2B7D700
	public bool get_sRGB() { }

	// RVA: 0x2B7D750 Offset: 0x2B7D851 VA: 0x2B7D750
	public VRTextureUsage get_vrUsage() { }

	// RVA: 0x2B7D7A0 Offset: 0x2B7D8A1 VA: 0x2B7D7A0
	public void set_vrUsage(VRTextureUsage value) { }

	// RVA: 0x2B7D7F0 Offset: 0x2B7D8F1 VA: 0x2B7D7F0
	public RenderTextureMemoryless get_memorylessMode() { }

	// RVA: 0x2B7D840 Offset: 0x2B7D941 VA: 0x2B7D840
	public void set_memorylessMode(RenderTextureMemoryless value) { }

	// RVA: 0x2B7D890 Offset: 0x2B7D991 VA: 0x2B7D890
	public RenderTextureFormat get_format() { }

	// RVA: 0x2B7D8E0 Offset: 0x2B7D9E1 VA: 0x2B7D8E0
	public void set_format(RenderTextureFormat value) { }

	// RVA: 0x2B7D970 Offset: 0x2B7DA71 VA: 0x2B7D970
	public GraphicsFormat get_stencilFormat() { }

	// RVA: 0x2B7D9C0 Offset: 0x2B7DAC1 VA: 0x2B7D9C0
	public void set_stencilFormat(GraphicsFormat value) { }

	// RVA: 0x2B7DA10 Offset: 0x2B7DB11 VA: 0x2B7DA10
	public bool get_autoGenerateMips() { }

	// RVA: 0x2B7DA60 Offset: 0x2B7DB61 VA: 0x2B7DA60
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x2B7DAB0 Offset: 0x2B7DBB1 VA: 0x2B7DAB0
	public int get_volumeDepth() { }

	// RVA: 0x2B7DB00 Offset: 0x2B7DC01 VA: 0x2B7DB00
	public void set_volumeDepth(int value) { }

	// RVA: 0x2B7DB50 Offset: 0x2B7DC51 VA: 0x2B7DB50
	public int get_antiAliasing() { }

	// RVA: 0x2B7DBA0 Offset: 0x2B7DCA1 VA: 0x2B7DBA0
	public void set_antiAliasing(int value) { }

	// RVA: 0x2B7DBF0 Offset: 0x2B7DCF1 VA: 0x2B7DBF0
	public bool get_bindTextureMS() { }

	// RVA: 0x2B7DC40 Offset: 0x2B7DD41 VA: 0x2B7DC40
	public void set_bindTextureMS(bool value) { }

	// RVA: 0x2B7DC90 Offset: 0x2B7DD91 VA: 0x2B7DC90
	public bool get_enableRandomWrite() { }

	// RVA: 0x2B7DCE0 Offset: 0x2B7DDE1 VA: 0x2B7DCE0
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x2B7DD30 Offset: 0x2B7DE31 VA: 0x2B7DD30
	public bool get_useDynamicScale() { }

	// RVA: 0x2B7DD80 Offset: 0x2B7DE81 VA: 0x2B7DD80
	public void set_useDynamicScale(bool value) { }

	// RVA: 0x2B7DDD0 Offset: 0x2B7DED1 VA: 0x2B7DDD0
	private bool GetIsPowerOfTwo() { }

	// RVA: 0x2B7DE20 Offset: 0x2B7DF21 VA: 0x2B7DE20
	public bool get_isPowerOfTwo() { }

	// RVA: 0x2B7DE70 Offset: 0x2B7DF71 VA: 0x2B7DE70
	public void set_isPowerOfTwo(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xD4450 Offset: 0xD4551 VA: 0xD4450
	// RVA: 0x2B7DE80 Offset: 0x2B7DF81 VA: 0x2B7DE80
	private static RenderTexture GetActive() { }

	[FreeFunctionAttribute] // RVA: 0xD4490 Offset: 0xD4591 VA: 0xD4490
	// RVA: 0x2B7DEC0 Offset: 0x2B7DFC1 VA: 0x2B7DEC0
	private static void SetActive(RenderTexture rt) { }

	// RVA: 0x2B7DF10 Offset: 0x2B7E011 VA: 0x2B7DF10
	public static RenderTexture get_active() { }

	// RVA: 0x2B7DF50 Offset: 0x2B7E051 VA: 0x2B7DF50
	public static void set_active(RenderTexture value) { }

	[FreeFunctionAttribute] // RVA: 0xD44D0 Offset: 0xD45D1 VA: 0xD44D0
	// RVA: 0x2B7DFA0 Offset: 0x2B7E0A1 VA: 0x2B7DFA0
	private RenderBuffer GetColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xD4520 Offset: 0xD4621 VA: 0xD4520
	// RVA: 0x2B7E050 Offset: 0x2B7E151 VA: 0x2B7E050
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0x2B7E100 Offset: 0x2B7E201 VA: 0x2B7E100
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x2B7E160 Offset: 0x2B7E261 VA: 0x2B7E160
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0x2B7E1C0 Offset: 0x2B7E2C1 VA: 0x2B7E1C0
	public IntPtr GetNativeDepthBufferPtr() { }

	// RVA: 0x2B7E210 Offset: 0x2B7E311 VA: 0x2B7E210
	public void DiscardContents(bool discardColor, bool discardDepth) { }

	// RVA: 0x2B7E270 Offset: 0x2B7E371 VA: 0x2B7E270
	public void MarkRestoreExpected() { }

	// RVA: 0x2B7E2C0 Offset: 0x2B7E3C1 VA: 0x2B7E2C0
	public void DiscardContents() { }

	[NativeNameAttribute] // RVA: 0xD4570 Offset: 0xD4671 VA: 0xD4570
	// RVA: 0x2B7E310 Offset: 0x2B7E411 VA: 0x2B7E310
	private void ResolveAA() { }

	[NativeNameAttribute] // RVA: 0xD45B0 Offset: 0xD46B1 VA: 0xD45B0
	// RVA: 0x2B7E360 Offset: 0x2B7E461 VA: 0x2B7E360
	private void ResolveAATo(RenderTexture rt) { }

	// RVA: 0x2B7E3B0 Offset: 0x2B7E4B1 VA: 0x2B7E3B0
	public void ResolveAntiAliasedSurface() { }

	// RVA: 0x2B7E400 Offset: 0x2B7E501 VA: 0x2B7E400
	public void ResolveAntiAliasedSurface(RenderTexture target) { }

	[FreeFunctionAttribute] // RVA: 0xD45F0 Offset: 0xD46F1 VA: 0xD45F0
	// RVA: 0x2B7E450 Offset: 0x2B7E551 VA: 0x2B7E450
	public void SetGlobalShaderProperty(string propertyName) { }

	// RVA: 0x2B7E4A0 Offset: 0x2B7E5A1 VA: 0x2B7E4A0
	public bool Create() { }

	// RVA: 0x2B7E4F0 Offset: 0x2B7E5F1 VA: 0x2B7E4F0
	public void Release() { }

	// RVA: 0x2B7E540 Offset: 0x2B7E641 VA: 0x2B7E540
	public bool IsCreated() { }

	// RVA: 0x2B7E590 Offset: 0x2B7E691 VA: 0x2B7E590
	public void GenerateMips() { }

	// RVA: 0x2B7E5E0 Offset: 0x2B7E6E1 VA: 0x2B7E5E0
	public void ConvertToEquirect(RenderTexture equirect, Camera.MonoOrStereoscopicEye eye = 2) { }

	// RVA: 0x2B7E640 Offset: 0x2B7E741 VA: 0x2B7E640
	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunctionAttribute] // RVA: 0xD4640 Offset: 0xD4741 VA: 0xD4640
	// RVA: 0x2B7E690 Offset: 0x2B7E791 VA: 0x2B7E690
	private static void Internal_Create(RenderTexture rt) { }

	[FreeFunctionAttribute] // RVA: 0xD4680 Offset: 0xD4781 VA: 0xD4680
	// RVA: 0x2B7E6E0 Offset: 0x2B7E7E1 VA: 0x2B7E6E0
	public static bool SupportsStencil(RenderTexture rt) { }

	[NativeNameAttribute] // RVA: 0xD46C0 Offset: 0xD47C1 VA: 0xD46C0
	// RVA: 0x2B7E730 Offset: 0x2B7E831 VA: 0x2B7E730
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeNameAttribute] // RVA: 0xD4700 Offset: 0xD4801 VA: 0xD4700
	// RVA: 0x2B7E7D0 Offset: 0x2B7E8D1 VA: 0x2B7E7D0
	private RenderTextureDescriptor GetDescriptor() { }

	[FreeFunctionAttribute] // RVA: 0xD4740 Offset: 0xD4841 VA: 0xD4740
	// RVA: 0x2B7E8B0 Offset: 0x2B7E9B1 VA: 0x2B7E8B0
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0xD4780 Offset: 0xD4881 VA: 0xD4780
	// RVA: 0x2B7E950 Offset: 0x2B7EA51 VA: 0x2B7E950
	public static void ReleaseTemporary(RenderTexture temp) { }

	[FreeFunctionAttribute] // RVA: 0xD47C0 Offset: 0xD48C1 VA: 0xD47C0
	// RVA: 0x2B7E9A0 Offset: 0x2B7EAA1 VA: 0x2B7E9A0
	public int get_depth() { }

	[FreeFunctionAttribute] // RVA: 0xD4810 Offset: 0xD4911 VA: 0xD4810
	// RVA: 0x2B7E9F0 Offset: 0x2B7EAF1 VA: 0x2B7E9F0
	public void set_depth(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD4860 Offset: 0xD4961 VA: 0xD4860
	// RVA: 0x2B7EA40 Offset: 0x2B7EB41 VA: 0x2B7EA40
	protected internal void .ctor() { }

	// RVA: 0x2B7EAB0 Offset: 0x2B7EBB1 VA: 0x2B7EAB0
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x2B7EF40 Offset: 0x2B7F041 VA: 0x2B7EF40
	public void .ctor(RenderTexture textureToCopy) { }

	// RVA: 0x2B7F340 Offset: 0x2B7F441 VA: 0x2B7F340
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	// RVA: 0x2B7F390 Offset: 0x2B7F491 VA: 0x2B7F390
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	// RVA: 0x2B7F550 Offset: 0x2B7F651 VA: 0x2B7F550
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	// RVA: 0x2B7F910 Offset: 0x2B7FA11 VA: 0x2B7F910
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD4870 Offset: 0xD4971 VA: 0xD4870
	// RVA: 0x2B7FAB0 Offset: 0x2B7FBB1 VA: 0x2B7FAB0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD4880 Offset: 0xD4981 VA: 0xD4880
	// RVA: 0x2B7FB00 Offset: 0x2B7FC01 VA: 0x2B7FB00
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD4890 Offset: 0xD4991 VA: 0xD4890
	// RVA: 0x2B7FB50 Offset: 0x2B7FC51 VA: 0x2B7FB50
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x2B7F280 Offset: 0x2B7F381 VA: 0x2B7F280
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x2B7F860 Offset: 0x2B7F961 VA: 0x2B7F860
	public void set_descriptor(RenderTextureDescriptor value) { }

	// RVA: 0x2B7EBE0 Offset: 0x2B7ECE1 VA: 0x2B7EBE0
	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x2B7F960 Offset: 0x2B7FA61 VA: 0x2B7F960
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x2B7FC60 Offset: 0x2B7FD61 VA: 0x2B7FC60
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x2B7FD30 Offset: 0x2B7FE31 VA: 0x2B7FD30
	private static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = False) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD48A0 Offset: 0xD49A1 VA: 0xD48A0
	// RVA: 0x2B7FFD0 Offset: 0x2B800D1 VA: 0x2B7FFD0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD48B0 Offset: 0xD49B1 VA: 0xD48B0
	// RVA: 0x2B7FFE0 Offset: 0x2B800E1 VA: 0x2B7FFE0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD48C0 Offset: 0xD49C1 VA: 0xD48C0
	// RVA: 0x2B80000 Offset: 0x2B80101 VA: 0x2B80000
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD48D0 Offset: 0xD49D1 VA: 0xD48D0
	// RVA: 0x2B80030 Offset: 0x2B80131 VA: 0x2B80030
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD48E0 Offset: 0xD49E1 VA: 0xD48E0
	// RVA: 0x2B80060 Offset: 0x2B80161 VA: 0x2B80060
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format) { }

	// RVA: 0x2B80090 Offset: 0x2B80191 VA: 0x2B80090
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD48F0 Offset: 0xD49F1 VA: 0xD48F0
	// RVA: 0x2B80110 Offset: 0x2B80211 VA: 0x2B80110
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD4900 Offset: 0xD4A01 VA: 0xD4900
	// RVA: 0x2B80180 Offset: 0x2B80281 VA: 0x2B80180
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD4910 Offset: 0xD4A11 VA: 0xD4910
	// RVA: 0x2B80200 Offset: 0x2B80301 VA: 0x2B80200
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD4920 Offset: 0xD4A21 VA: 0xD4920
	// RVA: 0x2B80270 Offset: 0x2B80371 VA: 0x2B80270
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD4930 Offset: 0xD4A31 VA: 0xD4930
	// RVA: 0x2B802E0 Offset: 0x2B803E1 VA: 0x2B802E0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD4940 Offset: 0xD4A41 VA: 0xD4940
	// RVA: 0x2B80350 Offset: 0x2B80451 VA: 0x2B80350
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD4950 Offset: 0xD4A51 VA: 0xD4950
	// RVA: 0x2B803C0 Offset: 0x2B804C1 VA: 0x2B803C0
	public static RenderTexture GetTemporary(int width, int height) { }

	// RVA: 0x2B80420 Offset: 0x2B80521 VA: 0x2B80420
	public bool get_isCubemap() { }

	// RVA: 0x2B80450 Offset: 0x2B80551 VA: 0x2B80450
	public void set_isCubemap(bool value) { }

	// RVA: 0x2B80480 Offset: 0x2B80581 VA: 0x2B80480
	public bool get_isVolume() { }

	// RVA: 0x2B804B0 Offset: 0x2B805B1 VA: 0x2B804B0
	public void set_isVolume(bool value) { }

	// RVA: 0x2B804E0 Offset: 0x2B805E1 VA: 0x2B804E0
	public static bool get_enabled() { }

	// RVA: 0x2B804F0 Offset: 0x2B805F1 VA: 0x2B804F0
	public static void set_enabled(bool value) { }

	[ObsoleteAttribute] // RVA: 0xD4960 Offset: 0xD4A61 VA: 0xD4960
	[EditorBrowsableAttribute] // RVA: 0xD4960 Offset: 0xD4A61 VA: 0xD4960
	// RVA: 0x2B80500 Offset: 0x2B80601 VA: 0x2B80500
	public Vector2 GetTexelOffset() { }

	// RVA: 0x2B7E000 Offset: 0x2B7E101 VA: 0x2B7E000
	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x2B7E0B0 Offset: 0x2B7E1B1 VA: 0x2B7E0B0
	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x2B7E780 Offset: 0x2B7E881 VA: 0x2B7E780
	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	// RVA: 0x2B7E860 Offset: 0x2B7E961 VA: 0x2B7E860
	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	// RVA: 0x2B7E900 Offset: 0x2B7EA01 VA: 0x2B7E900
	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }
}

