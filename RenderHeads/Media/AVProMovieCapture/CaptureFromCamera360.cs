[AddComponentMenu] // RVA: 0x148EB0 Offset: 0x148FB1 VA: 0x148EB0
public class CaptureFromCamera360 : CaptureBase // TypeDefIndex: 9589
{
	// Fields
	[SerializeField] // RVA: 0x17D180 Offset: 0x17D281 VA: 0x17D180
	public int _cubemapResolution; // 0x1B0
	[SerializeField] // RVA: 0x17D190 Offset: 0x17D291 VA: 0x17D190
	public int _cubemapDepth; // 0x1B4
	[SerializeField] // RVA: 0x17D1A0 Offset: 0x17D2A1 VA: 0x17D1A0
	public bool _supportGUI; // 0x1B8
	[SerializeField] // RVA: 0x17D1B0 Offset: 0x17D2B1 VA: 0x17D1B0
	public bool _supportCameraRotation; // 0x1B9
	[SerializeField] // RVA: 0x17D1C0 Offset: 0x17D2C1 VA: 0x17D1C0
	[TooltipAttribute] // RVA: 0x17D1C0 Offset: 0x17D2C1 VA: 0x17D1C0
	public bool _render180Degrees; // 0x1BA
	[SerializeField] // RVA: 0x17D210 Offset: 0x17D311 VA: 0x17D210
	public StereoPacking _stereoRendering; // 0x1BC
	[SerializeField] // RVA: 0x17D220 Offset: 0x17D321 VA: 0x17D220
	[TooltipAttribute] // RVA: 0x17D220 Offset: 0x17D321 VA: 0x17D220
	public float _ipd; // 0x1C0
	[SerializeField] // RVA: 0x17D270 Offset: 0x17D371 VA: 0x17D270
	private Camera _camera; // 0x1C8
	private RenderTexture _faceTarget; // 0x1D0
	private Material _blitMaterial; // 0x1D8
	private Material _cubemapToEquirectangularMaterial; // 0x1E0
	private RenderTexture _cubeTarget; // 0x1E8
	private RenderTexture _finalTarget; // 0x1F0
	private IntPtr _targetNativePointer; // 0x1F8
	private int _propFlipX; // 0x200

	// Methods

	// RVA: 0x2318C00 Offset: 0x2318D01 VA: 0x2318C00
	public void .ctor() { }

	// RVA: 0x2318C90 Offset: 0x2318D91 VA: 0x2318C90
	private CaptureFromCamera360.CubemapRenderMethod GetCubemapRenderingMethod() { }

	// RVA: 0x2318CD0 Offset: 0x2318DD1 VA: 0x2318CD0
	public void SetCamera(Camera camera) { }

	// RVA: 0x2318CE0 Offset: 0x2318DE1 VA: 0x2318CE0 Slot: 13
	public override void UpdateFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC380 Offset: 0x1AC481 VA: 0x1AC380
	// RVA: 0x2318DA0 Offset: 0x2318EA1 VA: 0x2318DA0
	private IEnumerator FinalRenderCapture() { }

	// RVA: 0x2318E20 Offset: 0x2318F21 VA: 0x2318E20
	private void Capture() { }

	// RVA: 0x23195D0 Offset: 0x23196D1 VA: 0x23195D0
	private static void ClearCubemap(RenderTexture texture, Color color) { }

	// RVA: 0x23197B0 Offset: 0x23198B1 VA: 0x23197B0
	private void RenderCubemapToEquiRect(RenderTexture cubemap, RenderTexture target, bool supportRotation, Quaternion rotation, bool isEyeLeft) { }

	// RVA: 0x2319200 Offset: 0x2319301 VA: 0x2319200
	private void UpdateTexture() { }

	// RVA: 0x2319920 Offset: 0x2319A21 VA: 0x2319920
	private void RenderCameraToCubemap(Camera camera, RenderTexture cubemapTarget) { }

	// RVA: 0x2319110 Offset: 0x2319211 VA: 0x2319110
	private void AccumulateMotionBlur() { }

	// RVA: 0x231A0F0 Offset: 0x231A1F1 VA: 0x231A0F0 Slot: 9
	public override bool PrepareCapture() { }

	// RVA: 0x231AC90 Offset: 0x231AD91 VA: 0x231AC90 Slot: 12
	public override Texture GetPreviewTexture() { }

	// RVA: 0x231ACE0 Offset: 0x231ADE1 VA: 0x231ACE0 Slot: 5
	public override void Start() { }

	// RVA: 0x231AEB0 Offset: 0x231AFB1 VA: 0x231AEB0 Slot: 6
	public override void OnDestroy() { }
}

