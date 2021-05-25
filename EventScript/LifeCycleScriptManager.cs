public class LifeCycleScriptManager : MonoBehaviour // TypeDefIndex: 10423
{
	// Fields
	private Dictionary<ActorID, LifeCycleScriptPlayer> player_; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x181850 Offset: 0x181951 VA: 0x181850
	private bool <IsReady>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x181860 Offset: 0x181961 VA: 0x181860
	private bool <IsActive>k__BackingField; // 0x21
	private static readonly Dictionary<ActorID, int> DataId; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x181870 Offset: 0x181971 VA: 0x181870
	private static LifeCycleScriptManager <Instance>k__BackingField; // 0x8

	// Properties
	public bool IsReady { get; set; }
	public bool IsActive { get; set; }
	public static bool Active { get; }
	public static LifeCycleScriptManager Instance { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AF250 Offset: 0x1AF351 VA: 0x1AF250
	// RVA: 0x2074BD0 Offset: 0x2074CD1 VA: 0x2074BD0
	public bool get_IsReady() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF260 Offset: 0x1AF361 VA: 0x1AF260
	// RVA: 0x2074BE0 Offset: 0x2074CE1 VA: 0x2074BE0
	private void set_IsReady(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF270 Offset: 0x1AF371 VA: 0x1AF270
	// RVA: 0x2074BF0 Offset: 0x2074CF1 VA: 0x2074BF0
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF280 Offset: 0x1AF381 VA: 0x1AF280
	// RVA: 0x2074C00 Offset: 0x2074D01 VA: 0x2074C00
	private void set_IsActive(bool value) { }

	// RVA: 0x2074C10 Offset: 0x2074D11 VA: 0x2074C10
	public static bool get_Active() { }

	// RVA: 0x2074E20 Offset: 0x2074F21 VA: 0x2074E20
	public static void Add(ActorID actorID) { }

	// RVA: 0x2075040 Offset: 0x2075141 VA: 0x2075040
	public static void Del(ActorID actorID) { }

	// RVA: 0x20751E0 Offset: 0x20752E1 VA: 0x20751E0
	public static void Play(ActorID actorID) { }

	// RVA: 0x20753A0 Offset: 0x20754A1 VA: 0x20753A0
	public static void PlayAll() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF290 Offset: 0x1AF391 VA: 0x1AF290
	// RVA: 0x2075620 Offset: 0x2075721 VA: 0x2075620
	public static LifeCycleScriptManager get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF2A0 Offset: 0x1AF3A1 VA: 0x1AF2A0
	// RVA: 0x2075690 Offset: 0x2075791 VA: 0x2075690
	private static void set_Instance(LifeCycleScriptManager value) { }

	// RVA: 0x20754F0 Offset: 0x20755F1 VA: 0x20754F0
	private void Init() { }

	// RVA: 0x2075700 Offset: 0x2075801 VA: 0x2075700
	private void Quit() { }

	// RVA: 0x2075770 Offset: 0x2075871 VA: 0x2075770
	private void Awake() { }

	// RVA: 0x20758C0 Offset: 0x20759C1 VA: 0x20758C0
	private void OnDestroy() { }

	// RVA: 0x2074F10 Offset: 0x2075011 VA: 0x2074F10
	private void ScrAdd(ActorID actorID) { }

	// RVA: 0x2075170 Offset: 0x2075271 VA: 0x2075170
	private void ScrDel(ActorID actorID) { }

	// RVA: 0x2075320 Offset: 0x2075421 VA: 0x2075320
	private void ScrPlay(ActorID actorID) { }

	// RVA: 0x2075500 Offset: 0x2075601 VA: 0x2075500
	private void ScrPlay() { }

	// RVA: 0x2075A80 Offset: 0x2075B81 VA: 0x2075A80
	private void Start() { }

	// RVA: 0x2075980 Offset: 0x2075A81 VA: 0x2075980
	private void Load(ActorID actorID, int id) { }

	// RVA: 0x2075AA0 Offset: 0x2075BA1 VA: 0x2075AA0
	private void Update() { }

	// RVA: 0x2075F00 Offset: 0x2076001 VA: 0x2075F00
	public void NpcLifeCycleDataLoad(ActorID actorID, int loaderId, Action callback) { }

	// RVA: 0x2076010 Offset: 0x2076111 VA: 0x2076010
	public void .ctor() { }

	// RVA: 0x2076090 Offset: 0x2076191 VA: 0x2076090
	private static void .cctor() { }
}

