[Serializable]
public class MonsterFootStepEventDataTableArray : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 10638
{
	// Fields
	[SerializeField] // RVA: 0x181F20 Offset: 0x182021 VA: 0x181F20
	public MonsterFootStepEventDataTable[] DataTables; // 0x18
	public Dictionary<MonsterFootStepEventDataID, MonsterFootStepEventDataTable> DataTableDic; // 0x20

	// Methods

	// RVA: 0x1CAE050 Offset: 0x1CAE151 VA: 0x1CAE050 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x1CAE1F0 Offset: 0x1CAE2F1 VA: 0x1CAE1F0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x1CAE200 Offset: 0x1CAE301 VA: 0x1CAE200
	public void .ctor() { }
}