[AddComponentMenu] // RVA: 0x148EB0 Offset: 0x148FB1 VA: 0x148EB0
public class CaptureFromCamera360 : CaptureBase // TypeDefIndex: 9589
{
	// Fields
	[SerializeField] // RVA: 0x17D180 Offset: 0x17D281 VA: 0x17D180
	public int _cubemapResolution; // 0x1B0
	[SerializeField] // RVA: 0x17D190 Offset: 0x17D291 VA: 0x17D190
	public int _cubemapDepth; // 0x1B4
	[SerializeField] // RVA: 0x17D1A0 Offset: 0x17D2A1 VA: 0x17D1A0
	public bool _supportGUI; // 0x1B8
	[SerializeField] // RVA: 0x17D1B0 Offset: 0x17D2B1 VA: 0x17D1B0
	public bool _supportCameraRotation; // 0x1B9
	[SerializeField] // RVA: 0x17D1C0 Offset: 0x17D2C1 VA: 0x17D1C0
	[TooltipAttribute] // RVA: 0x17D1C0 Offset: 0x17D2C1 VA: 0x17D1C0
	public bool _render180Degrees; // 0x1BA
	[SerializeField] // RVA: 0x17D210 Offset: 0x17D311 VA: 0x17D210
	public StereoPacking _stereoRendering; // 0x1BC
	[SerializeField] // RVA: 0x17D220 Offset: 0x17D321 VA: 0x17D220
	[TooltipAttribute] // RVA: 0x17D220 Offset: 0x17D321 VA: 0x17D220
	public float _ipd; // 0x1C0
	[SerializeField] // RVA: 0x17D270 Offset: 0x17D371 VA: 0x17D270
	private Camera _camera; // 0x1C8
	private RenderTexture _faceTarget; // 0x1D0
	private Material _blitMaterial; // 0x1D8
	private Material _cubemapToEquirectangularMaterial; // 0x1E0
	private RenderTexture _cubeTarget; // 0x1E8
	private RenderTexture _finalTarget; // 0x1F0
	private IntPtr _targetNativePointer; // 0x1F8
	private int _propFlipX; // 0x200

	// Methods

	// RVA: 0x2318C00 Offset: 0x2318D01 VA: 0x2318C00
	public void .ctor() { }

	// RVA: 0x2318C90 Offset: 0x2318D91 VA: 0x2318C90
	private CaptureFromCamera360.CubemapRenderMethod GetCubemapRenderingMethod() { }

	// RVA: 0x2318CD0 Offset: 0x2318DD1 VA: 0x2318CD0
	public void SetCamera(Camera camera) { }

	// RVA: 0x2318CE0 Offset: 0x2318DE1 VA: 0x2318CE0 Slot: 13
	public override void UpdateFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC380 Offset: 0x1AC481 VA: 0x1AC380
	// RVA: 0x2318DA0 Offset: 0x2318EA1 VA: 0x2318DA0
	private IEnumerator FinalRenderCapture() { }

	// RVA: 0x2318E20 Offset: 0x2318F21 VA: 0x2318E20
	private void Capture() { }

	// RVA: 0x23195D0 Offset: 0x23196D1 VA: 0x23195D0
	private static void ClearCubemap(RenderTexture texture, Color color) { }

	// RVA: 0x23197B0 Offset: 0x23198B1 VA: 0x23197B0
	private void RenderCubemapToEquiRect(RenderTexture cubemap, RenderTexture target, bool supportRotation, Quaternion rotation, bool isEyeLeft) { }

	// RVA: 0x2319200 Offset: 0x2319301 VA: 0x2319200
	private void UpdateTexture() { }

	// RVA: 0x2319920 Offset: 0x2319A21 VA: 0x2319920
	private void RenderCameraToCubemap(Camera camera, RenderTexture cubemapTarget) { }

	// RVA: 0x2319110 Offset: 0x2319211 VA: 0x2319110
	private void AccumulateMotionBlur() { }

	// RVA: 0x231A0F0 Offset: 0x231A1F1 VA: 0x231A0F0 Slot: 9
	public override bool PrepareCapture() { }

	// RVA: 0x231AC90 Offset: 0x231AD91 VA: 0x231AC90 Slot: 12
	public override Texture GetPreviewTexture() { }

	// RVA: 0x231ACE0 Offset: 0x231ADE1 VA: 0x231ACE0 Slot: 5
	public override void Start() { }

	// RVA: 0x231AEB0 Offset: 0x231AFB1 VA: 0x231AEB0 Slot: 6
	public override void OnDestroy() { }
}

