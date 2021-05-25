public class HandCuffsStatus : MonsterStatusBase // TypeDefIndex: 8298
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

	// RVA: 0x22F4A80 Offset: 0x22F4B81 VA: 0x22F4A80 Slot: 6
	public override Alliance get_Alliance() { }

	// RVA: 0x22F4A90 Offset: 0x22F4B91 VA: 0x22F4A90 Slot: 26
	public override string get_Name() { }

	// RVA: 0x22F4AA0 Offset: 0x22F4BA1 VA: 0x22F4AA0 Slot: 27
	public override MonsterDataID get_MonsterDataID() { }

	// RVA: 0x22F4B30 Offset: 0x22F4C31 VA: 0x22F4B30
	public EnemyStatusData get_EnemyStatusData() { }

	// RVA: 0x22F4BD0 Offset: 0x22F4CD1 VA: 0x22F4BD0 Slot: 16
	protected override float get_PoisonDamagePercent() { }

	// RVA: 0x22F4BE0 Offset: 0x22F4CE1 VA: 0x22F4BE0 Slot: 22
	public override int get_BrushCount() { }

	// RVA: 0x22F4BF0 Offset: 0x22F4CF1 VA: 0x22F4BF0 Slot: 23
	public override void set_BrushCount(int value) { }

	// RVA: 0x22F4C00 Offset: 0x22F4D01 VA: 0x22F4C00 Slot: 24
	public override int get_PresentCount() { }

	// RVA: 0x22F4C10 Offset: 0x22F4D11 VA: 0x22F4C10 Slot: 25
	public override void set_PresentCount(int value) { }

	// RVA: 0x22F4C20 Offset: 0x22F4D21 VA: 0x22F4C20 Slot: 20
	protected override void LevelUp() { }

	// RVA: 0x22F4C30 Offset: 0x22F4D31 VA: 0x22F4C30
	public void .ctor(EnemyStatusData statusData) { }
}

