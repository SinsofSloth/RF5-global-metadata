[ExecuteInEditMode] // RVA: 0x142E90 Offset: 0x142F91 VA: 0x142E90
[AddComponentMenu] // RVA: 0x142E90 Offset: 0x142F91 VA: 0x142E90
public class ColorCorrectionCurves : PostEffectsBase // TypeDefIndex: 6012
{
	// Fields
	public AnimationCurve redChannel; // 0x28
	public AnimationCurve greenChannel; // 0x30
	public AnimationCurve blueChannel; // 0x38
	public bool useDepthCorrection; // 0x40
	public AnimationCurve zCurve; // 0x48
	public AnimationCurve depthRedChannel; // 0x50
	public AnimationCurve depthGreenChannel; // 0x58
	public AnimationCurve depthBlueChannel; // 0x60
	private Material ccMaterial; // 0x68
	private Material ccDepthMaterial; // 0x70
	private Material selectiveCcMaterial; // 0x78
	private Texture2D rgbChannelTex; // 0x80
	private Texture2D rgbDepthChannelTex; // 0x88
	private Texture2D zCurveTex; // 0x90
	public float saturation; // 0x98
	public bool selectiveCc; // 0x9C
	public Color selectiveFromColor; // 0xA0
	public Color selectiveToColor; // 0xB0
	public ColorCorrectionCurves.ColorCorrectionMode mode; // 0xC0
	public bool updateTextures; // 0xC4
	public Shader colorCorrectionCurvesShader; // 0xC8
	public Shader simpleColorCorrectionCurvesShader; // 0xD0
	public Shader colorCorrectionSelectiveShader; // 0xD8
	private bool updateTexturesOnStartup; // 0xE0

	// Methods

	// RVA: 0x1A52140 Offset: 0x1A52241 VA: 0x1A52140
	private void Start() { }

	// RVA: 0x1A52180 Offset: 0x1A52281 VA: 0x1A52180
	private void Awake() { }

	// RVA: 0x1A52190 Offset: 0x1A52291 VA: 0x1A52190 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A52520 Offset: 0x1A52621 VA: 0x1A52520
	public void UpdateParameters() { }

	// RVA: 0x1A52920 Offset: 0x1A52A21 VA: 0x1A52920
	private void UpdateTextures() { }

	// RVA: 0x1A52930 Offset: 0x1A52A31 VA: 0x1A52930
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A52C40 Offset: 0x1A52D41 VA: 0x1A52C40
	public void .ctor() { }
}

