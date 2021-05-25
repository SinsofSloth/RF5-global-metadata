[Serializable]
public class HitEffectBase // TypeDefIndex: 7616
{
	// Fields
	[SerializeField] // RVA: 0x168540 Offset: 0x168641 VA: 0x168540
	public string EffectName; // 0x10
	[SerializeField] // RVA: 0x168550 Offset: 0x168651 VA: 0x168550
	public EffectID EffectId; // 0x18
	[SerializeField] // RVA: 0x168560 Offset: 0x168661 VA: 0x168560
	public Vector3 Position; // 0x1C
	[SerializeField] // RVA: 0x168570 Offset: 0x168671 VA: 0x168570
	public Vector3 Rotation; // 0x28
	[SerializeField] // RVA: 0x168580 Offset: 0x168681 VA: 0x168580
	public Vector3 Scale; // 0x34
	protected ParticleSystem effectData; // 0x40

	// Methods

	// RVA: 0x2304A70 Offset: 0x2304B71 VA: 0x2304A70
	public void SetEffectID() { }

	// RVA: 0x2304B20 Offset: 0x2304C21 VA: 0x2304B20
	public void Copy(HitEffectBase effectUnit) { }

	// RVA: 0x2304BF0 Offset: 0x2304CF1 VA: 0x2304BF0
	public void EffectCreate(Vector3 position, Quaternion quaternion, Transform target, float speed = 1) { }

	// RVA: 0x2304EE0 Offset: 0x2304FE1 VA: 0x2304EE0 Slot: 4
	protected virtual void EffectDestroy() { }

	// RVA: 0x2304FC0 Offset: 0x23050C1 VA: 0x2304FC0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A21B0 Offset: 0x1A22B1 VA: 0x1A21B0
	// RVA: 0x2305070 Offset: 0x2305171 VA: 0x2305070
	private void <EffectCreate>b__8_0(ParticleSystem p) { }
}

