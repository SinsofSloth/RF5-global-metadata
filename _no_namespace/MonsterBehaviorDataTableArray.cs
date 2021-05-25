[Serializable]
public class MonsterBehaviorDataTableArray : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 7768
{
	// Fields
	[SerializeField] // RVA: 0x1692C0 Offset: 0x1693C1 VA: 0x1692C0
	public MonsterBehaviorDataTable[] DataTables; // 0x18

	// Methods

	// RVA: 0x2161C10 Offset: 0x2161D11 VA: 0x2161C10 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2161C90 Offset: 0x2161D91 VA: 0x2161C90 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x2161CA0 Offset: 0x2161DA1 VA: 0x2161CA0
	public void .ctor() { }
}

