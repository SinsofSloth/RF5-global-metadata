[DisallowMultipleComponent] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[RequireComponent] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[AddComponentMenu] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[ExecuteAlways] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[HelpURLAttribute] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 5899
{
	// Fields
	[SerializeField] // RVA: 0x1402F0 Offset: 0x1403F1 VA: 0x1402F0
	private bool m_hasFontAssetChanged; // 0x1C20
	private float m_previousLossyScaleY; // 0x1C24
	[SerializeField] // RVA: 0x140300 Offset: 0x140401 VA: 0x140300
	private Renderer m_renderer; // 0x1C28
	private MeshFilter m_meshFilter; // 0x1C30
	private CanvasRenderer m_CanvasRenderer; // 0x1C38
	private bool m_isFirstAllocation; // 0x1C40
	private int m_max_characters; // 0x1C44
	private int m_max_numberOfLines; // 0x1C48
	private TMP_SubMesh[] m_subTextObjects; // 0x1C50
	[SerializeField] // RVA: 0x140310 Offset: 0x140411 VA: 0x140310
	private MaskingTypes m_maskType; // 0x1C58
	private Matrix4x4 m_EnvMapMatrix; // 0x1C5C
	private Vector3[] m_RectTransformCorners; // 0x1CA0
	private bool m_isRegisteredForEvents; // 0x1CA8
	[SerializeField] // RVA: 0x140320 Offset: 0x140421 VA: 0x140320
	internal int _SortingLayerID; // 0x1CAC
	[SerializeField] // RVA: 0x140330 Offset: 0x140431 VA: 0x140330
	internal int _SortingOrder; // 0x1CB0
	[CompilerGeneratedAttribute] // RVA: 0x140340 Offset: 0x140441 VA: 0x140340
	private Action<TMP_TextInfo> OnPreRenderText; // 0x1CB8
	private bool m_currentAutoSizeMode; // 0x1CC0

	// Properties
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public override bool autoSizeTextContainer { get; set; }
	[ObsoleteAttribute] // RVA: 0x140BA0 Offset: 0x140CA1 VA: 0x140BA0
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }

	// Methods

	// RVA: 0x15A5F70 Offset: 0x15A6071 VA: 0x15A5F70 Slot: 4
	protected override void Awake() { }

	// RVA: 0x15A64C0 Offset: 0x15A65C1 VA: 0x15A64C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15A66D0 Offset: 0x15A67D1 VA: 0x15A66D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15A6740 Offset: 0x15A6841 VA: 0x15A6740 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x15A6800 Offset: 0x15A6901 VA: 0x15A6800 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x15A6F20 Offset: 0x15A7021 VA: 0x15A6F20
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x15A7260 Offset: 0x15A7361 VA: 0x15A7260
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x15A7400 Offset: 0x15A7501 VA: 0x15A7400
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x15A74B0 Offset: 0x15A75B1 VA: 0x15A74B0
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x15A75C0 Offset: 0x15A76C1 VA: 0x15A75C0
	private void EnableMasking() { }

	// RVA: 0x15A77D0 Offset: 0x15A78D1 VA: 0x15A77D0
	private void DisableMasking() { }

	// RVA: 0x15A7740 Offset: 0x15A7841 VA: 0x15A7740
	private void UpdateMask() { }

	// RVA: 0x15A7A20 Offset: 0x15A7B21 VA: 0x15A7A20 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x15A7B60 Offset: 0x15A7C61 VA: 0x15A7B60 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x15A7D50 Offset: 0x15A7E51 VA: 0x15A7D50 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x15A7DA0 Offset: 0x15A7EA1 VA: 0x15A7DA0 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x15A7F60 Offset: 0x15A8061 VA: 0x15A7F60 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x15A8330 Offset: 0x15A8431 VA: 0x15A8330 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x15A84B0 Offset: 0x15A85B1 VA: 0x15A84B0 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x15A85D0 Offset: 0x15A86D1 VA: 0x15A85D0 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x15A7950 Offset: 0x15A7A51 VA: 0x15A7950
	private void CreateMaterialInstance() { }

	// RVA: 0x15A86F0 Offset: 0x15A87F1 VA: 0x15A86F0 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x15A8830 Offset: 0x15A8931 VA: 0x15A8830 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x15A8B10 Offset: 0x15A8C11 VA: 0x15A8B10
	private void SetPerspectiveCorrection() { }

	// RVA: 0x15A8BD0 Offset: 0x15A8CD1 VA: 0x15A8BD0 Slot: 114
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x15AAA30 Offset: 0x15AAB31 VA: 0x15AAA30 Slot: 120
	public override void ComputeMarginSize() { }

	// RVA: 0x15AAB70 Offset: 0x15AAC71 VA: 0x15AAB70 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x15AAB90 Offset: 0x15AAC91 VA: 0x15AAB90 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x15AABD0 Offset: 0x15AACD1 VA: 0x15AABD0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15AADF0 Offset: 0x15AAEF1 VA: 0x15AADF0 Slot: 133
	internal override void InternalUpdate() { }

	// RVA: 0x15AB100 Offset: 0x15AB201 VA: 0x15AB100
	private void OnPreRenderObject() { }

	// RVA: 0x15AB440 Offset: 0x15AB541 VA: 0x15AB440 Slot: 115
	protected override void GenerateTextMesh() { }

	// RVA: 0x15B44A0 Offset: 0x15B45A1 VA: 0x15B44A0 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x15B4560 Offset: 0x15B4661 VA: 0x15B4560
	private void SetMeshFilters(bool state) { }

	// RVA: 0x15B4830 Offset: 0x15B4931 VA: 0x15B4830 Slot: 128
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x15B4950 Offset: 0x15B4A51 VA: 0x15B4950
	protected void SetActiveSubTextObjectRenderers(bool state) { }

	// RVA: 0x15B4AA0 Offset: 0x15B4BA1 VA: 0x15B4AA0 Slot: 129
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x15B4BB0 Offset: 0x15B4CB1 VA: 0x15B4BB0 Slot: 117
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x15AAEF0 Offset: 0x15AAFF1 VA: 0x15AAEF0
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x15B4ED0 Offset: 0x15B4FD1 VA: 0x15B4ED0
	public int get_sortingLayerID() { }

	// RVA: 0x15B50B0 Offset: 0x15B51B1 VA: 0x15B50B0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x15B51E0 Offset: 0x15B52E1 VA: 0x15B51E0
	public int get_sortingOrder() { }

	// RVA: 0x15B5310 Offset: 0x15B5411 VA: 0x15B5310
	public void set_sortingOrder(int value) { }

	// RVA: 0x15B5440 Offset: 0x15B5541 VA: 0x15B5440 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x15B5450 Offset: 0x15B5551 VA: 0x15B5450 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x15B54B0 Offset: 0x15B55B1 VA: 0x15B54B0
	public TextContainer get_textContainer() { }

	// RVA: 0x15A6410 Offset: 0x15A6511 VA: 0x15A6410
	public Transform get_transform() { }

	// RVA: 0x15B5000 Offset: 0x15B5101 VA: 0x15B5000
	public Renderer get_renderer() { }

	// RVA: 0x15B54C0 Offset: 0x15B55C1 VA: 0x15B54C0 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x15A65A0 Offset: 0x15A66A1 VA: 0x15A65A0
	public MeshFilter get_meshFilter() { }

	// RVA: 0x15B5590 Offset: 0x15B5691 VA: 0x15B5590
	public MaskingTypes get_maskType() { }

	// RVA: 0x15B55A0 Offset: 0x15B56A1 VA: 0x15B55A0
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x15B55B0 Offset: 0x15B56B1 VA: 0x15B55B0
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x15B5670 Offset: 0x15B5771 VA: 0x15B5670
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x15B56E0 Offset: 0x15B57E1 VA: 0x15B56E0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x15B5780 Offset: 0x15B5881 VA: 0x15B5780 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x15B5860 Offset: 0x15B5961 VA: 0x15B5860 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x15B5870 Offset: 0x15B5971 VA: 0x15B5870 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x15B58D0 Offset: 0x15B59D1 VA: 0x15B58D0 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x15B59D0 Offset: 0x15B5AD1 VA: 0x15B59D0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x15B5BA0 Offset: 0x15B5CA1 VA: 0x15B5BA0 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x15B5CC0 Offset: 0x15B5DC1 VA: 0x15B5CC0 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x15B5D00 Offset: 0x15B5E01 VA: 0x15B5D00 Slot: 119
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x15B5D80 Offset: 0x15B5E81 VA: 0x15B5D80 Slot: 131
	public override void ClearMesh(bool updateMesh) { }

	[CompilerGeneratedAttribute] // RVA: 0x140800 Offset: 0x140901 VA: 0x140800
	// RVA: 0x15B5EB0 Offset: 0x15B5FB1 VA: 0x15B5EB0 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x140810 Offset: 0x140911 VA: 0x140810
	// RVA: 0x15B5F60 Offset: 0x15B6061 VA: 0x15B5F60 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x15B6010 Offset: 0x15B6111 VA: 0x15B6010 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x15B6030 Offset: 0x15B6131 VA: 0x15B6030 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x15B61E0 Offset: 0x15B62E1 VA: 0x15B61E0 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x15B6390 Offset: 0x15B6491 VA: 0x15B6390
	public void UpdateFontAsset() { }

	// RVA: 0x15B63A0 Offset: 0x15B64A1 VA: 0x15B63A0 Slot: 134
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x15B63B0 Offset: 0x15B64B1 VA: 0x15B63B0 Slot: 135
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x15B63C0 Offset: 0x15B64C1 VA: 0x15B63C0
	public void .ctor() { }
}

