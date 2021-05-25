[MessagePackObjectAttribute] // RVA: 0x146B60 Offset: 0x146C61 VA: 0x146B60
public class MonsterLovePoint // TypeDefIndex: 8222
{
	// Fields
	[KeyAttribute] // RVA: 0x16BCD0 Offset: 0x16BDD1 VA: 0x16BCD0
	public int LovePoint; // 0x10
	private const int POINT_MAX = 65535;
	private const int LV_OVER_MAX = 1000;
	private const int LV_MAX = 10;
	private const int LV_10_EXP = 255;
	private const int OVER_LV_EXP = 64;
	private const int PRESENT_ITEM_PLUS_MAX = 5;
	public const int CAN_FARMWORK_LV = 3;
	public const int CAN_SOWINGSEED_LV = 8;
	private const int LoveDrinkID = 2009;
	private readonly int[] LovePointTable; // 0x18
	private readonly int[] LovePointRiseTable; // 0x20

	// Methods

	// RVA: 0x1CCA9D0 Offset: 0x1CCAAD1 VA: 0x1CCA9D0
	public void .ctor() { }

	// RVA: 0x1CCAAA0 Offset: 0x1CCABA1 VA: 0x1CCAAA0
	private int Add(int addPoint) { }

	// RVA: 0x1CCAAE0 Offset: 0x1CCABE1 VA: 0x1CCAAE0
	public bool IsLoveDrink(int itemID) { }

	// RVA: 0x1CCAAF0 Offset: 0x1CCABF1 VA: 0x1CCAAF0
	public int GetPoint() { }

	// RVA: 0x1CCAB00 Offset: 0x1CCAC01 VA: 0x1CCAB00
	public int GetLoveLv() { }

	// RVA: 0x1CCAC50 Offset: 0x1CCAD51 VA: 0x1CCAC50
	public ValueTuple<int, int> GetNowLv_PerNext() { }

	// RVA: 0x1CCAF60 Offset: 0x1CCB061 VA: 0x1CCAF60
	public float GetNowLv_PerForUI() { }

	// RVA: 0x1CCB040 Offset: 0x1CCB141 VA: 0x1CCB040
	private int GetAddLovePoint(MonsterLovePoint.FluctuationType type) { }

	// RVA: 0x1CCB080 Offset: 0x1CCB181 VA: 0x1CCB080
	private int GetAddMonsterSkillLevel() { }

	// RVA: 0x1CCB110 Offset: 0x1CCB211 VA: 0x1CCB110
	public int AddLovePoind(MonsterLovePoint.FluctuationType type, int AddLikePoint = 0) { }
}

