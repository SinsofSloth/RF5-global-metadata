[AddComponentMenu] // RVA: 0x11AA00 Offset: 0x11AB01 VA: 0x11AA00
public class EventSystem : UIBehaviour // TypeDefIndex: 4070
{
	// Fields
	private List<BaseInputModule> m_SystemInputModules; // 0x18
	private BaseInputModule m_CurrentInputModule; // 0x20
	private static List<EventSystem> m_EventSystems; // 0x0
	[SerializeField] // RVA: 0x11CB80 Offset: 0x11CC81 VA: 0x11CB80
	[FormerlySerializedAsAttribute] // RVA: 0x11CB80 Offset: 0x11CC81 VA: 0x11CB80
	private GameObject m_FirstSelected; // 0x28
	[SerializeField] // RVA: 0x11CBD0 Offset: 0x11CCD1 VA: 0x11CBD0
	private bool m_sendNavigationEvents; // 0x30
	[SerializeField] // RVA: 0x11CBE0 Offset: 0x11CCE1 VA: 0x11CBE0
	private int m_DragThreshold; // 0x34
	private GameObject m_CurrentSelected; // 0x38
	private bool m_HasFocus; // 0x40
	private bool m_SelectionGuard; // 0x41
	private BaseEventData m_DummyData; // 0x48
	private static readonly Comparison<RaycastResult> s_RaycastComparer; // 0x8

	// Properties
	public static EventSystem current { get; set; }
	public bool sendNavigationEvents { get; set; }
	public int pixelDragThreshold { get; set; }
	public BaseInputModule currentInputModule { get; }
	public GameObject firstSelectedGameObject { get; set; }
	public GameObject currentSelectedGameObject { get; }
	[ObsoleteAttribute] // RVA: 0x11DB00 Offset: 0x11DC01 VA: 0x11DB00
	public GameObject lastSelectedGameObject { get; }
	public bool isFocused { get; }
	public bool alreadySelecting { get; }
	private BaseEventData baseEventDataCache { get; }

	// Methods

	// RVA: 0x16393A0 Offset: 0x16394A1 VA: 0x16393A0
	public static EventSystem get_current() { }

	// RVA: 0x1639470 Offset: 0x1639571 VA: 0x1639470
	public static void set_current(EventSystem value) { }

	// RVA: 0x1639580 Offset: 0x1639681 VA: 0x1639580
	public bool get_sendNavigationEvents() { }

	// RVA: 0x1639590 Offset: 0x1639691 VA: 0x1639590
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0x16395A0 Offset: 0x16396A1 VA: 0x16395A0
	public int get_pixelDragThreshold() { }

	// RVA: 0x16395B0 Offset: 0x16396B1 VA: 0x16395B0
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x16395C0 Offset: 0x16396C1 VA: 0x16395C0
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x16395D0 Offset: 0x16396D1 VA: 0x16395D0
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x16395E0 Offset: 0x16396E1 VA: 0x16395E0
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x16395F0 Offset: 0x16396F1 VA: 0x16395F0
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x1639600 Offset: 0x1639701 VA: 0x1639600
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x1639610 Offset: 0x1639711 VA: 0x1639610
	public bool get_isFocused() { }

	// RVA: 0x1639620 Offset: 0x1639721 VA: 0x1639620
	protected void .ctor() { }

	// RVA: 0x1637C20 Offset: 0x1637D21 VA: 0x1637C20
	public void UpdateModules() { }

	// RVA: 0x16396B0 Offset: 0x16397B1 VA: 0x16396B0
	public bool get_alreadySelecting() { }

	// RVA: 0x16375E0 Offset: 0x16376E1 VA: 0x16375E0
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x16396C0 Offset: 0x16397C1 VA: 0x16396C0
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x1639770 Offset: 0x1639871 VA: 0x1639770
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x1639810 Offset: 0x1639911 VA: 0x1639810
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x1639B90 Offset: 0x1639C91 VA: 0x1639B90
	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	// RVA: 0x1639D80 Offset: 0x1639E81 VA: 0x1639D80
	public bool IsPointerOverGameObject() { }

	// RVA: 0x1639E30 Offset: 0x1639F31 VA: 0x1639E30
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x1639EF0 Offset: 0x1639FF1 VA: 0x1639EF0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1639F80 Offset: 0x163A081 VA: 0x1639F80 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x163A070 Offset: 0x163A171 VA: 0x163A070
	private void TickModules() { }

	// RVA: 0x163A180 Offset: 0x163A281 VA: 0x163A180 Slot: 17
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x163A190 Offset: 0x163A291 VA: 0x163A190 Slot: 18
	protected virtual void Update() { }

	// RVA: 0x163A420 Offset: 0x163A521 VA: 0x163A420
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x163A550 Offset: 0x163A651 VA: 0x163A550 Slot: 3
	public override string ToString() { }

	// RVA: 0x163A680 Offset: 0x163A781 VA: 0x163A680
	private static void .cctor() { }
}