[DisallowMultipleComponent] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[RequireComponent] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[AddComponentMenu] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[ExecuteAlways] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[HelpURLAttribute] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 5899
{
	// Fields
	[SerializeField] // RVA: 0x1402F0 Offset: 0x1403F1 VA: 0x1402F0
	private bool m_hasFontAssetChanged; // 0x1C20
	private float m_previousLossyScaleY; // 0x1C24
	[SerializeField] // RVA: 0x140300 Offset: 0x140401 VA: 0x140300
	private Renderer m_renderer; // 0x1C28
	private MeshFilter m_meshFilter; // 0x1C30
	private CanvasRenderer m_CanvasRenderer; // 0x1C38
	private bool m_isFirstAllocation; // 0x1C40
	private int m_max_characters; // 0x1C44
	private int m_max_numberOfLines; // 0x1C48
	private TMP_SubMesh[] m_subTextObjects; // 0x1C50
	[SerializeField] // RVA: 0x140310 Offset: 0x140411 VA: 0x140310
	private MaskingTypes m_maskType; // 0x1C58
	private Matrix4x4 m_EnvMapMatrix; // 0x1C5C
	private Vector3[] m_RectTransformCorners; // 0x1CA0
	private bool m_isRegisteredForEvents; // 0x1CA8
	[SerializeField] // RVA: 0x140320 Offset: 0x140421 VA: 0x140320
	internal int _SortingLayerID; // 0x1CAC
	[SerializeField] // RVA: 0x140330 Offset: 0x140431 VA: 0x140330
	internal int _SortingOrder; // 0x1CB0
	[CompilerGeneratedAttribute] // RVA: 0x140340 Offset: 0x140441 VA: 0x140340
	private Action<TMP_TextInfo> OnPreRenderText; // 0x1CB8
	private bool m_currentAutoSizeMode; // 0x1CC0

	// Properties
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public override bool autoSizeTextContainer { get; set; }
	[ObsoleteAttribute] // RVA: 0x140BA0 Offset: 0x140CA1 VA: 0x140BA0
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }

	// Methods

	// RVA: 0x15A5F70 Offset: 0x15A6071 VA: 0x15A5F70 Slot: 4
	protected override void Awake() { }

	// RVA: 0x15A64C0 Offset: 0x15A65C1 VA: 0x15A64C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15A66D0 Offset: 0x15A67D1 VA: 0x15A66D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15A6740 Offset: 0x15A6841 VA: 0x15A6740 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x15A6800 Offset: 0x15A6901 VA: 0x15A6800 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x15A6F20 Offset: 0x15A7021 VA: 0x15A6F20
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x15A7260 Offset: 0x15A7361 VA: 0x15A7260
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x15A7400 Offset: 0x15A7501 VA: 0x15A7400
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x15A74B0 Offset: 0x15A75B1 VA: 0x15A74B0
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x15A75C0 Offset: 0x15A76C1 VA: 0x15A75C0
	private void EnableMasking() { }

	// RVA: 0x15A77D0 Offset: 0x15A78D1 VA: 0x15A77D0
	private void DisableMasking() { }

	// RVA: 0x15A7740 Offset: 0x15A7841 VA: 0x15A7740
	private void UpdateMask() { }

	// RVA: 0x15A7A20 Offset: 0x15A7B21 VA: 0x15A7A20 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x15A7B60 Offset: 0x15A7C61 VA: 0x15A7B60 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x15A7D50 Offset: 0x15A7E51 VA: 0x15A7D50 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x15A7DA0 Offset: 0x15A7EA1 VA: 0x15A7DA0 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x15A7F60 Offset: 0x15A8061 VA: 0x15A7F60 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x15A8330 Offset: 0x15A8431 VA: 0x15A8330 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x15A84B0 Offset: 0x15A85B1 VA: 0x15A84B0 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x15A85D0 Offset: 0x15A86D1 VA: 0x15A85D0 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x15A7950 Offset: 0x15A7A51 VA: 0x15A7950
	private void CreateMaterialInstance() { }

	// RVA: 0x15A86F0 Offset: 0x15A87F1 VA: 0x15A86F0 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x15A8830 Offset: 0x15A8931 VA: 0x15A8830 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x15A8B10 Offset: 0x15A8C11 VA: 0x15A8B10
	private void SetPerspectiveCorrection() { }

	// RVA: 0x15A8BD0 Offset: 0x15A8CD1 VA: 0x15A8BD0 Slot: 114
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x15AAA30 Offset: 0x15AAB31 VA: 0x15AAA30 Slot: 120
	public override void ComputeMarginSize() { }

	// RVA: 0x15AAB70 Offset: 0x15AAC71 VA: 0x15AAB70 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x15AAB90 Offset: 0x15AAC91 VA: 0x15AAB90 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x15AABD0 Offset: 0x15AACD1 VA: 0x15AABD0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15AADF0 Offset: 0x15AAEF1 VA: 0x15AADF0 Slot: 133
	internal override void InternalUpdate() { }

	// RVA: 0x15AB100 Offset: 0x15AB201 VA: 0x15AB100
	private void OnPreRenderObject() { }

	// RVA: 0x15AB440 Offset: 0x15AB541 VA: 0x15AB440 Slot: 115
	protected override void GenerateTextMesh() { }

	// RVA: 0x15B44A0 Offset: 0x15B45A1 VA: 0x15B44A0 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x15B4560 Offset: 0x15B4661 VA: 0x15B4560
	private void SetMeshFilters(bool state) { }

	// RVA: 0x15B4830 Offset: 0x15B4931 VA: 0x15B4830 Slot: 128
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x15B4950 Offset: 0x15B4A51 VA: 0x15B4950
	protected void SetActiveSubTextObjectRenderers(bool state) { }

	// RVA: 0x15B4AA0 Offset: 0x15B4BA1 VA: 0x15B4AA0 Slot: 129
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x15B4BB0 Offset: 0x15B4CB1 VA: 0x15B4BB0 Slot: 117
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x15AAEF0 Offset: 0x15AAFF1 VA: 0x15AAEF0
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x15B4ED0 Offset: 0x15B4FD1 VA: 0x15B4ED0
	public int get_sortingLayerID() { }

	// RVA: 0x15B50B0 Offset: 0x15B51B1 VA: 0x15B50B0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x15B51E0 Offset: 0x15B52E1 VA: 0x15B51E0
	public int get_sortingOrder() { }

	// RVA: 0x15B5310 Offset: 0x15B5411 VA: 0x15B5310
	public void set_sortingOrder(int value) { }

	// RVA: 0x15B5440 Offset: 0x15B5541 VA: 0x15B5440 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x15B5450 Offset: 0x15B5551 VA: 0x15B5450 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x15B54B0 Offset: 0x15B55B1 VA: 0x15B54B0
	public TextContainer get_textContainer() { }

	// RVA: 0x15A6410 Offset: 0x15A6511 VA: 0x15A6410
	public Transform get_transform() { }

	// RVA: 0x15B5000 Offset: 0x15B5101 VA: 0x15B5000
	public Renderer get_renderer() { }

	// RVA: 0x15B54C0 Offset: 0x15B55C1 VA: 0x15B54C0 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x15A65A0 Offset: 0x15A66A1 VA: 0x15A65A0
	public MeshFilter get_meshFilter() { }

	// RVA: 0x15B5590 Offset: 0x15B5691 VA: 0x15B5590
	public MaskingTypes get_maskType() { }

	// RVA: 0x15B55A0 Offset: 0x15B56A1 VA: 0x15B55A0
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x15B55B0 Offset: 0x15B56B1 VA: 0x15B55B0
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x15B5670 Offset: 0x15B5771 VA: 0x15B5670
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x15B56E0 Offset: 0x15B57E1 VA: 0x15B56E0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x15B5780 Offset: 0x15B5881 VA: 0x15B5780 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x15B5860 Offset: 0x15B5961 VA: 0x15B5860 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x15B5870 Offset: 0x15B5971 VA: 0x15B5870 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x15B58D0 Offset: 0x15B59D1 VA: 0x15B58D0 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x15B59D0 Offset: 0x15B5AD1 VA: 0x15B59D0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x15B5BA0 Offset: 0x15B5CA1 VA: 0x15B5BA0 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x15B5CC0 Offset: 0x15B5DC1 VA: 0x15B5CC0 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x15B5D00 Offset: 0x15B5E01 VA: 0x15B5D00 Slot: 119
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x15B5D80 Offset: 0x15B5E81 VA: 0x15B5D80 Slot: 131
	public override void ClearMesh(bool updateMesh) { }

	[CompilerGeneratedAttribute] // RVA: 0x140800 Offset: 0x140901 VA: 0x140800
	// RVA: 0x15B5EB0 Offset: 0x15B5FB1 VA: 0x15B5EB0 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x140810 Offset: 0x140911 VA: 0x140810
	// RVA: 0x15B5F60 Offset: 0x15B6061 VA: 0x15B5F60 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x15B6010 Offset: 0x15B6111 VA: 0x15B6010 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x15B6030 Offset: 0x15B6131 VA: 0x15B6030 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x15B61E0 Offset: 0x15B62E1 VA: 0x15B61E0 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x15B6390 Offset: 0x15B6491 VA: 0x15B6390
	public void UpdateFontAsset() { }

	// RVA: 0x15B63A0 Offset: 0x15B64A1 VA: 0x15B63A0 Slot: 134
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x15B63B0 Offset: 0x15B64B1 VA: 0x15B63B0 Slot: 135
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x15B63C0 Offset: 0x15B64C1 VA: 0x15B63C0
	public void .ctor() { }
}

