[DocumentationSortingAttribute] // RVA: 0x12F5D0 Offset: 0x12F6D1 VA: 0x12F5D0
[Serializable]
public struct NoiseSettings.NoiseParams // TypeDefIndex: 4855
{
	// Fields
	[TooltipAttribute] // RVA: 0x1362F0 Offset: 0x1363F1 VA: 0x1362F0
	public float Frequency; // 0x0
	[TooltipAttribute] // RVA: 0x136330 Offset: 0x136431 VA: 0x136330
	public float Amplitude; // 0x4
	[TooltipAttribute] // RVA: 0x136370 Offset: 0x136471 VA: 0x136370
	public bool Constant; // 0x8

	// Methods

	// RVA: 0x17C30 Offset: 0x17D31 VA: 0x17C30
	public float GetValueAt(float time, float timeOffset) { }
}

