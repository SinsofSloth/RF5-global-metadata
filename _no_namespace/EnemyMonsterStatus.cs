public class EnemyMonsterStatus : MonsterStatusBase // TypeDefIndex: 8295
{
	// Fields
	private int m_BrushCount; // 0x230
	private int m_PresentCount; // 0x234
	private string FocusName; // 0x238

	// Properties
	public override Alliance Alliance { get; }
	public override string Name { get; }
	public override MonsterDataID MonsterDataID { get; }
	public EnemyStatusData EnemyStatusData { get; }
	protected override float PoisonDamagePercent { get; }
	public override int BrushCount { get; set; }
	public override int PresentCount { get; set; }

	// Methods

	// RVA: 0x201E380 Offset: 0x201E481 VA: 0x201E380 Slot: 6
	public override Alliance get_Alliance() { }

	// RVA: 0x201E390 Offset: 0x201E491 VA: 0x201E390 Slot: 26
	public override string get_Name() { }

	// RVA: 0x201E3A0 Offset: 0x201E4A1 VA: 0x201E3A0 Slot: 27
	public override MonsterDataID get_MonsterDataID() { }

	// RVA: 0x201E430 Offset: 0x201E531 VA: 0x201E430
	public EnemyStatusData get_EnemyStatusData() { }

	// RVA: 0x201E4D0 Offset: 0x201E5D1 VA: 0x201E4D0 Slot: 16
	protected override float get_PoisonDamagePercent() { }

	// RVA: 0x201E4E0 Offset: 0x201E5E1 VA: 0x201E4E0 Slot: 22
	public override int get_BrushCount() { }

	// RVA: 0x201E4F0 Offset: 0x201E5F1 VA: 0x201E4F0 Slot: 23
	public override void set_BrushCount(int value) { }

	// RVA: 0x201E500 Offset: 0x201E601 VA: 0x201E500 Slot: 24
	public override int get_PresentCount() { }

	// RVA: 0x201E510 Offset: 0x201E611 VA: 0x201E510 Slot: 25
	public override void set_PresentCount(int value) { }

	// RVA: 0x201E520 Offset: 0x201E621 VA: 0x201E520
	public void .ctor(int spawnLevel, MonsterControllerBase owner, MonsterDataID id) { }

	// RVA: 0x201E920 Offset: 0x201EA21 VA: 0x201E920 Slot: 20
	protected override void LevelUp() { }

	// RVA: 0x201E9A0 Offset: 0x201EAA1 VA: 0x201E9A0 Slot: 21
	protected override void LevelDown() { }
}

