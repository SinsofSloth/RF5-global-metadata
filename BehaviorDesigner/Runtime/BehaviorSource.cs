[Serializable]
public class BehaviorSource : IVariableSource // TypeDefIndex: 4666
{
	// Fields
	public string behaviorName; // 0x10
	public string behaviorDescription; // 0x18
	private int behaviorID; // 0x20
	private Task mEntryTask; // 0x28
	private Task mRootTask; // 0x30
	private List<Task> mDetachedTasks; // 0x38
	private List<SharedVariable> mVariables; // 0x40
	private Dictionary<string, int> mSharedVariableIndex; // 0x48
	private bool mHasSerialized; // 0x50
	[SerializeField] // RVA: 0x12D520 Offset: 0x12D621 VA: 0x12D520
	private TaskSerializationData mTaskData; // 0x58
	[SerializeField] // RVA: 0x12D530 Offset: 0x12D631 VA: 0x12D530
	private IBehavior mOwner; // 0x60

	// Properties
	public Task EntryTask { get; set; }
	public Task RootTask { get; set; }
	public List<Task> DetachedTasks { get; set; }
	public List<SharedVariable> Variables { get; set; }
	public bool HasSerialized { get; set; }
	public IBehavior Owner { get; set; }

	// Methods

	// RVA: 0x17700E0 Offset: 0x17701E1 VA: 0x17700E0
	public void .ctor() { }

	// RVA: 0x175E120 Offset: 0x175E221 VA: 0x175E120
	public void .ctor(IBehavior owner) { }

	// RVA: 0x1770170 Offset: 0x1770271 VA: 0x1770170
	public Task get_EntryTask() { }

	// RVA: 0x1770180 Offset: 0x1770281 VA: 0x1770180
	public void set_EntryTask(Task value) { }

	// RVA: 0x1770190 Offset: 0x1770291 VA: 0x1770190
	public Task get_RootTask() { }

	// RVA: 0x17701A0 Offset: 0x17702A1 VA: 0x17701A0
	public void set_RootTask(Task value) { }

	// RVA: 0x17701B0 Offset: 0x17702B1 VA: 0x17701B0
	public List<Task> get_DetachedTasks() { }

	// RVA: 0x17701C0 Offset: 0x17702C1 VA: 0x17701C0
	public void set_DetachedTasks(List<Task> value) { }

	// RVA: 0x17701D0 Offset: 0x17702D1 VA: 0x17701D0
	public List<SharedVariable> get_Variables() { }

	// RVA: 0x17701E0 Offset: 0x17702E1 VA: 0x17701E0
	public void set_Variables(List<SharedVariable> value) { }

	// RVA: 0x1770390 Offset: 0x1770491 VA: 0x1770390
	public bool get_HasSerialized() { }

	// RVA: 0x17703A0 Offset: 0x17704A1 VA: 0x17703A0
	public void set_HasSerialized(bool value) { }

	// RVA: 0x17703B0 Offset: 0x17704B1 VA: 0x17703B0
	public IBehavior get_Owner() { }

	// RVA: 0x17703C0 Offset: 0x17704C1 VA: 0x17703C0
	public void set_Owner(IBehavior value) { }

	// RVA: 0x17703D0 Offset: 0x17704D1 VA: 0x17703D0
	public void Initialize(IBehavior owner) { }

	// RVA: 0x175FF30 Offset: 0x1760031 VA: 0x175FF30
	public bool CheckForSerialization(bool force, BehaviorSource behaviorSource) { }

	// RVA: 0x175F820 Offset: 0x175F921 VA: 0x175F820 Slot: 4
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x175E8D0 Offset: 0x175E9D1 VA: 0x175E8D0 Slot: 7
	public List<SharedVariable> GetAllVariables() { }

	// RVA: 0x175E900 Offset: 0x175EA01 VA: 0x175E900 Slot: 5
	public void SetVariable(string name, SharedVariable sharedVariable) { }

	// RVA: 0x1771810 Offset: 0x1771911 VA: 0x1771810 Slot: 6
	public void SetAllVariables(List<SharedVariable> variables) { }

	// RVA: 0x1770210 Offset: 0x1770311 VA: 0x1770210
	private void UpdateVariablesIndex() { }

