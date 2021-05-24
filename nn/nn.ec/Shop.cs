public static class Shop // TypeDefIndex: 11701
{
	// Methods

	// RVA: 0x26A82D0 Offset: 0x26A83D1 VA: 0x26A82D0
	public static extern void ShowApplicationInformation(ulong applicationId) { }

	// RVA: 0x26A82E0 Offset: 0x26A83E1 VA: 0x26A82E0
	public static extern void ShowApplicationInformation(ulong applicationId, UserHandle selectedUser) { }

	// RVA: 0x26A8310 Offset: 0x26A8411 VA: 0x26A8310
	public static extern void ShowAddOnContentList(ulong applicationId) { }

	// RVA: 0x26A8320 Offset: 0x26A8421 VA: 0x26A8320
	public static extern void ShowAddOnContentList(ulong applicationId, UserHandle selectedUser) { }

	// RVA: 0x26A8350 Offset: 0x26A8451 VA: 0x26A8350
	public static extern void ShowSubscriptionList(ulong applicationId) { }

	// RVA: 0x26A8360 Offset: 0x26A8461 VA: 0x26A8360
	public static extern void ShowSubscriptionList(ulong applicationId, UserHandle selectedUser) { }

	// RVA: 0x26A8390 Offset: 0x26A8491 VA: 0x26A8390
	public static extern void ShowSubscriptionList(ulong applicationId, CourseId courseId) { }

	// RVA: 0x26A83F0 Offset: 0x26A84F1 VA: 0x26A83F0
	public static extern void ShowSubscriptionList(ulong applicationId, CourseId courseId, UserHandle selectedUser) { }

	// RVA: 0x26A8470 Offset: 0x26A8571 VA: 0x26A8470
	public static extern void ShowConsumableItemList(ulong applicationId) { }

	// RVA: 0x26A8480 Offset: 0x26A8581 VA: 0x26A8480
	public static extern void ShowConsumableItemList(ulong applicationId, UserHandle selectedUser) { }

	// RVA: 0x26A84B0 Offset: 0x26A85B1 VA: 0x26A84B0
	public static extern void ShowConsumableItemDetail(ulong applicationId, ConsumableId consumableId, NsUid nsUid) { }

	// RVA: 0x26A8520 Offset: 0x26A8621 VA: 0x26A8520
	public static extern void ShowConsumableItemDetail(ulong applicationId, ConsumableId consumableId, NsUid nsUid, UserHandle selectedUser) { }

	// RVA: 0x26A85B0 Offset: 0x26A86B1 VA: 0x26A85B0
	public static extern void ShowEnterCodeScene() { }

	// RVA: 0x26A85C0 Offset: 0x26A86C1 VA: 0x26A85C0
	public static extern void ShowEnterCodeScene(UserHandle selectedUser) { }

	// RVA: 0x26A85F0 Offset: 0x26A86F1 VA: 0x26A85F0
	public static extern void ShowShopProductDetails(NsUid nsuid) { }

	// RVA: 0x26A8600 Offset: 0x26A8701 VA: 0x26A8600
	public static extern void ShowShopProductDetails(NsUid nsuid, UserHandle selectedUser) { }

	// RVA: 0x26A8630 Offset: 0x26A8731 VA: 0x26A8630
	public static void ShowShopProductList(NsUid[] nsuidList, string listName) { }

	// RVA: 0x26A8680 Offset: 0x26A8781 VA: 0x26A8680
	private static extern void ShowShopProductList(NsUid[] nsuidList, int nsuidCount, string listName) { }

	// RVA: 0x26A86D0 Offset: 0x26A87D1 VA: 0x26A86D0
	public static void ShowShopProductList(NsUid[] nsuidList, string listName, UserHandle selectedUser) { }

	// RVA: 0x26A8750 Offset: 0x26A8851 VA: 0x26A8750
	private static extern void ShowShopProductList(NsUid[] nsuidList, int nsuidCount, string listName, UserHandle selectedUser) { }

	// RVA: 0x26A87D0 Offset: 0x26A88D1 VA: 0x26A87D0
	public static extern NsUid MakeNsUid(string str) { }
}

