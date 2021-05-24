internal class InvokableCallList // TypeDefIndex: 3104
{
	// Fields
	private readonly List<BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; // 0x18
	private readonly List<BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28

	// Methods

	// RVA: 0x2B07F60 Offset: 0x2B08061 VA: 0x2B07F60
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x2B07FE0 Offset: 0x2B080E1 VA: 0x2B07FE0
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x2B08060 Offset: 0x2B08161 VA: 0x2B08060
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x2B08250 Offset: 0x2B08351 VA: 0x2B08250
	public void Clear() { }

	// RVA: 0x2B082C0 Offset: 0x2B083C1 VA: 0x2B082C0
	public void ClearPersistent() { }

	// RVA: 0x2B08330 Offset: 0x2B08431 VA: 0x2B08330
	public List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x2B083D0 Offset: 0x2B084D1 VA: 0x2B083D0
	public void .ctor() { }
}

