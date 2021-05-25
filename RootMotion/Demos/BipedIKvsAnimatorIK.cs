public class BipedIKvsAnimatorIK : MonoBehaviour // TypeDefIndex: 9335
{
	// Fields
	[LargeHeader] // RVA: 0x177D20 Offset: 0x177E21 VA: 0x177D20
	public Animator animator; // 0x18
	public BipedIK bipedIK; // 0x20
	[LargeHeader] // RVA: 0x177D60 Offset: 0x177E61 VA: 0x177D60
	public Transform lookAtTargetBiped; // 0x28
	public Transform lookAtTargetAnimator; // 0x30
	[RangeAttribute] // RVA: 0x177DA0 Offset: 0x177EA1 VA: 0x177DA0
	public float lookAtWeight; // 0x38
	[RangeAttribute] // RVA: 0x177DC0 Offset: 0x177EC1 VA: 0x177DC0
	public float lookAtBodyWeight; // 0x3C
	[RangeAttribute] // RVA: 0x177DE0 Offset: 0x177EE1 VA: 0x177DE0
	public float lookAtHeadWeight; // 0x40
	[RangeAttribute] // RVA: 0x177E00 Offset: 0x177F01 VA: 0x177E00
	public float lookAtEyesWeight; // 0x44
	[RangeAttribute] // RVA: 0x177E20 Offset: 0x177F21 VA: 0x177E20
	public float lookAtClampWeight; // 0x48
	[RangeAttribute] // RVA: 0x177E40 Offset: 0x177F41 VA: 0x177E40
	public float lookAtClampWeightHead; // 0x4C
	[RangeAttribute] // RVA: 0x177E60 Offset: 0x177F61 VA: 0x177E60
	public float lookAtClampWeightEyes; // 0x50
	[LargeHeader] // RVA: 0x177E80 Offset: 0x177F81 VA: 0x177E80
	public Transform footTargetBiped; // 0x58
	public Transform footTargetAnimator; // 0x60
	[RangeAttribute] // RVA: 0x177EC0 Offset: 0x177FC1 VA: 0x177EC0
	public float footPositionWeight; // 0x68
	[RangeAttribute] // RVA: 0x177EE0 Offset: 0x177FE1 VA: 0x177EE0
	public float footRotationWeight; // 0x6C
	[LargeHeader] // RVA: 0x177F00 Offset: 0x178001 VA: 0x177F00
	public Transform handTargetBiped; // 0x70
	public Transform handTargetAnimator; // 0x78
	[RangeAttribute] // RVA: 0x177F40 Offset: 0x178041 VA: 0x177F40
	public float handPositionWeight; // 0x80
	[RangeAttribute] // RVA: 0x177F60 Offset: 0x178061 VA: 0x177F60
	public float handRotationWeight; // 0x84

	// Methods

	// RVA: 0x26C0800 Offset: 0x26C0901 VA: 0x26C0800
	private void OnAnimatorIK(int layer) { }

	// RVA: 0x26C0CB0 Offset: 0x26C0DB1 VA: 0x26C0CB0
	public void .ctor() { }
}

