public class YadokariShellController : MonoBehaviour // TypeDefIndex: 7998
{
	// Fields
	private readonly Vector3 StartLocalPosition; // 0x18
	private readonly Vector3 StartLocalRotation; // 0x24
	private const float Angle = 360;
	private const float ShellAroundRotateTime = 1;
	private const float ClearTime = 1;
	private Collider Collider; // 0x30
	[SerializeField] // RVA: 0x169F10 Offset: 0x16A011 VA: 0x169F10
	private Transform ParentTransform; // 0x38
	private TweenerCore<Vector3, Vector3, VectorOptions> ShellTweenCore; // 0x40
	private TweenerCore<Vector3, Vector3, VectorOptions> ParentShellTweenCore; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x169F20 Offset: 0x16A021 VA: 0x169F20
	private bool <IsThrow>k__BackingField; // 0x50
	private bool IsClear; // 0x51

	// Properties
	public bool IsThrow { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A5090 Offset: 0x1A5191 VA: 0x1A5090
	// RVA: 0x26A2390 Offset: 0x26A2491 VA: 0x26A2390
	public bool get_IsThrow() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A50A0 Offset: 0x1A51A1 VA: 0x1A50A0
	// RVA: 0x26A23A0 Offset: 0x26A24A1 VA: 0x26A23A0
	private void set_IsThrow(bool value) { }

	// RVA: 0x26A23B0 Offset: 0x26A24B1 VA: 0x26A23B0
	private void Start() { }

	// RVA: 0x26A2430 Offset: 0x26A2531 VA: 0x26A2430
	public void ResetShell() { }

	// RVA: 0x26A1AE0 Offset: 0x26A1BE1 VA: 0x26A1AE0
	public void Throw(Vector3 controllerforward, Vector3 targetPosition, float jumpPower, float duration) { }

	// RVA: 0x26A1DB0 Offset: 0x26A1EB1 VA: 0x26A1DB0
	public void Pickup(float duration) { }

	// RVA: 0x26A0F80 Offset: 0x26A1081 VA: 0x26A0F80
	public void Clear() { }

	// RVA: 0x26A2510 Offset: 0x26A2611 VA: 0x26A2510
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x26A26C0 Offset: 0x26A27C1 VA: 0x26A26C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A50B0 Offset: 0x1A51B1 VA: 0x1A50B0
	// RVA: 0x26A2770 Offset: 0x26A2871 VA: 0x26A2770
	private void <Pickup>b__17_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A50C0 Offset: 0x1A51C1 VA: 0x1A50C0
	// RVA: 0x26A2780 Offset: 0x26A2881 VA: 0x26A2780
	private void <Clear>b__18_0() { }
}

