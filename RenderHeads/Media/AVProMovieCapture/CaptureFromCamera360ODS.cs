[AddComponentMenu] // RVA: 0x148EF0 Offset: 0x148FF1 VA: 0x148EF0
public class CaptureFromCamera360ODS : CaptureBase // TypeDefIndex: 9592
{
	// Fields
	[SerializeField] // RVA: 0x17D280 Offset: 0x17D381 VA: 0x17D280
	private CaptureFromCamera360ODS.Settings _settings; // 0x1B0
	private int _eyeWidth; // 0x1B8
	private int _eyeHeight; // 0x1BC
	private Transform _cameraGroup; // 0x1C0
	private Camera _leftCameraTop; // 0x1C8
	private Camera _leftCameraBot; // 0x1D0
	private Camera _rightCameraTop; // 0x1D8
	private Camera _rightCameraBot; // 0x1E0
	private RenderTexture _final; // 0x1E8
	private IntPtr _targetNativePointer; // 0x1F0
	private Material _finalMaterial; // 0x1F8
	private int _propSliceCenter; // 0x200

	// Properties
	public CaptureFromCamera360ODS.Settings Setup { get; }

	// Methods

	// RVA: 0x231B1B0 Offset: 0x231B2B1 VA: 0x231B1B0
	public CaptureFromCamera360ODS.Settings get_Setup() { }

	// RVA: 0x231B1C0 Offset: 0x231B2C1 VA: 0x231B1C0
	public void .ctor() { }

	// RVA: 0x231B310 Offset: 0x231B411 VA: 0x231B310
	public void SetCamera(Camera camera) { }

	// RVA: 0x231B330 Offset: 0x231B431 VA: 0x231B330 Slot: 5
	public override void Start() { }

	// RVA: 0x231B450 Offset: 0x231B551 VA: 0x231B450
	private Camera CreateEye(Camera camera, string gameObjectName, float yRot, float xOffset, int cameraTargetHeight, int cullingMask, float fov, float aspect, int aalevel) { }

	// RVA: 0x231BA10 Offset: 0x231BB11 VA: 0x231BA10 Slot: 13
	public override void UpdateFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC3F0 Offset: 0x1AC4F1 VA: 0x1AC3F0
	// RVA: 0x231BAD0 Offset: 0x231BBD1 VA: 0x231BAD0
	private IEnumerator FinalRenderCapture() { }

	// RVA: 0x231BB50 Offset: 0x231BC51 VA: 0x231BB50
	private void Capture() { }

	// RVA: 0x231BD80 Offset: 0x231BE81 VA: 0x231BD80
	private void AccumulateMotionBlur() { }

	// RVA: 0x231BE80 Offset: 0x231BF81 VA: 0x231BE80
	private void RenderFrame() { }

	// RVA: 0x231C2A0 Offset: 0x231C3A1 VA: 0x231C2A0 Slot: 12
	public override Texture GetPreviewTexture() { }

	// RVA: 0x231C2F0 Offset: 0x231C3F1 VA: 0x231C2F0 Slot: 9
	public override bool PrepareCapture() { }

	// RVA: 0x231CD50 Offset: 0x231CE51 VA: 0x231CD50
	private static void DestroyEye(Camera camera) { }

	// RVA: 0x231CE30 Offset: 0x231CF31 VA: 0x231CE30 Slot: 6
	public override void OnDestroy() { }
}

