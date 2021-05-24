public static class FacilityManager // TypeDefIndex: 10382
{
	// Fields
	private static RecipePanShopID Selected_RecipePanID; // 0x0
	private static List<RecipePanShopID> DisplayedList_RecipePanID; // 0x8
	private static ClothShopID Selected_ClothShopID; // 0x10
	private static List<ClothShopID> DisplayedList_ClothShopID; // 0x18
	private static HotSpringID Selected_HotSpringID; // 0x20
	private static List<HotSpringID> DisplayedList_HotSpringID; // 0x28
	private static VaccinationID Selected_VaccinationID; // 0x30
	private static List<VaccinationID> DisplayedList_VaccinationID; // 0x38
	private static ItemID Selected_CrystalID; // 0x40
	private static List<ItemID> DisplayedList_CrystalID; // 0x48
	private static EquipSlotType Selected_EquipSlotType; // 0x50
	private const int RookieBadgeLimit = 20;
	public static bool IsKilledByWantedMonster; // 0x54
	public static bool IsFreeRespawn; // 0x55
	private static List<string> EquipAppraisalMaterials; // 0x58
	private static List<string> EquipSynthesisMaterials; // 0x60
	private static string EquipArrangeOverrideMaterial; // 0x68

	// Methods

	// RVA: 0x207D2B0 Offset: 0x207D3B1 VA: 0x207D2B0
	public static string SelectedItemName(ADVShopID shopID) { }

	// RVA: 0x207D630 Offset: 0x207D731 VA: 0x207D630
	public static string SelectedCrystalFragmentName() { }

	// RVA: 0x207D6C0 Offset: 0x207D7C1 VA: 0x207D6C0
	public static int CountSelectedCrystalFragment() { }

	// RVA: 0x207D780 Offset: 0x207D881 VA: 0x207D780
	public static int SelectedItemPrice(ADVShopID shopID) { }

	// RVA: 0x207D8F0 Offset: 0x207D9F1 VA: 0x207D8F0
	public static string SelectedItemDetail(ADVShopID shopID) { }

	// RVA: 0x207DB10 Offset: 0x207DC11 VA: 0x207DB10
	public static int SelectedItemTime(ADVShopID shopID) { }

	// RVA: 0x207DC00 Offset: 0x207DD01 VA: 0x207DC00
	public static string Temporary_HotSpring() { }

	// RVA: 0x207DD30 Offset: 0x207DE31 VA: 0x207DD30
	public static string TemporaryTimeLimit_HotSpring() { }

	// RVA: 0x207DDF0 Offset: 0x207DEF1 VA: 0x207DDF0
	private static string CreateTextTimeLimit(int to, int current) { }

	// RVA: 0x207DEC0 Offset: 0x207DFC1 VA: 0x207DEC0
	public static string Temporary_Vaccination() { }

	// RVA: 0x207DFF0 Offset: 0x207E0F1 VA: 0x207DFF0
	public static string TemporaryTimeLimit_Vaccination() { }

	// RVA: 0x207E0B0 Offset: 0x207E1B1 VA: 0x207E0B0
	public static ValueTuple<EventSelectGroupType, List<string>> GetADVShopList(ADVShopID id) { }

	// RVA: 0x207EFE0 Offset: 0x207F0E1 VA: 0x207EFE0
	public static void OnSelectedMenu_ADVShopList(EventSelectGroupType eventSelectGroupType, int index) { }

	// RVA: 0x207F3F0 Offset: 0x207F4F1 VA: 0x207F3F0
	public static void RevivalPlayer() { }

	// RVA: 0x207F7F0 Offset: 0x207F8F1 VA: 0x207F7F0
	public static bool IsCheckFreeRespawn() { }

	// RVA: 0x207F840 Offset: 0x207F941 VA: 0x207F840
	public static int CalucRespawnCost() { }

	// RVA: 0x207FD30 Offset: 0x207FE31 VA: 0x207FD30
	public static void ReduceRespawnCost() { }

	// RVA: 0x207FDD0 Offset: 0x207FED1 VA: 0x207FDD0
	public static void RespawnHeal() { }

	// RVA: 0x207FF50 Offset: 0x2080051 VA: 0x207FF50
	public static bool IsVaccination() { }

	// RVA: 0x207FFD0 Offset: 0x20800D1 VA: 0x207FFD0
	public static bool BuyVaccination() { }

	// RVA: 0x207FA30 Offset: 0x207FB31 VA: 0x207FA30
	public static bool IsPartyLover() { }

	// RVA: 0x207FBB0 Offset: 0x207FCB1 VA: 0x207FBB0
	public static bool IsPartySpouses() { }

	// RVA: 0x2080130 Offset: 0x2080231 VA: 0x2080130
	public static int GetCount_Today_RecipePan(bool isBakery) { }

	// RVA: 0x2080200 Offset: 0x2080301 VA: 0x2080200
	public static bool BuyRecipePan(bool isBakery) { }

	// RVA: 0x2080460 Offset: 0x2080561 VA: 0x2080460
	public static bool BuyClothShop() { }

	// RVA: 0x20805E0 Offset: 0x20806E1 VA: 0x20805E0
	public static bool IsBoughtClothAll() { }

	// RVA: 0x20808A0 Offset: 0x20809A1 VA: 0x20808A0
	public static bool IsHotSpring() { }

	// RVA: 0x2080920 Offset: 0x2080A21 VA: 0x2080920
	public static bool BuyHotSpring() { }

	// RVA: 0x2080B80 Offset: 0x2080C81 VA: 0x2080B80
	public static void SetHotSpring(HotSpringID hotSpringID) { }

	// RVA: 0x2080BF0 Offset: 0x2080CF1 VA: 0x2080BF0
	public static bool CheckRookieBadgeLimit(int lv) { }

	// RVA: 0x2080C00 Offset: 0x2080D01 VA: 0x2080C00
	public static bool TradeCrystal() { }

	// RVA: 0x2080E00 Offset: 0x2080F01 VA: 0x2080E00
	public static int CountCrystalFragment(ItemID itemID) { }

	// RVA: 0x2080EC0 Offset: 0x2080FC1 VA: 0x2080EC0
	public static void SelectedEquipSlotType(EquipSlotType type) { }

	// RVA: 0x2080F30 Offset: 0x2081031 VA: 0x2080F30
	public static bool SelectedEquipSlot_IsStrengthening() { }

	// RVA: 0x2081220 Offset: 0x2081321 VA: 0x2081220
	public static int GetSelectedEquipSlot_MaterialsNum() { }

	// RVA: 0x20812A0 Offset: 0x20813A1 VA: 0x20812A0
	public static string GetSelectedEquipSlot_MaterialName(int index) { }

	// RVA: 0x2081380 Offset: 0x2081481 VA: 0x2081380
	public static string GetSelectedEquipSlot_Name() { }

	// RVA: 0x20810D0 Offset: 0x20811D1 VA: 0x20810D0
	public static void SetSelectedEquipSlot_AllMaterialStr() { }

	// RVA: 0x2081710 Offset: 0x2081811 VA: 0x2081710
	public static int GetSelectedEquipSlot_BaseLvType() { }

	// RVA: 0x2081900 Offset: 0x2081A01 VA: 0x2081900
	public static int GetSelectedEquipSlot_TotalMaterialBonusType() { }

	// RVA: 0x20814E0 Offset: 0x20815E1 VA: 0x20814E0
	private static void SetAllMaterialStr(EquipItemData item) { }

	// RVA: 0x20818B0 Offset: 0x20819B1 VA: 0x20818B0
	private static int GetBaseLvType(EquipItemData item) { }

	// RVA: 0x2081AC0 Offset: 0x2081BC1 VA: 0x2081AC0
	private static int GetTotalMaterialBonusType(EquipItemData item) { }

	// RVA: 0x2081B30 Offset: 0x2081C31 VA: 0x2081B30
	public static int GetSelectedEquipSlot_SynthesisMaterialsNum() { }

	// RVA: 0x2081EA0 Offset: 0x2081FA1 VA: 0x2081EA0
	public static string GetSelectedEquipSlot_SynthesisMaterialName() { }

	// RVA: 0x2081FC0 Offset: 0x20820C1 VA: 0x2081FC0
	public static bool GetSelectedEquipSlot_ArrangeOverride() { }

	// RVA: 0x2082290 Offset: 0x2082391 VA: 0x2082290
	public static string GetSelectedEquipSlot_ArrangeOverrideMaterialName() { }

	// RVA: 0x2082370 Offset: 0x2082471 VA: 0x2082370
	public static int GetFieldUniqueTreasureBox_OpenedNum() { }

	// RVA: 0x20823E0 Offset: 0x20824E1 VA: 0x20823E0
	public static int GetFieldUniqueTreasureBox_MaxNum() { }

	// RVA: 0x2082420 Offset: 0x2082521 VA: 0x2082420
	public static bool IsEnableNPC(ActorID actorID) { }

	// RVA: 0x2082A30 Offset: 0x2082B31 VA: 0x2082A30
	private static void .cctor() { }
}