[AddComponentMenu] // RVA: 0x148EB0 Offset: 0x148FB1 VA: 0x148EB0
public class CaptureFromCamera360 : CaptureBase // TypeDefIndex: 9589
{
	// Fields
	[SerializeField] // RVA: 0x17D180 Offset: 0x17D281 VA: 0x17D180
	public int _cubemapResolution; // 0x1B0
	[SerializeField] // RVA: 0x17D190 Offset: 0x17D291 VA: 0x17D190
	public int _cubemapDepth; // 0x1B4
	[SerializeField] // RVA: 0x17D1A0 Offset: 0x17D2A1 VA: 0x17D1A0
	public bool _supportGUI; // 0x1B8
	[SerializeField] // RVA: 0x17D1B0 Offset: 0x17D2B1 VA: 0x17D1B0
	public bool _supportCameraRotation; // 0x1B9
	[SerializeField] // RVA: 0x17D1C0 Offset: 0x17D2C1 VA: 0x17D1C0
	[TooltipAttribute] // RVA: 0x17D1C0 Offset: 0x17D2C1 VA: 0x17D1C0
	public bool _render180Degrees; // 0x1BA
	[SerializeField] // RVA: 0x17D210 Offset: 0x17D311 VA: 0x17D210
	public StereoPacking _stereoRendering; // 0x1BC
	[SerializeField] // RVA: 0x17D220 Offset: 0x17D321 VA: 0x17D220
	[TooltipAttribute] // RVA: 0x17D220 Offset: 0x17D321 VA: 0x17D220
	public float _ipd; // 0x1C0
	[SerializeField] // RVA: 0x17D270 Offset: 0x17D371 VA: 0x17D270
	private Camera _camera; // 0x1C8
	private RenderTexture _faceTarget; // 0x1D0
	private Material _blitMaterial; // 0x1D8
	private Material _cubemapToEquirectangularMaterial; // 0x1E0
	private RenderTexture _cubeTarget; // 0x1E8
	private RenderTexture _finalTarget; // 0x1F0
	private IntPtr _targetNativePointer; // 0x1F8
	private int _propFlipX; // 0x200

	// Methods

	// RVA: 0x2318C00 Offset: 0x2318D01 VA: 0x2318C00
	public void .ctor() { }

	// RVA: 0x2318C90 Offset: 0x2318D91 VA: 0x2318C90
	private CaptureFromCamera360.CubemapRenderMethod GetCubemapRenderingMethod() { }

	// RVA: 0x2318CD0 Offset: 0x2318DD1 VA: 0x2318CD0
	public void SetCamera(Camera camera) { }

	// RVA: 0x2318CE0 Offset: 0x2318DE1 VA: 0x2318CE0 Slot: 13
	public override void UpdateFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC380 Offset: 0x1AC481 VA: 0x1AC380
	// RVA: 0x2318DA0 Offset: 0x2318EA1 VA: 0x2318DA0
	private IEnumerator FinalRenderCapture() { }

	// RVA: 0x2318E20 Offset: 0x2318F21 VA: 0x2318E20
	private void Capture() { }

	// RVA: 0x23195D0 Offset: 0x23196D1 VA: 0x23195D0
	private static void ClearCubemap(RenderTexture texture, Color color) { }

	// RVA: 0x23197B0 Offset: 0x23198B1 VA: 0x23197B0
	private void RenderCubemapToEquiRect(RenderTexture cubemap, RenderTexture target, bool supportRotation, Quaternion rotation, bool isEyeLeft) { }

	// RVA: 0x2319200 Offset: 0x2319301 VA: 0x2319200
	private void UpdateTexture() { }

	// RVA: 0x2319920 Offset: 0x2319A21 VA: 0x2319920
	private void RenderCameraToCubemap(Camera camera, RenderTexture cubemapTarget) { }

	// RVA: 0x2319110 Offset: 0x2319211 VA: 0x2319110
	private void AccumulateMotionBlur() { }

	// RVA: 0x231A0F0 Offset: 0x231A1F1 VA: 0x231A0F0 Slot: 9
	public override bool PrepareCapture() { }

	// RVA: 0x231AC90 Offset: 0x231AD91 VA: 0x231AC90 Slot: 12
	public override Texture GetPreviewTexture() { }

	// RVA: 0x231ACE0 Offset: 0x231ADE1 VA: 0x231ACE0 Slot: 5
	public override void Start() { }

	// RVA: 0x231AEB0 Offset: 0x231AFB1 VA: 0x231AEB0 Slot: 6
	public override void OnDestroy() { }
}

