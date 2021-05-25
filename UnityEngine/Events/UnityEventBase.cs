[UsedByNativeCodeAttribute] // RVA: 0xC7860 Offset: 0xC7961 VA: 0xC7860
[Serializable]
public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 3105
{
	// Fields
	private InvokableCallList m_Calls; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xCB220 Offset: 0xCB321 VA: 0xCB220
	[SerializeField] // RVA: 0xCB220 Offset: 0xCB321 VA: 0xCB220
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x2B091F0 Offset: 0x2B092F1 VA: 0x2B091F0
	protected void .ctor() { }

	// RVA: 0x2B09A60 Offset: 0x2B09B61 VA: 0x2B09A60 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2B09A70 Offset: 0x2B09B71 VA: 0x2B09A70 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MethodInfo FindMethod_Impl(string name, object targetObj) { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x2B087C0 Offset: 0x2B088C1 VA: 0x2B087C0
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x2B09B70 Offset: 0x2B09C71 VA: 0x2B09B70
	internal MethodInfo FindMethod(string name, object listener, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x2B09AF0 Offset: 0x2B09BF1 VA: 0x2B09AF0
	private void DirtyPersistentCalls() { }

	// RVA: 0x2B09E10 Offset: 0x2B09F11 VA: 0x2B09E10
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x2B09480 Offset: 0x2B09581 VA: 0x2B09480
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x2B09550 Offset: 0x2B09651 VA: 0x2B09550
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x2B09E50 Offset: 0x2B09F51 VA: 0x2B09E50
	public void RemoveAllListeners() { }

	// RVA: 0x2B09A10 Offset: 0x2B09B11 VA: 0x2B09A10
	internal List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x2B09EC0 Offset: 0x2B09FC1 VA: 0x2B09EC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2B095E0 Offset: 0x2B096E1 VA: 0x2B095E0
	public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes) { }
}

