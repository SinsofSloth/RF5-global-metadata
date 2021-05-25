[RequireComponent] // RVA: 0x147A10 Offset: 0x147B11 VA: 0x147A10
public class PhysicCullingSystem : MonoBehaviour // TypeDefIndex: 9076
{
	// Fields
	[TooltipAttribute] // RVA: 0x176710 Offset: 0x176811 VA: 0x176710
	public float physicDistance; // 0x18
	private float sphereSize; // 0x1C
	private Rigidbody rigidbody_; // 0x20
	private CullingGroup group; // 0x28
	private BoundingSphere[] spheres; // 0x30
	private Camera mainCamera; // 0x38
	[HideInInspector] // RVA: 0x176750 Offset: 0x176851 VA: 0x176750
	public Vector3 velocity; // 0x40
	[HideInInspector] // RVA: 0x176760 Offset: 0x176861 VA: 0x176760
	public Vector3 angularVelocity; // 0x4C
	public bool gizmo; // 0x58

	// Methods

	// RVA: 0x1FE7000 Offset: 0x1FE7101 VA: 0x1FE7000
	private void Start() { }

	// RVA: 0x1FE7240 Offset: 0x1FE7341 VA: 0x1FE7240
	private void OnDrawGizmosSelected() { }

	// RVA: 0x1FE72B0 Offset: 0x1FE73B1 VA: 0x1FE72B0
	private void CheckVisibility() { }

	// RVA: 0x1FE7360 Offset: 0x1FE7461 VA: 0x1FE7360
	public void Update() { }

	// RVA: 0x1FE7480 Offset: 0x1FE7581 VA: 0x1FE7480
	private void StateChangedMethod(CullingGroupEvent evt) { }

	// RVA: 0x1FE7530 Offset: 0x1FE7631 VA: 0x1FE7530
	private void OnDisable() { }

	// RVA: 0x1FE74D0 Offset: 0x1FE75D1 VA: 0x1FE74D0
	private void StopMovement() { }

	// RVA: 0x1FE7300 Offset: 0x1FE7401 VA: 0x1FE7300
	private void StartMovement() { }

	// RVA: 0x1FE7580 Offset: 0x1FE7681 VA: 0x1FE7580
	public void .ctor() { }
}

