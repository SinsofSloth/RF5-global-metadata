public abstract class ParentTask : Task // TypeDefIndex: 4682
{
	// Fields
	[SerializeField] // RVA: 0x12D620 Offset: 0x12D721 VA: 0x12D620
	protected List<Task> children; // 0x50

	// Properties
	public List<Task> Children { get; }

	// Methods

	// RVA: 0x1B23DA0 Offset: 0x1B23EA1 VA: 0x1B23DA0
	protected void .ctor() { }

	// RVA: 0x1B23FD0 Offset: 0x1B240D1 VA: 0x1B23FD0
	public List<Task> get_Children() { }

	// RVA: 0x1B23FE0 Offset: 0x1B240E1 VA: 0x1B23FE0 Slot: 30
	public virtual int MaxChildren() { }

	// RVA: 0x1B23FF0 Offset: 0x1B240F1 VA: 0x1B23FF0 Slot: 31
	public virtual bool CanRunParallelChildren() { }

	// RVA: 0x1B24000 Offset: 0x1B24101 VA: 0x1B24000 Slot: 32
	public virtual int CurrentChildIndex() { }

	// RVA: 0x1B24010 Offset: 0x1B24111 VA: 0x1B24010 Slot: 33
	public virtual bool CanExecute() { }

	// RVA: 0x1B24020 Offset: 0x1B24121 VA: 0x1B24020 Slot: 34
	public virtual TaskStatus Decorate(TaskStatus status) { }

	// RVA: 0x1B24030 Offset: 0x1B24131 VA: 0x1B24030 Slot: 35
	public virtual bool CanReevaluate() { }

	// RVA: 0x1B24040 Offset: 0x1B24141 VA: 0x1B24040 Slot: 36
	public virtual void OnChildExecuted(TaskStatus childStatus) { }

	// RVA: 0x1B24050 Offset: 0x1B24151 VA: 0x1B24050 Slot: 37
	public virtual void OnChildExecuted(int childIndex, TaskStatus childStatus) { }

	// RVA: 0x1B24060 Offset: 0x1B24161 VA: 0x1B24060 Slot: 38
	public virtual void OnChildStarted() { }

	// RVA: 0x1B24070 Offset: 0x1B24171 VA: 0x1B24070 Slot: 39
	public virtual void OnChildStarted(int childIndex) { }

	// RVA: 0x1B24080 Offset: 0x1B24181 VA: 0x1B24080 Slot: 40
	public virtual TaskStatus OverrideStatus(TaskStatus status) { }

	// RVA: 0x1B24090 Offset: 0x1B24191 VA: 0x1B24090 Slot: 41
	public virtual TaskStatus OverrideStatus() { }

	// RVA: 0x1B240A0 Offset: 0x1B241A1 VA: 0x1B240A0 Slot: 42
	public virtual void OnConditionalAbort(int childIndex) { }

	// RVA: 0x1B240B0 Offset: 0x1B241B1 VA: 0x1B240B0 Slot: 13
	public override float GetUtility() { }

	// RVA: 0x1B241E0 Offset: 0x1B242E1 VA: 0x1B241E0 Slot: 17
	public override void OnDrawGizmos() { }

	// RVA: 0x1B242F0 Offset: 0x1B243F1 VA: 0x1B242F0
	public void AddChild(Task child, int index) { }

	// RVA: 0x1B243A0 Offset: 0x1B244A1 VA: 0x1B243A0
	public void ReplaceAddChild(Task child, int index) { }
}

public abstract class ParentTask : Task // TypeDefIndex: 4682
{
	// Fields
	[SerializeField] // RVA: 0x12D620 Offset: 0x12D721 VA: 0x12D620
	protected List<Task> children; // 0x50

	// Properties
	public List<Task> Children { get; }

	// Methods

	// RVA: 0x1B23DA0 Offset: 0x1B23EA1 VA: 0x1B23DA0
	protected void .ctor() { }

	// RVA: 0x1B23FD0 Offset: 0x1B240D1 VA: 0x1B23FD0
	public List<Task> get_Children() { }

