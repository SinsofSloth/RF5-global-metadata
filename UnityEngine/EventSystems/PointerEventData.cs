public class PointerEventData : BaseEventData // TypeDefIndex: 4048
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x11CA50 Offset: 0x11CB51 VA: 0x11CA50
	private GameObject <pointerEnter>k__BackingField; // 0x20
	private GameObject m_PointerPress; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x11CA60 Offset: 0x11CB61 VA: 0x11CA60
	private GameObject <lastPress>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x11CA70 Offset: 0x11CB71 VA: 0x11CA70
	private GameObject <rawPointerPress>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x11CA80 Offset: 0x11CB81 VA: 0x11CA80
	private GameObject <pointerDrag>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x11CA90 Offset: 0x11CB91 VA: 0x11CA90
	private RaycastResult <pointerCurrentRaycast>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x11CAA0 Offset: 0x11CBA1 VA: 0x11CAA0
	private RaycastResult <pointerPressRaycast>k__BackingField; // 0x90
	public List<GameObject> hovered; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x11CAB0 Offset: 0x11CBB1 VA: 0x11CAB0
	private bool <eligibleForClick>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x11CAC0 Offset: 0x11CBC1 VA: 0x11CAC0
	private int <pointerId>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x11CAD0 Offset: 0x11CBD1 VA: 0x11CAD0
	private Vector2 <position>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x11CAE0 Offset: 0x11CBE1 VA: 0x11CAE0
	private Vector2 <delta>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x11CAF0 Offset: 0x11CBF1 VA: 0x11CAF0
	private Vector2 <pressPosition>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x11CB00 Offset: 0x11CC01 VA: 0x11CB00
	private Vector3 <worldPosition>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x11CB10 Offset: 0x11CC11 VA: 0x11CB10
	private Vector3 <worldNormal>k__BackingField; // 0x10C
	[CompilerGeneratedAttribute] // RVA: 0x11CB20 Offset: 0x11CC21 VA: 0x11CB20
	private float <clickTime>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x11CB30 Offset: 0x11CC31 VA: 0x11CB30
	private int <clickCount>k__BackingField; // 0x11C
	[CompilerGeneratedAttribute] // RVA: 0x11CB40 Offset: 0x11CC41 VA: 0x11CB40
	private Vector2 <scrollDelta>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x11CB50 Offset: 0x11CC51 VA: 0x11CB50
	private bool <useDragThreshold>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x11CB60 Offset: 0x11CC61 VA: 0x11CB60
	private bool <dragging>k__BackingField; // 0x129
	[CompilerGeneratedAttribute] // RVA: 0x11CB70 Offset: 0x11CC71 VA: 0x11CB70
	private PointerEventData.InputButton <button>k__BackingField; // 0x12C

	// Properties
	public GameObject pointerEnter { get; set; }
	public GameObject lastPress { get; set; }
	public GameObject rawPointerPress { get; set; }
	public GameObject pointerDrag { get; set; }
	public RaycastResult pointerCurrentRaycast { get; set; }
	public RaycastResult pointerPressRaycast { get; set; }
	public bool eligibleForClick { get; set; }
	public int pointerId { get; set; }
	public Vector2 position { get; set; }
	public Vector2 delta { get; set; }
	public Vector2 pressPosition { get; set; }
	[ObsoleteAttribute] // RVA: 0x11DA80 Offset: 0x11DB81 VA: 0x11DA80
	public Vector3 worldPosition { get; set; }
	[ObsoleteAttribute] // RVA: 0x11DAC0 Offset: 0x11DBC1 VA: 0x11DAC0
	public Vector3 worldNormal { get; set; }
	public float clickTime { get; set; }
	public int clickCount { get; set; }
	public Vector2 scrollDelta { get; set; }
	public bool useDragThreshold { get; set; }
	public bool dragging { get; set; }
	public PointerEventData.InputButton button { get; set; }
	public Camera enterEventCamera { get; }
	public Camera pressEventCamera { get; }
	public GameObject pointerPress { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11D4A0 Offset: 0x11D5A1 VA: 0x11D4A0
	// RVA: 0x163DE50 Offset: 0x163DF51 VA: 0x163DE50
	public GameObject get_pointerEnter() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D4B0 Offset: 0x11D5B1 VA: 0x11D4B0
	// RVA: 0x163DE60 Offset: 0x163DF61 VA: 0x163DE60
	public void set_pointerEnter(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D4C0 Offset: 0x11D5C1 VA: 0x11D4C0
	// RVA: 0x163DE70 Offset: 0x163DF71 VA: 0x163DE70
	public GameObject get_lastPress() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D4D0 Offset: 0x11D5D1 VA: 0x11D4D0
	// RVA: 0x163DE80 Offset: 0x163DF81 VA: 0x163DE80
	private void set_lastPress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D4E0 Offset: 0x11D5E1 VA: 0x11D4E0
	// RVA: 0x163DE90 Offset: 0x163DF91 VA: 0x163DE90
	public GameObject get_rawPointerPress() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D4F0 Offset: 0x11D5F1 VA: 0x11D4F0
	// RVA: 0x163DEA0 Offset: 0x163DFA1 VA: 0x163DEA0
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D500 Offset: 0x11D601 VA: 0x11D500
	// RVA: 0x163DEB0 Offset: 0x163DFB1 VA: 0x163DEB0
	public GameObject get_pointerDrag() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D510 Offset: 0x11D611 VA: 0x11D510
	// RVA: 0x163DEC0 Offset: 0x163DFC1 VA: 0x163DEC0
	public void set_pointerDrag(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D520 Offset: 0x11D621 VA: 0x11D520
	// RVA: 0x163DED0 Offset: 0x163DFD1 VA: 0x163DED0
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D530 Offset: 0x11D631 VA: 0x11D530
	// RVA: 0x163DF00 Offset: 0x163E001 VA: 0x163DF00
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D540 Offset: 0x11D641 VA: 0x11D540
	// RVA: 0x163DF30 Offset: 0x163E031 VA: 0x163DF30
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D550 Offset: 0x11D651 VA: 0x11D550
	// RVA: 0x163DF60 Offset: 0x163E061 VA: 0x163DF60
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D560 Offset: 0x11D661 VA: 0x11D560
	// RVA: 0x163DF90 Offset: 0x163E091 VA: 0x163DF90
	public bool get_eligibleForClick() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D570 Offset: 0x11D671 VA: 0x11D570
	// RVA: 0x163DFA0 Offset: 0x163E0A1 VA: 0x163DFA0
	public void set_eligibleForClick(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D580 Offset: 0x11D681 VA: 0x11D580
	// RVA: 0x163DFB0 Offset: 0x163E0B1 VA: 0x163DFB0
	public int get_pointerId() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D590 Offset: 0x11D691 VA: 0x11D590
	// RVA: 0x163DFC0 Offset: 0x163E0C1 VA: 0x163DFC0
	public void set_pointerId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D5A0 Offset: 0x11D6A1 VA: 0x11D5A0
	// RVA: 0x163DFD0 Offset: 0x163E0D1 VA: 0x163DFD0
	public Vector2 get_position() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D5B0 Offset: 0x11D6B1 VA: 0x11D5B0
	// RVA: 0x163DFE0 Offset: 0x163E0E1 VA: 0x163DFE0
	public void set_position(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D5C0 Offset: 0x11D6C1 VA: 0x11D5C0
	// RVA: 0x163DFF0 Offset: 0x163E0F1 VA: 0x163DFF0
	public Vector2 get_delta() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D5D0 Offset: 0x11D6D1 VA: 0x11D5D0
	// RVA: 0x163E000 Offset: 0x163E101 VA: 0x163E000
	public void set_delta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D5E0 Offset: 0x11D6E1 VA: 0x11D5E0
	// RVA: 0x163E010 Offset: 0x163E111 VA: 0x163E010
	public Vector2 get_pressPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D5F0 Offset: 0x11D6F1 VA: 0x11D5F0
	// RVA: 0x163E020 Offset: 0x163E121 VA: 0x163E020
	public void set_pressPosition(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D600 Offset: 0x11D701 VA: 0x11D600
	// RVA: 0x163E030 Offset: 0x163E131 VA: 0x163E030
	public Vector3 get_worldPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D610 Offset: 0x11D711 VA: 0x11D610
	// RVA: 0x163E040 Offset: 0x163E141 VA: 0x163E040
	public void set_worldPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D620 Offset: 0x11D721 VA: 0x11D620
	// RVA: 0x163E050 Offset: 0x163E151 VA: 0x163E050
	public Vector3 get_worldNormal() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D630 Offset: 0x11D731 VA: 0x11D630
	// RVA: 0x163E060 Offset: 0x163E161 VA: 0x163E060
	public void set_worldNormal(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D640 Offset: 0x11D741 VA: 0x11D640
	// RVA: 0x163E070 Offset: 0x163E171 VA: 0x163E070
	public float get_clickTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D650 Offset: 0x11D751 VA: 0x11D650
	// RVA: 0x163E080 Offset: 0x163E181 VA: 0x163E080
	public void set_clickTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D660 Offset: 0x11D761 VA: 0x11D660
	// RVA: 0x163E090 Offset: 0x163E191 VA: 0x163E090
	public int get_clickCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D670 Offset: 0x11D771 VA: 0x11D670
	// RVA: 0x163E0A0 Offset: 0x163E1A1 VA: 0x163E0A0
	public void set_clickCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D680 Offset: 0x11D781 VA: 0x11D680
	// RVA: 0x163E0B0 Offset: 0x163E1B1 VA: 0x163E0B0
	public Vector2 get_scrollDelta() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D690 Offset: 0x11D791 VA: 0x11D690
	// RVA: 0x163E0C0 Offset: 0x163E1C1 VA: 0x163E0C0
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D6A0 Offset: 0x11D7A1 VA: 0x11D6A0
	// RVA: 0x163E0D0 Offset: 0x163E1D1 VA: 0x163E0D0
	public bool get_useDragThreshold() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D6B0 Offset: 0x11D7B1 VA: 0x11D6B0
	// RVA: 0x163E0E0 Offset: 0x163E1E1 VA: 0x163E0E0
	public void set_useDragThreshold(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D6C0 Offset: 0x11D7C1 VA: 0x11D6C0
	// RVA: 0x163E0F0 Offset: 0x163E1F1 VA: 0x163E0F0
	public bool get_dragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D6D0 Offset: 0x11D7D1 VA: 0x11D6D0
	// RVA: 0x163E100 Offset: 0x163E201 VA: 0x163E100
	public void set_dragging(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11D6E0 Offset: 0x11D7E1 VA: 0x11D6E0
	// RVA: 0x163E110 Offset: 0x163E211 VA: 0x163E110
	public PointerEventData.InputButton get_button() { }

	[CompilerGeneratedAttribute] // RVA: 0x11D6F0 Offset: 0x11D7F1 VA: 0x11D6F0
	// RVA: 0x163E120 Offset: 0x163E221 VA: 0x163E120
	public void set_button(PointerEventData.InputButton value) { }

	// RVA: 0x163E130 Offset: 0x163E231 VA: 0x163E130
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x163E240 Offset: 0x163E341 VA: 0x163E240
	public bool IsPointerMoving() { }

	// RVA: 0x163E280 Offset: 0x163E381 VA: 0x163E280
	public bool IsScrolling() { }

	// RVA: 0x163E2C0 Offset: 0x163E3C1 VA: 0x163E2C0
	public Camera get_enterEventCamera() { }

	// RVA: 0x163E360 Offset: 0x163E461 VA: 0x163E360
	public Camera get_pressEventCamera() { }

	// RVA: 0x163E400 Offset: 0x163E501 VA: 0x163E400
	public GameObject get_pointerPress() { }

	// RVA: 0x163E410 Offset: 0x163E511 VA: 0x163E410
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x163E4D0 Offset: 0x163E5D1 VA: 0x163E4D0 Slot: 3
	public override string ToString() { }
}

