[Serializable]
public class EnvironmentSoundDataTableArray : ScriptableObject // TypeDefIndex: 10559
{
	// Fields
	[SerializeField] // RVA: 0x181EA0 Offset: 0x181FA1 VA: 0x181EA0
	public EnvironmentSoundDataTable[] DataTables; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x181EB0 Offset: 0x181FB1 VA: 0x181EB0
	private Dictionary<EnvironmentSoundType, List<EnvironmentSoundDataTable>> <DataTablesByType>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x181EC0 Offset: 0x181FC1 VA: 0x181EC0
	private Dictionary<FieldSceneId, List<EnvironmentSoundDataTable>> <DataTablesBySceneID>k__BackingField; // 0x28
	private bool IsInit; // 0x30

	// Properties
	private Dictionary<EnvironmentSoundType, List<EnvironmentSoundDataTable>> DataTablesByType { get; set; }
	private Dictionary<FieldSceneId, List<EnvironmentSoundDataTable>> DataTablesBySceneID { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AFDC0 Offset: 0x1AFEC1 VA: 0x1AFDC0
	// RVA: 0x1CAD220 Offset: 0x1CAD321 VA: 0x1CAD220
	private Dictionary<EnvironmentSoundType, List<EnvironmentSoundDataTable>> get_DataTablesByType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AFDD0 Offset: 0x1AFED1 VA: 0x1AFDD0
	// RVA: 0x1CAD230 Offset: 0x1CAD331 VA: 0x1CAD230
	private void set_DataTablesByType(Dictionary<EnvironmentSoundType, List<EnvironmentSoundDataTable>> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AFDE0 Offset: 0x1AFEE1 VA: 0x1AFDE0
	// RVA: 0x1CAD240 Offset: 0x1CAD341 VA: 0x1CAD240
	private Dictionary<FieldSceneId, List<EnvironmentSoundDataTable>> get_DataTablesBySceneID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AFDF0 Offset: 0x1AFEF1 VA: 0x1AFDF0
	// RVA: 0x1CAD250 Offset: 0x1CAD351 VA: 0x1CAD250
	private void set_DataTablesBySceneID(Dictionary<FieldSceneId, List<EnvironmentSoundDataTable>> value) { }

	// RVA: 0x1CAD260 Offset: 0x1CAD361 VA: 0x1CAD260
	private void Init() { }

	// RVA: 0x1CAD4D0 Offset: 0x1CAD5D1 VA: 0x1CAD4D0
	public EnvironmentSoundDataTable[] GetDataTables(EnvironmentSoundType type) { }

	// RVA: 0x1CAD680 Offset: 0x1CAD781 VA: 0x1CAD680
	public EnvironmentSoundDataTable[] GetDataTables(FieldSceneId id) { }

	// RVA: 0x1CAD770 Offset: 0x1CAD871 VA: 0x1CAD770
	public void .ctor() { }
}

