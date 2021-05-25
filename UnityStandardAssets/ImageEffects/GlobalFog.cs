[ExecuteInEditMode] // RVA: 0x143390 Offset: 0x143491 VA: 0x143390
[RequireComponent] // RVA: 0x143390 Offset: 0x143491 VA: 0x143390
[AddComponentMenu] // RVA: 0x143390 Offset: 0x143491 VA: 0x143390
internal class GlobalFog : PostEffectsBase // TypeDefIndex: 6030
{
	// Fields
	[TooltipAttribute] // RVA: 0x143FF0 Offset: 0x1440F1 VA: 0x143FF0
	public bool distanceFog; // 0x28
	[TooltipAttribute] // RVA: 0x144030 Offset: 0x144131 VA: 0x144030
	public bool excludeFarPixels; // 0x29
	[TooltipAttribute] // RVA: 0x144070 Offset: 0x144171 VA: 0x144070
	public bool useRadialDistance; // 0x2A
	[TooltipAttribute] // RVA: 0x1440B0 Offset: 0x1441B1 VA: 0x1440B0
	public bool heightFog; // 0x2B
	[TooltipAttribute] // RVA: 0x1440F0 Offset: 0x1441F1 VA: 0x1440F0
	public float height; // 0x2C
	[RangeAttribute] // RVA: 0x144130 Offset: 0x144231 VA: 0x144130
	public float heightDensity; // 0x30
	[TooltipAttribute] // RVA: 0x144150 Offset: 0x144251 VA: 0x144150
	public float startDistance; // 0x34
	public Shader fogShader; // 0x38
	private Material fogMaterial; // 0x40

	// Methods

	// RVA: 0x1A5AA10 Offset: 0x1A5AB11 VA: 0x1A5AA10 Slot: 4
	public override bool CheckResources() { }

	[ImageEffectOpaque] // RVA: 0x144A50 Offset: 0x144B51 VA: 0x144A50
	// RVA: 0x1A5AB10 Offset: 0x1A5AC11 VA: 0x1A5AB10
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A5B380 Offset: 0x1A5B481 VA: 0x1A5B380
	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr) { }

	// RVA: 0x1A5B500 Offset: 0x1A5B601 VA: 0x1A5B500
	public void .ctor() { }
}

