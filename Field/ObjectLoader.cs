public class ObjectLoader : MonoBehaviour // TypeDefIndex: 10462
{
	// Fields
	protected ObjectLoadParam loadParam; // 0x18
	private int loaderId; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x181A30 Offset: 0x181B31 VA: 0x181A30
	private int <LoadingCount>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x181A40 Offset: 0x181B41 VA: 0x181A40
	private bool <IsUpdate>k__BackingField; // 0x28

	// Properties
	public int LoadingCount { get; set; }
	public bool IsUpdate { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AF510 Offset: 0x1AF611 VA: 0x1AF510
	// RVA: 0x1EEDCB0 Offset: 0x1EEDDB1 VA: 0x1EEDCB0
	public int get_LoadingCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF520 Offset: 0x1AF621 VA: 0x1AF520
	// RVA: 0x1EEDCC0 Offset: 0x1EEDDC1 VA: 0x1EEDCC0
	protected void set_LoadingCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF530 Offset: 0x1AF631 VA: 0x1AF530
	// RVA: 0x1EEDCD0 Offset: 0x1EEDDD1 VA: 0x1EEDCD0
	public bool get_IsUpdate() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF540 Offset: 0x1AF641 VA: 0x1AF540
	// RVA: 0x1EEDCE0 Offset: 0x1EEDDE1 VA: 0x1EEDCE0
	protected void set_IsUpdate(bool value) { }

	// RVA: 0x1EEDC10 Offset: 0x1EEDD11 VA: 0x1EEDC10
	public bool NeedsLoad() { }

	// RVA: 0x1EED5F0 Offset: 0x1EED6F1 VA: 0x1EED5F0
	public bool IsCompleted() { }

	// RVA: 0x1EEDCF0 Offset: 0x1EEDDF1 VA: 0x1EEDCF0
	private void OnDestroy() { }

	// RVA: 0x1EEDE10 Offset: 0x1EEDF11 VA: 0x1EEDE10
	private void Awake() { }

	// RVA: 0x1EEDEB0 Offset: 0x1EEDFB1 VA: 0x1EEDEB0
	private void OnEnable() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF550 Offset: 0x1AF651 VA: 0x1AF550
	// RVA: -1 Offset: -1
	public IEnumerator LoadObjectAsync<T>(int id, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AB060 Offset: 0x21AB161 VA: 0x21AB060
	|-ObjectLoader.LoadObjectAsync<object>
	|-ObjectLoader.LoadObjectAsync<GameObject>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x1AF5C0 Offset: 0x1AF6C1 VA: 0x1AF5C0
	// RVA: 0x1EEDEC0 Offset: 0x1EEDFC1 VA: 0x1EEDEC0 Slot: 4
	public virtual IEnumerator Load() { }

	// RVA: 0x1EEDF70 Offset: 0x1EEE071 VA: 0x1EEDF70
	public void .ctor() { }
}

