public static class MonsterUtility // TypeDefIndex: 8095
{
	// Fields
	public static readonly Dictionary<int, Vector2Int> MakingMonsterLevelupStageDic; // 0x0
	public const int MonsterLevelupStageMin = 0;
	public const int MonsterLevelupStageMax = 10;
	public static uint MaxFarmSupportMonsterCount; // 0x8
	public static readonly Dictionary<int, MonsterDataID> ConvertMonsterDataIdDic; // 0x10

	// Methods

	// RVA: 0x1CD8550 Offset: 0x1CD8651 VA: 0x1CD8550
	public static bool ExistWoolMocomocoMonsterDataId(MonsterDataID monsterDataId) { }

	// RVA: 0x1CD8570 Offset: 0x1CD8671 VA: 0x1CD8570
	public static bool NotExistWoolMocomocoMonsterDataId(MonsterDataID monsterDataId) { }

	// RVA: 0x1CD8590 Offset: 0x1CD8691 VA: 0x1CD8590
	public static bool IsMocomocoMonsterDataId(MonsterDataID monsterDataId) { }

	// RVA: 0x1CD8660 Offset: 0x1CD8761 VA: 0x1CD8660
	public static bool CanGrowsWoolMocomocoMonsterData(MonsterDataID monsterDataID) { }

	// RVA: 0x1CD8670 Offset: 0x1CD8771 VA: 0x1CD8670
	public static void UpdateSuction(Transform centerTransform, float suctionPower, float minRange, float maxRange) { }

	// RVA: 0x1CD8940 Offset: 0x1CD8A41 VA: 0x1CD8940
	public static bool GetNavimeshPostion(Vector3 pos, int sampleRange, int areaMask, out Vector3 hitPos) { }

	// RVA: 0x1CD89C0 Offset: 0x1CD8AC1 VA: 0x1CD89C0
	public static Vector3 GetRandomPlanePostion(Transform targetTransform, float maxRadius, float sampleRange, int areaMask, Func<NavMeshHit, bool> compareFlag, float minRadius = 0) { }

	// RVA: 0x1CD8C30 Offset: 0x1CD8D31 VA: 0x1CD8C30
	private static void .cctor() { }
}

