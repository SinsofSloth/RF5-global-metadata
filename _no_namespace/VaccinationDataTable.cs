[Serializable]
public class VaccinationDataTable // TypeDefIndex: 7054
{
	// Fields
	[SerializeField] // RVA: 0x162D80 Offset: 0x162E81 VA: 0x162D80
	public int Price; // 0x10
	[SerializeField] // RVA: 0x162D90 Offset: 0x162E91 VA: 0x162D90
	public int Time; // 0x14
	[SerializeField] // RVA: 0x162DA0 Offset: 0x162EA1 VA: 0x162DA0
	public float Args1; // 0x18
	[SerializeField] // RVA: 0x162DB0 Offset: 0x162EB1 VA: 0x162DB0
	public float Args2; // 0x1C
	[SerializeField] // RVA: 0x162DC0 Offset: 0x162EC1 VA: 0x162DC0
	public string ScreenNameID; // 0x20
	[SerializeField] // RVA: 0x162DD0 Offset: 0x162ED1 VA: 0x162DD0
	public string DetailTextID; // 0x28
	[SerializeField] // RVA: 0x162DE0 Offset: 0x162EE1 VA: 0x162DE0
	public BuilderId Release_BuilderID; // 0x30
	private static VaccinationDataTableArray _VaccinationDataTableArray; // 0x0

	// Methods

	// RVA: 0x1CFDDA0 Offset: 0x1CFDEA1 VA: 0x1CFDDA0
	public static VaccinationDataTable GetDataTable(VaccinationID vaccinationID) { }

	// RVA: 0x1CFDEE0 Offset: 0x1CFDFE1 VA: 0x1CFDEE0
	public static IEnumerable<SerializeVaccinationDataTable> GetDataTables() { }

	// RVA: 0x1CFE000 Offset: 0x1CFE101 VA: 0x1CFE000
	public void .ctor() { }
}

