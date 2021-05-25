[ExecuteInEditMode] // RVA: 0x1432F0 Offset: 0x1433F1 VA: 0x1432F0
[RequireComponent] // RVA: 0x1432F0 Offset: 0x1433F1 VA: 0x1432F0
[AddComponentMenu] // RVA: 0x1432F0 Offset: 0x1433F1 VA: 0x1432F0
public class Fisheye : PostEffectsBase // TypeDefIndex: 6029
{
	// Fields
	[RangeAttribute] // RVA: 0x143FB0 Offset: 0x1440B1 VA: 0x143FB0
	public float strengthX; // 0x28
	[RangeAttribute] // RVA: 0x143FD0 Offset: 0x1440D1 VA: 0x143FD0
	public float strengthY; // 0x2C
	public Shader fishEyeShader; // 0x30
	private Material fisheyeMaterial; // 0x38

	// Methods

	// RVA: 0x1A5A670 Offset: 0x1A5A771 VA: 0x1A5A670 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A5A800 Offset: 0x1A5A901 VA: 0x1A5A800
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A5A970 Offset: 0x1A5AA71 VA: 0x1A5A970
	public void .ctor() { }
}