[AddComponentMenu] // RVA: 0x148EB0 Offset: 0x148FB1 VA: 0x148EB0
public class CaptureFromCamera360 : CaptureBase // TypeDefIndex: 9589
{
	// Fields
	[SerializeField] // RVA: 0x17D180 Offset: 0x17D281 VA: 0x17D180
	public int _cubemapResolution; // 0x1B0
	[SerializeField] // RVA: 0x17D190 Offset: 0x17D291 VA: 0x17D190
	public int _cubemapDepth; // 0x1B4
	[SerializeField] // RVA: 0x17D1A0 Offset: 0x17D2A1 VA: 0x17D1A0
	public bool _supportGUI; // 0x1B8
	[SerializeField] // RVA: 0x17D1B0 Offset: 0x17D2B1 VA: 0x17D1B0
	public bool _supportCameraRotation; // 0x1B9
	[SerializeField] // RVA: 0x17D1C0 Offset: 0x17D2C1 VA: 0x17D1C0
	[TooltipAttribute] // RVA: 0x17D1C0 Offset: 0x17D2C1 VA: 0x17D1C0
	public bool _render180Degrees; // 0x1BA
	[SerializeField] // RVA: 0x17D210 Offset: 0x17D311 VA: 0x17D210
	public StereoPacking _stereoRendering; // 0x1BC
	[SerializeField] // RVA: 0x17D220 Offset: 0x17D321 VA: 0x17D220
	[TooltipAttribute] // RVA: 0x17D220 Offset: 0x17D321 VA: 0x17D220
	public float _ipd; // 0x1C0
	[SerializeField] // RVA: 0x17D270 Offset: 0x17D371 VA: 0x17D270
	private Camera _camera; // 0x1C8
	private RenderTexture _faceTarget; // 0x1D0
	private Material _blitMaterial; // 0x1D8
	private Material _cubemapToEquirectangularMaterial; // 0x1E0
	private RenderTexture _cubeTarget; // 0x1E8
	private RenderTexture _finalTarget; // 0x1F0
	private IntPtr _targetNativePointer; // 0x1F8
	private int _propFlipX; // 0x200

	// Methods

	// RVA: 0x2318C00 Offset: 0x2318D01 VA: 0x2318C00
	public void .ctor() { }

	// RVA: 0x2318C90 Offset: 0x2318D91 VA: 0x2318C90
	private CaptureFromCamera360.CubemapRenderMethod GetCubemapRenderingMethod() { }

	// RVA: 0x2318CD0 Offset: 0x2318DD1 VA: 0x2318CD0
	public void SetCamera(Camera camera) { }

	// RVA: 0x2318CE0 Offset: 0x2318DE1 VA: 0x2318CE0 Slot: 13
	public override void UpdateFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC380 Offset: 0x1AC481 VA: 0x1AC380
	// RVA: 0x2318DA0 Offset: 0x2318EA1 VA: 0x2318DA0
	private IEnumerator FinalRenderCapture() { }

	// RVA: 0x2318E20 Offset: 0x2318F21 VA: 0x2318E20
	private void Capture() { }

	// RVA: 0x23195D0 Offset: 0x23196D1 VA: 0x23195D0
	private static void ClearCubemap(RenderTexture texture, Color color) { }

	// RVA: 0x23197B0 Offset: 0x23198B1 VA: 0x23197B0
	private void RenderCubemapToEquiRect(RenderTexture cubemap, RenderTexture target, bool supportRotation, Quaternion rotation, bool isEyeLeft) { }

	// RVA: 0x2319200 Offset: 0x2319301 VA: 0x2319200
	private void UpdateTexture() { }

	// RVA: 0x2319920 Offset: 0x2319A21 VA: 0x2319920
	private void RenderCameraToCubemap(Camera camera, RenderTexture cubemapTarget) { }

	// RVA: 0x2319110 Offset: 0x2319211 VA: 0x2319110
	private void AccumulateMotionBlur() { }

	// RVA: 0x231A0F0 Offset: 0x231A1F1 VA: 0x231A0F0 Slot: 9
	public override bool PrepareCapture() { }

	// RVA: 0x231AC90 Offset: 0x231AD91 VA: 0x231AC90 Slot: 12
	public override Texture GetPreviewTexture() { }

	// RVA: 0x231ACE0 Offset: 0x231ADE1 VA: 0x231ACE0 Slot: 5
	public override void Start() { }

	// RVA: 0x231AEB0 Offset: 0x231AFB1 VA: 0x231AEB0 Slot: 6
	public override void OnDestroy() { }
}

