[Serializable]
public class BulletExplosion : BulletSubModule // TypeDefIndex: 6464
{
	// Fields
	[SerializeField] // RVA: 0x15CAD0 Offset: 0x15CBD1 VA: 0x15CAD0
	private BulletExplosionType type; // 0x1C
	[SerializeField] // RVA: 0x15CAE0 Offset: 0x15CBE1 VA: 0x15CAE0
	private float radius; // 0x20
	[SerializeField] // RVA: 0x15CAF0 Offset: 0x15CBF1 VA: 0x15CAF0
	private EffectID effectID; // 0x24
	[SerializeField] // RVA: 0x15CB00 Offset: 0x15CC01 VA: 0x15CB00
	private float effectScale; // 0x28
	[SerializeField] // RVA: 0x15CB10 Offset: 0x15CC11 VA: 0x15CB10
	private MagicParamID paramID; // 0x2C

	// Methods

	// RVA: 0x2066B60 Offset: 0x2066C61 VA: 0x2066B60 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x2066C00 Offset: 0x2066D01 VA: 0x2066C00 Slot: 10
	public override void OnHit(BulletBase bullet) { }

	// RVA: 0x2067480 Offset: 0x2067581 VA: 0x2067480 Slot: 11
	public override void OnDead(BulletBase bullet) { }

	// RVA: 0x2066C10 Offset: 0x2066D11 VA: 0x2066C10
	private void DoExplosion(BulletBase bullet) { }

	// RVA: 0x2067490 Offset: 0x2067591 VA: 0x2067490
	public void .ctor() { }
}

