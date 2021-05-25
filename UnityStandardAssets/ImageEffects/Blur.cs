[ExecuteInEditMode] // RVA: 0x142D00 Offset: 0x142E01 VA: 0x142D00
[AddComponentMenu] // RVA: 0x142D00 Offset: 0x142E01 VA: 0x142D00
public class Blur : MonoBehaviour // TypeDefIndex: 6007
{
	// Fields
	[RangeAttribute] // RVA: 0x143E50 Offset: 0x143F51 VA: 0x143E50
	public int iterations; // 0x18
	[RangeAttribute] // RVA: 0x143E70 Offset: 0x143F71 VA: 0x143E70
	public float blurSpread; // 0x1C
	public Shader blurShader; // 0x20
	private static Material m_Material; // 0x0

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x1A4E190 Offset: 0x1A4E291 VA: 0x1A4E190
	protected Material get_material() { }

	// RVA: 0x1A4E2D0 Offset: 0x1A4E3D1 VA: 0x1A4E2D0
	protected void OnDisable() { }

	// RVA: 0x1A4E3E0 Offset: 0x1A4E4E1 VA: 0x1A4E3E0
	protected void Start() { }

	// RVA: 0x1A4E4B0 Offset: 0x1A4E5B1 VA: 0x1A4E4B0
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration) { }

	// RVA: 0x1A4E650 Offset: 0x1A4E751 VA: 0x1A4E650
	private void DownSample4x(RenderTexture source, RenderTexture dest) { }

	// RVA: 0x1A4E7D0 Offset: 0x1A4E8D1 VA: 0x1A4E7D0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1A4E940 Offset: 0x1A4EA41 VA: 0x1A4E940
	public void .ctor() { }

	// RVA: 0x1A4E960 Offset: 0x1A4EA61 VA: 0x1A4E960
	private static void .cctor() { }
}