	// RVA: 0x1771840 Offset: 0x1771941 VA: 0x1771840 Slot: 3
	public override string ToString() { }
}

[Serializable]
public class BehaviorSource : IVariableSource // TypeDefIndex: 4666
{
	// Fields
	public string behaviorName; // 0x10
	public string behaviorDescription; // 0x18
	private int behaviorID; // 0x20
	private Task mEntryTask; // 0x28
	private Task mRootTask; // 0x30
	private List<Task> mDetachedTasks; // 0x38
	private List<SharedVariable> mVariables; // 0x40
	private Dictionary<string, int> mSharedVariableIndex; // 0x48
	private bool mHasSerialized; // 0x50
	[SerializeField] // RVA: 0x12D520 Offset: 0x12D621 VA: 0x12D520
	private TaskSerializationData mTaskData; // 0x58
	[SerializeField] // RVA: 0x12D530 Offset: 0x12D631 VA: 0x12D530
	private IBehavior mOwner; // 0x60

	// Properties
	public Task EntryTask { get; set; }
	public Task RootTask { get; set; }
	public List<Task> DetachedTasks { get; set; }
	public List<SharedVariable> Variables { get; set; }
	public bool HasSerialized { get; set; }
	public IBehavior Owner { get; set; }

	// Methods

	// RVA: 0x17700E0 Offset: 0x17701E1 VA: 0x17700E0
	public void .ctor() { }

	// RVA: 0x175E120 Offset: 0x175E221 VA: 0x175E120
	public void .ctor(IBehavior owner) { }

	// RVA: 0x1770170 Offset: 0x1770271 VA: 0x1770170
	public Task get_EntryTask() { }

	// RVA: 0x1770180 Offset: 0x1770281 VA: 0x1770180
	public void set_EntryTask(Task value) { }

	// RVA: 0x1770190 Offset: 0x1770291 VA: 0x1770190
	public Task get_RootTask() { }

	// RVA: 0x17701A0 Offset: 0x17702A1 VA: 0x17701A0
	public void set_RootTask(Task value) { }

	// RVA: 0x17701B0 Offset: 0x17702B1 VA: 0x17701B0
	public List<Task> get_DetachedTasks() { }

	// RVA: 0x17701C0 Offset: 0x17702C1 VA: 0x17701C0
	public void set_DetachedTasks(List<Task> value) { }

	// RVA: 0x17701D0 Offset: 0x17702D1 VA: 0x17701D0
	public List<SharedVariable> get_Variables() { }

	// RVA: 0x17701E0 Offset: 0x17702E1 VA: 0x17701E0
	public void set_Variables(List<SharedVariable> value) { }

	// RVA: 0x1770390 Offset: 0x1770491 VA: 0x1770390
	public bool get_HasSerialized() { }

	// RVA: 0x17703A0 Offset: 0x17704A1 VA: 0x17703A0
	public void set_HasSerialized(bool value) { }

	// RVA: 0x17703B0 Offset: 0x17704B1 VA: 0x17703B0
	public IBehavior get_Owner() { }

	// RVA: 0x17703C0 Offset: 0x17704C1 VA: 0x17703C0
	public void set_Owner(IBehavior value) { }

	// RVA: 0x17703D0 Offset: 0x17704D1 VA: 0x17703D0
	public void Initialize(IBehavior owner) { }

	// RVA: 0x175FF30 Offset: 0x1760031 VA: 0x175FF30
	public bool CheckForSerialization(bool force, BehaviorSource behaviorSource) { }

	// RVA: 0x175F820 Offset: 0x175F921 VA: 0x175F820 Slot: 4
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x175E8D0 Offset: 0x175E9D1 VA: 0x175E8D0 Slot: 7
	public List<SharedVariable> GetAllVariables() { }

	// RVA: 0x175E900 Offset: 0x175EA01 VA: 0x175E900 Slot: 5
	public void SetVariable(string name, SharedVariable sharedVariable) { }

	// RVA: 0x1771810 Offset: 0x1771911 VA: 0x1771810 Slot: 6
	public void SetAllVariables(List<SharedVariable> variables) { }

	// RVA: 0x1770210 Offset: 0x1770311 VA: 0x1770210
	private void UpdateVariablesIndex() { }

	// RVA: 0x1771840 Offset: 0x1771941 VA: 0x1771840 Slot: 3
	public override string ToString() { }
}

