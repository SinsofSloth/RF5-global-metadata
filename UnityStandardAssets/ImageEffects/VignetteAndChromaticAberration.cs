[ExecuteInEditMode] // RVA: 0x143C80 Offset: 0x143D81 VA: 0x143C80
[RequireComponent] // RVA: 0x143C80 Offset: 0x143D81 VA: 0x143C80
[AddComponentMenu] // RVA: 0x143C80 Offset: 0x143D81 VA: 0x143C80
public class VignetteAndChromaticAberration : PostEffectsBase // TypeDefIndex: 6057
{
	// Fields
	public VignetteAndChromaticAberration.AberrationMode mode; // 0x28
	public float intensity; // 0x2C
	public float chromaticAberration; // 0x30
	public float axialAberration; // 0x34
	public float blur; // 0x38
	public float blurSpread; // 0x3C
	public float luminanceDependency; // 0x40
	public float blurDistance; // 0x44
	public Shader vignetteShader; // 0x48
	public Shader separableBlurShader; // 0x50
	public Shader chromAberrationShader; // 0x58
	private Material m_VignetteMaterial; // 0x60
	private Material m_SeparableBlurMaterial; // 0x68
	private Material m_ChromAberrationMaterial; // 0x70

	// Methods

	// RVA: 0x1B731B0 Offset: 0x1B732B1 VA: 0x1B731B0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1B73280 Offset: 0x1B73381 VA: 0x1B73280
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1B739E0 Offset: 0x1B73AE1 VA: 0x1B739E0
	public void .ctor() { }
}

