[ExecuteInEditMode] // RVA: 0x143A60 Offset: 0x143B61 VA: 0x143A60
[RequireComponent] // RVA: 0x143A60 Offset: 0x143B61 VA: 0x143A60
[AddComponentMenu] // RVA: 0x143A60 Offset: 0x143B61 VA: 0x143A60
public class SunShafts : PostEffectsBase // TypeDefIndex: 6046
{
	// Fields
	public SunShafts.SunShaftsResolution resolution; // 0x28
	public SunShafts.ShaftsScreenBlendMode screenBlendMode; // 0x2C
	public Transform sunTransform; // 0x30
	public int radialBlurIterations; // 0x38
	public Color sunColor; // 0x3C
	public Color sunThreshold; // 0x4C
	public float sunShaftBlurRadius; // 0x5C
	public float sunShaftIntensity; // 0x60
	public float maxRadius; // 0x64
	public bool useDepthTexture; // 0x68
	public Shader sunShaftsShader; // 0x70
	private Material sunShaftsMaterial; // 0x78
	public Shader simpleClearShader; // 0x80
	private Material simpleClearMaterial; // 0x88

	// Methods

	// RVA: 0x1B70920 Offset: 0x1B70A21 VA: 0x1B70920 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1B709D0 Offset: 0x1B70AD1 VA: 0x1B709D0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1B711E0 Offset: 0x1B712E1 VA: 0x1B711E0
	public void .ctor() { }
}