[Serializable]
public class BehaviorSource : IVariableSource // TypeDefIndex: 4666
{
	// Fields
	public string behaviorName; // 0x10
	public string behaviorDescription; // 0x18
	private int behaviorID; // 0x20
	private Task mEntryTask; // 0x28
	private Task mRootTask; // 0x30
	private List<Task> mDetachedTasks; // 0x38
	private List<SharedVariable> mVariables; // 0x40
	private Dictionary<string, int> mSharedVariableIndex; // 0x48
	private bool mHasSerialized; // 0x50
	[SerializeField] // RVA: 0x12D520 Offset: 0x12D621 VA: 0x12D520
	private TaskSerializationData mTaskData; // 0x58
	[SerializeField] // RVA: 0x12D530 Offset: 0x12D631 VA: 0x12D530
	private IBehavior mOwner; // 0x60

	// Properties
	public Task EntryTask { get; set; }
	public Task RootTask { get; set; }
	public List<Task> DetachedTasks { get; set; }
	public List<SharedVariable> Variables { get; set; }
	public bool HasSerialized { get; set; }
	public IBehavior Owner { get; set; }

	// Methods

	// RVA: 0x17700E0 Offset: 0x17701E1 VA: 0x17700E0
	public void .ctor() { }

	// RVA: 0x175E120 Offset: 0x175E221 VA: 0x175E120
	public void .ctor(IBehavior owner) { }

	// RVA: 0x1770170 Offset: 0x1770271 VA: 0x1770170
	public Task get_EntryTask() { }

	// RVA: 0x1770180 Offset: 0x1770281 VA: 0x1770180
	public void set_EntryTask(Task value) { }

	// RVA: 0x1770190 Offset: 0x1770291 VA: 0x1770190
	public Task get_RootTask() { }

	// RVA: 0x17701A0 Offset: 0x17702A1 VA: 0x17701A0
	public void set_RootTask(Task value) { }

	// RVA: 0x17701B0 Offset: 0x17702B1 VA: 0x17701B0
	public List<Task> get_DetachedTasks() { }

	// RVA: 0x17701C0 Offset: 0x17702C1 VA: 0x17701C0
	public void set_DetachedTasks(List<Task> value) { }

	// RVA: 0x17701D0 Offset: 0x17702D1 VA: 0x17701D0
	public List<SharedVariable> get_Variables() { }

	// RVA: 0x17701E0 Offset: 0x17702E1 VA: 0x17701E0
	public void set_Variables(List<SharedVariable> value) { }

	// RVA: 0x1770390 Offset: 0x1770491 VA: 0x1770390
	public bool get_HasSerialized() { }

	// RVA: 0x17703A0 Offset: 0x17704A1 VA: 0x17703A0
	public void set_HasSerialized(bool value) { }

	// RVA: 0x17703B0 Offset: 0x17704B1 VA: 0x17703B0
	public IBehavior get_Owner() { }

	// RVA: 0x17703C0 Offset: 0x17704C1 VA: 0x17703C0
	public void set_Owner(IBehavior value) { }

	// RVA: 0x17703D0 Offset: 0x17704D1 VA: 0x17703D0
	public void Initialize(IBehavior owner) { }

	// RVA: 0x175FF30 Offset: 0x1760031 VA: 0x175FF30
	public bool CheckForSerialization(bool force, BehaviorSource behaviorSource) { }

	// RVA: 0x175F820 Offset: 0x175F921 VA: 0x175F820 Slot: 4
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x175E8D0 Offset: 0x175E9D1 VA: 0x175E8D0 Slot: 7
	public List<SharedVariable> GetAllVariables() { }

	// RVA: 0x175E900 Offset: 0x175EA01 VA: 0x175E900 Slot: 5
	public void SetVariable(string name, SharedVariable sharedVariable) { }

	// RVA: 0x1771810 Offset: 0x1771911 VA: 0x1771810 Slot: 6
	public void SetAllVariables(List<SharedVariable> variables) { }

	// RVA: 0x1770210 Offset: 0x1770311 VA: 0x1770210
	private void UpdateVariablesIndex() { }

	// RVA: 0x1771840 Offset: 0x1771941 VA: 0x1771840 Slot: 3
	public override string ToString() { }
}

