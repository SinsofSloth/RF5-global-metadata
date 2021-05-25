[ExecuteInEditMode] // RVA: 0x142D50 Offset: 0x142E51 VA: 0x142D50
[RequireComponent] // RVA: 0x142D50 Offset: 0x142E51 VA: 0x142D50
[AddComponentMenu] // RVA: 0x142D50 Offset: 0x142E51 VA: 0x142D50
public class BlurOptimized : PostEffectsBase // TypeDefIndex: 6008
{
	// Fields
	[RangeAttribute] // RVA: 0x143E90 Offset: 0x143F91 VA: 0x143E90
	public int downsample; // 0x28
	[RangeAttribute] // RVA: 0x143EB0 Offset: 0x143FB1 VA: 0x143EB0
	public float blurSize; // 0x2C
	[RangeAttribute] // RVA: 0x143ED0 Offset: 0x143FD1 VA: 0x143ED0
	public int blurIterations; // 0x30
	public BlurOptimized.BlurType blurType; // 0x34
	public Shader blurShader; // 0x38
	private Material blurMaterial; // 0x40

	// Methods

	// RVA: 0x1A4E970 Offset: 0x1A4EA71 VA: 0x1A4E970 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A4EB00 Offset: 0x1A4EC01 VA: 0x1A4EB00
	public void OnDisable() { }

	// RVA: 0x1A4EBC0 Offset: 0x1A4ECC1 VA: 0x1A4EBC0
	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A4EF70 Offset: 0x1A4F071 VA: 0x1A4EF70
	public void .ctor() { }
}

