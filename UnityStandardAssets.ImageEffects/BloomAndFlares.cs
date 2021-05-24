[ExecuteInEditMode] // RVA: 0x142BC0 Offset: 0x142CC1 VA: 0x142BC0
[RequireComponent] // RVA: 0x142BC0 Offset: 0x142CC1 VA: 0x142BC0
[AddComponentMenu] // RVA: 0x142BC0 Offset: 0x142CC1 VA: 0x142BC0
public class BloomAndFlares : PostEffectsBase // TypeDefIndex: 6003
{
	// Fields
	public TweakMode34 tweakMode; // 0x28
	public BloomScreenBlendMode screenBlendMode; // 0x2C
	public HDRBloomMode hdr; // 0x30
	private bool doHdr; // 0x34
	public float sepBlurSpread; // 0x38
	public float useSrcAlphaAsMask; // 0x3C
	public float bloomIntensity; // 0x40
	public float bloomThreshold; // 0x44
	public int bloomBlurIterations; // 0x48
	public bool lensflares; // 0x4C
	public int hollywoodFlareBlurIterations; // 0x50
	public LensflareStyle34 lensflareMode; // 0x54
	public float hollyStretchWidth; // 0x58
	public float lensflareIntensity; // 0x5C
	public float lensflareThreshold; // 0x60
	public Color flareColorA; // 0x64
	public Color flareColorB; // 0x74
	public Color flareColorC; // 0x84
	public Color flareColorD; // 0x94
	public Texture2D lensFlareVignetteMask; // 0xA8
	public Shader lensFlareShader; // 0xB0
	private Material lensFlareMaterial; // 0xB8
	public Shader vignetteShader; // 0xC0
	private Material vignetteMaterial; // 0xC8
	public Shader separableBlurShader; // 0xD0
	private Material separableBlurMaterial; // 0xD8
	public Shader addBrightStuffOneOneShader; // 0xE0
	private Material addBrightStuffBlendOneOneMaterial; // 0xE8
	public Shader screenBlendShader; // 0xF0
	private Material screenBlend; // 0xF8
	public Shader hollywoodFlaresShader; // 0x100
	private Material hollywoodFlaresMaterial; // 0x108
	public Shader brightPassFilterShader; // 0x110
	private Material brightPassFilterMaterial; // 0x118

	// Methods

	// RVA: 0x1A4C510 Offset: 0x1A4C611 VA: 0x1A4C510 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A4C770 Offset: 0x1A4C871 VA: 0x1A4C770
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A4D840 Offset: 0x1A4D941 VA: 0x1A4D840
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to) { }

	// RVA: 0x1A4D650 Offset: 0x1A4D751 VA: 0x1A4D650
	private void BlendFlares(RenderTexture from, RenderTexture to) { }

	// RVA: 0x1A4D3B0 Offset: 0x1A4D4B1 VA: 0x1A4D3B0
	private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to) { }

	// RVA: 0x1A4D4E0 Offset: 0x1A4D5E1 VA: 0x1A4D4E0
	private void Vignette(float amount, RenderTexture from, RenderTexture to) { }

	// RVA: 0x1A4D900 Offset: 0x1A4DA01 VA: 0x1A4D900
	public void .ctor() { }
}

