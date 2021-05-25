public static class ObjectPool // TypeDefIndex: 4681
{
	// Fields
	private static Dictionary<Type, object> poolDictionary; // 0x0
	private static object lockObject; // 0x8

	// Methods

	// RVA: 0x1B221C0 Offset: 0x1B222C1 VA: 0x1B221C0
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	public static T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BE300 Offset: 0x23BE401 VA: 0x23BE300
	|-ObjectPool.Get<BehaviorManager.BehaviorTree.ConditionalReevaluate>
	|-ObjectPool.Get<BehaviorManager.BehaviorTree>
	|-ObjectPool.Get<BehaviorManager.TaskAddData.OverrideFieldValue>
	|-ObjectPool.Get<BehaviorManager.TaskAddData>
	|-ObjectPool.Get<BehaviorManager.ThirdPartyTask>
	|-ObjectPool.Get<BehaviorSource>
	|-ObjectPool.Get<Dictionary<int, int>>
	|-ObjectPool.Get<Dictionary<string, BehaviorManager.TaskAddData.OverrideFieldValue>>
	|-ObjectPool.Get<HashSet<int>>
	|-ObjectPool.Get<List<int>>
	|-ObjectPool.Get<List<FieldInfo>>
	|-ObjectPool.Get<Stack<int>>
	|-ObjectPool.Get<object>
	*/

	// RVA: -1 Offset: -1
	public static void Return<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CE8C0 Offset: 0x21CE9C1 VA: 0x21CE8C0
	|-ObjectPool.Return<BehaviorManager.BehaviorTree.ConditionalReevaluate>
	|-ObjectPool.Return<BehaviorManager.BehaviorTree>
	|-ObjectPool.Return<BehaviorManager.TaskAddData>
	|-ObjectPool.Return<BehaviorSource>
	|-ObjectPool.Return<Dictionary<int, int>>
	|-ObjectPool.Return<Dictionary<string, BehaviorManager.TaskAddData.OverrideFieldValue>>
	|-ObjectPool.Return<HashSet<int>>
	|-ObjectPool.Return<List<int>>
	|-ObjectPool.Return<List<FieldInfo>>
	|-ObjectPool.Return<Stack<int>>
	|-ObjectPool.Return<object>
	|
	|-RVA: 0x21CE5C0 Offset: 0x21CE6C1 VA: 0x21CE5C0
	|-ObjectPool.Return<KeyValuePair<object, object>>
	|-ObjectPool.Return<KeyValuePair<string, BehaviorManager.TaskAddData.OverrideFieldValue>>
	*/

	// RVA: 0x1B22270 Offset: 0x1B22371 VA: 0x1B22270
	public static void Clear() { }
}

