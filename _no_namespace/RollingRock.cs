public class RollingRock : MonoBehaviour // TypeDefIndex: 7605
{
	// Fields
	public Spline Spline; // 0x18
	public float Damage; // 0x20
	public float AttackKnockbackPower; // 0x24
	public float MoveSpeed; // 0x28
	public float FadeInTime; // 0x2C
	public float FadeOutTime; // 0x30
	public float FadeOutStartTime; // 0x34
	private SphereCollider SphereCollider; // 0x38
	private Rigidbody[] Rigidbodys; // 0x40
	private MeshCollider[] MeshColliders; // 0x48
	private bool IsBreak; // 0x50
	private float MovedDistance; // 0x54
	private Vector3 PrebPoint; // 0x58
	private Quaternion CurrentRolling; // 0x64
	private Transform Children; // 0x78
	private const SoundID BreakSe = 707;
	private const SoundID GorogoroSe = 706;
	private SEController Gorogoro; // 0x80
	private CurveSample Sample; // 0x88
	private Renderer[] _renderer; // 0xD0
	private Material[] _materials; // 0xD8
	private Coroutine fadeCoroutine; // 0xE0

	// Methods

	// RVA: 0x26B2E80 Offset: 0x26B2F81 VA: 0x26B2E80
	private void Awake() { }

	// RVA: 0x26B30E0 Offset: 0x26B31E1 VA: 0x26B30E0
	private void Start() { }

	// RVA: 0x26B32B0 Offset: 0x26B33B1 VA: 0x26B32B0
	private void OnDestroy() { }

	// RVA: 0x26B33D0 Offset: 0x26B34D1 VA: 0x26B33D0
	private void FixedUpdate() { }

	// RVA: 0x26B3870 Offset: 0x26B3971 VA: 0x26B3870
	private void Update() { }

	// RVA: 0x26B3BA0 Offset: 0x26B3CA1 VA: 0x26B3BA0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x26B3510 Offset: 0x26B3611 VA: 0x26B3510
	private void Break() { }

	// RVA: 0x26B2F80 Offset: 0x26B3081 VA: 0x26B2F80
	private void FadeInit() { }

	// RVA: 0x26B31D0 Offset: 0x26B32D1 VA: 0x26B31D0
	private void FadeIn(float time = 1) { }

	// RVA: 0x26B42A0 Offset: 0x26B43A1 VA: 0x26B42A0
	private void FadeOut(float time = 1) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A2080 Offset: 0x1A2181 VA: 0x1A2080
	// RVA: 0x26B4200 Offset: 0x26B4301 VA: 0x26B4200
	private IEnumerator Fade(float start, float end, float fade_time) { }

	// RVA: 0x26B40E0 Offset: 0x26B41E1 VA: 0x26B40E0
	private void SetAlpha(float alpha) { }

	// RVA: 0x26B32C0 Offset: 0x26B33C1 VA: 0x26B32C0
	private void FadeDestory() { }

	// RVA: 0x26B4010 Offset: 0x26B4111 VA: 0x26B4010
	private void FadeWaitStart(float time) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A20F0 Offset: 0x1A21F1 VA: 0x1A20F0
	// RVA: 0x26B43B0 Offset: 0x26B44B1 VA: 0x26B43B0
	private IEnumerator FadeWait(float fade_time) { }

	// RVA: 0x26B4470 Offset: 0x26B4571 VA: 0x26B4470
	public void .ctor() { }
}

