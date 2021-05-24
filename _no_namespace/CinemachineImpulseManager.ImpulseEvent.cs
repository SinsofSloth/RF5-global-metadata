public class CinemachineImpulseManager.ImpulseEvent // TypeDefIndex: 4888
{
	// Fields
	[TooltipAttribute] // RVA: 0x1367C0 Offset: 0x1368C1 VA: 0x1367C0
	public float m_StartTime; // 0x10
	[TooltipAttribute] // RVA: 0x136800 Offset: 0x136901 VA: 0x136800
	public CinemachineImpulseManager.EnvelopeDefinition m_Envelope; // 0x18
	[TooltipAttribute] // RVA: 0x136840 Offset: 0x136941 VA: 0x136840
	public ISignalSource6D m_SignalSource; // 0x38
	[TooltipAttribute] // RVA: 0x136880 Offset: 0x136981 VA: 0x136880
	public Vector3 m_Position; // 0x40
	[TooltipAttribute] // RVA: 0x1368C0 Offset: 0x1369C1 VA: 0x1368C0
	public float m_Radius; // 0x4C
	[TooltipAttribute] // RVA: 0x136900 Offset: 0x136A01 VA: 0x136900
	public CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode; // 0x50
	[TooltipAttribute] // RVA: 0x136940 Offset: 0x136A41 VA: 0x136940
	public int m_Channel; // 0x54
	[TooltipAttribute] // RVA: 0x136980 Offset: 0x136A81 VA: 0x136980
	public CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode; // 0x58
	[TooltipAttribute] // RVA: 0x1369C0 Offset: 0x136AC1 VA: 0x1369C0
	public float m_DissipationDistance; // 0x5C
	[TooltipAttribute] // RVA: 0x136A00 Offset: 0x136B01 VA: 0x136A00
	public float m_PropagationSpeed; // 0x60

	// Properties
	public bool Expired { get; }

	// Methods

	// RVA: 0x172CA40 Offset: 0x172CB41 VA: 0x172CA40
	public bool get_Expired() { }

	// RVA: 0x172D590 Offset: 0x172D691 VA: 0x172D590
	public void Cancel(float time, bool forceNoDecay) { }

	// RVA: 0x172D5E0 Offset: 0x172D6E1 VA: 0x172D5E0
	public float DistanceDecay(float distance) { }

	// RVA: 0x172CC90 Offset: 0x172CD91 VA: 0x172CC90
	public bool GetDecayedSignal(Vector3 listenerPosition, bool use2D, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0x172CBC0 Offset: 0x172CCC1 VA: 0x172CBC0
	public void Clear() { }

	// RVA: 0x172D2D0 Offset: 0x172D3D1 VA: 0x172D2D0
	internal void .ctor() { }
}

