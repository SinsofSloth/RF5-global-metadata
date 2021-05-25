public class FriendMonsterStatus : MonsterStatusBase // TypeDefIndex: 8297
{
	// Properties
	public override Alliance Alliance { get; }
	public override string Name { get; }
	public override MonsterDataID MonsterDataID { get; }
	public uint FriendDataID { get; }
	public FriendMonsterStatusData FriendMonsterStatusData { get; }
	protected override float PoisonDamagePercent { get; }
	public int LoveLV { get; set; }
	public override int BrushCount { get; set; }
	public override int PresentCount { get; set; }

	// Methods

	// RVA: 0x22A92B0 Offset: 0x22A93B1 VA: 0x22A92B0 Slot: 6
	public override Alliance get_Alliance() { }

	// RVA: 0x22A92C0 Offset: 0x22A93C1 VA: 0x22A92C0 Slot: 26
	public override string get_Name() { }

	// RVA: 0x22A93F0 Offset: 0x22A94F1 VA: 0x22A93F0 Slot: 27
	public override MonsterDataID get_MonsterDataID() { }

	// RVA: 0x22A9480 Offset: 0x22A9581 VA: 0x22A9480
	public uint get_FriendDataID() { }

	// RVA: 0x22A9510 Offset: 0x22A9611 VA: 0x22A9510
	public void .ctor(FriendMonsterStatusData statusData) { }

	// RVA: 0x22A9350 Offset: 0x22A9451 VA: 0x22A9350
	public FriendMonsterStatusData get_FriendMonsterStatusData() { }

	// RVA: 0x22A9560 Offset: 0x22A9661 VA: 0x22A9560 Slot: 16
	protected override float get_PoisonDamagePercent() { }

	// RVA: 0x22A9570 Offset: 0x22A9671 VA: 0x22A9570
	public int get_LoveLV() { }

	// RVA: 0x22A9600 Offset: 0x22A9701 VA: 0x22A9600
	public void set_LoveLV(int value) { }

	// RVA: 0x22A9610 Offset: 0x22A9711 VA: 0x22A9610 Slot: 22
	public override int get_BrushCount() { }

	// RVA: 0x22A96A0 Offset: 0x22A97A1 VA: 0x22A96A0 Slot: 23
	public override void set_BrushCount(int value) { }

	// RVA: 0x22A9740 Offset: 0x22A9841 VA: 0x22A9740 Slot: 24
	public override int get_PresentCount() { }

	// RVA: 0x22A97D0 Offset: 0x22A98D1 VA: 0x22A97D0 Slot: 25
	public override void set_PresentCount(int value) { }

	// RVA: 0x22A9870 Offset: 0x22A9971 VA: 0x22A9870
	public int AddLovePoint(MonsterLovePoint.FluctuationType type, int AddLikePoint = 0, bool isRenew = True) { }

	// RVA: 0x22A9940 Offset: 0x22A9A41 VA: 0x22A9940 Slot: 20
	protected override void LevelUp() { }

	// RVA: 0x22A9AA0 Offset: 0x22A9BA1 VA: 0x22A9AA0
	public bool AddDefeatBonus(MonsterDataID monsterDataID) { }

	// RVA: 0x22AA170 Offset: 0x22AA271 VA: 0x22AA170
	public void Present(ItemData item, out bool isFavorite) { }

	// RVA: 0x22AA510 Offset: 0x22AA611 VA: 0x22AA510
	private static Parameter PresentStatusUp_Item(ItemData item, bool isFav) { }

	// RVA: 0x22AA7F0 Offset: 0x22AA8F1 VA: 0x22AA7F0
	private static Parameter PresentStatusUp_Category(ItemCategory category) { }
}

