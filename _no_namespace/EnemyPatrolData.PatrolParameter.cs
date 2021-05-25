[Serializable]
public class EnemyPatrolData.PatrolParameter // TypeDefIndex: 8002
{
	// Fields
	[SerializeField] // RVA: 0x195A10 Offset: 0x195B11 VA: 0x195A10
	private List<MonsterCharacterType> CharacterTypeList; // 0x10
	[SerializeField] // RVA: 0x195A20 Offset: 0x195B21 VA: 0x195A20
	public List<EnemyPatrolData.PatrolParameter.PatrollBehaviorTypeKeyAndValue> PatrolLot; // 0x18
	[SerializeField] // RVA: 0x195A30 Offset: 0x195B31 VA: 0x195A30
	private float MinWalkTime; // 0x20
	[SerializeField] // RVA: 0x195A40 Offset: 0x195B41 VA: 0x195A40
	private float MaxWalkTime; // 0x24
	[SerializeField] // RVA: 0x195A50 Offset: 0x195B51 VA: 0x195A50
	private float MinRunTime; // 0x28
	[SerializeField] // RVA: 0x195A60 Offset: 0x195B61 VA: 0x195A60
	private float MaxRunTime; // 0x2C
	[SerializeField] // RVA: 0x195A70 Offset: 0x195B71 VA: 0x195A70
	private int MinWaitCount; // 0x30
	[SerializeField] // RVA: 0x195A80 Offset: 0x195B81 VA: 0x195A80
	private int MaxWaitCount; // 0x34

	// Methods

	// RVA: 0x201EAB0 Offset: 0x201EBB1 VA: 0x201EAB0
	public bool ExistCharacterType(MonsterCharacterType type) { }

	// RVA: 0x201D5B0 Offset: 0x201D6B1 VA: 0x201D5B0
	public PatrolBehaviorType GetLotteryPatrolType() { }

	// RVA: 0x201D790 Offset: 0x201D891 VA: 0x201D790
	public float GetWalkTime() { }

	// RVA: 0x201D7A0 Offset: 0x201D8A1 VA: 0x201D7A0
	public float GetRunTime() { }

	// RVA: 0x201D7B0 Offset: 0x201D8B1 VA: 0x201D7B0
	public int GetWaitCount() { }

	// RVA: 0x201EB20 Offset: 0x201EC21 VA: 0x201EB20
	public void .ctor() { }
}

