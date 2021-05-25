[ExecuteInEditMode] // RVA: 0x142DF0 Offset: 0x142EF1 VA: 0x142DF0
[RequireComponent] // RVA: 0x142DF0 Offset: 0x142EF1 VA: 0x142DF0
[AddComponentMenu] // RVA: 0x142DF0 Offset: 0x142EF1 VA: 0x142DF0
public class CameraMotionBlur : PostEffectsBase // TypeDefIndex: 6010
{
	// Fields
	private static float MAX_RADIUS; // 0x0
	public CameraMotionBlur.MotionBlurFilter filterType; // 0x28
	public bool preview; // 0x2C
	public Vector3 previewScale; // 0x30
	public float movementScale; // 0x3C
	public float rotationScale; // 0x40
	public float maxVelocity; // 0x44
	public float minVelocity; // 0x48
	public float velocityScale; // 0x4C
	public float softZDistance; // 0x50
	public int velocityDownsample; // 0x54
	public LayerMask excludeLayers; // 0x58
	private GameObject tmpCam; // 0x60
	public Shader shader; // 0x68
	public Shader dx11MotionBlurShader; // 0x70
	public Shader replacementClear; // 0x78
	private Material motionBlurMaterial; // 0x80
	private Material dx11MotionBlurMaterial; // 0x88
	public Texture2D noiseTexture; // 0x90
	public float jitter; // 0x98
	public bool showVelocity; // 0x9C
	public float showVelocityScale; // 0xA0
	private Matrix4x4 currentViewProjMat; // 0xA4
	private Matrix4x4[] currentStereoViewProjMat; // 0xE8
	private Matrix4x4 prevViewProjMat; // 0xF0
	private Matrix4x4[] prevStereoViewProjMat; // 0x130
	private int prevFrameCount; // 0x138
	private bool wasActive; // 0x13C
	private Vector3 prevFrameForward; // 0x140
	private Vector3 prevFrameUp; // 0x14C
	private Vector3 prevFramePos; // 0x158
	private Camera _camera; // 0x168

	// Methods

	// RVA: 0x1A4F010 Offset: 0x1A4F111 VA: 0x1A4F010
	private void CalculateViewProjection() { }

	// RVA: 0x1A4F600 Offset: 0x1A4F701 VA: 0x1A4F600
	private void Start() { }

	// RVA: 0x1A4F910 Offset: 0x1A4FA11 VA: 0x1A4F910
	private void OnEnable() { }

	// RVA: 0x1A4F9E0 Offset: 0x1A4FAE1 VA: 0x1A4F9E0
	private void OnDisable() { }

	// RVA: 0x1A4FB80 Offset: 0x1A4FC81 VA: 0x1A4FB80 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A4FD40 Offset: 0x1A4FE41 VA: 0x1A4FD40
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A4F730 Offset: 0x1A4F831 VA: 0x1A4F730
	private void Remember() { }

	// RVA: 0x1A51C20 Offset: 0x1A51D21 VA: 0x1A51C20
	private Camera GetTmpCam() { }

	// RVA: 0x1A51B30 Offset: 0x1A51C31 VA: 0x1A51B30
	private void StartFrame() { }

	// RVA: 0x1A51C10 Offset: 0x1A51D11 VA: 0x1A51C10
	private static int divRoundUp(int x, int d) { }

	// RVA: 0x1A51F70 Offset: 0x1A52071 VA: 0x1A51F70
	public void .ctor() { }

	// RVA: 0x1A520E0 Offset: 0x1A521E1 VA: 0x1A520E0
	private static void .cctor() { }
}

