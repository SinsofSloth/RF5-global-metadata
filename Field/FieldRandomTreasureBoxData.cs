public class FieldRandomTreasureBoxData : FieldTreasureBoxData // TypeDefIndex: 10506
{
	// Fields
	private const int ItemDropRate = 100;
	private const int ItemDrop2Rate = 75;
	private const int ItemDrop3Rate = 50;
	private const int ItemDrop4Rate = 50;
	private FieldRandomTreasureBoxSpawnID _FieldRandomBoxSpawnID; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x181CB0 Offset: 0x181DB1 VA: 0x181CB0
	private FieldRandomTreasureBoxSpawnDataTable <RandomBoxSpawnData>k__BackingField; // 0x38
	public int LotteryType; // 0x58

	// Properties
	public FieldRandomTreasureBoxSpawnID FieldRandomBoxSpawnID { get; set; }
	public FieldRandomTreasureBoxSpawnDataTable RandomBoxSpawnData { get; set; }

	// Methods

	// RVA: 0x1E278A0 Offset: 0x1E279A1 VA: 0x1E278A0
	public FieldRandomTreasureBoxSpawnID get_FieldRandomBoxSpawnID() { }

	// RVA: 0x1E278B0 Offset: 0x1E279B1 VA: 0x1E278B0
	public void set_FieldRandomBoxSpawnID(FieldRandomTreasureBoxSpawnID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AFA90 Offset: 0x1AFB91 VA: 0x1AFA90
	// RVA: 0x1E278C0 Offset: 0x1E279C1 VA: 0x1E278C0
	public FieldRandomTreasureBoxSpawnDataTable get_RandomBoxSpawnData() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AFAA0 Offset: 0x1AFBA1 VA: 0x1AFAA0
	// RVA: 0x1E278E0 Offset: 0x1E279E1 VA: 0x1E278E0
	public void set_RandomBoxSpawnData(FieldRandomTreasureBoxSpawnDataTable value) { }

	// RVA: 0x1E27900 Offset: 0x1E27A01 VA: 0x1E27900 Slot: 4
	public override void SetDataId(int id) { }

	// RVA: 0x1E27910 Offset: 0x1E27A11 VA: 0x1E27910 Slot: 10
	public override bool IsRespawn() { }

	// RVA: 0x1E27920 Offset: 0x1E27A21 VA: 0x1E27920 Slot: 11
	public override bool IsTakeDamege() { }

	// RVA: 0x1E27930 Offset: 0x1E27A31 VA: 0x1E27930 Slot: 12
	public override FieldTreasureBoxDropItem[] GetDropItems() { }

	// RVA: 0x1E27D80 Offset: 0x1E27E81 VA: 0x1E27D80 Slot: 13
	public override FieldTreasureBoxDropRecipe[] GetDropRecipes() { }

	// RVA: 0x1E27D90 Offset: 0x1E27E91 VA: 0x1E27D90 Slot: 14
	public override int GetDropGold() { }

	// RVA: 0x1E27DA0 Offset: 0x1E27EA1 VA: 0x1E27DA0 Slot: 15
	public override bool CanSpawnSeason(Season season) { }

	// RVA: 0x1E27DB0 Offset: 0x1E27EB1 VA: 0x1E27DB0
	public void .ctor() { }
}

