[Serializable]
public struct ItemLevelData // TypeDefIndex: 7530
{
	// Fields
	[SerializeField] // RVA: 0x166E70 Offset: 0x166F71 VA: 0x166E70
	public int[] Level; // 0x0
	private static bool IsLoad; // 0x0
	private static ItemLevelDataTableArray _ItemLevelDataTableArray; // 0x8

	// Methods

	// RVA: 0x2E16E0 Offset: 0x2E17E1 VA: 0x2E16E0
	public void .ctor(int level0, int level1, int level2, int level3) { }

	// RVA: 0x2E16F0 Offset: 0x2E17F1 VA: 0x2E16F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F46E70 Offset: 0x1F46F71 VA: 0x1F46E70
	public static int GetLevel(int table) { }

	// RVA: 0x1F46FD0 Offset: 0x1F470D1 VA: 0x1F46FD0
	public static void LoadData() { }

	// RVA: 0x1F47100 Offset: 0x1F47201 VA: 0x1F47100
	private static void .cctor() { }
}

