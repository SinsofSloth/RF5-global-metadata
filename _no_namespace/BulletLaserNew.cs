public class BulletLaserNew : BulletSubModule // TypeDefIndex: 6468
{
	// Fields
	[SerializeField] // RVA: 0x15CB80 Offset: 0x15CC81 VA: 0x15CB80
	public ParticleDestroy mainParticle; // 0x20
	[SerializeField] // RVA: 0x15CB90 Offset: 0x15CC91 VA: 0x15CB90
	public ParticleDestroy lastParticle; // 0x28
	[SerializeField] // RVA: 0x15CBA0 Offset: 0x15CCA1 VA: 0x15CBA0
	public float radius; // 0x30
	[SerializeField] // RVA: 0x15CBB0 Offset: 0x15CCB1 VA: 0x15CBB0
	public float maxLength; // 0x34
	[SerializeField] // RVA: 0x15CBC0 Offset: 0x15CCC1 VA: 0x15CBC0
	public float speed; // 0x38
	[SerializeField] // RVA: 0x15CBD0 Offset: 0x15CCD1 VA: 0x15CBD0
	public LayerMask hitLayerMask; // 0x3C
	[SerializeField] // RVA: 0x15CBE0 Offset: 0x15CCE1 VA: 0x15CBE0
	public QueryTriggerInteraction queryTriggerInteraction; // 0x40
	private float currentLength; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x15CBF0 Offset: 0x15CCF1 VA: 0x15CBF0
	private bool <Penetrate>k__BackingField; // 0x48

	// Properties
	public bool Penetrate { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B2A0 Offset: 0x19B3A1 VA: 0x19B2A0
	// RVA: 0x2069370 Offset: 0x2069471 VA: 0x2069370
	public bool get_Penetrate() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B2B0 Offset: 0x19B3B1 VA: 0x19B2B0
	// RVA: 0x2069380 Offset: 0x2069481 VA: 0x2069380
	public void set_Penetrate(bool value) { }

	// RVA: 0x2069390 Offset: 0x2069491 VA: 0x2069390 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x2069420 Offset: 0x2069521 VA: 0x2069420 Slot: 9
	public override void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x2069930 Offset: 0x2069A31 VA: 0x2069930
	private void OnDrawGizmos() { }

	// RVA: 0x2069D40 Offset: 0x2069E41 VA: 0x2069D40
	public void .ctor() { }
}

