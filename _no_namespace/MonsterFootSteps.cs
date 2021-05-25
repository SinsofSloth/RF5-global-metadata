public class MonsterFootSteps : CharaFootSteps<MonsterControllerBase> // TypeDefIndex: 6341
{
	// Fields
	private FootStepType _FootStepType; // 0x60
	private Transform CenterTransform; // 0x68

	// Properties
	protected override FootStepType FootStepType { get; }

	// Methods

	// RVA: 0x2173670 Offset: 0x2173771 VA: 0x2173670 Slot: 4
	protected override FootStepType get_FootStepType() { }

	// RVA: 0x21660D0 Offset: 0x21661D1 VA: 0x21660D0
	public void Setup(MonsterDataTable monsterData, MonsterModel monsterModel, float parentLocalScaleX) { }

	// RVA: 0x2173680 Offset: 0x2173781 VA: 0x2173680
	private void SetFootStepType(MonsterDataTable monsterData) { }

	// RVA: 0x2173690 Offset: 0x2173791 VA: 0x2173690
	private void ResetTransform(MonsterModel monsterModel) { }

	// RVA: 0x2173770 Offset: 0x2173871 VA: 0x2173770 Slot: 8
	protected override Vector3 GetRootPosition() { }

	// RVA: 0x2173840 Offset: 0x2173941 VA: 0x2173840
	public void .ctor() { }
}

