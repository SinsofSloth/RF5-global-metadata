public class FieldTreasureBoxSpawner : MonoBehaviour // TypeDefIndex: 10522
{
	// Fields
	protected int BoxSpawnID; // 0x18
	[SerializeField] // RVA: 0x181D60 Offset: 0x181E61 VA: 0x181D60
	public string GateDataIDName; // 0x20
	[HideInInspector] // RVA: 0x181D70 Offset: 0x181E71 VA: 0x181D70
	public GateDataID GateDataID; // 0x28
	public GameObject SpawnObject; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x181D80 Offset: 0x181E81 VA: 0x181D80
	private bool <IsInit>k__BackingField; // 0x38

	// Properties
	public bool IsInit { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AFC90 Offset: 0x1AFD91 VA: 0x1AFC90
	// RVA: 0x1E33530 Offset: 0x1E33631 VA: 0x1E33530
	public bool get_IsInit() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AFCA0 Offset: 0x1AFDA1 VA: 0x1AFCA0
	// RVA: 0x1E33540 Offset: 0x1E33641 VA: 0x1E33540
	public void set_IsInit(bool value) { }

	// RVA: 0x1E33550 Offset: 0x1E33651 VA: 0x1E33550 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x1E33570 Offset: 0x1E33671 VA: 0x1E33570 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x1E33590 Offset: 0x1E33691 VA: 0x1E33590 Slot: 6
	public virtual void Spawn() { }

	// RVA: 0x1E2A040 Offset: 0x1E2A141 VA: 0x1E2A040
	public void .ctor() { }
}

