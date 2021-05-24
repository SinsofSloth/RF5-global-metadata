[AddComponentMenu] // RVA: 0x119E90 Offset: 0x119F91 VA: 0x119E90
public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 3936
{
	// Fields
	protected static Material s_ETC1DefaultUI; // 0x0
	[FormerlySerializedAsAttribute] // RVA: 0x11B660 Offset: 0x11B761 VA: 0x11B660
	[SerializeField] // RVA: 0x11B660 Offset: 0x11B761 VA: 0x11B660
	private Sprite m_Sprite; // 0xC0
	private Sprite m_OverrideSprite; // 0xC8
	[SerializeField] // RVA: 0x11B6B0 Offset: 0x11B7B1 VA: 0x11B6B0
	private Image.Type m_Type; // 0xD0
	[SerializeField] // RVA: 0x11B6C0 Offset: 0x11B7C1 VA: 0x11B6C0
	private bool m_PreserveAspect; // 0xD4
	[SerializeField] // RVA: 0x11B6D0 Offset: 0x11B7D1 VA: 0x11B6D0
	private bool m_FillCenter; // 0xD5
	[SerializeField] // RVA: 0x11B6E0 Offset: 0x11B7E1 VA: 0x11B6E0
	private Image.FillMethod m_FillMethod; // 0xD8
	[RangeAttribute] // RVA: 0x11B6F0 Offset: 0x11B7F1 VA: 0x11B6F0
	[SerializeField] // RVA: 0x11B6F0 Offset: 0x11B7F1 VA: 0x11B6F0
	private float m_FillAmount; // 0xDC
	[SerializeField] // RVA: 0x11B730 Offset: 0x11B831 VA: 0x11B730
	private bool m_FillClockwise; // 0xE0
	[SerializeField] // RVA: 0x11B740 Offset: 0x11B841 VA: 0x11B740
	private int m_FillOrigin; // 0xE4
	private float m_AlphaHitTestMinimumThreshold; // 0xE8
	private bool m_Tracked; // 0xEC
	[SerializeField] // RVA: 0x11B750 Offset: 0x11B851 VA: 0x11B750
	private bool m_UseSpriteMesh; // 0xED
	[SerializeField] // RVA: 0x11B760 Offset: 0x11B861 VA: 0x11B760
	private float m_PixelsPerUnitMultiplier; // 0xF0
	private float m_CachedReferencePixelsPerUnit; // 0xF4
	private static readonly Vector2[] s_VertScratch; // 0x8
	private static readonly Vector2[] s_UVScratch; // 0x10
	private static readonly Vector3[] s_Xy; // 0x18
	private static readonly Vector3[] s_Uv; // 0x20
	private static List<Image> m_TrackedTexturelessImages; // 0x28
	private static bool s_Initialized; // 0x30

	// Properties
	public Sprite sprite { get; set; }
	public Sprite overrideSprite { get; set; }
	private Sprite activeSprite { get; }
	public Image.Type type { get; set; }
	public bool preserveAspect { get; set; }
	public bool fillCenter { get; set; }
	public Image.FillMethod fillMethod { get; set; }
	public float fillAmount { get; set; }
	public bool fillClockwise { get; set; }
	public int fillOrigin { get; set; }
	[ObsoleteAttribute] // RVA: 0x11D9C0 Offset: 0x11DAC1 VA: 0x11D9C0
	public float eventAlphaThreshold { get; set; }
	public float alphaHitTestMinimumThreshold { get; set; }
	public bool useSpriteMesh { get; set; }
	public static Material defaultETC1GraphicMaterial { get; }
	public override Texture mainTexture { get; }
	public bool hasBorder { get; }
	public float pixelsPerUnitMultiplier { get; set; }
	public float pixelsPerUnit { get; }
	protected float multipliedPixelsPerUnit { get; }
	public override Material material { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x186CD40 Offset: 0x186CE41 VA: 0x186CD40
	public Sprite get_sprite() { }

	// RVA: 0x186CD50 Offset: 0x186CE51 VA: 0x186CD50
	public void set_sprite(Sprite value) { }

	// RVA: 0x186D240 Offset: 0x186D341 VA: 0x186D240
	public void DisableSpriteOptimizations() { }

	// RVA: 0x186D250 Offset: 0x186D351 VA: 0x186D250
	public Sprite get_overrideSprite() { }

	// RVA: 0x186D370 Offset: 0x186D471 VA: 0x186D370
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x186D2E0 Offset: 0x186D3E1 VA: 0x186D2E0
	private Sprite get_activeSprite() { }

	// RVA: 0x186D400 Offset: 0x186D501 VA: 0x186D400
	public Image.Type get_type() { }

	// RVA: 0x186D410 Offset: 0x186D511 VA: 0x186D410
	public void set_type(Image.Type value) { }

	// RVA: 0x186D4A0 Offset: 0x186D5A1 VA: 0x186D4A0
	public bool get_preserveAspect() { }

	// RVA: 0x186D4B0 Offset: 0x186D5B1 VA: 0x186D4B0
	public void set_preserveAspect(bool value) { }

	// RVA: 0x186D540 Offset: 0x186D641 VA: 0x186D540
	public bool get_fillCenter() { }

	// RVA: 0x186D550 Offset: 0x186D651 VA: 0x186D550
	public void set_fillCenter(bool value) { }

	// RVA: 0x186D5E0 Offset: 0x186D6E1 VA: 0x186D5E0
	public Image.FillMethod get_fillMethod() { }

	// RVA: 0x186D5F0 Offset: 0x186D6F1 VA: 0x186D5F0
	public void set_fillMethod(Image.FillMethod value) { }

	// RVA: 0x186D670 Offset: 0x186D771 VA: 0x186D670
	public float get_fillAmount() { }

	// RVA: 0x186D680 Offset: 0x186D781 VA: 0x186D680
	public void set_fillAmount(float value) { }

	// RVA: 0x186D740 Offset: 0x186D841 VA: 0x186D740
	public bool get_fillClockwise() { }

	// RVA: 0x186D750 Offset: 0x186D851 VA: 0x186D750
	public void set_fillClockwise(bool value) { }

	// RVA: 0x186D7E0 Offset: 0x186D8E1 VA: 0x186D7E0
	public int get_fillOrigin() { }

	// RVA: 0x186D7F0 Offset: 0x186D8F1 VA: 0x186D7F0
	public void set_fillOrigin(int value) { }

	// RVA: 0x186D880 Offset: 0x186D981 VA: 0x186D880
	public float get_eventAlphaThreshold() { }

	// RVA: 0x186D890 Offset: 0x186D991 VA: 0x186D890
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x186D8A0 Offset: 0x186D9A1 VA: 0x186D8A0
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x186D8B0 Offset: 0x186D9B1 VA: 0x186D8B0
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x186D8C0 Offset: 0x186D9C1 VA: 0x186D8C0
	public bool get_useSpriteMesh() { }

	// RVA: 0x186D8D0 Offset: 0x186D9D1 VA: 0x186D8D0
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x186D960 Offset: 0x186DA61 VA: 0x186D960
	protected void .ctor() { }

	// RVA: 0x186D9B0 Offset: 0x186DAB1 VA: 0x186D9B0
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x186DAB0 Offset: 0x186DBB1 VA: 0x186DAB0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x186DD00 Offset: 0x186DE01 VA: 0x186DD00
	public bool get_hasBorder() { }

	// RVA: 0x186DE90 Offset: 0x186DF91 VA: 0x186DE90
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x186DEA0 Offset: 0x186DFA1 VA: 0x186DEA0
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x186DF30 Offset: 0x186E031 VA: 0x186DF30
	public float get_pixelsPerUnit() { }

	// RVA: 0x186E1D0 Offset: 0x186E2D1 VA: 0x186E1D0
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x186E200 Offset: 0x186E301 VA: 0x186E200 Slot: 32
	public override Material get_material() { }

	// RVA: 0x186E420 Offset: 0x186E521 VA: 0x186E420 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x186E4E0 Offset: 0x186E5E1 VA: 0x186E4E0 Slot: 77
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x186E4F0 Offset: 0x186E5F1 VA: 0x186E4F0 Slot: 78
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x186E5B0 Offset: 0x186E6B1 VA: 0x186E5B0
	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	// RVA: 0x186E7C0 Offset: 0x186E8C1 VA: 0x186E7C0
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x186ECD0 Offset: 0x186EDD1 VA: 0x186ECD0 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x186F060 Offset: 0x186F161 VA: 0x186F060 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x186D080 Offset: 0x186D181 VA: 0x186D080
	private void TrackSprite() { }

	// RVA: 0x1872EC0 Offset: 0x1872FC1 VA: 0x1872EC0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1872EF0 Offset: 0x1872FF1 VA: 0x1872EF0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1873070 Offset: 0x1873171 VA: 0x1873070 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x18732E0 Offset: 0x18733E1 VA: 0x18732E0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x186F210 Offset: 0x186F311 VA: 0x186F210
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x186F610 Offset: 0x186F711 VA: 0x186F610
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x186FD50 Offset: 0x186FE51 VA: 0x186FD50
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x18707B0 Offset: 0x18708B1 VA: 0x18707B0
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x1873AE0 Offset: 0x1873BE1 VA: 0x1873AE0
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x18738C0 Offset: 0x18739C1 VA: 0x18738C0
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x1873500 Offset: 0x1873601 VA: 0x1873500
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x1871E50 Offset: 0x1871F51 VA: 0x1871E50
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x1873DA0 Offset: 0x1873EA1 VA: 0x1873DA0
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x1873F10 Offset: 0x1874011 VA: 0x1873F10
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x18744B0 Offset: 0x18745B1 VA: 0x18744B0 Slot: 79
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18744C0 Offset: 0x18745C1 VA: 0x18744C0 Slot: 80
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x18744D0 Offset: 0x18745D1 VA: 0x18744D0 Slot: 81
	public virtual float get_minWidth() { }

	// RVA: 0x18744E0 Offset: 0x18745E1 VA: 0x18744E0 Slot: 82
	public virtual float get_preferredWidth() { }

	// RVA: 0x18746F0 Offset: 0x18747F1 VA: 0x18746F0 Slot: 83
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1874700 Offset: 0x1874801 VA: 0x1874700 Slot: 84
	public virtual float get_minHeight() { }

	// RVA: 0x1874710 Offset: 0x1874811 VA: 0x1874710 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x1874920 Offset: 0x1874A21 VA: 0x1874920 Slot: 86
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1874930 Offset: 0x1874A31 VA: 0x1874930 Slot: 87
	public virtual int get_layoutPriority() { }

	// RVA: 0x1874940 Offset: 0x1874A41 VA: 0x1874940 Slot: 88
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x1874F80 Offset: 0x1875081 VA: 0x1874F80
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x1875540 Offset: 0x1875641 VA: 0x1875540
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x1872D60 Offset: 0x1872E61 VA: 0x1872D60
	private static void TrackImage(Image g) { }

	// RVA: 0x1872FE0 Offset: 0x18730E1 VA: 0x1872FE0
	private static void UnTrackImage(Image g) { }

	// RVA: 0x18757D0 Offset: 0x18758D1 VA: 0x18757D0 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1875810 Offset: 0x1875911 VA: 0x1875810
	private static void .cctor() { }
}

