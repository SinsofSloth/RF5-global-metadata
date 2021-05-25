[DocumentationSortingAttribute] // RVA: 0x12F4C0 Offset: 0x12F5C1 VA: 0x12F4C0
[Serializable]
public struct CinemachineOrbitalTransposer.Heading // TypeDefIndex: 4795
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x135C80 Offset: 0x135D81 VA: 0x135C80
	[TooltipAttribute] // RVA: 0x135C80 Offset: 0x135D81 VA: 0x135C80
	public CinemachineOrbitalTransposer.Heading.HeadingDefinition m_Definition; // 0x0
	[RangeAttribute] // RVA: 0x135CE0 Offset: 0x135DE1 VA: 0x135CE0
	[TooltipAttribute] // RVA: 0x135CE0 Offset: 0x135DE1 VA: 0x135CE0
	public int m_VelocityFilterStrength; // 0x4
	[RangeAttribute] // RVA: 0x135D40 Offset: 0x135E41 VA: 0x135D40
	[FormerlySerializedAsAttribute] // RVA: 0x135D40 Offset: 0x135E41 VA: 0x135D40
	[TooltipAttribute] // RVA: 0x135D40 Offset: 0x135E41 VA: 0x135D40
	public float m_Bias; // 0x8

	// Methods

	// RVA: 0x8FE0 Offset: 0x90E1 VA: 0x8FE0
	public void .ctor(CinemachineOrbitalTransposer.Heading.HeadingDefinition def, int filterStrength, float bias) { }
}

