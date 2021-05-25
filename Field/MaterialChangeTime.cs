public class MaterialChangeTime : MonoBehaviour // TypeDefIndex: 10454
{
	// Fields
	[SerializeField] // RVA: 0x181990 Offset: 0x181A91 VA: 0x181990
	private TimeParamTable[] _TimeParamTables; // 0x18
	[SerializeField] // RVA: 0x1819A0 Offset: 0x181AA1 VA: 0x1819A0
	public Material[] Materials; // 0x20
	[SerializeField] // RVA: 0x1819B0 Offset: 0x181AB1 VA: 0x1819B0
	private RendererMaterial[] _RendererMaterials; // 0x28
	[SerializeField] // RVA: 0x1819C0 Offset: 0x181AC1 VA: 0x1819C0
	private Light _Light; // 0x30

	// Properties
	public TimeParamTable[] TimeParamTables { get; set; }
	[SerializeField] // RVA: 0x1B92D0 Offset: 0x1B93D1 VA: 0x1B92D0
	public RendererMaterial[] RendererMaterials { get; set; }
	public Light Light { get; set; }

	// Methods

	// RVA: 0x1EE94C0 Offset: 0x1EE95C1 VA: 0x1EE94C0
	public TimeParamTable[] get_TimeParamTables() { }

	// RVA: 0x1EE94D0 Offset: 0x1EE95D1 VA: 0x1EE94D0
	public void set_TimeParamTables(TimeParamTable[] value) { }

	// RVA: 0x1EE94E0 Offset: 0x1EE95E1 VA: 0x1EE94E0
	public RendererMaterial[] get_RendererMaterials() { }

	// RVA: 0x1EE94F0 Offset: 0x1EE95F1 VA: 0x1EE94F0
	public void set_RendererMaterials(RendererMaterial[] value) { }

	// RVA: 0x1EE9500 Offset: 0x1EE9601 VA: 0x1EE9500
	public Light get_Light() { }

	// RVA: 0x1EE9510 Offset: 0x1EE9611 VA: 0x1EE9510
	public void set_Light(Light value) { }

	// RVA: 0x1EE9520 Offset: 0x1EE9621 VA: 0x1EE9520
	private void OnDestroy() { }

	// RVA: 0x1EE96F0 Offset: 0x1EE97F1 VA: 0x1EE96F0
	private void Awake() { }

	// RVA: 0x1EE7500 Offset: 0x1EE7601 VA: 0x1EE7500
	public void SetTimeParamTable(TimeParamTable[] timeParamTables) { }

	// RVA: 0x1EE9CB0 Offset: 0x1EE9DB1 VA: 0x1EE9CB0
	public void .ctor() { }
}

