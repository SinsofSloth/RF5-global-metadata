[ExecuteInEditMode] // RVA: 0x143830 Offset: 0x143931 VA: 0x143830
[RequireComponent] // RVA: 0x143830 Offset: 0x143931 VA: 0x143830
[AddComponentMenu] // RVA: 0x143830 Offset: 0x143931 VA: 0x143830
public class ScreenOverlay : PostEffectsBase // TypeDefIndex: 6040
{
	// Fields
	public ScreenOverlay.OverlayBlendMode blendMode; // 0x28
	public float intensity; // 0x2C
	public Texture2D texture; // 0x30
	public Shader overlayShader; // 0x38
	private Material overlayMaterial; // 0x40

	// Methods

	// RVA: 0x1B6F1D0 Offset: 0x1B6F2D1 VA: 0x1B6F1D0 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1B6F250 Offset: 0x1B6F351 VA: 0x1B6F250
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1B6F3C0 Offset: 0x1B6F4C1 VA: 0x1B6F3C0
	public void .ctor() { }
}

