[ExecuteAlways] // RVA: 0x13EE40 Offset: 0x13EF41 VA: 0x13EE40
public class TMP_SubMeshUI : MaskableGraphic // TypeDefIndex: 5851
{
	// Fields
	[SerializeField] // RVA: 0x13FDD0 Offset: 0x13FED1 VA: 0x13FDD0
	private TMP_FontAsset m_fontAsset; // 0xC0
	[SerializeField] // RVA: 0x13FDE0 Offset: 0x13FEE1 VA: 0x13FDE0
	private TMP_SpriteAsset m_spriteAsset; // 0xC8
	[SerializeField] // RVA: 0x13FDF0 Offset: 0x13FEF1 VA: 0x13FDF0
	private Material m_material; // 0xD0
	[SerializeField] // RVA: 0x13FE00 Offset: 0x13FF01 VA: 0x13FE00
	private Material m_sharedMaterial; // 0xD8
	private Material m_fallbackMaterial; // 0xE0
	private Material m_fallbackSourceMaterial; // 0xE8
	[SerializeField] // RVA: 0x13FE10 Offset: 0x13FF11 VA: 0x13FE10
	private bool m_isDefaultMaterial; // 0xF0
	[SerializeField] // RVA: 0x13FE20 Offset: 0x13FF21 VA: 0x13FE20
	private float m_padding; // 0xF4
	private Mesh m_mesh; // 0xF8
	[SerializeField] // RVA: 0x13FE30 Offset: 0x13FF31 VA: 0x13FE30
	private TextMeshProUGUI m_TextComponent; // 0x100
	private bool m_isRegisteredForEvents; // 0x108
	private bool m_materialDirty; // 0x109
	[SerializeField] // RVA: 0x13FE40 Offset: 0x13FF41 VA: 0x13FE40
	private int m_materialReferenceIndex; // 0x10C
	private Transform m_RootCanvasTransform; // 0x110

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public override Texture mainTexture { get; }
	public override Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public override Material materialForRendering { get; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Mesh mesh { get; set; }
	public TMP_Text textComponent { get; }

	// Methods

	// RVA: 0x14CC090 Offset: 0x14CC191 VA: 0x14CC090
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x14CC0A0 Offset: 0x14CC1A1 VA: 0x14CC0A0
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x14CC0B0 Offset: 0x14CC1B1 VA: 0x14CC0B0
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x14CC0C0 Offset: 0x14CC1C1 VA: 0x14CC0C0
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x14CC0D0 Offset: 0x14CC1D1 VA: 0x14CC0D0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x14CC1A0 Offset: 0x14CC2A1 VA: 0x14CC1A0 Slot: 32
	public override Material get_material() { }

	// RVA: 0x14CC340 Offset: 0x14CC441 VA: 0x14CC340 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x14CC570 Offset: 0x14CC671 VA: 0x14CC570
	public Material get_sharedMaterial() { }

	// RVA: 0x14CC580 Offset: 0x14CC681 VA: 0x14CC580
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x14CC660 Offset: 0x14CC761 VA: 0x14CC660
	public Material get_fallbackMaterial() { }

	// RVA: 0x14CC670 Offset: 0x14CC771 VA: 0x14CC670
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x14CC7F0 Offset: 0x14CC8F1 VA: 0x14CC7F0
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x14CC800 Offset: 0x14CC901 VA: 0x14CC800
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x14CC810 Offset: 0x14CC911 VA: 0x14CC810 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x14CC880 Offset: 0x14CC981 VA: 0x14CC880
	public bool get_isDefaultMaterial() { }

	// RVA: 0x14CC890 Offset: 0x14CC991 VA: 0x14CC890
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x14CC8A0 Offset: 0x14CC9A1 VA: 0x14CC8A0
	public float get_padding() { }

	// RVA: 0x14CC8B0 Offset: 0x14CC9B1 VA: 0x14CC8B0
	public void set_padding(float value) { }

	// RVA: 0x14CC8C0 Offset: 0x14CC9C1 VA: 0x14CC8C0
	public Mesh get_mesh() { }

	// RVA: 0x14CC980 Offset: 0x14CCA81 VA: 0x14CC980
	public void set_mesh(Mesh value) { }

	// RVA: 0x14CC990 Offset: 0x14CCA91 VA: 0x14CC990
	public TMP_Text get_textComponent() { }

	// RVA: 0x14CCA40 Offset: 0x14CCB41 VA: 0x14CCA40
	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	// RVA: 0x14CCFB0 Offset: 0x14CD0B1 VA: 0x14CCFB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x14CD030 Offset: 0x14CD131 VA: 0x14CD030 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x14CD100 Offset: 0x14CD201 VA: 0x14CD100 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x14CD2E0 Offset: 0x14CD3E1 VA: 0x14CD2E0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x14CD350 Offset: 0x14CD451 VA: 0x14CD350 Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x14CC4D0 Offset: 0x14CC5D1 VA: 0x14CC4D0
	public float GetPaddingForMaterial() { }

	// RVA: 0x14CD490 Offset: 0x14CD591 VA: 0x14CD490
	public float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x14CD530 Offset: 0x14CD631 VA: 0x14CD530
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x14CD5C0 Offset: 0x14CD6C1 VA: 0x14CD5C0 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x14CD5D0 Offset: 0x14CD6D1 VA: 0x14CD5D0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x14CD6B0 Offset: 0x14CD7B1 VA: 0x14CD6B0 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x14CD6C0 Offset: 0x14CD7C1 VA: 0x14CD6C0 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x14CD710 Offset: 0x14CD811 VA: 0x14CD710
	public void SetPivotDirty() { }

	// RVA: 0x14CD810 Offset: 0x14CD911 VA: 0x14CD810
	private Transform GetRootCanvasTransform() { }

	// RVA: 0x14CD8E0 Offset: 0x14CD9E1 VA: 0x14CD8E0 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x14CD8F0 Offset: 0x14CD9F1 VA: 0x14CD8F0 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x14CD900 Offset: 0x14CDA01 VA: 0x14CD900 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x14CD950 Offset: 0x14CDA51 VA: 0x14CD950
	public void RefreshMaterial() { }

	// RVA: 0x14CD960 Offset: 0x14CDA61 VA: 0x14CD960 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x14CDB80 Offset: 0x14CDC81 VA: 0x14CDB80 Slot: 63
	public override void RecalculateClipping() { }

	// RVA: 0x14CDB90 Offset: 0x14CDC91 VA: 0x14CDB90
	private Material GetMaterial() { }

	// RVA: 0x14CC1B0 Offset: 0x14CC2B1 VA: 0x14CC1B0
	private Material GetMaterial(Material mat) { }

	// RVA: 0x14CDBA0 Offset: 0x14CDCA1 VA: 0x14CDBA0
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0x14CDC60 Offset: 0x14CDD61 VA: 0x14CDC60
	private Material GetSharedMaterial() { }

	// RVA: 0x14CC590 Offset: 0x14CC691 VA: 0x14CC590
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0x14CDC90 Offset: 0x14CDD91 VA: 0x14CDC90
	public void .ctor() { }
}

