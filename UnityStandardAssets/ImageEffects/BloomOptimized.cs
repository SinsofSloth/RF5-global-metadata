[ExecuteInEditMode] // RVA: 0x142C60 Offset: 0x142D61 VA: 0x142C60
[RequireComponent] // RVA: 0x142C60 Offset: 0x142D61 VA: 0x142C60
[AddComponentMenu] // RVA: 0x142C60 Offset: 0x142D61 VA: 0x142C60
public class BloomOptimized : PostEffectsBase // TypeDefIndex: 6004
{
	// Fields
	[RangeAttribute] // RVA: 0x143DD0 Offset: 0x143ED1 VA: 0x143DD0
	public float threshold; // 0x28
	[RangeAttribute] // RVA: 0x143DF0 Offset: 0x143EF1 VA: 0x143DF0
	public float intensity; // 0x2C
	[RangeAttribute] // RVA: 0x143E10 Offset: 0x143F11 VA: 0x143E10
	public float blurSize; // 0x30
	private BloomOptimized.Resolution resolution; // 0x34
	[RangeAttribute] // RVA: 0x143E30 Offset: 0x143F31 VA: 0x143E30
	public int blurIterations; // 0x38
	public BloomOptimized.BlurType blurType; // 0x3C
	public Shader fastBloomShader; // 0x40
	private Material fastBloomMaterial; // 0x48

	// Methods

	// RVA: 0x1A4DAC0 Offset: 0x1A4DBC1 VA: 0x1A4DAC0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A4DC50 Offset: 0x1A4DD51 VA: 0x1A4DC50
	private void OnDisable() { }

	// RVA: 0x1A4DD10 Offset: 0x1A4DE11 VA: 0x1A4DD10
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A4E0E0 Offset: 0x1A4E1E1 VA: 0x1A4E0E0
	public void .ctor() { }
}