	// RVA: 0x1B23FE0 Offset: 0x1B240E1 VA: 0x1B23FE0 Slot: 30
	public virtual int MaxChildren() { }

	// RVA: 0x1B23FF0 Offset: 0x1B240F1 VA: 0x1B23FF0 Slot: 31
	public virtual bool CanRunParallelChildren() { }

	// RVA: 0x1B24000 Offset: 0x1B24101 VA: 0x1B24000 Slot: 32
	public virtual int CurrentChildIndex() { }

	// RVA: 0x1B24010 Offset: 0x1B24111 VA: 0x1B24010 Slot: 33
	public virtual bool CanExecute() { }

	// RVA: 0x1B24020 Offset: 0x1B24121 VA: 0x1B24020 Slot: 34
	public virtual TaskStatus Decorate(TaskStatus status) { }

	// RVA: 0x1B24030 Offset: 0x1B24131 VA: 0x1B24030 Slot: 35
	public virtual bool CanReevaluate() { }

	// RVA: 0x1B24040 Offset: 0x1B24141 VA: 0x1B24040 Slot: 36
	public virtual void OnChildExecuted(TaskStatus childStatus) { }

	// RVA: 0x1B24050 Offset: 0x1B24151 VA: 0x1B24050 Slot: 37
	public virtual void OnChildExecuted(int childIndex, TaskStatus childStatus) { }

	// RVA: 0x1B24060 Offset: 0x1B24161 VA: 0x1B24060 Slot: 38
	public virtual void OnChildStarted() { }

	// RVA: 0x1B24070 Offset: 0x1B24171 VA: 0x1B24070 Slot: 39
	public virtual void OnChildStarted(int childIndex) { }

	// RVA: 0x1B24080 Offset: 0x1B24181 VA: 0x1B24080 Slot: 40
	public virtual TaskStatus OverrideStatus(TaskStatus status) { }

	// RVA: 0x1B24090 Offset: 0x1B24191 VA: 0x1B24090 Slot: 41
	public virtual TaskStatus OverrideStatus() { }

	// RVA: 0x1B240A0 Offset: 0x1B241A1 VA: 0x1B240A0 Slot: 42
	public virtual void OnConditionalAbort(int childIndex) { }

	// RVA: 0x1B240B0 Offset: 0x1B241B1 VA: 0x1B240B0 Slot: 13
	public override float GetUtility() { }

	// RVA: 0x1B241E0 Offset: 0x1B242E1 VA: 0x1B241E0 Slot: 17
	public override void OnDrawGizmos() { }

	// RVA: 0x1B242F0 Offset: 0x1B243F1 VA: 0x1B242F0
	public void AddChild(Task child, int index) { }

	// RVA: 0x1B243A0 Offset: 0x1B244A1 VA: 0x1B243A0
	public void ReplaceAddChild(Task child, int index) { }
}

public abstract class ParentTask : Task // TypeDefIndex: 4682
{
	// Fields
	[SerializeField] // RVA: 0x12D620 Offset: 0x12D721 VA: 0x12D620
	protected List<Task> children; // 0x50

	// Properties
	public List<Task> Children { get; }

	// Methods

	// RVA: 0x1B23DA0 Offset: 0x1B23EA1 VA: 0x1B23DA0
	protected void .ctor() { }

	// RVA: 0x1B23FD0 Offset: 0x1B240D1 VA: 0x1B23FD0
	public List<Task> get_Children() { }

	// RVA: 0x1B23FE0 Offset: 0x1B240E1 VA: 0x1B23FE0 Slot: 30
	public virtual int MaxChildren() { }

	// RVA: 0x1B23FF0 Offset: 0x1B240F1 VA: 0x1B23FF0 Slot: 31
	public virtual bool CanRunParallelChildren() { }

	// RVA: 0x1B24000 Offset: 0x1B24101 VA: 0x1B24000 Slot: 32
	public virtual int CurrentChildIndex() { }

	// RVA: 0x1B24010 Offset: 0x1B24111 VA: 0x1B24010 Slot: 33
	public virtual bool CanExecute() { }

	// RVA: 0x1B24020 Offset: 0x1B24121 VA: 0x1B24020 Slot: 34
	public virtual TaskStatus Decorate(TaskStatus status) { }