[Serializable]
public class BehaviorSource : IVariableSource // TypeDefIndex: 4666
{
	// Fields
	public string behaviorName; // 0x10
	public string behaviorDescription; // 0x18
	private int behaviorID; // 0x20
	private Task mEntryTask; // 0x28
	private Task mRootTask; // 0x30
	private List<Task> mDetachedTasks; // 0x38
	private List<SharedVariable> mVariables; // 0x40
	private Dictionary<string, int> mSharedVariableIndex; // 0x48
	private bool mHasSerialized; // 0x50
	[SerializeField] // RVA: 0x12D520 Offset: 0x12D621 VA: 0x12D520
	private TaskSerializationData mTaskData; // 0x58
	[SerializeField] // RVA: 0x12D530 Offset: 0x12D631 VA: 0x12D530
	private IBehavior mOwner; // 0x60

	// Properties
	public Task EntryTask { get; set; }
	public Task RootTask { get; set; }
	public List<Task> DetachedTasks { get; set; }
	public List<SharedVariable> Variables { get; set; }
	public bool HasSerialized { get; set; }
	public IBehavior Owner { get; set; }

	// Methods

	// RVA: 0x17700E0 Offset: 0x17701E1 VA: 0x17700E0
	public void .ctor() { }

	// RVA: 0x175E120 Offset: 0x175E221 VA: 0x175E120
	public void .ctor(IBehavior owner) { }

	// RVA: 0x1770170 Offset: 0x1770271 VA: 0x1770170
	public Task get_EntryTask() { }

	// RVA: 0x1770180 Offset: 0x1770281 VA: 0x1770180
	public void set_EntryTask(Task value) { }

	// RVA: 0x1770190 Offset: 0x1770291 VA: 0x1770190
	public Task get_RootTask() { }

	// RVA: 0x17701A0 Offset: 0x17702A1 VA: 0x17701A0
	public void set_RootTask(Task value) { }

	// RVA: 0x17701B0 Offset: 0x17702B1 VA: 0x17701B0
	public List<Task> get_DetachedTasks() { }

	// RVA: 0x17701C0 Offset: 0x17702C1 VA: 0x17701C0
	public void set_DetachedTasks(List<Task> value) { }

	// RVA: 0x17701D0 Offset: 0x17702D1 VA: 0x17701D0
	public List<SharedVariable> get_Variables() { }

	// RVA: 0x17701E0 Offset: 0x17702E1 VA: 0x17701E0
	public void set_Variables(List<SharedVariable> value) { }

	// RVA: 0x1770390 Offset: 0x1770491 VA: 0x1770390
	public bool get_HasSerialized() { }

	// RVA: 0x17703A0 Offset: 0x17704A1 VA: 0x17703A0
	public void set_HasSerialized(bool value) { }

	// RVA: 0x17703B0 Offset: 0x17704B1 VA: 0x17703B0
	public IBehavior get_Owner() { }

	// RVA: 0x17703C0 Offset: 0x17704C1 VA: 0x17703C0
	public void set_Owner(IBehavior value) { }

	// RVA: 0x17703D0 Offset: 0x17704D1 VA: 0x17703D0
	public void Initialize(IBehavior owner) { }

	// RVA: 0x175FF30 Offset: 0x1760031 VA: 0x175FF30
	public bool CheckForSerialization(bool force, BehaviorSource behaviorSource) { }

	// RVA: 0x175F820 Offset: 0x175F921 VA: 0x175F820 Slot: 4
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x175E8D0 Offset: 0x175E9D1 VA: 0x175E8D0 Slot: 7
	public List<SharedVariable> GetAllVariables() { }

	// RVA: 0x175E900 Offset: 0x175EA01 VA: 0x175E900 Slot: 5
	public void SetVariable(string name, SharedVariable sharedVariable) { }

	// RVA: 0x1771810 Offset: 0x1771911 VA: 0x1771810 Slot: 6
	public void SetAllVariables(List<SharedVariable> variables) { }

	// RVA: 0x1770210 Offset: 0x1770311 VA: 0x1770210
	private void UpdateVariablesIndex() { }

	// RVA: 0x1771840 Offset: 0x1771941 VA: 0x1771840 Slot: 3
	public override string ToString() { }
}

