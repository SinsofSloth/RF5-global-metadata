[SaveDuringPlayAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[DocumentationSortingAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[AddComponentMenu] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[ExecuteAlways] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[DisallowMultipleComponent] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[HelpURLAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
public class CinemachineStoryboard : CinemachineExtension // TypeDefIndex: 4769
{
	// Fields
	[TooltipAttribute] // RVA: 0x131700 Offset: 0x131801 VA: 0x131700
	public static bool s_StoryboardGlobalMute; // 0x0
	[TooltipAttribute] // RVA: 0x131740 Offset: 0x131841 VA: 0x131740
	public bool m_ShowImage; // 0x28
	[TooltipAttribute] // RVA: 0x131780 Offset: 0x131881 VA: 0x131780
	public Texture m_Image; // 0x30
	[TooltipAttribute] // RVA: 0x1317C0 Offset: 0x1318C1 VA: 0x1317C0
	public CinemachineStoryboard.FillStrategy m_Aspect; // 0x38
	[TooltipAttribute] // RVA: 0x131800 Offset: 0x131901 VA: 0x131800
	[RangeAttribute] // RVA: 0x131800 Offset: 0x131901 VA: 0x131800
	public float m_Alpha; // 0x3C
	[TooltipAttribute] // RVA: 0x131860 Offset: 0x131961 VA: 0x131860
	public Vector2 m_Center; // 0x40
	[TooltipAttribute] // RVA: 0x1318A0 Offset: 0x1319A1 VA: 0x1318A0
	public Vector3 m_Rotation; // 0x48
	[TooltipAttribute] // RVA: 0x1318E0 Offset: 0x1319E1 VA: 0x1318E0
	public Vector2 m_Scale; // 0x54
	[TooltipAttribute] // RVA: 0x131920 Offset: 0x131A21 VA: 0x131920
	public bool m_SyncScale; // 0x5C
	[TooltipAttribute] // RVA: 0x131960 Offset: 0x131A61 VA: 0x131960
	public bool m_MuteCamera; // 0x5D
	[RangeAttribute] // RVA: 0x1319A0 Offset: 0x131AA1 VA: 0x1319A0
	[TooltipAttribute] // RVA: 0x1319A0 Offset: 0x131AA1 VA: 0x1319A0
	public float m_SplitView; // 0x60
	private List<CinemachineStoryboard.CanvasInfo> mCanvasInfo; // 0x68

	// Properties
	private string CanvasName { get; }

	// Methods

	// RVA: 0x1737D50 Offset: 0x1737E51 VA: 0x1737D50 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1737EC0 Offset: 0x1737FC1 VA: 0x1737EC0 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0x1738290 Offset: 0x1738391 VA: 0x1738290
	private string get_CanvasName() { }

	// RVA: 0x1738320 Offset: 0x1738421 VA: 0x1738320
	private void CameraUpdatedCallback(CinemachineBrain brain) { }

	// RVA: 0x1738590 Offset: 0x1738691 VA: 0x1738590
	private CinemachineStoryboard.CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound) { }

	// RVA: 0x17389E0 Offset: 0x1738AE1 VA: 0x17389E0
	private void CreateCanvas(CinemachineStoryboard.CanvasInfo ci) { }

	// RVA: 0x1738020 Offset: 0x1738121 VA: 0x1738020
	private void DestroyCanvas() { }

	// RVA: 0x1738E20 Offset: 0x1738F21 VA: 0x1738E20
	private void PlaceImage(CinemachineStoryboard.CanvasInfo ci, float alpha) { }

	// RVA: 0x17394C0 Offset: 0x17395C1 VA: 0x17394C0
	private static void StaticBlendingHandler(CinemachineBrain brain) { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x136C30 Offset: 0x136D31 VA: 0x136C30
	// RVA: 0x17396F0 Offset: 0x17397F1 VA: 0x17396F0
	private static void InitializeModule() { }

	// RVA: 0x1739800 Offset: 0x1739901 VA: 0x1739800
	public void .ctor() { }
}

[SaveDuringPlayAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[DocumentationSortingAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[AddComponentMenu] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[ExecuteAlways] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[DisallowMultipleComponent] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[HelpURLAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
public class CinemachineStoryboard : CinemachineExtension // TypeDefIndex: 4769
{
	// Fields
	[TooltipAttribute] // RVA: 0x131700 Offset: 0x131801 VA: 0x131700
	public static bool s_StoryboardGlobalMute; // 0x0
	[TooltipAttribute] // RVA: 0x131740 Offset: 0x131841 VA: 0x131740
	public bool m_ShowImage; // 0x28
	[TooltipAttribute] // RVA: 0x131780 Offset: 0x131881 VA: 0x131780
	public Texture m_Image; // 0x30
	[TooltipAttribute] // RVA: 0x1317C0 Offset: 0x1318C1 VA: 0x1317C0
	public CinemachineStoryboard.FillStrategy m_Aspect; // 0x38
	[TooltipAttribute] // RVA: 0x131800 Offset: 0x131901 VA: 0x131800
	[RangeAttribute] // RVA: 0x131800 Offset: 0x131901 VA: 0x131800
	public float m_Alpha; // 0x3C
	[TooltipAttribute] // RVA: 0x131860 Offset: 0x131961 VA: 0x131860
	public Vector2 m_Center; // 0x40
	[TooltipAttribute] // RVA: 0x1318A0 Offset: 0x1319A1 VA: 0x1318A0
	public Vector3 m_Rotation; // 0x48
	[TooltipAttribute] // RVA: 0x1318E0 Offset: 0x1319E1 VA: 0x1318E0
	public Vector2 m_Scale; // 0x54
	[TooltipAttribute] // RVA: 0x131920 Offset: 0x131A21 VA: 0x131920
	public bool m_SyncScale; // 0x5C
	[TooltipAttribute] // RVA: 0x131960 Offset: 0x131A61 VA: 0x131960
	public bool m_MuteCamera; // 0x5D
	[RangeAttribute] // RVA: 0x1319A0 Offset: 0x131AA1 VA: 0x1319A0
	[TooltipAttribute] // RVA: 0x1319A0 Offset: 0x131AA1 VA: 0x1319A0
	public float m_SplitView; // 0x60
	private List<CinemachineStoryboard.CanvasInfo> mCanvasInfo; // 0x68

	// Properties
	private string CanvasName { get; }

	// Methods

	// RVA: 0x1737D50 Offset: 0x1737E51 VA: 0x1737D50 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1737EC0 Offset: 0x1737FC1 VA: 0x1737EC0 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0x1738290 Offset: 0x1738391 VA: 0x1738290
	private string get_CanvasName() { }

	// RVA: 0x1738320 Offset: 0x1738421 VA: 0x1738320
	private void CameraUpdatedCallback(CinemachineBrain brain) { }

	// RVA: 0x1738590 Offset: 0x1738691 VA: 0x1738590
	private CinemachineStoryboard.CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound) { }

	// RVA: 0x17389E0 Offset: 0x1738AE1 VA: 0x17389E0
	private void CreateCanvas(CinemachineStoryboard.CanvasInfo ci) { }

	// RVA: 0x1738020 Offset: 0x1738121 VA: 0x1738020
	private void DestroyCanvas() { }

	// RVA: 0x1738E20 Offset: 0x1738F21 VA: 0x1738E20
	private void PlaceImage(CinemachineStoryboard.CanvasInfo ci, float alpha) { }

	// RVA: 0x17394C0 Offset: 0x17395C1 VA: 0x17394C0
	private static void StaticBlendingHandler(CinemachineBrain brain) { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x136C30 Offset: 0x136D31 VA: 0x136C30
	// RVA: 0x17396F0 Offset: 0x17397F1 VA: 0x17396F0
	private static void InitializeModule() { }

	// RVA: 0x1739800 Offset: 0x1739901 VA: 0x1739800
	public void .ctor() { }
}

[SaveDuringPlayAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[DocumentationSortingAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[AddComponentMenu] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[ExecuteAlways] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[DisallowMultipleComponent] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[HelpURLAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
public class CinemachineStoryboard : CinemachineExtension // TypeDefIndex: 4769
{
	// Fields
	[TooltipAttribute] // RVA: 0x131700 Offset: 0x131801 VA: 0x131700
	public static bool s_StoryboardGlobalMute; // 0x0
	[TooltipAttribute] // RVA: 0x131740 Offset: 0x131841 VA: 0x131740
	public bool m_ShowImage; // 0x28
	[TooltipAttribute] // RVA: 0x131780 Offset: 0x131881 VA: 0x131780
	public Texture m_Image; // 0x30
	[TooltipAttribute] // RVA: 0x1317C0 Offset: 0x1318C1 VA: 0x1317C0
	public CinemachineStoryboard.FillStrategy m_Aspect; // 0x38
	[TooltipAttribute] // RVA: 0x131800 Offset: 0x131901 VA: 0x131800
	[RangeAttribute] // RVA: 0x131800 Offset: 0x131901 VA: 0x131800
	public float m_Alpha; // 0x3C
	[TooltipAttribute] // RVA: 0x131860 Offset: 0x131961 VA: 0x131860
	public Vector2 m_Center; // 0x40
	[TooltipAttribute] // RVA: 0x1318A0 Offset: 0x1319A1 VA: 0x1318A0
	public Vector3 m_Rotation; // 0x48
	[TooltipAttribute] // RVA: 0x1318E0 Offset: 0x1319E1 VA: 0x1318E0
	public Vector2 m_Scale; // 0x54
	[TooltipAttribute] // RVA: 0x131920 Offset: 0x131A21 VA: 0x131920
	public bool m_SyncScale; // 0x5C
	[TooltipAttribute] // RVA: 0x131960 Offset: 0x131A61 VA: 0x131960
	public bool m_MuteCamera; // 0x5D
	[RangeAttribute] // RVA: 0x1319A0 Offset: 0x131AA1 VA: 0x1319A0
	[TooltipAttribute] // RVA: 0x1319A0 Offset: 0x131AA1 VA: 0x1319A0
	public float m_SplitView; // 0x60
	private List<CinemachineStoryboard.CanvasInfo> mCanvasInfo; // 0x68

	// Properties
	private string CanvasName { get; }

	// Methods

	// RVA: 0x1737D50 Offset: 0x1737E51 VA: 0x1737D50 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1737EC0 Offset: 0x1737FC1 VA: 0x1737EC0 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0x1738290 Offset: 0x1738391 VA: 0x1738290
	private string get_CanvasName() { }

	// RVA: 0x1738320 Offset: 0x1738421 VA: 0x1738320
	private void CameraUpdatedCallback(CinemachineBrain brain) { }

	// RVA: 0x1738590 Offset: 0x1738691 VA: 0x1738590
	private CinemachineStoryboard.CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound) { }

	// RVA: 0x17389E0 Offset: 0x1738AE1 VA: 0x17389E0
	private void CreateCanvas(CinemachineStoryboard.CanvasInfo ci) { }

	// RVA: 0x1738020 Offset: 0x1738121 VA: 0x1738020
	private void DestroyCanvas() { }

	// RVA: 0x1738E20 Offset: 0x1738F21 VA: 0x1738E20
	private void PlaceImage(CinemachineStoryboard.CanvasInfo ci, float alpha) { }

	// RVA: 0x17394C0 Offset: 0x17395C1 VA: 0x17394C0
	private static void StaticBlendingHandler(CinemachineBrain brain) { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x136C30 Offset: 0x136D31 VA: 0x136C30
	// RVA: 0x17396F0 Offset: 0x17397F1 VA: 0x17396F0
	private static void InitializeModule() { }

	// RVA: 0x1739800 Offset: 0x1739901 VA: 0x1739800
	public void .ctor() { }
}

[SaveDuringPlayAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[DocumentationSortingAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[AddComponentMenu] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[ExecuteAlways] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[DisallowMultipleComponent] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[HelpURLAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
public class CinemachineStoryboard : CinemachineExtension // TypeDefIndex: 4769
{
	// Fields
	[TooltipAttribute] // RVA: 0x131700 Offset: 0x131801 VA: 0x131700
	public static bool s_StoryboardGlobalMute; // 0x0
	[TooltipAttribute] // RVA: 0x131740 Offset: 0x131841 VA: 0x131740
	public bool m_ShowImage; // 0x28
	[TooltipAttribute] // RVA: 0x131780 Offset: 0x131881 VA: 0x131780
	public Texture m_Image; // 0x30
	[TooltipAttribute] // RVA: 0x1317C0 Offset: 0x1318C1 VA: 0x1317C0
	public CinemachineStoryboard.FillStrategy m_Aspect; // 0x38
	[TooltipAttribute] // RVA: 0x131800 Offset: 0x131901 VA: 0x131800
	[RangeAttribute] // RVA: 0x131800 Offset: 0x131901 VA: 0x131800
	public float m_Alpha; // 0x3C
	[TooltipAttribute] // RVA: 0x131860 Offset: 0x131961 VA: 0x131860
	public Vector2 m_Center; // 0x40
	[TooltipAttribute] // RVA: 0x1318A0 Offset: 0x1319A1 VA: 0x1318A0
	public Vector3 m_Rotation; // 0x48
	[TooltipAttribute] // RVA: 0x1318E0 Offset: 0x1319E1 VA: 0x1318E0
	public Vector2 m_Scale; // 0x54
	[TooltipAttribute] // RVA: 0x131920 Offset: 0x131A21 VA: 0x131920
	public bool m_SyncScale; // 0x5C
	[TooltipAttribute] // RVA: 0x131960 Offset: 0x131A61 VA: 0x131960
	public bool m_MuteCamera; // 0x5D
	[RangeAttribute] // RVA: 0x1319A0 Offset: 0x131AA1 VA: 0x1319A0
	[TooltipAttribute] // RVA: 0x1319A0 Offset: 0x131AA1 VA: 0x1319A0
	public float m_SplitView; // 0x60
	private List<CinemachineStoryboard.CanvasInfo> mCanvasInfo; // 0x68

	// Properties
	private string CanvasName { get; }

	// Methods

	// RVA: 0x1737D50 Offset: 0x1737E51 VA: 0x1737D50 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1737EC0 Offset: 0x1737FC1 VA: 0x1737EC0 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0x1738290 Offset: 0x1738391 VA: 0x1738290
	private string get_CanvasName() { }

	// RVA: 0x1738320 Offset: 0x1738421 VA: 0x1738320
	private void CameraUpdatedCallback(CinemachineBrain brain) { }

	// RVA: 0x1738590 Offset: 0x1738691 VA: 0x1738590
	private CinemachineStoryboard.CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound) { }

	// RVA: 0x17389E0 Offset: 0x1738AE1 VA: 0x17389E0
	private void CreateCanvas(CinemachineStoryboard.CanvasInfo ci) { }

	// RVA: 0x1738020 Offset: 0x1738121 VA: 0x1738020
	private void DestroyCanvas() { }

	// RVA: 0x1738E20 Offset: 0x1738F21 VA: 0x1738E20
	private void PlaceImage(CinemachineStoryboard.CanvasInfo ci, float alpha) { }

	// RVA: 0x17394C0 Offset: 0x17395C1 VA: 0x17394C0
	private static void StaticBlendingHandler(CinemachineBrain brain) { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x136C30 Offset: 0x136D31 VA: 0x136C30
	// RVA: 0x17396F0 Offset: 0x17397F1 VA: 0x17396F0
	private static void InitializeModule() { }

	// RVA: 0x1739800 Offset: 0x1739901 VA: 0x1739800
	public void .ctor() { }
}

[SaveDuringPlayAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[DocumentationSortingAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[AddComponentMenu] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[ExecuteAlways] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[DisallowMultipleComponent] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
[HelpURLAttribute] // RVA: 0x12E6C0 Offset: 0x12E7C1 VA: 0x12E6C0
public class CinemachineStoryboard : CinemachineExtension // TypeDefIndex: 4769
{
	// Fields
	[TooltipAttribute] // RVA: 0x131700 Offset: 0x131801 VA: 0x131700
	public static bool s_StoryboardGlobalMute; // 0x0
	[TooltipAttribute] // RVA: 0x131740 Offset: 0x131841 VA: 0x131740
	public bool m_ShowImage; // 0x28
	[TooltipAttribute] // RVA: 0x131780 Offset: 0x131881 VA: 0x131780
	public Texture m_Image; // 0x30
	[TooltipAttribute] // RVA: 0x1317C0 Offset: 0x1318C1 VA: 0x1317C0
	public CinemachineStoryboard.FillStrategy m_Aspect; // 0x38
	[TooltipAttribute] // RVA: 0x131800 Offset: 0x131901 VA: 0x131800
	[RangeAttribute] // RVA: 0x131800 Offset: 0x131901 VA: 0x131800
	public float m_Alpha; // 0x3C
	[TooltipAttribute] // RVA: 0x131860 Offset: 0x131961 VA: 0x131860
	public Vector2 m_Center; // 0x40
	[TooltipAttribute] // RVA: 0x1318A0 Offset: 0x1319A1 VA: 0x1318A0
	public Vector3 m_Rotation; // 0x48
	[TooltipAttribute] // RVA: 0x1318E0 Offset: 0x1319E1 VA: 0x1318E0
	public Vector2 m_Scale; // 0x54
	[TooltipAttribute] // RVA: 0x131920 Offset: 0x131A21 VA: 0x131920
	public bool m_SyncScale; // 0x5C
	[TooltipAttribute] // RVA: 0x131960 Offset: 0x131A61 VA: 0x131960
	public bool m_MuteCamera; // 0x5D
	[RangeAttribute] // RVA: 0x1319A0 Offset: 0x131AA1 VA: 0x1319A0
	[TooltipAttribute] // RVA: 0x1319A0 Offset: 0x131AA1 VA: 0x1319A0
	public float m_SplitView; // 0x60
	private List<CinemachineStoryboard.CanvasInfo> mCanvasInfo; // 0x68

	// Properties
	private string CanvasName { get; }

	// Methods

	// RVA: 0x1737D50 Offset: 0x1737E51 VA: 0x1737D50 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1737EC0 Offset: 0x1737FC1 VA: 0x1737EC0 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0x1738290 Offset: 0x1738391 VA: 0x1738290
	private string get_CanvasName() { }

	// RVA: 0x1738320 Offset: 0x1738421 VA: 0x1738320
	private void CameraUpdatedCallback(CinemachineBrain brain) { }

	// RVA: 0x1738590 Offset: 0x1738691 VA: 0x1738590
	private CinemachineStoryboard.CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound) { }

	// RVA: 0x17389E0 Offset: 0x1738AE1 VA: 0x17389E0
	private void CreateCanvas(CinemachineStoryboard.CanvasInfo ci) { }

	// RVA: 0x1738020 Offset: 0x1738121 VA: 0x1738020
	private void DestroyCanvas() { }

	// RVA: 0x1738E20 Offset: 0x1738F21 VA: 0x1738E20
	private void PlaceImage(CinemachineStoryboard.CanvasInfo ci, float alpha) { }

	// RVA: 0x17394C0 Offset: 0x17395C1 VA: 0x17394C0
	private static void StaticBlendingHandler(CinemachineBrain brain) { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x136C30 Offset: 0x136D31 VA: 0x136C30
	// RVA: 0x17396F0 Offset: 0x17397F1 VA: 0x17396F0
	private static void InitializeModule() { }

	// RVA: 0x1739800 Offset: 0x1739901 VA: 0x1739800
	public void .ctor() { }
}

