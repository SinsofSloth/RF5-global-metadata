[Serializable]
public class KissingRig.Partner // TypeDefIndex: 9363
{
	// Fields
	public FullBodyBipedIK ik; // 0x10
	public Transform mouth; // 0x18
	public Transform mouthTarget; // 0x20
	public Transform touchTargetLeftHand; // 0x28
	public Transform touchTargetRightHand; // 0x30
	public float bodyWeightHorizontal; // 0x38
	public float bodyWeightVertical; // 0x3C
	public float neckRotationWeight; // 0x40
	public float headTiltAngle; // 0x44
	public Vector3 headTiltAxis; // 0x48
	private Quaternion neckRotation; // 0x54

	// Properties
	private Transform neck { get; }

	// Methods

	// RVA: 0x26CAC80 Offset: 0x26CAD81 VA: 0x26CAC80
	public void Initiate() { }

	// RVA: 0x26CAD00 Offset: 0x26CAE01 VA: 0x26CAD00
	public void Update(float weight) { }

	// RVA: 0x26CB540 Offset: 0x26CB641 VA: 0x26CB540
	private Transform get_neck() { }

	// RVA: 0x26CB360 Offset: 0x26CB461 VA: 0x26CB360
	private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight) { }

	// RVA: 0x26CB5A0 Offset: 0x26CB6A1 VA: 0x26CB5A0
	public void .ctor() { }
}

