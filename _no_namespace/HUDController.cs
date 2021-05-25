public class HUDController : MonoBehaviour // TypeDefIndex: 8546
{
	// Fields
	public static HUDController _Instance; // 0x0
	private static float[,] SetFadeTimeTable; // 0x8
	private float[] nowFrameSetFade; // 0x18
	private HUDFadeMove[] HUDFadeMoves; // 0x20
	[SerializeField] // RVA: 0x170620 Offset: 0x170721 VA: 0x170620
	private AnimationCurve slideCurve; // 0x28
	[SerializeField] // RVA: 0x170630 Offset: 0x170731 VA: 0x170630
	private AnimationCurve fadeCurve; // 0x30
	[SerializeField] // RVA: 0x170640 Offset: 0x170741 VA: 0x170640
	private HUDFadeMove MiniMapObj; // 0x38
	[SerializeField] // RVA: 0x170650 Offset: 0x170751 VA: 0x170650
	private HUDFadeMove AreaNameObj; // 0x40
	[SerializeField] // RVA: 0x170660 Offset: 0x170761 VA: 0x170660
	private HUDFadeMove TimeClockObj; // 0x48
	[SerializeField] // RVA: 0x170670 Offset: 0x170771 VA: 0x170670
	private HUDFadeMove MoneyPointObj; // 0x50
	[SerializeField] // RVA: 0x170680 Offset: 0x170781 VA: 0x170680
	private HUDFadeMove PlayerStatusObj; // 0x58
	[SerializeField] // RVA: 0x170690 Offset: 0x170791 VA: 0x170690
	private HUDFadeMove PartnerAStatusObj; // 0x60
	[SerializeField] // RVA: 0x1706A0 Offset: 0x1707A1 VA: 0x1706A0
	private HUDFadeMove PartnerBStatusObj; // 0x68
	[SerializeField] // RVA: 0x1706B0 Offset: 0x1707B1 VA: 0x1706B0
	private HUDFadeMove PartnerCStatusObj; // 0x70
	[SerializeField] // RVA: 0x1706C0 Offset: 0x1707C1 VA: 0x1706C0
	private HUDFadeMove RightDownMenuObj; // 0x78
	[SerializeField] // RVA: 0x1706D0 Offset: 0x1707D1 VA: 0x1706D0
	private HUDFadeMove LeftDownMenuObj; // 0x80
	[SerializeField] // RVA: 0x1706E0 Offset: 0x1707E1 VA: 0x1706E0
	private HUDFadeMove MagnifierObj; // 0x88
	[SerializeField] // RVA: 0x1706F0 Offset: 0x1707F1 VA: 0x1706F0
	private HUDFadeMove WateringPotObj; // 0x90
	[SerializeField] // RVA: 0x170700 Offset: 0x170801 VA: 0x170700
	private HUDFadeMove MapCalendarObj; // 0x98
	[SerializeField] // RVA: 0x170710 Offset: 0x170811 VA: 0x170710
	private OrderPopControl OrderPopControl; // 0xA0
	[SerializeField] // RVA: 0x170720 Offset: 0x170821 VA: 0x170720
	private HUDCharactorStatus PlayerStatus; // 0xA8
	[SerializeField] // RVA: 0x170730 Offset: 0x170831 VA: 0x170730
	private HUDCharactorStatus PartnerAStatus; // 0xB0
	[SerializeField] // RVA: 0x170740 Offset: 0x170841 VA: 0x170740
	private HUDCharactorStatus PartnerBStatus; // 0xB8
	[SerializeField] // RVA: 0x170750 Offset: 0x170851 VA: 0x170750
	private HUDCharactorStatus PartnerCStatus; // 0xC0
	[SerializeField] // RVA: 0x170760 Offset: 0x170861 VA: 0x170760
	private Text AreaNameText; // 0xC8
	[SerializeField] // RVA: 0x170770 Offset: 0x170871 VA: 0x170770
	private Text MagnifierText; // 0xD0
	[SerializeField] // RVA: 0x170780 Offset: 0x170881 VA: 0x170780
	private GameObject CrossfireObj; // 0xD8
	private bool CrossfireIsUsOpened; // 0xE0
	[SerializeField] // RVA: 0x170790 Offset: 0x170891 VA: 0x170790
	private Text TimeClockText; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x1707A0 Offset: 0x1708A1 VA: 0x1707A0
	private bool <FocusingMagnifier>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x1707B0 Offset: 0x1708B1 VA: 0x1707B0
	private bool <IsAllHide>k__BackingField; // 0xF1
	public List<Transform> HumanList; // 0xF8
	public List<Transform> EnemyList; // 0x100
	private Vector3 PlayerPos; // 0x108
	[SerializeField] // RVA: 0x1707C0 Offset: 0x1708C1 VA: 0x1707C0
	private Transform[] MinimapParents; // 0x118
	[SerializeField] // RVA: 0x1707D0 Offset: 0x1708D1 VA: 0x1707D0
	private RectTransform MinimapRect; // 0x120
	[SerializeField] // RVA: 0x1707E0 Offset: 0x1708E1 VA: 0x1707E0
	private HUDMinimapControl MiniMapCtrl; // 0x128
	private int usingMinimapNo; // 0x130
	private HUDFadeMove tempMoneyDisp; // 0x138

	// Properties
	public static HUDController Instance { get; }
	public AnimationCurve SlideCurve { get; }
	public AnimationCurve FadeCurve { get; }
	public bool FocusingMagnifier { get; set; }
	public bool IsAllHide { get; set; }

	// Methods

	// RVA: 0x1EB97B0 Offset: 0x1EB98B1 VA: 0x1EB97B0
	public static HUDController get_Instance() { }

	// RVA: 0x1EB9820 Offset: 0x1EB9921 VA: 0x1EB9820
	public AnimationCurve get_SlideCurve() { }

	// RVA: 0x1EB9830 Offset: 0x1EB9931 VA: 0x1EB9830
	public AnimationCurve get_FadeCurve() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7C00 Offset: 0x1A7D01 VA: 0x1A7C00
	// RVA: 0x1EB9840 Offset: 0x1EB9941 VA: 0x1EB9840
	public bool get_FocusingMagnifier() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7C10 Offset: 0x1A7D11 VA: 0x1A7C10
	// RVA: 0x1EB9850 Offset: 0x1EB9951 VA: 0x1EB9850
	private void set_FocusingMagnifier(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7C20 Offset: 0x1A7D21 VA: 0x1A7C20
	// RVA: 0x1EB9860 Offset: 0x1EB9961 VA: 0x1EB9860
	public bool get_IsAllHide() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7C30 Offset: 0x1A7D31 VA: 0x1A7C30
	// RVA: 0x1EB9870 Offset: 0x1EB9971 VA: 0x1EB9870
	private void set_IsAllHide(bool value) { }

	// RVA: 0x1EB9880 Offset: 0x1EB9981 VA: 0x1EB9880
	public static void AddHuman(Transform _transform) { }

	// RVA: 0x1EB9C00 Offset: 0x1EB9D01 VA: 0x1EB9C00
	public static void AddEnemy(Transform _transform) { }

	// RVA: 0x1EB9F80 Offset: 0x1EBA081 VA: 0x1EB9F80
	public static void RemoveEnemy(Transform _transform) { }

	// RVA: 0x1EBA170 Offset: 0x1EBA271 VA: 0x1EBA170
	private void Awake() { }

	// RVA: 0x1EBAE60 Offset: 0x1EBAF61 VA: 0x1EBAE60
	private void CheckPlayerMove() { }

	// RVA: 0x1EBB070 Offset: 0x1EBB171 VA: 0x1EBB070
	public void SetAllFadeTime(float time) { }

	// RVA: 0x1EBA9A0 Offset: 0x1EBAAA1 VA: 0x1EBA9A0
	public void SetAllHide(bool s) { }

	// RVA: 0x1EBB560 Offset: 0x1EBB661 VA: 0x1EBB560
	private void CheckSetButton() { }

	// RVA: 0x1EBB600 Offset: 0x1EBB701 VA: 0x1EBB600
	public void MinimapSwitcher() { }

	// RVA: 0x1EBB9B0 Offset: 0x1EBBAB1 VA: 0x1EBB9B0
	private void Update() { }

	// RVA: 0x1EBBE00 Offset: 0x1EBBF01 VA: 0x1EBBE00
	public void SetEnterSafeZone() { }

	// RVA: 0x1EBBE10 Offset: 0x1EBBF11 VA: 0x1EBBE10
	public void SetExitSafeZone() { }

	// RVA: 0x1EBBE20 Offset: 0x1EBBF21 VA: 0x1EBBE20
	public void SetExitEnemyZone() { }

	// RVA: 0x1EBBE30 Offset: 0x1EBBF31 VA: 0x1EBBE30
	public static OrderHUDBlock AddHudBlock(OrderData data) { }

	// RVA: 0x1EBBFF0 Offset: 0x1EBC0F1 VA: 0x1EBBFF0
	public void CheckPartnerForceFadeOut() { }

	// RVA: 0x1EBC140 Offset: 0x1EBC241 VA: 0x1EBC140
	public void OnPartnerChange() { }

	// RVA: 0x1EBC1F0 Offset: 0x1EBC2F1 VA: 0x1EBC1F0
	public void OnPlayerMoveStat(HUDController.PlayerMoveStat playerMoveStat) { }

	// RVA: 0x1EBA540 Offset: 0x1EBA641 VA: 0x1EBA540
	private void SetHUDFadeMoveToTable() { }

	// RVA: 0x1EBBD30 Offset: 0x1EBBE31 VA: 0x1EBBD30
	private void SetFadeTime() { }

	// RVA: 0x1EB86A0 Offset: 0x1EB87A1 VA: 0x1EB86A0
	public void SetCharacterFadeTimeEnd(HUDCharactorStatus.CharactorType charaType) { }

	// RVA: 0x1EB8970 Offset: 0x1EB8A71 VA: 0x1EB8970
	public void SetHUDState(HUDController.HUD_DoState doState) { }

	// RVA: 0x1EBC200 Offset: 0x1EBC301 VA: 0x1EBC200
	public void SetMagnifier(string text = "") { }

	// RVA: 0x1EBC2F0 Offset: 0x1EBC3F1 VA: 0x1EBC2F0
	public void OnQuickMenu(bool flag) { }

	// RVA: 0x1EBAE00 Offset: 0x1EBAF01 VA: 0x1EBAE00
	public void TurnOnTimeClockText(bool stat) { }

	// RVA: 0x1EBC510 Offset: 0x1EBC611 VA: 0x1EBC510
	public void SetAreaChangeText(string AreaName) { }

	// RVA: 0x1EBBCD0 Offset: 0x1EBBDD1 VA: 0x1EBBCD0
	public void TurnCrossfire(bool OnOff) { }

	// RVA: 0x1EBC5D0 Offset: 0x1EBC6D1 VA: 0x1EBC5D0
	public void DispTempMoney() { }

	// RVA: 0x1EBC970 Offset: 0x1EBCA71 VA: 0x1EBC970
	public void EndTempMoney() { }

	// RVA: 0x1EBCA40 Offset: 0x1EBCB41 VA: 0x1EBCA40
	public void InitGameMain() { }

	// RVA: 0x1EBCA90 Offset: 0x1EBCB91 VA: 0x1EBCA90
	public void .ctor() { }

	// RVA: 0x1EBCB30 Offset: 0x1EBCC31 VA: 0x1EBCB30
	private static void .cctor() { }
}