[AddComponentMenu] // RVA: 0x148EB0 Offset: 0x148FB1 VA: 0x148EB0
public class CaptureFromCamera360 : CaptureBase // TypeDefIndex: 9589
{
	// Fields
	[SerializeField] // RVA: 0x17D180 Offset: 0x17D281 VA: 0x17D180
	public int _cubemapResolution; // 0x1B0
	[SerializeField] // RVA: 0x17D190 Offset: 0x17D291 VA: 0x17D190
	public int _cubemapDepth; // 0x1B4
	[SerializeField] // RVA: 0x17D1A0 Offset: 0x17D2A1 VA: 0x17D1A0
	public bool _supportGUI; // 0x1B8
	[SerializeField] // RVA: 0x17D1B0 Offset: 0x17D2B1 VA: 0x17D1B0
	public bool _supportCameraRotation; // 0x1B9
	[SerializeField] // RVA: 0x17D1C0 Offset: 0x17D2C1 VA: 0x17D1C0
	[TooltipAttribute] // RVA: 0x17D1C0 Offset: 0x17D2C1 VA: 0x17D1C0
	public bool _render180Degrees; // 0x1BA
	[SerializeField] // RVA: 0x17D210 Offset: 0x17D311 VA: 0x17D210
	public StereoPacking _stereoRendering; // 0x1BC
	[SerializeField] // RVA: 0x17D220 Offset: 0x17D321 VA: 0x17D220
	[TooltipAttribute] // RVA: 0x17D220 Offset: 0x17D321 VA: 0x17D220
	public float _ipd; // 0x1C0
	[SerializeField] // RVA: 0x17D270 Offset: 0x17D371 VA: 0x17D270
	private Camera _camera; // 0x1C8
	private RenderTexture _faceTarget; // 0x1D0
	private Material _blitMaterial; // 0x1D8
	private Material _cubemapToEquirectangularMaterial; // 0x1E0
	private RenderTexture _cubeTarget; // 0x1E8
	private RenderTexture _finalTarget; // 0x1F0
	private IntPtr _targetNativePointer; // 0x1F8
	private int _propFlipX; // 0x200

	// Methods

	// RVA: 0x2318C00 Offset: 0x2318D01 VA: 0x2318C00
	public void .ctor() { }

	// RVA: 0x2318C90 Offset: 0x2318D91 VA: 0x2318C90
	private CaptureFromCamera360.CubemapRenderMethod GetCubemapRenderingMethod() { }

	// RVA: 0x2318CD0 Offset: 0x2318DD1 VA: 0x2318CD0
	public void SetCamera(Camera camera) { }

	// RVA: 0x2318CE0 Offset: 0x2318DE1 VA: 0x2318CE0 Slot: 13
	public override void UpdateFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC380 Offset: 0x1AC481 VA: 0x1AC380
	// RVA: 0x2318DA0 Offset: 0x2318EA1 VA: 0x2318DA0
	private IEnumerator FinalRenderCapture() { }

	// RVA: 0x2318E20 Offset: 0x2318F21 VA: 0x2318E20
	private void Capture() { }

	// RVA: 0x23195D0 Offset: 0x23196D1 VA: 0x23195D0
	private static void ClearCubemap(RenderTexture texture, Color color) { }

	// RVA: 0x23197B0 Offset: 0x23198B1 VA: 0x23197B0
	private void RenderCubemapToEquiRect(RenderTexture cubemap, RenderTexture target, bool supportRotation, Quaternion rotation, bool isEyeLeft) { }

	// RVA: 0x2319200 Offset: 0x2319301 VA: 0x2319200
	private void UpdateTexture() { }

	// RVA: 0x2319920 Offset: 0x2319A21 VA: 0x2319920
	private void RenderCameraToCubemap(Camera camera, RenderTexture cubemapTarget) { }

	// RVA: 0x2319110 Offset: 0x2319211 VA: 0x2319110
	private void AccumulateMotionBlur() { }

	// RVA: 0x231A0F0 Offset: 0x231A1F1 VA: 0x231A0F0 Slot: 9
	public override bool PrepareCapture() { }

	// RVA: 0x231AC90 Offset: 0x231AD91 VA: 0x231AC90 Slot: 12
	public override Texture GetPreviewTexture() { }

	// RVA: 0x231ACE0 Offset: 0x231ADE1 VA: 0x231ACE0 Slot: 5
	public override void Start() { }

	// RVA: 0x231AEB0 Offset: 0x231AFB1 VA: 0x231AEB0 Slot: 6
	public override void OnDestroy() { }
}

