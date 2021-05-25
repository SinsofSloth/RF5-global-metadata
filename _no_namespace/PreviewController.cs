[DefaultExecutionOrder] // RVA: 0x145F50 Offset: 0x146051 VA: 0x145F50
public class PreviewController : HumanController // TypeDefIndex: 6781
{
	// Fields
	private bool m_isBattleMode; // 0x238
	[CompilerGeneratedAttribute] // RVA: 0x15F7D0 Offset: 0x15F8D1 VA: 0x15F7D0
	private float <FadeAlpha>k__BackingField; // 0x23C

	// Properties
	public override Actor Actor { get; }
	public override bool IsBattleMode { get; }
	protected override bool FadeEnable { get; }
	protected virtual float FadeAlpha { get; set; }

	// Methods

	// RVA: 0x1DE9CE0 Offset: 0x1DE9DE1 VA: 0x1DE9CE0 Slot: 16
	public override Actor get_Actor() { }

	// RVA: 0x1DE9D00 Offset: 0x1DE9E01 VA: 0x1DE9D00 Slot: 35
	public override bool get_IsBattleMode() { }

	// RVA: 0x1DE9D10 Offset: 0x1DE9E11 VA: 0x1DE9D10 Slot: 76
	protected override bool get_FadeEnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CF10 Offset: 0x19D011 VA: 0x19CF10
	// RVA: 0x1DE9D20 Offset: 0x1DE9E21 VA: 0x1DE9D20 Slot: 97
	protected virtual float get_FadeAlpha() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CF20 Offset: 0x19D021 VA: 0x19CF20
	// RVA: 0x1DE9D30 Offset: 0x1DE9E31 VA: 0x1DE9D30 Slot: 98
	protected virtual void set_FadeAlpha(float value) { }

	// RVA: 0x1DE9D40 Offset: 0x1DE9E41 VA: 0x1DE9D40 Slot: 18
	public override void OnSwitchActorBase(bool on) { }

	// RVA: 0x1DEA090 Offset: 0x1DEA191 VA: 0x1DEA090 Slot: 11
	protected override void Awake() { }

	// RVA: 0x1DEA0D0 Offset: 0x1DEA1D1 VA: 0x1DEA0D0 Slot: 13
	protected override void OnEnable() { }

	// RVA: 0x1DEA110 Offset: 0x1DEA211 VA: 0x1DEA110 Slot: 40
	protected override void Update() { }

	// RVA: 0x1DEA340 Offset: 0x1DEA441 VA: 0x1DEA340 Slot: 79
	protected override void UpdateLookIK() { }

	// RVA: 0x1DEA440 Offset: 0x1DEA541 VA: 0x1DEA440 Slot: 49
	public override bool InputMove(Vector3 vector) { }

	// RVA: 0x1DEA450 Offset: 0x1DEA551 VA: 0x1DEA450 Slot: 87
	protected override void OnChangeEquip_ForNoticeStatus() { }

	// RVA: 0x1DEA460 Offset: 0x1DEA561 VA: 0x1DEA460 Slot: 62
	public override void SetGrounderIKWeight(float weight) { }

	// RVA: 0x1DEA470 Offset: 0x1DEA571 VA: 0x1DEA470 Slot: 80
	protected override float UpdateArmIKWeight(float currentWeight, bool isArmIk) { }

	// RVA: 0x1DEA520 Offset: 0x1DEA621 VA: 0x1DEA520 Slot: 99
	public virtual void UnEquipAll() { }

	// RVA: 0x1DEA5C0 Offset: 0x1DEA6C1 VA: 0x1DEA5C0
	public void .ctor() { }
}

