public class ActorManager : MonoBehaviour // TypeDefIndex: 6305
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15C040 Offset: 0x15C141 VA: 0x15C040
	private static ActorDataTable <ActorDataTable>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x15C050 Offset: 0x15C151 VA: 0x15C050
	private static HumanDataTable <HumanDataTable>k__BackingField; // 0x8
	private Actor[] Actors; // 0x18
	private CharacterStatusBase[] ActorStatusControllers; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15C060 Offset: 0x15C161 VA: 0x15C060
	private static PartyBase[] <Parties>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x15C070 Offset: 0x15C171 VA: 0x15C070
	private static bool <IsBusy>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15C080 Offset: 0x15C181 VA: 0x15C080
	private bool <EnableStatusUpdate>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15C090 Offset: 0x15C191 VA: 0x15C090
	private static ActorManager <Instance>k__BackingField; // 0x20
	private bool IsActive; // 0x29

	// Properties
	public static ActorDataTable ActorDataTable { get; set; }
	public static HumanDataTable HumanDataTable { get; set; }
	private static PartyData[] PartyDatas { get; }
	public static PartyBase[] Parties { get; set; }
	public static bool IsBusy { get; set; }
	public bool EnableStatusUpdate { get; set; }
	public static ActorManager Instance { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19AAF0 Offset: 0x19ABF1 VA: 0x19AAF0
	// RVA: 0x1BED7B0 Offset: 0x1BED8B1 VA: 0x1BED7B0
	public static ActorDataTable get_ActorDataTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AB00 Offset: 0x19AC01 VA: 0x19AB00
	// RVA: 0x1BED800 Offset: 0x1BED901 VA: 0x1BED800
	private static void set_ActorDataTable(ActorDataTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19AB10 Offset: 0x19AC11 VA: 0x19AB10
	// RVA: 0x1BED860 Offset: 0x1BED961 VA: 0x1BED860
	public static HumanDataTable get_HumanDataTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AB20 Offset: 0x19AC21 VA: 0x19AB20
	// RVA: 0x1BED8B0 Offset: 0x1BED9B1 VA: 0x1BED8B0
	private static void set_HumanDataTable(HumanDataTable value) { }

	// RVA: 0x1BED910 Offset: 0x1BEDA11 VA: 0x1BED910
	private static PartyData[] get_PartyDatas() { }

	// RVA: 0x1BED940 Offset: 0x1BEDA41 VA: 0x1BED940
	public static void InitializeForNewGame() { }

	// RVA: 0x1BEDAF0 Offset: 0x1BEDBF1 VA: 0x1BEDAF0
	public static void Initialize() { }

	// RVA: 0x1BEDE50 Offset: 0x1BEDF51 VA: 0x1BEDE50
	public static void InitializeAfterSceneLoad() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AB30 Offset: 0x19AC31 VA: 0x19AB30
	// RVA: 0x1BEE310 Offset: 0x1BEE411 VA: 0x1BEE310
	public static PartyBase[] get_Parties() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AB40 Offset: 0x19AC41 VA: 0x19AB40
	// RVA: 0x1BEE360 Offset: 0x1BEE461 VA: 0x1BEE360
	private static void set_Parties(PartyBase[] value) { }

	// RVA: 0x1BEE3C0 Offset: 0x1BEE4C1 VA: 0x1BEE3C0
	public static ActorID PartyMonsterActorId(int no) { }

	// RVA: 0x1BED950 Offset: 0x1BEDA51 VA: 0x1BED950
	private static void PartyCreate() { }

	// RVA: 0x1BEE3D0 Offset: 0x1BEE4D1 VA: 0x1BEE3D0
	public static void PartyClear() { }

	// RVA: 0x1BEDE60 Offset: 0x1BEDF61 VA: 0x1BEDE60
	public static void PartyReset() { }

	// RVA: 0x1BEE600 Offset: 0x1BEE701 VA: 0x1BEE600
	public static int PartyFreeNo() { }

	// RVA: 0x1BEE6B0 Offset: 0x1BEE7B1 VA: 0x1BEE6B0
	public static bool PartyIsJoinedHandCuffs() { }

	// RVA: 0x1BEE7C0 Offset: 0x1BEE8C1 VA: 0x1BEE7C0
	public static void PartyInHuman(int no, ActorID actorID) { }

	// RVA: 0x1BEECE0 Offset: 0x1BEEDE1 VA: 0x1BEECE0
	public static void PartyInMonster(int no, string name, EnemyStatusData mosterStatusData, bool inParty = True) { }

	// RVA: 0x1BEED30 Offset: 0x1BEEE31 VA: 0x1BEED30
	public static void PartyInMonster(int no, uint fmId) { }

	// RVA: 0x1BEEF90 Offset: 0x1BEF091 VA: 0x1BEEF90
	public static void PartyInHandCuffs(int no, MonsterControllerBase enemy) { }

	// RVA: 0x1BEEA30 Offset: 0x1BEEB31 VA: 0x1BEEA30
	public static void PartyOut(int no) { }

	// RVA: 0x1BEF2E0 Offset: 0x1BEF3E1 VA: 0x1BEF2E0
	public static void PartyAllOut() { }

	// RVA: 0x1BEF380 Offset: 0x1BEF481 VA: 0x1BEF380
	public static bool PartyInMonsterCheck(uint fmId) { }

	// RVA: 0x1BEF4C0 Offset: 0x1BEF5C1 VA: 0x1BEF4C0
	public static List<uint> PartyInMonsterGetId() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AB50 Offset: 0x19AC51 VA: 0x19AB50
	// RVA: 0x1BEF730 Offset: 0x1BEF831 VA: 0x1BEF730
	public static bool get_IsBusy() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AB60 Offset: 0x19AC61 VA: 0x19AB60
	// RVA: 0x1BEF780 Offset: 0x1BEF881 VA: 0x1BEF780
	private static void set_IsBusy(bool value) { }

	// RVA: 0x1BEF7E0 Offset: 0x1BEF8E1 VA: 0x1BEF7E0
	public static bool CheckVariationNo(ActorID actorId, VariationNo variationNo) { }

	// RVA: 0x1BE8DB0 Offset: 0x1BE8EB1 VA: 0x1BE8DB0
	public static Actor GetActor(ActorID actorId) { }

	// RVA: 0x1BEF960 Offset: 0x1BEFA61 VA: 0x1BEF960
	public static Actor Create(ActorID actor_id, ActorType type, CharID char_id, VariationNo variation_no = 0, HairType hair_type = 0) { }

	// RVA: 0x1BEFA30 Offset: 0x1BEFB31 VA: 0x1BEFA30
	public static Actor CreateBaseOnly(ActorID actor_id, ActorType type, CharID char_id, VariationNo variation_no = 0, HairType hair_type = 0) { }

	// RVA: 0x1BEFB20 Offset: 0x1BEFC21 VA: 0x1BEFB20
	public static Actor Create(ActorID actor_id, ActorType type, CharID char_id) { }

	// RVA: 0x1BEFBE0 Offset: 0x1BEFCE1 VA: 0x1BEFBE0
	public static Actor Create(ActorID actor_id) { }

	// RVA: 0x1BEFC90 Offset: 0x1BEFD91 VA: 0x1BEFC90
	public static Actor SwitchBase(ActorID actor_id, ActorType actor_type, bool is_copy = True) { }

	// RVA: 0x1BEFD40 Offset: 0x1BEFE41 VA: 0x1BEFD40
	public static void DestroyModel(ActorID actor_id) { }

	// RVA: 0x1BEFE50 Offset: 0x1BEFF51 VA: 0x1BEFE50
	public static void Destroy(ActorID actor_id) { }

	// RVA: 0x1BEFEF0 Offset: 0x1BEFFF1 VA: 0x1BEFEF0
	public static void DestroyAll() { }

	// RVA: 0x1BEDB10 Offset: 0x1BEDC11 VA: 0x1BEDB10
	public static void InitializeStatusController() { }

	// RVA: 0x1BF0070 Offset: 0x1BF0171 VA: 0x1BF0070
	public static CharacterStatusBase GetStatus(ActorID actor_id) { }

	// RVA: 0x1BF0100 Offset: 0x1BF0201 VA: 0x1BF0100
	public static HumanStatus GetHumanStatus(ActorID actor_id) { }

	// RVA: 0x1BF0210 Offset: 0x1BF0311 VA: 0x1BF0210
	public static HumanStatusData GetHumanStatusData(ActorID actor_id) { }

	// RVA: 0x1BF0300 Offset: 0x1BF0401 VA: 0x1BF0300
	public static ItemData GetEquipItem(ActorID actor_id, EquipSlotType equip_slot_type) { }

	// RVA: 0x1BF0340 Offset: 0x1BF0441 VA: 0x1BF0340
	public static ItemData Equip(ActorID actor_id, EquipSlotType equip_slot_type, ItemData itemData) { }

	// RVA: 0x1BF03B0 Offset: 0x1BF04B1 VA: 0x1BF03B0
	public static ItemData UnEquip(ActorID actor_id, EquipSlotType equip_slot_type) { }

	[CompilerGeneratedAttribute] // RVA: 0x19AB70 Offset: 0x19AC71 VA: 0x19AB70
	// RVA: 0x1BF0420 Offset: 0x1BF0521 VA: 0x1BF0420
	public bool get_EnableStatusUpdate() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AB80 Offset: 0x19AC81 VA: 0x19AB80
	// RVA: 0x1BF0430 Offset: 0x1BF0531 VA: 0x1BF0430
	public void set_EnableStatusUpdate(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19AB90 Offset: 0x19AC91 VA: 0x19AB90
	// RVA: 0x1BF0440 Offset: 0x1BF0541 VA: 0x1BF0440
	public static ActorManager get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19ABA0 Offset: 0x19ACA1 VA: 0x19ABA0
	// RVA: 0x1BF0490 Offset: 0x1BF0591 VA: 0x1BF0490
	private static void set_Instance(ActorManager value) { }

	// RVA: 0x1BF04F0 Offset: 0x1BF05F1 VA: 0x1BF04F0
	private void Awake() { }

	// RVA: 0x1BF0910 Offset: 0x1BF0A11 VA: 0x1BF0910
	private void Start() { }

	// RVA: 0x1BF0940 Offset: 0x1BF0A41 VA: 0x1BF0940
	private void OnDestroy() { }

	// RVA: 0x1BF0BB0 Offset: 0x1BF0CB1 VA: 0x1BF0BB0
	private void Update() { }

	// RVA: 0x1BF0DF0 Offset: 0x1BF0EF1 VA: 0x1BF0DF0
	public void .ctor() { }
}

