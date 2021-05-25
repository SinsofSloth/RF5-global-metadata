public class HUDTime : MonoBehaviour // TypeDefIndex: 8583
{
	// Fields
	[SerializeField] // RVA: 0x170CE0 Offset: 0x170DE1 VA: 0x170CE0
	private Image BorderImage; // 0x18
	[SerializeField] // RVA: 0x170CF0 Offset: 0x170DF1 VA: 0x170CF0
	private Sprite[] BorderSprites; // 0x20
	[SerializeField] // RVA: 0x170D00 Offset: 0x170E01 VA: 0x170D00
	private Text TimeText; // 0x28
	[SerializeField] // RVA: 0x170D10 Offset: 0x170E11 VA: 0x170D10
	private Text DateText; // 0x30
	[SerializeField] // RVA: 0x170D20 Offset: 0x170E21 VA: 0x170D20
	private Text SeasonText; // 0x38
	[SerializeField] // RVA: 0x170D30 Offset: 0x170E31 VA: 0x170D30
	private Image WeatherImage; // 0x40
	[SerializeField] // RVA: 0x170D40 Offset: 0x170E41 VA: 0x170D40
	private Sprite[] WeatherSprites; // 0x48
	private int weatherSpriteId; // 0x50
	private string[] SeasonStr; // 0x58
	private string[] DateStr; // 0x60
	private string timeFormatText; // 0x68
	private string dateFormatText; // 0x70
	private int Hour; // 0x78
	private int Minutes; // 0x7C
	private Season Season; // 0x80
	private int Day; // 0x84
	private DayOfWeek DayOfWeek; // 0x88

	// Methods

	// RVA: 0x22EF490 Offset: 0x22EF591 VA: 0x22EF490
	private void Awake() { }

	// RVA: 0x22EF850 Offset: 0x22EF951 VA: 0x22EF850
	private void UpdateTime() { }

	// RVA: 0x22EF9F0 Offset: 0x22EFAF1 VA: 0x22EF9F0
	private void UpdateSeason() { }

	// RVA: 0x22EFB20 Offset: 0x22EFC21 VA: 0x22EFB20
	private void UpdateDate() { }

	// RVA: 0x22EFC60 Offset: 0x22EFD61 VA: 0x22EFC60
	private void UpdateWeatherIcon() { }

	// RVA: 0x22EFDA0 Offset: 0x22EFEA1 VA: 0x22EFDA0
	private void Update() { }

	// RVA: 0x22EFDE0 Offset: 0x22EFEE1 VA: 0x22EFDE0
	public void .ctor() { }
}

