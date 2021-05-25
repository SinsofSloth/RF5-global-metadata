public class UIMainController : SingletonMonoBehaviour<UIMainController> // TypeDefIndex: 8916
{
	// Fields
	[SerializeField] // RVA: 0x174A80 Offset: 0x174B81 VA: 0x174A80
	private GameObject[] HUDMainObjectList; // 0x18
	private uint inputStateFlag; // 0x20
	private const uint CursorInputStateBlocker = 15848;
	private const uint UISystemInputStateBlocker = 16376;
	[SerializeField] // RVA: 0x174A90 Offset: 0x174B91 VA: 0x174A90
	private RectTransform _CharactorLog; // 0x28
	[SerializeField] // RVA: 0x174AA0 Offset: 0x174BA1 VA: 0x174AA0
	private UIFadeScreen UIFadeScreenAdvChatBlur; // 0x30
	[SerializeField] // RVA: 0x174AB0 Offset: 0x174BB1 VA: 0x174AB0
	private UIFadeScreen UIFadeScreenUnderAdv; // 0x38
	[SerializeField] // RVA: 0x174AC0 Offset: 0x174BC1 VA: 0x174AC0
	private UIFadeScreen UIFadeScreenOverAdv; // 0x40
	[SerializeField] // RVA: 0x174AD0 Offset: 0x174BD1 VA: 0x174AD0
	private UIFadeScreen UIFadeScreenOverChoice; // 0x48
	[SerializeField] // RVA: 0x174AE0 Offset: 0x174BE1 VA: 0x174AE0
	private RectTransform DamageHpParent; // 0x50
	[SerializeField] // RVA: 0x174AF0 Offset: 0x174BF1 VA: 0x174AF0
	private TwoChoicePopupMain TwoChoicePopupMain; // 0x58
	private TwoChoicePopupMain nowTwoChoicePopupMain; // 0x60
	[SerializeField] // RVA: 0x174B00 Offset: 0x174C01 VA: 0x174B00
	private NoChoicePopupMain NoChoicePopupMain; // 0x68
	private NoChoicePopupMain nowNoChoicePopupMain; // 0x70
	[SerializeField] // RVA: 0x174B10 Offset: 0x174C11 VA: 0x174B10
	private CutInTelopControl CutInTelopControl; // 0x78
	[SerializeField] // RVA: 0x174B20 Offset: 0x174C21 VA: 0x174B20
	private RectTransform _MinigameUI; // 0x80
	[SerializeField] // RVA: 0x174B30 Offset: 0x174C31 VA: 0x174B30
	private ButtonHintMain ButtonHintMain; // 0x88
	[SerializeField] // RVA: 0x174B40 Offset: 0x174C41 VA: 0x174B40
	private Canvas AddSystemPopupCanvas; // 0x90
	public GameObject UIBackScreenObject; // 0x98
	public CampMenuMain CampMenuMain; // 0xA0
	public string CurrentMap; // 0xA8
	public string FieldSceneName; // 0xB0
	public GameObject SetOnField; // 0xB8
	private const int damageTextStockMax = 10;
	private List<DamageText> damageTextObject; // 0xC0
	private List<Light> _RealtimeBakeLightList; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x174B50 Offset: 0x174C51 VA: 0x174B50
	private bool <PlayerHoldNotItemOnHand>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x174B60 Offset: 0x174C61 VA: 0x174B60
	private bool <PlayerRiding>k__BackingField; // 0xD1
	private RenameMobControl RenameMobControl; // 0xD8
	private static int ScreenFadeUsing; // 0x0
	private const int ScreenFilter_AdvChatBlur = 1;
	private const int ScreenFilter_UnderAdv = 2;
	private const int ScreenFilter_OverAdv = 4;
	private const int ScreenFilter_OverChoice = 8;
	[CompilerGeneratedAttribute] // RVA: 0x174B70 Offset: 0x174C71 VA: 0x174B70
	private ButtonGuideId <usingButtonGuideId>k__BackingField; // 0xE0

	// Properties
	public RectTransform CharactorLog { get; }
	public RectTransform MinigameUI { get; }
	public Canvas SystemCanvas { get; }
	public Camera UICamera { get; }
	public List<Light> RealtimeBakeLightList { get; }
	public bool PlayerHoldNotItemOnHand { get; set; }
	public bool PlayerRiding { get; set; }
	public bool PlayerBlockHoldItemByUI { get; }
	public ButtonGuideId usingButtonGuideId { get; set; }

	// Methods

	// RVA: 0x1EDA9C0 Offset: 0x1EDAAC1 VA: 0x1EDA9C0
	public RectTransform get_CharactorLog() { }

	// RVA: 0x1EDA9D0 Offset: 0x1EDAAD1 VA: 0x1EDA9D0
	public RectTransform get_MinigameUI() { }

	// RVA: 0x1EDA9E0 Offset: 0x1EDAAE1 VA: 0x1EDA9E0
	public Canvas get_SystemCanvas() { }

	// RVA: 0x1EDA9F0 Offset: 0x1EDAAF1 VA: 0x1EDA9F0
	public Camera get_UICamera() { }

	// RVA: 0x1EDAA60 Offset: 0x1EDAB61 VA: 0x1EDAA60
	public List<Light> get_RealtimeBakeLightList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9100 Offset: 0x1A9201 VA: 0x1A9100
	// RVA: 0x1EDAA70 Offset: 0x1EDAB71 VA: 0x1EDAA70
	public bool get_PlayerHoldNotItemOnHand() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9110 Offset: 0x1A9211 VA: 0x1A9110
	// RVA: 0x1EDAA80 Offset: 0x1EDAB81 VA: 0x1EDAA80
	private void set_PlayerHoldNotItemOnHand(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9120 Offset: 0x1A9221 VA: 0x1A9120
	// RVA: 0x1EDAA90 Offset: 0x1EDAB91 VA: 0x1EDAA90
	public bool get_PlayerRiding() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9130 Offset: 0x1A9231 VA: 0x1A9130
	// RVA: 0x1EDAAA0 Offset: 0x1EDABA1 VA: 0x1EDAAA0
	private void set_PlayerRiding(bool value) { }

	// RVA: 0x1ED5130 Offset: 0x1ED5231 VA: 0x1ED5130
	public bool get_PlayerBlockHoldItemByUI() { }

	// RVA: 0x1EDAAB0 Offset: 0x1EDABB1 VA: 0x1EDAAB0
	public void ReCheckEquipNotItemOnHand() { }

	// RVA: 0x1EDAC30 Offset: 0x1EDAD31 VA: 0x1EDAC30
	public void AddRealtimeBakeLight(Light light) { }

	// RVA: 0x1EDACD0 Offset: 0x1EDADD1 VA: 0x1EDACD0
	public void RemoveRealtimeBakeLight(Light light) { }

	// RVA: 0x1EDAD70 Offset: 0x1EDAE71 VA: 0x1EDAD70
	public void ClearRealtimeBakeLightList() { }

	// RVA: 0x1EDADD0 Offset: 0x1EDAED1 VA: 0x1EDADD0
	public void SetRealtimeBakeLightList(bool isEnable) { }

	// RVA: 0x1EDAED0 Offset: 0x1EDAFD1 VA: 0x1EDAED0
	public void OpenRenameMobSelector() { }

	// RVA: 0x1EDAF50 Offset: 0x1EDB051 VA: 0x1EDAF50
	public void EndRenameMobSelector() { }

	// RVA: 0x1EDAF60 Offset: 0x1EDB061 VA: 0x1EDAF60
	private void CheckMapSet() { }

	// RVA: 0x1ED8870 Offset: 0x1ED8971 VA: 0x1ED8870
	public void SetStartInputState(UIMainController.UIInputState inputState) { }

	// RVA: 0x1ED8D30 Offset: 0x1ED8E31 VA: 0x1ED8D30
	public void ReleaseInputState(UIMainController.UIInputState inputState) { }

	// RVA: 0x1EDB1B0 Offset: 0x1EDB2B1 VA: 0x1EDB1B0
	public bool IsOtherInputUsing(UIMainController.UIInputState myInputState) { }

	// RVA: 0x1ED4910 Offset: 0x1ED4A11 VA: 0x1ED4910
	public bool IsUsing(UIMainController.UIInputState myInputState) { }

	// RVA: 0x1EDB1C0 Offset: 0x1EDB2C1 VA: 0x1EDB1C0
	public bool IsUISystemBlockInput() { }

	// RVA: 0x1EDB1E0 Offset: 0x1EDB2E1 VA: 0x1EDB1E0
	public bool IsBlockCursorInput() { }

	// RVA: 0x1EDB200 Offset: 0x1EDB301 VA: 0x1EDB200
	public void TurnOnHud() { }

	// RVA: 0x1EDB270 Offset: 0x1EDB371 VA: 0x1EDB270
	public void TurnOffHud() { }

	// RVA: 0x1EDB2E0 Offset: 0x1EDB3E1 VA: 0x1EDB2E0
	private void AddScreenFadeUsing(bool fadeUsing, int filter) { }

	// RVA: 0x1EDB3A0 Offset: 0x1EDB4A1 VA: 0x1EDB3A0
	public bool IsScreenFadeUsing() { }

	// RVA: 0x1EDB410 Offset: 0x1EDB511 VA: 0x1EDB410
	public bool IsUnderAdvToBlack() { }

	// RVA: 0x1EDB430 Offset: 0x1EDB531 VA: 0x1EDB430
	public void ScreenFadeChat(float fadeTime, Color fadeColor, int fadeStat = 2) { }

	// RVA: 0x1EDB5F0 Offset: 0x1EDB6F1 VA: 0x1EDB5F0
	public void ScreenFadeChat(float fadeTime, int fadeStat) { }

	// RVA: 0x1EDB7B0 Offset: 0x1EDB8B1 VA: 0x1EDB7B0
	public void ScreenFade(float fadeTime, Color fadeColor, int fadeStat = 2) { }

	// RVA: 0x1EDB970 Offset: 0x1EDBA71 VA: 0x1EDB970
	public void ScreenFade(float fadeTime, int fadeStat) { }

	// RVA: 0x1EDBB40 Offset: 0x1EDBC41 VA: 0x1EDBB40
	public void OverAdvDialogFade(float fadeTime, Color fadeColor, int fadeStat = 2) { }

	// RVA: 0x1EDBD00 Offset: 0x1EDBE01 VA: 0x1EDBD00
	public void OverAdvDialogFade(float fadeTime, int fadeStat) { }

	// RVA: 0x1EDBED0 Offset: 0x1EDBFD1 VA: 0x1EDBED0
	public void OverAdvChoiceFade(float fadeTime, Color fadeColor, int fadeStat = 2) { }

	// RVA: 0x1EDC090 Offset: 0x1EDC191 VA: 0x1EDC090
	public void OverAdvChoiceFade(float fadeTime, int fadeStat) { }

	// RVA: 0x1EDC260 Offset: 0x1EDC361 VA: 0x1EDC260
	public GameObject GetSimpleHpBar() { }

	// RVA: 0x1EDC320 Offset: 0x1EDC421 VA: 0x1EDC320
	private void InitDamageText() { }

	// RVA: 0x1EDC490 Offset: 0x1EDC591 VA: 0x1EDC490
	private DamageText GetDamageTextObject() { }

	// RVA: 0x1EDC680 Offset: 0x1EDC781 VA: 0x1EDC680
	public void EndDamageTextObject(DamageText damageText) { }

	// RVA: 0x1EDC800 Offset: 0x1EDC901 VA: 0x1EDC800
	public void ShowDamage(Vector3 _position, float _damage, UIDamageType _type, bool _is_crit = False, bool _is_weak = False, bool _is_resist = False) { }

	// RVA: 0x1EDC950 Offset: 0x1EDCA51 VA: 0x1EDC950
	public void OpenTwoChoicePopup(UnityAction<bool> unityAction, string str, bool StartOnYesButton = True) { }

	// RVA: 0x1EDCA30 Offset: 0x1EDCB31 VA: 0x1EDCA30
	public void OpenNoChoicePopup(UnityAction<bool> unityAction, string str, TextAnchor anchor = 4) { }

	// RVA: 0x1EDCB10 Offset: 0x1EDCC11 VA: 0x1EDCB10
	public void EndTwoChoicePopup() { }

	// RVA: 0x1EDCB20 Offset: 0x1EDCC21 VA: 0x1EDCB20
	public void EndNoChoicePopup() { }

	// RVA: 0x1EDCB30 Offset: 0x1EDCC31 VA: 0x1EDCB30
	public void SetCutInTelop(string textId, float stayTime, bool PlaySE) { }

	// RVA: 0x1EDCC00 Offset: 0x1EDCD01 VA: 0x1EDCC00
	private void Update() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9140 Offset: 0x1A9241 VA: 0x1A9140
	// RVA: 0x1EDCC10 Offset: 0x1EDCD11 VA: 0x1EDCC10
	public ButtonGuideId get_usingButtonGuideId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9150 Offset: 0x1A9251 VA: 0x1A9150
	// RVA: 0x1EDCC20 Offset: 0x1EDCD21 VA: 0x1EDCC20
	private void set_usingButtonGuideId(ButtonGuideId value) { }

	// RVA: 0x1EDCC30 Offset: 0x1EDCD31 VA: 0x1EDCC30
	public ButtonGuideId GetNowButtonHintId() { }

	// RVA: 0x1ED4920 Offset: 0x1ED4A21 VA: 0x1ED4920
	public void SetButtonHint(ButtonGuideId id) { }

	// RVA: 0x1EDCC40 Offset: 0x1EDCD41 VA: 0x1EDCC40
	public void SetButtonHint(ButtonType buttonType, TextId textId = 0) { }

	// RVA: 0x1ED8DE0 Offset: 0x1ED8EE1 VA: 0x1ED8DE0
	public void ClearButtonHint() { }

	// RVA: 0x1EDCC80 Offset: 0x1EDCD81 VA: 0x1EDCC80
	public static bool CheckStorageFurniture(StorageType storageType) { }

	// RVA: 0x1EDCF30 Offset: 0x1EDD031 VA: 0x1EDCF30
	public static bool EnableOpenMenu() { }

	// RVA: 0x1EDD0B0 Offset: 0x1EDD1B1 VA: 0x1EDD0B0
	public static void DoScriptUICommand(int valueA) { }

	// RVA: 0x1EDD3C0 Offset: 0x1EDD4C1 VA: 0x1EDD3C0
	private void Start() { }

	// RVA: 0x1EDD3D0 Offset: 0x1EDD4D1 VA: 0x1EDD3D0
	public void .ctor() { }

	// RVA: 0x1EDD470 Offset: 0x1EDD571 VA: 0x1EDD470
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9160 Offset: 0x1A9261 VA: 0x1A9160
	// RVA: 0x1EDD480 Offset: 0x1EDD581 VA: 0x1EDD480
	private void <ScreenFadeChat>b__72_0(bool fade) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9170 Offset: 0x1A9271 VA: 0x1A9170
	// RVA: 0x1EDD530 Offset: 0x1EDD631 VA: 0x1EDD530
	private void <ScreenFadeChat>b__73_0(bool fade) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9180 Offset: 0x1A9281 VA: 0x1A9180
	// RVA: 0x1EDD5E0 Offset: 0x1EDD6E1 VA: 0x1EDD5E0
	private void <ScreenFade>b__74_0(bool fade) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9190 Offset: 0x1A9291 VA: 0x1A9190
	// RVA: 0x1EDD6A0 Offset: 0x1EDD7A1 VA: 0x1EDD6A0
	private void <ScreenFade>b__75_0(bool fade) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A91A0 Offset: 0x1A92A1 VA: 0x1A91A0
	// RVA: 0x1EDD760 Offset: 0x1EDD861 VA: 0x1EDD760
	private void <OverAdvDialogFade>b__76_0(bool fade) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A91B0 Offset: 0x1A92B1 VA: 0x1A91B0
	// RVA: 0x1EDD820 Offset: 0x1EDD921 VA: 0x1EDD820
	private void <OverAdvDialogFade>b__77_0(bool fade) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A91C0 Offset: 0x1A92C1 VA: 0x1A91C0
	// RVA: 0x1EDD8E0 Offset: 0x1EDD9E1 VA: 0x1EDD8E0
	private void <OverAdvChoiceFade>b__78_0(bool fade) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A91D0 Offset: 0x1A92D1 VA: 0x1A91D0
	// RVA: 0x1EDD9A0 Offset: 0x1EDDAA1 VA: 0x1EDD9A0
	private void <OverAdvChoiceFade>b__79_0(bool fade) { }
}

