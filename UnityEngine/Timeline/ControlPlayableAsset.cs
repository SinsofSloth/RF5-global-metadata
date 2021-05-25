[NotKeyableAttribute] // RVA: 0x12A770 Offset: 0x12A871 VA: 0x12A770
[Serializable]
public class ControlPlayableAsset : PlayableAsset, IPropertyPreview, ITimelineClipAsset // TypeDefIndex: 4573
{
	// Fields
	private const int k_MaxRandInt = 10000;
	private static readonly List<PlayableDirector> k_EmptyDirectorsList; // 0x0
	private static readonly List<ParticleSystem> k_EmptyParticlesList; // 0x8
	private static readonly HashSet<ParticleSystem> s_SubEmitterCollector; // 0x10
	[SerializeField] // RVA: 0x12BAC0 Offset: 0x12BBC1 VA: 0x12BAC0
	public ExposedReference<GameObject> sourceGameObject; // 0x18
	[SerializeField] // RVA: 0x12BAD0 Offset: 0x12BBD1 VA: 0x12BAD0
	public GameObject prefabGameObject; // 0x28
	[SerializeField] // RVA: 0x12BAE0 Offset: 0x12BBE1 VA: 0x12BAE0
	public bool updateParticle; // 0x30
	[SerializeField] // RVA: 0x12BAF0 Offset: 0x12BBF1 VA: 0x12BAF0
	public uint particleRandomSeed; // 0x34
	[SerializeField] // RVA: 0x12BB00 Offset: 0x12BC01 VA: 0x12BB00
	public bool updateDirector; // 0x38
	[SerializeField] // RVA: 0x12BB10 Offset: 0x12BC11 VA: 0x12BB10
	public bool updateITimeControl; // 0x39
	[SerializeField] // RVA: 0x12BB20 Offset: 0x12BC21 VA: 0x12BB20
	public bool searchHierarchy; // 0x3A
	[SerializeField] // RVA: 0x12BB30 Offset: 0x12BC31 VA: 0x12BB30
	public bool active; // 0x3B
	[SerializeField] // RVA: 0x12BB40 Offset: 0x12BC41 VA: 0x12BB40
	public ActivationControlPlayable.PostPlaybackState postPlayback; // 0x3C
	private PlayableAsset m_ControlDirectorAsset; // 0x40
	private double m_Duration; // 0x48
	private bool m_SupportLoop; // 0x50
	private static HashSet<PlayableDirector> s_ProcessedDirectors; // 0x18
	private static HashSet<GameObject> s_CreatedPrefabs; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x12BB50 Offset: 0x12BC51 VA: 0x12BB50
	private bool <controllingDirectors>k__BackingField; // 0x51
	[CompilerGeneratedAttribute] // RVA: 0x12BB60 Offset: 0x12BC61 VA: 0x12BB60
	private bool <controllingParticles>k__BackingField; // 0x52

