[CreateAssetMenuAttribute] // RVA: 0x149C10 Offset: 0x149D11 VA: 0x149C10
[Serializable]
public class WantedDataTable : ScriptableObject // TypeDefIndex: 9804
{
	// Fields
	[SerializeField] // RVA: 0x17F360 Offset: 0x17F461 VA: 0x17F360
	public WantedDataTable.Data[] wantedDatas; // 0x18
	[SerializeField] // RVA: 0x17F370 Offset: 0x17F471 VA: 0x17F370
	public WantedDataTable.Data[] randomWantedForestDatas; // 0x20
	[SerializeField] // RVA: 0x17F380 Offset: 0x17F481 VA: 0x17F380
	public WantedDataTable.Data[] randomWantedVolcanoDatas; // 0x28
	[SerializeField] // RVA: 0x17F390 Offset: 0x17F491 VA: 0x17F390
	public WantedDataTable.Data[] randomWantedIcyDatas; // 0x30
	[SerializeField] // RVA: 0x17F3A0 Offset: 0x17F4A1 VA: 0x17F3A0
	public WantedDataTable.Reward[] RewardDatas; // 0x38
	[SerializeField] // RVA: 0x17F3B0 Offset: 0x17F4B1 VA: 0x17F3B0
	public WantedDataTable.Reward[] RandomRewardDatas; // 0x40

	// Methods

	// RVA: 0x1DA7F50 Offset: 0x1DA8051 VA: 0x1DA7F50
	public void .ctor() { }
}

