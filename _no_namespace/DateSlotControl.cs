public class DateSlotControl : ButtonLinker // TypeDefIndex: 8643
{
	// Fields
	[SerializeField] // RVA: 0x171730 Offset: 0x171831 VA: 0x171730
	private Text DateText; // 0x60
	[SerializeField] // RVA: 0x171740 Offset: 0x171841 VA: 0x171740
	private Image SlotImg; // 0x68
	[SerializeField] // RVA: 0x171750 Offset: 0x171851 VA: 0x171750
	private Image FesIcon; // 0x70
	[SerializeField] // RVA: 0x171760 Offset: 0x171861 VA: 0x171760
	private Image MinigameFesIcon; // 0x78
	[SerializeField] // RVA: 0x171770 Offset: 0x171871 VA: 0x171770
	private Image[] BirthDayIcon; // 0x80
	[SerializeField] // RVA: 0x171780 Offset: 0x171881 VA: 0x171780
	private Sprite HolidaySprite; // 0x88
	[SerializeField] // RVA: 0x171790 Offset: 0x171891 VA: 0x171790
	private Sprite NonHolidaySprite; // 0x90
	[SerializeField] // RVA: 0x1717A0 Offset: 0x1718A1 VA: 0x1717A0
	private Sprite SelectingSprite; // 0x98
	[SerializeField] // RVA: 0x1717B0 Offset: 0x1718B1 VA: 0x1717B0
	private Image myDateIcon; // 0xA0
	private List<NPCID> BirthdayNpcidList; // 0xA8
	private int MySeason; // 0xB0
	private int MyDate; // 0xB4
	[SerializeField] // RVA: 0x1717C0 Offset: 0x1718C1 VA: 0x1717C0
	private bool SetFocusToday; // 0xB8
	public CalendarDataTable.FestivalId FestivalId; // 0xBC
	[SerializeField] // RVA: 0x1717D0 Offset: 0x1718D1 VA: 0x1717D0
	private UICalendarMenu UICalendarMenu; // 0xC0
	public static readonly MakingID[] MakingIdFestivalTable; // 0x0
	private readonly GameFlagData[] birthdayFlagTable; // 0xC8

	// Methods

	// RVA: 0x1CAFCA0 Offset: 0x1CAFDA1 VA: 0x1CAFCA0
	public void DoInit(int year, int season, int date, RectTransform parentRect) { }

	// RVA: 0x1CAFE90 Offset: 0x1CAFF91 VA: 0x1CAFE90
	public void SetIcon() { }

	// RVA: 0x1CB0A70 Offset: 0x1CB0B71 VA: 0x1CB0A70
	public void SetTextDetail(Text[] texts, Text FesText) { }

	// RVA: 0x1CB10F0 Offset: 0x1CB11F1 VA: 0x1CB10F0
	public string GetDateText() { }

	// RVA: 0x1CB1220 Offset: 0x1CB1321 VA: 0x1CB1220
	public string GetYearText() { }

	// RVA: 0x1CB1370 Offset: 0x1CB1471 VA: 0x1CB1370
	public string GetMonthText() { }

	// RVA: 0x1CB15F0 Offset: 0x1CB16F1 VA: 0x1CB15F0 Slot: 8
	public override void OnNextFocus(CursorLinker nextObject) { }

	// RVA: 0x1CB1670 Offset: 0x1CB1771 VA: 0x1CB1670 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1CB1740 Offset: 0x1CB1841 VA: 0x1CB1740
	public void .ctor() { }

	// RVA: 0x1CB17E0 Offset: 0x1CB18E1 VA: 0x1CB17E0
	private static void .cctor() { }
}

