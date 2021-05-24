[AddComponentMenu] // RVA: 0x148E70 Offset: 0x148F71 VA: 0x148E70
public class CaptureFromCamera : CaptureBase // TypeDefIndex: 9587
{
	// Fields
	[SerializeField] // RVA: 0x17D150 Offset: 0x17D251 VA: 0x17D150
	private Camera _lastCamera; // 0x1B0
	[SerializeField] // RVA: 0x17D160 Offset: 0x17D261 VA: 0x17D160
	private Camera[] _contribCameras; // 0x1B8
	[SerializeField] // RVA: 0x17D170 Offset: 0x17D271 VA: 0x17D170
	private bool _useContributingCameras; // 0x1C0
	private RenderTexture _target; // 0x1C8
	private IntPtr _targetNativePointer; // 0x1D0

	// Properties
	public bool UseContributingCameras { get; set; }

	// Methods

	// RVA: 0x2317010 Offset: 0x2317111 VA: 0x2317010
	public bool get_UseContributingCameras() { }

	// RVA: 0x2317020 Offset: 0x2317121 VA: 0x2317020
	public void set_UseContributingCameras(bool value) { }

	// RVA: 0x2317030 Offset: 0x2317131 VA: 0x2317030
	public void SetCamera(Camera mainCamera, bool useContributingCameras = True) { }

	// RVA: 0x23176C0 Offset: 0x23177C1 VA: 0x23176C0
	public void SetCamera(Camera mainCamera, Camera[] contributingCameras) { }

	// RVA: 0x2317700 Offset: 0x2317801 VA: 0x2317700
	private bool HasCamera() { }

	// RVA: 0x2317770 Offset: 0x2317871 VA: 0x2317770
	private bool HasContributingCameras() { }

	// RVA: 0x23177A0 Offset: 0x23178A1 VA: 0x23177A0 Slot: 13
	public override void UpdateFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC310 Offset: 0x1AC411 VA: 0x1AC310
	// RVA: 0x23178C0 Offset: 0x23179C1 VA: 0x23178C0
	private IEnumerator FinalRenderCapture() { }

	// RVA: 0x2317940 Offset: 0x2317A41 VA: 0x2317940
	private void Capture() { }

	// RVA: 0x2317C60 Offset: 0x2317D61 VA: 0x2317C60
	private void UpdateTexture() { }

	// RVA: 0x2318240 Offset: 0x2318341 VA: 0x2318240 Slot: 10
	public override void UnprepareCapture() { }

	// RVA: 0x2318350 Offset: 0x2318451 VA: 0x2318350 Slot: 12
	public override Texture GetPreviewTexture() { }

	// RVA: 0x2318360 Offset: 0x2318461 VA: 0x2318360 Slot: 9
	public override bool PrepareCapture() { }

	// RVA: 0x23189C0 Offset: 0x2318AC1 VA: 0x23189C0 Slot: 6
	public override void OnDestroy() { }

	// RVA: 0x2318A70 Offset: 0x2318B71 VA: 0x2318A70
	public void .ctor() { }
}

[AddComponentMenu] // RVA: 0x148E70 Offset: 0x148F71 VA: 0x148E70
public class CaptureFromCamera : CaptureBase // TypeDefIndex: 9587
{
	// Fields
	[SerializeField] // RVA: 0x17D150 Offset: 0x17D251 VA: 0x17D150
	private Camera _lastCamera; // 0x1B0
	[SerializeField] // RVA: 0x17D160 Offset: 0x17D261 VA: 0x17D160
	private Camera[] _contribCameras; // 0x1B8
	[SerializeField] // RVA: 0x17D170 Offset: 0x17D271 VA: 0x17D170
	private bool _useContributingCameras; // 0x1C0
	private RenderTexture _target; // 0x1C8
	private IntPtr _targetNativePointer; // 0x1D0

	// Properties
	public bool UseContributingCameras { get; set; }

	// Methods

	// RVA: 0x2317010 Offset: 0x2317111 VA: 0x2317010
	public bool get_UseContributingCameras() { }

	// RVA: 0x2317020 Offset: 0x2317121 VA: 0x2317020
	public void set_UseContributingCameras(bool value) { }

	// RVA: 0x2317030 Offset: 0x2317131 VA: 0x2317030
	public void SetCamera(Camera mainCamera, bool useContributingCameras = True) { }

	// RVA: 0x23176C0 Offset: 0x23177C1 VA: 0x23176C0
	public void SetCamera(Camera mainCamera, Camera[] contributingCameras) { }

	// RVA: 0x2317700 Offset: 0x2317801 VA: 0x2317700
	private bool HasCamera() { }

	// RVA: 0x2317770 Offset: 0x2317871 VA: 0x2317770
	private bool HasContributingCameras() { }

	// RVA: 0x23177A0 Offset: 0x23178A1 VA: 0x23177A0 Slot: 13
	public override void UpdateFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC310 Offset: 0x1AC411 VA: 0x1AC310
	// RVA: 0x23178C0 Offset: 0x23179C1 VA: 0x23178C0
	private IEnumerator FinalRenderCapture() { }

