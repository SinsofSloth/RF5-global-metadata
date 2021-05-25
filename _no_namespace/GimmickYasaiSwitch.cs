public class GimmickYasaiSwitch : GimmickBase, ItemInteractionInterface, FocusInterface, InteractionInterface // TypeDefIndex: 7597
{
	// Fields
	[SerializeField] // RVA: 0x167F80 Offset: 0x168081 VA: 0x167F80
	private string KeyItemID; // 0x20
	[SerializeField] // RVA: 0x167F90 Offset: 0x168091 VA: 0x167F90
	private ItemID _ItemID; // 0x28
	[SerializeField] // RVA: 0x167FA0 Offset: 0x1680A1 VA: 0x167FA0
	private GimmickLayoutID[] _TargetGimmickLayoutIDs; // 0x30
	[SerializeField] // RVA: 0x167FB0 Offset: 0x1680B1 VA: 0x167FB0
	private bool[] _TargetValueInverts; // 0x38
	public OnChangeGimmickSwitch OnChangeGimmickSwitch; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0x167FC0 Offset: 0x1680C1 VA: 0x167FC0
	[SerializeField] // RVA: 0x167FC0 Offset: 0x1680C1 VA: 0x167FC0
	protected string FocusTextID; // 0x48
	[SerializeField] // RVA: 0x168010 Offset: 0x168111 VA: 0x168010
	protected string ButtonGuideTextID; // 0x50
	[SerializeField] // RVA: 0x168020 Offset: 0x168121 VA: 0x168020
	protected string ItemGuideTextID; // 0x58
	protected string FocusText; // 0x60
	protected string ButtonGuideText; // 0x68
	protected string ItemGuideText; // 0x70
	protected Collider SwitchCollider; // 0x78

	// Properties
	private ItemID ItemID { get; }
	private ItemDataTable ItemDataTable { get; }
	public GimmickLayoutID[] TargetGimmickLayoutIDs { get; set; }
	public bool[] TargetValueInverts { get; set; }
	public string ItemInteractionButtonHint { get; }
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x1EAAD00 Offset: 0x1EAAE01 VA: 0x1EAAD00
	private ItemID get_ItemID() { }

	// RVA: 0x1EAAE10 Offset: 0x1EAAF11 VA: 0x1EAAE10
	private ItemDataTable get_ItemDataTable() { }

	// RVA: 0x1EAAE30 Offset: 0x1EAAF31 VA: 0x1EAAE30
	public GimmickLayoutID[] get_TargetGimmickLayoutIDs() { }

	// RVA: 0x1EAAE40 Offset: 0x1EAAF41 VA: 0x1EAAE40
	public void set_TargetGimmickLayoutIDs(GimmickLayoutID[] value) { }

	// RVA: 0x1EAAE50 Offset: 0x1EAAF51 VA: 0x1EAAE50
	public bool[] get_TargetValueInverts() { }

	// RVA: 0x1EAAE60 Offset: 0x1EAAF61 VA: 0x1EAAE60
	private void set_TargetValueInverts(bool[] value) { }

	// RVA: 0x1EAAE70 Offset: 0x1EAAF71 VA: 0x1EAAE70
	public string get_ItemInteractionButtonHint() { }

	// RVA: 0x1EAAE80 Offset: 0x1EAAF81 VA: 0x1EAAE80 Slot: 9
	public override void Init() { }

	// RVA: 0x1EAB5C0 Offset: 0x1EAB6C1 VA: 0x1EAB5C0 Slot: 15
	public bool get_Focusable() { }

	// RVA: 0x1EAB620 Offset: 0x1EAB721 VA: 0x1EAB620 Slot: 18
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1EAB630 Offset: 0x1EAB731 VA: 0x1EAB630 Slot: 19
	public int get_FocusPriority() { }

	// RVA: 0x1EAB640 Offset: 0x1EAB741 VA: 0x1EAB640 Slot: 20
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1EAB650 Offset: 0x1EAB751 VA: 0x1EAB650 Slot: 25
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1EAB6B0 Offset: 0x1EAB7B1 VA: 0x1EAB6B0 Slot: 12
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	// RVA: 0x1EAB730 Offset: 0x1EAB831 VA: 0x1EAB730 Slot: 24
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1EAB800 Offset: 0x1EAB901 VA: 0x1EAB800 Slot: 11
	public void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1F40 Offset: 0x1A2041 VA: 0x1A1F40
	// RVA: 0x1EAB980 Offset: 0x1EABA81 VA: 0x1EAB980
	private IEnumerator WaitEventEnd() { }

	// RVA: 0x1EAB360 Offset: 0x1EAB461 VA: 0x1EAB360
	public void SetSwitchState(bool newState, bool setFlag, bool immediate) { }

	// RVA: 0x1EABA30 Offset: 0x1EABB31 VA: 0x1EABA30 Slot: 14
	public string GetFocusName() { }

	// RVA: 0x1EABA40 Offset: 0x1EABB41 VA: 0x1EABA40 Slot: 28
	public string GetInteractionButtonHint() { }

	// RVA: 0x1EABA50 Offset: 0x1EABB51 VA: 0x1EABA50 Slot: 17
	public void OffFocus() { }

	// RVA: 0x1EABA60 Offset: 0x1EABB61 VA: 0x1EABA60 Slot: 16
	public void OnFocus() { }

	// RVA: 0x1EABA70 Offset: 0x1EABB71 VA: 0x1EABA70 Slot: 21
	public ushort GetInteractionType() { }

	// RVA: 0x1EABBE0 Offset: 0x1EABCE1 VA: 0x1EABBE0 Slot: 13
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData) { }

	// RVA: 0x1EABBF0 Offset: 0x1EABCF1 VA: 0x1EABBF0 Slot: 26
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1EABC00 Offset: 0x1EABD01 VA: 0x1EABC00 Slot: 27
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1EABC10 Offset: 0x1EABD11 VA: 0x1EABC10
	public void .ctor() { }

	// RVA: 0x1EABD20 Offset: 0x1EABE21 VA: 0x1EABD20 Slot: 22
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1EABD30 Offset: 0x1EABE31 VA: 0x1EABD30 Slot: 23
	private Transform FocusInterface.get_transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1FB0 Offset: 0x1A20B1 VA: 0x1A1FB0
	[DebuggerHiddenAttribute] // RVA: 0x1A1FB0 Offset: 0x1A20B1 VA: 0x1A1FB0
	// RVA: 0x1EABD40 Offset: 0x1EABE41 VA: 0x1EABD40
	private void <>n__0(bool newState) { }
}

