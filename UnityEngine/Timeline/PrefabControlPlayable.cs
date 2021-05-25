public class PrefabControlPlayable : PlayableBehaviour // TypeDefIndex: 4608
{
	// Fields
	private GameObject m_Instance; // 0x10

	// Properties
	public GameObject prefabInstance { get; }

	// Methods

	// RVA: 0x17DB060 Offset: 0x17DB161 VA: 0x17DB060
	public static ScriptPlayable<PrefabControlPlayable> Create(PlayableGraph graph, GameObject prefabGameObject, Transform parentTransform) { }

	// RVA: 0x17E43B0 Offset: 0x17E44B1 VA: 0x17E43B0
	public GameObject get_prefabInstance() { }

	// RVA: 0x17E4110 Offset: 0x17E4211 VA: 0x17E4110
	public GameObject Initialize(GameObject prefabGameObject, Transform parentTransform) { }

	// RVA: 0x17E46A0 Offset: 0x17E47A1 VA: 0x17E46A0 Slot: 16
	public override void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x17E47A0 Offset: 0x17E48A1 VA: 0x17E47A0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x17E4840 Offset: 0x17E4941 VA: 0x17E4840 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x17E43C0 Offset: 0x17E44C1 VA: 0x17E43C0
	private static void SetHideFlagsRecursive(GameObject gameObject) { }

	// RVA: 0x17E4900 Offset: 0x17E4A01 VA: 0x17E4900
	public void .ctor() { }
}

