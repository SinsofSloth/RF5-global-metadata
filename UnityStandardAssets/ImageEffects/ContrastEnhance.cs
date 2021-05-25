[ExecuteInEditMode] // RVA: 0x142F80 Offset: 0x143081 VA: 0x142F80
[RequireComponent] // RVA: 0x142F80 Offset: 0x143081 VA: 0x142F80
[AddComponentMenu] // RVA: 0x142F80 Offset: 0x143081 VA: 0x142F80
public class ContrastEnhance : PostEffectsBase // TypeDefIndex: 6016
{
	// Fields
	[RangeAttribute] // RVA: 0x143EF0 Offset: 0x143FF1 VA: 0x143EF0
	public float intensity; // 0x28
	[RangeAttribute] // RVA: 0x143F10 Offset: 0x144011 VA: 0x143F10
	public float threshold; // 0x2C
	private Material separableBlurMaterial; // 0x30
	private Material contrastCompositeMaterial; // 0x38
	[RangeAttribute] // RVA: 0x143F30 Offset: 0x144031 VA: 0x143F30
	public float blurSpread; // 0x40
	public Shader separableBlurShader; // 0x48
	public Shader contrastCompositeShader; // 0x50

	// Methods

	// RVA: 0x1A54300 Offset: 0x1A54401 VA: 0x1A54300 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A544B0 Offset: 0x1A545B1 VA: 0x1A544B0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A54820 Offset: 0x1A54921 VA: 0x1A54820
	public void .ctor() { }
}

