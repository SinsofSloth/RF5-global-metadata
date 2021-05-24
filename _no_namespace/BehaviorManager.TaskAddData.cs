public class BehaviorManager.TaskAddData // TypeDefIndex: 4660
{
	// Fields
	public bool fromExternalTask; // 0x10
	public ParentTask parentTask; // 0x18
	public int parentIndex; // 0x20
	public int depth; // 0x24
	public int compositeParentIndex; // 0x28
	public Vector2 offset; // 0x2C
	public Dictionary<string, BehaviorManager.TaskAddData.OverrideFieldValue> overrideFields; // 0x38
	public HashSet<object> overiddenFields; // 0x40
	public int errorTask; // 0x48
	public string errorTaskName; // 0x50

	// Methods

	// RVA: 0x175DF30 Offset: 0x175E031 VA: 0x175DF30
	public void .ctor() { }

	// RVA: 0x17670E0 Offset: 0x17671E1 VA: 0x17670E0
	public void Initialize() { }

	// RVA: 0x17689D0 Offset: 0x1768AD1 VA: 0x17689D0
	public void Destroy() { }
}

