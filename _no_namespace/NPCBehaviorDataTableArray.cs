[Serializable]
public class NPCBehaviorDataTableArray : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 7019
{
	// Fields
	[SerializeField] // RVA: 0x1627E0 Offset: 0x1628E1 VA: 0x1627E0
	public NPCBehaviorDataTable[] DataTables; // 0x18
	public Dictionary<int, NPCBehaviorDataTable> DataTableDic; // 0x20

	// Methods

	// RVA: 0x1FB4CC0 Offset: 0x1FB4DC1 VA: 0x1FB4CC0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x1FB4DB0 Offset: 0x1FB4EB1 VA: 0x1FB4DB0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x1FB4DC0 Offset: 0x1FB4EC1 VA: 0x1FB4DC0
	public void .ctor() { }
}

