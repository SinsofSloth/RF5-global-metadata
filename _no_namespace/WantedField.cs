public class WantedField : MonoBehaviour // TypeDefIndex: 8070
{
	// Fields
	public const int MaxFieldIDCount = 5;
	public const int MaxPopPointIDCount = 3;
	[SerializeField] // RVA: 0x16A2B0 Offset: 0x16A3B1 VA: 0x16A2B0
	private WantedFieldType _FieldType; // 0x18
	[SerializeField] // RVA: 0x16A2C0 Offset: 0x16A3C1 VA: 0x16A2C0
	private List<WantedField.Points> FieldPopPointData; // 0x20

	// Properties
	public WantedFieldType FieldType { get; set; }

	// Methods

	// RVA: 0x1D02C50 Offset: 0x1D02D51 VA: 0x1D02C50
	public WantedFieldType get_FieldType() { }

	// RVA: 0x1D02C60 Offset: 0x1D02D61 VA: 0x1D02C60
	private void set_FieldType(WantedFieldType value) { }

	// RVA: 0x1D02C70 Offset: 0x1D02D71 VA: 0x1D02C70
	private int FieldIDToIndex(int fieldID) { }

	// RVA: 0x1D02C80 Offset: 0x1D02D81 VA: 0x1D02C80
	public Transform GetPopPoint(int fieldID, int popPointID) { }

	// RVA: 0x1D02DD0 Offset: 0x1D02ED1 VA: 0x1D02DD0
	public Transform GetPopPoint(int fieldID) { }

	// RVA: 0x1D02EB0 Offset: 0x1D02FB1 VA: 0x1D02EB0
	public void .ctor() { }
}

