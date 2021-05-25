public class SnowmanBox : CharacterBase, FocusInterface // TypeDefIndex: 7495
{
	// Fields
	private const string FoucsNameTextID = "FIELD_LAYOUT_OBJECT_NAME_00007";
	private FieldWoodBoxSpawnID BoxSpawnID; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x166AA0 Offset: 0x166BA1 VA: 0x166AA0
	private ItemLotteryID <ItemLotteryID>k__BackingField; // 0x68
	private bool DoneBroken; // 0x6C
	[SerializeField] // RVA: 0x166AB0 Offset: 0x166BB1 VA: 0x166AB0
	private CapsuleCollider capsule; // 0x70
	private bool IsDamaged; // 0x78

	// Properties
	public ItemLotteryID ItemLotteryID { get; set; }
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A1410 Offset: 0x1A1511 VA: 0x1A1410
	// RVA: 0x210D8D0 Offset: 0x210D9D1 VA: 0x210D8D0
	public ItemLotteryID get_ItemLotteryID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1420 Offset: 0x1A1521 VA: 0x1A1420
	// RVA: 0x210D8E0 Offset: 0x210D9E1 VA: 0x210D8E0
	public void set_ItemLotteryID(ItemLotteryID value) { }

	// RVA: 0x210D8F0 Offset: 0x210D9F1 VA: 0x210D8F0
	public void SetDataID(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x210D900 Offset: 0x210DA01 VA: 0x210D900
	private void OnDestroy() { }

	// RVA: 0x210D9D0 Offset: 0x210DAD1 VA: 0x210D9D0 Slot: 17
	public bool get_Focusable() { }

	// RVA: 0x210DA60 Offset: 0x210DB61 VA: 0x210DA60 Slot: 20
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x210DA70 Offset: 0x210DB71 VA: 0x210DA70 Slot: 21
	public int get_FocusPriority() { }

	// RVA: 0x210DA80 Offset: 0x210DB81 VA: 0x210DA80 Slot: 22
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x210DA90 Offset: 0x210DB91 VA: 0x210DA90 Slot: 16
	public string GetFocusName() { }

	// RVA: 0x210DB80 Offset: 0x210DC81 VA: 0x210DB80
	public string GetInteractionButtonHint() { }

	// RVA: 0x210DBD0 Offset: 0x210DCD1 VA: 0x210DBD0 Slot: 19
	public void OffFocus() { }

	// RVA: 0x210DBE0 Offset: 0x210DCE1 VA: 0x210DBE0 Slot: 18
	public void OnFocus() { }

	// RVA: 0x210DBF0 Offset: 0x210DCF1 VA: 0x210DBF0 Slot: 23
	public ushort GetInteractionType() { }

	// RVA: 0x210DC00 Offset: 0x210DD01 VA: 0x210DC00 Slot: 11
	protected override void Awake() { }

	// RVA: 0x210DCC0 Offset: 0x210DDC1 VA: 0x210DCC0
	private void OnBroken() { }

	// RVA: 0x210DF00 Offset: 0x210E001 VA: 0x210DF00 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage) { }

	// RVA: 0x210DFC0 Offset: 0x210E0C1 VA: 0x210DFC0
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x210E160 Offset: 0x210E261 VA: 0x210E160
	public void .ctor() { }

	// RVA: 0x210E170 Offset: 0x210E271 VA: 0x210E170 Slot: 24
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x210E180 Offset: 0x210E281 VA: 0x210E180 Slot: 25
	private Transform FocusInterface.get_transform() { }
}

