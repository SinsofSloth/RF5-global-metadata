public class SeedPointManager // TypeDefIndex: 8815
{
	// Fields
	private const int MonsterMaxCountInOneDay = 50;
	private static readonly int[] QuestPointTable; // 0x0
	private static readonly int[,] BasePointTable; // 0x8

	// Properties
	private static bool PatrolBatchEquiped { get; }

	// Methods

	// RVA: 0x1C86CA0 Offset: 0x1C86DA1 VA: 0x1C86CA0
	private static bool get_PatrolBatchEquiped() { }

	// RVA: 0x1C86D10 Offset: 0x1C86E11 VA: 0x1C86D10
	private static int CalcBatchPoint(int basePoint) { }

	// RVA: 0x1C86E10 Offset: 0x1C86F11 VA: 0x1C86E10
	public static void AddBoardQuestComplete(int addPoint) { }

	// RVA: 0x1C87010 Offset: 0x1C87111 VA: 0x1C87010
	public static void AddNPCQuestComplete(int addPoint) { }

	// RVA: 0x1C87100 Offset: 0x1C87201 VA: 0x1C87100
	public static void AddWantedClear(int addPoint) { }

	// RVA: 0x1C87170 Offset: 0x1C87271 VA: 0x1C87170
	public static void AddWantedComplete(int addPoint) { }

	// RVA: 0x1C871E0 Offset: 0x1C872E1 VA: 0x1C871E0
	public static void AddShipping(int totalPrice) { }

	// RVA: 0x1C86F00 Offset: 0x1C87001 VA: 0x1C86F00
	private static int GetBasePoint(SeedPointManager.Type type) { }

	// RVA: 0x1C872C0 Offset: 0x1C873C1 VA: 0x1C872C0
	public static void Add(SeedPointManager.Type type) { }

	// RVA: 0x1C87430 Offset: 0x1C87531 VA: 0x1C87430
	public void .ctor() { }

	// RVA: 0x1C87440 Offset: 0x1C87541 VA: 0x1C87440
	private static void .cctor() { }
}

