public class AS_ToolController.ToolActionData // TypeDefIndex: 6163
{
	// Fields
	public bool IsEnable; // 0x10
	public ItemData itemData; // 0x18
	public List<ItemEquip> itemEquips; // 0x20
	public List<AS_ToolController.ChargeInfo> chargeInfoList; // 0x28
	public FarmAction chargeFarmAction; // 0x30
	public float chargeTime; // 0x34
	public ToolChargeLevel ActionChargeLevel; // 0x38
	public string actScriptName; // 0x40
	public string avoidScriptName; // 0x48
	public MagicID[] magicIDs; // 0x50
	public HumanMotionType HumanMotionType; // 0x58
	public int ComboNum; // 0x5C
	[CompilerGeneratedAttribute] // RVA: 0x195460 Offset: 0x195561 VA: 0x195460
	private bool <IsPush>k__BackingField; // 0x60
	public bool IsCanNext; // 0x61
	public bool IsInputAccept; // 0x62
	public int NextPressCount; // 0x64
	public int RequestPressCount; // 0x68
	public bool IsDamageCheckAccept; // 0x6C
	public bool IsDamageCheckAcceptAngle; // 0x6D
	public float DamageCheckAcceptAngle; // 0x70
	public bool IsHitCheckAccept; // 0x74

	// Properties
	public bool IsPush { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1B04F0 Offset: 0x1B05F1 VA: 0x1B04F0
	// RVA: 0x1E74630 Offset: 0x1E74731 VA: 0x1E74630
	public bool get_IsPush() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B0500 Offset: 0x1B0601 VA: 0x1B0500
	// RVA: 0x1E74640 Offset: 0x1E74741 VA: 0x1E74640
	public void set_IsPush(bool value) { }

	// RVA: 0x1E67F50 Offset: 0x1E68051 VA: 0x1E67F50
	public void .ctor() { }
}

