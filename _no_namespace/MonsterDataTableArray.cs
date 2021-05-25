[Serializable]
public class MonsterDataTableArray : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 7773
{
	// Fields
	[SerializeField] // RVA: 0x1697A0 Offset: 0x1698A1 VA: 0x1697A0
	public MonsterDataTable[] DataTables; // 0x18
	public Dictionary<MonsterDataID, MonsterDataTable> DataTableDic; // 0x20

	// Methods

	// RVA: 0x21712D0 Offset: 0x21713D1 VA: 0x21712D0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2171480 Offset: 0x2171581 VA: 0x2171480 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x2171490 Offset: 0x2171591 VA: 0x2171490
	public void .ctor() { }
}

