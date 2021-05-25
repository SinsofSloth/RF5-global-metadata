[Serializable]
public class DifficultyData // TypeDefIndex: 6943
{
	// Fields
	[SerializeField] // RVA: 0x161A20 Offset: 0x161B21 VA: 0x161A20
	public float DamageRate; // 0x10
	[SerializeField] // RVA: 0x161A30 Offset: 0x161B31 VA: 0x161A30
	public float EnemyHpRate; // 0x14
	[SerializeField] // RVA: 0x161A40 Offset: 0x161B41 VA: 0x161A40
	public int Cost; // 0x18
	[SerializeField] // RVA: 0x161A50 Offset: 0x161B51 VA: 0x161A50
	public float ExpRate; // 0x1C
	[SerializeField] // RVA: 0x161A60 Offset: 0x161B61 VA: 0x161A60
	public bool KnockBack; // 0x20
	[SerializeField] // RVA: 0x161A70 Offset: 0x161B71 VA: 0x161A70
	public float CriticalRate; // 0x24
	[SerializeField] // RVA: 0x161A80 Offset: 0x161B81 VA: 0x161A80
	public DifficultyWait EnemyWaitTime; // 0x28
	[SerializeField] // RVA: 0x161A90 Offset: 0x161B91 VA: 0x161A90
	public int EnemyGateNum; // 0x2C
	[SerializeField] // RVA: 0x161AA0 Offset: 0x161BA1 VA: 0x161AA0
	public bool Poison; // 0x30
	private static bool IsLoad; // 0x0
	private static DifficultyDataTableArray _DifficultyDataTableArray; // 0x8

	// Properties
	public static DifficultyDataTableArray DifficultyDataTableArray { get; }

	// Methods

	// RVA: 0x1CEAB80 Offset: 0x1CEAC81 VA: 0x1CEAB80
	public void .ctor() { }

	// RVA: 0x1CEAB90 Offset: 0x1CEAC91 VA: 0x1CEAB90
	public void .ctor(float damageRate, float enemyHpRate, int cost, float expRate, bool knockBack, float criticalRate, DifficultyWait enemyWaitTime, int enemyGateNum, bool poison) { }

	// RVA: 0x1CEAC20 Offset: 0x1CEAD21 VA: 0x1CEAC20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CEB1C0 Offset: 0x1CEB2C1 VA: 0x1CEB1C0
	public static DifficultyDataTableArray get_DifficultyDataTableArray() { }

	// RVA: 0x1CEB230 Offset: 0x1CEB331 VA: 0x1CEB230
	private static void LoadData() { }

	// RVA: 0x1CEB360 Offset: 0x1CEB461 VA: 0x1CEB360
	private static DifficultyData GetData(int index) { }

	// RVA: 0x1CEB4B0 Offset: 0x1CEB5B1 VA: 0x1CEB4B0
	public static float GetDamageRate(Difficulty difficulty) { }

	// RVA: 0x1CEB530 Offset: 0x1CEB631 VA: 0x1CEB530
	public static float GetHpRate(Difficulty difficulty) { }

	// RVA: 0x1CEB5B0 Offset: 0x1CEB6B1 VA: 0x1CEB5B0
	public static int GetCost(Difficulty difficulty) { }

	// RVA: 0x1CEB630 Offset: 0x1CEB731 VA: 0x1CEB630
	public static float GetExpRate(Difficulty difficulty) { }

	// RVA: 0x1CEB6B0 Offset: 0x1CEB7B1 VA: 0x1CEB6B0
	public static float GetKnockBack(Difficulty difficulty, float KnockbackTime, Alliance Alliance, bool IsBoss) { }

	// RVA: 0x1CEB760 Offset: 0x1CEB861 VA: 0x1CEB760
	public static float GetCriticalRate(Difficulty difficulty) { }

	// RVA: 0x1CEB7E0 Offset: 0x1CEB8E1 VA: 0x1CEB7E0
	public static DifficultyWait GetWaitTime(Difficulty difficulty) { }

	// RVA: 0x1CEB860 Offset: 0x1CEB961 VA: 0x1CEB860
	public static int GetGateNum(Difficulty difficulty) { }

	// RVA: 0x1CEB8E0 Offset: 0x1CEB9E1 VA: 0x1CEB8E0
	public static bool GetPoison(Difficulty difficulty) { }

	// RVA: 0x1CEB960 Offset: 0x1CEBA61 VA: 0x1CEB960
	private static void .cctor() { }
}

