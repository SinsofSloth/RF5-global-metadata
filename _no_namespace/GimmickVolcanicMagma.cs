public class GimmickVolcanicMagma : GimmickBase // TypeDefIndex: 7596
{
	// Fields
	private const EffectID EffectId = 7055;
	private const EffectID SignEffectId = 7013;
	private const float SEPlayDistance = 32;
	private float CurrentTime; // 0x20
	[SerializeField] // RVA: 0x167F30 Offset: 0x168031 VA: 0x167F30
	private float Interval; // 0x24
	[SerializeField] // RVA: 0x167F40 Offset: 0x168041 VA: 0x167F40
	private float Duration; // 0x28
	[SerializeField] // RVA: 0x167F50 Offset: 0x168051 VA: 0x167F50
	private float DamagePercent; // 0x2C
	[SerializeField] // RVA: 0x167F60 Offset: 0x168061 VA: 0x167F60
	private float Damage; // 0x30
	[SerializeField] // RVA: 0x167F70 Offset: 0x168071 VA: 0x167F70
	private float AttackKnockbackPower; // 0x34
	private Collider HitCollider; // 0x38
	private ParticleSystem VolcanicEffect; // 0x40
	private ParticleSystem SignEffect; // 0x48
	private DamageInfo DamageInfo; // 0x50
	private SEController SEController; // 0xD0
	private bool sign; // 0xD8

	// Methods

	// RVA: 0x1EA9F20 Offset: 0x1EAA021 VA: 0x1EA9F20 Slot: 7
	public override void SetGimmickState(bool newState) { }

	// RVA: 0x1EA9F30 Offset: 0x1EAA031 VA: 0x1EA9F30 Slot: 9
	public override void Init() { }

	// RVA: 0x1EA9F40 Offset: 0x1EAA041 VA: 0x1EA9F40
	private void Awake() { }

	// RVA: 0x1EA9FC0 Offset: 0x1EAA0C1 VA: 0x1EA9FC0
	private void Update() { }

	// RVA: 0x1EAA180 Offset: 0x1EAA281 VA: 0x1EAA180
	private void StartVolcanicMagma() { }

	// RVA: 0x1EAA340 Offset: 0x1EAA441 VA: 0x1EAA340
	private void StartEffect() { }

	// RVA: 0x1EAA620 Offset: 0x1EAA721 VA: 0x1EAA620
	private void StopVolcanicMagma() { }

	// RVA: 0x1EAA660 Offset: 0x1EAA761 VA: 0x1EAA660
	private void StopEffect() { }

	// RVA: 0x1EAA060 Offset: 0x1EAA161 VA: 0x1EAA060
	private void StartSignEffect() { }

	// RVA: 0x1EAA2A0 Offset: 0x1EAA3A1 VA: 0x1EAA2A0
	private void StopSignEffect() { }

	// RVA: 0x1EAA750 Offset: 0x1EAA851 VA: 0x1EAA750
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x1EAABA0 Offset: 0x1EAACA1 VA: 0x1EAABA0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1F10 Offset: 0x1A2011 VA: 0x1A1F10
	// RVA: 0x1EAABC0 Offset: 0x1EAACC1 VA: 0x1EAABC0
	private void <StartVolcanicMagma>b__19_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1F20 Offset: 0x1A2021 VA: 0x1A1F20
	// RVA: 0x1EAAC00 Offset: 0x1EAAD01 VA: 0x1EAAC00
	private void <StartEffect>b__20_0(ParticleSystem effect) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1F30 Offset: 0x1A2031 VA: 0x1A1F30
	// RVA: 0x1EAAC80 Offset: 0x1EAAD81 VA: 0x1EAAC80
	private void <StartSignEffect>b__23_0(ParticleSystem effect) { }
}

