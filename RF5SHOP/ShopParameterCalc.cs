public class ShopParameterCalc // TypeDefIndex: 9781
{
	// Methods

	// RVA: 0x1DF7690 Offset: 0x1DF7791 VA: 0x1DF7690
	private int GetBuilderLv(BuilderId builderId, int maxLv) { }

	// RVA: 0x1DF5A30 Offset: 0x1DF5B31 VA: 0x1DF5A30
	public int GetShopLv(NpcShopType shopType) { }

	// RVA: 0x1DF7710 Offset: 0x1DF7811 VA: 0x1DF7710
	public bool CheckShopItemCondition(ulong conditionId, GameFlagData storyLineFrags, int conditionShopLv, int myShopLv, NPCID npcId) { }

	// RVA: 0x1DF6120 Offset: 0x1DF6221 VA: 0x1DF6120
	public bool CheckShopItemCondition(NpcShopType shopType, ShopItem shopItem, int myShopLv, NPCID npcId) { }

	// RVA: 0x1DF7E90 Offset: 0x1DF7F91 VA: 0x1DF7E90
	public bool CheckBuildItemCondition(BuildItemData shopItem, int myShopLv, NPCID npcId) { }

	// RVA: 0x1DF5A20 Offset: 0x1DF5B21 VA: 0x1DF5A20
	public void .ctor() { }
}

