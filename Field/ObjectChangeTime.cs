public class ObjectChangeTime : MonoBehaviour // TypeDefIndex: 10457
{
	// Fields
	[SerializeField] // RVA: 0x1819D0 Offset: 0x181AD1 VA: 0x1819D0
	private TimeParamTable _TimeParamTable; // 0x18
	[SerializeField] // RVA: 0x1819E0 Offset: 0x181AE1 VA: 0x1819E0
	public GameObject[] GameObjects; // 0x20
	[SerializeField] // RVA: 0x1819F0 Offset: 0x181AF1 VA: 0x1819F0
	public Renderer[] Renderers; // 0x28
	[SerializeField] // RVA: 0x181A00 Offset: 0x181B01 VA: 0x181A00
	public ParticleSystem[] ParticleSystems; // 0x30

	// Properties
	public TimeParamTable TimeParamTable { get; set; }

	// Methods

	// RVA: 0x1EECE30 Offset: 0x1EECF31 VA: 0x1EECE30
	public TimeParamTable get_TimeParamTable() { }

	// RVA: 0x1EECE40 Offset: 0x1EECF41 VA: 0x1EECE40
	public void set_TimeParamTable(TimeParamTable value) { }

	// RVA: 0x1EECE50 Offset: 0x1EECF51 VA: 0x1EECE50
	private void OnDestroy() { }

	// RVA: 0x1EECF40 Offset: 0x1EED041 VA: 0x1EECF40
	private void Start() { }

	// RVA: 0x1EECFF0 Offset: 0x1EED0F1 VA: 0x1EECFF0 Slot: 4
	public virtual void UpdateObjectActive(bool value) { }

	// RVA: 0x1EED140 Offset: 0x1EED241 VA: 0x1EED140
	public void .ctor() { }
}

