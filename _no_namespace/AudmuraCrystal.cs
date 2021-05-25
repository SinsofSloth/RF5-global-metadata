public class AudmuraCrystal : CharacterBase // TypeDefIndex: 7808
{
	// Fields
	private MonsterProjectileActionScriptsController MonsterProjectileActionScriptsController; // 0x68
	private InstantCountStatus Status; // 0x70
	[SerializeField] // RVA: 0x169AB0 Offset: 0x169BB1 VA: 0x169AB0
	private ParticleSystem CrystalPartileSystem; // 0x78
	[SerializeField] // RVA: 0x169AC0 Offset: 0x169BC1 VA: 0x169AC0
	private ParticleSystem EndParticleSystem; // 0x80
	private bool isHit; // 0x88

	// Properties
	public override Alliance Alliance { get; }
	public override Vector3 GetTakeLockonPos { get; }

	// Methods

	// RVA: 0x2149A20 Offset: 0x2149B21 VA: 0x2149A20 Slot: 8
	public override Alliance get_Alliance() { }

	// RVA: 0x2149A30 Offset: 0x2149B31 VA: 0x2149A30 Slot: 10
	public override Vector3 get_GetTakeLockonPos() { }

	// RVA: 0x2149B10 Offset: 0x2149C11 VA: 0x2149B10 Slot: 12
	protected override void Start() { }

	// RVA: 0x2149160 Offset: 0x2149261 VA: 0x2149160
	public void CreateEffect(bool isVariation) { }

	// RVA: 0x2149B50 Offset: 0x2149C51 VA: 0x2149B50
	public void Setup(MonsterProjectileActionScriptsController projectile, int maxHP) { }

	// RVA: 0x2149D40 Offset: 0x2149E41 VA: 0x2149D40 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage) { }

	// RVA: 0x21495C0 Offset: 0x21496C1 VA: 0x21495C0
	public void End() { }

	// RVA: 0x2149E30 Offset: 0x2149F31 VA: 0x2149E30
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x2149FE0 Offset: 0x214A0E1 VA: 0x2149FE0
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x214A140 Offset: 0x214A241 VA: 0x214A140
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2F40 Offset: 0x1A3041 VA: 0x1A2F40
	// RVA: 0x214A150 Offset: 0x214A251 VA: 0x214A150
	private void <CreateEffect>b__10_0(ParticleSystem particle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2F50 Offset: 0x1A3051 VA: 0x1A2F50
	// RVA: 0x214A2B0 Offset: 0x214A3B1 VA: 0x214A2B0
	private void <CreateEffect>b__10_1(ParticleSystem particle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2F60 Offset: 0x1A3061 VA: 0x1A2F60
	// RVA: 0x214A430 Offset: 0x214A531 VA: 0x214A430
	private void <CreateEffect>b__10_2(ParticleSystem particle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2F70 Offset: 0x1A3071 VA: 0x1A2F70
	// RVA: 0x214A590 Offset: 0x214A691 VA: 0x214A590
	private void <CreateEffect>b__10_3(ParticleSystem particle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2F80 Offset: 0x1A3081 VA: 0x1A2F80
	// RVA: 0x214A710 Offset: 0x214A811 VA: 0x214A710
	private void <Setup>b__11_0(Collider other) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2F90 Offset: 0x1A3091 VA: 0x1A2F90
	// RVA: 0x214A840 Offset: 0x214A941 VA: 0x214A840
	private void <Setup>b__11_1() { }
}

