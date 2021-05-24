[ExecuteInEditMode] // RVA: 0x142EE0 Offset: 0x142FE1 VA: 0x142EE0
[AddComponentMenu] // RVA: 0x142EE0 Offset: 0x142FE1 VA: 0x142EE0
public class ColorCorrectionLookup : PostEffectsBase // TypeDefIndex: 6014
{
	// Fields
	public Shader shader; // 0x28
	private Material material; // 0x30
	public Texture3D converted3DLut; // 0x38
	public string basedOnTempTex; // 0x40

	// Methods

	// RVA: 0x1A53440 Offset: 0x1A53541 VA: 0x1A53440 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x1A535C0 Offset: 0x1A536C1 VA: 0x1A535C0
	private void OnDisable() { }

	// RVA: 0x1A53690 Offset: 0x1A53791 VA: 0x1A53690
	private void OnDestroy() { }

	// RVA: 0x1A53760 Offset: 0x1A53861 VA: 0x1A53760
	public void SetIdentityLut() { }

	// RVA: 0x1A539F0 Offset: 0x1A53AF1 VA: 0x1A539F0
	public bool ValidDimensions(Texture2D tex2d) { }

	// RVA: 0x1A53B10 Offset: 0x1A53C11 VA: 0x1A53B10
	public void Convert(Texture2D temp2DTex, string path) { }

	// RVA: 0x1A53E80 Offset: 0x1A53F81 VA: 0x1A53E80
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A54070 Offset: 0x1A54171 VA: 0x1A54070
	public void .ctor() { }
}

