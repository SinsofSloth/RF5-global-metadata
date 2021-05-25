[AddComponentMenu] // RVA: 0x11A570 Offset: 0x11A671 VA: 0x11A570
[ExecuteAlways] // RVA: 0x11A570 Offset: 0x11A671 VA: 0x11A570
[RequireComponent] // RVA: 0x11A570 Offset: 0x11A671 VA: 0x11A570
public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 3997
{
	// Fields
	[SerializeField] // RVA: 0x11C430 Offset: 0x11C531 VA: 0x11C430
	private RectTransform m_HandleRect; // 0xF8
	[SerializeField] // RVA: 0x11C440 Offset: 0x11C541 VA: 0x11C440
	private Scrollbar.Direction m_Direction; // 0x100
	[RangeAttribute] // RVA: 0x11C450 Offset: 0x11C551 VA: 0x11C450
	[SerializeField] // RVA: 0x11C450 Offset: 0x11C551 VA: 0x11C450
	private float m_Value; // 0x104
	[RangeAttribute] // RVA: 0x11C490 Offset: 0x11C591 VA: 0x11C490
	[SerializeField] // RVA: 0x11C490 Offset: 0x11C591 VA: 0x11C490
	private float m_Size; // 0x108
	[RangeAttribute] // RVA: 0x11C4D0 Offset: 0x11C5D1 VA: 0x11C4D0
	[SerializeField] // RVA: 0x11C4D0 Offset: 0x11C5D1 VA: 0x11C4D0
	private int m_NumberOfSteps; // 0x10C
	[SpaceAttribute] // RVA: 0x11C510 Offset: 0x11C611 VA: 0x11C510
	[SerializeField] // RVA: 0x11C510 Offset: 0x11C611 VA: 0x11C510
	private Scrollbar.ScrollEvent m_OnValueChanged; // 0x110
	private RectTransform m_ContainerRect; // 0x118
	private Vector2 m_Offset; // 0x120
	private DrivenRectTransformTracker m_Tracker; // 0x128
	private Coroutine m_PointerDownRepeat; // 0x130
	private bool isPointerDownAndNotDragging; // 0x138
	private bool m_DelayedUpdateVisuals; // 0x139

	// Properties
	public RectTransform handleRect { get; set; }
	public Scrollbar.Direction direction { get; set; }
	public float value { get; set; }
	public float size { get; set; }
	public int numberOfSteps { get; set; }
	public Scrollbar.ScrollEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Scrollbar.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x18CD160 Offset: 0x18CD261 VA: 0x18CD160
	public RectTransform get_handleRect() { }

	// RVA: 0x18CD170 Offset: 0x18CD271 VA: 0x18CD170
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x18CD510 Offset: 0x18CD611 VA: 0x18CD510
	public Scrollbar.Direction get_direction() { }

	// RVA: 0x18CD520 Offset: 0x18CD621 VA: 0x18CD520
	public void set_direction(Scrollbar.Direction value) { }

	// RVA: 0x18CD5A0 Offset: 0x18CD6A1 VA: 0x18CD5A0
	protected void .ctor() { }

	// RVA: 0x18CD850 Offset: 0x18CD951 VA: 0x18CD850
	public float get_value() { }

	// RVA: 0x18CB630 Offset: 0x18CB731 VA: 0x18CB630
	public void set_value(float value) { }

	// RVA: 0x18CDA40 Offset: 0x18CDB41 VA: 0x18CDA40 Slot: 47
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x18CDAC0 Offset: 0x18CDBC1 VA: 0x18CDAC0
	public float get_size() { }

	// RVA: 0x18CB430 Offset: 0x18CB531 VA: 0x18CB430
	public void set_size(float value) { }

	// RVA: 0x18CDAD0 Offset: 0x18CDBD1 VA: 0x18CDAD0
	public int get_numberOfSteps() { }

	// RVA: 0x18CDAE0 Offset: 0x18CDBE1 VA: 0x18CDAE0
	public void set_numberOfSteps(int value) { }

	// RVA: 0x18CDB70 Offset: 0x18CDC71 VA: 0x18CDB70
	public Scrollbar.ScrollEvent get_onValueChanged() { }

	// RVA: 0x18CDB80 Offset: 0x18CDC81 VA: 0x18CDB80
	public void set_onValueChanged(Scrollbar.ScrollEvent value) { }

	// RVA: 0x18CDB90 Offset: 0x18CDC91 VA: 0x18CDB90
	private float get_stepSize() { }

	// RVA: 0x18CDBC0 Offset: 0x18CDCC1 VA: 0x18CDBC0 Slot: 48
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18CDBD0 Offset: 0x18CDCD1 VA: 0x18CDBD0 Slot: 49
	public virtual void LayoutComplete() { }

	// RVA: 0x18CDBE0 Offset: 0x18CDCE1 VA: 0x18CDBE0 Slot: 50
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18CDBF0 Offset: 0x18CDCF1 VA: 0x18CDBF0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x18CDEA0 Offset: 0x18CDFA1 VA: 0x18CDEA0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x18CE060 Offset: 0x18CE161 VA: 0x18CE060 Slot: 51
	protected virtual void Update() { }

	// RVA: 0x18CD200 Offset: 0x18CD301 VA: 0x18CD200
	private void UpdateCachedReferences() { }

	// RVA: 0x18CD970 Offset: 0x18CDA71 VA: 0x18CD970
	private void Set(float input, bool sendCallback = True) { }

	// RVA: 0x18CE080 Offset: 0x18CE181 VA: 0x18CE080 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18CE0D0 Offset: 0x18CE1D1 VA: 0x18CE0D0
	private Scrollbar.Axis get_axis() { }

	// RVA: 0x18CE0E0 Offset: 0x18CE1E1 VA: 0x18CE0E0
	private bool get_reverseValue() { }

	// RVA: 0x18CD320 Offset: 0x18CD421 VA: 0x18CD320
	private void UpdateVisuals() { }

	// RVA: 0x18CE100 Offset: 0x18CE201 VA: 0x18CE100
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x18CE3B0 Offset: 0x18CE4B1 VA: 0x18CE3B0
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x18CE500 Offset: 0x18CE601 VA: 0x18CE500
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x18CE580 Offset: 0x18CE681 VA: 0x18CE580 Slot: 52
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x18CE7B0 Offset: 0x18CE8B1 VA: 0x18CE7B0 Slot: 53
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18CE890 Offset: 0x18CE991 VA: 0x18CE890 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18CEC30 Offset: 0x18CED31 VA: 0x18CEC30
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x11D1A0 Offset: 0x11D2A1 VA: 0x11D1A0
	// RVA: 0x18CEB80 Offset: 0x18CEC81 VA: 0x18CEB80
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	// RVA: 0x18CED20 Offset: 0x18CEE21 VA: 0x18CED20 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x18CEEA0 Offset: 0x18CEFA1 VA: 0x18CEEA0 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x18CF1D0 Offset: 0x18CF2D1 VA: 0x18CF1D0 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x18CF340 Offset: 0x18CF441 VA: 0x18CF340 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x18CF4B0 Offset: 0x18CF5B1 VA: 0x18CF4B0 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x18CF620 Offset: 0x18CF721 VA: 0x18CF620 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x18CF790 Offset: 0x18CF891 VA: 0x18CF790 Slot: 54
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18CF7B0 Offset: 0x18CF8B1 VA: 0x18CF7B0
	public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x18CF990 Offset: 0x18CFA91 VA: 0x18CF990 Slot: 43
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

