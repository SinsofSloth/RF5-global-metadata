[RequireComponent] // RVA: 0x148060 Offset: 0x148161 VA: 0x148060
public class PendulumExample : MonoBehaviour // TypeDefIndex: 9370
{
	// Fields
	[TooltipAttribute] // RVA: 0x178470 Offset: 0x178571 VA: 0x178470
	[RangeAttribute] // RVA: 0x178470 Offset: 0x178571 VA: 0x178470
	public float weight; // 0x18
	[TooltipAttribute] // RVA: 0x1784D0 Offset: 0x1785D1 VA: 0x1784D0
	public float hangingDistanceMlp; // 0x1C
	[TooltipAttribute] // RVA: 0x178510 Offset: 0x178611 VA: 0x178510
	[HideInInspector] // RVA: 0x178510 Offset: 0x178611 VA: 0x178510
	public Vector3 rootTargetPosition; // 0x20
	[TooltipAttribute] // RVA: 0x178560 Offset: 0x178661 VA: 0x178560
	[HideInInspector] // RVA: 0x178560 Offset: 0x178661 VA: 0x178560
	public Quaternion rootTargetRotation; // 0x2C
	public Transform target; // 0x40
	public Transform leftHandTarget; // 0x48
	public Transform rightHandTarget; // 0x50
	public Transform leftFootTarget; // 0x58
	public Transform rightFootTarget; // 0x60
	public Transform pelvisTarget; // 0x68
	public Transform bodyTarget; // 0x70
	public Transform headTarget; // 0x78
	public Vector3 pelvisDownAxis; // 0x80
	private FullBodyBipedIK ik; // 0x90
	private Quaternion rootRelativeToPelvis; // 0x98
	private Vector3 pelvisToRoot; // 0xA8
	private float lastWeight; // 0xB4

	// Methods

	// RVA: 0x2726B10 Offset: 0x2726C11 VA: 0x2726B10
	private void Start() { }

	// RVA: 0x2726E60 Offset: 0x2726F61 VA: 0x2726E60
	private void LateUpdate() { }

	// RVA: 0x27275B0 Offset: 0x27276B1 VA: 0x27275B0
	public void .ctor() { }
}

