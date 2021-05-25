public class PartnerNPCController : HumanController, InteractionInterface, FocusInterface, ItemInteractionInterface // TypeDefIndex: 6767
{
	// Fields
	[HeaderAttribute] // RVA: 0x15F4E0 Offset: 0x15F5E1 VA: 0x15F4E0
	[SerializeField] // RVA: 0x15F4E0 Offset: 0x15F5E1 VA: 0x15F4E0
	public NPCID m_CharaID; // 0x238
	[SerializeField] // RVA: 0x15F530 Offset: 0x15F631 VA: 0x15F530
	private HumanDualSkillGaugeObserve m_DualSkillGaugeObserve; // 0x240
	[CompilerGeneratedAttribute] // RVA: 0x15F540 Offset: 0x15F641 VA: 0x15F540
	private NpcData <NPCData>k__BackingField; // 0x248
	[CompilerGeneratedAttribute] // RVA: 0x15F550 Offset: 0x15F651 VA: 0x15F550
	private NPCBehaviorDataTable <NPCBehaviorDataTable>k__BackingField; // 0x250
	[CompilerGeneratedAttribute] // RVA: 0x15F560 Offset: 0x15F661 VA: 0x15F560
	private PartnerNPCWeaponBehaviorDataTable <CurrentEquipWeaponDataTable>k__BackingField; // 0x258
	private string FocusName; // 0x268
	protected AS_ToolController EquiptToolActionScriptsController; // 0x270
	private PartnerNPCEventReceiverInterface Receiver; // 0x278
	protected string CurrentActionScriptName; // 0x280
	public bool focusable; // 0x288

	// Properties
	public NpcData NPCData { get; set; }
	public NPCBehaviorDataTable NPCBehaviorDataTable { get; set; }
	public PartnerNPCWeaponBehaviorDataTable CurrentEquipWeaponDataTable { get; set; }
	protected override bool UseGravityOnNavMeshEnabled { get; }
	public bool Focusable { get; set; }
	public string ItemInteractionButtonHint { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19CD70 Offset: 0x19CE71 VA: 0x19CD70
	// RVA: 0x1FDB530 Offset: 0x1FDB631 VA: 0x1FDB530
	public NpcData get_NPCData() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CD80 Offset: 0x19CE81 VA: 0x19CD80
	// RVA: 0x1FDB540 Offset: 0x1FDB641 VA: 0x1FDB540
	protected void set_NPCData(NpcData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CD90 Offset: 0x19CE91 VA: 0x19CD90
	// RVA: 0x1FDB550 Offset: 0x1FDB651 VA: 0x1FDB550
	public NPCBehaviorDataTable get_NPCBehaviorDataTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CDA0 Offset: 0x19CEA1 VA: 0x19CDA0
	// RVA: 0x1FDB560 Offset: 0x1FDB661 VA: 0x1FDB560
	protected void set_NPCBehaviorDataTable(NPCBehaviorDataTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CDB0 Offset: 0x19CEB1 VA: 0x19CDB0
	// RVA: 0x1FDB570 Offset: 0x1FDB671 VA: 0x1FDB570
	public PartnerNPCWeaponBehaviorDataTable get_CurrentEquipWeaponDataTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CDC0 Offset: 0x19CEC1 VA: 0x19CDC0
	// RVA: 0x1FDB580 Offset: 0x1FDB681 VA: 0x1FDB580
	protected void set_CurrentEquipWeaponDataTable(PartnerNPCWeaponBehaviorDataTable value) { }

	// RVA: 0x1FDB590 Offset: 0x1FDB691 VA: 0x1FDB590 Slot: 39
	protected override bool get_UseGravityOnNavMeshEnabled() { }

	// RVA: 0x1FDB5A0 Offset: 0x1FDB6A1 VA: 0x1FDB5A0
	public void SetReceiver(PartnerNPCEventReceiverInterface receiver) { }

	// RVA: 0x1FDB5B0 Offset: 0x1FDB6B1 VA: 0x1FDB5B0
	public void SetNPCData(NpcData nPCData) { }

	// RVA: 0x1FDB6D0 Offset: 0x1FDB7D1 VA: 0x1FDB6D0 Slot: 88
	public override void ResetEquip(bool force = False) { }

	// RVA: 0x1FDB8D0 Offset: 0x1FDB9D1 VA: 0x1FDB8D0
	public void SetupPartner() { }

	// RVA: 0x1FDBDE0 Offset: 0x1FDBEE1 VA: 0x1FDBDE0
	public void SetActionScript(string actionScriptName) { }

	// RVA: 0x1FDBE30 Offset: 0x1FDBF31 VA: 0x1FDBE30
	public void DoActionScript() { }

	// RVA: 0x1FDB990 Offset: 0x1FDBA91 VA: 0x1FDB990
	public void SetupActionEvent() { }

	// RVA: 0x1FDBE60 Offset: 0x1FDBF61 VA: 0x1FDBE60 Slot: 11
	protected override void Awake() { }

	// RVA: 0x1FDBE70 Offset: 0x1FDBF71 VA: 0x1FDBE70 Slot: 12
	protected override void Start() { }

	// RVA: 0x1FDBEC0 Offset: 0x1FDBFC1 VA: 0x1FDBEC0 Slot: 40
	protected override void Update() { }

	// RVA: 0x1FDC120 Offset: 0x1FDC221 VA: 0x1FDC120 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x1FDC2F0 Offset: 0x1FDC3F1 VA: 0x1FDC2F0 Slot: 67
	public override void OnPlayDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x1FDC4E0 Offset: 0x1FDC5E1 VA: 0x1FDC4E0 Slot: 69
	public override void OnAfterDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x1FDC690 Offset: 0x1FDC791 VA: 0x1FDC690 Slot: 65
	public override void OnBadStatus(BadStatus badStatus, bool isEnable) { }

	// RVA: 0x1FDC780 Offset: 0x1FDC881 VA: 0x1FDC780 Slot: 18
	public override void OnSwitchActorBase(bool on) { }

	// RVA: 0x1FDC8D0 Offset: 0x1FDC9D1 VA: 0x1FDC8D0 Slot: 101
	public string GetInteractionButtonHint() { }

	// RVA: 0x1FDC920 Offset: 0x1FDCA21 VA: 0x1FDC920 Slot: 98
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1FDCCC0 Offset: 0x1FDCDC1 VA: 0x1FDCCC0 Slot: 97
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1FDCE10 Offset: 0x1FDCF11 VA: 0x1FDCE10 Slot: 102
	public string GetFocusName() { }

	// RVA: 0x1FDCE20 Offset: 0x1FDCF21 VA: 0x1FDCE20 Slot: 103
	public bool get_Focusable() { }

	// RVA: 0x1FDCEB0 Offset: 0x1FDCFB1 VA: 0x1FDCEB0
	private void set_Focusable(bool value) { }

	// RVA: 0x1FDCEC0 Offset: 0x1FDCFC1 VA: 0x1FDCEC0 Slot: 104
	public void OnFocus() { }

	// RVA: 0x1FDCED0 Offset: 0x1FDCFD1 VA: 0x1FDCED0 Slot: 105
	public void OffFocus() { }

	// RVA: 0x1FDCEE0 Offset: 0x1FDCFE1 VA: 0x1FDCEE0 Slot: 109
	public ushort GetInteractionType() { }

	// RVA: 0x1FDD140 Offset: 0x1FDD241 VA: 0x1FDD140
	public string get_ItemInteractionButtonHint() { }

	// RVA: 0x1FDD190 Offset: 0x1FDD291 VA: 0x1FDD190 Slot: 106
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1FDD1A0 Offset: 0x1FDD2A1 VA: 0x1FDD1A0 Slot: 107
	public int get_FocusPriority() { }

	// RVA: 0x1FDD1B0 Offset: 0x1FDD2B1 VA: 0x1FDD1B0 Slot: 108
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1FDCFC0 Offset: 0x1FDD0C1 VA: 0x1FDCFC0 Slot: 113
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x1FDD1C0 Offset: 0x1FDD2C1 VA: 0x1FDD1C0 Slot: 114
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData) { }

	// RVA: 0x1FDD1D0 Offset: 0x1FDD2D1 VA: 0x1FDD1D0 Slot: 112
	public void DoItemInteraction(HumanController causer, ItemData itemData, bool isThrow) { }

	// RVA: 0x1FDD460 Offset: 0x1FDD561 VA: 0x1FDD460
	private bool IsWeapon(ItemCategory itemCategory) { }

	// RVA: 0x1FDD490 Offset: 0x1FDD591 VA: 0x1FDD490 Slot: 99
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1FDD4A0 Offset: 0x1FDD5A1 VA: 0x1FDD4A0 Slot: 100
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1FDD4B0 Offset: 0x1FDD5B1 VA: 0x1FDD4B0
	public void .ctor() { }

	// RVA: 0x1FDD530 Offset: 0x1FDD631 VA: 0x1FDD530 Slot: 110
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1FDD540 Offset: 0x1FDD641 VA: 0x1FDD540 Slot: 111
	private Transform FocusInterface.get_transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CDD0 Offset: 0x19CED1 VA: 0x19CDD0
	// RVA: 0x1FDD550 Offset: 0x1FDD651 VA: 0x1FDD550
	private void <SetupActionEvent>b__26_0() { }
}

