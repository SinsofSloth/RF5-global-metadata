[DisallowMultipleComponent] // RVA: 0x119CB0 Offset: 0x119DB1 VA: 0x119CB0
[RequireComponent] // RVA: 0x119CB0 Offset: 0x119DB1 VA: 0x119CB0
[RequireComponent] // RVA: 0x119CB0 Offset: 0x119DB1 VA: 0x119CB0
[ExecuteAlways] // RVA: 0x119CB0 Offset: 0x119DB1 VA: 0x119CB0
public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 3928
{
	// Fields
	protected static Material s_DefaultUI; // 0x0
	protected static Texture2D s_WhiteTexture; // 0x8
	[FormerlySerializedAsAttribute] // RVA: 0x11B530 Offset: 0x11B631 VA: 0x11B530
	[SerializeField] // RVA: 0x11B530 Offset: 0x11B631 VA: 0x11B530
	protected Material m_Material; // 0x18
	[SerializeField] // RVA: 0x11B580 Offset: 0x11B681 VA: 0x11B580
	private Color m_Color; // 0x20
	protected bool m_SkipLayoutUpdate; // 0x30
	protected bool m_SkipMaterialUpdate; // 0x31
	[SerializeField] // RVA: 0x11B590 Offset: 0x11B691 VA: 0x11B590
	private bool m_RaycastTarget; // 0x32
	private RectTransform m_RectTransform; // 0x38
	private CanvasRenderer m_CanvasRenderer; // 0x40
	private Canvas m_Canvas; // 0x48
	private bool m_VertsDirty; // 0x50
	private bool m_MaterialDirty; // 0x51
	protected UnityAction m_OnDirtyLayoutCallback; // 0x58
	protected UnityAction m_OnDirtyVertsCallback; // 0x60
	protected UnityAction m_OnDirtyMaterialCallback; // 0x68
	protected static Mesh s_Mesh; // 0x10
	private static readonly VertexHelper s_VertexHelper; // 0x18
	protected Mesh m_CachedMesh; // 0x70
	protected Vector2[] m_CachedUvs; // 0x78
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x11B5A0 Offset: 0x11B6A1 VA: 0x11B5A0
	private bool <useLegacyMeshGeneration>k__BackingField; // 0x88

	// Properties
	public static Material defaultGraphicMaterial { get; }
	public virtual Color color { get; set; }
	public virtual bool raycastTarget { get; set; }
	protected bool useLegacyMeshGeneration { get; set; }
	public int depth { get; }
	public RectTransform rectTransform { get; }
	public Canvas canvas { get; }
	public CanvasRenderer canvasRenderer { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Material material { get; set; }
	public virtual Material materialForRendering { get; }
	public virtual Texture mainTexture { get; }
	protected static Mesh workerMesh { get; }

	// Methods

	// RVA: 0x18646E0 Offset: 0x18647E1 VA: 0x18646E0
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0x18647E0 Offset: 0x18648E1 VA: 0x18647E0 Slot: 22
	public virtual Color get_color() { }

	// RVA: 0x18647F0 Offset: 0x18648F1 VA: 0x18647F0 Slot: 23
	public virtual void set_color(Color value) { }

	// RVA: 0x1864840 Offset: 0x1864941 VA: 0x1864840 Slot: 24
	public virtual bool get_raycastTarget() { }

	// RVA: 0x1864850 Offset: 0x1864951 VA: 0x1864850 Slot: 25
	public virtual void set_raycastTarget(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11CEB0 Offset: 0x11CFB1 VA: 0x11CEB0
	// RVA: 0x1864860 Offset: 0x1864961 VA: 0x1864860
	protected bool get_useLegacyMeshGeneration() { }

	[CompilerGeneratedAttribute] // RVA: 0x11CEC0 Offset: 0x11CFC1 VA: 0x11CEC0
	// RVA: 0x1864870 Offset: 0x1864971 VA: 0x1864870
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x1864880 Offset: 0x1864981 VA: 0x1864880
	protected void .ctor() { }

	// RVA: 0x1864950 Offset: 0x1864A51 VA: 0x1864950 Slot: 26
	public virtual void SetAllDirty() { }

	// RVA: 0x18649D0 Offset: 0x1864AD1 VA: 0x18649D0 Slot: 27
	public virtual void SetLayoutDirty() { }

	// RVA: 0x1864B60 Offset: 0x1864C61 VA: 0x1864B60 Slot: 28
	public virtual void SetVerticesDirty() { }

	// RVA: 0x1864C00 Offset: 0x1864D01 VA: 0x1864C00 Slot: 29
	public virtual void SetMaterialDirty() { }

	// RVA: 0x1864CA0 Offset: 0x1864DA1 VA: 0x1864CA0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1864D60 Offset: 0x1864E61 VA: 0x1864D60 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x18650B0 Offset: 0x18651B1 VA: 0x18650B0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18654F0 Offset: 0x18655F1 VA: 0x18654F0
	public int get_depth() { }

	// RVA: 0x1864AD0 Offset: 0x1864BD1 VA: 0x1864AD0 Slot: 30
	public RectTransform get_rectTransform() { }

	// RVA: 0x1864EC0 Offset: 0x1864FC1 VA: 0x1864EC0
	public Canvas get_canvas() { }

	// RVA: 0x18651F0 Offset: 0x18652F1 VA: 0x18651F0
	private void CacheCanvas() { }

	// RVA: 0x1865570 Offset: 0x1865671 VA: 0x1865570
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x1865600 Offset: 0x1865701 VA: 0x1865600 Slot: 31
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x1865670 Offset: 0x1865771 VA: 0x1865670 Slot: 32
	public virtual Material get_material() { }

	// RVA: 0x1865710 Offset: 0x1865811 VA: 0x1865710 Slot: 33
	public virtual void set_material(Material value) { }

	// RVA: 0x18657D0 Offset: 0x18658D1 VA: 0x18657D0 Slot: 34
	public virtual Material get_materialForRendering() { }

	// RVA: 0x18659D0 Offset: 0x1865AD1 VA: 0x18659D0 Slot: 35
	public virtual Texture get_mainTexture() { }

	// RVA: 0x1865A40 Offset: 0x1865B41 VA: 0x1865A40 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1865BD0 Offset: 0x1865CD1 VA: 0x1865BD0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1865E70 Offset: 0x1865F71 VA: 0x1865E70 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1865F50 Offset: 0x1866051 VA: 0x1865F50 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x18660E0 Offset: 0x18661E1 VA: 0x18660E0 Slot: 36
	public virtual void OnCullingChanged() { }

	// RVA: 0x18661F0 Offset: 0x18662F1 VA: 0x18661F0 Slot: 37
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x18663A0 Offset: 0x18664A1 VA: 0x18663A0 Slot: 38
	public virtual void LayoutComplete() { }

	// RVA: 0x18663B0 Offset: 0x18664B1 VA: 0x18663B0 Slot: 39
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18663C0 Offset: 0x18664C1 VA: 0x18663C0 Slot: 40
	protected virtual void UpdateMaterial() { }

	// RVA: 0x1866560 Offset: 0x1866661 VA: 0x1866560 Slot: 41
	protected virtual void UpdateGeometry() { }

	// RVA: 0x1866A50 Offset: 0x1866B51 VA: 0x1866A50
	private void DoMeshGeneration() { }

	// RVA: 0x1866570 Offset: 0x1866671 VA: 0x1866570
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x1866F70 Offset: 0x1867071 VA: 0x1866F70
	protected static Mesh get_workerMesh() { }

	[EditorBrowsableAttribute] // RVA: 0x11CED0 Offset: 0x11CFD1 VA: 0x11CED0
	[ObsoleteAttribute] // RVA: 0x11CED0 Offset: 0x11CFD1 VA: 0x11CED0
	// RVA: 0x18670C0 Offset: 0x18671C1 VA: 0x18670C0 Slot: 42
	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	[ObsoleteAttribute] // RVA: 0x11CF30 Offset: 0x11D031 VA: 0x11CF30
	// RVA: 0x18670D0 Offset: 0x18671D1 VA: 0x18670D0 Slot: 43
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x1867180 Offset: 0x1867281 VA: 0x1867180 Slot: 44
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x18677B0 Offset: 0x18678B1 VA: 0x18677B0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18677C0 Offset: 0x18678C1 VA: 0x18677C0 Slot: 45
	public virtual void SetNativeSize() { }

	// RVA: 0x18677D0 Offset: 0x18678D1 VA: 0x18677D0 Slot: 46
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1867CA0 Offset: 0x1867DA1 VA: 0x1867CA0
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x18673F0 Offset: 0x18674F1 VA: 0x18673F0
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x1867FA0 Offset: 0x18680A1 VA: 0x1867FA0 Slot: 47
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x1867FC0 Offset: 0x18680C1 VA: 0x1867FC0 Slot: 48
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x1868340 Offset: 0x1868441 VA: 0x1868340
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x1868370 Offset: 0x1868471 VA: 0x1868370 Slot: 49
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x1868420 Offset: 0x1868521 VA: 0x1868420
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x18684B0 Offset: 0x18685B1 VA: 0x18684B0
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x1868540 Offset: 0x1868641 VA: 0x1868540
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x18685D0 Offset: 0x18686D1 VA: 0x18685D0
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x1868660 Offset: 0x1868761 VA: 0x1868660
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x18686F0 Offset: 0x18687F1 VA: 0x18686F0
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x1868780 Offset: 0x1868881 VA: 0x1868780
	private static void .cctor() { }

	// RVA: 0x1868820 Offset: 0x1868921 VA: 0x1868820 Slot: 18
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

