[CreateAssetMenuAttribute] // RVA: 0x14A610 Offset: 0x14A711 VA: 0x14A610
[Serializable]
public class FocusObjectDataTableArray : ScriptableObject // TypeDefIndex: 10445
{
	// Fields
	[SerializeField] // RVA: 0x1818D0 Offset: 0x1819D1 VA: 0x1818D0
	public FocusObjectDataTable[] DataTables; // 0x18

	// Methods

	// RVA: 0x1EE6D70 Offset: 0x1EE6E71 VA: 0x1EE6D70
	public FocusObjectDataTable[] GetDataTables() { }

	// RVA: 0x1EE6D80 Offset: 0x1EE6E81 VA: 0x1EE6D80
	public FocusObjectDataTable GetDataTables(int index) { }

	// RVA: 0x1EE6DD0 Offset: 0x1EE6ED1 VA: 0x1EE6DD0
	public FocusObjectDataTable GetDataTables(FocusObjectID id) { }

	// RVA: 0x1EE6E80 Offset: 0x1EE6F81 VA: 0x1EE6E80
	public void .ctor() { }
}