	// RVA: 0x2317940 Offset: 0x2317A41 VA: 0x2317940
	private void Capture() { }

	// RVA: 0x2317C60 Offset: 0x2317D61 VA: 0x2317C60
	private void UpdateTexture() { }

	// RVA: 0x2318240 Offset: 0x2318341 VA: 0x2318240 Slot: 10
	public override void UnprepareCapture() { }

	// RVA: 0x2318350 Offset: 0x2318451 VA: 0x2318350 Slot: 12
	public override Texture GetPreviewTexture() { }

	// RVA: 0x2318360 Offset: 0x2318461 VA: 0x2318360 Slot: 9
	public override bool PrepareCapture() { }

	// RVA: 0x23189C0 Offset: 0x2318AC1 VA: 0x23189C0 Slot: 6
	public override void OnDestroy() { }

	// RVA: 0x2318A70 Offset: 0x2318B71 VA: 0x2318A70
	public void .ctor() { }
}

[AddComponentMenu] // RVA: 0x148E70 Offset: 0x148F71 VA: 0x148E70
public class CaptureFromCamera : CaptureBase // TypeDefIndex: 9587
{
	// Fields
	[SerializeField] // RVA: 0x17D150 Offset: 0x17D251 VA: 0x17D150
	private Camera _lastCamera; // 0x1B0
	[SerializeField] // RVA: 0x17D160 Offset: 0x17D261 VA: 0x17D160
	private Camera[] _contribCameras; // 0x1B8
	[SerializeField] // RVA: 0x17D170 Offset: 0x17D271 VA: 0x17D170
	private bool _useContributingCameras; // 0x1C0
	private RenderTexture _target; // 0x1C8
	private IntPtr _targetNativePointer; // 0x1D0

	// Properties
	public bool UseContributingCameras { get; set; }

	// Methods

	// RVA: 0x2317010 Offset: 0x2317111 VA: 0x2317010
	public bool get_UseContributingCameras() { }

	// RVA: 0x2317020 Offset: 0x2317121 VA: 0x2317020
	public void set_UseContributingCameras(bool value) { }

	// RVA: 0x2317030 Offset: 0x2317131 VA: 0x2317030
	public void SetCamera(Camera mainCamera, bool useContributingCameras = True) { }

	// RVA: 0x23176C0 Offset: 0x23177C1 VA: 0x23176C0
	public void SetCamera(Camera mainCamera, Camera[] contributingCameras) { }

	// RVA: 0x2317700 Offset: 0x2317801 VA: 0x2317700
	private bool HasCamera() { }

	// RVA: 0x2317770 Offset: 0x2317871 VA: 0x2317770
	private bool HasContributingCameras() { }

	// RVA: 0x23177A0 Offset: 0x23178A1 VA: 0x23177A0 Slot: 13
	public override void UpdateFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC310 Offset: 0x1AC411 VA: 0x1AC310
	// RVA: 0x23178C0 Offset: 0x23179C1 VA: 0x23178C0
	private IEnumerator FinalRenderCapture() { }

	// RVA: 0x2317940 Offset: 0x2317A41 VA: 0x2317940
	private void Capture() { }

	// RVA: 0x2317C60 Offset: 0x2317D61 VA: 0x2317C60
	private void UpdateTexture() { }

	// RVA: 0x2318240 Offset: 0x2318341 VA: 0x2318240 Slot: 10
	public override void UnprepareCapture() { }

	// RVA: 0x2318350 Offset: 0x2318451 VA: 0x2318350 Slot: 12
	public override Texture GetPreviewTexture() { }

	// RVA: 0x2318360 Offset: 0x2318461 VA: 0x2318360 Slot: 9
	public override bool PrepareCapture() { }

	// RVA: 0x23189C0 Offset: 0x2318AC1 VA: 0x23189C0 Slot: 6
	public override void OnDestroy() { }

	// RVA: 0x2318A70 Offset: 0x2318B71 VA: 0x2318A70
	public void .ctor() { }
}

[AddComponentMenu] // RVA: 0x148E70 Offset: 0x148F71 VA: 0x148E70
public class CaptureFromCamera : CaptureBase // TypeDefIndex: 9587
{
	// Fields
	[SerializeField] // RVA: 0x17D150 Offset: 0x17D251 VA: 0x17D150
	private Camera _lastCamera; // 0x1B0
	[SerializeField] // RVA: 0x17D160 Offset: 0x17D261 VA: 0x17D160
	private Camera[] _contribCameras; // 0x1B8
	[SerializeField] // RVA: 0x17D170 Offset: 0x17D271 VA: 0x17D170
	private bool _useContributingCameras; // 0x1C0
	private RenderTexture _target; // 0x1C8
	private IntPtr _targetNativePointer; // 0x1D0

	// Properties
	public bool UseContributingCameras { get; set; }

	// Methods

	// RVA: 0x2317010 Offset: 0x2317111 VA: 0x2317010
	public bool get_UseContributingCameras() { }

