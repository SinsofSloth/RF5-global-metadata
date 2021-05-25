public abstract class SRMonoBehaviourEx : SRMonoBehaviour // TypeDefIndex: 4301
{
	// Fields
	private static Dictionary<Type, IList<SRMonoBehaviourEx.FieldInfo>> _checkedFields; // 0x0

	// Methods

	// RVA: 0x1A815A0 Offset: 0x1A816A1 VA: 0x1A815A0
	private static void CheckFields(SRMonoBehaviourEx instance, bool justSet = False) { }

	// RVA: 0x1A819D0 Offset: 0x1A81AD1 VA: 0x1A819D0
	private static void PopulateObject(IList<SRMonoBehaviourEx.FieldInfo> cache, SRMonoBehaviourEx instance, bool justSet) { }

	// RVA: 0x1A816E0 Offset: 0x1A817E1 VA: 0x1A816E0
	private static List<SRMonoBehaviourEx.FieldInfo> ScanType(Type t) { }

	// RVA: 0x1A82100 Offset: 0x1A82201 VA: 0x1A82100 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1A82110 Offset: 0x1A82211 VA: 0x1A82110 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x1A82120 Offset: 0x1A82221 VA: 0x1A82120 Slot: 6
	protected virtual void Update() { }

	// RVA: 0x1A82130 Offset: 0x1A82231 VA: 0x1A82130 Slot: 7
	protected virtual void FixedUpdate() { }

	// RVA: 0x1A82140 Offset: 0x1A82241 VA: 0x1A82140 Slot: 8
	protected virtual void OnEnable() { }

	// RVA: 0x1A82150 Offset: 0x1A82251 VA: 0x1A82150 Slot: 9
	protected virtual void OnDisable() { }

	// RVA: 0x1A82160 Offset: 0x1A82261 VA: 0x1A82160 Slot: 10
	protected virtual void OnDestroy() { }

	// RVA: 0x1A82170 Offset: 0x1A82271 VA: 0x1A82170
	protected void .ctor() { }
}

