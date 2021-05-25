[Serializable]
public class HitOptionParamDataTable // TypeDefIndex: 6967
{
	// Fields
	[SerializeField] // RVA: 0x1620E0 Offset: 0x1621E1 VA: 0x1620E0
	public HitOptionParamDataTable.LevelData DamageRate; // 0x10
	[SerializeField] // RVA: 0x1620F0 Offset: 0x1621F1 VA: 0x1620F0
	public HitOptionParamDataTable.LevelData BlowAwayRate; // 0x38
	[SerializeField] // RVA: 0x162100 Offset: 0x162201 VA: 0x162100
	public HitOptionParamDataTable.LevelData BlowPowerRate; // 0x60
	public HitOptionParamDataTable.LevelData AttackPoison; // 0x88
	public HitOptionParamDataTable.LevelData AttackParalysis; // 0xB0
	public HitOptionParamDataTable.LevelData AttackSleep; // 0xD8
	public HitOptionParamDataTable.LevelData AttackTire; // 0x100
	public HitOptionParamDataTable.LevelData AttackSick; // 0x128
	public HitOptionParamDataTable.LevelData AttackDeath; // 0x150
	public HitOptionParamDataTable.LevelData AttackHpDrain; // 0x178
	public HitOptionParamDataTable.LevelData AttackSeal; // 0x1A0
	[SerializeField] // RVA: 0x162110 Offset: 0x162211 VA: 0x162110
	public TimeScaleID TimeScaleID; // 0x1C8
	[SerializeField] // RVA: 0x162120 Offset: 0x162221 VA: 0x162120
	public float KnockBackRate; // 0x1CC
	[SerializeField] // RVA: 0x162130 Offset: 0x162231 VA: 0x162130
	public HitType HitType; // 0x1D0
	private static HitOptionParamDataTableArray _HitOptionParamDataTableArray; // 0x0

	// Methods

	// RVA: 0x2305840 Offset: 0x2305941 VA: 0x2305840
	public static HitOptionParamDataTable GetDataTable(HitOptionParamID id) { }

	// RVA: 0x2305990 Offset: 0x2305A91 VA: 0x2305990
	public void .ctor() { }
}

