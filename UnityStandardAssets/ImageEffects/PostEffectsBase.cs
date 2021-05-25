[ExecuteInEditMode] // RVA: 0x143730 Offset: 0x143831 VA: 0x143730
[RequireComponent] // RVA: 0x143730 Offset: 0x143831 VA: 0x143730
public class PostEffectsBase : MonoBehaviour // TypeDefIndex: 6037
{
	// Fields
	protected bool supportHDRTextures; // 0x18
	protected bool supportDX11; // 0x19
	protected bool isSupported; // 0x1A
	private List<Material> createdMaterials; // 0x20

	// Methods

	// RVA: 0x1A4AA80 Offset: 0x1A4AB81 VA: 0x1A4AA80
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x1A49EF0 Offset: 0x1A49FF1 VA: 0x1A49EF0
	protected Material CreateMaterial(Shader s, Material m2Create) { }

	// RVA: 0x1A5D8D0 Offset: 0x1A5D9D1 VA: 0x1A5D8D0
	private void OnEnable() { }

	// RVA: 0x1A5D8E0 Offset: 0x1A5D9E1 VA: 0x1A5D8E0
	private void OnDestroy() { }

	// RVA: 0x1A5D8F0 Offset: 0x1A5D9F1 VA: 0x1A5D8F0
	private void RemoveCreatedMaterials() { }

	// RVA: 0x1A5D9A0 Offset: 0x1A5DAA1 VA: 0x1A5D9A0
	protected bool CheckSupport() { }

	// RVA: 0x1A5DA70 Offset: 0x1A5DB71 VA: 0x1A5DA70 Slot: 4
	public virtual bool CheckResources() { }

	// RVA: 0x1A52170 Offset: 0x1A52271 VA: 0x1A52170
	protected void Start() { }

	// RVA: 0x1A49DD0 Offset: 0x1A49ED1 VA: 0x1A49DD0
	protected bool CheckSupport(bool needDepth) { }

	// RVA: 0x1A4FCD0 Offset: 0x1A4FDD1 VA: 0x1A4FCD0
	protected bool CheckSupport(bool needDepth, bool needHdr) { }

	// RVA: 0x1A5DB20 Offset: 0x1A5DC21 VA: 0x1A5DB20
	public bool Dx11Support() { }

	// RVA: 0x1A4A120 Offset: 0x1A4A221 VA: 0x1A4A120
	protected void ReportAutoDisable() { }

	// RVA: 0x1A5DB30 Offset: 0x1A5DC31 VA: 0x1A5DB30
	private bool CheckShader(Shader s) { }

	// RVA: 0x1A4A0F0 Offset: 0x1A4A1F1 VA: 0x1A4A0F0
	protected void NotSupported() { }

	// RVA: 0x1A5DD90 Offset: 0x1A5DE91 VA: 0x1A5DD90
	protected void DrawBorder(RenderTexture dest, Material material) { }

	// RVA: 0x1A4A800 Offset: 0x1A4A901 VA: 0x1A4A800
	public void .ctor() { }
}

