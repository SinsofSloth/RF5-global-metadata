public class MobTravelerController : MobController // TypeDefIndex: 6745
{
	// Fields
	[SerializeField] // RVA: 0x15F360 Offset: 0x15F461 VA: 0x15F360
	protected int m_focusNameTextID; // 0x274
	[SerializeField] // RVA: 0x15F370 Offset: 0x15F471 VA: 0x15F370
	protected float m_MoveSpeedRate; // 0x278

	// Properties
	public virtual string Name { get; }
	public override float OnEnableFadeAlpha { get; }

	// Methods

	// RVA: 0x1CBE980 Offset: 0x1CBEA81 VA: 0x1CBE980 Slot: 127
	public virtual string get_Name() { }

	// RVA: 0x1CBEB50 Offset: 0x1CBEC51 VA: 0x1CBEB50 Slot: 123
	public override float get_OnEnableFadeAlpha() { }

	// RVA: 0x1CBEB60 Offset: 0x1CBEC61 VA: 0x1CBEB60 Slot: 12
	protected override void Start() { }

	// RVA: 0x1CBEE90 Offset: 0x1CBEF91 VA: 0x1CBEE90 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x1CBF000 Offset: 0x1CBF101 VA: 0x1CBF000 Slot: 18
	public override void OnSwitchActorBase(bool on) { }

	// RVA: 0x1CBF1D0 Offset: 0x1CBF2D1 VA: 0x1CBF1D0
	public void SetFocusName(int id) { }

	// RVA: 0x1CBF1E0 Offset: 0x1CBF2E1 VA: 0x1CBF1E0
	public int GetFocusNameID() { }

	// RVA: 0x1CBF1F0 Offset: 0x1CBF2F1 VA: 0x1CBF1F0 Slot: 113
	public override string GetFocusName() { }

	// RVA: 0x1CBF200 Offset: 0x1CBF301 VA: 0x1CBF200 Slot: 49
	public override bool InputMove(Vector3 vector) { }

	// RVA: 0x1CBF2C0 Offset: 0x1CBF3C1 VA: 0x1CBF2C0 Slot: 47
	protected override void SetLocomotion(float value) { }

	// RVA: 0x1CBF370 Offset: 0x1CBF471 VA: 0x1CBF370
	public void .ctor() { }
}

