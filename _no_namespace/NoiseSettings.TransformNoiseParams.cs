[DocumentationSortingAttribute] // RVA: 0x12F5F0 Offset: 0x12F6F1 VA: 0x12F5F0
[Serializable]
public struct NoiseSettings.TransformNoiseParams // TypeDefIndex: 4856
{
	// Fields
	[TooltipAttribute] // RVA: 0x1363B0 Offset: 0x1364B1 VA: 0x1363B0
	public NoiseSettings.NoiseParams X; // 0x0
	[TooltipAttribute] // RVA: 0x1363F0 Offset: 0x1364F1 VA: 0x1363F0
	public NoiseSettings.NoiseParams Y; // 0xC
	[TooltipAttribute] // RVA: 0x136430 Offset: 0x136531 VA: 0x136430
	public NoiseSettings.NoiseParams Z; // 0x18

	// Methods

	// RVA: 0x17CE0 Offset: 0x17DE1 VA: 0x17CE0
	public Vector3 GetValueAt(float time, Vector3 timeOffsets) { }
}

