[Serializable]
public struct CinemachineTriggerAction.ActionSettings // TypeDefIndex: 4872
{
	// Fields
	[TooltipAttribute] // RVA: 0x136480 Offset: 0x136581 VA: 0x136480
	public CinemachineTriggerAction.ActionSettings.Mode m_Action; // 0x0
	[TooltipAttribute] // RVA: 0x1364C0 Offset: 0x1365C1 VA: 0x1364C0
	public Object m_Target; // 0x8
	[TooltipAttribute] // RVA: 0x136500 Offset: 0x136601 VA: 0x136500
	public int m_BoostAmount; // 0x10
	[TooltipAttribute] // RVA: 0x136540 Offset: 0x136641 VA: 0x136540
	public float m_StartTime; // 0x14
	[TooltipAttribute] // RVA: 0x136580 Offset: 0x136681 VA: 0x136580
	public CinemachineTriggerAction.ActionSettings.TimeMode m_Mode; // 0x18
	[TooltipAttribute] // RVA: 0x1365C0 Offset: 0x1366C1 VA: 0x1365C0
	public CinemachineTriggerAction.ActionSettings.TriggerEvent m_Event; // 0x20

	// Methods

	// RVA: 0x178A0 Offset: 0x179A1 VA: 0x178A0
	public void .ctor(CinemachineTriggerAction.ActionSettings.Mode action) { }

	// RVA: 0x17930 Offset: 0x17A31 VA: 0x17930
	public void Invoke() { }
}

