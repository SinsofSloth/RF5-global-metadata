[AddComponentMenu] // RVA: 0x11A4B0 Offset: 0x11A5B1 VA: 0x11A4B0
[SelectionBaseAttribute] // RVA: 0x11A4B0 Offset: 0x11A5B1 VA: 0x11A4B0
[ExecuteAlways] // RVA: 0x11A4B0 Offset: 0x11A5B1 VA: 0x11A4B0
[DisallowMultipleComponent] // RVA: 0x11A4B0 Offset: 0x11A5B1 VA: 0x11A4B0
[RequireComponent] // RVA: 0x11A4B0 Offset: 0x11A5B1 VA: 0x11A4B0
public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 3993
{
	// Fields
	[SerializeField] // RVA: 0x11C330 Offset: 0x11C431 VA: 0x11C330
	private RectTransform m_Content; // 0x18
	[SerializeField] // RVA: 0x11C340 Offset: 0x11C441 VA: 0x11C340
	private bool m_Horizontal; // 0x20
	[SerializeField] // RVA: 0x11C350 Offset: 0x11C451 VA: 0x11C350
	private bool m_Vertical; // 0x21
	[SerializeField] // RVA: 0x11C360 Offset: 0x11C461 VA: 0x11C360
	private ScrollRect.MovementType m_MovementType; // 0x24
	[SerializeField] // RVA: 0x11C370 Offset: 0x11C471 VA: 0x11C370
	private float m_Elasticity; // 0x28
	[SerializeField] // RVA: 0x11C380 Offset: 0x11C481 VA: 0x11C380
	private bool m_Inertia; // 0x2C
	[SerializeField] // RVA: 0x11C390 Offset: 0x11C491 VA: 0x11C390
	private float m_DecelerationRate; // 0x30
	[SerializeField] // RVA: 0x11C3A0 Offset: 0x11C4A1 VA: 0x11C3A0
	private float m_ScrollSensitivity; // 0x34
	[SerializeField] // RVA: 0x11C3B0 Offset: 0x11C4B1 VA: 0x11C3B0
	private RectTransform m_Viewport; // 0x38
	[SerializeField] // RVA: 0x11C3C0 Offset: 0x11C4C1 VA: 0x11C3C0
	private Scrollbar m_HorizontalScrollbar; // 0x40
	[SerializeField] // RVA: 0x11C3D0 Offset: 0x11C4D1 VA: 0x11C3D0
	private Scrollbar m_VerticalScrollbar; // 0x48
	[SerializeField] // RVA: 0x11C3E0 Offset: 0x11C4E1 VA: 0x11C3E0
	private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x50
	[SerializeField] // RVA: 0x11C3F0 Offset: 0x11C4F1 VA: 0x11C3F0
	private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x54
	[SerializeField] // RVA: 0x11C400 Offset: 0x11C501 VA: 0x11C400
	private float m_HorizontalScrollbarSpacing; // 0x58
	[SerializeField] // RVA: 0x11C410 Offset: 0x11C511 VA: 0x11C410
	private float m_VerticalScrollbarSpacing; // 0x5C
	[SerializeField] // RVA: 0x11C420 Offset: 0x11C521 VA: 0x11C420
	private ScrollRect.ScrollRectEvent m_OnValueChanged; // 0x60
	private Vector2 m_PointerStartLocalCursor; // 0x68
	protected Vector2 m_ContentStartPosition; // 0x70
	private RectTransform m_ViewRect; // 0x78
	protected Bounds m_ContentBounds; // 0x80
	private Bounds m_ViewBounds; // 0x98
	private Vector2 m_Velocity; // 0xB0
	private bool m_Dragging; // 0xB8
	private bool m_Scrolling; // 0xB9
	private Vector2 m_PrevPosition; // 0xBC
	private Bounds m_PrevContentBounds; // 0xC4
	private Bounds m_PrevViewBounds; // 0xDC
	private bool m_HasRebuiltLayout; // 0xF4
	private bool m_HSliderExpand; // 0xF5
	private bool m_VSliderExpand; // 0xF6
	private float m_HSliderHeight; // 0xF8
	private float m_VSliderWidth; // 0xFC
	private RectTransform m_Rect; // 0x100
	private RectTransform m_HorizontalScrollbarRect; // 0x108
	private RectTransform m_VerticalScrollbarRect; // 0x110
	private DrivenRectTransformTracker m_Tracker; // 0x118
	private readonly Vector3[] m_Corners; // 0x120

	// Properties
	public RectTransform content { get; set; }
	public bool horizontal { get; set; }
	public bool vertical { get; set; }
	public ScrollRect.MovementType movementType { get; set; }
	public float elasticity { get; set; }
	public bool inertia { get; set; }
	public float decelerationRate { get; set; }
	public float scrollSensitivity { get; set; }
	public RectTransform viewport { get; set; }
	public Scrollbar horizontalScrollbar { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
	public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
	public float horizontalScrollbarSpacing { get; set; }
	public float verticalScrollbarSpacing { get; set; }
	public ScrollRect.ScrollRectEvent onValueChanged { get; set; }
	protected RectTransform viewRect { get; }
	public Vector2 velocity { get; set; }
	private RectTransform rectTransform { get; }
	public Vector2 normalizedPosition { get; set; }
	public float horizontalNormalizedPosition { get; set; }
	public float verticalNormalizedPosition { get; set; }
	private bool hScrollingNeeded { get; }
	private bool vScrollingNeeded { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x18C80D0 Offset: 0x18C81D1 VA: 0x18C80D0
	public RectTransform get_content() { }

	// RVA: 0x18C80E0 Offset: 0x18C81E1 VA: 0x18C80E0
	public void set_content(RectTransform value) { }

	// RVA: 0x18C80F0 Offset: 0x18C81F1 VA: 0x18C80F0
	public bool get_horizontal() { }

	// RVA: 0x18C8100 Offset: 0x18C8201 VA: 0x18C8100
	public void set_horizontal(bool value) { }

	// RVA: 0x18C8110 Offset: 0x18C8211 VA: 0x18C8110
	public bool get_vertical() { }

	// RVA: 0x18C8120 Offset: 0x18C8221 VA: 0x18C8120
	public void set_vertical(bool value) { }

	// RVA: 0x18C8130 Offset: 0x18C8231 VA: 0x18C8130
	public ScrollRect.MovementType get_movementType() { }

	// RVA: 0x18C8140 Offset: 0x18C8241 VA: 0x18C8140
	public void set_movementType(ScrollRect.MovementType value) { }

	// RVA: 0x18C8150 Offset: 0x18C8251 VA: 0x18C8150
	public float get_elasticity() { }

	// RVA: 0x18C8160 Offset: 0x18C8261 VA: 0x18C8160
	public void set_elasticity(float value) { }

	// RVA: 0x18C8170 Offset: 0x18C8271 VA: 0x18C8170
	public bool get_inertia() { }

	// RVA: 0x18C8180 Offset: 0x18C8281 VA: 0x18C8180
	public void set_inertia(bool value) { }

	// RVA: 0x18C8190 Offset: 0x18C8291 VA: 0x18C8190
	public float get_decelerationRate() { }

	// RVA: 0x18C81A0 Offset: 0x18C82A1 VA: 0x18C81A0
	public void set_decelerationRate(float value) { }

	// RVA: 0x18C81B0 Offset: 0x18C82B1 VA: 0x18C81B0
	public float get_scrollSensitivity() { }

	// RVA: 0x18C81C0 Offset: 0x18C82C1 VA: 0x18C81C0
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x18C81D0 Offset: 0x18C82D1 VA: 0x18C81D0
	public RectTransform get_viewport() { }

	// RVA: 0x18C81E0 Offset: 0x18C82E1 VA: 0x18C81E0
	public void set_viewport(RectTransform value) { }

	// RVA: 0x18C8370 Offset: 0x18C8471 VA: 0x18C8370
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x18C8380 Offset: 0x18C8481 VA: 0x18C8380
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x18C8530 Offset: 0x18C8631 VA: 0x18C8530
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x18C8540 Offset: 0x18C8641 VA: 0x18C8540
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x18C86F0 Offset: 0x18C87F1 VA: 0x18C86F0
	public ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x18C8700 Offset: 0x18C8801 VA: 0x18C8700
	public void set_horizontalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x18C8710 Offset: 0x18C8811 VA: 0x18C8710
	public ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x18C8720 Offset: 0x18C8821 VA: 0x18C8720
	public void set_verticalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x18C8730 Offset: 0x18C8831 VA: 0x18C8730
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x18C8740 Offset: 0x18C8841 VA: 0x18C8740
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x18C8870 Offset: 0x18C8971 VA: 0x18C8870
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x18C8880 Offset: 0x18C8981 VA: 0x18C8880
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x18C8890 Offset: 0x18C8991 VA: 0x18C8890
	public ScrollRect.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x18C88A0 Offset: 0x18C89A1 VA: 0x18C88A0
	public void set_onValueChanged(ScrollRect.ScrollRectEvent value) { }

	// RVA: 0x18C88B0 Offset: 0x18C89B1 VA: 0x18C88B0
	protected RectTransform get_viewRect() { }

	// RVA: 0x18C89C0 Offset: 0x18C8AC1 VA: 0x18C89C0
	public Vector2 get_velocity() { }

	// RVA: 0x18C89D0 Offset: 0x18C8AD1 VA: 0x18C89D0
	public void set_velocity(Vector2 value) { }

	// RVA: 0x18C89E0 Offset: 0x18C8AE1 VA: 0x18C89E0
	private RectTransform get_rectTransform() { }

	// RVA: 0x18C8A90 Offset: 0x18C8B91 VA: 0x18C8A90
	protected void .ctor() { }

	// RVA: 0x18C8C30 Offset: 0x18C8D31 VA: 0x18C8C30 Slot: 38
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18C9B10 Offset: 0x18C9C11 VA: 0x18C9B10 Slot: 39
	public virtual void LayoutComplete() { }

	// RVA: 0x18C9B20 Offset: 0x18C9C21 VA: 0x18C9B20 Slot: 40
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18C8CF0 Offset: 0x18C8DF1 VA: 0x18C8CF0
	private void UpdateCachedData() { }

	// RVA: 0x18C9B30 Offset: 0x18C9C31 VA: 0x18C9B30 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x18C9D00 Offset: 0x18C9E01 VA: 0x18C9D00 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x18C9FB0 Offset: 0x18CA0B1 VA: 0x18C9FB0 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x18CA040 Offset: 0x18CA141 VA: 0x18CA040
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x18CA0D0 Offset: 0x18CA1D1 VA: 0x18CA0D0 Slot: 41
	public virtual void StopMovement() { }

	// RVA: 0x18CA140 Offset: 0x18CA241 VA: 0x18CA140 Slot: 42
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x18CA4B0 Offset: 0x18CA5B1 VA: 0x18CA4B0 Slot: 43
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18CA550 Offset: 0x18CA651 VA: 0x18CA550 Slot: 44
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x18CA680 Offset: 0x18CA781 VA: 0x18CA680 Slot: 45
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x18CA6B0 Offset: 0x18CA7B1 VA: 0x18CA6B0 Slot: 46
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18CAA90 Offset: 0x18CAB91 VA: 0x18CAA90 Slot: 47
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x18CABC0 Offset: 0x18CACC1 VA: 0x18CABC0 Slot: 48
	protected virtual void LateUpdate() { }

	// RVA: 0x18C9A30 Offset: 0x18C9B31 VA: 0x18C9A30
	protected void UpdatePrevData() { }

	// RVA: 0x18C9680 Offset: 0x18C9781 VA: 0x18C9680
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x18CB300 Offset: 0x18CB401 VA: 0x18CB300
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x18CB790 Offset: 0x18CB891 VA: 0x18CB790
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x18CB4E0 Offset: 0x18CB5E1 VA: 0x18CB4E0
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x18CB7F0 Offset: 0x18CB8F1 VA: 0x18CB7F0
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x18CB640 Offset: 0x18CB741 VA: 0x18CB640
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x18CB810 Offset: 0x18CB911 VA: 0x18CB810
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x18CB830 Offset: 0x18CB931 VA: 0x18CB830
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x18CB850 Offset: 0x18CB951 VA: 0x18CB850
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x18CB870 Offset: 0x18CB971 VA: 0x18CB870 Slot: 49
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x18CA9E0 Offset: 0x18CAAE1 VA: 0x18CA9E0
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x18CBAF0 Offset: 0x18CBBF1 VA: 0x18CBAF0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18CBB00 Offset: 0x18CBC01 VA: 0x18CBB00
	private bool get_hScrollingNeeded() { }

	// RVA: 0x18CBB80 Offset: 0x18CBC81 VA: 0x18CBB80
	private bool get_vScrollingNeeded() { }

	// RVA: 0x18CBC00 Offset: 0x18CBD01 VA: 0x18CBC00 Slot: 50
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x18CBC10 Offset: 0x18CBD11 VA: 0x18CBC10 Slot: 51
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x18CBC20 Offset: 0x18CBD21 VA: 0x18CBC20 Slot: 52
	public virtual float get_minWidth() { }

	// RVA: 0x18CBC30 Offset: 0x18CBD31 VA: 0x18CBC30 Slot: 53
	public virtual float get_preferredWidth() { }

	// RVA: 0x18CBC40 Offset: 0x18CBD41 VA: 0x18CBC40 Slot: 54
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18CBC50 Offset: 0x18CBD51 VA: 0x18CBC50 Slot: 55
	public virtual float get_minHeight() { }

	// RVA: 0x18CBC60 Offset: 0x18CBD61 VA: 0x18CBC60 Slot: 56
	public virtual float get_preferredHeight() { }

	// RVA: 0x18CBC70 Offset: 0x18CBD71 VA: 0x18CBC70 Slot: 57
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18CBC80 Offset: 0x18CBD81 VA: 0x18CBC80 Slot: 58
	public virtual int get_layoutPriority() { }

	// RVA: 0x18CBC90 Offset: 0x18CBD91 VA: 0x18CBC90 Slot: 59
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x18CC410 Offset: 0x18CC511 VA: 0x18CC410 Slot: 60
	public virtual void SetLayoutVertical() { }

	// RVA: 0x18CB360 Offset: 0x18CB461 VA: 0x18CB360
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x18CC940 Offset: 0x18CCA41 VA: 0x18CC940
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x18CC570 Offset: 0x18CC671 VA: 0x18CC570
	private void UpdateScrollbarLayout() { }

	// RVA: 0x18C9120 Offset: 0x18C9221 VA: 0x18C9120
	protected void UpdateBounds() { }

	// RVA: 0x18CCA60 Offset: 0x18CCB61 VA: 0x18CCA60
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	// RVA: 0x18CC300 Offset: 0x18CC401 VA: 0x18CC300
	private Bounds GetBounds() { }

	// RVA: 0x18CCBA0 Offset: 0x18CCCA1 VA: 0x18CCBA0
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x18CA470 Offset: 0x18CA571 VA: 0x18CA470
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x18CCF50 Offset: 0x18CD051 VA: 0x18CCF50
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta) { }

	// RVA: 0x18C8750 Offset: 0x18C8851 VA: 0x18C8750
	protected void SetDirty() { }

	// RVA: 0x18C8210 Offset: 0x18C8311 VA: 0x18C8210
	protected void SetDirtyCaching() { }

	// RVA: 0x18CD150 Offset: 0x18CD251 VA: 0x18CD150 Slot: 23
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

