[Serializable]
public class MonsterModelData // TypeDefIndex: 7778
{
	// Fields
	[SerializeField] // RVA: 0x169870 Offset: 0x169971 VA: 0x169870
	public MonsterModelDataID DataID; // 0x10
	[SerializeField] // RVA: 0x169880 Offset: 0x169981 VA: 0x169880
	public Prefab MonsterControllerLoaderID; // 0x14
	[SerializeField] // RVA: 0x169890 Offset: 0x169991 VA: 0x169890
	public Prefab EnemyModelLoaderID; // 0x18
	[SerializeField] // RVA: 0x1698A0 Offset: 0x1699A1 VA: 0x1698A0
	public Prefab FriendModelLoaderID; // 0x1C
	[SerializeField] // RVA: 0x1698B0 Offset: 0x1699B1 VA: 0x1698B0
	public float EnemyPrefabScale; // 0x20
	[SerializeField] // RVA: 0x1698C0 Offset: 0x1699C1 VA: 0x1698C0
	public float FriendPrefabScale; // 0x24
	[SerializeField] // RVA: 0x1698D0 Offset: 0x1699D1 VA: 0x1698D0
	public float EnemyEmotionScale; // 0x28
	[SerializeField] // RVA: 0x1698E0 Offset: 0x1699E1 VA: 0x1698E0
	public float FriendEmotionScale; // 0x2C
	[SerializeField] // RVA: 0x1698F0 Offset: 0x1699F1 VA: 0x1698F0
	public float UIPrefabScale; // 0x30
	[SerializeField] // RVA: 0x169900 Offset: 0x169A01 VA: 0x169900
	public HeightSizeType HeightSize; // 0x34
	private static MonsterModelDataTable _MonsterModelDataTable; // 0x0

	// Methods

	// RVA: 0x1CD1260 Offset: 0x1CD1361 VA: 0x1CD1260
	public Prefab GetModelLoaderID(bool isEnemy) { }

	// RVA: 0x1CD0600 Offset: 0x1CD0701 VA: 0x1CD0600
	public float GetScale(bool isEnemy) { }

	// RVA: 0x1CD2DB0 Offset: 0x1CD2EB1 VA: 0x1CD2DB0
	public float GetEmotionScale(bool isEnemy) { }

	// RVA: 0x1CD2DD0 Offset: 0x1CD2ED1 VA: 0x1CD2DD0
	public static MonsterModelData GetDataTable(MonsterModelDataID dataID) { }

	// RVA: 0x1CD2F30 Offset: 0x1CD3031 VA: 0x1CD2F30
	public void .ctor() { }
}