	// RVA: 0x1B24030 Offset: 0x1B24131 VA: 0x1B24030 Slot: 35
	public virtual bool CanReevaluate() { }

	// RVA: 0x1B24040 Offset: 0x1B24141 VA: 0x1B24040 Slot: 36
	public virtual void OnChildExecuted(TaskStatus childStatus) { }

	// RVA: 0x1B24050 Offset: 0x1B24151 VA: 0x1B24050 Slot: 37
	public virtual void OnChildExecuted(int childIndex, TaskStatus childStatus) { }

	// RVA: 0x1B24060 Offset: 0x1B24161 VA: 0x1B24060 Slot: 38
	public virtual void OnChildStarted() { }

	// RVA: 0x1B24070 Offset: 0x1B24171 VA: 0x1B24070 Slot: 39
	public virtual void OnChildStarted(int childIndex) { }

	// RVA: 0x1B24080 Offset: 0x1B24181 VA: 0x1B24080 Slot: 40
	public virtual TaskStatus OverrideStatus(TaskStatus status) { }

	// RVA: 0x1B24090 Offset: 0x1B24191 VA: 0x1B24090 Slot: 41
	public virtual TaskStatus OverrideStatus() { }

	// RVA: 0x1B240A0 Offset: 0x1B241A1 VA: 0x1B240A0 Slot: 42
	public virtual void OnConditionalAbort(int childIndex) { }

	// RVA: 0x1B240B0 Offset: 0x1B241B1 VA: 0x1B240B0 Slot: 13
	public override float GetUtility() { }

	// RVA: 0x1B241E0 Offset: 0x1B242E1 VA: 0x1B241E0 Slot: 17
	public override void OnDrawGizmos() { }

	// RVA: 0x1B242F0 Offset: 0x1B243F1 VA: 0x1B242F0
	public void AddChild(Task child, int index) { }

	// RVA: 0x1B243A0 Offset: 0x1B244A1 VA: 0x1B243A0
	public void ReplaceAddChild(Task child, int index) { }
}

public abstract class ParentTask : Task // TypeDefIndex: 4682
{
	// Fields
	[SerializeField] // RVA: 0x12D620 Offset: 0x12D721 VA: 0x12D620
	protected List<Task> children; // 0x50

	// Properties
	public List<Task> Children { get; }

	// Methods

	// RVA: 0x1B23DA0 Offset: 0x1B23EA1 VA: 0x1B23DA0
	protected void .ctor() { }

	// RVA: 0x1B23FD0 Offset: 0x1B240D1 VA: 0x1B23FD0
	public List<Task> get_Children() { }

	// RVA: 0x1B23FE0 Offset: 0x1B240E1 VA: 0x1B23FE0 Slot: 30
	public virtual int MaxChildren() { }

	// RVA: 0x1B23FF0 Offset: 0x1B240F1 VA: 0x1B23FF0 Slot: 31
	public virtual bool CanRunParallelChildren() { }

	// RVA: 0x1B24000 Offset: 0x1B24101 VA: 0x1B24000 Slot: 32
	public virtual int CurrentChildIndex() { }

	// RVA: 0x1B24010 Offset: 0x1B24111 VA: 0x1B24010 Slot: 33
	public virtual bool CanExecute() { }

	// RVA: 0x1B24020 Offset: 0x1B24121 VA: 0x1B24020 Slot: 34
	public virtual TaskStatus Decorate(TaskStatus status) { }

	// RVA: 0x1B24030 Offset: 0x1B24131 VA: 0x1B24030 Slot: 35
	public virtual bool CanReevaluate() { }

	// RVA: 0x1B24040 Offset: 0x1B24141 VA: 0x1B24040 Slot: 36
	public virtual void OnChildExecuted(TaskStatus childStatus) { }

	// RVA: 0x1B24050 Offset: 0x1B24151 VA: 0x1B24050 Slot: 37
	public virtual void OnChildExecuted(int childIndex, TaskStatus childStatus) { }

	// RVA: 0x1B24060 Offset: 0x1B24161 VA: 0x1B24060 Slot: 38
	public virtual void OnChildStarted() { }

