public static class DualWorkManager // TypeDefIndex: 10386
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x181640 Offset: 0x181741 VA: 0x181640
	private static DualWorkType <WorkType>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x181650 Offset: 0x181751 VA: 0x181650
	private static ActorID <SubActor>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x181660 Offset: 0x181761 VA: 0x181660
	private static int <LoveLevel>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x181670 Offset: 0x181771 VA: 0x181670
	private static ItemData[] <DualworkTmp>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x181680 Offset: 0x181781 VA: 0x181680
	private static DualWorkObject <DualWorkObject>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x181690 Offset: 0x181791 VA: 0x181690
	private static UnityAction<bool> <EndCallBack>k__BackingField; // 0x20
	public static DualWorkManager.CraftInfoData CraftInfo; // 0x28
	private static readonly ActorID[] LotteryBase; // 0x40

	// Properties
	public static DualWorkType WorkType { get; set; }
	public static ActorID SubActor { get; set; }
	public static int LoveLevel { get; set; }
	public static ItemData[] DualworkTmp { get; set; }
	private static DualWorkObject DualWorkObject { get; set; }
	private static UnityAction<bool> EndCallBack { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AEE00 Offset: 0x1AEF01 VA: 0x1AEE00
	// RVA: 0x1CF6930 Offset: 0x1CF6A31 VA: 0x1CF6930
	public static DualWorkType get_WorkType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE10 Offset: 0x1AEF11 VA: 0x1AEE10
	// RVA: 0x1CF69A0 Offset: 0x1CF6AA1 VA: 0x1CF69A0
	public static void set_WorkType(DualWorkType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE20 Offset: 0x1AEF21 VA: 0x1AEE20
	// RVA: 0x1CF6A10 Offset: 0x1CF6B11 VA: 0x1CF6A10
	public static ActorID get_SubActor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE30 Offset: 0x1AEF31 VA: 0x1AEE30
	// RVA: 0x1CF6A80 Offset: 0x1CF6B81 VA: 0x1CF6A80
	public static void set_SubActor(ActorID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE40 Offset: 0x1AEF41 VA: 0x1AEE40
	// RVA: 0x1CF6AF0 Offset: 0x1CF6BF1 VA: 0x1CF6AF0
	public static int get_LoveLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE50 Offset: 0x1AEF51 VA: 0x1AEE50
	// RVA: 0x1CF6B60 Offset: 0x1CF6C61 VA: 0x1CF6B60
	public static void set_LoveLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE60 Offset: 0x1AEF61 VA: 0x1AEE60
	// RVA: 0x1CF6BD0 Offset: 0x1CF6CD1 VA: 0x1CF6BD0
	public static ItemData[] get_DualworkTmp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE70 Offset: 0x1AEF71 VA: 0x1AEE70
	// RVA: 0x1CF6C40 Offset: 0x1CF6D41 VA: 0x1CF6C40
	public static void set_DualworkTmp(ItemData[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE80 Offset: 0x1AEF81 VA: 0x1AEE80
	// RVA: 0x1CF6CB0 Offset: 0x1CF6DB1 VA: 0x1CF6CB0
	private static DualWorkObject get_DualWorkObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE90 Offset: 0x1AEF91 VA: 0x1AEE90
	// RVA: 0x1CF6D20 Offset: 0x1CF6E21 VA: 0x1CF6D20
	private static void set_DualWorkObject(DualWorkObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEA0 Offset: 0x1AEFA1 VA: 0x1AEEA0
	// RVA: 0x1CF6D90 Offset: 0x1CF6E91 VA: 0x1CF6D90
	private static UnityAction<bool> get_EndCallBack() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEB0 Offset: 0x1AEFB1 VA: 0x1AEEB0
	// RVA: 0x1CF6E00 Offset: 0x1CF6F01 VA: 0x1CF6E00
	private static void set_EndCallBack(UnityAction<bool> value) { }

	// RVA: 0x1CF6E70 Offset: 0x1CF6F71 VA: 0x1CF6E70
	public static void StartDualWork(DualWorkObject dualWorkObject, ActorID subActor, int loveLevel, UnityAction<bool> endCallBack) { }

	// RVA: 0x1CF78D0 Offset: 0x1CF79D1 VA: 0x1CF78D0
	private static void CloseUICraft() { }

	// RVA: 0x1CF7BB0 Offset: 0x1CF7CB1 VA: 0x1CF7BB0
	private static void OnEndMiniGame(bool isSuccess) { }

	// RVA: 0x1CF64E0 Offset: 0x1CF65E1 VA: 0x1CF64E0
	public static string GetDualWorkTypeScreenName(DualWorkType type) { }

	// RVA: 0x1CF8320 Offset: 0x1CF8421 VA: 0x1CF8320
	public static string GetDualWorkTypeForScript(DualWorkType type) { }

	// RVA: 0x1CF8390 Offset: 0x1CF8491 VA: 0x1CF8390
	public static RF5SaveData.FLAG GetDualworkDoneFlagID(DualWorkType type) { }

	// RVA: 0x1CF83B0 Offset: 0x1CF84B1 VA: 0x1CF83B0
	public static string GetCurrentDualWorkName() { }

	// RVA: 0x1CF8290 Offset: 0x1CF8391 VA: 0x1CF8290
	public static void DoneDualWork(DualWorkType type) { }

	// RVA: 0x1CF8570 Offset: 0x1CF8671 VA: 0x1CF8570
	public static void DoneDualWork() { }

	// RVA: 0x1CF8640 Offset: 0x1CF8741 VA: 0x1CF8640
	public static bool IsDoneDualWork(DualWorkType currentDualTypeWork) { }

	// RVA: 0x1CF86D0 Offset: 0x1CF87D1 VA: 0x1CF86D0
	public static void ApplySmith(ItemData itemData) { }

	// RVA: 0x1CF89D0 Offset: 0x1CF8AD1 VA: 0x1CF89D0
	public static int GetMaxLoveLevel() { }

	// RVA: 0x1CF8B30 Offset: 0x1CF8C31 VA: 0x1CF8B30
	private static ActorID CalcLottery() { }

	// RVA: 0x1CF8ED0 Offset: 0x1CF8FD1 VA: 0x1CF8ED0
	public static int DoLotteryNPC(DualWorkType workType) { }

	// RVA: 0x1CF9360 Offset: 0x1CF9461 VA: 0x1CF9360
	private static void .cctor() { }
}

public static class DualWorkManager // TypeDefIndex: 10386
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x181640 Offset: 0x181741 VA: 0x181640
	private static DualWorkType <WorkType>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x181650 Offset: 0x181751 VA: 0x181650
	private static ActorID <SubActor>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x181660 Offset: 0x181761 VA: 0x181660
	private static int <LoveLevel>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x181670 Offset: 0x181771 VA: 0x181670
	private static ItemData[] <DualworkTmp>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x181680 Offset: 0x181781 VA: 0x181680
	private static DualWorkObject <DualWorkObject>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x181690 Offset: 0x181791 VA: 0x181690
	private static UnityAction<bool> <EndCallBack>k__BackingField; // 0x20
	public static DualWorkManager.CraftInfoData CraftInfo; // 0x28
	private static readonly ActorID[] LotteryBase; // 0x40

	// Properties
	public static DualWorkType WorkType { get; set; }
	public static ActorID SubActor { get; set; }
	public static int LoveLevel { get; set; }
	public static ItemData[] DualworkTmp { get; set; }
	private static DualWorkObject DualWorkObject { get; set; }
	private static UnityAction<bool> EndCallBack { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AEE00 Offset: 0x1AEF01 VA: 0x1AEE00
	// RVA: 0x1CF6930 Offset: 0x1CF6A31 VA: 0x1CF6930
	public static DualWorkType get_WorkType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE10 Offset: 0x1AEF11 VA: 0x1AEE10
	// RVA: 0x1CF69A0 Offset: 0x1CF6AA1 VA: 0x1CF69A0
	public static void set_WorkType(DualWorkType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE20 Offset: 0x1AEF21 VA: 0x1AEE20
	// RVA: 0x1CF6A10 Offset: 0x1CF6B11 VA: 0x1CF6A10
	public static ActorID get_SubActor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE30 Offset: 0x1AEF31 VA: 0x1AEE30
	// RVA: 0x1CF6A80 Offset: 0x1CF6B81 VA: 0x1CF6A80
	public static void set_SubActor(ActorID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE40 Offset: 0x1AEF41 VA: 0x1AEE40
	// RVA: 0x1CF6AF0 Offset: 0x1CF6BF1 VA: 0x1CF6AF0
	public static int get_LoveLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE50 Offset: 0x1AEF51 VA: 0x1AEE50
	// RVA: 0x1CF6B60 Offset: 0x1CF6C61 VA: 0x1CF6B60
	public static void set_LoveLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE60 Offset: 0x1AEF61 VA: 0x1AEE60
	// RVA: 0x1CF6BD0 Offset: 0x1CF6CD1 VA: 0x1CF6BD0
	public static ItemData[] get_DualworkTmp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE70 Offset: 0x1AEF71 VA: 0x1AEE70
	// RVA: 0x1CF6C40 Offset: 0x1CF6D41 VA: 0x1CF6C40
	public static void set_DualworkTmp(ItemData[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE80 Offset: 0x1AEF81 VA: 0x1AEE80
	// RVA: 0x1CF6CB0 Offset: 0x1CF6DB1 VA: 0x1CF6CB0
	private static DualWorkObject get_DualWorkObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE90 Offset: 0x1AEF91 VA: 0x1AEE90
	// RVA: 0x1CF6D20 Offset: 0x1CF6E21 VA: 0x1CF6D20
	private static void set_DualWorkObject(DualWorkObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEA0 Offset: 0x1AEFA1 VA: 0x1AEEA0
	// RVA: 0x1CF6D90 Offset: 0x1CF6E91 VA: 0x1CF6D90
	private static UnityAction<bool> get_EndCallBack() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEB0 Offset: 0x1AEFB1 VA: 0x1AEEB0
	// RVA: 0x1CF6E00 Offset: 0x1CF6F01 VA: 0x1CF6E00
	private static void set_EndCallBack(UnityAction<bool> value) { }

	// RVA: 0x1CF6E70 Offset: 0x1CF6F71 VA: 0x1CF6E70
	public static void StartDualWork(DualWorkObject dualWorkObject, ActorID subActor, int loveLevel, UnityAction<bool> endCallBack) { }

	// RVA: 0x1CF78D0 Offset: 0x1CF79D1 VA: 0x1CF78D0
	private static void CloseUICraft() { }

	// RVA: 0x1CF7BB0 Offset: 0x1CF7CB1 VA: 0x1CF7BB0
	private static void OnEndMiniGame(bool isSuccess) { }

	// RVA: 0x1CF64E0 Offset: 0x1CF65E1 VA: 0x1CF64E0
	public static string GetDualWorkTypeScreenName(DualWorkType type) { }

	// RVA: 0x1CF8320 Offset: 0x1CF8421 VA: 0x1CF8320
	public static string GetDualWorkTypeForScript(DualWorkType type) { }

	// RVA: 0x1CF8390 Offset: 0x1CF8491 VA: 0x1CF8390
	public static RF5SaveData.FLAG GetDualworkDoneFlagID(DualWorkType type) { }

	// RVA: 0x1CF83B0 Offset: 0x1CF84B1 VA: 0x1CF83B0
	public static string GetCurrentDualWorkName() { }

	// RVA: 0x1CF8290 Offset: 0x1CF8391 VA: 0x1CF8290
	public static void DoneDualWork(DualWorkType type) { }

	// RVA: 0x1CF8570 Offset: 0x1CF8671 VA: 0x1CF8570
	public static void DoneDualWork() { }

	// RVA: 0x1CF8640 Offset: 0x1CF8741 VA: 0x1CF8640
	public static bool IsDoneDualWork(DualWorkType currentDualTypeWork) { }

	// RVA: 0x1CF86D0 Offset: 0x1CF87D1 VA: 0x1CF86D0
	public static void ApplySmith(ItemData itemData) { }

	// RVA: 0x1CF89D0 Offset: 0x1CF8AD1 VA: 0x1CF89D0
	public static int GetMaxLoveLevel() { }

	// RVA: 0x1CF8B30 Offset: 0x1CF8C31 VA: 0x1CF8B30
	private static ActorID CalcLottery() { }

	// RVA: 0x1CF8ED0 Offset: 0x1CF8FD1 VA: 0x1CF8ED0
	public static int DoLotteryNPC(DualWorkType workType) { }

	// RVA: 0x1CF9360 Offset: 0x1CF9461 VA: 0x1CF9360
	private static void .cctor() { }
}

public static class DualWorkManager // TypeDefIndex: 10386
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x181640 Offset: 0x181741 VA: 0x181640
	private static DualWorkType <WorkType>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x181650 Offset: 0x181751 VA: 0x181650
	private static ActorID <SubActor>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x181660 Offset: 0x181761 VA: 0x181660
	private static int <LoveLevel>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x181670 Offset: 0x181771 VA: 0x181670
	private static ItemData[] <DualworkTmp>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x181680 Offset: 0x181781 VA: 0x181680
	private static DualWorkObject <DualWorkObject>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x181690 Offset: 0x181791 VA: 0x181690
	private static UnityAction<bool> <EndCallBack>k__BackingField; // 0x20
	public static DualWorkManager.CraftInfoData CraftInfo; // 0x28
	private static readonly ActorID[] LotteryBase; // 0x40

	// Properties
	public static DualWorkType WorkType { get; set; }
	public static ActorID SubActor { get; set; }
	public static int LoveLevel { get; set; }
	public static ItemData[] DualworkTmp { get; set; }
	private static DualWorkObject DualWorkObject { get; set; }
	private static UnityAction<bool> EndCallBack { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AEE00 Offset: 0x1AEF01 VA: 0x1AEE00
	// RVA: 0x1CF6930 Offset: 0x1CF6A31 VA: 0x1CF6930
	public static DualWorkType get_WorkType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE10 Offset: 0x1AEF11 VA: 0x1AEE10
	// RVA: 0x1CF69A0 Offset: 0x1CF6AA1 VA: 0x1CF69A0
	public static void set_WorkType(DualWorkType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE20 Offset: 0x1AEF21 VA: 0x1AEE20
	// RVA: 0x1CF6A10 Offset: 0x1CF6B11 VA: 0x1CF6A10
	public static ActorID get_SubActor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE30 Offset: 0x1AEF31 VA: 0x1AEE30
	// RVA: 0x1CF6A80 Offset: 0x1CF6B81 VA: 0x1CF6A80
	public static void set_SubActor(ActorID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE40 Offset: 0x1AEF41 VA: 0x1AEE40
	// RVA: 0x1CF6AF0 Offset: 0x1CF6BF1 VA: 0x1CF6AF0
	public static int get_LoveLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE50 Offset: 0x1AEF51 VA: 0x1AEE50
	// RVA: 0x1CF6B60 Offset: 0x1CF6C61 VA: 0x1CF6B60
	public static void set_LoveLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE60 Offset: 0x1AEF61 VA: 0x1AEE60
	// RVA: 0x1CF6BD0 Offset: 0x1CF6CD1 VA: 0x1CF6BD0
	public static ItemData[] get_DualworkTmp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE70 Offset: 0x1AEF71 VA: 0x1AEE70
	// RVA: 0x1CF6C40 Offset: 0x1CF6D41 VA: 0x1CF6C40
	public static void set_DualworkTmp(ItemData[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE80 Offset: 0x1AEF81 VA: 0x1AEE80
	// RVA: 0x1CF6CB0 Offset: 0x1CF6DB1 VA: 0x1CF6CB0
	private static DualWorkObject get_DualWorkObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE90 Offset: 0x1AEF91 VA: 0x1AEE90
	// RVA: 0x1CF6D20 Offset: 0x1CF6E21 VA: 0x1CF6D20
	private static void set_DualWorkObject(DualWorkObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEA0 Offset: 0x1AEFA1 VA: 0x1AEEA0
	// RVA: 0x1CF6D90 Offset: 0x1CF6E91 VA: 0x1CF6D90
	private static UnityAction<bool> get_EndCallBack() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEB0 Offset: 0x1AEFB1 VA: 0x1AEEB0
	// RVA: 0x1CF6E00 Offset: 0x1CF6F01 VA: 0x1CF6E00
	private static void set_EndCallBack(UnityAction<bool> value) { }

	// RVA: 0x1CF6E70 Offset: 0x1CF6F71 VA: 0x1CF6E70
	public static void StartDualWork(DualWorkObject dualWorkObject, ActorID subActor, int loveLevel, UnityAction<bool> endCallBack) { }

	// RVA: 0x1CF78D0 Offset: 0x1CF79D1 VA: 0x1CF78D0
	private static void CloseUICraft() { }

	// RVA: 0x1CF7BB0 Offset: 0x1CF7CB1 VA: 0x1CF7BB0
	private static void OnEndMiniGame(bool isSuccess) { }

	// RVA: 0x1CF64E0 Offset: 0x1CF65E1 VA: 0x1CF64E0
	public static string GetDualWorkTypeScreenName(DualWorkType type) { }

	// RVA: 0x1CF8320 Offset: 0x1CF8421 VA: 0x1CF8320
	public static string GetDualWorkTypeForScript(DualWorkType type) { }

	// RVA: 0x1CF8390 Offset: 0x1CF8491 VA: 0x1CF8390
	public static RF5SaveData.FLAG GetDualworkDoneFlagID(DualWorkType type) { }

	// RVA: 0x1CF83B0 Offset: 0x1CF84B1 VA: 0x1CF83B0
	public static string GetCurrentDualWorkName() { }

	// RVA: 0x1CF8290 Offset: 0x1CF8391 VA: 0x1CF8290
	public static void DoneDualWork(DualWorkType type) { }

	// RVA: 0x1CF8570 Offset: 0x1CF8671 VA: 0x1CF8570
	public static void DoneDualWork() { }

	// RVA: 0x1CF8640 Offset: 0x1CF8741 VA: 0x1CF8640
	public static bool IsDoneDualWork(DualWorkType currentDualTypeWork) { }

	// RVA: 0x1CF86D0 Offset: 0x1CF87D1 VA: 0x1CF86D0
	public static void ApplySmith(ItemData itemData) { }

	// RVA: 0x1CF89D0 Offset: 0x1CF8AD1 VA: 0x1CF89D0
	public static int GetMaxLoveLevel() { }

	// RVA: 0x1CF8B30 Offset: 0x1CF8C31 VA: 0x1CF8B30
	private static ActorID CalcLottery() { }

	// RVA: 0x1CF8ED0 Offset: 0x1CF8FD1 VA: 0x1CF8ED0
	public static int DoLotteryNPC(DualWorkType workType) { }

	// RVA: 0x1CF9360 Offset: 0x1CF9461 VA: 0x1CF9360
	private static void .cctor() { }
}

public static class DualWorkManager // TypeDefIndex: 10386
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x181640 Offset: 0x181741 VA: 0x181640
	private static DualWorkType <WorkType>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x181650 Offset: 0x181751 VA: 0x181650
	private static ActorID <SubActor>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x181660 Offset: 0x181761 VA: 0x181660
	private static int <LoveLevel>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x181670 Offset: 0x181771 VA: 0x181670
	private static ItemData[] <DualworkTmp>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x181680 Offset: 0x181781 VA: 0x181680
	private static DualWorkObject <DualWorkObject>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x181690 Offset: 0x181791 VA: 0x181690
	private static UnityAction<bool> <EndCallBack>k__BackingField; // 0x20
	public static DualWorkManager.CraftInfoData CraftInfo; // 0x28
	private static readonly ActorID[] LotteryBase; // 0x40

	// Properties
	public static DualWorkType WorkType { get; set; }
	public static ActorID SubActor { get; set; }
	public static int LoveLevel { get; set; }
	public static ItemData[] DualworkTmp { get; set; }
	private static DualWorkObject DualWorkObject { get; set; }
	private static UnityAction<bool> EndCallBack { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AEE00 Offset: 0x1AEF01 VA: 0x1AEE00
	// RVA: 0x1CF6930 Offset: 0x1CF6A31 VA: 0x1CF6930
	public static DualWorkType get_WorkType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE10 Offset: 0x1AEF11 VA: 0x1AEE10
	// RVA: 0x1CF69A0 Offset: 0x1CF6AA1 VA: 0x1CF69A0
	public static void set_WorkType(DualWorkType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE20 Offset: 0x1AEF21 VA: 0x1AEE20
	// RVA: 0x1CF6A10 Offset: 0x1CF6B11 VA: 0x1CF6A10
	public static ActorID get_SubActor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE30 Offset: 0x1AEF31 VA: 0x1AEE30
	// RVA: 0x1CF6A80 Offset: 0x1CF6B81 VA: 0x1CF6A80
	public static void set_SubActor(ActorID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE40 Offset: 0x1AEF41 VA: 0x1AEE40
	// RVA: 0x1CF6AF0 Offset: 0x1CF6BF1 VA: 0x1CF6AF0
	public static int get_LoveLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE50 Offset: 0x1AEF51 VA: 0x1AEE50
	// RVA: 0x1CF6B60 Offset: 0x1CF6C61 VA: 0x1CF6B60
	public static void set_LoveLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE60 Offset: 0x1AEF61 VA: 0x1AEE60
	// RVA: 0x1CF6BD0 Offset: 0x1CF6CD1 VA: 0x1CF6BD0
	public static ItemData[] get_DualworkTmp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE70 Offset: 0x1AEF71 VA: 0x1AEE70
	// RVA: 0x1CF6C40 Offset: 0x1CF6D41 VA: 0x1CF6C40
	public static void set_DualworkTmp(ItemData[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE80 Offset: 0x1AEF81 VA: 0x1AEE80
	// RVA: 0x1CF6CB0 Offset: 0x1CF6DB1 VA: 0x1CF6CB0
	private static DualWorkObject get_DualWorkObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE90 Offset: 0x1AEF91 VA: 0x1AEE90
	// RVA: 0x1CF6D20 Offset: 0x1CF6E21 VA: 0x1CF6D20
	private static void set_DualWorkObject(DualWorkObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEA0 Offset: 0x1AEFA1 VA: 0x1AEEA0
	// RVA: 0x1CF6D90 Offset: 0x1CF6E91 VA: 0x1CF6D90
	private static UnityAction<bool> get_EndCallBack() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEB0 Offset: 0x1AEFB1 VA: 0x1AEEB0
	// RVA: 0x1CF6E00 Offset: 0x1CF6F01 VA: 0x1CF6E00
	private static void set_EndCallBack(UnityAction<bool> value) { }

	// RVA: 0x1CF6E70 Offset: 0x1CF6F71 VA: 0x1CF6E70
	public static void StartDualWork(DualWorkObject dualWorkObject, ActorID subActor, int loveLevel, UnityAction<bool> endCallBack) { }

	// RVA: 0x1CF78D0 Offset: 0x1CF79D1 VA: 0x1CF78D0
	private static void CloseUICraft() { }

	// RVA: 0x1CF7BB0 Offset: 0x1CF7CB1 VA: 0x1CF7BB0
	private static void OnEndMiniGame(bool isSuccess) { }

	// RVA: 0x1CF64E0 Offset: 0x1CF65E1 VA: 0x1CF64E0
	public static string GetDualWorkTypeScreenName(DualWorkType type) { }

	// RVA: 0x1CF8320 Offset: 0x1CF8421 VA: 0x1CF8320
	public static string GetDualWorkTypeForScript(DualWorkType type) { }

	// RVA: 0x1CF8390 Offset: 0x1CF8491 VA: 0x1CF8390
	public static RF5SaveData.FLAG GetDualworkDoneFlagID(DualWorkType type) { }

	// RVA: 0x1CF83B0 Offset: 0x1CF84B1 VA: 0x1CF83B0
	public static string GetCurrentDualWorkName() { }

	// RVA: 0x1CF8290 Offset: 0x1CF8391 VA: 0x1CF8290
	public static void DoneDualWork(DualWorkType type) { }

	// RVA: 0x1CF8570 Offset: 0x1CF8671 VA: 0x1CF8570
	public static void DoneDualWork() { }

	// RVA: 0x1CF8640 Offset: 0x1CF8741 VA: 0x1CF8640
	public static bool IsDoneDualWork(DualWorkType currentDualTypeWork) { }

	// RVA: 0x1CF86D0 Offset: 0x1CF87D1 VA: 0x1CF86D0
	public static void ApplySmith(ItemData itemData) { }

	// RVA: 0x1CF89D0 Offset: 0x1CF8AD1 VA: 0x1CF89D0
	public static int GetMaxLoveLevel() { }

	// RVA: 0x1CF8B30 Offset: 0x1CF8C31 VA: 0x1CF8B30
	private static ActorID CalcLottery() { }

	// RVA: 0x1CF8ED0 Offset: 0x1CF8FD1 VA: 0x1CF8ED0
	public static int DoLotteryNPC(DualWorkType workType) { }

	// RVA: 0x1CF9360 Offset: 0x1CF9461 VA: 0x1CF9360
	private static void .cctor() { }
}

public static class DualWorkManager // TypeDefIndex: 10386
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x181640 Offset: 0x181741 VA: 0x181640
	private static DualWorkType <WorkType>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x181650 Offset: 0x181751 VA: 0x181650
	private static ActorID <SubActor>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x181660 Offset: 0x181761 VA: 0x181660
	private static int <LoveLevel>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x181670 Offset: 0x181771 VA: 0x181670
	private static ItemData[] <DualworkTmp>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x181680 Offset: 0x181781 VA: 0x181680
	private static DualWorkObject <DualWorkObject>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x181690 Offset: 0x181791 VA: 0x181690
	private static UnityAction<bool> <EndCallBack>k__BackingField; // 0x20
	public static DualWorkManager.CraftInfoData CraftInfo; // 0x28
	private static readonly ActorID[] LotteryBase; // 0x40

	// Properties
	public static DualWorkType WorkType { get; set; }
	public static ActorID SubActor { get; set; }
	public static int LoveLevel { get; set; }
	public static ItemData[] DualworkTmp { get; set; }
	private static DualWorkObject DualWorkObject { get; set; }
	private static UnityAction<bool> EndCallBack { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AEE00 Offset: 0x1AEF01 VA: 0x1AEE00
	// RVA: 0x1CF6930 Offset: 0x1CF6A31 VA: 0x1CF6930
	public static DualWorkType get_WorkType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE10 Offset: 0x1AEF11 VA: 0x1AEE10
	// RVA: 0x1CF69A0 Offset: 0x1CF6AA1 VA: 0x1CF69A0
	public static void set_WorkType(DualWorkType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE20 Offset: 0x1AEF21 VA: 0x1AEE20
	// RVA: 0x1CF6A10 Offset: 0x1CF6B11 VA: 0x1CF6A10
	public static ActorID get_SubActor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE30 Offset: 0x1AEF31 VA: 0x1AEE30
	// RVA: 0x1CF6A80 Offset: 0x1CF6B81 VA: 0x1CF6A80
	public static void set_SubActor(ActorID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE40 Offset: 0x1AEF41 VA: 0x1AEE40
	// RVA: 0x1CF6AF0 Offset: 0x1CF6BF1 VA: 0x1CF6AF0
	public static int get_LoveLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE50 Offset: 0x1AEF51 VA: 0x1AEE50
	// RVA: 0x1CF6B60 Offset: 0x1CF6C61 VA: 0x1CF6B60
	public static void set_LoveLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE60 Offset: 0x1AEF61 VA: 0x1AEE60
	// RVA: 0x1CF6BD0 Offset: 0x1CF6CD1 VA: 0x1CF6BD0
	public static ItemData[] get_DualworkTmp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE70 Offset: 0x1AEF71 VA: 0x1AEE70
	// RVA: 0x1CF6C40 Offset: 0x1CF6D41 VA: 0x1CF6C40
	public static void set_DualworkTmp(ItemData[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE80 Offset: 0x1AEF81 VA: 0x1AEE80
	// RVA: 0x1CF6CB0 Offset: 0x1CF6DB1 VA: 0x1CF6CB0
	private static DualWorkObject get_DualWorkObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEE90 Offset: 0x1AEF91 VA: 0x1AEE90
	// RVA: 0x1CF6D20 Offset: 0x1CF6E21 VA: 0x1CF6D20
	private static void set_DualWorkObject(DualWorkObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEA0 Offset: 0x1AEFA1 VA: 0x1AEEA0
	// RVA: 0x1CF6D90 Offset: 0x1CF6E91 VA: 0x1CF6D90
	private static UnityAction<bool> get_EndCallBack() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEB0 Offset: 0x1AEFB1 VA: 0x1AEEB0
	// RVA: 0x1CF6E00 Offset: 0x1CF6F01 VA: 0x1CF6E00
	private static void set_EndCallBack(UnityAction<bool> value) { }

	// RVA: 0x1CF6E70 Offset: 0x1CF6F71 VA: 0x1CF6E70
	public static void StartDualWork(DualWorkObject dualWorkObject, ActorID subActor, int loveLevel, UnityAction<bool> endCallBack) { }

	// RVA: 0x1CF78D0 Offset: 0x1CF79D1 VA: 0x1CF78D0
	private static void CloseUICraft() { }

	// RVA: 0x1CF7BB0 Offset: 0x1CF7CB1 VA: 0x1CF7BB0
	private static void OnEndMiniGame(bool isSuccess) { }

	// RVA: 0x1CF64E0 Offset: 0x1CF65E1 VA: 0x1CF64E0
	public static string GetDualWorkTypeScreenName(DualWorkType type) { }

	// RVA: 0x1CF8320 Offset: 0x1CF8421 VA: 0x1CF8320
	public static string GetDualWorkTypeForScript(DualWorkType type) { }

	// RVA: 0x1CF8390 Offset: 0x1CF8491 VA: 0x1CF8390
	public static RF5SaveData.FLAG GetDualworkDoneFlagID(DualWorkType type) { }

	// RVA: 0x1CF83B0 Offset: 0x1CF84B1 VA: 0x1CF83B0
	public static string GetCurrentDualWorkName() { }

	// RVA: 0x1CF8290 Offset: 0x1CF8391 VA: 0x1CF8290
	public static void DoneDualWork(DualWorkType type) { }

	// RVA: 0x1CF8570 Offset: 0x1CF8671 VA: 0x1CF8570
	public static void DoneDualWork() { }

	// RVA: 0x1CF8640 Offset: 0x1CF8741 VA: 0x1CF8640
	public static bool IsDoneDualWork(DualWorkType currentDualTypeWork) { }

	// RVA: 0x1CF86D0 Offset: 0x1CF87D1 VA: 0x1CF86D0
	public static void ApplySmith(ItemData itemData) { }

	// RVA: 0x1CF89D0 Offset: 0x1CF8AD1 VA: 0x1CF89D0
	public static int GetMaxLoveLevel() { }

	// RVA: 0x1CF8B30 Offset: 0x1CF8C31 VA: 0x1CF8B30
	private static ActorID CalcLottery() { }

	// RVA: 0x1CF8ED0 Offset: 0x1CF8FD1 VA: 0x1CF8ED0
	public static int DoLotteryNPC(DualWorkType workType) { }

	// RVA: 0x1CF9360 Offset: 0x1CF9461 VA: 0x1CF9360
	private static void .cctor() { }
}

