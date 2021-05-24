public static class RenderPipelineManager // TypeDefIndex: 3328
{
	// Fields
	internal static RenderPipelineAsset s_CurrentPipelineAsset; // 0x0
	private static Camera[] s_Cameras; // 0x8
	private static int s_CameraCapacity; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xCBAF0 Offset: 0xCBBF1 VA: 0xCBAF0
	[DebuggerBrowsableAttribute] // RVA: 0xCBAF0 Offset: 0xCBBF1 VA: 0xCBAF0
	private static RenderPipeline <currentPipeline>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xCBB30 Offset: 0xCBC31 VA: 0xCBB30
	[DebuggerBrowsableAttribute] // RVA: 0xCBB30 Offset: 0xCBC31 VA: 0xCBB30
	private static Action<ScriptableRenderContext, Camera[]> beginFrameRendering; // 0x20

	// Properties
	public static RenderPipeline currentPipeline { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xD9AD0 Offset: 0xD9BD1 VA: 0xD9AD0
	// RVA: 0x2A20C30 Offset: 0x2A20D31 VA: 0x2A20C30
	public static RenderPipeline get_currentPipeline() { }

	[CompilerGeneratedAttribute] // RVA: 0xD9AE0 Offset: 0xD9BE1 VA: 0xD9AE0
	// RVA: 0x2A20CA0 Offset: 0x2A20DA1 VA: 0x2A20CA0
	private static void set_currentPipeline(RenderPipeline value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD9AF0 Offset: 0xD9BF1 VA: 0xD9AF0
	// RVA: 0x2A20D10 Offset: 0x2A20E11 VA: 0x2A20D10
	public static void add_beginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD9B00 Offset: 0xD9C01 VA: 0xD9B00
	// RVA: 0x2A20E00 Offset: 0x2A20F01 VA: 0x2A20E00
	public static void remove_beginFrameRendering(Action<ScriptableRenderContext, Camera[]> value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9B10 Offset: 0xD9C11 VA: 0xD9B10
	// RVA: 0x2A20480 Offset: 0x2A20581 VA: 0x2A20480
	internal static void CleanupRenderPipeline() { }

	// RVA: 0x2A20FA0 Offset: 0x2A210A1 VA: 0x2A20FA0
	private static void GetCameras(ScriptableRenderContext context) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9B20 Offset: 0xD9C21 VA: 0xD9B20
	// RVA: 0x2A21250 Offset: 0x2A21351 VA: 0x2A21250
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr) { }

	// RVA: 0x2A207E0 Offset: 0x2A208E1 VA: 0x2A207E0
	internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x2A214C0 Offset: 0x2A215C1 VA: 0x2A214C0
	private static void .cctor() { }
}

