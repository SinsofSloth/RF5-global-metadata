private class BehaviorManager.BehaviorThreadLoader // TypeDefIndex: 4662
{
	// Fields
	private Behavior behavior; // 0x10
	private GameObject gameObject; // 0x18
	private string gameObjectName; // 0x20
	private Transform transform; // 0x28
	private Func<Behavior, GameObject, string, Transform, BehaviorManager.BehaviorTree> loadBehaviorAction; // 0x30
	private Thread thread; // 0x38
	private BehaviorManager.BehaviorTree behaviorTree; // 0x40

	// Properties
	public Behavior Behavior { get; }
	public Thread Thread { get; set; }
	public BehaviorManager.BehaviorTree BehaviorTree { get; }

	// Methods

	// RVA: 0x1765FB0 Offset: 0x17660B1 VA: 0x1765FB0
	public void .ctor(Behavior behaviorTree, Func<Behavior, GameObject, string, Transform, BehaviorManager.BehaviorTree> action) { }

	// RVA: 0x176FF70 Offset: 0x1770071 VA: 0x176FF70
	public Behavior get_Behavior() { }

	// RVA: 0x176FF80 Offset: 0x1770081 VA: 0x176FF80
	public Thread get_Thread() { }

	// RVA: 0x176FF90 Offset: 0x1770091 VA: 0x176FF90
	public void set_Thread(Thread value) { }

	// RVA: 0x176FFA0 Offset: 0x17700A1 VA: 0x176FFA0
	public BehaviorManager.BehaviorTree get_BehaviorTree() { }

	// RVA: 0x176FFB0 Offset: 0x17700B1 VA: 0x176FFB0
	public void LoadBehavior() { }
}

