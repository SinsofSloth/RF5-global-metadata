public class PetManager : SingletonMonoBehaviour<PetManager> // TypeDefIndex: 7396
{
	// Fields
	[SerializeField] // RVA: 0x166280 Offset: 0x166381 VA: 0x166280
	private FestivalCamera petCamera; // 0x18
	private PetUI petUI; // 0x20
	[SerializeField] // RVA: 0x166290 Offset: 0x166391 VA: 0x166290
	private GameObject playerPos; // 0x28
	[SerializeField] // RVA: 0x1662A0 Offset: 0x1663A1 VA: 0x1662A0
	private GameObject npcPos; // 0x30
	[SerializeField] // RVA: 0x1662B0 Offset: 0x1663B1 VA: 0x1662B0
	private GameObject[] Player_PetStartPos; // 0x38
	[SerializeField] // RVA: 0x1662C0 Offset: 0x1663C1 VA: 0x1662C0
	private GameObject[] NPC_PetStartPos; // 0x40
	private List<PartnerMonsterBehaviorController> Player_PetControllers; // 0x48
	private List<PartnerMonsterBehaviorController> NPC_PetControllers; // 0x50
	private int Player_PetDeadCount; // 0x58
	private int NPC_PetDeadCount; // 0x5C
	private int battleRound; // 0x60
	private readonly int MAX_PET; // 0x64
	private bool isLoading; // 0x68
	private List<ActorID> rankingList; // 0x70
	private PetNpcPetDataTable petNpcPetDataTable; // 0x78
	private List<FriendMonsterStatusData> NPC_Pets; // 0x80
	private List<ActorID> actorID; // 0x88
	private PetManager.State state; // 0x90
	private PetManager.Result result; // 0x94
	private Dictionary<uint, PartnerMovementOrderType> EntryMonsterOrderTypeDic; // 0x98

	// Properties
	public FestivalCamera Camera { get; }

	// Methods

	// RVA: 0x1FE2550 Offset: 0x1FE2651 VA: 0x1FE2550
	public FestivalCamera get_Camera() { }

	// RVA: 0x1FE2560 Offset: 0x1FE2661 VA: 0x1FE2560 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1FE25D0 Offset: 0x1FE26D1 VA: 0x1FE25D0
	private void Start() { }

	// RVA: 0x1FE2700 Offset: 0x1FE2801 VA: 0x1FE2700
	private void CharaSetup() { }

	// RVA: 0x1FE2990 Offset: 0x1FE2A91 VA: 0x1FE2990
	private bool IsLoading() { }

	// RVA: 0x1FE2BA0 Offset: 0x1FE2CA1 VA: 0x1FE2BA0
	private void Update() { }

	// RVA: 0x1FE3BD0 Offset: 0x1FE3CD1 VA: 0x1FE3BD0
	public PetManager.Result CheckResult() { }

	// RVA: 0x1FE3860 Offset: 0x1FE3961 VA: 0x1FE3860
	private void BattlePrepare() { }

	// RVA: 0x1FE46E0 Offset: 0x1FE47E1 VA: 0x1FE46E0
	private int GetNPCMonsterLevel() { }

	// RVA: 0x1FE43C0 Offset: 0x1FE44C1 VA: 0x1FE43C0
	private void DecideNextBattleNPC() { }

	// RVA: 0x1FE3F70 Offset: 0x1FE4071 VA: 0x1FE3F70
	private void RankingDecide() { }

	// RVA: 0x1FE4830 Offset: 0x1FE4931 VA: 0x1FE4830
	private void AddPlayerMonsterDeadCount() { }

	// RVA: 0x1FE4840 Offset: 0x1FE4941 VA: 0x1FE4840
	private void AddNPCMonsterDeadCount() { }

	// RVA: 0x1FE3670 Offset: 0x1FE3771 VA: 0x1FE3670
	private void PartyMonsterAction(Action<bool, PartyMonster> action) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A08C0 Offset: 0x1A09C1 VA: 0x1A08C0
	// RVA: 0x1FE4640 Offset: 0x1FE4741 VA: 0x1FE4640
	private IEnumerator AsyncChallange(Action callBack) { }

	// RVA: 0x1FE4880 Offset: 0x1FE4981 VA: 0x1FE4880
	public void OnImageBattle() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0930 Offset: 0x1A0A31 VA: 0x1A0930
	// RVA: 0x1FE49B0 Offset: 0x1FE4AB1 VA: 0x1FE49B0
	public IEnumerator OnImageResult() { }

	// RVA: 0x1FE4A60 Offset: 0x1FE4B61 VA: 0x1FE4A60
	public void ResetNpc() { }

	// RVA: 0x1FE50A0 Offset: 0x1FE51A1 VA: 0x1FE50A0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A09A0 Offset: 0x1A0AA1 VA: 0x1A09A0
	// RVA: 0x1FE51D0 Offset: 0x1FE52D1 VA: 0x1FE51D0
	private void <Update>b__28_0(bool isEntry, PartyMonster partyMonster) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A09B0 Offset: 0x1A0AB1 VA: 0x1A09B0
	// RVA: 0x1FE5420 Offset: 0x1FE5521 VA: 0x1FE5420
	private void <BattlePrepare>b__30_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A09C0 Offset: 0x1A0AC1 VA: 0x1A09C0
	// RVA: 0x1FE5430 Offset: 0x1FE5531 VA: 0x1FE5430
	private void <AsyncChallange>b__37_0(bool isEntry, PartyMonster partyMonster) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A09D0 Offset: 0x1A0AD1 VA: 0x1A09D0
	// RVA: 0x1FE5670 Offset: 0x1FE5771 VA: 0x1FE5670
	private void <AsyncChallange>b__37_2(PartnerMonsterBehaviorController monsterBehaviorController) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A09E0 Offset: 0x1A0AE1 VA: 0x1A09E0
	// RVA: 0x1FE5700 Offset: 0x1FE5801 VA: 0x1FE5700
	private void <ResetNpc>b__40_0(bool isEntry, PartyMonster partyMonster) { }
}

