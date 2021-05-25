[ExecuteInEditMode] // RVA: 0x147770 Offset: 0x147871 VA: 0x147770
[AddComponentMenu] // RVA: 0x147770 Offset: 0x147871 VA: 0x147770
public class CameraFilterPack_Glow_Glow_Color : MonoBehaviour // TypeDefIndex: 8967
{
	// Fields
	public Shader SCShader; // 0x18
	private float TimeX; // 0x20
	private Material SCMaterial; // 0x28
	[RangeAttribute] // RVA: 0x174F90 Offset: 0x175091 VA: 0x174F90
	public float Amount; // 0x30
	[RangeAttribute] // RVA: 0x174FB0 Offset: 0x1750B1 VA: 0x174FB0
	public int FastFilter; // 0x34
	[RangeAttribute] // RVA: 0x174FD0 Offset: 0x1750D1 VA: 0x174FD0
	public float Threshold; // 0x38
	[RangeAttribute] // RVA: 0x174FF0 Offset: 0x1750F1 VA: 0x174FF0
	public float Intensity; // 0x3C
	[RangeAttribute] // RVA: 0x175010 Offset: 0x175111 VA: 0x175010
	public float Precision; // 0x40
	public Color GlowColor; // 0x44

	// Properties
	private Material material { get; }

	// Methods

	// RVA: 0x1D33AA0 Offset: 0x1D33BA1 VA: 0x1D33AA0
	private Material get_material() { }

	// RVA: 0x1D33B80 Offset: 0x1D33C81 VA: 0x1D33B80
	private void Start() { }

	// RVA: 0x1D33C10 Offset: 0x1D33D11 VA: 0x1D33C10
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture) { }

	// RVA: 0x1D340A0 Offset: 0x1D341A1 VA: 0x1D340A0
	private void Update() { }

	// RVA: 0x1D340B0 Offset: 0x1D341B1 VA: 0x1D340B0
	private void OnDisable() { }

	// RVA: 0x1D34170 Offset: 0x1D34271 VA: 0x1D34170
	public void .ctor() { }
}

