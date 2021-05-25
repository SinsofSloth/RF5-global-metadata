public class GateEnemyModelContainer : CharacterModel // TypeDefIndex: 7870
{
	// Fields
	private Dictionary<GateEnemyModelContainer.GateType, EffectID> DisapperEffectDic; // 0x68
	public ParticleSystem DefaultEffect; // 0x70
	public GateEnemyModelContainer.GateType SelectGateType; // 0x78

	// Properties
	public EffectID DisapperEffectID { get; }
	public EffectID SummonEffectID { get; }
	public EffectID DamageEffectID { get; }

	// Methods

	// RVA: 0x1E45A70 Offset: 0x1E45B71 VA: 0x1E45A70
	public EffectID get_DisapperEffectID() { }

	// RVA: 0x1E45390 Offset: 0x1E45491 VA: 0x1E45390
	public EffectID get_SummonEffectID() { }

	// RVA: 0x1E45620 Offset: 0x1E45721 VA: 0x1E45620
	public EffectID get_DamageEffectID() { }

	// RVA: 0x1E45190 Offset: 0x1E45291 VA: 0x1E45190
	public void Setup(Vector3 offset) { }

	// RVA: 0x1E45C30 Offset: 0x1E45D31 VA: 0x1E45C30
	public void .ctor() { }
}

