[ExecuteInEditMode] // RVA: 0x1431B0 Offset: 0x1432B1 VA: 0x1431B0
[RequireComponent] // RVA: 0x1431B0 Offset: 0x1432B1 VA: 0x1431B0
[AddComponentMenu] // RVA: 0x1431B0 Offset: 0x1432B1 VA: 0x1431B0
public class DepthOfFieldDeprecated : PostEffectsBase // TypeDefIndex: 6022
{
	// Fields
	private static int SMOOTH_DOWNSAMPLE_PASS; // 0x0
	private static float BOKEH_EXTRA_BLUR; // 0x4
	public DepthOfFieldDeprecated.Dof34QualitySetting quality; // 0x28
	public DepthOfFieldDeprecated.DofResolution resolution; // 0x2C
	public bool simpleTweakMode; // 0x30
	public float focalPoint; // 0x34
	public float smoothness; // 0x38
	public float focalZDistance; // 0x3C
	public float focalZStartCurve; // 0x40
	public float focalZEndCurve; // 0x44
	private float focalStartCurve; // 0x48
	private float focalEndCurve; // 0x4C
	private float focalDistance01; // 0x50
	public Transform objectFocus; // 0x58
	public float focalSize; // 0x60
	public DepthOfFieldDeprecated.DofBlurriness bluriness; // 0x64
	public float maxBlurSpread; // 0x68
	public float foregroundBlurExtrude; // 0x6C
	public Shader dofBlurShader; // 0x70
	private Material dofBlurMaterial; // 0x78
	public Shader dofShader; // 0x80
	private Material dofMaterial; // 0x88
	public bool visualize; // 0x90
	public DepthOfFieldDeprecated.BokehDestination bokehDestination; // 0x94
	private float widthOverHeight; // 0x98
	private float oneOverBaseSize; // 0x9C
	public bool bokeh; // 0xA0
	public bool bokehSupport; // 0xA1
	public Shader bokehShader; // 0xA8
	public Texture2D bokehTexture; // 0xB0
	public float bokehScale; // 0xB8
	public float bokehIntensity; // 0xBC
	public float bokehThresholdContrast; // 0xC0
	public float bokehThresholdLuminance; // 0xC4
	public int bokehDownsample; // 0xC8
	private Material bokehMaterial; // 0xD0
	private Camera _camera; // 0xD8
	private RenderTexture foregroundTexture; // 0xE0
	private RenderTexture mediumRezWorkTexture; // 0xE8
	private RenderTexture finalDefocus; // 0xF0
	private RenderTexture lowRezWorkTexture; // 0xF8
	private RenderTexture bokehSource; // 0x100
	private RenderTexture bokehSource2; // 0x108

	// Methods

	// RVA: 0x1A57DA0 Offset: 0x1A57EA1 VA: 0x1A57DA0
	private void CreateMaterials() { }

	// RVA: 0x1A57EC0 Offset: 0x1A57FC1 VA: 0x1A57EC0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A58080 Offset: 0x1A58181 VA: 0x1A58080
	private void OnDisable() { }

	// RVA: 0x1A580F0 Offset: 0x1A581F1 VA: 0x1A580F0
	private void OnEnable() { }

	// RVA: 0x1A58180 Offset: 0x1A58281 VA: 0x1A58180
	private float FocalDistance01(float worldDist) { }

	// RVA: 0x1A582E0 Offset: 0x1A583E1 VA: 0x1A582E0
	private int GetDividerBasedOnQuality() { }

	// RVA: 0x1A58310 Offset: 0x1A58411 VA: 0x1A58310
	private int GetLowResolutionDividerBasedOnQuality(int baseDivider) { }

	// RVA: 0x1A58340 Offset: 0x1A58441 VA: 0x1A58340
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A59210 Offset: 0x1A59311 VA: 0x1A59210
	private void Blur(RenderTexture from, RenderTexture to, DepthOfFieldDeprecated.DofBlurriness iterations, int blurPass, float spread) { }

	// RVA: 0x1A59900 Offset: 0x1A59A01 VA: 0x1A59900
	private void BlurFg(RenderTexture from, RenderTexture to, DepthOfFieldDeprecated.DofBlurriness iterations, int blurPass, float spread) { }

	// RVA: 0x1A59DE0 Offset: 0x1A59EE1 VA: 0x1A59DE0
	private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp) { }

	// RVA: 0x1A590C0 Offset: 0x1A591C1 VA: 0x1A590C0
	private void Downsample(RenderTexture from, RenderTexture to) { }

	// RVA: 0x1A594B0 Offset: 0x1A595B1 VA: 0x1A594B0
	private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget) { }

	// RVA: 0x1A59BC0 Offset: 0x1A59CC1 VA: 0x1A59BC0
	private void ReleaseTextures() { }

	// RVA: 0x1A58CD0 Offset: 0x1A58DD1 VA: 0x1A58CD0
	private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider) { }

	// RVA: 0x1A5A010 Offset: 0x1A5A111 VA: 0x1A5A010
	public void .ctor() { }

	// RVA: 0x1A5A130 Offset: 0x1A5A231 VA: 0x1A5A130
	private static void .cctor() { }
}

