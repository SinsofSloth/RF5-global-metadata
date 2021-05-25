public class HumanStatus : CharacterStatusBase // TypeDefIndex: 8299
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16EAE0 Offset: 0x16EBE1 VA: 0x16EAE0
	private ActorID <ActorID>k__BackingField; // 0x21C

	// Properties
	public override Alliance Alliance { get; }
	public override Character Owner { get; }
	public ActorID ActorID { get; set; }
	public HumanStatusData HumanStatusData { get; }
	public override HumanEquip EquipItem { get; }
	protected override float PoisonDamagePercent { get; }
	public virtual float DualSkillGauge { get; set; }
	public bool IsGaugeMax { get; }
	public bool CanDualSkill { get; }

	// Methods

	// RVA: 0x20C26A0 Offset: 0x20C27A1 VA: 0x20C26A0 Slot: 6
	public override Alliance get_Alliance() { }

	// RVA: 0x20C26B0 Offset: 0x20C27B1 VA: 0x20C26B0 Slot: 4
	public override Character get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6BA0 Offset: 0x1A6CA1 VA: 0x1A6BA0
	// RVA: 0x20C2760 Offset: 0x20C2861 VA: 0x20C2760
	public ActorID get_ActorID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6BB0 Offset: 0x1A6CB1 VA: 0x1A6BB0
	// RVA: 0x20C2770 Offset: 0x20C2871 VA: 0x20C2770
	private void set_ActorID(ActorID value) { }

	// RVA: 0x20C2780 Offset: 0x20C2881 VA: 0x20C2780
	public HumanStatusData get_HumanStatusData() { }

	// RVA: 0x20C2820 Offset: 0x20C2921 VA: 0x20C2820 Slot: 7
	public override HumanEquip get_EquipItem() { }

	// RVA: 0x20C28B0 Offset: 0x20C29B1 VA: 0x20C28B0 Slot: 16
	protected override float get_PoisonDamagePercent() { }

	// RVA: 0x20C28C0 Offset: 0x20C29C1 VA: 0x20C28C0
	public void .ctor(ActorID actor_id) { }

	// RVA: 0x20C2AC0 Offset: 0x20C2BC1 VA: 0x20C2AC0 Slot: 13
	protected override CharaParamDataTable GetCharaParam() { }

	// RVA: 0x20C2AF0 Offset: 0x20C2BF1 VA: 0x20C2AF0 Slot: 20
	protected override void LevelUp() { }

	// RVA: 0x20C2BD0 Offset: 0x20C2CD1 VA: 0x20C2BD0 Slot: 22
	public virtual int GetSkillLevel(SkillID skill) { }

	// RVA: 0x20C2C30 Offset: 0x20C2D31 VA: 0x20C2C30 Slot: 23
	public virtual void DoActionRpExp(SkillActionID skillAction, int level = 1) { }

	// RVA: 0x20C2C40 Offset: 0x20C2D41 VA: 0x20C2C40 Slot: 24
	public virtual void DoActionRpExp(SkillActionID skillAction, int level, float useRpRate = 1) { }

	// RVA: 0x20C2C50 Offset: 0x20C2D51 VA: 0x20C2C50 Slot: 25
	public virtual void DoActionExp(SkillActionID skillAction) { }

	// RVA: 0x20C2C60 Offset: 0x20C2D61 VA: 0x20C2C60 Slot: 26
	public virtual void DoActionRp(SkillActionID skillAction, int level = 1) { }

	// RVA: 0x20C2C70 Offset: 0x20C2D71 VA: 0x20C2C70 Slot: 27
	public virtual void DoActionRp(SkillActionID skillAction, int level, float useRpRate = 1) { }

	// RVA: 0x20C2C80 Offset: 0x20C2D81 VA: 0x20C2C80 Slot: 28
	public virtual float get_DualSkillGauge() { }

	// RVA: 0x20C2D10 Offset: 0x20C2E11 VA: 0x20C2D10 Slot: 29
	public virtual void set_DualSkillGauge(float value) { }

	// RVA: 0x20C2DA0 Offset: 0x20C2EA1 VA: 0x20C2DA0
	public bool get_IsGaugeMax() { }

	// RVA: 0x20C2DD0 Offset: 0x20C2ED1 VA: 0x20C2DD0
	public bool get_CanDualSkill() { }

	// RVA: 0x20C2E50 Offset: 0x20C2F51 VA: 0x20C2E50
	public void ClearDualSkillGauge() { }

	// RVA: 0x20C2E70 Offset: 0x20C2F71 VA: 0x20C2E70 Slot: 19
	public override DamageInfo CreateMagicDamageInfo(MagicParamDataTable dataTable, int level) { }

	// RVA: 0x20C3720 Offset: 0x20C3821 VA: 0x20C3720 Slot: 11
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x20C3810 Offset: 0x20C3911 VA: 0x20C3810
	public DamageInfo CreateObjThrowDamage() { }

	// RVA: 0x20C3960 Offset: 0x20C3A61 VA: 0x20C3960 Slot: 30
	public virtual void AddDualSkillGauge(DualSkillGaugeUpType dualSkillGaugeUpType) { }
}

