[ExecuteInEditMode] // RVA: 0x143110 Offset: 0x143211 VA: 0x143110
[RequireComponent] // RVA: 0x143110 Offset: 0x143211 VA: 0x143110
[AddComponentMenu] // RVA: 0x143110 Offset: 0x143211 VA: 0x143110
public class DepthOfField : PostEffectsBase // TypeDefIndex: 6019
{
	// Fields
	public bool visualizeFocus; // 0x28
	public float focalLength; // 0x2C
	public float focalSize; // 0x30
	public float aperture; // 0x34
	public Transform focalTransform; // 0x38
	public float maxBlurSize; // 0x40
	public bool highResolution; // 0x44
	public DepthOfField.BlurType blurType; // 0x48
	public DepthOfField.BlurSampleCount blurSampleCount; // 0x4C
	public bool nearBlur; // 0x50
	public float foregroundOverlap; // 0x54
	public Shader dofHdrShader; // 0x58
	private Material dofHdrMaterial; // 0x60
	public Shader dx11BokehShader; // 0x68
	private Material dx11bokehMaterial; // 0x70
	public float dx11BokehThreshold; // 0x78
	public float dx11SpawnHeuristic; // 0x7C
	public Texture2D dx11BokehTexture; // 0x80
	public float dx11BokehScale; // 0x88
	public float dx11BokehIntensity; // 0x8C
	private float focalDistance01; // 0x90
	private ComputeBuffer cbDrawArgs; // 0x98
	private ComputeBuffer cbPoints; // 0xA0
	private float internalBlurWidth; // 0xA8
	private Camera cachedCamera; // 0xB0

	// Methods

	// RVA: 0x1A55C70 Offset: 0x1A55D71 VA: 0x1A55C70 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A55F10 Offset: 0x1A56011 VA: 0x1A55F10
	private void OnEnable() { }

	// RVA: 0x1A55FA0 Offset: 0x1A560A1 VA: 0x1A55FA0
	private void OnDisable() { }

	// RVA: 0x1A56130 Offset: 0x1A56231 VA: 0x1A56130
	private void ReleaseComputeResources() { }

	// RVA: 0x1A55DB0 Offset: 0x1A55EB1 VA: 0x1A55DB0
	private void CreateComputeResources() { }

	// RVA: 0x1A56190 Offset: 0x1A56291 VA: 0x1A56190
	private float FocalDistance01(float worldDist) { }

	// RVA: 0x1A562F0 Offset: 0x1A563F1 VA: 0x1A562F0
	private void WriteCoc(RenderTexture fromTo, bool fgDilate) { }

	// RVA: 0x1A56610 Offset: 0x1A56711 VA: 0x1A56610
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A57CB0 Offset: 0x1A57DB1 VA: 0x1A57CB0
	public void .ctor() { }
}

