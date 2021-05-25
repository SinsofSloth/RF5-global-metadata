public class BossMonsterStatus : EnemyMonsterStatus // TypeDefIndex: 8288
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16E9A0 Offset: 0x16EAA1 VA: 0x16E9A0
	private bool <IsMadness>k__BackingField; // 0x240
	public bool IsActiveHyperArmor; // 0x241
	private int HyperArmorAccumulatedValue; // 0x244
	private int MaxHyperArmorAccumulatedValue; // 0x248
	private float HyperArmorValuePerTime; // 0x24C
	private float HyperArmorTimer; // 0x250
	private bool _IsHyperArmor; // 0x254
	public BossMonsterStatus.HyperArmorEvent OnChangeHyperArmor; // 0x258

	// Properties
	public bool IsMadness { get; set; }
	protected override float PoisonDamagePercent { get; }
	protected override bool IsBoss { get; }
	public bool IsHyperArmor { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A68D0 Offset: 0x1A69D1 VA: 0x1A68D0
	// RVA: 0x205BFA0 Offset: 0x205C0A1 VA: 0x205BFA0
	public bool get_IsMadness() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A68E0 Offset: 0x1A69E1 VA: 0x1A68E0
	// RVA: 0x205BFB0 Offset: 0x205C0B1 VA: 0x205BFB0
	public void set_IsMadness(bool value) { }

	// RVA: 0x205BFC0 Offset: 0x205C0C1 VA: 0x205BFC0
	public void SetMadness(bool isEnable) { }

	// RVA: 0x205BFD0 Offset: 0x205C0D1 VA: 0x205BFD0
	public void .ctor(int level, MonsterControllerBase owner, MonsterDataID id) { }

	// RVA: 0x205C100 Offset: 0x205C201 VA: 0x205C100 Slot: 16
	protected override float get_PoisonDamagePercent() { }

	// RVA: 0x205C110 Offset: 0x205C211 VA: 0x205C110 Slot: 14
	protected override bool get_IsBoss() { }

	// RVA: 0x205C120 Offset: 0x205C221 VA: 0x205C120
	public bool get_IsHyperArmor() { }

	// RVA: 0x205C130 Offset: 0x205C231 VA: 0x205C130
	private void set_IsHyperArmor(bool value) { }

	// RVA: 0x205C1C0 Offset: 0x205C2C1 VA: 0x205C1C0
	protected void Start() { }

	// RVA: 0x205C250 Offset: 0x205C351 VA: 0x205C250 Slot: 15
	public override void UpdateStatus() { }

	// RVA: 0x205C280 Offset: 0x205C381 VA: 0x205C280
	private void UpdateHyperArmor() { }

	// RVA: 0x205C340 Offset: 0x205C441 VA: 0x205C340 Slot: 11
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x205C4E0 Offset: 0x205C5E1 VA: 0x205C4E0 Slot: 20
	protected override void LevelUp() { }

	// RVA: 0x205CB20 Offset: 0x205CC21 VA: 0x205CB20 Slot: 21
	protected override void LevelDown() { }
}

