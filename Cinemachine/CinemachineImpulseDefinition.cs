[DocumentationSortingAttribute] // RVA: 0x12F100 Offset: 0x12F201 VA: 0x12F100
[Serializable]
public class CinemachineImpulseDefinition // TypeDefIndex: 4880
{
	// Fields
	[CinemachineImpulseChannelPropertyAttribute] // RVA: 0x135350 Offset: 0x135451 VA: 0x135350
	[TooltipAttribute] // RVA: 0x135350 Offset: 0x135451 VA: 0x135350
	public int m_ImpulseChannel; // 0x10
	[HeaderAttribute] // RVA: 0x1353A0 Offset: 0x1354A1 VA: 0x1353A0
	[TooltipAttribute] // RVA: 0x1353A0 Offset: 0x1354A1 VA: 0x1353A0
	[CinemachineEmbeddedAssetPropertyAttribute] // RVA: 0x1353A0 Offset: 0x1354A1 VA: 0x1353A0
	public SignalSourceAsset m_RawSignal; // 0x18
	[TooltipAttribute] // RVA: 0x135420 Offset: 0x135521 VA: 0x135420
	public float m_AmplitudeGain; // 0x20
	[TooltipAttribute] // RVA: 0x135460 Offset: 0x135561 VA: 0x135460
	public float m_FrequencyGain; // 0x24
	[TooltipAttribute] // RVA: 0x1354A0 Offset: 0x1355A1 VA: 0x1354A0
	public CinemachineImpulseDefinition.RepeatMode m_RepeatMode; // 0x28
	[TooltipAttribute] // RVA: 0x1354E0 Offset: 0x1355E1 VA: 0x1354E0
	public bool m_Randomize; // 0x2C
	[TooltipAttribute] // RVA: 0x135520 Offset: 0x135621 VA: 0x135520
	[CinemachineImpulseEnvelopePropertyAttribute] // RVA: 0x135520 Offset: 0x135621 VA: 0x135520
	public CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope; // 0x30
	[HeaderAttribute] // RVA: 0x135570 Offset: 0x135671 VA: 0x135570
	[TooltipAttribute] // RVA: 0x135570 Offset: 0x135671 VA: 0x135570
	public float m_ImpactRadius; // 0x50
	[TooltipAttribute] // RVA: 0x1355D0 Offset: 0x1356D1 VA: 0x1355D0
	public CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode; // 0x54
	[TooltipAttribute] // RVA: 0x135610 Offset: 0x135711 VA: 0x135610
	public CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode; // 0x58
	[TooltipAttribute] // RVA: 0x135650 Offset: 0x135751 VA: 0x135650
	public float m_DissipationDistance; // 0x5C
	[TooltipAttribute] // RVA: 0x135690 Offset: 0x135791 VA: 0x135690
	public float m_PropagationSpeed; // 0x60

	// Methods

	// RVA: 0x172B870 Offset: 0x172B971 VA: 0x172B870
	public void OnValidate() { }

	// RVA: 0x172B9E0 Offset: 0x172BAE1 VA: 0x172B9E0
	public void CreateEvent(Vector3 position, Vector3 velocity) { }

	// RVA: 0x172B9F0 Offset: 0x172BAF1 VA: 0x172B9F0
	public CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(Vector3 position, Vector3 velocity) { }

	// RVA: 0x172C0E0 Offset: 0x172C1E1 VA: 0x172C0E0
	public void .ctor() { }
}

