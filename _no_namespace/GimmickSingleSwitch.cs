public class GimmickSingleSwitch : GimmickBase, InteractionInterface, FocusInterface // TypeDefIndex: 7588
{
	// Fields
	[SerializeField] // RVA: 0x1679D0 Offset: 0x167AD1 VA: 0x1679D0
	private bool IsOnce; // 0x1E
	[SerializeField] // RVA: 0x1679E0 Offset: 0x167AE1 VA: 0x1679E0
	private GameObject OnVisible; // 0x20
	[SerializeField] // RVA: 0x1679F0 Offset: 0x167AF1 VA: 0x1679F0
	private GameObject OffVisible; // 0x28
	[SerializeField] // RVA: 0x167A00 Offset: 0x167B01 VA: 0x167A00
	private GimmickLayoutID[] _TargetGimmickLayoutIDs; // 0x30
	[SerializeField] // RVA: 0x167A10 Offset: 0x167B11 VA: 0x167A10
	private bool[] _TargetValueInverts; // 0x38
	[SerializeField] // RVA: 0x167A20 Offset: 0x167B21 VA: 0x167A20
	private GateController[] TriggerGateControllers; // 0x40
	private List<GameObject> TriggerObjects; // 0x48
	[SerializeField] // RVA: 0x167A30 Offset: 0x167B31 VA: 0x167A30
	private BossStageManager[] TriggerStageManagers; // 0x50
	public OnChangeGimmickSwitch OnChangeGimmickSwitch; // 0x58
	[SerializeField] // RVA: 0x167A40 Offset: 0x167B41 VA: 0x167A40
	protected string FoucsNameTextID; // 0x60
	[SerializeField] // RVA: 0x167A50 Offset: 0x167B51 VA: 0x167A50
	protected string ButtonHintNameTextID; // 0x68
	protected string FocusName; // 0x70
	protected string ButtonHintName; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x167A60 Offset: 0x167B61 VA: 0x167A60
	private bool <Appear>k__BackingField; // 0x80

	// Properties
	public GimmickLayoutID[] TargetGimmickLayoutIDs { get; set; }
	public bool[] TargetValueInverts { get; set; }
	public bool Appear { get; set; }
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x1EA6570 Offset: 0x1EA6671 VA: 0x1EA6570
	public GimmickLayoutID[] get_TargetGimmickLayoutIDs() { }

	// RVA: 0x1EA6580 Offset: 0x1EA6681 VA: 0x1EA6580
	public void set_TargetGimmickLayoutIDs(GimmickLayoutID[] value) { }

	// RVA: 0x1EA6590 Offset: 0x1EA6691 VA: 0x1EA6590
	public bool[] get_TargetValueInverts() { }

	// RVA: 0x1EA65A0 Offset: 0x1EA66A1 VA: 0x1EA65A0
	private void set_TargetValueInverts(bool[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1E40 Offset: 0x1A1F41 VA: 0x1A1E40
	// RVA: 0x1EA65B0 Offset: 0x1EA66B1 VA: 0x1EA65B0
	public bool get_Appear() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1E50 Offset: 0x1A1F51 VA: 0x1A1E50
	// RVA: 0x1EA65C0 Offset: 0x1EA66C1 VA: 0x1EA65C0
	private void set_Appear(bool value) { }

	// RVA: 0x1EA65D0 Offset: 0x1EA66D1 VA: 0x1EA65D0 Slot: 6
	protected override void Start() { }

	// RVA: 0x1EA65E0 Offset: 0x1EA66E1 VA: 0x1EA65E0 Slot: 9
	public override void Init() { }

	// RVA: 0x1EA6EB0 Offset: 0x1EA6FB1 VA: 0x1EA6EB0 Slot: 17
	public bool get_Focusable() { }

	// RVA: 0x1EA6EE0 Offset: 0x1EA6FE1 VA: 0x1EA6EE0 Slot: 20
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1EA6EF0 Offset: 0x1EA6FF1 VA: 0x1EA6EF0 Slot: 21
	public int get_FocusPriority() { }

	// RVA: 0x1EA6F00 Offset: 0x1EA7001 VA: 0x1EA6F00 Slot: 22
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1EA6F10 Offset: 0x1EA7011 VA: 0x1EA6F10 Slot: 12
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1EA6F80 Offset: 0x1EA7081 VA: 0x1EA6F80 Slot: 11
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1EA7020 Offset: 0x1EA7121 VA: 0x1EA7020 Slot: 16
	public string GetFocusName() { }

	// RVA: 0x1EA7030 Offset: 0x1EA7131 VA: 0x1EA7030 Slot: 15
	public string GetInteractionButtonHint() { }

	// RVA: 0x1EA7040 Offset: 0x1EA7141 VA: 0x1EA7040 Slot: 19
	public void OffFocus() { }

	// RVA: 0x1EA7050 Offset: 0x1EA7151 VA: 0x1EA7050 Slot: 18
	public void OnFocus() { }

	// RVA: 0x1EA7060 Offset: 0x1EA7161 VA: 0x1EA7060 Slot: 23
	public ushort GetInteractionType() { }

	// RVA: 0x1EA7070 Offset: 0x1EA7171 VA: 0x1EA7070 Slot: 7
	public override void SetGimmickState(bool newState) { }

	// RVA: 0x1EA6BB0 Offset: 0x1EA6CB1 VA: 0x1EA6BB0
	public void SetSwitchState(bool newState, bool setFlag, bool immediate) { }

	// RVA: 0x1EA70B0 Offset: 0x1EA71B1 VA: 0x1EA70B0
	private void OnDestroyGate(GateController gateEnemy) { }

	// RVA: 0x1EA7270 Offset: 0x1EA7371 VA: 0x1EA7270
	private void OnDestroyStageEnemy(BossStageManager bossStage) { }

	// RVA: 0x1EA7140 Offset: 0x1EA7241 VA: 0x1EA7140
	private void DecrementWithCheck() { }

	// RVA: 0x1EA7300 Offset: 0x1EA7401 VA: 0x1EA7300
	private void ApperSwitch() { }

	// RVA: 0x1EA7410 Offset: 0x1EA7511 VA: 0x1EA7410 Slot: 13
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1EA7420 Offset: 0x1EA7521 VA: 0x1EA7420 Slot: 14
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1EA7430 Offset: 0x1EA7531 VA: 0x1EA7430
	public void .ctor() { }

	// RVA: 0x1EA7540 Offset: 0x1EA7641 VA: 0x1EA7540 Slot: 24
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1EA7550 Offset: 0x1EA7651 VA: 0x1EA7550 Slot: 25
	private Transform FocusInterface.get_transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1E60 Offset: 0x1A1F61 VA: 0x1A1E60
	// RVA: 0x1EA7560 Offset: 0x1EA7661 VA: 0x1EA7560
	private void <ApperSwitch>b__45_0() { }
}

