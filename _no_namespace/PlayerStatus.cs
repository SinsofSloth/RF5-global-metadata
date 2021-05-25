public class PlayerStatus : HumanStatus // TypeDefIndex: 8303
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16EB20 Offset: 0x16EC21 VA: 0x16EB20
	private float <CurrentTimer_AutoRPHeal>k__BackingField; // 0x220
	[CompilerGeneratedAttribute] // RVA: 0x16EB30 Offset: 0x16EC31 VA: 0x16EB30
	private bool <IsAutoRPHeal>k__BackingField; // 0x224

	// Properties
	private float CurrentTimer_AutoRPHeal { get; set; }
	public bool IsAutoRPHeal { get; set; }
	public override Character Owner { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6C20 Offset: 0x1A6D21 VA: 0x1A6C20
	// RVA: 0x2204D30 Offset: 0x2204E31 VA: 0x2204D30
	private float get_CurrentTimer_AutoRPHeal() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6C30 Offset: 0x1A6D31 VA: 0x1A6C30
	// RVA: 0x2204D40 Offset: 0x2204E41 VA: 0x2204D40
	private void set_CurrentTimer_AutoRPHeal(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6C40 Offset: 0x1A6D41 VA: 0x1A6C40
	// RVA: 0x2204D50 Offset: 0x2204E51 VA: 0x2204D50
	public bool get_IsAutoRPHeal() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6C50 Offset: 0x1A6D51 VA: 0x1A6C50
	// RVA: 0x2204D60 Offset: 0x2204E61 VA: 0x2204D60
	public void set_IsAutoRPHeal(bool value) { }

	// RVA: 0x2204D70 Offset: 0x2204E71 VA: 0x2204D70
	public void .ctor(ActorID actor_id) { }

	// RVA: 0x2204D80 Offset: 0x2204E81 VA: 0x2204D80 Slot: 4
	public override Character get_Owner() { }

	// RVA: 0x2204E30 Offset: 0x2204F31 VA: 0x2204E30 Slot: 20
	protected override void LevelUp() { }

	// RVA: 0x2204F60 Offset: 0x2205061 VA: 0x2204F60 Slot: 21
	protected override void LevelDown() { }

	// RVA: 0x2205050 Offset: 0x2205151 VA: 0x2205050 Slot: 22
	public override int GetSkillLevel(SkillID skill) { }

	// RVA: 0x22050C0 Offset: 0x22051C1 VA: 0x22050C0 Slot: 11
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x22054B0 Offset: 0x22055B1 VA: 0x22054B0 Slot: 23
	public override void DoActionRpExp(SkillActionID skillAction, int level = 1) { }

	// RVA: 0x22054D0 Offset: 0x22055D1 VA: 0x22054D0 Slot: 24
	public override void DoActionRpExp(SkillActionID skillAction, int level, float useRpRate = 1) { }

	// RVA: 0x2205620 Offset: 0x2205721 VA: 0x2205620 Slot: 25
	public override void DoActionExp(SkillActionID skillAction) { }

	// RVA: 0x2205690 Offset: 0x2205791 VA: 0x2205690 Slot: 26
	public override void DoActionRp(SkillActionID skillAction, int level = 1) { }

	// RVA: 0x22056B0 Offset: 0x22057B1 VA: 0x22056B0 Slot: 27
	public override void DoActionRp(SkillActionID skillAction, int level, float rpRate = 1) { }

	// RVA: 0x2205800 Offset: 0x2205901 VA: 0x2205800
	public void UpdateAutoRPHeal(float deltaTime) { }

	// RVA: 0x2205990 Offset: 0x2205A91 VA: 0x2205990 Slot: 30
	public override void AddDualSkillGauge(DualSkillGaugeUpType dualSkillGaugeUpType) { }
}

