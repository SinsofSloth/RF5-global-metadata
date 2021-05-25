public class PartnerAdvChoice // TypeDefIndex: 7216
{
	// Fields
	private PartnerAdvChoice.PartnerEventStep partnerEventStep; // 0x10
	private List<stCommand_t> cmdList; // 0x18
	private int ChoiceSelect; // 0x20
	private bool NickNameChanging; // 0x24
	private uint TalkingID; // 0x28
	private int PartyNo; // 0x2C
	private int RideCount; // 0x30
	private FriendMonsterStatus friendMob; // 0x38
	private List<int> ChoiceNextStepList; // 0x40
	private Action<ActorID> m_onRide; // 0x48

	// Methods

	// RVA: 0x21BE4F0 Offset: 0x21BE5F1 VA: 0x21BE4F0
	public void InitializeStep() { }

	// RVA: 0x21BE580 Offset: 0x21BE681 VA: 0x21BE580
	public void NickNameChangeEnd(string name) { }

	// RVA: 0x21BE5F0 Offset: 0x21BE6F1 VA: 0x21BE5F0
	public void NickNameChangeStart() { }

	// RVA: 0x21BE6A0 Offset: 0x21BE7A1 VA: 0x21BE6A0
	private string GetPartnerMenuText(int id) { }

	// RVA: 0x21BE8F0 Offset: 0x21BE9F1 VA: 0x21BE8F0
	private string GetAdvChoiceNothing() { }

	// RVA: 0x21BE9E0 Offset: 0x21BEAE1 VA: 0x21BE9E0
	private string GetAdvChoiceRelease() { }

	// RVA: 0x21BEAD0 Offset: 0x21BEBD1 VA: 0x21BEAD0
	private string GetPartnerMonsterMenuText(int id) { }

	// RVA: 0x21BF000 Offset: 0x21BF101 VA: 0x21BF000
	private string GetAdvChoiceChangeNickName() { }

	// RVA: 0x21BF0F0 Offset: 0x21BF1F1 VA: 0x21BF0F0
	private string GetAdvChoiceMonsterNothing() { }

	// RVA: 0x21BF1E0 Offset: 0x21BF2E1 VA: 0x21BF1E0
	public void SetMonsterSelectMenu_Partner(FriendMonsterStatus friend, int rideCount, Action<ActorID> onRide) { }

	// RVA: 0x21BF590 Offset: 0x21BF691 VA: 0x21BF590
	public void SetMonsterSelectMenu_Wait(FriendMonsterStatus friend) { }

	// RVA: 0x21BF5B0 Offset: 0x21BF6B1 VA: 0x21BF5B0
	public void SetMonsterSelectMenu_HandCuffs(HandCuffsStatus handCuffs) { }

	// RVA: 0x21BF200 Offset: 0x21BF301 VA: 0x21BF200
	private void SetMonsterSelectMenuBase(PartnerAdvChoice.PartnerEventStep step, FriendMonsterStatus friend, int rideCount = 0, Action<ActorID> onRide) { }

	// RVA: 0x21BFE40 Offset: 0x21BFF41 VA: 0x21BFE40
	public void AppearSelectMenu(string message, int nextStep) { }

	// RVA: 0x21BFF60 Offset: 0x21C0061 VA: 0x21BFF60
	public void AdvSelectStart() { }

	// RVA: 0x21BFFF0 Offset: 0x21C00F1 VA: 0x21BFFF0
	public void SelectedMenu(int nextStep) { }

	// RVA: 0x21C1810 Offset: 0x21C1911 VA: 0x21C1810
	private void FriendMonsterPartyOut(FriendMonsterStatusData StatusData) { }

	// RVA: 0x21C1990 Offset: 0x21C1A91 VA: 0x21C1990
	private void SelectEnd() { }

	// RVA: 0x21BF6E0 Offset: 0x21BF7E1 VA: 0x21BF6E0
	public void SetNextPartnerMonsterChoice(uint targetId) { }

	[IteratorStateMachineAttribute] // RVA: 0x19E280 Offset: 0x19E381 VA: 0x19E280
	// RVA: 0x21C1B20 Offset: 0x21C1C21 VA: 0x21C1B20
	private IEnumerator GoPause() { }

	// RVA: 0x21C1BD0 Offset: 0x21C1CD1 VA: 0x21C1BD0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E2F0 Offset: 0x19E3F1 VA: 0x19E2F0
	// RVA: 0x21C1C90 Offset: 0x21C1D91 VA: 0x21C1C90
	private void <NickNameChangeStart>b__13_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E300 Offset: 0x19E401 VA: 0x19E300
	// RVA: 0x21C1D50 Offset: 0x21C1E51 VA: 0x21C1D50
	private void <NickNameChangeStart>b__13_1(string str) { }

	[CompilerGeneratedAttribute] // RVA: 0x19E310 Offset: 0x19E411 VA: 0x19E310
	// RVA: 0x21C1DC0 Offset: 0x21C1EC1 VA: 0x21C1DC0
	private void <SelectedMenu>b__26_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x19E320 Offset: 0x19E421 VA: 0x19E320
	// RVA: 0x21C1DD0 Offset: 0x21C1ED1 VA: 0x21C1DD0
	private void <SelectedMenu>b__26_2() { }
}