[DisallowMultipleComponent] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[RequireComponent] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[AddComponentMenu] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[ExecuteAlways] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[HelpURLAttribute] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 5899
{
	// Fields
	[SerializeField] // RVA: 0x1402F0 Offset: 0x1403F1 VA: 0x1402F0
	private bool m_hasFontAssetChanged; // 0x1C20
	private float m_previousLossyScaleY; // 0x1C24
	[SerializeField] // RVA: 0x140300 Offset: 0x140401 VA: 0x140300
	private Renderer m_renderer; // 0x1C28
	private MeshFilter m_meshFilter; // 0x1C30
	private CanvasRenderer m_CanvasRenderer; // 0x1C38
	private bool m_isFirstAllocation; // 0x1C40
	private int m_max_characters; // 0x1C44
	private int m_max_numberOfLines; // 0x1C48
	private TMP_SubMesh[] m_subTextObjects; // 0x1C50
	[SerializeField] // RVA: 0x140310 Offset: 0x140411 VA: 0x140310
	private MaskingTypes m_maskType; // 0x1C58
	private Matrix4x4 m_EnvMapMatrix; // 0x1C5C
	private Vector3[] m_RectTransformCorners; // 0x1CA0
	private bool m_isRegisteredForEvents; // 0x1CA8
	[SerializeField] // RVA: 0x140320 Offset: 0x140421 VA: 0x140320
	internal int _SortingLayerID; // 0x1CAC
	[SerializeField] // RVA: 0x140330 Offset: 0x140431 VA: 0x140330
	internal int _SortingOrder; // 0x1CB0
	[CompilerGeneratedAttribute] // RVA: 0x140340 Offset: 0x140441 VA: 0x140340
	private Action<TMP_TextInfo> OnPreRenderText; // 0x1CB8
	private bool m_currentAutoSizeMode; // 0x1CC0

	// Properties
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public override bool autoSizeTextContainer { get; set; }
	[ObsoleteAttribute] // RVA: 0x140BA0 Offset: 0x140CA1 VA: 0x140BA0
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }

	// Methods

	// RVA: 0x15A5F70 Offset: 0x15A6071 VA: 0x15A5F70 Slot: 4
	protected override void Awake() { }

	// RVA: 0x15A64C0 Offset: 0x15A65C1 VA: 0x15A64C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15A66D0 Offset: 0x15A67D1 VA: 0x15A66D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15A6740 Offset: 0x15A6841 VA: 0x15A6740 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x15A6800 Offset: 0x15A6901 VA: 0x15A6800 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x15A6F20 Offset: 0x15A7021 VA: 0x15A6F20
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x15A7260 Offset: 0x15A7361 VA: 0x15A7260
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x15A7400 Offset: 0x15A7501 VA: 0x15A7400
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x15A74B0 Offset: 0x15A75B1 VA: 0x15A74B0
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x15A75C0 Offset: 0x15A76C1 VA: 0x15A75C0
	private void EnableMasking() { }

	// RVA: 0x15A77D0 Offset: 0x15A78D1 VA: 0x15A77D0
	private void DisableMasking() { }

	// RVA: 0x15A7740 Offset: 0x15A7841 VA: 0x15A7740
	private void UpdateMask() { }

	// RVA: 0x15A7A20 Offset: 0x15A7B21 VA: 0x15A7A20 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x15A7B60 Offset: 0x15A7C61 VA: 0x15A7B60 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x15A7D50 Offset: 0x15A7E51 VA: 0x15A7D50 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x15A7DA0 Offset: 0x15A7EA1 VA: 0x15A7DA0 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x15A7F60 Offset: 0x15A8061 VA: 0x15A7F60 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x15A8330 Offset: 0x15A8431 VA: 0x15A8330 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x15A84B0 Offset: 0x15A85B1 VA: 0x15A84B0 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x15A85D0 Offset: 0x15A86D1 VA: 0x15A85D0 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x15A7950 Offset: 0x15A7A51 VA: 0x15A7950
	private void CreateMaterialInstance() { }

	// RVA: 0x15A86F0 Offset: 0x15A87F1 VA: 0x15A86F0 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x15A8830 Offset: 0x15A8931 VA: 0x15A8830 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x15A8B10 Offset: 0x15A8C11 VA: 0x15A8B10
	private void SetPerspectiveCorrection() { }

	// RVA: 0x15A8BD0 Offset: 0x15A8CD1 VA: 0x15A8BD0 Slot: 114
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x15AAA30 Offset: 0x15AAB31 VA: 0x15AAA30 Slot: 120
	public override void ComputeMarginSize() { }

	// RVA: 0x15AAB70 Offset: 0x15AAC71 VA: 0x15AAB70 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x15AAB90 Offset: 0x15AAC91 VA: 0x15AAB90 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x15AABD0 Offset: 0x15AACD1 VA: 0x15AABD0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15AADF0 Offset: 0x15AAEF1 VA: 0x15AADF0 Slot: 133
	internal override void InternalUpdate() { }

	// RVA: 0x15AB100 Offset: 0x15AB201 VA: 0x15AB100
	private void OnPreRenderObject() { }

	// RVA: 0x15AB440 Offset: 0x15AB541 VA: 0x15AB440 Slot: 115
	protected override void GenerateTextMesh() { }

	// RVA: 0x15B44A0 Offset: 0x15B45A1 VA: 0x15B44A0 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x15B4560 Offset: 0x15B4661 VA: 0x15B4560
	private void SetMeshFilters(bool state) { }

	// RVA: 0x15B4830 Offset: 0x15B4931 VA: 0x15B4830 Slot: 128
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x15B4950 Offset: 0x15B4A51 VA: 0x15B4950
	protected void SetActiveSubTextObjectRenderers(bool state) { }

	// RVA: 0x15B4AA0 Offset: 0x15B4BA1 VA: 0x15B4AA0 Slot: 129
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x15B4BB0 Offset: 0x15B4CB1 VA: 0x15B4BB0 Slot: 117
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x15AAEF0 Offset: 0x15AAFF1 VA: 0x15AAEF0
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x15B4ED0 Offset: 0x15B4FD1 VA: 0x15B4ED0
	public int get_sortingLayerID() { }

	// RVA: 0x15B50B0 Offset: 0x15B51B1 VA: 0x15B50B0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x15B51E0 Offset: 0x15B52E1 VA: 0x15B51E0
	public int get_sortingOrder() { }

	// RVA: 0x15B5310 Offset: 0x15B5411 VA: 0x15B5310
	public void set_sortingOrder(int value) { }

	// RVA: 0x15B5440 Offset: 0x15B5541 VA: 0x15B5440 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x15B5450 Offset: 0x15B5551 VA: 0x15B5450 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x15B54B0 Offset: 0x15B55B1 VA: 0x15B54B0
	public TextContainer get_textContainer() { }

	// RVA: 0x15A6410 Offset: 0x15A6511 VA: 0x15A6410
	public Transform get_transform() { }

	// RVA: 0x15B5000 Offset: 0x15B5101 VA: 0x15B5000
	public Renderer get_renderer() { }

	// RVA: 0x15B54C0 Offset: 0x15B55C1 VA: 0x15B54C0 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x15A65A0 Offset: 0x15A66A1 VA: 0x15A65A0
	public MeshFilter get_meshFilter() { }

	// RVA: 0x15B5590 Offset: 0x15B5691 VA: 0x15B5590
	public MaskingTypes get_maskType() { }

	// RVA: 0x15B55A0 Offset: 0x15B56A1 VA: 0x15B55A0
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x15B55B0 Offset: 0x15B56B1 VA: 0x15B55B0
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x15B5670 Offset: 0x15B5771 VA: 0x15B5670
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x15B56E0 Offset: 0x15B57E1 VA: 0x15B56E0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x15B5780 Offset: 0x15B5881 VA: 0x15B5780 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x15B5860 Offset: 0x15B5961 VA: 0x15B5860 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x15B5870 Offset: 0x15B5971 VA: 0x15B5870 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x15B58D0 Offset: 0x15B59D1 VA: 0x15B58D0 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x15B59D0 Offset: 0x15B5AD1 VA: 0x15B59D0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x15B5BA0 Offset: 0x15B5CA1 VA: 0x15B5BA0 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x15B5CC0 Offset: 0x15B5DC1 VA: 0x15B5CC0 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x15B5D00 Offset: 0x15B5E01 VA: 0x15B5D00 Slot: 119
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x15B5D80 Offset: 0x15B5E81 VA: 0x15B5D80 Slot: 131
	public override void ClearMesh(bool updateMesh) { }

	[CompilerGeneratedAttribute] // RVA: 0x140800 Offset: 0x140901 VA: 0x140800
	// RVA: 0x15B5EB0 Offset: 0x15B5FB1 VA: 0x15B5EB0 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x140810 Offset: 0x140911 VA: 0x140810
	// RVA: 0x15B5F60 Offset: 0x15B6061 VA: 0x15B5F60 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x15B6010 Offset: 0x15B6111 VA: 0x15B6010 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x15B6030 Offset: 0x15B6131 VA: 0x15B6030 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x15B61E0 Offset: 0x15B62E1 VA: 0x15B61E0 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x15B6390 Offset: 0x15B6491 VA: 0x15B6390
	public void UpdateFontAsset() { }

	// RVA: 0x15B63A0 Offset: 0x15B64A1 VA: 0x15B63A0 Slot: 134
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x15B63B0 Offset: 0x15B64B1 VA: 0x15B63B0 Slot: 135
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x15B63C0 Offset: 0x15B64C1 VA: 0x15B63C0
	public void .ctor() { }
}

