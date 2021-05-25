public class AracneCageWeb : MonoBehaviour // TypeDefIndex: 7785
{
	// Fields
	[SerializeField] // RVA: 0x169960 Offset: 0x169A61 VA: 0x169960
	private float DestoryTime; // 0x18
	private float ElapasedTimer; // 0x1C
	[SerializeField] // RVA: 0x169970 Offset: 0x169A71 VA: 0x169970
	private float CatchTime; // 0x20
	[SerializeField] // RVA: 0x169980 Offset: 0x169A81 VA: 0x169980
	private int LeverGatyaMax; // 0x24
	private int LeverGatyaCounter; // 0x28
	private bool IsCtrlChara; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x169990 Offset: 0x169A91 VA: 0x169990
	private Character <CatchCharacter>k__BackingField; // 0x30
	private bool IsBreak; // 0x38
	public Action EndCallback; // 0x40
	public Alliance Alliance; // 0x48
	[SerializeField] // RVA: 0x1699A0 Offset: 0x169AA1 VA: 0x1699A0
	private ParticleSystem StartEffect; // 0x50
	[SerializeField] // RVA: 0x1699B0 Offset: 0x169AB1 VA: 0x1699B0
	private ParticleSystem LoopEffect; // 0x58
	[SerializeField] // RVA: 0x1699C0 Offset: 0x169AC1 VA: 0x1699C0
	private ParticleSystem BreakLoopEffect; // 0x60
	[SerializeField] // RVA: 0x1699D0 Offset: 0x169AD1 VA: 0x1699D0
	private ParticleSystem EndEffect; // 0x68
	[SerializeField] // RVA: 0x1699E0 Offset: 0x169AE1 VA: 0x1699E0
	private ParticleSystem GatyaEffect; // 0x70

	// Properties
	public Character CatchCharacter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A2C70 Offset: 0x1A2D71 VA: 0x1A2C70
	// RVA: 0x227BFF0 Offset: 0x227C0F1 VA: 0x227BFF0
	public Character get_CatchCharacter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2C80 Offset: 0x1A2D81 VA: 0x1A2C80
	// RVA: 0x227C000 Offset: 0x227C101 VA: 0x227C000
	private void set_CatchCharacter(Character value) { }

	// RVA: 0x227C010 Offset: 0x227C111 VA: 0x227C010
	private void Start() { }

	// RVA: 0x227C120 Offset: 0x227C221 VA: 0x227C120
	private void OnDestroy() { }

	// RVA: 0x227C250 Offset: 0x227C351 VA: 0x227C250
	private void Update() { }

	// RVA: 0x227C7E0 Offset: 0x227C8E1 VA: 0x227C7E0
	private void Catch(Character character) { }

	// RVA: 0x227C3E0 Offset: 0x227C4E1 VA: 0x227C3E0
	private void Gatya() { }

	// RVA: 0x227C5A0 Offset: 0x227C6A1 VA: 0x227C5A0
	private void Break() { }

	// RVA: 0x227C620 Offset: 0x227C721 VA: 0x227C620
	public void End() { }

	// RVA: 0x227C950 Offset: 0x227CA51 VA: 0x227C950
	private void RideOn(MonsterControllerBase monster) { }

	// RVA: 0x227CA70 Offset: 0x227CB71 VA: 0x227CA70
	private void RideEnd(MonsterControllerBase monster) { }

	// RVA: 0x227CB00 Offset: 0x227CC01 VA: 0x227CB00
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x227CDC0 Offset: 0x227CEC1 VA: 0x227CDC0
	public void .ctor() { }
}

