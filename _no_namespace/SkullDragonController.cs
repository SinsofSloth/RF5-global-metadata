public class SkullDragonController : BossMonsterContoroller // TypeDefIndex: 7974
{
	// Fields
	private const string HeadBoneName = "Head";
	public bool IsFilledTailDamage; // 0x510
	public bool IsHeadAttack; // 0x511
	[CompilerGeneratedAttribute] // RVA: 0x169E80 Offset: 0x169F81 VA: 0x169E80
	private bool <IsFireCharge>k__BackingField; // 0x512
	public float IsChargeTime; // 0x514
	[CompilerGeneratedAttribute] // RVA: 0x169E90 Offset: 0x169F91 VA: 0x169E90
	private bool <IsBreathAttack>k__BackingField; // 0x518
	public GameObject headobj; // 0x520
	private SkinnedMeshRenderer HeadSkin; // 0x528
	public float ShoutSoul; // 0x530
	private SkullDragonController.SkullHeadController HeadController; // 0x538
	private SkinnedMeshRenderer SkinnedMeshRenderer; // 0x540
	private Material DefaultMaterial; // 0x548
	private const string CorePointName = "CorePoint";
	private bool IsDisplayHead; // 0x550
	private SkullDragonController.CoreController CorePoint; // 0x558

	// Properties
	public bool IsFireCharge { get; set; }
	public bool IsBreathAttack { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A4DC0 Offset: 0x1A4EC1 VA: 0x1A4DC0
	// RVA: 0x1C57910 Offset: 0x1C57A11 VA: 0x1C57910
	public bool get_IsFireCharge() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4DD0 Offset: 0x1A4ED1 VA: 0x1A4DD0
	// RVA: 0x1C57920 Offset: 0x1C57A21 VA: 0x1C57920
	public void set_IsFireCharge(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4DE0 Offset: 0x1A4EE1 VA: 0x1A4DE0
	// RVA: 0x1C57930 Offset: 0x1C57A31 VA: 0x1C57930
	public bool get_IsBreathAttack() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4DF0 Offset: 0x1A4EF1 VA: 0x1A4DF0
	// RVA: 0x1C57940 Offset: 0x1C57A41 VA: 0x1C57940
	public void set_IsBreathAttack(bool value) { }

	// RVA: 0x1C57950 Offset: 0x1C57A51 VA: 0x1C57950 Slot: 9
	public override bool IsCanNotLockon(CharacterBase lockonCharacter) { }

	// RVA: 0x1C579A0 Offset: 0x1C57AA1 VA: 0x1C579A0
	public void SetupSkullHead() { }

	// RVA: 0x1C57D60 Offset: 0x1C57E61 VA: 0x1C57D60 Slot: 134
	public override void OnSetBodyPartsType(BodyPartsCollision bodyPartsCollision) { }

	// RVA: 0x1C57E20 Offset: 0x1C57F21 VA: 0x1C57E20
	public void SetDisplayHead(bool isDisplay) { }

	// RVA: 0x1C57F50 Offset: 0x1C58051 VA: 0x1C57F50
	public void SetDisplayCore(bool isDisplay) { }

	// RVA: 0x1C58000 Offset: 0x1C58101 VA: 0x1C58000
	public void SetLookOn(bool isLookOn, float damage) { }

	// RVA: 0x1C58070 Offset: 0x1C58171 VA: 0x1C58070 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x1C58450 Offset: 0x1C58551 VA: 0x1C58450
	public void Accidental(float damage) { }

	// RVA: 0x1C56C90 Offset: 0x1C56D91 VA: 0x1C56C90
	public void SetBreathAttack(bool state) { }

	// RVA: 0x1C584E0 Offset: 0x1C585E1 VA: 0x1C584E0
	public float CheckSoulCount() { }

	// RVA: 0x1C584F0 Offset: 0x1C585F1 VA: 0x1C584F0 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x1C58680 Offset: 0x1C58781 VA: 0x1C58680
	private bool IsShinanasaso(ItemID itemID) { }

	// RVA: 0x1C58690 Offset: 0x1C58791 VA: 0x1C58690
	private bool IsInStage(StorageType storageType, ItemID itemID) { }

	// RVA: 0x1C587B0 Offset: 0x1C588B1 VA: 0x1C587B0
	private bool IsOnGroundShianasaso() { }

	// RVA: 0x1C588E0 Offset: 0x1C589E1 VA: 0x1C588E0
	private bool IsExistShianasaso() { }

	// RVA: 0x1C589B0 Offset: 0x1C58AB1 VA: 0x1C589B0 Slot: 122
	protected override List<MonsterControllerBase.DropItemDataParameter> GetDoropItemList() { }

	// RVA: 0x1C58A80 Offset: 0x1C58B81 VA: 0x1C58A80 Slot: 120
	protected override MonsterControllerBase.DropItemDataParameter GetHandCuffsDropItem() { }

	// RVA: 0x1C59060 Offset: 0x1C59161 VA: 0x1C59060 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x1C59090 Offset: 0x1C59191 VA: 0x1C59090 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x1C59310 Offset: 0x1C59411 VA: 0x1C59310
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x1C593F0 Offset: 0x1C594F1 VA: 0x1C593F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4E00 Offset: 0x1A4F01 VA: 0x1A4E00
	// RVA: 0x1C59400 Offset: 0x1C59501 VA: 0x1C59400
	private bool <GetDoropItemList>b__39_0(MonsterControllerBase.DropItemDataParameter param) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4E10 Offset: 0x1A4F11 VA: 0x1A4E10
	// RVA: 0x1C59430 Offset: 0x1C59531 VA: 0x1C59430
	private bool <GetHandCuffsDropItem>b__40_0(DropItemParam param) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4E20 Offset: 0x1A4F21 VA: 0x1A4E20
	// RVA: 0x1C59440 Offset: 0x1C59541 VA: 0x1C59440
	private bool <GetHandCuffsDropItem>b__40_1(DropItemParam param) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4E30 Offset: 0x1A4F31 VA: 0x1A4E30
	// RVA: 0x1C59450 Offset: 0x1C59551 VA: 0x1C59450
	private void <CreateProjectileEvent>b__43_0() { }
}

