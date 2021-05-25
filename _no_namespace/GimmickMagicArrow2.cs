public class GimmickMagicArrow2 : GimmickMagicArrow // TypeDefIndex: 7581
{
	// Fields
	private const float RUN_THRESHOLD = 0.5;
	public const float STOP_THRESHOLD = 0.1;
	[SerializeField] // RVA: 0x167930 Offset: 0x167A31 VA: 0x167930
	[RangeAttribute] // RVA: 0x167930 Offset: 0x167A31 VA: 0x167930
	private float SearchAngle; // 0x68
	private SphereCollider sphere; // 0x70

	// Methods

	// RVA: 0x1EA3410 Offset: 0x1EA3511 VA: 0x1EA3410 Slot: 6
	protected override void Start() { }

	// RVA: 0x1EA3480 Offset: 0x1EA3581 VA: 0x1EA3480 Slot: 11
	protected override void OnEnterEvent(Collider fromCollider, Collider toCollider) { }

	// RVA: 0x1EA3490 Offset: 0x1EA3591 VA: 0x1EA3490 Slot: 12
	protected override void OnStayEvent(Collider fromCollider, Collider toCollider) { }

	// RVA: 0x1EA3800 Offset: 0x1EA3901 VA: 0x1EA3800
	private bool IsWithinRangeAngle(Vector3 i_forwardDir, Vector3 i_toTargetDir, float i_cosTheta) { }

	// RVA: 0x1EA3930 Offset: 0x1EA3A31 VA: 0x1EA3930
	public void .ctor() { }
}

