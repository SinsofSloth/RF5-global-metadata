[ExecuteInEditMode] // RVA: 0x143B90 Offset: 0x143C91 VA: 0x143B90
[RequireComponent] // RVA: 0x143B90 Offset: 0x143C91 VA: 0x143B90
[AddComponentMenu] // RVA: 0x143B90 Offset: 0x143C91 VA: 0x143B90
public class Tonemapping : PostEffectsBase // TypeDefIndex: 6052
{
	// Fields
	public Tonemapping.TonemapperType type; // 0x28
	public Tonemapping.AdaptiveTexSize adaptiveTextureSize; // 0x2C
	public AnimationCurve remapCurve; // 0x30
	private Texture2D curveTex; // 0x38
	public float exposureAdjustment; // 0x40
	public float middleGrey; // 0x44
	public float white; // 0x48
	public float adaptionSpeed; // 0x4C
	public Shader tonemapper; // 0x50
	public bool validRenderTextureFormat; // 0x58
	private Material tonemapMaterial; // 0x60
	private RenderTexture rt; // 0x68
	private RenderTextureFormat rtFormat; // 0x70

	// Methods

	// RVA: 0x1B715C0 Offset: 0x1B716C1 VA: 0x1B715C0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1B71760 Offset: 0x1B71861 VA: 0x1B71760
	public float UpdateCurve() { }

	// RVA: 0x1B71A60 Offset: 0x1B71B61 VA: 0x1B71A60
	private void OnDisable() { }

	// RVA: 0x1B71C30 Offset: 0x1B71D31 VA: 0x1B71C30
	private bool CreateInternalRenderTexture() { }

	[ImageEffectTransformsToLDR] // RVA: 0x144B00 Offset: 0x144C01 VA: 0x144B00
	// RVA: 0x1B71D50 Offset: 0x1B71E51 VA: 0x1B71D50
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1B72610 Offset: 0x1B72711 VA: 0x1B72610
	public void .ctor() { }
}

