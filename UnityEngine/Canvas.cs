[RequireComponent] // RVA: 0x1031D0 Offset: 0x1032D1 VA: 0x1031D0
[NativeHeaderAttribute] // RVA: 0x1031D0 Offset: 0x1032D1 VA: 0x1031D0
[NativeClassAttribute] // RVA: 0x1031D0 Offset: 0x1032D1 VA: 0x1031D0
[NativeHeaderAttribute] // RVA: 0x1031D0 Offset: 0x1032D1 VA: 0x1031D0
public sealed class Canvas : Behaviour // TypeDefIndex: 3699
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x103350 Offset: 0x103451 VA: 0x103350
	[CompilerGeneratedAttribute] // RVA: 0x103350 Offset: 0x103451 VA: 0x103350
	private static Canvas.WillRenderCanvases willRenderCanvases; // 0x0

	// Properties
	public RenderMode renderMode { get; set; }
	public bool isRootCanvas { get; }
	public Rect pixelRect { get; }
	public float scaleFactor { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public bool overridePixelPerfect { get; set; }
	public bool pixelPerfect { get; set; }
	public float planeDistance { get; set; }
	public int renderOrder { get; }
	public bool overrideSorting { get; set; }
	public int sortingOrder { get; set; }
	public int targetDisplay { get; set; }
	public int sortingLayerID { get; set; }
	public int cachedSortingLayerValue { get; }
	public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
	public string sortingLayerName { get; set; }
	public Canvas rootCanvas { get; }
	[NativePropertyAttribute] // RVA: 0x103810 Offset: 0x103911 VA: 0x103810
	public Camera worldCamera { get; set; }
	[NativePropertyAttribute] // RVA: 0x103850 Offset: 0x103951 VA: 0x103850
	public float normalizedSortingGridSize { get; set; }
	[ObsoleteAttribute] // RVA: 0x103890 Offset: 0x103991 VA: 0x103890
	[NativePropertyAttribute] // RVA: 0x103890 Offset: 0x103991 VA: 0x103890
	public int sortingGridNormalizedSize { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1034F0 Offset: 0x1035F1 VA: 0x1034F0
	// RVA: 0x1BBEE20 Offset: 0x1BBEF21 VA: 0x1BBEE20
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGeneratedAttribute] // RVA: 0x103500 Offset: 0x103601 VA: 0x103500
	// RVA: 0x1BBEEE0 Offset: 0x1BBEFE1 VA: 0x1BBEEE0
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	// RVA: 0x1BBEFA0 Offset: 0x1BBF0A1 VA: 0x1BBEFA0
	public RenderMode get_renderMode() { }

	// RVA: 0x1BBEFF0 Offset: 0x1BBF0F1 VA: 0x1BBEFF0
	public void set_renderMode(RenderMode value) { }

	// RVA: 0x1BBF040 Offset: 0x1BBF141 VA: 0x1BBF040
	public bool get_isRootCanvas() { }

	// RVA: 0x1BBF090 Offset: 0x1BBF191 VA: 0x1BBF090
	public Rect get_pixelRect() { }

	// RVA: 0x1BBF140 Offset: 0x1BBF241 VA: 0x1BBF140
	public float get_scaleFactor() { }

	// RVA: 0x1BBF190 Offset: 0x1BBF291 VA: 0x1BBF190
	public void set_scaleFactor(float value) { }

	// RVA: 0x1BBF1E0 Offset: 0x1BBF2E1 VA: 0x1BBF1E0
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x1BBF230 Offset: 0x1BBF331 VA: 0x1BBF230
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x1BBF280 Offset: 0x1BBF381 VA: 0x1BBF280
	public bool get_overridePixelPerfect() { }

	// RVA: 0x1BBF2D0 Offset: 0x1BBF3D1 VA: 0x1BBF2D0
	public void set_overridePixelPerfect(bool value) { }

	// RVA: 0x1BBF320 Offset: 0x1BBF421 VA: 0x1BBF320
	public bool get_pixelPerfect() { }

	// RVA: 0x1BBF370 Offset: 0x1BBF471 VA: 0x1BBF370
	public void set_pixelPerfect(bool value) { }

	// RVA: 0x1BBF3C0 Offset: 0x1BBF4C1 VA: 0x1BBF3C0
	public float get_planeDistance() { }

	// RVA: 0x1BBF410 Offset: 0x1BBF511 VA: 0x1BBF410
	public void set_planeDistance(float value) { }

	// RVA: 0x1BBF460 Offset: 0x1BBF561 VA: 0x1BBF460
	public int get_renderOrder() { }

	// RVA: 0x1BBF4B0 Offset: 0x1BBF5B1 VA: 0x1BBF4B0
	public bool get_overrideSorting() { }

	// RVA: 0x1BBF500 Offset: 0x1BBF601 VA: 0x1BBF500
	public void set_overrideSorting(bool value) { }

	// RVA: 0x1BBF550 Offset: 0x1BBF651 VA: 0x1BBF550
	public int get_sortingOrder() { }

	// RVA: 0x1BBF5A0 Offset: 0x1BBF6A1 VA: 0x1BBF5A0
	public void set_sortingOrder(int value) { }

	// RVA: 0x1BBF5F0 Offset: 0x1BBF6F1 VA: 0x1BBF5F0
	public int get_targetDisplay() { }

	// RVA: 0x1BBF640 Offset: 0x1BBF741 VA: 0x1BBF640
	public void set_targetDisplay(int value) { }

	// RVA: 0x1BBF690 Offset: 0x1BBF791 VA: 0x1BBF690
	public int get_sortingLayerID() { }

	// RVA: 0x1BBF6E0 Offset: 0x1BBF7E1 VA: 0x1BBF6E0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x1BBF730 Offset: 0x1BBF831 VA: 0x1BBF730
	public int get_cachedSortingLayerValue() { }

	// RVA: 0x1BBF780 Offset: 0x1BBF881 VA: 0x1BBF780
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x1BBF7D0 Offset: 0x1BBF8D1 VA: 0x1BBF7D0
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x1BBF820 Offset: 0x1BBF921 VA: 0x1BBF820
	public string get_sortingLayerName() { }

	// RVA: 0x1BBF870 Offset: 0x1BBF971 VA: 0x1BBF870
	public void set_sortingLayerName(string value) { }

	// RVA: 0x1BBF8C0 Offset: 0x1BBF9C1 VA: 0x1BBF8C0
	public Canvas get_rootCanvas() { }

	// RVA: 0x1BBF910 Offset: 0x1BBFA11 VA: 0x1BBF910
	public Camera get_worldCamera() { }

	// RVA: 0x1BBF960 Offset: 0x1BBFA61 VA: 0x1BBF960
	public void set_worldCamera(Camera value) { }

	// RVA: 0x1BBF9B0 Offset: 0x1BBFAB1 VA: 0x1BBF9B0
	public float get_normalizedSortingGridSize() { }

	// RVA: 0x1BBFA00 Offset: 0x1BBFB01 VA: 0x1BBFA00
	public void set_normalizedSortingGridSize(float value) { }

	// RVA: 0x1BBFA50 Offset: 0x1BBFB51 VA: 0x1BBFA50
	public int get_sortingGridNormalizedSize() { }

	// RVA: 0x1BBFAA0 Offset: 0x1BBFBA1 VA: 0x1BBFAA0
	public void set_sortingGridNormalizedSize(int value) { }

	[ObsoleteAttribute] // RVA: 0x103510 Offset: 0x103611 VA: 0x103510
	[FreeFunctionAttribute] // RVA: 0x103510 Offset: 0x103611 VA: 0x103510
	// RVA: 0x1BBFAF0 Offset: 0x1BBFBF1 VA: 0x1BBFAF0
	public static Material GetDefaultCanvasTextMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x103580 Offset: 0x103681 VA: 0x103580
	// RVA: 0x1BBFB30 Offset: 0x1BBFC31 VA: 0x1BBFB30
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x1035C0 Offset: 0x1036C1 VA: 0x1035C0
	// RVA: 0x1BBFB70 Offset: 0x1BBFC71 VA: 0x1BBFB70
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x1BBFBB0 Offset: 0x1BBFCB1 VA: 0x1BBFBB0
	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x103600 Offset: 0x103701 VA: 0x103600
	// RVA: 0x1BBFC10 Offset: 0x1BBFD11 VA: 0x1BBFC10
	private static void SendWillRenderCanvases() { }

	// RVA: 0x1BBFEB0 Offset: 0x1BBFFB1 VA: 0x1BBFEB0
	public void .ctor() { }

	// RVA: 0x1BBF0F0 Offset: 0x1BBF1F1 VA: 0x1BBF0F0
	private void get_pixelRect_Injected(out Rect ret) { }
}

