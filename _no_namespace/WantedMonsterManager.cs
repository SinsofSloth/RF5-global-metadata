public class WantedMonsterManager // TypeDefIndex: 8039
{
	// Fields
	private const float Length = 5;
	private const string FieldSceneName = "FieldMap";
	private bool ExistOnFieldScene; // 0x10
	private Dictionary<WantedFieldType, WantedField> WantedFieldDic; // 0x18
	private MonsterBehaviorController WantedMonsterBehaviorController; // 0x20
	private float AppearRange; // 0x28
	private float DisappearRange; // 0x2C
	private Transform PopPointTransform; // 0x30
	private List<Action> UpdateStateList; // 0x38
	private WantedMonsterManager.State CurrentState; // 0x40

	// Methods

	// RVA: 0x1D03060 Offset: 0x1D03161 VA: 0x1D03060
	public void .ctor() { }

	// RVA: 0x1D03240 Offset: 0x1D03341 VA: 0x1D03240
	private void DestroyMonster() { }

	// RVA: 0x1D03320 Offset: 0x1D03421 VA: 0x1D03320
	public void Setup() { }

	// RVA: 0x1D03560 Offset: 0x1D03661 VA: 0x1D03560
	public void CheckWantedData() { }

	// RVA: 0x1D037B0 Offset: 0x1D038B1 VA: 0x1D037B0
	public void OnUpdate() { }

	// RVA: 0x1D038B0 Offset: 0x1D039B1 VA: 0x1D038B0
	private void UpdateWaitAppearing() { }

	// RVA: 0x1D03D60 Offset: 0x1D03E61 VA: 0x1D03D60
	private void OnDeadFinish(MonsterControllerBase monster) { }

	// RVA: 0x1D03E90 Offset: 0x1D03F91 VA: 0x1D03E90
	private void UpdateWaitDisappearing() { }

	// RVA: 0x1D03830 Offset: 0x1D03931 VA: 0x1D03830
	private void UpdateWantedState() { }

	// RVA: 0x1D033E0 Offset: 0x1D034E1 VA: 0x1D033E0
	private void SetupWantedField() { }

	// RVA: 0x1D036C0 Offset: 0x1D037C1 VA: 0x1D036C0
	private bool ExistData() { }

	// RVA: 0x1D03690 Offset: 0x1D03791 VA: 0x1D03690
	public void OnReset() { }
}

