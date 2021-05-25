internal struct SliderHandler // TypeDefIndex: 3620
{
	// Fields
	private readonly Rect position; // 0x0
	private readonly float currentValue; // 0x10
	private readonly float size; // 0x14
	private readonly float start; // 0x18
	private readonly float end; // 0x1C
	private readonly GUIStyle slider; // 0x20
	private readonly GUIStyle thumb; // 0x28
	private readonly GUIStyle thumbExtent; // 0x30
	private readonly bool horiz; // 0x38
	private readonly int id; // 0x3C

	// Methods

	// RVA: 0x3A2570 Offset: 0x3A2671 VA: 0x3A2570
	public void .ctor(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x3A2600 Offset: 0x3A2701 VA: 0x3A2600
	public float Handle() { }

	// RVA: 0x3A2610 Offset: 0x3A2711 VA: 0x3A2610
	private float OnMouseDown() { }

	// RVA: 0x3A2620 Offset: 0x3A2721 VA: 0x3A2620
	private float OnMouseDrag() { }

	// RVA: 0x3A2630 Offset: 0x3A2731 VA: 0x3A2630
	private float OnMouseUp() { }

	// RVA: 0x3A26E0 Offset: 0x3A27E1 VA: 0x3A26E0
	private float OnRepaint() { }

	// RVA: 0x3A26F0 Offset: 0x3A27F1 VA: 0x3A26F0
	private EventType CurrentEventType() { }

	// RVA: 0x3A2730 Offset: 0x3A2831 VA: 0x3A2730
	private int CurrentScrollTroughSide() { }

	// RVA: 0x3A2740 Offset: 0x3A2841 VA: 0x3A2740
	private bool IsEmptySlider() { }

	// RVA: 0x3A2750 Offset: 0x3A2851 VA: 0x3A2750
	private bool SupportsPageMovements() { }

	// RVA: 0x3A27E0 Offset: 0x3A28E1 VA: 0x3A27E0
	private float PageMovementValue() { }

	// RVA: 0x3A2870 Offset: 0x3A2971 VA: 0x3A2870
	private float PageUpMovementBound() { }

	// RVA: 0x3A2880 Offset: 0x3A2981 VA: 0x3A2880
	private Event CurrentEvent() { }

	// RVA: 0x3A2890 Offset: 0x3A2991 VA: 0x3A2890
	private float ValueForCurrentMousePosition() { }

	// RVA: 0x3A28A0 Offset: 0x3A29A1 VA: 0x3A28A0
	private float Clamp(float value) { }

	// RVA: 0x3A28B0 Offset: 0x3A29B1 VA: 0x3A28B0
	private Rect ThumbSelectionRect() { }

	// RVA: 0x3A28D0 Offset: 0x3A29D1 VA: 0x3A28D0
	private void StartDraggingWithValue(float dragStartValue) { }

	// RVA: 0x3A2920 Offset: 0x3A2A21 VA: 0x3A2920
	private SliderState SliderState() { }

	// RVA: 0x3A2930 Offset: 0x3A2A31 VA: 0x3A2930
	private Rect ThumbExtRect() { }

	// RVA: 0x3A2940 Offset: 0x3A2A41 VA: 0x3A2940
	private Rect ThumbRect() { }

	// RVA: 0x3A2960 Offset: 0x3A2A61 VA: 0x3A2960
	private Rect VerticalThumbRect() { }

	// RVA: 0x3A2970 Offset: 0x3A2A71 VA: 0x3A2970
	private Rect HorizontalThumbRect() { }

	// RVA: 0x3A2980 Offset: 0x3A2A81 VA: 0x3A2980
	private float ClampedCurrentValue() { }

	// RVA: 0x3A2990 Offset: 0x3A2A91 VA: 0x3A2990
	private float MousePosition() { }

	// RVA: 0x3A29A0 Offset: 0x3A2AA1 VA: 0x3A29A0
	private float ValuesPerPixel() { }

	// RVA: 0x3A29B0 Offset: 0x3A2AB1 VA: 0x3A29B0
	private float ThumbSize() { }

	// RVA: 0x3A29C0 Offset: 0x3A2AC1 VA: 0x3A29C0
	private float MaxValue() { }

	// RVA: 0x3A2A50 Offset: 0x3A2B51 VA: 0x3A2A50
	private float MinValue() { }
}

