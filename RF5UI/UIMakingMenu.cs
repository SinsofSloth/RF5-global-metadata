public class UIMakingMenu : CursorLinkConnector // TypeDefIndex: 9829
{
	// Fields
	[SerializeField] // RVA: 0x17F730 Offset: 0x17F831 VA: 0x17F730
	private PopupChoiceControl PopupChoiceControl; // 0x58
	private List<int> makingHeadChoiceIDs; // 0x60
	private List<List<int>> makingIDs; // 0x68
	private MakingTable MakingTable; // 0x70
	[SerializeField] // RVA: 0x17F740 Offset: 0x17F841 VA: 0x17F740
	private UIFadeOnOffAnimate UIFadeOnOffAnimate; // 0x78
	[SerializeField] // RVA: 0x17F750 Offset: 0x17F851 VA: 0x17F750
	private UIOnOffAnimate PlayerMoneyBarAnimate; // 0x80
	private int selectedHeadId; // 0x88
	[SerializeField] // RVA: 0x17F760 Offset: 0x17F861 VA: 0x17F760
	private Animator OrderSuccessAnimator; // 0x90
	private Animator useOrderSuccessAnimator; // 0x98
	private MakingID DoSuccessID; // 0xA0
	private bool isWaitingAfterSuccessTalkEnd; // 0xA4
	private List<int> selectNpcList; // 0xA8
	private AdvDialogControl _AdvDialogControl; // 0xB0
	[SerializeField] // RVA: 0x17F770 Offset: 0x17F871 VA: 0x17F770
	private UISaveMenuManager UIMakingSaveLoadMenu; // 0xB8
	private readonly string[] SeasonTextId; // 0xC0
	[SerializeField] // RVA: 0x17F780 Offset: 0x17F881 VA: 0x17F780
	private Text PlayerMoneyText; // 0xC8
	[SerializeField] // RVA: 0x17F790 Offset: 0x17F891 VA: 0x17F790
	private Text PlayerPointText; // 0xD0
	[SerializeField] // RVA: 0x17F7A0 Offset: 0x17F8A1 VA: 0x17F7A0
	private Text PlayerStoneText; // 0xD8
	[SerializeField] // RVA: 0x17F7B0 Offset: 0x17F8B1 VA: 0x17F7B0
	private Text PlayerLumberText; // 0xE0
	private long NowDispPlayerMoney; // 0xE8
	private long NowDispPlayerPoint; // 0xF0
	private long NowDispPlayerStone; // 0xF8
	private long NowDispPlayerLumber; // 0x100

	// Properties
	private AdvDialogControl AdvDialogControl { get; }
	private string PlayerName { get; }

	// Methods

	// RVA: 0x1D9D540 Offset: 0x1D9D641 VA: 0x1D9D540
	private AdvDialogControl get_AdvDialogControl() { }

	// RVA: 0x1D9D650 Offset: 0x1D9D751 VA: 0x1D9D650
	private string get_PlayerName() { }

	// RVA: 0x1D9D7D0 Offset: 0x1D9D8D1 VA: 0x1D9D7D0
	private List<int> GetMakingIds(MakingID[] Table, bool Checker) { }

	// RVA: 0x1D9D970 Offset: 0x1D9DA71 VA: 0x1D9D970
	private void SetBackUI(bool open) { }

	// RVA: 0x1D9DA00 Offset: 0x1D9DB01 VA: 0x1D9DA00
	private int GetSeasonFromMakingId(int id) { }

	// RVA: 0x1D9DA90 Offset: 0x1D9DB91 VA: 0x1D9DA90
	private MakingID[] GetNowSeasonFestivalTable() { }

	// RVA: 0x1D9E0F0 Offset: 0x1D9E1F1 VA: 0x1D9E0F0
	private void SetNormalMakingID() { }

	// RVA: 0x1D9E2E0 Offset: 0x1D9E3E1 VA: 0x1D9E2E0
	private void SetMakingIDOnTutorialRuck() { }

	// RVA: 0x1D9E4A0 Offset: 0x1D9E5A1 VA: 0x1D9E4A0
	private void SetMakingIDOnTutorialFes() { }

	// RVA: 0x1D9E650 Offset: 0x1D9E751 VA: 0x1D9E650
	private void SetMakingID() { }

	// RVA: 0x1D9E6F0 Offset: 0x1D9E7F1 VA: 0x1D9E6F0
	private void SetChoiceID() { }

	// RVA: 0x1D9E810 Offset: 0x1D9E911 VA: 0x1D9E810
	private void ShowHeadChoice() { }

	// RVA: 0x1D9EF90 Offset: 0x1D9F091 VA: 0x1D9EF90
	private void ShowMakingChoice(int headId, List<int> idList) { }

	// RVA: 0x1DA07F0 Offset: 0x1DA08F1 VA: 0x1DA07F0
	private void CallbackHead(int select) { }

	// RVA: 0x1DA0C40 Offset: 0x1DA0D41 VA: 0x1DA0C40
	private void CallBackFromNotEnough() { }

	// RVA: 0x1DA0C50 Offset: 0x1DA0D51 VA: 0x1DA0C50
	private void CallbackMakingSelect(int select) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD080 Offset: 0x1AD181 VA: 0x1AD080
	// RVA: 0x1DA17F0 Offset: 0x1DA18F1 VA: 0x1DA17F0
	private IEnumerator WaitChangeGender() { }

	// RVA: 0x1DA1DB0 Offset: 0x1DA1EB1 VA: 0x1DA1DB0
	public void HeadEquipItemRelease(int select) { }

	// RVA: 0x1DA1F40 Offset: 0x1DA2041 VA: 0x1DA1F40
	public void CancelLoadOtherSave() { }

	// RVA: 0x1DA1F50 Offset: 0x1DA2051 VA: 0x1DA1F50
	public void LicenseQuizFail() { }

	// RVA: 0x1DA19D0 Offset: 0x1DA1AD1 VA: 0x1DA19D0
	public void DoSuccess(MakingID MakingID) { }

	// RVA: 0x1DA1FC0 Offset: 0x1DA20C1 VA: 0x1DA1FC0
	private void DoSuccessAnimate() { }

	// RVA: 0x1DA2210 Offset: 0x1DA2311 VA: 0x1DA2210
	public void SuccessAnimateEnd() { }

	// RVA: 0x1DA1870 Offset: 0x1DA1971 VA: 0x1DA1870
	public void SuccessEnd(MakingID MakingID) { }

	// RVA: 0x1DA26F0 Offset: 0x1DA27F1 VA: 0x1DA26F0
	public void SuccessAnimateEndAfterAdv() { }

	// RVA: 0x1DA2820 Offset: 0x1DA2921 VA: 0x1DA2820
	private string GetDoAfterScript() { }

	// RVA: 0x1DA2E00 Offset: 0x1DA2F01 VA: 0x1DA2E00
	public void AfterScriptAfterSuccessAnimateEnd() { }

	// RVA: 0x1DA0A60 Offset: 0x1DA0B61 VA: 0x1DA0A60
	private void Close() { }

	// RVA: 0x1DA20F0 Offset: 0x1DA21F1 VA: 0x1DA20F0
	private void SetPause() { }

	// RVA: 0x1D9EEE0 Offset: 0x1D9EFE1 VA: 0x1D9EEE0
	private void AppearBustup() { }

	// RVA: 0x1DA2F60 Offset: 0x1DA3061 VA: 0x1DA2F60
	private void ClearBustup() { }

	// RVA: 0x1DA3010 Offset: 0x1DA3111 VA: 0x1DA3010
	public void BackToMenu() { }

	// RVA: 0x1DA3030 Offset: 0x1DA3131 VA: 0x1DA3030
	public void HidePopupChoice(bool _hide) { }

	// RVA: 0x1DA3050 Offset: 0x1DA3151 VA: 0x1DA3050
	private void Start() { }

	// RVA: 0x1DA3130 Offset: 0x1DA3231 VA: 0x1DA3130
	private void InitMoneyText() { }

	// RVA: 0x1DA3400 Offset: 0x1DA3501 VA: 0x1DA3400
	private void LateUpdate() { }

	// RVA: 0x1DA07E0 Offset: 0x1DA08E1 VA: 0x1DA07E0
	private string ConvertToFullWidth(string halfWidthStr) { }

	// RVA: 0x1DA3870 Offset: 0x1DA3971 VA: 0x1DA3870
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD0F0 Offset: 0x1AD1F1 VA: 0x1AD0F0
	// RVA: 0x1DA3A70 Offset: 0x1DA3B71 VA: 0x1DA3A70
	private void <CallbackMakingSelect>b__32_0(int a) { }
}

