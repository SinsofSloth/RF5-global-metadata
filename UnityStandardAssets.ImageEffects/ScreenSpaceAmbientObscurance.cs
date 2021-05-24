[ExecuteInEditMode] // RVA: 0x1438D0 Offset: 0x1439D1 VA: 0x1438D0
[RequireComponent] // RVA: 0x1438D0 Offset: 0x1439D1 VA: 0x1438D0
[AddComponentMenu] // RVA: 0x1438D0 Offset: 0x1439D1 VA: 0x1438D0
internal class ScreenSpaceAmbientObscurance : PostEffectsBase // TypeDefIndex: 6042
{
	// Fields
	[RangeAttribute] // RVA: 0x1442B0 Offset: 0x1443B1 VA: 0x1442B0
	public float intensity; // 0x28
	[RangeAttribute] // RVA: 0x1442D0 Offset: 0x1443D1 VA: 0x1442D0
	public float radius; // 0x2C
	[RangeAttribute] // RVA: 0x1442F0 Offset: 0x1443F1 VA: 0x1442F0
	public int blurIterations; // 0x30
	[RangeAttribute] // RVA: 0x144310 Offset: 0x144411 VA: 0x144310
	public float blurFilterDistance; // 0x34
	[RangeAttribute] // RVA: 0x144330 Offset: 0x144431 VA: 0x144330
	public int downsample; // 0x38
	public Texture2D rand; // 0x40
	public Shader aoShader; // 0x48
	private Material aoMaterial; // 0x50

	// Methods

	// RVA: 0x1B6F3E0 Offset: 0x1B6F4E1 VA: 0x1B6F3E0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1B6F460 Offset: 0x1B6F561 VA: 0x1B6F460
	private void OnDisable() { }

	[ImageEffectOpaque] // RVA: 0x144AE0 Offset: 0x144BE1 VA: 0x144AE0
	// RVA: 0x1B6F530 Offset: 0x1B6F631 VA: 0x1B6F530
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1B6FDA0 Offset: 0x1B6FEA1 VA: 0x1B6FDA0
	public void .ctor() { }
}

