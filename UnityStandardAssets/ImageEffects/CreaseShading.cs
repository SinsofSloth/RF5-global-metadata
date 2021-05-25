[ExecuteInEditMode] // RVA: 0x143070 Offset: 0x143171 VA: 0x143070
[RequireComponent] // RVA: 0x143070 Offset: 0x143171 VA: 0x143070
[AddComponentMenu] // RVA: 0x143070 Offset: 0x143171 VA: 0x143070
public class CreaseShading : PostEffectsBase // TypeDefIndex: 6018
{
	// Fields
	public float intensity; // 0x28
	public int softness; // 0x2C
	public float spread; // 0x30
	public Shader blurShader; // 0x38
	private Material blurMaterial; // 0x40
	public Shader depthFetchShader; // 0x48
	private Material depthFetchMaterial; // 0x50
	public Shader creaseApplyShader; // 0x58
	private Material creaseApplyMaterial; // 0x60

	// Methods

	// RVA: 0x1A556D0 Offset: 0x1A557D1 VA: 0x1A556D0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A55810 Offset: 0x1A55911 VA: 0x1A55810
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A55BD0 Offset: 0x1A55CD1 VA: 0x1A55BD0
	public void .ctor() { }
}