[DisallowMultipleComponent] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[RequireComponent] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[AddComponentMenu] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[ExecuteAlways] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[HelpURLAttribute] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 5899
{
	// Fields
	[SerializeField] // RVA: 0x1402F0 Offset: 0x1403F1 VA: 0x1402F0
	private bool m_hasFontAssetChanged; // 0x1C20
	private float m_previousLossyScaleY; // 0x1C24
	[SerializeField] // RVA: 0x140300 Offset: 0x140401 VA: 0x140300
	private Renderer m_renderer; // 0x1C28
	private MeshFilter m_meshFilter; // 0x1C30
	private CanvasRenderer m_CanvasRenderer; // 0x1C38
	private bool m_isFirstAllocation; // 0x1C40
	private int m_max_characters; // 0x1C44
	private int m_max_numberOfLines; // 0x1C48
	private TMP_SubMesh[] m_subTextObjects; // 0x1C50
	[SerializeField] // RVA: 0x140310 Offset: 0x140411 VA: 0x140310
	private MaskingTypes m_maskType; // 0x1C58
	private Matrix4x4 m_EnvMapMatrix; // 0x1C5C
	private Vector3[] m_RectTransformCorners; // 0x1CA0
	private bool m_isRegisteredForEvents; // 0x1CA8
	[SerializeField] // RVA: 0x140320 Offset: 0x140421 VA: 0x140320
	internal int _SortingLayerID; // 0x1CAC
	[SerializeField] // RVA: 0x140330 Offset: 0x140431 VA: 0x140330
	internal int _SortingOrder; // 0x1CB0
	[CompilerGeneratedAttribute] // RVA: 0x140340 Offset: 0x140441 VA: 0x140340
	private Action<TMP_TextInfo> OnPreRenderText; // 0x1CB8
	private bool m_currentAutoSizeMode; // 0x1CC0

	// Properties
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public override bool autoSizeTextContainer { get; set; }
	[ObsoleteAttribute] // RVA: 0x140BA0 Offset: 0x140CA1 VA: 0x140BA0
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }

	// Methods

	// RVA: 0x15A5F70 Offset: 0x15A6071 VA: 0x15A5F70 Slot: 4
	protected override void Awake() { }

	// RVA: 0x15A64C0 Offset: 0x15A65C1 VA: 0x15A64C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15A66D0 Offset: 0x15A67D1 VA: 0x15A66D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15A6740 Offset: 0x15A6841 VA: 0x15A6740 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x15A6800 Offset: 0x15A6901 VA: 0x15A6800 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x15A6F20 Offset: 0x15A7021 VA: 0x15A6F20
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x15A7260 Offset: 0x15A7361 VA: 0x15A7260
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x15A7400 Offset: 0x15A7501 VA: 0x15A7400
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x15A74B0 Offset: 0x15A75B1 VA: 0x15A74B0
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x15A75C0 Offset: 0x15A76C1 VA: 0x15A75C0
	private void EnableMasking() { }

	// RVA: 0x15A77D0 Offset: 0x15A78D1 VA: 0x15A77D0
	private void DisableMasking() { }

	// RVA: 0x15A7740 Offset: 0x15A7841 VA: 0x15A7740
	private void UpdateMask() { }

	// RVA: 0x15A7A20 Offset: 0x15A7B21 VA: 0x15A7A20 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x15A7B60 Offset: 0x15A7C61 VA: 0x15A7B60 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x15A7D50 Offset: 0x15A7E51 VA: 0x15A7D50 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x15A7DA0 Offset: 0x15A7EA1 VA: 0x15A7DA0 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x15A7F60 Offset: 0x15A8061 VA: 0x15A7F60 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x15A8330 Offset: 0x15A8431 VA: 0x15A8330 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x15A84B0 Offset: 0x15A85B1 VA: 0x15A84B0 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x15A85D0 Offset: 0x15A86D1 VA: 0x15A85D0 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x15A7950 Offset: 0x15A7A51 VA: 0x15A7950
	private void CreateMaterialInstance() { }

	// RVA: 0x15A86F0 Offset: 0x15A87F1 VA: 0x15A86F0 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x15A8830 Offset: 0x15A8931 VA: 0x15A8830 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x15A8B10 Offset: 0x15A8C11 VA: 0x15A8B10
	private void SetPerspectiveCorrection() { }

	// RVA: 0x15A8BD0 Offset: 0x15A8CD1 VA: 0x15A8BD0 Slot: 114
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x15AAA30 Offset: 0x15AAB31 VA: 0x15AAA30 Slot: 120
	public override void ComputeMarginSize() { }

	// RVA: 0x15AAB70 Offset: 0x15AAC71 VA: 0x15AAB70 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x15AAB90 Offset: 0x15AAC91 VA: 0x15AAB90 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x15AABD0 Offset: 0x15AACD1 VA: 0x15AABD0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15AADF0 Offset: 0x15AAEF1 VA: 0x15AADF0 Slot: 133
	internal override void InternalUpdate() { }

	// RVA: 0x15AB100 Offset: 0x15AB201 VA: 0x15AB100
	private void OnPreRenderObject() { }

	// RVA: 0x15AB440 Offset: 0x15AB541 VA: 0x15AB440 Slot: 115
	protected override void GenerateTextMesh() { }

	// RVA: 0x15B44A0 Offset: 0x15B45A1 VA: 0x15B44A0 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x15B4560 Offset: 0x15B4661 VA: 0x15B4560
	private void SetMeshFilters(bool state) { }

	// RVA: 0x15B4830 Offset: 0x15B4931 VA: 0x15B4830 Slot: 128
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x15B4950 Offset: 0x15B4A51 VA: 0x15B4950
	protected void SetActiveSubTextObjectRenderers(bool state) { }

	// RVA: 0x15B4AA0 Offset: 0x15B4BA1 VA: 0x15B4AA0 Slot: 129
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x15B4BB0 Offset: 0x15B4CB1 VA: 0x15B4BB0 Slot: 117
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x15AAEF0 Offset: 0x15AAFF1 VA: 0x15AAEF0
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x15B4ED0 Offset: 0x15B4FD1 VA: 0x15B4ED0
	public int get_sortingLayerID() { }

	// RVA: 0x15B50B0 Offset: 0x15B51B1 VA: 0x15B50B0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x15B51E0 Offset: 0x15B52E1 VA: 0x15B51E0
	public int get_sortingOrder() { }

	// RVA: 0x15B5310 Offset: 0x15B5411 VA: 0x15B5310
	public void set_sortingOrder(int value) { }

	// RVA: 0x15B5440 Offset: 0x15B5541 VA: 0x15B5440 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x15B5450 Offset: 0x15B5551 VA: 0x15B5450 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x15B54B0 Offset: 0x15B55B1 VA: 0x15B54B0
	public TextContainer get_textContainer() { }

	// RVA: 0x15A6410 Offset: 0x15A6511 VA: 0x15A6410
	public Transform get_transform() { }

	// RVA: 0x15B5000 Offset: 0x15B5101 VA: 0x15B5000
	public Renderer get_renderer() { }

	// RVA: 0x15B54C0 Offset: 0x15B55C1 VA: 0x15B54C0 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x15A65A0 Offset: 0x15A66A1 VA: 0x15A65A0
	public MeshFilter get_meshFilter() { }

	// RVA: 0x15B5590 Offset: 0x15B5691 VA: 0x15B5590
	public MaskingTypes get_maskType() { }

	// RVA: 0x15B55A0 Offset: 0x15B56A1 VA: 0x15B55A0
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x15B55B0 Offset: 0x15B56B1 VA: 0x15B55B0
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x15B5670 Offset: 0x15B5771 VA: 0x15B5670
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x15B56E0 Offset: 0x15B57E1 VA: 0x15B56E0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x15B5780 Offset: 0x15B5881 VA: 0x15B5780 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x15B5860 Offset: 0x15B5961 VA: 0x15B5860 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x15B5870 Offset: 0x15B5971 VA: 0x15B5870 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x15B58D0 Offset: 0x15B59D1 VA: 0x15B58D0 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x15B59D0 Offset: 0x15B5AD1 VA: 0x15B59D0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x15B5BA0 Offset: 0x15B5CA1 VA: 0x15B5BA0 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x15B5CC0 Offset: 0x15B5DC1 VA: 0x15B5CC0 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x15B5D00 Offset: 0x15B5E01 VA: 0x15B5D00 Slot: 119
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x15B5D80 Offset: 0x15B5E81 VA: 0x15B5D80 Slot: 131
	public override void ClearMesh(bool updateMesh) { }

	[CompilerGeneratedAttribute] // RVA: 0x140800 Offset: 0x140901 VA: 0x140800
	// RVA: 0x15B5EB0 Offset: 0x15B5FB1 VA: 0x15B5EB0 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x140810 Offset: 0x140911 VA: 0x140810
	// RVA: 0x15B5F60 Offset: 0x15B6061 VA: 0x15B5F60 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x15B6010 Offset: 0x15B6111 VA: 0x15B6010 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x15B6030 Offset: 0x15B6131 VA: 0x15B6030 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x15B61E0 Offset: 0x15B62E1 VA: 0x15B61E0 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x15B6390 Offset: 0x15B6491 VA: 0x15B6390
	public void UpdateFontAsset() { }

	// RVA: 0x15B63A0 Offset: 0x15B64A1 VA: 0x15B63A0 Slot: 134
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x15B63B0 Offset: 0x15B64B1 VA: 0x15B63B0 Slot: 135
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x15B63C0 Offset: 0x15B64C1 VA: 0x15B63C0
	public void .ctor() { }
}

