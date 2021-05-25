[AddComponentMenu] // RVA: 0x148FF0 Offset: 0x1490F1 VA: 0x148FF0
public class MotionBlur : MonoBehaviour // TypeDefIndex: 9600
{
	// Fields
	[SerializeField] // RVA: 0x17D2E0 Offset: 0x17D3E1 VA: 0x17D2E0
	public RenderTextureFormat _format; // 0x18
	[SerializeField] // RVA: 0x17D2F0 Offset: 0x17D3F1 VA: 0x17D2F0
	private int _numSamples; // 0x1C
	private RenderTexture _accum; // 0x20
	private RenderTexture _lastComp; // 0x28
	private Material _addMaterial; // 0x30
	private Material _divMaterial; // 0x38
	private int _frameCount; // 0x40
	private int _targetWidth; // 0x44
	private int _targetHeight; // 0x48
	private bool _isDirty; // 0x4C
	private static int _propNumSamples; // 0x0
	private static int _propWeight; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x17D300 Offset: 0x17D401 VA: 0x17D300
	private bool <IsFrameAccumulated>k__BackingField; // 0x4D
	[SerializeField] // RVA: 0x17D310 Offset: 0x17D411 VA: 0x17D310
	public float _bias; // 0x50
	private float _total; // 0x54

	// Properties
	public bool IsFrameAccumulated { get; set; }
	public int NumSamples { get; set; }
	public int FrameCount { get; }
	public RenderTexture FinalTexture { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AC540 Offset: 0x1AC641 VA: 0x1AC540
	// RVA: 0x2326B30 Offset: 0x2326C31 VA: 0x2326B30
	public bool get_IsFrameAccumulated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AC550 Offset: 0x1AC651 VA: 0x1AC550
	// RVA: 0x2326B40 Offset: 0x2326C41 VA: 0x2326B40
	private void set_IsFrameAccumulated(bool value) { }

	// RVA: 0x2326B50 Offset: 0x2326C51 VA: 0x2326B50
	public int get_NumSamples() { }

	// RVA: 0x2326B60 Offset: 0x2326C61 VA: 0x2326B60
	public void set_NumSamples(int value) { }

	// RVA: 0x2326C40 Offset: 0x2326D41 VA: 0x2326C40
	public int get_FrameCount() { }

	// RVA: 0x2326C50 Offset: 0x2326D51 VA: 0x2326C50
	public RenderTexture get_FinalTexture() { }

	// RVA: 0x2326C60 Offset: 0x2326D61 VA: 0x2326C60
	private void Awake() { }

	// RVA: 0x2326D00 Offset: 0x2326E01 VA: 0x2326D00
	public void SetTargetSize(int width, int height) { }

	// RVA: 0x2326D30 Offset: 0x2326E31 VA: 0x2326D30
	private void Start() { }

	// RVA: 0x2327060 Offset: 0x2327161 VA: 0x2327060
	private void OnEnable() { }

	// RVA: 0x2326D40 Offset: 0x2326E41 VA: 0x2326D40
	private void Setup() { }

	// RVA: 0x23270C0 Offset: 0x23271C1 VA: 0x23270C0
	private void ClearAccumulation() { }

	// RVA: 0x2327120 Offset: 0x2327221 VA: 0x2327120
	private void OnDestroy() { }

	// RVA: 0x2326B70 Offset: 0x2326C71 VA: 0x2326B70
	public void OnNumSamplesChanged() { }

	// RVA: 0x2327350 Offset: 0x2327451 VA: 0x2327350
	private static float LerpUnclamped(float a, float b, float t) { }

	// RVA: 0x2327360 Offset: 0x2327461 VA: 0x2327360
	private void ApplyWeighting() { }

	// RVA: 0x2319FB0 Offset: 0x231A0B1 VA: 0x2319FB0
	public void Accumulate(Texture src) { }

	// RVA: 0x2327460 Offset: 0x2327561 VA: 0x2327460
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	// RVA: 0x23274F0 Offset: 0x23275F1 VA: 0x23274F0
	public void .ctor() { }
}

