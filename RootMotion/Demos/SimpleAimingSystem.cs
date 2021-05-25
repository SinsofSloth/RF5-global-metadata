public class SimpleAimingSystem : MonoBehaviour // TypeDefIndex: 9333
{
	// Fields
	[TooltipAttribute] // RVA: 0x177BA0 Offset: 0x177CA1 VA: 0x177BA0
	public AimPoser aimPoser; // 0x18
	[TooltipAttribute] // RVA: 0x177BE0 Offset: 0x177CE1 VA: 0x177BE0
	public AimIK aim; // 0x20
	[TooltipAttribute] // RVA: 0x177C20 Offset: 0x177D21 VA: 0x177C20
	public LookAtIK lookAt; // 0x28
	[TooltipAttribute] // RVA: 0x177C60 Offset: 0x177D61 VA: 0x177C60
	public Animator animator; // 0x30
	[TooltipAttribute] // RVA: 0x177CA0 Offset: 0x177DA1 VA: 0x177CA0
	public float crossfadeTime; // 0x38
	[TooltipAttribute] // RVA: 0x177CE0 Offset: 0x177DE1 VA: 0x177CE0
	public float minAimDistance; // 0x3C
	private AimPoser.Pose aimPose; // 0x40
	private AimPoser.Pose lastPose; // 0x48

	// Methods

	// RVA: 0x2729A90 Offset: 0x2729B91 VA: 0x2729A90
	private void Start() { }

	// RVA: 0x2729AE0 Offset: 0x2729BE1 VA: 0x2729AE0
	private void LateUpdate() { }

	// RVA: 0x2729C30 Offset: 0x2729D31 VA: 0x2729C30
	private void Pose() { }

	// RVA: 0x2729E90 Offset: 0x2729F91 VA: 0x2729E90
	private void LimitAimTarget() { }

	// RVA: 0x272A1E0 Offset: 0x272A2E1 VA: 0x272A1E0
	private void DirectCrossFade(string state, float target) { }

	// RVA: 0x272A2C0 Offset: 0x272A3C1 VA: 0x272A2C0
	public void .ctor() { }
}

