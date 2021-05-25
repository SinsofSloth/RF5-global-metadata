public class EffectManager : SingletonMonoBehaviour<EffectManager> // TypeDefIndex: 7105
{
	// Fields
	[SerializeField] // RVA: 0x162E90 Offset: 0x162F91 VA: 0x162E90
	private static List<ParticleSystem> m_PlayingList; // 0x0
	[SerializeField] // RVA: 0x162EA0 Offset: 0x162FA1 VA: 0x162EA0
	private static List<ParticleSystem> m_DeleteList; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x162EB0 Offset: 0x162FB1 VA: 0x162EB0
	private GameObject <EffectRoot>k__BackingField; // 0x18
	private static ResourceManager<GameObject> ResourceManager; // 0x10

	// Properties
	public GameObject EffectRoot { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19DDC0 Offset: 0x19DEC1 VA: 0x19DDC0
	// RVA: 0x2017000 Offset: 0x2017101 VA: 0x2017000
	public GameObject get_EffectRoot() { }

	[CompilerGeneratedAttribute] // RVA: 0x19DDD0 Offset: 0x19DED1 VA: 0x19DDD0
	// RVA: 0x2017010 Offset: 0x2017111 VA: 0x2017010
	private void set_EffectRoot(GameObject value) { }

	// RVA: 0x2017020 Offset: 0x2017121 VA: 0x2017020 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2017250 Offset: 0x2017351 VA: 0x2017250
	private void OnLoadEffectAsset(GameObject asset) { }

	// RVA: 0x20172E0 Offset: 0x20173E1 VA: 0x20172E0
	private static void LateUpdate() { }

	// RVA: 0x20175E0 Offset: 0x20176E1 VA: 0x20175E0
	private static ParticleSystem PlayEffect(EffectDataTable dataTable, bool noSE, ParticleSystem effect, float speed, Vector3 position, Quaternion rotation, Vector3 scale, Transform parent) { }

	// RVA: 0x20178B0 Offset: 0x20179B1 VA: 0x20178B0
	private static void PlaySE(SoundID soundId, Vector3 position, Transform parent) { }

	// RVA: 0x2015F70 Offset: 0x2016071 VA: 0x2015F70
	public static void Entry(EffectID id, UnityAction<ParticleSystem> callback) { }

	// RVA: 0x20179D0 Offset: 0x2017AD1 VA: 0x20179D0
	public static void Play(EffectID id, float speed, Transform parent, UnityAction<ParticleSystem> callback) { }

	// RVA: 0x2017B20 Offset: 0x2017C21 VA: 0x2017B20
	public static void Play(EffectID id, float speed, Vector3 position, Quaternion rotation, Vector3 scale, Transform parent, UnityAction<ParticleSystem> callback) { }

	// RVA: 0x2017DA0 Offset: 0x2017EA1 VA: 0x2017DA0
	public static void PlayNoSE(EffectID id, float speed, Vector3 position, Quaternion rotation, Vector3 scale, Transform parent, UnityAction<ParticleSystem> callback) { }

	// RVA: 0x2018020 Offset: 0x2018121 VA: 0x2018020
	public static void DeleteAll() { }

	// RVA: 0x2018220 Offset: 0x2018321 VA: 0x2018220
	public void .ctor() { }

	// RVA: 0x2018270 Offset: 0x2018371 VA: 0x2018270
	private static void .cctor() { }
}