[DisallowMultipleComponent] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[RequireComponent] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[AddComponentMenu] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[ExecuteAlways] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
[HelpURLAttribute] // RVA: 0x13EEB0 Offset: 0x13EFB1 VA: 0x13EEB0
public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 5899
{
	// Fields
	[SerializeField] // RVA: 0x1402F0 Offset: 0x1403F1 VA: 0x1402F0
	private bool m_hasFontAssetChanged; // 0x1C20
	private float m_previousLossyScaleY; // 0x1C24
	[SerializeField] // RVA: 0x140300 Offset: 0x140401 VA: 0x140300
	private Renderer m_renderer; // 0x1C28
	private MeshFilter m_meshFilter; // 0x1C30
	private CanvasRenderer m_CanvasRenderer; // 0x1C38
	private bool m_isFirstAllocation; // 0x1C40
	private int m_max_characters; // 0x1C44
	private int m_max_numberOfLines; // 0x1C48
	private TMP_SubMesh[] m_subTextObjects; // 0x1C50
	[SerializeField] // RVA: 0x140310 Offset: 0x140411 VA: 0x140310
	private MaskingTypes m_maskType; // 0x1C58
	private Matrix4x4 m_EnvMapMatrix; // 0x1C5C
	private Vector3[] m_RectTransformCorners; // 0x1CA0
	private bool m_isRegisteredForEvents; // 0x1CA8
	[SerializeField] // RVA: 0x140320 Offset: 0x140421 VA: 0x140320
	internal int _SortingLayerID; // 0x1CAC
	[SerializeField] // RVA: 0x140330 Offset: 0x140431 VA: 0x140330
	internal int _SortingOrder; // 0x1CB0
	[CompilerGeneratedAttribute] // RVA: 0x140340 Offset: 0x140441 VA: 0x140340
	private Action<TMP_TextInfo> OnPreRenderText; // 0x1CB8
	private bool m_currentAutoSizeMode; // 0x1CC0

	// Properties
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public override bool autoSizeTextContainer { get; set; }
	[ObsoleteAttribute] // RVA: 0x140BA0 Offset: 0x140CA1 VA: 0x140BA0
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }

	// Methods

	// RVA: 0x15A5F70 Offset: 0x15A6071 VA: 0x15A5F70 Slot: 4
	protected override void Awake() { }

	// RVA: 0x15A64C0 Offset: 0x15A65C1 VA: 0x15A64C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x15A66D0 Offset: 0x15A67D1 VA: 0x15A66D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x15A6740 Offset: 0x15A6841 VA: 0x15A6740 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x15A6800 Offset: 0x15A6901 VA: 0x15A6800 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x15A6F20 Offset: 0x15A7021 VA: 0x15A6F20
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x15A7260 Offset: 0x15A7361 VA: 0x15A7260
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x15A7400 Offset: 0x15A7501 VA: 0x15A7400
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x15A74B0 Offset: 0x15A75B1 VA: 0x15A74B0
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x15A75C0 Offset: 0x15A76C1 VA: 0x15A75C0
	private void EnableMasking() { }

	// RVA: 0x15A77D0 Offset: 0x15A78D1 VA: 0x15A77D0
	private void DisableMasking() { }

	// RVA: 0x15A7740 Offset: 0x15A7841 VA: 0x15A7740
	private void UpdateMask() { }

	// RVA: 0x15A7A20 Offset: 0x15A7B21 VA: 0x15A7A20 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x15A7B60 Offset: 0x15A7C61 VA: 0x15A7B60 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x15A7D50 Offset: 0x15A7E51 VA: 0x15A7D50 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x15A7DA0 Offset: 0x15A7EA1 VA: 0x15A7DA0 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x15A7F60 Offset: 0x15A8061 VA: 0x15A7F60 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x15A8330 Offset: 0x15A8431 VA: 0x15A8330 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x15A84B0 Offset: 0x15A85B1 VA: 0x15A84B0 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x15A85D0 Offset: 0x15A86D1 VA: 0x15A85D0 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x15A7950 Offset: 0x15A7A51 VA: 0x15A7950
	private void CreateMaterialInstance() { }

	// RVA: 0x15A86F0 Offset: 0x15A87F1 VA: 0x15A86F0 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x15A8830 Offset: 0x15A8931 VA: 0x15A8830 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x15A8B10 Offset: 0x15A8C11 VA: 0x15A8B10
	private void SetPerspectiveCorrection() { }

	// RVA: 0x15A8BD0 Offset: 0x15A8CD1 VA: 0x15A8BD0 Slot: 114
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x15AAA30 Offset: 0x15AAB31 VA: 0x15AAA30 Slot: 120
	public override void ComputeMarginSize() { }

	// RVA: 0x15AAB70 Offset: 0x15AAC71 VA: 0x15AAB70 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x15AAB90 Offset: 0x15AAC91 VA: 0x15AAB90 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x15AABD0 Offset: 0x15AACD1 VA: 0x15AABD0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x15AADF0 Offset: 0x15AAEF1 VA: 0x15AADF0 Slot: 133
	internal override void InternalUpdate() { }

	// RVA: 0x15AB100 Offset: 0x15AB201 VA: 0x15AB100
	private void OnPreRenderObject() { }

	// RVA: 0x15AB440 Offset: 0x15AB541 VA: 0x15AB440 Slot: 115
	protected override void GenerateTextMesh() { }

	// RVA: 0x15B44A0 Offset: 0x15B45A1 VA: 0x15B44A0 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x15B4560 Offset: 0x15B4661 VA: 0x15B4560
	private void SetMeshFilters(bool state) { }

	// RVA: 0x15B4830 Offset: 0x15B4931 VA: 0x15B4830 Slot: 128
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x15B4950 Offset: 0x15B4A51 VA: 0x15B4950
	protected void SetActiveSubTextObjectRenderers(bool state) { }

	// RVA: 0x15B4AA0 Offset: 0x15B4BA1 VA: 0x15B4AA0 Slot: 129
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x15B4BB0 Offset: 0x15B4CB1 VA: 0x15B4BB0 Slot: 117
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x15AAEF0 Offset: 0x15AAFF1 VA: 0x15AAEF0
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x15B4ED0 Offset: 0x15B4FD1 VA: 0x15B4ED0
	public int get_sortingLayerID() { }

	// RVA: 0x15B50B0 Offset: 0x15B51B1 VA: 0x15B50B0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x15B51E0 Offset: 0x15B52E1 VA: 0x15B51E0
	public int get_sortingOrder() { }

	// RVA: 0x15B5310 Offset: 0x15B5411 VA: 0x15B5310
	public void set_sortingOrder(int value) { }

	// RVA: 0x15B5440 Offset: 0x15B5541 VA: 0x15B5440 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x15B5450 Offset: 0x15B5551 VA: 0x15B5450 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x15B54B0 Offset: 0x15B55B1 VA: 0x15B54B0
	public TextContainer get_textContainer() { }

	// RVA: 0x15A6410 Offset: 0x15A6511 VA: 0x15A6410
	public Transform get_transform() { }

	// RVA: 0x15B5000 Offset: 0x15B5101 VA: 0x15B5000
	public Renderer get_renderer() { }

	// RVA: 0x15B54C0 Offset: 0x15B55C1 VA: 0x15B54C0 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x15A65A0 Offset: 0x15A66A1 VA: 0x15A65A0
	public MeshFilter get_meshFilter() { }

	// RVA: 0x15B5590 Offset: 0x15B5691 VA: 0x15B5590
	public MaskingTypes get_maskType() { }

	// RVA: 0x15B55A0 Offset: 0x15B56A1 VA: 0x15B55A0
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x15B55B0 Offset: 0x15B56B1 VA: 0x15B55B0
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x15B5670 Offset: 0x15B5771 VA: 0x15B5670
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x15B56E0 Offset: 0x15B57E1 VA: 0x15B56E0 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x15B5780 Offset: 0x15B5881 VA: 0x15B5780 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x15B5860 Offset: 0x15B5961 VA: 0x15B5860 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x15B5870 Offset: 0x15B5971 VA: 0x15B5870 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x15B58D0 Offset: 0x15B59D1 VA: 0x15B58D0 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x15B59D0 Offset: 0x15B5AD1 VA: 0x15B59D0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x15B5BA0 Offset: 0x15B5CA1 VA: 0x15B5BA0 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x15B5CC0 Offset: 0x15B5DC1 VA: 0x15B5CC0 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x15B5D00 Offset: 0x15B5E01 VA: 0x15B5D00 Slot: 119
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x15B5D80 Offset: 0x15B5E81 VA: 0x15B5D80 Slot: 131
	public override void ClearMesh(bool updateMesh) { }

	[CompilerGeneratedAttribute] // RVA: 0x140800 Offset: 0x140901 VA: 0x140800
	// RVA: 0x15B5EB0 Offset: 0x15B5FB1 VA: 0x15B5EB0 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x140810 Offset: 0x140911 VA: 0x140810
	// RVA: 0x15B5F60 Offset: 0x15B6061 VA: 0x15B5F60 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x15B6010 Offset: 0x15B6111 VA: 0x15B6010 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x15B6030 Offset: 0x15B6131 VA: 0x15B6030 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x15B61E0 Offset: 0x15B62E1 VA: 0x15B61E0 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x15B6390 Offset: 0x15B6491 VA: 0x15B6390
	public void UpdateFontAsset() { }

	// RVA: 0x15B63A0 Offset: 0x15B64A1 VA: 0x15B63A0 Slot: 134
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x15B63B0 Offset: 0x15B64B1 VA: 0x15B63B0 Slot: 135
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x15B63C0 Offset: 0x15B64C1 VA: 0x15B63C0
	public void .ctor() { }
}

