public class MannequinManager : MonoBehaviour // TypeDefIndex: 6314
{
	// Fields
	[SerializeField] // RVA: 0x15C0C0 Offset: 0x15C1C1 VA: 0x15C0C0
	[HeaderAttribute] // RVA: 0x15C0C0 Offset: 0x15C1C1 VA: 0x15C0C0
	private int MANNEQIN_CACHE_MAX; // 0x18
	private int ManneqinEnableMax; // 0x1C
	private List<Actor> Manneqins; // 0x20
	private List<Actor> DeleteManneqins; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15C110 Offset: 0x15C211 VA: 0x15C110
	private static MannequinManager <Instance>k__BackingField; // 0x0

	// Properties
	private static MannequinManager Instance { get; set; }

	// Methods

	// RVA: 0x1E12270 Offset: 0x1E12371 VA: 0x1E12270
	public static void Add(ActorID actor_id) { }

	// RVA: 0x1E12630 Offset: 0x1E12731 VA: 0x1E12630
	public static Actor GetMannequin() { }

	// RVA: 0x1E12770 Offset: 0x1E12871 VA: 0x1E12770
	public static Actor GetActor(ActorID actorId) { }

	// RVA: 0x1E128B0 Offset: 0x1E129B1 VA: 0x1E128B0
	public static void Clear() { }

	[CompilerGeneratedAttribute] // RVA: 0x19ABF0 Offset: 0x19ACF1 VA: 0x19ABF0
	// RVA: 0x1E12910 Offset: 0x1E12A11 VA: 0x1E12910
	private static MannequinManager get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AC00 Offset: 0x19AD01 VA: 0x19AC00
	// RVA: 0x1E12960 Offset: 0x1E12A61 VA: 0x1E12960
	private static void set_Instance(MannequinManager value) { }

	// RVA: 0x1E129C0 Offset: 0x1E12AC1 VA: 0x1E129C0
	private void Awake() { }

	// RVA: 0x1E12AA0 Offset: 0x1E12BA1 VA: 0x1E12AA0
	private void OnDestroy() { }

	// RVA: 0x1E122E0 Offset: 0x1E123E1 VA: 0x1E122E0
	private void CreateMannequin(ActorID actor_id) { }

	// RVA: 0x1E12CB0 Offset: 0x1E12DB1 VA: 0x1E12CB0
	private void Update() { }

	// RVA: 0x1E13000 Offset: 0x1E13101 VA: 0x1E13000
	public void .ctor() { }
}

