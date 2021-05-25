[Serializable]
public class UnityEvent : UnityEventBase // TypeDefIndex: 3107
{
	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xD93C0 Offset: 0xD94C1 VA: 0xD93C0
	// RVA: 0x2B091C0 Offset: 0x2B092C1 VA: 0x2B091C0
	public void .ctor() { }

	// RVA: 0x2B09300 Offset: 0x2B09401 VA: 0x2B09300
	public void AddListener(UnityAction call) { }

	// RVA: 0x2B09500 Offset: 0x2B09601 VA: 0x2B09500
	public void RemoveListener(UnityAction call) { }

	// RVA: 0x2B09570 Offset: 0x2B09671 VA: 0x2B09570 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }

	// RVA: 0x2B097C0 Offset: 0x2B098C1 VA: 0x2B097C0 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x2B09390 Offset: 0x2B09491 VA: 0x2B09390
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x2B09830 Offset: 0x2B09931 VA: 0x2B09830
	public void Invoke() { }
}

