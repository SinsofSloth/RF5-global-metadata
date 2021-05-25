public class FPSAiming : MonoBehaviour // TypeDefIndex: 9355
{
	// Fields
	[RangeAttribute] // RVA: 0x178250 Offset: 0x178351 VA: 0x178250
	public float aimWeight; // 0x18
	[RangeAttribute] // RVA: 0x178270 Offset: 0x178371 VA: 0x178270
	public float sightWeight; // 0x1C
	[RangeAttribute] // RVA: 0x178290 Offset: 0x178391 VA: 0x178290
	public float maxAngle; // 0x20
	public Vector3 aimOffset; // 0x24
	public bool animatePhysics; // 0x30
	public Transform gun; // 0x38
	public Transform gunTarget; // 0x40
	public FullBodyBipedIK ik; // 0x48
	public AimIK gunAim; // 0x50
	public CameraControllerFPS cam; // 0x58
	public Recoil recoil; // 0x60
	[RangeAttribute] // RVA: 0x1782B0 Offset: 0x1783B1 VA: 0x1782B0
	public float cameraRecoilWeight; // 0x68
	public Vector3 gunTargetDefaultLocalPosition; // 0x6C
	public Vector3 gunTargetDefaultLocalRotation; // 0x78
	private Vector3 camDefaultLocalPosition; // 0x84
	private Vector3 camRelativeToGunTarget; // 0x90
	private bool updateFrame; // 0x9C

	// Methods

	// RVA: 0x26C7940 Offset: 0x26C7A41 VA: 0x26C7940
	private void Start() { }

	// RVA: 0x26C7AA0 Offset: 0x26C7BA1 VA: 0x26C7AA0
	private void FixedUpdate() { }

	// RVA: 0x26C7AB0 Offset: 0x26C7BB1 VA: 0x26C7AB0
	private void LateUpdate() { }

	// RVA: 0x26C7E00 Offset: 0x26C7F01 VA: 0x26C7E00
	private void Aiming() { }

	// RVA: 0x26C8070 Offset: 0x26C8171 VA: 0x26C8070
	private void LookDownTheSight() { }

	// RVA: 0x26C7B80 Offset: 0x26C7C81 VA: 0x26C7B80
	private void RotateCharacter() { }

	// RVA: 0x26C8AA0 Offset: 0x26C8BA1 VA: 0x26C8AA0
	public void .ctor() { }
}

