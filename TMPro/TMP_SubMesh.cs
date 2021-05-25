[RequireComponent] // RVA: 0x13EDC0 Offset: 0x13EEC1 VA: 0x13EDC0
[ExecuteAlways] // RVA: 0x13EDC0 Offset: 0x13EEC1 VA: 0x13EDC0
public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 5850
{
	// Fields
	[SerializeField] // RVA: 0x13FD50 Offset: 0x13FE51 VA: 0x13FD50
	private TMP_FontAsset m_fontAsset; // 0x18
	[SerializeField] // RVA: 0x13FD60 Offset: 0x13FE61 VA: 0x13FD60
	private TMP_SpriteAsset m_spriteAsset; // 0x20
	[SerializeField] // RVA: 0x13FD70 Offset: 0x13FE71 VA: 0x13FD70
	private Material m_material; // 0x28
	[SerializeField] // RVA: 0x13FD80 Offset: 0x13FE81 VA: 0x13FD80
	private Material m_sharedMaterial; // 0x30
	private Material m_fallbackMaterial; // 0x38
	private Material m_fallbackSourceMaterial; // 0x40
	[SerializeField] // RVA: 0x13FD90 Offset: 0x13FE91 VA: 0x13FD90
	private bool m_isDefaultMaterial; // 0x48
	[SerializeField] // RVA: 0x13FDA0 Offset: 0x13FEA1 VA: 0x13FDA0
	private float m_padding; // 0x4C
	[SerializeField] // RVA: 0x13FDB0 Offset: 0x13FEB1 VA: 0x13FDB0
	private Renderer m_renderer; // 0x50
	private MeshFilter m_meshFilter; // 0x58
	private Mesh m_mesh; // 0x60
	[SerializeField] // RVA: 0x13FDC0 Offset: 0x13FEC1 VA: 0x13FDC0
	private TextMeshPro m_TextComponent; // 0x68
	private bool m_isRegisteredForEvents; // 0x70

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Renderer renderer { get; }
	public MeshFilter meshFilter { get; }
	public Mesh mesh { get; set; }
	public TMP_Text textComponent { get; }

	// Methods

	// RVA: 0x14CA830 Offset: 0x14CA931 VA: 0x14CA830
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x14CA840 Offset: 0x14CA941 VA: 0x14CA840
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x14CA850 Offset: 0x14CA951 VA: 0x14CA850
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x14CA860 Offset: 0x14CA961 VA: 0x14CA860
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x14CA870 Offset: 0x14CA971 VA: 0x14CA870
	public Material get_material() { }

	// RVA: 0x14CAA50 Offset: 0x14CAB51 VA: 0x14CAA50
	public void set_material(Material value) { }

	// RVA: 0x14CAD00 Offset: 0x14CAE01 VA: 0x14CAD00
	public Material get_sharedMaterial() { }

	// RVA: 0x14CAD10 Offset: 0x14CAE11 VA: 0x14CAD10
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x14CADD0 Offset: 0x14CAED1 VA: 0x14CADD0
	public Material get_fallbackMaterial() { }

	// RVA: 0x14CADE0 Offset: 0x14CAEE1 VA: 0x14CADE0
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x14CAF60 Offset: 0x14CB061 VA: 0x14CAF60
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x14CAF70 Offset: 0x14CB071 VA: 0x14CAF70
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x14CAF80 Offset: 0x14CB081 VA: 0x14CAF80
	public bool get_isDefaultMaterial() { }

	// RVA: 0x14CAF90 Offset: 0x14CB091 VA: 0x14CAF90
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x14CAFA0 Offset: 0x14CB0A1 VA: 0x14CAFA0
	public float get_padding() { }

	// RVA: 0x14CAFB0 Offset: 0x14CB0B1 VA: 0x14CAFB0
	public void set_padding(float value) { }

	// RVA: 0x14CAFC0 Offset: 0x14CB0C1 VA: 0x14CAFC0
	public Renderer get_renderer() { }

	// RVA: 0x14CB070 Offset: 0x14CB171 VA: 0x14CB070
	public MeshFilter get_meshFilter() { }

	// RVA: 0x14CB1A0 Offset: 0x14CB2A1 VA: 0x14CB1A0
	public Mesh get_mesh() { }

	// RVA: 0x14CB260 Offset: 0x14CB361 VA: 0x14CB260
	public void set_mesh(Mesh value) { }

	// RVA: 0x14CB270 Offset: 0x14CB371 VA: 0x14CB270
	public TMP_Text get_textComponent() { }

	// RVA: 0x14CB320 Offset: 0x14CB421 VA: 0x14CB320
	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	// RVA: 0x14CB770 Offset: 0x14CB871 VA: 0x14CB770
	private void OnEnable() { }

	// RVA: 0x14CB8D0 Offset: 0x14CB9D1 VA: 0x14CB8D0
	private void OnDisable() { }

	// RVA: 0x14CB9B0 Offset: 0x14CBAB1 VA: 0x14CB9B0
	private void OnDestroy() { }

	// RVA: 0x14CBB60 Offset: 0x14CBC61 VA: 0x14CBB60
	public void DestroySelf() { }

	// RVA: 0x14CA880 Offset: 0x14CA981 VA: 0x14CA880
	private Material GetMaterial(Material mat) { }

	// RVA: 0x14CBBE0 Offset: 0x14CBCE1 VA: 0x14CBBE0
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0x14CBCA0 Offset: 0x14CBDA1 VA: 0x14CBCA0
	private Material GetSharedMaterial() { }

	// RVA: 0x14CAD20 Offset: 0x14CAE21 VA: 0x14CAD20
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0x14CAB70 Offset: 0x14CAC71 VA: 0x14CAB70
	public float GetPaddingForMaterial() { }

	// RVA: 0x14CBD60 Offset: 0x14CBE61 VA: 0x14CBD60
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x14CAC10 Offset: 0x14CAD11 VA: 0x14CAC10
	public void SetVerticesDirty() { }

	// RVA: 0x14CACF0 Offset: 0x14CADF1 VA: 0x14CACF0
	public void SetMaterialDirty() { }

	// RVA: 0x14CBDF0 Offset: 0x14CBEF1 VA: 0x14CBDF0
	protected void UpdateMaterial() { }

	// RVA: 0x14CC080 Offset: 0x14CC181 VA: 0x14CC080
	public void .ctor() { }
}

