[ExecuteInEditMode] // RVA: 0x142A80 Offset: 0x142B81 VA: 0x142A80
[RequireComponent] // RVA: 0x142A80 Offset: 0x142B81 VA: 0x142A80
[AddComponentMenu] // RVA: 0x142A80 Offset: 0x142B81 VA: 0x142A80
public class Antialiasing : PostEffectsBase // TypeDefIndex: 5992
{
	// Fields
	public AAMode mode; // 0x28
	public bool showGeneratedNormals; // 0x2C
	public float offsetScale; // 0x30
	public float blurRadius; // 0x34
	public float edgeThresholdMin; // 0x38
	public float edgeThreshold; // 0x3C
	public float edgeSharpness; // 0x40
	public bool dlaaSharp; // 0x44
	public Shader ssaaShader; // 0x48
	private Material ssaa; // 0x50
	public Shader dlaaShader; // 0x58
	private Material dlaa; // 0x60
	public Shader nfaaShader; // 0x68
	private Material nfaa; // 0x70
	public Shader shaderFXAAPreset2; // 0x78
	private Material materialFXAAPreset2; // 0x80
	public Shader shaderFXAAPreset3; // 0x88
	private Material materialFXAAPreset3; // 0x90
	public Shader shaderFXAAII; // 0x98
	private Material materialFXAAII; // 0xA0
	public Shader shaderFXAAIII; // 0xA8
	private Material materialFXAAIII; // 0xB0

	// Methods

	// RVA: 0x1A49AE0 Offset: 0x1A49BE1 VA: 0x1A49AE0
	public Material CurrentAAMaterial() { }

	// RVA: 0x1A49B60 Offset: 0x1A49C61 VA: 0x1A49B60 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A4A1C0 Offset: 0x1A4A2C1 VA: 0x1A4A1C0
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A4A740 Offset: 0x1A4A841 VA: 0x1A4A740
	public void .ctor() { }
}

