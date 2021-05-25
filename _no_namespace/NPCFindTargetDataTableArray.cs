[Serializable]
public class NPCFindTargetDataTableArray : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 7021
{
	// Fields
	[SerializeField] // RVA: 0x1627F0 Offset: 0x1628F1 VA: 0x1627F0
	public NPCFindTargetDataTable[] DataTables; // 0x18
	public Dictionary<int, NPCFindTargetDataTable> DataTableDic; // 0x20

	// Methods

	// RVA: 0x1FB4E00 Offset: 0x1FB4F01 VA: 0x1FB4E00 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x1FB4EF0 Offset: 0x1FB4FF1 VA: 0x1FB4EF0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x1FB4F00 Offset: 0x1FB5001 VA: 0x1FB4F00
	public void .ctor() { }
}

