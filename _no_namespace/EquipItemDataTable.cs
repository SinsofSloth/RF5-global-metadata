[Serializable]
public class EquipItemDataTable // TypeDefIndex: 6955
{
	// Fields
	[SerializeField] // RVA: 0x161E00 Offset: 0x161F01 VA: 0x161E00
	public bool Attribute_Fire; // 0x10
	[SerializeField] // RVA: 0x161E10 Offset: 0x161F11 VA: 0x161E10
	public bool Attribute_Water; // 0x11
	[SerializeField] // RVA: 0x161E20 Offset: 0x161F21 VA: 0x161E20
	public bool Attribute_Earth; // 0x12
	[SerializeField] // RVA: 0x161E30 Offset: 0x161F31 VA: 0x161E30
	public bool Attribute_Wind; // 0x13
	[SerializeField] // RVA: 0x161E40 Offset: 0x161F41 VA: 0x161E40
	public bool Attribute_Shine; // 0x14
	[SerializeField] // RVA: 0x161E50 Offset: 0x161F51 VA: 0x161E50
	public bool Attribute_Dark; // 0x15
	[SerializeField] // RVA: 0x161E60 Offset: 0x161F61 VA: 0x161E60
	public bool Attribute_Love; // 0x16
	public Parameter Parameter; // 0x18
	[SerializeField] // RVA: 0x161E70 Offset: 0x161F71 VA: 0x161E70
	public bool IsVisualEquip; // 0xD4
	[SerializeField] // RVA: 0x161E80 Offset: 0x161F81 VA: 0x161E80
	public HumanMotionType MotionType; // 0xD8
	[SerializeField] // RVA: 0x161E90 Offset: 0x161F91 VA: 0x161E90
	public EquipAttach[] AttachData; // 0xE0
	public HumanActionID[] AS_ChargeArray; // 0xE8
	public FarmAction ChargeFarmAction; // 0xF0
	public FarmRange[] FarmRangeArray; // 0xF8
	public HumanActionID[] AS_ItemLevel; // 0x100
	public HumanActionID AS_Avoid; // 0x108
	[SerializeField] // RVA: 0x161EA0 Offset: 0x161FA1 VA: 0x161EA0
	public MagicID[] MagicIDs; // 0x110
	[SerializeField] // RVA: 0x161EB0 Offset: 0x161FB1 VA: 0x161EB0
	public EquipItemFlag EquipItemFlag; // 0x118
	[SerializeField] // RVA: 0x161EC0 Offset: 0x161FC1 VA: 0x161EC0
	public HitSoundID HitSoundID; // 0x11C
	private static EquipItemDataTableArray _EquipItemParamDataTableArray; // 0x0

	// Methods

	// RVA: 0x2022920 Offset: 0x2022A21 VA: 0x2022920
	public static EquipItemDataTable GetDataTable(ItemID itemID) { }

	// RVA: 0x2023310 Offset: 0x2023411 VA: 0x2023310
	public static SerializeEquipItemDataTable[] GetDataTables() { }

	// RVA: 0x2023430 Offset: 0x2023531 VA: 0x2023430
	public static bool HasDataTable(ItemID itemID) { }

	// RVA: 0x2023300 Offset: 0x2023401 VA: 0x2023300
	public void .ctor() { }
}

