[ExecuteInEditMode] // RVA: 0x142B20 Offset: 0x142C21 VA: 0x142B20
[RequireComponent] // RVA: 0x142B20 Offset: 0x142C21 VA: 0x142B20
[AddComponentMenu] // RVA: 0x142B20 Offset: 0x142C21 VA: 0x142B20
public class Bloom : PostEffectsBase // TypeDefIndex: 5993
{
	// Fields
	public Bloom.TweakMode tweakMode; // 0x28
	public Bloom.BloomScreenBlendMode screenBlendMode; // 0x2C
	public Bloom.HDRBloomMode hdr; // 0x30
	private bool doHdr; // 0x34
	public float sepBlurSpread; // 0x38
	public Bloom.BloomQuality quality; // 0x3C
	public float bloomIntensity; // 0x40
	public float bloomThreshold; // 0x44
	public Color bloomThresholdColor; // 0x48
	public int bloomBlurIterations; // 0x58
	public int hollywoodFlareBlurIterations; // 0x5C
	public float flareRotation; // 0x60
	public Bloom.LensFlareStyle lensflareMode; // 0x64
	public float hollyStretchWidth; // 0x68
	public float lensflareIntensity; // 0x6C
	public float lensflareThreshold; // 0x70
	public float lensFlareSaturation; // 0x74
	public Color flareColorA; // 0x78
	public Color flareColorB; // 0x88
	public Color flareColorC; // 0x98
	public Color flareColorD; // 0xA8
	public Texture2D lensFlareVignetteMask; // 0xB8
	public Shader lensFlareShader; // 0xC0
	private Material lensFlareMaterial; // 0xC8
	public Shader screenBlendShader; // 0xD0
	private Material screenBlend; // 0xD8
	public Shader blurAndFlaresShader; // 0xE0
	private Material blurAndFlaresMaterial; // 0xE8
	public Shader brightPassFilterShader; // 0xF0
	private Material brightPassFilterMaterial; // 0xF8

	// Methods

	// RVA: 0x1A4A890 Offset: 0x1A4A991 VA: 0x1A4A890 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A4AE80 Offset: 0x1A4AF81 VA: 0x1A4AE80
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A4C270 Offset: 0x1A4C371 VA: 0x1A4C270
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to) { }

	// RVA: 0x1A4C070 Offset: 0x1A4C171 VA: 0x1A4C070
	private void BlendFlares(RenderTexture from, RenderTexture to) { }

	// RVA: 0x1A4BD60 Offset: 0x1A4BE61 VA: 0x1A4BD60
	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to) { }

	// RVA: 0x1A4BC70 Offset: 0x1A4BD71 VA: 0x1A4BC70
	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to) { }

	// RVA: 0x1A4BE50 Offset: 0x1A4BF51 VA: 0x1A4BE50
	private void Vignette(float amount, RenderTexture from, RenderTexture to) { }

	// RVA: 0x1A4C340 Offset: 0x1A4C441 VA: 0x1A4C340
	public void .ctor() { }
}

