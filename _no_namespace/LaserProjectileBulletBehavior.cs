public class LaserProjectileBulletBehavior : ProjectileBulletBehaviorBase // TypeDefIndex: 8393
{
	// Fields
	private EffectID LaunchPointEffectID; // 0x18
	private EffectID MainEffectID; // 0x1C
	private EffectID HitEffectID; // 0x20
	private float LaserWidth; // 0x24
	private float MaxLength; // 0x28
	private float LaserSpeed; // 0x2C
	private float CurrentLength; // 0x30
	private float EffectTime; // 0x34
	private bool IsActiveHitEffect; // 0x38
	private CapsuleCollider CapsuleCollider; // 0x40
	private Transform LaunchPointEffectTransform; // 0x48
	private Transform MainEffectTransform; // 0x50
	private Transform HitEffectTransform; // 0x58
	private ParticleSystem LaunchPointEffect; // 0x60
	private ParticleSystem MainEffect; // 0x68
	private ParticleSystem HitEffect; // 0x70
	private bool IsLaserEnd; // 0x78
	private bool IsForcePenetration; // 0x79
	private RaycastHit[] RaycastHits; // 0x80
	private List<int> SelfColliderIDCheckList; // 0x88

	// Methods

	// RVA: 0x2182A10 Offset: 0x2182B11 VA: 0x2182A10
	public void .ctor(float maxLength, float laserSpeed, EffectID effectID, EffectID hitEffectID, EffectID launchPointEffectID, float effectTime, bool isForcePenetration) { }

	// RVA: 0x2182B20 Offset: 0x2182C21 VA: 0x2182B20 Slot: 6
	public override void Setup(ProjectileBulletBase projectileBulletBase) { }

	// RVA: 0x2182BA0 Offset: 0x2182CA1 VA: 0x2182BA0 Slot: 7
	public override void Start() { }

	// RVA: 0x2183070 Offset: 0x2183171 VA: 0x2183070 Slot: 8
	public override void BeginUpdate() { }

	// RVA: 0x2183170 Offset: 0x2183271 VA: 0x2183170
	private void UpdateHitObject() { }

	// RVA: 0x2182F10 Offset: 0x2183011 VA: 0x2182F10
	private void UpdateCurrentLaserLength(float length) { }

	// RVA: 0x21834E0 Offset: 0x21835E1 VA: 0x21834E0
	private void UpdateEndEffect() { }

	// RVA: 0x2183550 Offset: 0x2183651 VA: 0x2183550
	private void DisableParticleEmission() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A73F0 Offset: 0x1A74F1 VA: 0x1A73F0
	// RVA: 0x21837D0 Offset: 0x21838D1 VA: 0x21837D0
	private void <Start>b__22_0(ParticleSystem startEffect) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7400 Offset: 0x1A7501 VA: 0x1A7400
	// RVA: 0x21838D0 Offset: 0x21839D1 VA: 0x21838D0
	private void <Start>b__22_1(ParticleSystem lastEffect) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7410 Offset: 0x1A7511 VA: 0x1A7410
	// RVA: 0x21839D0 Offset: 0x2183AD1 VA: 0x21839D0
	private void <Start>b__22_2(ParticleSystem mainEffect) { }
}

