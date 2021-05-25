public class TaskCoroutine // TypeDefIndex: 4697
{
	// Fields
	private IEnumerator mCoroutineEnumerator; // 0x10
	private Coroutine mCoroutine; // 0x18
	private Behavior mParent; // 0x20
	private string mCoroutineName; // 0x28
	private bool mStop; // 0x30

	// Properties
	public Coroutine Coroutine { get; }

	// Methods

	// RVA: 0x1B22600 Offset: 0x1B22701 VA: 0x1B22600
	public void .ctor(Behavior parent, IEnumerator coroutine, string coroutineName) { }

	// RVA: 0x1B22760 Offset: 0x1B22861 VA: 0x1B22760
	public Coroutine get_Coroutine() { }

	// RVA: 0x1B22770 Offset: 0x1B22871 VA: 0x1B22770
	public void Stop() { }

	[DebuggerHiddenAttribute] // RVA: 0x12DA90 Offset: 0x12DB91 VA: 0x12DA90
	// RVA: 0x1B226E0 Offset: 0x1B227E1 VA: 0x1B226E0
	public IEnumerator RunCoroutine() { }
}

