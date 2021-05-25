[ExecuteInEditMode] // RVA: 0x147720 Offset: 0x147821 VA: 0x147720
[AddComponentMenu] // RVA: 0x147720 Offset: 0x147821 VA: 0x147720
public class CameraFilterPack_Glow_Glow : MonoBehaviour // TypeDefIndex: 8966
{
	// Fields
	public Shader SCShader; // 0x18
	private float TimeX; // 0x20
	private Material SCMaterial; // 0x28
	[RangeAttribute] // RVA: 0x174EF0 Offset: 0x174FF1 VA: 0x174EF0
	public float Amount; // 0x30
	[RangeAttribute] // RVA: 0x174F10 Offset: 0x175011 VA: 0x174F10
	public int FastFilter; // 0x34
	[RangeAttribute] // RVA: 0x174F30 Offset: 0x175031 VA: 0x174F30
	public float Threshold; // 0x38
	[RangeAttribute] // RVA: 0x174F50 Offset: 0x175051 VA: 0x174F50
	public float Intensity; // 0x3C
	[RangeAttribute] // RVA: 0x174F70 Offset: 0x175071 VA: 0x174F70
	public float Precision; // 0x40

	// Properties
	private Material material { get; }

	// Methods

	// RVA: 0x1D333D0 Offset: 0x1D334D1 VA: 0x1D333D0
	private Material get_material() { }

	// RVA: 0x1D334B0 Offset: 0x1D335B1 VA: 0x1D334B0
	private void Start() { }

	// RVA: 0x1D33540 Offset: 0x1D33641 VA: 0x1D33540
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture) { }

	// RVA: 0x1D339A0 Offset: 0x1D33AA1 VA: 0x1D339A0
	private void Update() { }

	// RVA: 0x1D339B0 Offset: 0x1D33AB1 VA: 0x1D339B0
	private void OnDisable() { }

	// RVA: 0x1D33A70 Offset: 0x1D33B71 VA: 0x1D33A70
	public void .ctor() { }
}