	// Properties
	internal bool controllingDirectors { get; set; }
	internal bool controllingParticles { get; set; }
	public override double duration { get; }
	public ClipCaps clipCaps { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x12C260 Offset: 0x12C361 VA: 0x12C260
	// RVA: 0x17DA780 Offset: 0x17DA881 VA: 0x17DA780
	internal bool get_controllingDirectors() { }

	[CompilerGeneratedAttribute] // RVA: 0x12C270 Offset: 0x12C371 VA: 0x12C270
	// RVA: 0x17DA790 Offset: 0x17DA891 VA: 0x17DA790
	private void set_controllingDirectors(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12C280 Offset: 0x12C381 VA: 0x12C280
	// RVA: 0x17DA7A0 Offset: 0x17DA8A1 VA: 0x17DA7A0
	internal bool get_controllingParticles() { }

	[CompilerGeneratedAttribute] // RVA: 0x12C290 Offset: 0x12C391 VA: 0x12C290
	// RVA: 0x17DA7B0 Offset: 0x17DA8B1 VA: 0x17DA7B0
	private void set_controllingParticles(bool value) { }

	// RVA: 0x17DA7C0 Offset: 0x17DA8C1 VA: 0x17DA7C0
	public void OnEnable() { }

	// RVA: 0x17DA800 Offset: 0x17DA901 VA: 0x17DA800 Slot: 7
	public override double get_duration() { }

	// RVA: 0x17DA810 Offset: 0x17DA911 VA: 0x17DA810 Slot: 10
	public ClipCaps get_clipCaps() { }

	// RVA: 0x17DA820 Offset: 0x17DA921 VA: 0x17DA820 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x17DCCB0 Offset: 0x17DCDB1 VA: 0x17DCCB0
	private static Playable ConnectPlayablesToMixer(PlayableGraph graph, List<Playable> playables) { }

	// RVA: 0x17DBCB0 Offset: 0x17DBDB1 VA: 0x17DBCB0
	private void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<Playable> outplayables) { }

	// RVA: 0x17DC210 Offset: 0x17DC311 VA: 0x17DC210
	private void SearchHierarchyAndConnectParticleSystem(IEnumerable<ParticleSystem> particleSystems, PlayableGraph graph, List<Playable> outplayables) { }

	// RVA: 0x17DBDC0 Offset: 0x17DBEC1 VA: 0x17DBDC0
	private void SearchHierarchyAndConnectDirector(IEnumerable<PlayableDirector> directors, PlayableGraph graph, List<Playable> outplayables, bool disableSelfReferences) { }

	// RVA: 0x17DC7D0 Offset: 0x17DC8D1 VA: 0x17DC7D0
	private static void SearchHierarchyAndConnectControlableScripts(IEnumerable<MonoBehaviour> controlableScripts, PlayableGraph graph, List<Playable> outplayables) { }

	// RVA: 0x17DCE80 Offset: 0x17DCF81 VA: 0x17DCE80
	private static void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex) { }

	// RVA: -1 Offset: -1
	internal IList<T> GetComponent<T>(GameObject gameObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AA250 Offset: 0x21AA351 VA: 0x21AA250
	|-ControlPlayableAsset.GetComponent<object>
	|-ControlPlayableAsset.GetComponent<PlayableDirector>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x12C2A0 Offset: 0x12C3A1 VA: 0x12C2A0
	// RVA: 0x17DC740 Offset: 0x17DC841 VA: 0x17DC740
	internal static IEnumerable<MonoBehaviour> GetControlableScripts(GameObject root) { }

	// RVA: 0x17DB2D0 Offset: 0x17DB3D1 VA: 0x17DB2D0
	internal void UpdateDurationAndLoopFlag(IList<PlayableDirector> directors, IList<ParticleSystem> particleSystems) { }

	// RVA: 0x17DB190 Offset: 0x17DB291 VA: 0x17DB190
	private IList<ParticleSystem> GetControllableParticleSystems(GameObject go) { }

	// RVA: 0x17DD3F0 Offset: 0x17DD4F1 VA: 0x17DD3F0
	private static void GetControllableParticleSystems(Transform t, ICollection<ParticleSystem> roots, HashSet<ParticleSystem> subEmitters) { }

	// RVA: 0x17DD5D0 Offset: 0x17DD6D1 VA: 0x17DD5D0
	private static void CacheSubEmitters(ParticleSystem ps, HashSet<ParticleSystem> subEmitters) { }

	// RVA: 0x17DD720 Offset: 0x17DD821 VA: 0x17DD720 Slot: 9
	public void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x17DDA90 Offset: 0x17DDB91 VA: 0x17DDA90
	internal static void PreviewParticles(IPropertyCollector driver, IEnumerable<ParticleSystem> particles) { }

	// RVA: 0x17DDE90 Offset: 0x17DDF91 VA: 0x17DDE90
	internal static void PreviewActivation(IPropertyCollector driver, IEnumerable<GameObject> objects) { }

	// RVA: 0x17DE290 Offset: 0x17DE391 VA: 0x17DE290
	internal static void PreviewTimeControl(IPropertyCollector driver, PlayableDirector director, IEnumerable<MonoBehaviour> scripts) { }

	// RVA: 0x17DE670 Offset: 0x17DE771 VA: 0x17DE670
	internal static void PreviewDirectors(IPropertyCollector driver, IEnumerable<PlayableDirector> directors) { }

	// RVA: 0x17DECE0 Offset: 0x17DEDE1 VA: 0x17DECE0
	public void .ctor() { }

	// RVA: 0x17DED80 Offset: 0x17DEE81 VA: 0x17DED80
	private static void .cctor() { }
}

