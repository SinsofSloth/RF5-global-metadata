public class FriendsMenuController : MonoBehaviour // TypeDefIndex: 8670
{
	// Fields
	[SerializeField] // RVA: 0x171F30 Offset: 0x172031 VA: 0x171F30
	private GameObject NoPartnerObject; // 0x18
	[SerializeField] // RVA: 0x171F40 Offset: 0x172041 VA: 0x171F40
	private GameObject Partner1StatusObject; // 0x20
	[SerializeField] // RVA: 0x171F50 Offset: 0x172051 VA: 0x171F50
	private HumanStatusA humanStatusA; // 0x28
	[SerializeField] // RVA: 0x171F60 Offset: 0x172061 VA: 0x171F60
	private HumanStatusB humanStatusB; // 0x30
	[SerializeField] // RVA: 0x171F70 Offset: 0x172071 VA: 0x171F70
	private FriendsMenuStatusDisp FriendsMenuStatusDisp; // 0x38
	[SerializeField] // RVA: 0x171F80 Offset: 0x172081 VA: 0x171F80
	private UIOnOffAnimate[] StatusAnimateList; // 0x40
	[SerializeField] // RVA: 0x171F90 Offset: 0x172091 VA: 0x171F90
	private UIOnOffAnimate[] MonsterStatusAnimateList; // 0x48
	[SerializeField] // RVA: 0x171FA0 Offset: 0x1720A1 VA: 0x171FA0
	private FriendEquipSlot[] equipSlot; // 0x50
	[SerializeField] // RVA: 0x171FB0 Offset: 0x1720B1 VA: 0x171FB0
	private NonFocusButton JL_Button; // 0x58
	[SerializeField] // RVA: 0x171FC0 Offset: 0x1720C1 VA: 0x171FC0
	private NonFocusButton JR_Button; // 0x60
	[SerializeField] // RVA: 0x171FD0 Offset: 0x1720D1 VA: 0x171FD0
	private UIEMItemDetail itemDetail; // 0x68
	[SerializeField] // RVA: 0x171FE0 Offset: 0x1720E1 VA: 0x171FE0
	private TextMaskScrolling textScroll; // 0x70
	[SerializeField] // RVA: 0x171FF0 Offset: 0x1720F1 VA: 0x171FF0
	private CampBadStatusController CampBadStatusController; // 0x78
	private int nowFocusing; // 0x80
	private bool isSlotFocusing; // 0x84
	private bool noPartner; // 0x85
	private int OnFriendsPage; // 0x88
	private int FriendPageMax; // 0x8C
	private List<PartyBase> partyBases; // 0x90

	// Methods

	// RVA: 0x22ACCE0 Offset: 0x22ACDE1 VA: 0x22ACCE0
	private void SetPartnerToObject() { }

	// RVA: 0x22AD430 Offset: 0x22AD531 VA: 0x22AD430
	private void OpenFriendPage() { }

	// RVA: 0x22AD470 Offset: 0x22AD571 VA: 0x22AD470
	private void OnEnable() { }

	// RVA: 0x22AD9C0 Offset: 0x22ADAC1 VA: 0x22AD9C0
	private void PageChange(int val) { }

	// RVA: 0x22ADB00 Offset: 0x22ADC01 VA: 0x22ADB00
	private void Update() { }

	// RVA: 0x22AE470 Offset: 0x22AE571 VA: 0x22AE470
	public void CloseEquipMenu() { }

	// RVA: 0x22AE4B0 Offset: 0x22AE5B1 VA: 0x22AE4B0
	private void OnDisable() { }

	// RVA: 0x22AD8D0 Offset: 0x22AD9D1 VA: 0x22AD8D0
	private void SetTouchAction(int _index) { }

	// RVA: 0x22AE560 Offset: 0x22AE661 VA: 0x22AE560
	private void OnTouch(int _index) { }

	// RVA: 0x22AE370 Offset: 0x22AE471 VA: 0x22AE370
	public void OnTouchCharaModel() { }

	// RVA: 0x22AE6D0 Offset: 0x22AE7D1 VA: 0x22AE6D0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7FF0 Offset: 0x1A80F1 VA: 0x1A7FF0
	// RVA: 0x22AE6E0 Offset: 0x22AE7E1 VA: 0x22AE6E0
	private void <OnEnable>b__21_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8000 Offset: 0x1A8101 VA: 0x1A8000
	// RVA: 0x22AE6F0 Offset: 0x22AE7F1 VA: 0x22AE6F0
	private void <OnEnable>b__21_2() { }
}

