[ExecuteInEditMode] // RVA: 0x143250 Offset: 0x143351 VA: 0x143250
[RequireComponent] // RVA: 0x143250 Offset: 0x143351 VA: 0x143250
[AddComponentMenu] // RVA: 0x143250 Offset: 0x143351 VA: 0x143250
public class EdgeDetection : PostEffectsBase // TypeDefIndex: 6027
{
	// Fields
	public EdgeDetection.EdgeDetectMode mode; // 0x28
	public float sensitivityDepth; // 0x2C
	public float sensitivityNormals; // 0x30
	public float lumThreshold; // 0x34
	public float edgeExp; // 0x38
	public float sampleDist; // 0x3C
	public float edgesOnly; // 0x40
	public Color edgesOnlyBgColor; // 0x44
	public Shader edgeDetectShader; // 0x58
	private Material edgeDetectMaterial; // 0x60
	private EdgeDetection.EdgeDetectMode oldMode; // 0x68

	// Methods

	// RVA: 0x1A5A1A0 Offset: 0x1A5A2A1 VA: 0x1A5A1A0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A5A380 Offset: 0x1A5A481 VA: 0x1A5A380
	private void Start() { }

	// RVA: 0x1A5A2C0 Offset: 0x1A5A3C1 VA: 0x1A5A2C0
	private void SetCameraFlag() { }

	// RVA: 0x1A5A390 Offset: 0x1A5A491 VA: 0x1A5A390
	private void OnEnable() { }

	[ImageEffectOpaque] // RVA: 0x144A40 Offset: 0x144B41 VA: 0x144A40
	// RVA: 0x1A5A3A0 Offset: 0x1A5A4A1 VA: 0x1A5A3A0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A5A590 Offset: 0x1A5A691 VA: 0x1A5A590
	public void .ctor() { }
}

