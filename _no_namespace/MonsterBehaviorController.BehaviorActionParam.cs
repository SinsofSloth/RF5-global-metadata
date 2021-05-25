protected class MonsterBehaviorController.BehaviorActionParam // TypeDefIndex: 8076
{
	// Fields
	public List<MonsterActionBehaviorType> BehaviorActionTypeList; // 0x10
	public Action SetupAction; // 0x18
	public Action<int, int> ExecuteAction; // 0x20
	public Action<int, int> AbortAction; // 0x28
	public Action EndAction; // 0x30

	// Methods

	// RVA: 0x21613D0 Offset: 0x21614D1 VA: 0x21613D0
	public void .ctor() { }

	// RVA: 0x21613E0 Offset: 0x21614E1 VA: 0x21613E0
	public void .ctor(List<MonsterActionBehaviorType> actionBehaviorTypeList, Action setupAction, Action<int, int> executeAction, Action<int, int> abortAction, Action endAction) { }
}

