public class ReviatanIcePillar : MonoBehaviour // TypeDefIndex: 7967
{
	// Fields
	private MonsterProjectileActionScriptsController Projectile; // 0x18
	private Collider Collider; // 0x20
	private const float HIT_END_TIME = 1;
	[SerializeField] // RVA: 0x169E50 Offset: 0x169F51 VA: 0x169E50
	private ParticleSystem EndParticle; // 0x28
	private float EndTime; // 0x30
	private Action DestroyCallback; // 0x38
	private bool isHit; // 0x40

	// Methods

	// RVA: 0x2330B60 Offset: 0x2330C61 VA: 0x2330B60
	private void OnDestroy() { }

	// RVA: 0x2330B80 Offset: 0x2330C81 VA: 0x2330B80
	private void Start() { }

	// RVA: 0x23304F0 Offset: 0x23305F1 VA: 0x23304F0
	public void Setup(MonsterProjectileActionScriptsController projectile, Action destoryCallback) { }

	// RVA: 0x2330C00 Offset: 0x2330D01 VA: 0x2330C00
	private void Update() { }

	// RVA: 0x232F4B0 Offset: 0x232F5B1 VA: 0x232F4B0
	public void End() { }

	// RVA: 0x2330CC0 Offset: 0x2330DC1 VA: 0x2330CC0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x2330DE0 Offset: 0x2330EE1 VA: 0x2330DE0
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x2330F90 Offset: 0x2331091 VA: 0x2330F90
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x23310F0 Offset: 0x23311F1 VA: 0x23310F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4BA0 Offset: 0x1A4CA1 VA: 0x1A4BA0
	// RVA: 0x2331100 Offset: 0x2331201 VA: 0x2331100
	private void <Setup>b__9_0(Collider other) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A4BB0 Offset: 0x1A4CB1 VA: 0x1A4BB0
	// RVA: 0x2331230 Offset: 0x2331331 VA: 0x2331230
	private void <Setup>b__9_1() { }
}

