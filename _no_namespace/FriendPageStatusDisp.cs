public class FriendPageStatusDisp : MonoBehaviour // TypeDefIndex: 8660
{
	// Fields
	private GenerateFriendlistButton.FriendType FriendType; // 0x18
	[SerializeField] // RVA: 0x171CF0 Offset: 0x171DF1 VA: 0x171CF0
	private FriendsMenuStatusDisp FriendsMenuStatusDisp; // 0x20
	[SerializeField] // RVA: 0x171D00 Offset: 0x171E01 VA: 0x171D00
	private HumanStatusA HumanStatusA; // 0x28
	[SerializeField] // RVA: 0x171D10 Offset: 0x171E11 VA: 0x171D10
	private HumanStatusB HumanStatusB; // 0x30
	[SerializeField] // RVA: 0x171D20 Offset: 0x171E21 VA: 0x171D20
	private UIOnOffAnimate[] TurnOnAnimateNpc; // 0x38
	[SerializeField] // RVA: 0x171D30 Offset: 0x171E31 VA: 0x171D30
	private UIOnOffAnimate[] TurnOnAnimateMonster; // 0x40
	[SerializeField] // RVA: 0x171D40 Offset: 0x171E41 VA: 0x171D40
	private FriendEquipSlot[] equipSlot; // 0x48
	[SerializeField] // RVA: 0x171D50 Offset: 0x171E51 VA: 0x171D50
	private NonFocusButton JL_Button; // 0x50
	[SerializeField] // RVA: 0x171D60 Offset: 0x171E61 VA: 0x171D60
	private NonFocusButton JR_Button; // 0x58
	[SerializeField] // RVA: 0x171D70 Offset: 0x171E71 VA: 0x171D70
	private UIEMItemDetail itemDetail; // 0x60
	[SerializeField] // RVA: 0x171D80 Offset: 0x171E81 VA: 0x171D80
	private TextMaskScrolling textScroll; // 0x68
	[SerializeField] // RVA: 0x171D90 Offset: 0x171E91 VA: 0x171D90
	private CampBadStatusController CampBadStatusController; // 0x70
	private int nowFocusing; // 0x78
	private bool isSlotFocusing; // 0x7C
	private int pageID; // 0x80
	private ActorID actorId; // 0x84
	private MonsterDataID monsterDataID; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x171DA0 Offset: 0x171EA1 VA: 0x171DA0
	private GenerateFriendlistButton <GenerateFriendlistButton>k__BackingField; // 0x90

	// Properties
	public GenerateFriendlistButton GenerateFriendlistButton { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7F90 Offset: 0x1A8091 VA: 0x1A7F90
	// RVA: 0x22AAAE0 Offset: 0x22AABE1 VA: 0x22AAAE0
	public GenerateFriendlistButton get_GenerateFriendlistButton() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7FA0 Offset: 0x1A80A1 VA: 0x1A7FA0
	// RVA: 0x22AAAF0 Offset: 0x22AABF1 VA: 0x22AAAF0
	public void set_GenerateFriendlistButton(GenerateFriendlistButton value) { }

	// RVA: 0x22AAB00 Offset: 0x22AAC01 VA: 0x22AAB00
	public void SetStatusNPC(int pageId, GenerateFriendlistButton _generateFriendlistButton) { }

	// RVA: 0x22AB000 Offset: 0x22AB101 VA: 0x22AB000
	public void SetStatusMonster(int pageId, GenerateFriendlistButton _generateFriendlistButton) { }

	// RVA: 0x22AB420 Offset: 0x22AB521 VA: 0x22AB420
	private void OnEnable() { }

	// RVA: 0x22AB710 Offset: 0x22AB811 VA: 0x22AB710
	private void Update() { }

	// RVA: 0x22ABE20 Offset: 0x22ABF21 VA: 0x22ABE20
	private void OnDisable() { }

	// RVA: 0x22ABEE0 Offset: 0x22ABFE1 VA: 0x22ABEE0
	private void PageSwitch(int val) { }

	// RVA: 0x22AB620 Offset: 0x22AB721 VA: 0x22AB620
	private void SetTouchAction(int _index) { }

	// RVA: 0x22AC090 Offset: 0x22AC191 VA: 0x22AC090
	private void OnTouch(int _index) { }

	// RVA: 0x22ABD20 Offset: 0x22ABE21 VA: 0x22ABD20
	public void OnTouchCharaModel() { }

	// RVA: 0x22AC200 Offset: 0x22AC301 VA: 0x22AC200
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7FB0 Offset: 0x1A80B1 VA: 0x1A7FB0
	// RVA: 0x22AC220 Offset: 0x22AC321 VA: 0x22AC220
	private void <OnEnable>b__23_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7FC0 Offset: 0x1A80C1 VA: 0x1A7FC0
	// RVA: 0x22AC230 Offset: 0x22AC331 VA: 0x22AC230
	private void <OnEnable>b__23_1() { }
}

