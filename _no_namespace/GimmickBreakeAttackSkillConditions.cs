public class GimmickBreakeAttackSkillConditions : GimmickBreakeConditionsBase // TypeDefIndex: 7561
{
	// Fields
	[SerializeField] // RVA: 0x167480 Offset: 0x167581 VA: 0x167480
	public ItemCategory[] itemCategories; // 0x70
	[SerializeField] // RVA: 0x167490 Offset: 0x167591 VA: 0x167490
	public SkillID SkillID; // 0x78
	[SerializeField] // RVA: 0x1674A0 Offset: 0x1675A1 VA: 0x1674A0
	public int SkillLevel; // 0x7C

	// Methods

	// RVA: 0x1E4AA80 Offset: 0x1E4AB81 VA: 0x1E4AA80
	private bool IsSetItemCategories() { }

	// RVA: 0x1E4AAA0 Offset: 0x1E4ABA1 VA: 0x1E4AAA0
	private bool IsSetSkill() { }

	// RVA: 0x1E4AAB0 Offset: 0x1E4ABB1 VA: 0x1E4AAB0
	private bool CanBreakeWeapon(HumanController human) { }

	// RVA: 0x1E4AB90 Offset: 0x1E4AC91 VA: 0x1E4AB90
	private bool CanBreakeSkillLevel() { }

	// RVA: 0x1E4AC20 Offset: 0x1E4AD21 VA: 0x1E4AC20 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage) { }

	// RVA: 0x1E4B010 Offset: 0x1E4B111 VA: 0x1E4B010
	public void .ctor() { }
}

