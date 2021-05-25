public class MiningPoint : MonoBehaviour, InteractionInterface, FocusInterface, ItemInteractionInterface, PlowInteractionInterface, ToolInteractionInterface, SlashInteractionInterface, SmashInteractionInterface, ChopInteractionInterface // TypeDefIndex: 7464
{
	// Fields
	[HeaderAttribute] // RVA: 0x1668B0 Offset: 0x1669B1 VA: 0x1668B0
	[SerializeField] // RVA: 0x1668B0 Offset: 0x1669B1 VA: 0x1668B0
	private GameObject MiningModelObject; // 0x18
	[SerializeField] // RVA: 0x166900 Offset: 0x166A01 VA: 0x166900
	private CapsuleCollider capsuleCollider; // 0x20
	[SerializeField] // RVA: 0x166910 Offset: 0x166A11 VA: 0x166910
	private CapsuleCollider capsuleCollider_child; // 0x28
	[SerializeField] // RVA: 0x166920 Offset: 0x166A21 VA: 0x166920
	private ParticleSystem KirakiraEffect; // 0x30
	[SerializeField] // RVA: 0x166930 Offset: 0x166A31 VA: 0x166930
	private PushOverlap PushOverlap; // 0x38
	[HeaderAttribute] // RVA: 0x166940 Offset: 0x166A41 VA: 0x166940
	[SerializeField] // RVA: 0x166940 Offset: 0x166A41 VA: 0x166940
	public string MiningPointIDName; // 0x40
	public FarmManager.FARM_ID FarmId; // 0x48
	public int UniqueId; // 0x4C
	private MiningID miningID; // 0x50
	public MineTypeID mineType; // 0x54
	public MineTypeDataTable mineTypeDataTable; // 0x58
	public CropID cropId; // 0x98
	private CropDataTable cropDataTable; // 0xA0
	public bool isFieldItem; // 0x190
	private bool isInit; // 0x191
	private GameObject miningObject; // 0x198
	public Prefab prefabID; // 0x1A0
	private bool isSpawn; // 0x1A4
	[CompilerGeneratedAttribute] // RVA: 0x166990 Offset: 0x166A91 VA: 0x166990
	private readonly bool <Focusable>k__BackingField; // 0x1A5
	private bool isCreateRequest; // 0x1A6
	private bool isCreateRequestField; // 0x1A7

	// Properties
	public bool Focusable { get; }
	public string ItemInteractionButtonHint { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x1CB58A0 Offset: 0x1CB59A1 VA: 0x1CB58A0
	private void OnDestroy() { }

	// RVA: 0x1CB59D0 Offset: 0x1CB5AD1 VA: 0x1CB59D0 Slot: 9
	public string GetFocusName() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0FC0 Offset: 0x1A10C1 VA: 0x1A0FC0
	// RVA: 0x1CB5C20 Offset: 0x1CB5D21 VA: 0x1CB5C20 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x1CB5C30 Offset: 0x1CB5D31 VA: 0x1CB5C30 Slot: 11
	public void OnFocus() { }

	// RVA: 0x1CB5CB0 Offset: 0x1CB5DB1 VA: 0x1CB5CB0 Slot: 12
	public void OffFocus() { }

	// RVA: 0x1CB5CC0 Offset: 0x1CB5DC1 VA: 0x1CB5CC0 Slot: 22
	public void DoPlow(HumanController humanController) { }

	// RVA: 0x1CB6780 Offset: 0x1CB6881 VA: 0x1CB6780 Slot: 23
	public bool CanPlow(HumanController humanController) { }

	// RVA: 0x1CB6860 Offset: 0x1CB6961 VA: 0x1CB6860 Slot: 24
	public void DoSlash(HumanController humanController) { }

	// RVA: 0x1CB6B20 Offset: 0x1CB6C21 VA: 0x1CB6B20 Slot: 25
	public bool CanSlash(HumanController humanController) { }

	// RVA: 0x1CB6C60 Offset: 0x1CB6D61 VA: 0x1CB6C60 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x1CB6C70 Offset: 0x1CB6D71 VA: 0x1CB6C70 Slot: 26
	public void DoSmash(HumanController humanController) { }

	// RVA: 0x1CB6C80 Offset: 0x1CB6D81 VA: 0x1CB6C80 Slot: 27
	public bool CanSmash(HumanController humanController) { }

	// RVA: 0x1CB6C90 Offset: 0x1CB6D91 VA: 0x1CB6C90 Slot: 29
	public bool CanBreak(HumanController humanController) { }

	// RVA: 0x1CB6D50 Offset: 0x1CB6E51 VA: 0x1CB6D50 Slot: 28
	public void DoBreak(HumanController humanController) { }

	// RVA: 0x1CB7630 Offset: 0x1CB7731 VA: 0x1CB7630 Slot: 31
	public bool CanChop(HumanController humanController) { }

	// RVA: 0x1CB76E0 Offset: 0x1CB77E1 VA: 0x1CB76E0 Slot: 30
	public void DoChop(HumanController humanController) { }

	// RVA: 0x1CB7980 Offset: 0x1CB7A81 VA: 0x1CB7980 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x1CB79D0 Offset: 0x1CB7AD1 VA: 0x1CB79D0 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1CB7A20 Offset: 0x1CB7B21 VA: 0x1CB7A20 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1CB7E90 Offset: 0x1CB7F91 VA: 0x1CB7E90 Slot: 19
	public void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x1CB7EA0 Offset: 0x1CB7FA1 VA: 0x1CB7EA0 Slot: 20
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x1CB7F70 Offset: 0x1CB8071 VA: 0x1CB7F70 Slot: 21
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData) { }

	// RVA: 0x1CB7F80 Offset: 0x1CB8081 VA: 0x1CB7F80
	public string get_ItemInteractionButtonHint() { }

	// RVA: 0x1CB7FE0 Offset: 0x1CB80E1 VA: 0x1CB7FE0 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1CB7FF0 Offset: 0x1CB80F1 VA: 0x1CB7FF0 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x1CB8000 Offset: 0x1CB8101 VA: 0x1CB8000 Slot: 15
	public FocusPointType get_FocusPointType() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0FD0 Offset: 0x1A10D1 VA: 0x1A0FD0
	// RVA: 0x1CB7590 Offset: 0x1CB7691 VA: 0x1CB7590
	private IEnumerator MoveAction(HumanController humanController) { }

	// RVA: 0x1CB8040 Offset: 0x1CB8141 VA: 0x1CB8040
	private bool IsStump() { }

	// RVA: 0x1CB8060 Offset: 0x1CB8161 VA: 0x1CB8060
	private bool IsOre() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1040 Offset: 0x1A1141 VA: 0x1A1040
	// RVA: 0x1CB8090 Offset: 0x1CB8191 VA: 0x1CB8090
	private IEnumerator MoveAction(Vector3 euler) { }

	// RVA: 0x1CB3A80 Offset: 0x1CB3B81 VA: 0x1CB3A80
	public void MoveAcrtion(Vector2 euler) { }

	// RVA: 0x1CB7350 Offset: 0x1CB7451 VA: 0x1CB7350
	private ItemID dropItemLottery() { }

	// RVA: 0x1CB5F10 Offset: 0x1CB6011 VA: 0x1CB5F10
	private void dropItem(ItemID itemId, int skillLv, int toolLv, bool isSpread = True) { }

	// RVA: 0x1CB3B90 Offset: 0x1CB3C91 VA: 0x1CB3B90
	public bool checkDestroyItem() { }

	// RVA: 0x1CB72D0 Offset: 0x1CB73D1 VA: 0x1CB72D0
	private bool rfCalcOreKuzuCheck(int kuzu_rate, int skill_lv, int hammer_lv) { }

	// RVA: 0x1CB73E0 Offset: 0x1CB74E1 VA: 0x1CB73E0
	private bool rfCalcOreDoubleCheck(int skill_lv, int hammer_lv) { }

	// RVA: 0x1CB7440 Offset: 0x1CB7541 VA: 0x1CB7440
	private bool rfCalcOreRareCheck(int skill_lv, int hammer_lv) { }

	// RVA: 0x1CB7510 Offset: 0x1CB7611 VA: 0x1CB7510
	private bool rfCalcOreBreakCheck(int break_rate, int skill_lv, int hammer_lv) { }

	// RVA: 0x1CB7B60 Offset: 0x1CB7C61 VA: 0x1CB7B60
	private void Harvest(HumanController chracter, bool isItemInteraction) { }

	// RVA: 0x1CB6A10 Offset: 0x1CB6B11 VA: 0x1CB6A10
	private void CreateRuneBall(bool isFlower) { }

	// RVA: 0x1CB57A0 Offset: 0x1CB58A1 VA: 0x1CB57A0
	public void CreateMiningPoint4Farm() { }

	// RVA: 0x1CB8600 Offset: 0x1CB8701 VA: 0x1CB8600
	public void CreateMiningPoint4Field() { }

	// RVA: 0x1CB8170 Offset: 0x1CB8271 VA: 0x1CB8170
	public void CreateMiningPoint() { }

	// RVA: 0x1CB89E0 Offset: 0x1CB8AE1 VA: 0x1CB89E0
	private bool CheckMereor() { }

	// RVA: 0x1CB8C20 Offset: 0x1CB8D21 VA: 0x1CB8C20
	private void Start() { }

	// RVA: 0x1CB8CC0 Offset: 0x1CB8DC1 VA: 0x1CB8CC0
	private void OnEnable() { }

	// RVA: 0x1CB4480 Offset: 0x1CB4581 VA: 0x1CB4480
	public void Spawn() { }

	// RVA: 0x1CB8F00 Offset: 0x1CB9001 VA: 0x1CB8F00
	private void Update() { }

	// RVA: 0x1CB8FE0 Offset: 0x1CB90E1 VA: 0x1CB8FE0 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1CB8FF0 Offset: 0x1CB90F1 VA: 0x1CB8FF0 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1CB9000 Offset: 0x1CB9101 VA: 0x1CB9000
	public void .ctor() { }

	// RVA: 0x1CB9070 Offset: 0x1CB9171 VA: 0x1CB9070 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1CB9080 Offset: 0x1CB9181 VA: 0x1CB9080 Slot: 18
	private Transform FocusInterface.get_transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A10B0 Offset: 0x1A11B1 VA: 0x1A10B0
	// RVA: 0x1CB9090 Offset: 0x1CB9191 VA: 0x1CB9090
	private bool <dropItem>b__58_1(RaycastHit dat) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A10C0 Offset: 0x1A11C1 VA: 0x1A10C0
	// RVA: 0x1CB9150 Offset: 0x1CB9251 VA: 0x1CB9150
	private void <CreateMiningPoint>b__68_0(GameObject obj) { }
}

