public class BehaviorManager.BehaviorTree // TypeDefIndex: 4655
{
	// Fields
	public List<Task> taskList; // 0x10
	public List<int> parentIndex; // 0x18
	public List<List<int>> childrenIndex; // 0x20
	public List<int> relativeChildIndex; // 0x28
	public List<Stack<int>> activeStack; // 0x30
	public List<TaskStatus> nonInstantTaskStatus; // 0x38
	public List<int> interruptionIndex; // 0x40
	public List<TaskStatus> interruptionTaskStatus; // 0x48
	public List<BehaviorManager.BehaviorTree.ConditionalReevaluate> conditionalReevaluate; // 0x50
	public Dictionary<int, BehaviorManager.BehaviorTree.ConditionalReevaluate> conditionalReevaluateMap; // 0x58
	public List<int> parentReevaluate; // 0x60
	public List<int> parentCompositeIndex; // 0x68
	public List<List<int>> childConditionalIndex; // 0x70
	public int executionCount; // 0x78
	public Behavior behavior; // 0x80
	public bool destroyBehavior; // 0x88
	public string errorState; // 0x90

	// Methods

	// RVA: 0x175DC70 Offset: 0x175DD71 VA: 0x175DC70
	public void .ctor() { }

	// RVA: 0x1766DF0 Offset: 0x1766EF1 VA: 0x1766DF0
	public void Initialize(Behavior b) { }
}

