public class GimmickBreakeMoveCloudConditions : GimmickBreakeConditionsBase // TypeDefIndex: 7563
{
	// Fields
	[SerializeField] // RVA: 0x1674B0 Offset: 0x1675B1 VA: 0x1674B0
	public AttackType attackType; // 0x70
	[SerializeField] // RVA: 0x1674C0 Offset: 0x1675C1 VA: 0x1674C0
	public AttackAttribute[] attackAttribute; // 0x78
	[SerializeField] // RVA: 0x1674D0 Offset: 0x1675D1 VA: 0x1674D0
	public int Hp; // 0x80
	[SerializeField] // RVA: 0x1674E0 Offset: 0x1675E1 VA: 0x1674E0
	[RangeAttribute] // RVA: 0x1674E0 Offset: 0x1675E1 VA: 0x1674E0
	private float PushPercent; // 0x84

	// Methods

	// RVA: 0x1E4B1E0 Offset: 0x1E4B2E1 VA: 0x1E4B1E0
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x1E4B430 Offset: 0x1E4B531 VA: 0x1E4B430 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage) { }

	// RVA: 0x1E4B640 Offset: 0x1E4B741 VA: 0x1E4B640
	public void .ctor() { }
}

