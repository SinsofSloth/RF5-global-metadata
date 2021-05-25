public class FurnitureBreakConditions : CharacterBase // TypeDefIndex: 10263
{
	// Fields
	[SerializeField] // RVA: 0x180AA0 Offset: 0x180BA1 VA: 0x180AA0
	public AttackType attackType; // 0x64
	[SerializeField] // RVA: 0x180AB0 Offset: 0x180BB1 VA: 0x180AB0
	public AttackAttribute[] attackAttribute; // 0x68
	[SerializeField] // RVA: 0x180AC0 Offset: 0x180BC1 VA: 0x180AC0
	public int Hp; // 0x70
	private StorageFurniture Owner; // 0x78

	// Properties
	public override Vector3 GetTakeLockonPos { get; }

	// Methods

	// RVA: 0x1F2FCB0 Offset: 0x1F2FDB1 VA: 0x1F2FCB0 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage) { }

	// RVA: 0x1F301C0 Offset: 0x1F302C1 VA: 0x1F301C0 Slot: 11
	protected override void Awake() { }

	// RVA: 0x1F30230 Offset: 0x1F30331 VA: 0x1F30230 Slot: 10
	public override Vector3 get_GetTakeLockonPos() { }

	// RVA: 0x1F30290 Offset: 0x1F30391 VA: 0x1F30290 Slot: 9
	public override bool IsCanNotLockon(CharacterBase lockonCharacter) { }

	// RVA: 0x1F30390 Offset: 0x1F30491 VA: 0x1F30390
	public void .ctor() { }
}

