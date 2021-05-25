[AddComponentMenu] // RVA: 0x11A680 Offset: 0x11A781 VA: 0x11A680
[ExecuteAlways] // RVA: 0x11A680 Offset: 0x11A781 VA: 0x11A680
[RequireComponent] // RVA: 0x11A680 Offset: 0x11A781 VA: 0x11A680
public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 4006
{
	// Fields
	[SerializeField] // RVA: 0x11C7D0 Offset: 0x11C8D1 VA: 0x11C7D0
	private RectTransform m_FillRect; // 0xF8
	[SerializeField] // RVA: 0x11C7E0 Offset: 0x11C8E1 VA: 0x11C7E0
	private RectTransform m_HandleRect; // 0x100
	[SpaceAttribute] // RVA: 0x11C7F0 Offset: 0x11C8F1 VA: 0x11C7F0
	[SerializeField] // RVA: 0x11C7F0 Offset: 0x11C8F1 VA: 0x11C7F0
	private Slider.Direction m_Direction; // 0x108
	[SerializeField] // RVA: 0x11C830 Offset: 0x11C931 VA: 0x11C830
	private float m_MinValue; // 0x10C
	[SerializeField] // RVA: 0x11C840 Offset: 0x11C941 VA: 0x11C840
	private float m_MaxValue; // 0x110
	[SerializeField] // RVA: 0x11C850 Offset: 0x11C951 VA: 0x11C850
	private bool m_WholeNumbers; // 0x114
	[SerializeField] // RVA: 0x11C860 Offset: 0x11C961 VA: 0x11C860
	protected float m_Value; // 0x118
	[SpaceAttribute] // RVA: 0x11C870 Offset: 0x11C971 VA: 0x11C870
	[SerializeField] // RVA: 0x11C870 Offset: 0x11C971 VA: 0x11C870
	private Slider.SliderEvent m_OnValueChanged; // 0x120
	private Image m_FillImage; // 0x128
	private Transform m_FillTransform; // 0x130
	private RectTransform m_FillContainerRect; // 0x138
	private Transform m_HandleTransform; // 0x140
	private RectTransform m_HandleContainerRect; // 0x148
	private Vector2 m_Offset; // 0x150
	private DrivenRectTransformTracker m_Tracker; // 0x158
	private bool m_DelayedUpdateVisuals; // 0x159

	// Properties
	public RectTransform fillRect { get; set; }
	public RectTransform handleRect { get; set; }
	public Slider.Direction direction { get; set; }
	public float minValue { get; set; }
	public float maxValue { get; set; }
	public bool wholeNumbers { get; set; }
	public virtual float value { get; set; }
	public float normalizedValue { get; set; }
	public Slider.SliderEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Slider.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x18D2980 Offset: 0x18D2A81 VA: 0x18D2980
	public RectTransform get_fillRect() { }

	// RVA: 0x18D2990 Offset: 0x18D2A91 VA: 0x18D2990
	public void set_fillRect(RectTransform value) { }

	// RVA: 0x18D3050 Offset: 0x18D3151 VA: 0x18D3050
	public RectTransform get_handleRect() { }

	// RVA: 0x18D3060 Offset: 0x18D3161 VA: 0x18D3060
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x18D30F0 Offset: 0x18D31F1 VA: 0x18D30F0
	public Slider.Direction get_direction() { }

	// RVA: 0x18D3100 Offset: 0x18D3201 VA: 0x18D3100
	public void set_direction(Slider.Direction value) { }

	// RVA: 0x18D3180 Offset: 0x18D3281 VA: 0x18D3180
	public float get_minValue() { }

	// RVA: 0x18D3190 Offset: 0x18D3291 VA: 0x18D3190
	public void set_minValue(float value) { }

	// RVA: 0x18D3230 Offset: 0x18D3331 VA: 0x18D3230
	public float get_maxValue() { }

	// RVA: 0x18D3240 Offset: 0x18D3341 VA: 0x18D3240
	public void set_maxValue(float value) { }

	// RVA: 0x18D32E0 Offset: 0x18D33E1 VA: 0x18D32E0
	public bool get_wholeNumbers() { }

	// RVA: 0x18D32F0 Offset: 0x18D33F1 VA: 0x18D32F0
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x18D3390 Offset: 0x18D3491 VA: 0x18D3390 Slot: 46
	public virtual float get_value() { }

	// RVA: 0x18D3490 Offset: 0x18D3591 VA: 0x18D3490 Slot: 47
	public virtual void set_value(float value) { }

	// RVA: 0x18D34B0 Offset: 0x18D35B1 VA: 0x18D34B0 Slot: 48
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x18D34D0 Offset: 0x18D35D1 VA: 0x18D34D0
	public float get_normalizedValue() { }

	// RVA: 0x18D35C0 Offset: 0x18D36C1 VA: 0x18D35C0
	public void set_normalizedValue(float value) { }

	// RVA: 0x18D3660 Offset: 0x18D3761 VA: 0x18D3660
	public Slider.SliderEvent get_onValueChanged() { }

	// RVA: 0x18D3670 Offset: 0x18D3771 VA: 0x18D3670
	public void set_onValueChanged(Slider.SliderEvent value) { }

	// RVA: 0x18D3680 Offset: 0x18D3781 VA: 0x18D3680
	private float get_stepSize() { }

	// RVA: 0x18D36B0 Offset: 0x18D37B1 VA: 0x18D36B0
	protected void .ctor() { }

	// RVA: 0x18D3790 Offset: 0x18D3891 VA: 0x18D3790 Slot: 49
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x18D37A0 Offset: 0x18D38A1 VA: 0x18D37A0 Slot: 50
	public virtual void LayoutComplete() { }

	// RVA: 0x18D37B0 Offset: 0x18D38B1 VA: 0x18D37B0 Slot: 51
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x18D37C0 Offset: 0x18D38C1 VA: 0x18D37C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x18D3810 Offset: 0x18D3911 VA: 0x18D3810 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x18D3840 Offset: 0x18D3941 VA: 0x18D3840 Slot: 52
	protected virtual void Update() { }

	// RVA: 0x18D3890 Offset: 0x18D3991 VA: 0x18D3890 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18D2A20 Offset: 0x18D2B21 VA: 0x18D2A20
	private void UpdateCachedReferences() { }

	// RVA: 0x18D3AD0 Offset: 0x18D3BD1 VA: 0x18D3AD0
	private float ClampValue(float input) { }

	// RVA: 0x18D3C40 Offset: 0x18D3D41 VA: 0x18D3C40 Slot: 53
	protected virtual void Set(float input, bool sendCallback = True) { }

	// RVA: 0x18D3D10 Offset: 0x18D3E11 VA: 0x18D3D10 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18D3C30 Offset: 0x18D3D31 VA: 0x18D3C30
	private Slider.Axis get_axis() { }

	// RVA: 0x18D3C10 Offset: 0x18D3D11 VA: 0x18D3C10
	private bool get_reverseValue() { }

	// RVA: 0x18D2D80 Offset: 0x18D2E81 VA: 0x18D2D80
	private void UpdateVisuals() { }

	// RVA: 0x18D3D60 Offset: 0x18D3E61 VA: 0x18D3D60
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x18D4070 Offset: 0x18D4171 VA: 0x18D4070
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x18D40F0 Offset: 0x18D41F1 VA: 0x18D40F0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x18D42D0 Offset: 0x18D43D1 VA: 0x18D42D0 Slot: 54
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x18D4350 Offset: 0x18D4451 VA: 0x18D4350 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x18D45C0 Offset: 0x18D46C1 VA: 0x18D45C0 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x18D45F0 Offset: 0x18D46F1 VA: 0x18D45F0 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x18D4620 Offset: 0x18D4721 VA: 0x18D4620 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x18D4650 Offset: 0x18D4751 VA: 0x18D4650 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x18D4680 Offset: 0x18D4781 VA: 0x18D4680 Slot: 55
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x18D46A0 Offset: 0x18D47A1 VA: 0x18D46A0
	public void SetDirection(Slider.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x18D4880 Offset: 0x18D4981 VA: 0x18D4880 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

