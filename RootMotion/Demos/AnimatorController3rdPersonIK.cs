[RequireComponent] // RVA: 0x147DF0 Offset: 0x147EF1 VA: 0x147DF0
[RequireComponent] // RVA: 0x147DF0 Offset: 0x147EF1 VA: 0x147DF0
public class AnimatorController3rdPersonIK : AnimatorController3rdPerson // TypeDefIndex: 9345
{
	// Fields
	[RangeAttribute] // RVA: 0x178050 Offset: 0x178151 VA: 0x178050
	public float headLookWeight; // 0x5C
	public Vector3 gunHoldOffset; // 0x60
	public Vector3 leftHandOffset; // 0x6C
	public Recoil recoil; // 0x78
	private AimIK aim; // 0x80
	private FullBodyBipedIK ik; // 0x88
	private Vector3 headLookAxis; // 0x90
	private Vector3 leftHandPosRelToRightHand; // 0x9C
	private Quaternion leftHandRotRelToRightHand; // 0xA8
	private Vector3 aimTarget; // 0xB8
	private Quaternion rightHandRotation; // 0xC4

	// Methods

	// RVA: 0x26BF730 Offset: 0x26BF831 VA: 0x26BF730 Slot: 4
	protected override void Start() { }

	// RVA: 0x26BF920 Offset: 0x26BFA21 VA: 0x26BF920 Slot: 5
	public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget) { }

	// RVA: 0x26BFA00 Offset: 0x26BFB01 VA: 0x26BFA00
	private void Read() { }

	// RVA: 0x26BFB60 Offset: 0x26BFC61 VA: 0x26BFB60
	private void AimIK() { }

	// RVA: 0x26BFBB0 Offset: 0x26BFCB1 VA: 0x26BFBB0
	private void FBBIK() { }

	// RVA: 0x26C01C0 Offset: 0x26C02C1 VA: 0x26C01C0
	private void OnPreRead() { }

	// RVA: 0x26BFF80 Offset: 0x26C0081 VA: 0x26BFF80
	private void HeadLookAt(Vector3 lookAtTarget) { }

	// RVA: 0x26C0520 Offset: 0x26C0621 VA: 0x26C0520
	private void OnDestroy() { }

	// RVA: 0x26C0640 Offset: 0x26C0741 VA: 0x26C0640
	public void .ctor() { }
}

