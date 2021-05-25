[Serializable]
public struct CinemachineImpulseManager.EnvelopeDefinition // TypeDefIndex: 4887
{
	// Fields
	[TooltipAttribute] // RVA: 0x136600 Offset: 0x136701 VA: 0x136600
	public AnimationCurve m_AttackShape; // 0x0
	[TooltipAttribute] // RVA: 0x136640 Offset: 0x136741 VA: 0x136640
	public AnimationCurve m_DecayShape; // 0x8
	[TooltipAttribute] // RVA: 0x136680 Offset: 0x136781 VA: 0x136680
	public float m_AttackTime; // 0x10
	[TooltipAttribute] // RVA: 0x1366C0 Offset: 0x1367C1 VA: 0x1366C0
	public float m_SustainTime; // 0x14
	[TooltipAttribute] // RVA: 0x136700 Offset: 0x136801 VA: 0x136700
	public float m_DecayTime; // 0x18
	[TooltipAttribute] // RVA: 0x136740 Offset: 0x136841 VA: 0x136740
	public bool m_ScaleWithImpact; // 0x1C
	[TooltipAttribute] // RVA: 0x136780 Offset: 0x136881 VA: 0x136780
	public bool m_HoldForever; // 0x1D

	// Properties
	public float Duration { get; }

	// Methods

	// RVA: 0x172C170 Offset: 0x172C271 VA: 0x172C170
	public static CinemachineImpulseManager.EnvelopeDefinition Default() { }

	// RVA: 0x8C40 Offset: 0x8D41 VA: 0x8C40
	public float get_Duration() { }

	// RVA: 0x8C70 Offset: 0x8D71 VA: 0x8C70
	public float GetValueAt(float offset) { }

	// RVA: 0x8C80 Offset: 0x8D81 VA: 0x8C80
	public void ChangeStopTime(float offset, bool forceNoDecay) { }

	// RVA: 0x8CC0 Offset: 0x8DC1 VA: 0x8CC0
	public void Clear() { }

	// RVA: 0x8D00 Offset: 0x8E01 VA: 0x8D00
	public void Validate() { }
}

