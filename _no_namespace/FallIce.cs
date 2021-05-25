public class FallIce : MonoBehaviour // TypeDefIndex: 7549
{
	// Fields
	public float DamagePercent; // 0x18
	public float AttackKnockbackPower; // 0x1C
	public float FallAccelSpeed; // 0x20
	public float FallMaxSpeed; // 0x24
	public float FallStartTime; // 0x28
	public float ColliderStartTime; // 0x2C
	public float ShadowScale5m; // 0x30
	public float ShadowScale0m; // 0x34
	private float time_; // 0x38
	private float CurrentSpeed; // 0x3C
	private bool IsBreak; // 0x40
	private ParticleSystem tulala; // 0x48
	private ParticleSystem shadow; // 0x50
	private ParticleDestroy showdowTransform; // 0x58
	private GameObject shadowPos; // 0x60
	private Collider _collider; // 0x68

	// Methods

	// RVA: 0x2085070 Offset: 0x2085171 VA: 0x2085070
	private void Awake() { }

	// RVA: 0x2085200 Offset: 0x2085301 VA: 0x2085200
	private void Start() { }

	// RVA: 0x2085330 Offset: 0x2085431 VA: 0x2085330
	private void LateUpdate() { }

	// RVA: 0x2085750 Offset: 0x2085851 VA: 0x2085750
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x2085BD0 Offset: 0x2085CD1 VA: 0x2085BD0
	private void Break() { }

	// RVA: 0x2085D50 Offset: 0x2085E51 VA: 0x2085D50
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1A70 Offset: 0x1A1B71 VA: 0x1A1A70
	// RVA: 0x2085D80 Offset: 0x2085E81 VA: 0x2085D80
	private void <Start>b__17_0(ParticleSystem obj) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1A80 Offset: 0x1A1B81 VA: 0x1A1A80
	// RVA: 0x2085D90 Offset: 0x2085E91 VA: 0x2085D90
	private void <Start>b__17_1(ParticleSystem obj) { }
}

