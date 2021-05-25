public class TitleCanvasControl : MonoBehaviour // TypeDefIndex: 8875
{
	// Fields
	[SerializeField] // RVA: 0x174710 Offset: 0x174811 VA: 0x174710
	private TitleButton[] ButtonList; // 0x18
	private int focusing; // 0x20
	[SerializeField] // RVA: 0x174720 Offset: 0x174821 VA: 0x174720
	private Canvas buttonCanvas; // 0x28
	[SerializeField] // RVA: 0x174730 Offset: 0x174831 VA: 0x174730
	private RectTransform buttonCanRect; // 0x30
	[SerializeField] // RVA: 0x174740 Offset: 0x174841 VA: 0x174740
	private Canvas pressCanvas; // 0x38
	[SerializeField] // RVA: 0x174750 Offset: 0x174851 VA: 0x174750
	private Image pressText; // 0x40
	[SerializeField] // RVA: 0x174760 Offset: 0x174861 VA: 0x174760
	private Image pressBorder; // 0x48
	[SerializeField] // RVA: 0x174770 Offset: 0x174871 VA: 0x174770
	private RectTransform menuBgRect; // 0x50
	[SerializeField] // RVA: 0x174780 Offset: 0x174881 VA: 0x174780
	private VoiceComment voiceComment; // 0x58
	[SerializeField] // RVA: 0x174790 Offset: 0x174891 VA: 0x174790
	private LanguageWindow langWindowCntl; // 0x60
	[SerializeField] // RVA: 0x1747A0 Offset: 0x1748A1 VA: 0x1747A0
	private LoadLogoAnim loadLogoAnimCntl; // 0x68
	[SerializeField] // RVA: 0x1747B0 Offset: 0x1748B1 VA: 0x1747B0
	private Image imgFade; // 0x70
	[SerializeField] // RVA: 0x1747C0 Offset: 0x1748C1 VA: 0x1747C0
	private GameObject objTouchScreen; // 0x78
	[SerializeField] // RVA: 0x1747D0 Offset: 0x1748D1 VA: 0x1747D0
	private TwoChoicePopupLite TwoChoicePopupLite; // 0x80
	[SerializeField] // RVA: 0x1747E0 Offset: 0x1748E1 VA: 0x1747E0
	private NoChoicePopupLite NoChoicePopupLite; // 0x88
	private TitleCanvasControl.TitleButtonType btnType; // 0x90
	private bool ButtonStarted; // 0x94
	private float fadeTime; // 0x98
	private float fadeTimeMax; // 0x9C
	private int fadeType; // 0xA0
	private Sprite _sprBg; // 0xA8
	private Image _imgBg; // 0xB0
	private int _sprId; // 0xB8
	private TitleCanvasControl.TitleStep step; // 0xBC
	private float pressSin; // 0xC0
	private TitleMenu titleMenu; // 0xC8
	private float stayTime; // 0xD0
	private int charaAnimStep; // 0xD4
	private bool inputFlg; // 0xD8
	private bool m_touchBtn; // 0xD9
	private SoundID callId; // 0xDC
	private PlayableDirector logoAnimTimeline; // 0xE0
	private bool autosaveMessFlg; // 0xE8
	private SoundID[] TitleCallList; // 0xF0
	private int[] TitleCallRate; // 0xF8
	private Dictionary<TitleCanvasControl.TitleCallID, RF5SystemData.FLAG> TitleCallIdToFlag; // 0x100
	private TitleCanvasControl.TitleButtonType[,] menuList; // 0x108
	private float[,] MenuBtnLayoutList; // 0x110
	private int[] MenuListLayoutY; // 0x118
	private int btnListMax; // 0x120
	private int btnSelect; // 0x124
	private int btnListType; // 0x128
	private UITextDic.DICID[] dlcTextName4sp; // 0x130
	private UITextDic.DICID[] dlcTextNameLimited; // 0x138
	private UITextDic.DICID[] dlcTextNameShopList; // 0x140
	private UITextDic.DICID dlcCosInfoTextName; // 0x148
	private UITextDic.DICID dlcItemInfoTextName; // 0x14C
	private List<string> dlcMessList; // 0x150
	private bool addDLCCosFlg; // 0x158
	private bool addDLCItemFlg; // 0x159
	[SerializeField] // RVA: 0x1747F0 Offset: 0x1748F1 VA: 0x1747F0
	private GameObject LoadGamePage; // 0x160

	// Properties
	public bool IsOffInput { get; }

	// Methods

	// RVA: 0x1D24910 Offset: 0x1D24A11 VA: 0x1D24910
	private static extern void OpenURL(string url) { }

	// RVA: 0x1D24940 Offset: 0x1D24A41 VA: 0x1D24940
	public bool get_IsOffInput() { }

	// RVA: 0x1D24950 Offset: 0x1D24A51 VA: 0x1D24950
	private void Start() { }

	// RVA: 0x1D24D60 Offset: 0x1D24E61 VA: 0x1D24D60
	private void Update() { }

	// RVA: 0x1D261D0 Offset: 0x1D262D1 VA: 0x1D261D0
	private void OnDestroy() { }

	// RVA: 0x1D25F50 Offset: 0x1D26051 VA: 0x1D25F50
	private void DoButton() { }

	// RVA: 0x1D25B60 Offset: 0x1D25C61 VA: 0x1D25B60
	private void updatePressButton() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8BE0 Offset: 0x1A8CE1 VA: 0x1A8BE0
	// RVA: 0x1D262C0 Offset: 0x1D263C1 VA: 0x1D262C0
	private IEnumerator createBg(int id) { }

	// RVA: 0x1D26380 Offset: 0x1D26481 VA: 0x1D26380
	private void initUI() { }

	// RVA: 0x1D25880 Offset: 0x1D25981 VA: 0x1D25880
	private void setUI() { }

	// RVA: 0x1D260C0 Offset: 0x1D261C1 VA: 0x1D260C0
	private void updateMovieFade() { }

	// RVA: 0x1D24A50 Offset: 0x1D24B51 VA: 0x1D24A50
	private int getButtonMax() { }

	// RVA: 0x1D263C0 Offset: 0x1D264C1 VA: 0x1D263C0
	private int getTitleMenuType(RegionDefine.Region region) { }

	// RVA: 0x1D24AE0 Offset: 0x1D24BE1 VA: 0x1D24AE0
	private void initButtonMenu() { }

	// RVA: 0x1D26610 Offset: 0x1D26711 VA: 0x1D26610
	private void SetFocusButtonMenu(TitleCanvasControl.TitleButtonType type) { }

	// RVA: 0x1D263D0 Offset: 0x1D264D1 VA: 0x1D263D0
	private void initButtonPos() { }

	// RVA: 0x1D25CB0 Offset: 0x1D25DB1 VA: 0x1D25CB0
	private void updateButtonNo(int addVal) { }

	// RVA: 0x1D26820 Offset: 0x1D26921 VA: 0x1D26820
	private bool IsGameData() { }

	// RVA: 0x1D244B0 Offset: 0x1D245B1 VA: 0x1D244B0
	public void StartButton(TitleCanvasControl.TitleButtonType type) { }

	// RVA: 0x1D26900 Offset: 0x1D26A01 VA: 0x1D26900
	private void OpenOnlineManual(string manualUrl) { }

	// RVA: 0x1D25DF0 Offset: 0x1D25EF1 VA: 0x1D25DF0
	private void setButtonActive(bool flag) { }

	// RVA: 0x1D26930 Offset: 0x1D26A31 VA: 0x1D26930
	public void titleCanvasReset() { }

	// RVA: 0x1D26A90 Offset: 0x1D26B91 VA: 0x1D26A90
	public TitleCanvasControl.TitleStep getStep() { }

	// RVA: 0x1D26AA0 Offset: 0x1D26BA1 VA: 0x1D26AA0
	public void setStep(TitleCanvasControl.TitleStep stepno) { }

	// RVA: 0x1D26AB0 Offset: 0x1D26BB1 VA: 0x1D26AB0
	public bool getInputFlg() { }

	// RVA: 0x1D26AC0 Offset: 0x1D26BC1 VA: 0x1D26AC0
	public void setInputFlg(bool flg) { }

	// RVA: 0x1D26AD0 Offset: 0x1D26BD1 VA: 0x1D26AD0
	public void setMovieFadeOut(float time) { }

	// RVA: 0x1D26AE0 Offset: 0x1D26BE1 VA: 0x1D26AE0
	public void setMovieFadeIn(float time) { }

	// RVA: 0x1D26B00 Offset: 0x1D26C01 VA: 0x1D26B00
	public bool isPlayingMovieFade() { }

	// RVA: 0x1D24290 Offset: 0x1D24391 VA: 0x1D24290
	public void touchTitleButton(int no) { }

	// RVA: 0x1D26B10 Offset: 0x1D26C11 VA: 0x1D26B10
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8C50 Offset: 0x1A8D51 VA: 0x1A8C50
	// RVA: 0x1D27340 Offset: 0x1D27441 VA: 0x1D27340
	private void <Update>b__58_1(DLCID[] dlcids) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8C60 Offset: 0x1A8D61 VA: 0x1A8C60
	// RVA: 0x1D27890 Offset: 0x1D27991 VA: 0x1D27890
	private void <Update>b__58_0(bool a) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8C70 Offset: 0x1A8D71 VA: 0x1A8C70
	// RVA: 0x1D278A0 Offset: 0x1D279A1 VA: 0x1D278A0
	private void <StartButton>b__73_1(bool a) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8C80 Offset: 0x1A8D81 VA: 0x1A8C80
	// RVA: 0x1D279A0 Offset: 0x1D27AA1 VA: 0x1D279A0
	private void <StartButton>b__73_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8C90 Offset: 0x1A8D91 VA: 0x1A8C90
	// RVA: 0x1D279B0 Offset: 0x1D27AB1 VA: 0x1D279B0
	private void <StartButton>b__73_2(bool a) { }
}

