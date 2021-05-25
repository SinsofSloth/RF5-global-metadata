public class MummyHand : MonoBehaviour // TypeDefIndex: 7947
{
	// Fields
	private Animator Animator; // 0x18
	private MummyController MummyController; // 0x20
	private Transform DefaultTransform; // 0x28
	private Transform SetHandTransform; // 0x30
	private Transform EndTransform; // 0x38
	private Vector3 TargetPos; // 0x40
	private Vector3 OffsetPos; // 0x4C
	private Vector3 DefaultScale; // 0x58
	private bool IsSetup; // 0x64
	private bool IsSeek; // 0x65

	// Methods

	// RVA: 0x1FACF20 Offset: 0x1FAD021 VA: 0x1FACF20
	public void Setup(MummyController mummyController, SkinnedMeshRenderer skinnedMeshRenderer, Transform defaultTrans, Transform setHandTrans, Transform endTransform) { }

	// RVA: 0x1FAF070 Offset: 0x1FAF171 VA: 0x1FAF070
	public void SetDefault(float moveDuration, float scaleDuration) { }

	// RVA: 0x1FAFFD0 Offset: 0x1FB00D1 VA: 0x1FAFFD0
	public void SetTargetPos(Vector3 pos) { }

	// RVA: 0x1FAF2C0 Offset: 0x1FAF3C1 VA: 0x1FAF2C0
	public void SeekEnd() { }

	// RVA: 0x1FAF2D0 Offset: 0x1FAF3D1 VA: 0x1FAF2D0
	public void Press(float pressDuration) { }

	// RVA: 0x1FAF510 Offset: 0x1FAF611 VA: 0x1FAF510
	public void PressEnd() { }

	// RVA: 0x1FAF5A0 Offset: 0x1FAF6A1 VA: 0x1FAF5A0
	public void BackBody(float duration, Action callback) { }

	// RVA: 0x1FAFFF0 Offset: 0x1FB00F1 VA: 0x1FAFFF0
	private void Update() { }

	// RVA: 0x1FB0280 Offset: 0x1FB0381 VA: 0x1FB0280
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A48A0 Offset: 0x1A49A1 VA: 0x1A48A0
	// RVA: 0x1FB0330 Offset: 0x1FB0431 VA: 0x1FB0330
	private void <SetDefault>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A48B0 Offset: 0x1A49B1 VA: 0x1A48B0
	// RVA: 0x1FB0340 Offset: 0x1FB0441 VA: 0x1FB0340
	private void <Press>b__14_0() { }
}