	// RVA: 0x2317020 Offset: 0x2317121 VA: 0x2317020
	public void set_UseContributingCameras(bool value) { }

	// RVA: 0x2317030 Offset: 0x2317131 VA: 0x2317030
	public void SetCamera(Camera mainCamera, bool useContributingCameras = True) { }

	// RVA: 0x23176C0 Offset: 0x23177C1 VA: 0x23176C0
	public void SetCamera(Camera mainCamera, Camera[] contributingCameras) { }

	// RVA: 0x2317700 Offset: 0x2317801 VA: 0x2317700
	private bool HasCamera() { }

	// RVA: 0x2317770 Offset: 0x2317871 VA: 0x2317770
	private bool HasContributingCameras() { }

	// RVA: 0x23177A0 Offset: 0x23178A1 VA: 0x23177A0 Slot: 13
	public override void UpdateFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC310 Offset: 0x1AC411 VA: 0x1AC310
	// RVA: 0x23178C0 Offset: 0x23179C1 VA: 0x23178C0
	private IEnumerator FinalRenderCapture() { }

	// RVA: 0x2317940 Offset: 0x2317A41 VA: 0x2317940
	private void Capture() { }

	// RVA: 0x2317C60 Offset: 0x2317D61 VA: 0x2317C60
	private void UpdateTexture() { }

	// RVA: 0x2318240 Offset: 0x2318341 VA: 0x2318240 Slot: 10
	public override void UnprepareCapture() { }

	// RVA: 0x2318350 Offset: 0x2318451 VA: 0x2318350 Slot: 12
	public override Texture GetPreviewTexture() { }

	// RVA: 0x2318360 Offset: 0x2318461 VA: 0x2318360 Slot: 9
	public override bool PrepareCapture() { }

	// RVA: 0x23189C0 Offset: 0x2318AC1 VA: 0x23189C0 Slot: 6
	public override void OnDestroy() { }

	// RVA: 0x2318A70 Offset: 0x2318B71 VA: 0x2318A70
	public void .ctor() { }
}

[AddComponentMenu] // RVA: 0x148E70 Offset: 0x148F71 VA: 0x148E70
public class CaptureFromCamera : CaptureBase // TypeDefIndex: 9587
{
	// Fields
	[SerializeField] // RVA: 0x17D150 Offset: 0x17D251 VA: 0x17D150
	private Camera _lastCamera; // 0x1B0
	[SerializeField] // RVA: 0x17D160 Offset: 0x17D261 VA: 0x17D160
	private Camera[] _contribCameras; // 0x1B8
	[SerializeField] // RVA: 0x17D170 Offset: 0x17D271 VA: 0x17D170
	private bool _useContributingCameras; // 0x1C0
	private RenderTexture _target; // 0x1C8
	private IntPtr _targetNativePointer; // 0x1D0

	// Properties
	public bool UseContributingCameras { get; set; }

	// Methods

	// RVA: 0x2317010 Offset: 0x2317111 VA: 0x2317010
	public bool get_UseContributingCameras() { }

	// RVA: 0x2317020 Offset: 0x2317121 VA: 0x2317020
	public void set_UseContributingCameras(bool value) { }

	// RVA: 0x2317030 Offset: 0x2317131 VA: 0x2317030
	public void SetCamera(Camera mainCamera, bool useContributingCameras = True) { }

	// RVA: 0x23176C0 Offset: 0x23177C1 VA: 0x23176C0
	public void SetCamera(Camera mainCamera, Camera[] contributingCameras) { }

	// RVA: 0x2317700 Offset: 0x2317801 VA: 0x2317700
	private bool HasCamera() { }

	// RVA: 0x2317770 Offset: 0x2317871 VA: 0x2317770
	private bool HasContributingCameras() { }

	// RVA: 0x23177A0 Offset: 0x23178A1 VA: 0x23177A0 Slot: 13
	public override void UpdateFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC310 Offset: 0x1AC411 VA: 0x1AC310
	// RVA: 0x23178C0 Offset: 0x23179C1 VA: 0x23178C0
	private IEnumerator FinalRenderCapture() { }

	// RVA: 0x2317940 Offset: 0x2317A41 VA: 0x2317940
	private void Capture() { }

	// RVA: 0x2317C60 Offset: 0x2317D61 VA: 0x2317C60
	private void UpdateTexture() { }

	// RVA: 0x2318240 Offset: 0x2318341 VA: 0x2318240 Slot: 10
	public override void UnprepareCapture() { }

	// RVA: 0x2318350 Offset: 0x2318451 VA: 0x2318350 Slot: 12
	public override Texture GetPreviewTexture() { }

	// RVA: 0x2318360 Offset: 0x2318461 VA: 0x2318360 Slot: 9
	public override bool PrepareCapture() { }

	// RVA: 0x23189C0 Offset: 0x2318AC1 VA: 0x23189C0 Slot: 6
	public override void OnDestroy() { }

	// RVA: 0x2318A70 Offset: 0x2318B71 VA: 0x2318A70
	public void .ctor() { }
}