[Serializable]
public class BehaviorSource : IVariableSource // TypeDefIndex: 4666
{
	// Fields
	public string behaviorName; // 0x10
	public string behaviorDescription; // 0x18
	private int behaviorID; // 0x20
	private Task mEntryTask; // 0x28
	private Task mRootTask; // 0x30
	private List<Task> mDetachedTasks; // 0x38
	private List<SharedVariable> mVariables; // 0x40
	private Dictionary<string, int> mSharedVariableIndex; // 0x48
	private bool mHasSerialized; // 0x50
	[SerializeField] // RVA: 0x12D520 Offset: 0x12D621 VA: 0x12D520
	private TaskSerializationData mTaskData; // 0x58
	[SerializeField] // RVA: 0x12D530 Offset: 0x12D631 VA: 0x12D530
	private IBehavior mOwner; // 0x60

	// Properties
	public Task EntryTask { get; set; }
	public Task RootTask { get; set; }
	public List<Task> DetachedTasks { get; set; }
	public List<SharedVariable> Variables { get; set; }
	public bool HasSerialized { get; set; }
	public IBehavior Owner { get; set; }

	// Methods

	// RVA: 0x17700E0 Offset: 0x17701E1 VA: 0x17700E0
	public void .ctor() { }

	// RVA: 0x175E120 Offset: 0x175E221 VA: 0x175E120
	public void .ctor(IBehavior owner) { }

	// RVA: 0x1770170 Offset: 0x1770271 VA: 0x1770170
	public Task get_EntryTask() { }

	// RVA: 0x1770180 Offset: 0x1770281 VA: 0x1770180
	public void set_EntryTask(Task value) { }

	// RVA: 0x1770190 Offset: 0x1770291 VA: 0x1770190
	public Task get_RootTask() { }

	// RVA: 0x17701A0 Offset: 0x17702A1 VA: 0x17701A0
	public void set_RootTask(Task value) { }

	// RVA: 0x17701B0 Offset: 0x17702B1 VA: 0x17701B0
	public List<Task> get_DetachedTasks() { }

	// RVA: 0x17701C0 Offset: 0x17702C1 VA: 0x17701C0
	public void set_DetachedTasks(List<Task> value) { }

	// RVA: 0x17701D0 Offset: 0x17702D1 VA: 0x17701D0
	public List<SharedVariable> get_Variables() { }

	// RVA: 0x17701E0 Offset: 0x17702E1 VA: 0x17701E0
	public void set_Variables(List<SharedVariable> value) { }

	// RVA: 0x1770390 Offset: 0x1770491 VA: 0x1770390
	public bool get_HasSerialized() { }

	// RVA: 0x17703A0 Offset: 0x17704A1 VA: 0x17703A0
	public void set_HasSerialized(bool value) { }

	// RVA: 0x17703B0 Offset: 0x17704B1 VA: 0x17703B0
	public IBehavior get_Owner() { }

	// RVA: 0x17703C0 Offset: 0x17704C1 VA: 0x17703C0
	public void set_Owner(IBehavior value) { }

	// RVA: 0x17703D0 Offset: 0x17704D1 VA: 0x17703D0
	public void Initialize(IBehavior owner) { }

	// RVA: 0x175FF30 Offset: 0x1760031 VA: 0x175FF30
	public bool CheckForSerialization(bool force, BehaviorSource behaviorSource) { }

	// RVA: 0x175F820 Offset: 0x175F921 VA: 0x175F820 Slot: 4
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x175E8D0 Offset: 0x175E9D1 VA: 0x175E8D0 Slot: 7
	public List<SharedVariable> GetAllVariables() { }

	// RVA: 0x175E900 Offset: 0x175EA01 VA: 0x175E900 Slot: 5
	public void SetVariable(string name, SharedVariable sharedVariable) { }

	// RVA: 0x1771810 Offset: 0x1771911 VA: 0x1771810 Slot: 6
	public void SetAllVariables(List<SharedVariable> variables) { }

	// RVA: 0x1770210 Offset: 0x1770311 VA: 0x1770210
	private void UpdateVariablesIndex() { }

	// RVA: 0x1771840 Offset: 0x1771941 VA: 0x1771840 Slot: 3
	public override string ToString() { }
}

