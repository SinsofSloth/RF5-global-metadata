[CreateAssetMenuAttribute] // RVA: 0x146350 Offset: 0x146451 VA: 0x146350
[Serializable]
public class OrderMasterDataArray : ScriptableObject // TypeDefIndex: 7214
{
	// Fields
	[SerializeField] // RVA: 0x1650B0 Offset: 0x1651B1 VA: 0x1650B0
	public List<OrderMasterData> NpcDatas; // 0x18
	[SerializeField] // RVA: 0x1650C0 Offset: 0x1651C1 VA: 0x1650C0
	public List<OrderMasterData> PoliceDatas; // 0x20
	[SerializeField] // RVA: 0x1650D0 Offset: 0x1651D1 VA: 0x1650D0
	public List<OrderMasterData> TanteiDatas; // 0x28

	// Methods

	// RVA: 0x1F2B7B0 Offset: 0x1F2B8B1 VA: 0x1F2B7B0
	public void .ctor() { }
}

