[MessagePackObjectAttribute] // RVA: 0x1468B0 Offset: 0x1469B1 VA: 0x1468B0
public class EquipItemData : SynthesisItemData // TypeDefIndex: 8207
{
	// Fields
	public const int UpgradeMax = 9;
	public const int ArrangeLength = 3;
	[KeyAttribute] // RVA: 0x16B970 Offset: 0x16BA71 VA: 0x16B970
	public ItemID[] AddedItems; // 0x28
	[KeyAttribute] // RVA: 0x16B990 Offset: 0x16BA91 VA: 0x16B990
	public ItemID[] ArrangeItems; // 0x30
	[KeyAttribute] // RVA: 0x16B9B0 Offset: 0x16BAB1 VA: 0x16B9B0
	public ItemID ArrangeOverride; // 0x38
	[KeyAttribute] // RVA: 0x16B9D0 Offset: 0x16BAD1 VA: 0x16B9D0
	public int BaseLevel; // 0x3C
	[KeyAttribute] // RVA: 0x16B9F0 Offset: 0x16BAF1 VA: 0x16B9F0
	public int SozaiLevel; // 0x40
	[KeyAttribute] // RVA: 0x16BA10 Offset: 0x16BB11 VA: 0x16BA10
	public DualSmithActorDataTable.LotteryType DualWorkSmithBonusType; // 0x44
	[KeyAttribute] // RVA: 0x16BA30 Offset: 0x16BB31 VA: 0x16BA30
	public int DualWorkLoveLevel; // 0x48
	[KeyAttribute] // RVA: 0x16BA50 Offset: 0x16BB51 VA: 0x16BA50
	public ActorID DualWorkActor; // 0x4C
	[KeyAttribute] // RVA: 0x16BA70 Offset: 0x16BB71 VA: 0x16BA70
	public int DualWorkParam; // 0x50
	private static Dictionary<ItemID, int> SameItemNum; // 0x0
	[TupleElementNamesAttribute] // RVA: 0x16BA90 Offset: 0x16BB91 VA: 0x16BA90
	private static List<ValueTuple<bool, ItemID>> ItemStrengtheningList; // 0x8

	// Properties
	[IgnoreMemberAttribute] // RVA: 0x1B9060 Offset: 0x1B9161 VA: 0x1B9060
	public ItemID BaseItemID { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9070 Offset: 0x1B9171 VA: 0x1B9070
	public bool DoneDualSmith { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9080 Offset: 0x1B9181 VA: 0x1B9080
	public override int ItemLevel { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B9090 Offset: 0x1B9191 VA: 0x1B9090
	public override int FreeSpace { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B90A0 Offset: 0x1B91A1 VA: 0x1B90A0
	public override int SortValue { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B90B0 Offset: 0x1B91B1 VA: 0x1B90B0
	public virtual int CalcAttack { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B90C0 Offset: 0x1B91C1 VA: 0x1B90C0
	public virtual int CalcDefense { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B90D0 Offset: 0x1B91D1 VA: 0x1B90D0
	public virtual int CalcMagicAttack { get; }
	[IgnoreMemberAttribute] // RVA: 0x1B90E0 Offset: 0x1B91E1 VA: 0x1B90E0
	public virtual int CalcMagicDefense { get; }

	// Methods

	// RVA: 0x2021B80 Offset: 0x2021C81 VA: 0x2021B80
	public ItemID get_BaseItemID() { }

	// RVA: 0x2021BA0 Offset: 0x2021CA1 VA: 0x2021BA0
	public bool get_DoneDualSmith() { }

	// RVA: 0x2021BE0 Offset: 0x2021CE1 VA: 0x2021BE0 Slot: 10
	public override ItemData Copy() { }

	// RVA: 0x2021CE0 Offset: 0x2021DE1 VA: 0x2021CE0 Slot: 14
	public override Parameter CalcParameter() { }

	// RVA: 0x2022AB0 Offset: 0x2022BB1 VA: 0x2022AB0
	public ValueTuple<float, MagicID[]> CaclMagicIDs() { }

	// RVA: 0x2022F20 Offset: 0x2023021 VA: 0x2022F20 Slot: 5
	public override int get_ItemLevel() { }

	// RVA: 0x2022F30 Offset: 0x2023031 VA: 0x2022F30 Slot: 6
	public override int get_FreeSpace() { }

	// RVA: 0x2022F40 Offset: 0x2023041 VA: 0x2022F40 Slot: 7
	public override int get_SortValue() { }

	// RVA: 0x2022F50 Offset: 0x2023051 VA: 0x2022F50 Slot: 18
	public override bool CheckIsArrenge() { }

	// RVA: 0x2022FA0 Offset: 0x20230A1 VA: 0x2022FA0 Slot: 19
	public virtual int get_CalcAttack() { }

	// RVA: 0x2022FD0 Offset: 0x20230D1 VA: 0x2022FD0 Slot: 20
	public virtual int get_CalcDefense() { }

	// RVA: 0x2023000 Offset: 0x2023101 VA: 0x2023000 Slot: 21
	public virtual int get_CalcMagicAttack() { }

	// RVA: 0x2023030 Offset: 0x2023131 VA: 0x2023030 Slot: 22
	public virtual int get_CalcMagicDefense() { }

	// RVA: 0x2023060 Offset: 0x2023161 VA: 0x2023060
	public void .ctor() { }

	// RVA: 0x20230F0 Offset: 0x20231F1 VA: 0x20230F0
	private static void .cctor() { }
}

