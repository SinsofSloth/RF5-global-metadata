[Serializable]
public class MobTalkDataTable : ScriptableObject // TypeDefIndex: 7010
{
	// Fields
	[SerializeField] // RVA: 0x162710 Offset: 0x162811 VA: 0x162710
	public SerializeMobCharTalkDataTableArray Talks; // 0x18
	private static MobTalkDataTable _MobTalkDataTable; // 0x0

	// Methods

	// RVA: 0x1CBE590 Offset: 0x1CBE691 VA: 0x1CBE590
	public static MobTalkData GetDataTable(CharID charID, VariationNo no) { }

	// RVA: 0x1CBE7C0 Offset: 0x1CBE8C1 VA: 0x1CBE7C0
	public static bool HasDataTable(CharID charID, VariationNo no) { }

	// RVA: 0x1CBE970 Offset: 0x1CBEA71 VA: 0x1CBE970
	public void .ctor() { }
}

