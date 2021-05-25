public class UICalendarMenu : CursorLinkConnector // TypeDefIndex: 8755
{
	// Fields
	public static bool IsFurniture; // 0x0
	[SerializeField] // RVA: 0x173250 Offset: 0x173351 VA: 0x173250
	private RectTransform CalendarPage; // 0x58
	[SerializeField] // RVA: 0x173260 Offset: 0x173361 VA: 0x173260
	private CalendarDiscription calendarDiscription; // 0x60
	[SerializeField] // RVA: 0x173270 Offset: 0x173371 VA: 0x173270
	private ButtonLinker[] PagesBtn; // 0x68
	[SerializeField] // RVA: 0x173280 Offset: 0x173381 VA: 0x173280
	private Image NowBGImage; // 0x70
	[SerializeField] // RVA: 0x173290 Offset: 0x173391 VA: 0x173290
	private Image FromBGImage; // 0x78
	[SerializeField] // RVA: 0x1732A0 Offset: 0x1733A1 VA: 0x1732A0
	private Sprite[] BGSprites; // 0x80
	[SerializeField] // RVA: 0x1732B0 Offset: 0x1733B1 VA: 0x1732B0
	private Image LArrowImage; // 0x88
	[SerializeField] // RVA: 0x1732C0 Offset: 0x1733C1 VA: 0x1732C0
	private Image RArrowImage; // 0x90
	[SerializeField] // RVA: 0x1732D0 Offset: 0x1733D1 VA: 0x1732D0
	private Sprite[] ArrowSprites; // 0x98
	public int FromPage; // 0xA0
	public int NowPage; // 0xA4
	public int PageMax; // 0xA8
	private float MoveTimeMax; // 0xAC
	private float MoveDelayTime; // 0xB0
	private float startPosX; // 0xB4
	private float nextPosX; // 0xB8
	private float SlideSize; // 0xBC
	[SerializeField] // RVA: 0x1732E0 Offset: 0x1733E1 VA: 0x1732E0
	public bool isBirthdaySelecter; // 0xC0
	private static int focusingDate; // 0x4
	private static int focusingSeason; // 0x8
	private static UnityAction<int, int> EndCallback; // 0x10
	private bool popupOpening; // 0xC1

	// Methods

	// RVA: 0x1F038A0 Offset: 0x1F039A1 VA: 0x1F038A0
	public static void OpenBirthdaySelecter(UnityAction<int, int> endCallback) { }

	// RVA: 0x1F039F0 Offset: 0x1F03AF1 VA: 0x1F039F0
	private void Start() { }

	// RVA: 0x1F03DD0 Offset: 0x1F03ED1 VA: 0x1F03DD0
	private void OnDestroy() { }

	// RVA: 0x1F03E30 Offset: 0x1F03F31 VA: 0x1F03E30
	private void SetSeasonSprite() { }

	// RVA: 0x1F03F80 Offset: 0x1F04081 VA: 0x1F03F80
	private string GetDayOfWeekStr(int day) { }

	// RVA: 0x1F04290 Offset: 0x1F04391 VA: 0x1F04290
	public void DoSetBirthday() { }

	// RVA: 0x1F046E0 Offset: 0x1F047E1 VA: 0x1F046E0
	public void SetFocusingBirthday(int date, int season) { }

	// RVA: 0x1F03C80 Offset: 0x1F03D81 VA: 0x1F03C80
	private void ForceChangePage(int nextPage) { }

	// RVA: 0x1F04770 Offset: 0x1F04871 VA: 0x1F04770
	private void SetChangePage(int nextPage) { }

	// RVA: 0x1F047E0 Offset: 0x1F048E1 VA: 0x1F047E0
	private void Update() { }

	// RVA: 0x1F04B80 Offset: 0x1F04C81 VA: 0x1F04B80
	public void .ctor() { }

	// RVA: 0x1F04BB0 Offset: 0x1F04CB1 VA: 0x1F04BB0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8490 Offset: 0x1A8591 VA: 0x1A8490
	// RVA: 0x1F04BC0 Offset: 0x1F04CC1 VA: 0x1F04BC0
	private void <Start>b__24_0(bool select) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A84A0 Offset: 0x1A85A1 VA: 0x1A84A0
	// RVA: 0x1F04BD0 Offset: 0x1F04CD1 VA: 0x1F04BD0
	private void <DoSetBirthday>b__28_0(bool select) { }
}

