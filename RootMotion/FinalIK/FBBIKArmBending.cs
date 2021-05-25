public class FBBIKArmBending : MonoBehaviour // TypeDefIndex: 9457
{
	// Fields
	public FullBodyBipedIK ik; // 0x18
	public Vector3 bendDirectionOffsetLeft; // 0x20
	public Vector3 bendDirectionOffsetRight; // 0x2C
	public Vector3 characterSpaceBendOffsetLeft; // 0x38
	public Vector3 characterSpaceBendOffsetRight; // 0x44
	private Quaternion leftHandTargetRotation; // 0x50
	private Quaternion rightHandTargetRotation; // 0x60
	private bool initiated; // 0x70

	// Methods

	// RVA: 0x273AE00 Offset: 0x273AF01 VA: 0x273AE00
	private void LateUpdate() { }

	// RVA: 0x273B380 Offset: 0x273B481 VA: 0x273B380
	private void OnPostFBBIK() { }

	// RVA: 0x273B540 Offset: 0x273B641 VA: 0x273B540
	private void OnDestroy() { }

	// RVA: 0x273B660 Offset: 0x273B761 VA: 0x273B660
	public void .ctor() { }
}

