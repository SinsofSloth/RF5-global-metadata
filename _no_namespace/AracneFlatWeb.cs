public class AracneFlatWeb : CharacterBase // TypeDefIndex: 7795
{
	// Fields
	[SerializeField] // RVA: 0x1699F0 Offset: 0x169AF1 VA: 0x1699F0
	private float ToLoopTime; // 0x64
	[SerializeField] // RVA: 0x169A00 Offset: 0x169B01 VA: 0x169A00
	private float DestroyTime; // 0x68
	private bool IsLoop; // 0x6C
	private float ElapasedTimer; // 0x70
	private InstantCountStatus Status; // 0x78
	private Alliance _Alliance; // 0x80
	public Action EndCallback; // 0x88
	[SerializeField] // RVA: 0x169A10 Offset: 0x169B11 VA: 0x169A10
	private ParticleSystem StartEffect; // 0x90
	[SerializeField] // RVA: 0x169A20 Offset: 0x169B21 VA: 0x169A20
	private ParticleSystem LoopEffect; // 0x98
	[SerializeField] // RVA: 0x169A30 Offset: 0x169B31 VA: 0x169A30
	private ParticleSystem EndEffect; // 0xA0

	// Properties
	public override Alliance Alliance { get; }

	// Methods

	// RVA: 0x227F460 Offset: 0x227F561 VA: 0x227F460 Slot: 8
	public override Alliance get_Alliance() { }

	// RVA: 0x227E270 Offset: 0x227E371 VA: 0x227E270
	public void Setup(Alliance alliance) { }

	// RVA: 0x227F470 Offset: 0x227F571 VA: 0x227F470
	private void Update() { }

	// RVA: 0x227F5A0 Offset: 0x227F6A1 VA: 0x227F5A0 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x227D470 Offset: 0x227D571 VA: 0x227D470
	public void End() { }

	// RVA: 0x227F690 Offset: 0x227F791 VA: 0x227F690
	public void OnTriggerEnter(Collider other) { }

	// RVA: 0x227F970 Offset: 0x227FA71 VA: 0x227F970
	public void .ctor() { }
}

