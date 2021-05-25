public class DamageActionController : MonoBehaviour // TypeDefIndex: 6625
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15E1A0 Offset: 0x15E2A1 VA: 0x15E1A0
	private Character <character>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15E1B0 Offset: 0x15E2B1 VA: 0x15E1B0
	private CharacterController <characterController>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15E1C0 Offset: 0x15E2C1 VA: 0x15E1C0
	private NavMeshAgent <navMeshAgent>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15E1D0 Offset: 0x15E2D1 VA: 0x15E1D0
	private CharacterMovement <movement>k__BackingField; // 0x30
	private Vector3 m_Force; // 0x38
	private float m_Duration; // 0x44
	private float m_Elapsed; // 0x48
	private DamageResult m_currentDamageResult; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x15E1E0 Offset: 0x15E2E1 VA: 0x15E1E0
	private DamageActionType <Type>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x15E1F0 Offset: 0x15E2F1 VA: 0x15E1F0
	private float <BlowPower>k__BackingField; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x15E200 Offset: 0x15E301 VA: 0x15E200
	private bool <Locked>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x15E210 Offset: 0x15E311 VA: 0x15E210
	private Func<DamageActionType, DamageResult, bool> <OnBefore>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x15E220 Offset: 0x15E321 VA: 0x15E220
	private Action<DamageActionType, DamageResult> <OnPlay>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x15E230 Offset: 0x15E331 VA: 0x15E230
	private Action<DamageActionType, DamageResult> <OnStop>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x15E240 Offset: 0x15E341 VA: 0x15E240
	private Action<DamageActionType, DamageResult> <OnAfter>k__BackingField; // 0xB8

	// Properties
	private Character character { get; set; }
	private CharacterController characterController { get; set; }
	public NavMeshAgent navMeshAgent { get; set; }
	private CharacterMovement movement { get; set; }
	public DamageActionType Type { get; set; }
	public float BlowPower { get; set; }
	public bool IsPlaying { get; }
	public bool Locked { get; set; }
	public Func<DamageActionType, DamageResult, bool> OnBefore { get; set; }
	public Action<DamageActionType, DamageResult> OnPlay { get; set; }
	public Action<DamageActionType, DamageResult> OnStop { get; set; }
	public Action<DamageActionType, DamageResult> OnAfter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19C180 Offset: 0x19C281 VA: 0x19C180
	// RVA: 0x1CA8670 Offset: 0x1CA8771 VA: 0x1CA8670
	private Character get_character() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C190 Offset: 0x19C291 VA: 0x19C190
	// RVA: 0x1CA8680 Offset: 0x1CA8781 VA: 0x1CA8680
	private void set_character(Character value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C1A0 Offset: 0x19C2A1 VA: 0x19C1A0
	// RVA: 0x1CA8690 Offset: 0x1CA8791 VA: 0x1CA8690
	private CharacterController get_characterController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C1B0 Offset: 0x19C2B1 VA: 0x19C1B0
	// RVA: 0x1CA86A0 Offset: 0x1CA87A1 VA: 0x1CA86A0
	private void set_characterController(CharacterController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C1C0 Offset: 0x19C2C1 VA: 0x19C1C0
	// RVA: 0x1CA86B0 Offset: 0x1CA87B1 VA: 0x1CA86B0
	public NavMeshAgent get_navMeshAgent() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C1D0 Offset: 0x19C2D1 VA: 0x19C1D0
	// RVA: 0x1CA86C0 Offset: 0x1CA87C1 VA: 0x1CA86C0
	public void set_navMeshAgent(NavMeshAgent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C1E0 Offset: 0x19C2E1 VA: 0x19C1E0
	// RVA: 0x1CA86D0 Offset: 0x1CA87D1 VA: 0x1CA86D0
	private CharacterMovement get_movement() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C1F0 Offset: 0x19C2F1 VA: 0x19C1F0
	// RVA: 0x1CA86E0 Offset: 0x1CA87E1 VA: 0x1CA86E0
	private void set_movement(CharacterMovement value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C200 Offset: 0x19C301 VA: 0x19C200
	// RVA: 0x1CA86F0 Offset: 0x1CA87F1 VA: 0x1CA86F0
	public DamageActionType get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C210 Offset: 0x19C311 VA: 0x19C210
	// RVA: 0x1CA8700 Offset: 0x1CA8801 VA: 0x1CA8700
	private void set_Type(DamageActionType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C220 Offset: 0x19C321 VA: 0x19C220
	// RVA: 0x1CA8710 Offset: 0x1CA8811 VA: 0x1CA8710
	public float get_BlowPower() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C230 Offset: 0x19C331 VA: 0x19C230
	// RVA: 0x1CA8720 Offset: 0x1CA8821 VA: 0x1CA8720
	public void set_BlowPower(float value) { }

	// RVA: 0x1CA8730 Offset: 0x1CA8831 VA: 0x1CA8730
	public bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C240 Offset: 0x19C341 VA: 0x19C240
	// RVA: 0x1CA8740 Offset: 0x1CA8841 VA: 0x1CA8740
	public bool get_Locked() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C250 Offset: 0x19C351 VA: 0x19C250
	// RVA: 0x1CA8750 Offset: 0x1CA8851 VA: 0x1CA8750
	public void set_Locked(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C260 Offset: 0x19C361 VA: 0x19C260
	// RVA: 0x1CA8760 Offset: 0x1CA8861 VA: 0x1CA8760
	public Func<DamageActionType, DamageResult, bool> get_OnBefore() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C270 Offset: 0x19C371 VA: 0x19C270
	// RVA: 0x1CA8770 Offset: 0x1CA8871 VA: 0x1CA8770
	public void set_OnBefore(Func<DamageActionType, DamageResult, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C280 Offset: 0x19C381 VA: 0x19C280
	// RVA: 0x1CA8780 Offset: 0x1CA8881 VA: 0x1CA8780
	public Action<DamageActionType, DamageResult> get_OnPlay() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C290 Offset: 0x19C391 VA: 0x19C290
	// RVA: 0x1CA8790 Offset: 0x1CA8891 VA: 0x1CA8790
	public void set_OnPlay(Action<DamageActionType, DamageResult> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C2A0 Offset: 0x19C3A1 VA: 0x19C2A0
	// RVA: 0x1CA87A0 Offset: 0x1CA88A1 VA: 0x1CA87A0
	public Action<DamageActionType, DamageResult> get_OnStop() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C2B0 Offset: 0x19C3B1 VA: 0x19C2B0
	// RVA: 0x1CA87B0 Offset: 0x1CA88B1 VA: 0x1CA87B0
	public void set_OnStop(Action<DamageActionType, DamageResult> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C2C0 Offset: 0x19C3C1 VA: 0x19C2C0
	// RVA: 0x1CA87C0 Offset: 0x1CA88C1 VA: 0x1CA87C0
	public Action<DamageActionType, DamageResult> get_OnAfter() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C2D0 Offset: 0x19C3D1 VA: 0x19C2D0
	// RVA: 0x1CA87D0 Offset: 0x1CA88D1 VA: 0x1CA87D0
	public void set_OnAfter(Action<DamageActionType, DamageResult> value) { }

	// RVA: 0x1CA87E0 Offset: 0x1CA88E1 VA: 0x1CA87E0
	private void Awake() { }

	// RVA: 0x1CA88B0 Offset: 0x1CA89B1 VA: 0x1CA88B0
	public void Clear() { }

	// RVA: 0x1CA88C0 Offset: 0x1CA89C1 VA: 0x1CA88C0
	public bool Play(DamageResult damageResult) { }

	// RVA: 0x1CA91A0 Offset: 0x1CA92A1 VA: 0x1CA91A0
	public void Cancel() { }

	// RVA: 0x1CA8F30 Offset: 0x1CA9031 VA: 0x1CA8F30
	public bool DoAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x1CA91B0 Offset: 0x1CA92B1 VA: 0x1CA91B0
	public void StartKnockDown(float duration) { }

	// RVA: 0x1CA9260 Offset: 0x1CA9361 VA: 0x1CA9260
	public void StartKnockBack(Vector3 direction, float power, float duration) { }

	// RVA: 0x1CA8D00 Offset: 0x1CA8E01 VA: 0x1CA8D00
	public void StartBlow(Vector3 direction, float power) { }

	// RVA: 0x1CA9390 Offset: 0x1CA9491 VA: 0x1CA9390
	public bool Apply(float deltaTime) { }

	// RVA: 0x1CA99F0 Offset: 0x1CA9AF1 VA: 0x1CA99F0
	private void OnEnd(DamageActionType damageActionType) { }

	// RVA: 0x1CA94B0 Offset: 0x1CA95B1 VA: 0x1CA94B0
	private void ApplyKnockdown(float deltaTime) { }

	// RVA: 0x1CA9620 Offset: 0x1CA9721 VA: 0x1CA9620
	private void ApplyKnockback(float deltaTime) { }

	// RVA: 0x1CA9870 Offset: 0x1CA9971 VA: 0x1CA9870
	private void ApplyBlow(float deltaTime) { }

	// RVA: 0x1CA9AD0 Offset: 0x1CA9BD1 VA: 0x1CA9AD0
	private void OnStopBlow() { }

	// RVA: 0x1CA98A0 Offset: 0x1CA99A1 VA: 0x1CA98A0
	private void ApplyDead() { }

	// RVA: 0x1CA9C40 Offset: 0x1CA9D41 VA: 0x1CA9C40
	public bool OnLanding() { }

	// RVA: 0x1CA9C50 Offset: 0x1CA9D51 VA: 0x1CA9C50
	public void .ctor() { }
}

