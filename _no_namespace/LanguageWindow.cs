public class LanguageWindow : MonoBehaviour // TypeDefIndex: 8868
{
	// Fields
	[SerializeField] // RVA: 0x174610 Offset: 0x174711 VA: 0x174610
	private GameObject winBg; // 0x18
	[SerializeField] // RVA: 0x174620 Offset: 0x174721 VA: 0x174620
	private RectTransform windowMask; // 0x20
	[SerializeField] // RVA: 0x174630 Offset: 0x174731 VA: 0x174630
	private RectTransform windowAcs; // 0x28
	[SerializeField] // RVA: 0x174640 Offset: 0x174741 VA: 0x174640
	private RectTransform windowFrm; // 0x30
	[SerializeField] // RVA: 0x174650 Offset: 0x174751 VA: 0x174650
	private RectTransform rectLng; // 0x38
	[SerializeField] // RVA: 0x174660 Offset: 0x174761 VA: 0x174660
	private RectTransform rectVoice; // 0x40
	[SerializeField] // RVA: 0x174670 Offset: 0x174771 VA: 0x174670
	private RectTransform rectOk; // 0x48
	[SerializeField] // RVA: 0x174680 Offset: 0x174781 VA: 0x174680
	private Text InfoTitleL; // 0x50
	[SerializeField] // RVA: 0x174690 Offset: 0x174791 VA: 0x174690
	private Text InfoTitleV; // 0x58
	[SerializeField] // RVA: 0x1746A0 Offset: 0x1747A1 VA: 0x1746A0
	private Text InfoBtnTextL; // 0x60
	[SerializeField] // RVA: 0x1746B0 Offset: 0x1747B1 VA: 0x1746B0
	private Text InfoBtnTextV; // 0x68
	[SerializeField] // RVA: 0x1746C0 Offset: 0x1747C1 VA: 0x1746C0
	private TitleLangButton[] ButtonListLV; // 0x70
	[SerializeField] // RVA: 0x1746D0 Offset: 0x1747D1 VA: 0x1746D0
	private TitleLangButton[] ButtonListL; // 0x78
	private int focusing; // 0x80
	private static int _selectLngNo; // 0x0
	private static int _selectVoiceNo; // 0x4
	private LanguageWindow.LngButtonType btnType; // 0x84
	private bool ButtonStarted; // 0x88
	private LanguageWindow.LngStep step; // 0x8C
	private LanguageWindow.WindowType winMode; // 0x90
	private int langCnt; // 0x94
	private bool changeLang; // 0x98
	private SystemLanguage voiceLang; // 0x9C
	private Dictionary<SystemLanguage, string> LanguageString; // 0xA0
	private Dictionary<SystemLanguage, string> LanguageVoiceString; // 0xA8
	private Vector2[] WindowSizeTbl; // 0xB0
	private Vector2[] LngBtnPosTbl; // 0xB8
	private Vector2[] voiceBtnPosTbl; // 0xC0
	private Vector2[] okBtnPosTbl; // 0xC8

	// Properties
	public int selectLngNo { get; set; }
	public int selectVoiceNo { get; set; }

	// Methods

	// RVA: 0x2180DD0 Offset: 0x2180ED1 VA: 0x2180DD0
	public int get_selectLngNo() { }

	// RVA: 0x2180E20 Offset: 0x2180F21 VA: 0x2180E20
	public void set_selectLngNo(int value) { }

	// RVA: 0x2180E80 Offset: 0x2180F81 VA: 0x2180E80
	public int get_selectVoiceNo() { }

	// RVA: 0x2180ED0 Offset: 0x2180FD1 VA: 0x2180ED0
	public void set_selectVoiceNo(int value) { }

	// RVA: 0x2180F30 Offset: 0x2181031 VA: 0x2180F30
	private void Start() { }

	// RVA: 0x2180F40 Offset: 0x2181041 VA: 0x2180F40
	private void Update() { }

	// RVA: 0x2181190 Offset: 0x2181291 VA: 0x2181190
	private void initParam() { }

	// RVA: 0x2181280 Offset: 0x2181381 VA: 0x2181280
	private void createInfoWindow(LanguageWindow.WindowType type) { }

	// RVA: 0x21810A0 Offset: 0x21811A1 VA: 0x21810A0
	private void activeButton(int moveNum) { }

	// RVA: 0x2181790 Offset: 0x2181891 VA: 0x2181790
	private void setButton(LanguageWindow.LngButtonType type) { }

	// RVA: 0x21818F0 Offset: 0x21819F1 VA: 0x21818F0
	public void onWindow() { }

	// RVA: 0x2181C40 Offset: 0x2181D41 VA: 0x2181C40
	public void offWindow() { }

	// RVA: 0x2181C70 Offset: 0x2181D71 VA: 0x2181C70
	public void StartButton(LanguageWindow.LngButtonType type) { }

	// RVA: 0x2181F90 Offset: 0x2182091 VA: 0x2181F90
	public void LRButton(LanguageWindow.LngButtonType type, int addVal) { }

	// RVA: 0x2182360 Offset: 0x2182461 VA: 0x2182360
	public LanguageWindow.LngStep getStep() { }

	// RVA: 0x2182370 Offset: 0x2182471 VA: 0x2182370
	public void touchLngButton(int no) { }

	// RVA: 0x21825F0 Offset: 0x21826F1 VA: 0x21825F0
	public bool getChangeLang() { }

	// RVA: 0x2182600 Offset: 0x2182701 VA: 0x2182600
	public void .ctor() { }
}

