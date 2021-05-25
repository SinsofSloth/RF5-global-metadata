internal class DelayedActionManager : ComponentSingleton<DelayedActionManager> // TypeDefIndex: 4463
{
	// Fields
	private List<DelayedActionManager.DelegateInfo>[] m_Actions; // 0x18
	private LinkedList<DelayedActionManager.DelegateInfo> m_DelayedActions; // 0x20
	private Stack<LinkedListNode<DelayedActionManager.DelegateInfo>> m_NodeCache; // 0x28
	private int m_CollectionIndex; // 0x30
	private bool m_DestroyOnCompletion; // 0x34

	// Properties
	public static bool IsActive { get; }

	// Methods

	// RVA: 0x19E3C10 Offset: 0x19E3D11 VA: 0x19E3C10
	private LinkedListNode<DelayedActionManager.DelegateInfo> GetNode(ref DelayedActionManager.DelegateInfo del) { }

	// RVA: 0x19E3D10 Offset: 0x19E3E11 VA: 0x19E3D10
	public static void Clear() { }

	// RVA: 0x19E3D80 Offset: 0x19E3E81 VA: 0x19E3D80
	private void DestroyWhenComplete() { }

	// RVA: 0x19E3D90 Offset: 0x19E3E91 VA: 0x19E3D90
	public static void AddAction(Delegate action, float delay = 0, object[] parameters) { }

	// RVA: 0x19E3E10 Offset: 0x19E3F11 VA: 0x19E3E10
	private void AddActionInternal(Delegate action, float delay, object[] parameters) { }

	// RVA: 0x19E40F0 Offset: 0x19E41F1 VA: 0x19E40F0
	public static bool get_IsActive() { }

	// RVA: 0x19E4210 Offset: 0x19E4311 VA: 0x19E4210
	public static bool Wait(float timeout = 0, float timeAdvanceAmount = 0) { }

	// RVA: 0x19E4670 Offset: 0x19E4771 VA: 0x19E4670
	private void LateUpdate() { }

	// RVA: 0x19E43E0 Offset: 0x19E44E1 VA: 0x19E43E0
	private void InternalLateUpdate(float t) { }

	// RVA: 0x19E4880 Offset: 0x19E4981 VA: 0x19E4880
	private void OnApplicationQuit() { }

	// RVA: 0x19E4930 Offset: 0x19E4A31 VA: 0x19E4930
	public void .ctor() { }
}

