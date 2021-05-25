public class SpcMonsterController : MonsterControllerBase // TypeDefIndex: 6791
{
	// Fields
	private const float MaxSpeedTime = 1;
	[SerializeField] // RVA: 0x15F980 Offset: 0x15FA81 VA: 0x15F980
	public bool IsSlowdown; // 0x500
	[SerializeField] // RVA: 0x15F990 Offset: 0x15FA91 VA: 0x15F990
	public bool IsStop; // 0x501
	[SerializeField] // RVA: 0x15F9A0 Offset: 0x15FAA1 VA: 0x15F9A0
	public bool IsHurry; // 0x502
	[SerializeField] // RVA: 0x15F9B0 Offset: 0x15FAB1 VA: 0x15F9B0
	public float ShortPlayMoveSpeed; // 0x504
	[SerializeField] // RVA: 0x15F9C0 Offset: 0x15FAC1 VA: 0x15F9C0
	public float ShortPlayLocomotion; // 0x508
	[SerializeField] // RVA: 0x15F9D0 Offset: 0x15FAD1 VA: 0x15F9D0
	public float ShortPlayTargetMoveSpeed; // 0x50C
	[SerializeField] // RVA: 0x15F9E0 Offset: 0x15FAE1 VA: 0x15F9E0
	public float ShortPlayTargetLocomotion; // 0x510
	public Transform ShortPlayLookAtTarget; // 0x518
	public Vector3 lookatRotate; // 0x520
	private LookAtState lookAtState; // 0x52C
	public float Acceleration; // 0x530
	public Quaternion ShortPlayRotation; // 0x534

	// Properties
	private Vector3 lookat { get; }

	// Methods

	// RVA: 0x211C560 Offset: 0x211C661 VA: 0x211C560
	private Vector3 get_lookat() { }

	// RVA: 0x211C580 Offset: 0x211C681 VA: 0x211C580 Slot: 150
	public override string GetFocusName() { }

	// RVA: 0x211C5D0 Offset: 0x211C6D1 VA: 0x211C5D0 Slot: 11
	protected override void Awake() { }

	// RVA: 0x211C690 Offset: 0x211C791 VA: 0x211C690 Slot: 40
	protected override void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x19D0D0 Offset: 0x19D1D1 VA: 0x19D0D0
	// RVA: 0x211CDF0 Offset: 0x211CEF1 VA: 0x211CDF0 Slot: 109
	public override IEnumerator SetupAsync(Action callBack) { }

	// RVA: 0x211CEC0 Offset: 0x211CFC1 VA: 0x211CEC0
	public void SetShortPlayMovePosition(Vector3 _targetPosition, float _moveSpeed, float _locomotion) { }

	// RVA: 0x211CF90 Offset: 0x211D091 VA: 0x211CF90 Slot: 125
	public override void ShortPlay() { }

	// RVA: 0x211CFE0 Offset: 0x211D0E1 VA: 0x211CFE0 Slot: 126
	public override void ShortPlayExit() { }

	// RVA: 0x211C970 Offset: 0x211CA71 VA: 0x211C970
	public void UpdateMovePosition() { }

	// RVA: 0x211C6C0 Offset: 0x211C7C1 VA: 0x211C6C0
	public void UpdateOnGround() { }

	// RVA: 0x211D430 Offset: 0x211D531 VA: 0x211D430
	public void LookAtTargetShortPlay(Quaternion q) { }

	[IteratorStateMachineAttribute] // RVA: 0x19D140 Offset: 0x19D241 VA: 0x19D140
	// RVA: 0x211D5A0 Offset: 0x211D6A1 VA: 0x211D5A0
	public IEnumerator LookAtTargetShortPlayEnd() { }

	// RVA: 0x211D0B0 Offset: 0x211D1B1 VA: 0x211D0B0
	private void UpdateLookAtRotation() { }

	// RVA: 0x211D650 Offset: 0x211D751 VA: 0x211D650
	public void .ctor() { }
}

