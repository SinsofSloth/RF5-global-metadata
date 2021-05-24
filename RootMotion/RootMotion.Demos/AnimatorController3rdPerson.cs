[RequireComponent] // RVA: 0x147D80 Offset: 0x147E81 VA: 0x147D80
public class AnimatorController3rdPerson : MonoBehaviour // TypeDefIndex: 9344
{
	// Fields
	public float rotateSpeed; // 0x18
	public float blendSpeed; // 0x1C
	public float maxAngle; // 0x20
	public float moveSpeed; // 0x24
	public float rootMotionWeight; // 0x28
	protected Animator animator; // 0x30
	protected Vector3 moveBlend; // 0x38
	protected Vector3 moveInput; // 0x44
	protected Vector3 velocity; // 0x50

	// Methods

	// RVA: 0x26BF210 Offset: 0x26BF311 VA: 0x26BF210 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x26BF270 Offset: 0x26BF371 VA: 0x26BF270
	private void OnAnimatorMove() { }

	// RVA: 0x26BF4B0 Offset: 0x26BF5B1 VA: 0x26BF4B0 Slot: 5
	public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget) { }

	// RVA: 0x26BF710 Offset: 0x26BF811 VA: 0x26BF710
	public void .ctor() { }
}