[Serializable]
public class BehaviorSource : IVariableSource // TypeDefIndex: 4666
{
	// Fields
	public string behaviorName; // 0x10
	public string behaviorDescription; // 0x18
	private int behaviorID; // 0x20
	private Task mEntryTask; // 0x28
	private Task mRootTask; // 0x30
	private List<Task> mDetachedTasks; // 0x38
	private List<SharedVariable> mVariables; // 0x40
	private Dictionary<string, int> mSharedVariableIndex; // 0x48
	private bool mHasSerialized; // 0x50
	[SerializeField] // RVA: 0x12D520 Offset: 0x12D621 VA: 0x12D520
	private TaskSerializationData mTaskData; // 0x58
	[SerializeField] // RVA: 0x12D530 Offset: 0x12D631 VA: 0x12D530
	private IBehavior mOwner; // 0x60

	// Properties
	public Task EntryTask { get; set; }
	public Task RootTask { get; set; }
	public List<Task> DetachedTasks { get; set; }
	public List<SharedVariable> Variables { get; set; }
	public bool HasSerialized { get; set; }
	public IBehavior Owner { get; set; }

	// Methods

	// RVA: 0x17700E0 Offset: 0x17701E1 VA: 0x17700E0
	public void .ctor() { }

	// RVA: 0x175E120 Offset: 0x175E221 VA: 0x175E120
	public void .ctor(IBehavior owner) { }

	// RVA: 0x1770170 Offset: 0x1770271 VA: 0x1770170
	public Task get_EntryTask() { }

	// RVA: 0x1770180 Offset: 0x1770281 VA: 0x1770180
	public void set_EntryTask(Task value) { }

	// RVA: 0x1770190 Offset: 0x1770291 VA: 0x1770190
	public Task get_RootTask() { }

	// RVA: 0x17701A0 Offset: 0x17702A1 VA: 0x17701A0
	public void set_RootTask(Task value) { }

	// RVA: 0x17701B0 Offset: 0x17702B1 VA: 0x17701B0
	public List<Task> get_DetachedTasks() { }

	// RVA: 0x17701C0 Offset: 0x17702C1 VA: 0x17701C0
	public void set_DetachedTasks(List<Task> value) { }

	// RVA: 0x17701D0 Offset: 0x17702D1 VA: 0x17701D0
	public List<SharedVariable> get_Variables() { }

	// RVA: 0x17701E0 Offset: 0x17702E1 VA: 0x17701E0
	public void set_Variables(List<SharedVariable> value) { }

	// RVA: 0x1770390 Offset: 0x1770491 VA: 0x1770390
	public bool get_HasSerialized() { }

	// RVA: 0x17703A0 Offset: 0x17704A1 VA: 0x17703A0
	public void set_HasSerialized(bool value) { }

	// RVA: 0x17703B0 Offset: 0x17704B1 VA: 0x17703B0
	public IBehavior get_Owner() { }

	// RVA: 0x17703C0 Offset: 0x17704C1 VA: 0x17703C0
	public void set_Owner(IBehavior value) { }

	// RVA: 0x17703D0 Offset: 0x17704D1 VA: 0x17703D0
	public void Initialize(IBehavior owner) { }

	// RVA: 0x175FF30 Offset: 0x1760031 VA: 0x175FF30
	public bool CheckForSerialization(bool force, BehaviorSource behaviorSource) { }

	// RVA: 0x175F820 Offset: 0x175F921 VA: 0x175F820 Slot: 4
	public SharedVariable GetVariable(string name) { }

	// RVA: 0x175E8D0 Offset: 0x175E9D1 VA: 0x175E8D0 Slot: 7
	public List<SharedVariable> GetAllVariables() { }

	// RVA: 0x175E900 Offset: 0x175EA01 VA: 0x175E900 Slot: 5
	public void SetVariable(string name, SharedVariable sharedVariable) { }

	// RVA: 0x1771810 Offset: 0x1771911 VA: 0x1771810 Slot: 6
	public void SetAllVariables(List<SharedVariable> variables) { }

	// RVA: 0x1770210 Offset: 0x1770311 VA: 0x1770210
	private void UpdateVariablesIndex() { }

	// RVA: 0x1771840 Offset: 0x1771941 VA: 0x1771840 Slot: 3
	public override string ToString() { }
}

