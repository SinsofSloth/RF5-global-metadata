[AddComponentMenu] // RVA: 0x12D170 Offset: 0x12D271 VA: 0x12D170
public class VariableSynchronizer : MonoBehaviour // TypeDefIndex: 4700
{
	// Fields
	[SerializeField] // RVA: 0x12D730 Offset: 0x12D831 VA: 0x12D730
	private UpdateIntervalType updateInterval; // 0x18
	[SerializeField] // RVA: 0x12D740 Offset: 0x12D841 VA: 0x12D740
	private float updateIntervalSeconds; // 0x1C
	private WaitForSeconds updateWait; // 0x20
	[SerializeField] // RVA: 0x12D750 Offset: 0x12D851 VA: 0x12D750
	private List<VariableSynchronizer.SynchronizedVariable> synchronizedVariables; // 0x28

	// Properties
	public UpdateIntervalType UpdateInterval { get; set; }
	public float UpdateIntervalSeconds { get; set; }
	public List<VariableSynchronizer.SynchronizedVariable> SynchronizedVariables { get; set; }

	// Methods

	// RVA: 0x1B24B40 Offset: 0x1B24C41 VA: 0x1B24B40
	public void .ctor() { }

	// RVA: 0x1B24BC0 Offset: 0x1B24CC1 VA: 0x1B24BC0
	public UpdateIntervalType get_UpdateInterval() { }

	// RVA: 0x1B24BD0 Offset: 0x1B24CD1 VA: 0x1B24BD0
	public void set_UpdateInterval(UpdateIntervalType value) { }

	// RVA: 0x1B24CC0 Offset: 0x1B24DC1 VA: 0x1B24CC0
	public float get_UpdateIntervalSeconds() { }

	// RVA: 0x1B24CD0 Offset: 0x1B24DD1 VA: 0x1B24CD0
	public void set_UpdateIntervalSeconds(float value) { }

	// RVA: 0x1B24CE0 Offset: 0x1B24DE1 VA: 0x1B24CE0
	public List<VariableSynchronizer.SynchronizedVariable> get_SynchronizedVariables() { }

	// RVA: 0x1B24CF0 Offset: 0x1B24DF1 VA: 0x1B24CF0
	public void set_SynchronizedVariables(List<VariableSynchronizer.SynchronizedVariable> value) { }

	// RVA: 0x1B24BE0 Offset: 0x1B24CE1 VA: 0x1B24BE0
	private void UpdateIntervalChanged() { }

	// RVA: 0x1B24D20 Offset: 0x1B24E21 VA: 0x1B24D20
	public void Awake() { }

	// RVA: 0x1B259E0 Offset: 0x1B25AE1 VA: 0x1B259E0
	public void Update() { }

	[DebuggerHiddenAttribute] // RVA: 0x12DAE0 Offset: 0x12DBE1 VA: 0x12DAE0
	// RVA: 0x1B25DC0 Offset: 0x1B25EC1 VA: 0x1B25DC0
	private IEnumerator CoroutineUpdate() { }

	// RVA: 0x1B259F0 Offset: 0x1B25AF1 VA: 0x1B259F0
	public void Tick() { }

	// RVA: 0x1B256A0 Offset: 0x1B257A1 VA: 0x1B256A0
	private static Func<object> CreateGetDelegate(object instance, MethodInfo method) { }

	// RVA: 0x1B257C0 Offset: 0x1B258C1 VA: 0x1B257C0
	private static Action<object> CreateSetDelegate(object instance, MethodInfo method) { }
}

