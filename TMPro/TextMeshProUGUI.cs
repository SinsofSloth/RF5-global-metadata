[DisallowMultipleComponent] // RVA: 0x13EF80 Offset: 0x13F081 VA: 0x13EF80
[RequireComponent] // RVA: 0x13EF80 Offset: 0x13F081 VA: 0x13EF80
[RequireComponent] // RVA: 0x13EF80 Offset: 0x13F081 VA: 0x13EF80
[AddComponentMenu] // RVA: 0x13EF80 Offset: 0x13F081 VA: 0x13EF80
[ExecuteAlways] // RVA: 0x13EF80 Offset: 0x13F081 VA: 0x13EF80
[HelpURLAttribute] // RVA: 0x13EF80 Offset: 0x13F081 VA: 0x13EF80
public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 5900
{
	// Fields
	[SerializeField] // RVA: 0x140350 Offset: 0x140451 VA: 0x140350
	private bool m_hasFontAssetChanged; // 0x1C20
	protected TMP_SubMeshUI[] m_subTextObjects; // 0x1C28
	private float m_previousLossyScaleY; // 0x1C30
	private Vector3[] m_RectTransformCorners; // 0x1C38
	private CanvasRenderer m_canvasRenderer; // 0x1C40
	private Canvas m_canvas; // 0x1C48
	private bool m_isFirstAllocation; // 0x1C50
	private int m_max_characters; // 0x1C54
	[SerializeField] // RVA: 0x140360 Offset: 0x140461 VA: 0x140360
	private Material m_baseMaterial; // 0x1C58
	private bool m_isScrollRegionSet; // 0x1C60
	[SerializeField] // RVA: 0x140370 Offset: 0x140471 VA: 0x140370
	private Vector4 m_maskOffset; // 0x1C64
	private Matrix4x4 m_EnvMapMatrix; // 0x1C74
	private bool m_isRegisteredForEvents; // 0x1CB4
	private bool m_isRebuildingLayout; // 0x1CB5
	private Coroutine m_DelayedGraphicRebuild; // 0x1CB8
	private Coroutine m_DelayedMaterialRebuild; // 0x1CC0
	private Rect m_ClipRect; // 0x1CC8
	private bool m_ValidRect; // 0x1CD8
	[CompilerGeneratedAttribute] // RVA: 0x140380 Offset: 0x140481 VA: 0x140380
	private Action<TMP_TextInfo> OnPreRenderText; // 0x1CE0

	// Properties
	public override Material materialForRendering { get; }
	public override bool autoSizeTextContainer { get; set; }
	public override Mesh mesh { get; }
	public CanvasRenderer canvasRenderer { get; }
	public Vector4 maskOffset { get; set; }

	// Methods

	// RVA: 0x1834CC0 Offset: 0x1834DC1 VA: 0x1834CC0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1835060 Offset: 0x1835161 VA: 0x1835060 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1835300 Offset: 0x1835401 VA: 0x1835300 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1835480 Offset: 0x1835581 VA: 0x1835480 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x18355F0 Offset: 0x18356F1 VA: 0x18355F0 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x18351A0 Offset: 0x18352A1 VA: 0x18351A0
	private Canvas GetCanvas() { }

	// RVA: 0x1835C70 Offset: 0x1835D71 VA: 0x1835C70
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x1835FB0 Offset: 0x18360B1 VA: 0x1835FB0
	private void EnableMasking() { }

	// RVA: 0x18366A0 Offset: 0x18367A1 VA: 0x18366A0
	private void DisableMasking() { }

	// RVA: 0x18361A0 Offset: 0x18362A1 VA: 0x18361A0
	private void UpdateMask() { }

	// RVA: 0x18366B0 Offset: 0x18367B1 VA: 0x18366B0 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x1836820 Offset: 0x1836921 VA: 0x1836820 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x1836A10 Offset: 0x1836B11 VA: 0x1836A10 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x1836A60 Offset: 0x1836B61 VA: 0x1836A60 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x1836C20 Offset: 0x1836D21 VA: 0x1836C20 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x18370B0 Offset: 0x18371B1 VA: 0x18370B0 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x1837310 Offset: 0x1837411 VA: 0x1837310 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x1837440 Offset: 0x1837541 VA: 0x1837440 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x1837570 Offset: 0x1837671 VA: 0x1837570 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x18376D0 Offset: 0x18377D1 VA: 0x18376D0 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x1837A00 Offset: 0x1837B01 VA: 0x1837A00
	private void SetPerspectiveCorrection() { }

	// RVA: 0x1837AC0 Offset: 0x1837BC1 VA: 0x1837AC0
	private void SetMeshArrays(int size) { }

	// RVA: 0x1837B40 Offset: 0x1837C41 VA: 0x1837B40 Slot: 114
	protected override int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x1839AB0 Offset: 0x1839BB1 VA: 0x1839AB0 Slot: 120
	public override void ComputeMarginSize() { }

	// RVA: 0x1839BF0 Offset: 0x1839CF1 VA: 0x1839BF0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1839C40 Offset: 0x1839D41 VA: 0x1839C40 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1839D60 Offset: 0x1839E61 VA: 0x1839D60 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1839DC0 Offset: 0x1839EC1 VA: 0x1839DC0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x183A0F0 Offset: 0x183A1F1 VA: 0x183A0F0 Slot: 133
	internal override void InternalUpdate() { }

	// RVA: 0x183A490 Offset: 0x183A591 VA: 0x183A490
	private void OnPreRenderCanvas() { }

	// RVA: 0x183A770 Offset: 0x183A871 VA: 0x183A770 Slot: 115
	protected override void GenerateTextMesh() { }

	// RVA: 0x1843A70 Offset: 0x1843B71 VA: 0x1843A70 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x1843B30 Offset: 0x1843C31 VA: 0x1843B30 Slot: 128
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1843C50 Offset: 0x1843D51 VA: 0x1843C50 Slot: 129
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x1843D60 Offset: 0x1843E61 VA: 0x1843D60 Slot: 117
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x1844080 Offset: 0x1844181 VA: 0x1844080 Slot: 118
	internal override Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x183A1F0 Offset: 0x183A2F1 VA: 0x183A1F0
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x1844340 Offset: 0x1844441 VA: 0x1844340 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x18443B0 Offset: 0x18444B1 VA: 0x18443B0 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x18443C0 Offset: 0x18444C1 VA: 0x18443C0 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x1844480 Offset: 0x1844581 VA: 0x1844480 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x1844490 Offset: 0x1844591 VA: 0x1844490
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x1844540 Offset: 0x1844641 VA: 0x1844540 Slot: 134
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1844550 Offset: 0x1844651 VA: 0x1844550 Slot: 135
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1844560 Offset: 0x1844661 VA: 0x1844560 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x1844780 Offset: 0x1844881 VA: 0x1844780 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x1844870 Offset: 0x1844971 VA: 0x1844870 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x1844AA0 Offset: 0x1844BA1 VA: 0x1844AA0 Slot: 26
	public override void SetAllDirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x140820 Offset: 0x140921 VA: 0x140820
	// RVA: 0x1844700 Offset: 0x1844801 VA: 0x1844700
	private IEnumerator DelayedGraphicRebuild() { }

	[IteratorStateMachineAttribute] // RVA: 0x140890 Offset: 0x140991 VA: 0x140890
	// RVA: 0x1844A20 Offset: 0x1844B21 VA: 0x1844A20
	private IEnumerator DelayedMaterialRebuild() { }

	// RVA: 0x1844B60 Offset: 0x1844C61 VA: 0x1844B60 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1839FF0 Offset: 0x183A0F1 VA: 0x1839FF0
	private void UpdateSubObjectPivot() { }

	// RVA: 0x1844C60 Offset: 0x1844D61 VA: 0x1844C60 Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1844DA0 Offset: 0x1844EA1 VA: 0x1844DA0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1844F30 Offset: 0x1845031 VA: 0x1844F30
	public Vector4 get_maskOffset() { }

	// RVA: 0x1844F50 Offset: 0x1845051 VA: 0x1844F50
	public void set_maskOffset(Vector4 value) { }

	// RVA: 0x1844F90 Offset: 0x1845091 VA: 0x1844F90 Slot: 63
	public override void RecalculateClipping() { }

	// RVA: 0x1844FA0 Offset: 0x18450A1 VA: 0x1844FA0 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x18451E0 Offset: 0x18452E1 VA: 0x18451E0 Slot: 102
	internal override void UpdateCulling() { }

	// RVA: 0x18453D0 Offset: 0x18454D1 VA: 0x18453D0 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x18454F0 Offset: 0x18455F1 VA: 0x18454F0 Slot: 112
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x18455E0 Offset: 0x18456E1 VA: 0x18455E0 Slot: 113
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x1845690 Offset: 0x1845791 VA: 0x1845690 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x1845780 Offset: 0x1845881 VA: 0x1845780 Slot: 119
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x1845890 Offset: 0x1845991 VA: 0x1845890 Slot: 130
	public override void ClearMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x140900 Offset: 0x140A01 VA: 0x140900
	// RVA: 0x18459A0 Offset: 0x1845AA1 VA: 0x18459A0 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x140910 Offset: 0x140A11 VA: 0x140910
	// RVA: 0x1845A50 Offset: 0x1845B51 VA: 0x1845A50 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x1845B00 Offset: 0x1845C01 VA: 0x1845B00 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1845B90 Offset: 0x1845C91 VA: 0x1845B90 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x1845D90 Offset: 0x1845E91 VA: 0x1845D90 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x1845F80 Offset: 0x1846081 VA: 0x1845F80
	public void UpdateFontAsset() { }

	// RVA: 0x1845F90 Offset: 0x1846091 VA: 0x1845F90
	public void .ctor() { }
}