	// RVA: 0x1B24070 Offset: 0x1B24171 VA: 0x1B24070 Slot: 39
	public virtual void OnChildStarted(int childIndex) { }

	// RVA: 0x1B24080 Offset: 0x1B24181 VA: 0x1B24080 Slot: 40
	public virtual TaskStatus OverrideStatus(TaskStatus status) { }

	// RVA: 0x1B24090 Offset: 0x1B24191 VA: 0x1B24090 Slot: 41
	public virtual TaskStatus OverrideStatus() { }

	// RVA: 0x1B240A0 Offset: 0x1B241A1 VA: 0x1B240A0 Slot: 42
	public virtual void OnConditionalAbort(int childIndex) { }

	// RVA: 0x1B240B0 Offset: 0x1B241B1 VA: 0x1B240B0 Slot: 13
	public override float GetUtility() { }

	// RVA: 0x1B241E0 Offset: 0x1B242E1 VA: 0x1B241E0 Slot: 17
	public override void OnDrawGizmos() { }

	// RVA: 0x1B242F0 Offset: 0x1B243F1 VA: 0x1B242F0
	public void AddChild(Task child, int index) { }

	// RVA: 0x1B243A0 Offset: 0x1B244A1 VA: 0x1B243A0
	public void ReplaceAddChild(Task child, int index) { }
}

public abstract class ParentTask : Task // TypeDefIndex: 4682
{
	// Fields
	[SerializeField] // RVA: 0x12D620 Offset: 0x12D721 VA: 0x12D620
	protected List<Task> children; // 0x50

	// Properties
	public List<Task> Children { get; }

	// Methods

	// RVA: 0x1B23DA0 Offset: 0x1B23EA1 VA: 0x1B23DA0
	protected void .ctor() { }

	// RVA: 0x1B23FD0 Offset: 0x1B240D1 VA: 0x1B23FD0
	public List<Task> get_Children() { }

	// RVA: 0x1B23FE0 Offset: 0x1B240E1 VA: 0x1B23FE0 Slot: 30
	public virtual int MaxChildren() { }

	// RVA: 0x1B23FF0 Offset: 0x1B240F1 VA: 0x1B23FF0 Slot: 31
	public virtual bool CanRunParallelChildren() { }

	// RVA: 0x1B24000 Offset: 0x1B24101 VA: 0x1B24000 Slot: 32
	public virtual int CurrentChildIndex() { }

	// RVA: 0x1B24010 Offset: 0x1B24111 VA: 0x1B24010 Slot: 33
	public virtual bool CanExecute() { }

	// RVA: 0x1B24020 Offset: 0x1B24121 VA: 0x1B24020 Slot: 34
	public virtual TaskStatus Decorate(TaskStatus status) { }

	// RVA: 0x1B24030 Offset: 0x1B24131 VA: 0x1B24030 Slot: 35
	public virtual bool CanReevaluate() { }

	// RVA: 0x1B24040 Offset: 0x1B24141 VA: 0x1B24040 Slot: 36
	public virtual void OnChildExecuted(TaskStatus childStatus) { }

	// RVA: 0x1B24050 Offset: 0x1B24151 VA: 0x1B24050 Slot: 37
	public virtual void OnChildExecuted(int childIndex, TaskStatus childStatus) { }

	// RVA: 0x1B24060 Offset: 0x1B24161 VA: 0x1B24060 Slot: 38
	public virtual void OnChildStarted() { }

	// RVA: 0x1B24070 Offset: 0x1B24171 VA: 0x1B24070 Slot: 39
	public virtual void OnChildStarted(int childIndex) { }

	// RVA: 0x1B24080 Offset: 0x1B24181 VA: 0x1B24080 Slot: 40
	public virtual TaskStatus OverrideStatus(TaskStatus status) { }

	// RVA: 0x1B24090 Offset: 0x1B24191 VA: 0x1B24090 Slot: 41
	public virtual TaskStatus OverrideStatus() { }

	// RVA: 0x1B240A0 Offset: 0x1B241A1 VA: 0x1B240A0 Slot: 42
	public virtual void OnConditionalAbort(int childIndex) { }

