public class GimmickMagicArrowShot : MonoBehaviour // TypeDefIndex: 7582
{
	// Fields
	public float ColliderStartTime; // 0x18
	public float FadeOutTime; // 0x1C
	public float ShotEffectStopTime; // 0x20
	private float arrowDamage; // 0x24
	private float AttackKnockbackPower; // 0x28
	private Vector3 Dir; // 0x2C
	private float Life; // 0x38
	private SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher; // 0x40
	private CapsuleCollider _collider; // 0x48
	private ParticleSystem Monster_Goblin_Ork01; // 0x50
	private Renderer _renderer; // 0x58
	private MaterialPropertyBlock materialPropertyBlock; // 0x60
	private Coroutine fadeCoroutine; // 0x68
	private Coroutine stopCoroutine; // 0x70

	// Methods

	// RVA: 0x1EA30F0 Offset: 0x1EA31F1 VA: 0x1EA30F0
	public void SetSpeed(Vector3 dir, float damage, float knockback) { }

	// RVA: 0x1EA3960 Offset: 0x1EA3A61 VA: 0x1EA3960
	private void Awake() { }

	// RVA: 0x1EA3D80 Offset: 0x1EA3E81 VA: 0x1EA3D80
	private void Start() { }

	// RVA: 0x1EA3E20 Offset: 0x1EA3F21 VA: 0x1EA3E20
	private void Update() { }

	// RVA: 0x1EA3FF0 Offset: 0x1EA40F1 VA: 0x1EA3FF0
	private void OnStayEvent(Collider fromCollider, Collider toCollider) { }

	// RVA: 0x1EA4630 Offset: 0x1EA4731 VA: 0x1EA4630
	public void FadeOut(float time = 1) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1CD0 Offset: 0x1A1DD1 VA: 0x1A1CD0
	// RVA: 0x1EA4710 Offset: 0x1EA4811 VA: 0x1EA4710
	private IEnumerator Fade(float start, float end, float fade_time) { }

	// RVA: 0x1EA3D00 Offset: 0x1EA3E01 VA: 0x1EA3D00
	public void SetAlpha(float alpha) { }

	// RVA: 0x1EA4560 Offset: 0x1EA4661 VA: 0x1EA4560
	public void ShotEffectStop(float time = 1) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1D40 Offset: 0x1A1E41 VA: 0x1A1D40
	// RVA: 0x1EA47E0 Offset: 0x1EA48E1 VA: 0x1EA47E0
	private IEnumerator Wait(float time) { }

	// RVA: 0x1EA48A0 Offset: 0x1EA49A1 VA: 0x1EA48A0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1DB0 Offset: 0x1A1EB1 VA: 0x1A1DB0
	// RVA: 0x1EA4920 Offset: 0x1EA4A21 VA: 0x1EA4920
	private void <Awake>b__11_0(ParticleSystem obj) { }
}