	// RVA: 0x1B240B0 Offset: 0x1B241B1 VA: 0x1B240B0 Slot: 13
	public override float GetUtility() { }

	// RVA: 0x1B241E0 Offset: 0x1B242E1 VA: 0x1B241E0 Slot: 17
	public override void OnDrawGizmos() { }

	// RVA: 0x1B242F0 Offset: 0x1B243F1 VA: 0x1B242F0
	public void AddChild(Task child, int index) { }

	// RVA: 0x1B243A0 Offset: 0x1B244A1 VA: 0x1B243A0
	public void ReplaceAddChild(Task child, int index) { }
}

public abstract class ParentTask : Task // TypeDefIndex: 4682
{
	// Fields
	[SerializeField] // RVA: 0x12D620 Offset: 0x12D721 VA: 0x12D620
	protected List<Task> children; // 0x50

	// Properties
	public List<Task> Children { get; }

	// Methods

	// RVA: 0x1B23DA0 Offset: 0x1B23EA1 VA: 0x1B23DA0
	protected void .ctor() { }

	// RVA: 0x1B23FD0 Offset: 0x1B240D1 VA: 0x1B23FD0
	public List<Task> get_Children() { }

	// RVA: 0x1B23FE0 Offset: 0x1B240E1 VA: 0x1B23FE0 Slot: 30
	public virtual int MaxChildren() { }

	// RVA: 0x1B23FF0 Offset: 0x1B240F1 VA: 0x1B23FF0 Slot: 31
	public virtual bool CanRunParallelChildren() { }

	// RVA: 0x1B24000 Offset: 0x1B24101 VA: 0x1B24000 Slot: 32
	public virtual int CurrentChildIndex() { }

	// RVA: 0x1B24010 Offset: 0x1B24111 VA: 0x1B24010 Slot: 33
	public virtual bool CanExecute() { }

	// RVA: 0x1B24020 Offset: 0x1B24121 VA: 0x1B24020 Slot: 34
	public virtual TaskStatus Decorate(TaskStatus status) { }

	// RVA: 0x1B24030 Offset: 0x1B24131 VA: 0x1B24030 Slot: 35
	public virtual bool CanReevaluate() { }

	// RVA: 0x1B24040 Offset: 0x1B24141 VA: 0x1B24040 Slot: 36
	public virtual void OnChildExecuted(TaskStatus childStatus) { }

	// RVA: 0x1B24050 Offset: 0x1B24151 VA: 0x1B24050 Slot: 37
	public virtual void OnChildExecuted(int childIndex, TaskStatus childStatus) { }

	// RVA: 0x1B24060 Offset: 0x1B24161 VA: 0x1B24060 Slot: 38
	public virtual void OnChildStarted() { }

	// RVA: 0x1B24070 Offset: 0x1B24171 VA: 0x1B24070 Slot: 39
	public virtual void OnChildStarted(int childIndex) { }

	// RVA: 0x1B24080 Offset: 0x1B24181 VA: 0x1B24080 Slot: 40
	public virtual TaskStatus OverrideStatus(TaskStatus status) { }

	// RVA: 0x1B24090 Offset: 0x1B24191 VA: 0x1B24090 Slot: 41
	public virtual TaskStatus OverrideStatus() { }

	// RVA: 0x1B240A0 Offset: 0x1B241A1 VA: 0x1B240A0 Slot: 42
	public virtual void OnConditionalAbort(int childIndex) { }

	// RVA: 0x1B240B0 Offset: 0x1B241B1 VA: 0x1B240B0 Slot: 13
	public override float GetUtility() { }

	// RVA: 0x1B241E0 Offset: 0x1B242E1 VA: 0x1B241E0 Slot: 17
	public override void OnDrawGizmos() { }

	// RVA: 0x1B242F0 Offset: 0x1B243F1 VA: 0x1B242F0
	public void AddChild(Task child, int index) { }

	// RVA: 0x1B243A0 Offset: 0x1B244A1 VA: 0x1B243A0
	public void ReplaceAddChild(Task child, int index) { }
}

