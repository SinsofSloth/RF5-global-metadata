public class SoundManager : SingletonMonoBehaviour<SoundManager> // TypeDefIndex: 8260
{
	// Fields
	private AudioMixer MasterMixer; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16E700 Offset: 0x16E801 VA: 0x16E700
	private AudioMixerGroup[] <MixerVolumeGroups>k__BackingField; // 0x20
	[SerializeField] // RVA: 0x16E710 Offset: 0x16E811 VA: 0x16E710
	public AnimationCurve FadeInCurve; // 0x28
	[SerializeField] // RVA: 0x16E720 Offset: 0x16E821 VA: 0x16E720
	public AnimationCurve FadeOutCurve; // 0x30
	private LinkedList<BGMController> BGMControllers; // 0x38
	private LinkedList<SEController> SE2DControllers; // 0x40
	private LinkedList<VoiceController> Voice2DControllers; // 0x48
	private LinkedList<SEController> SEPool; // 0x50
	private Transform SEPoolTrans; // 0x58
	private Transform PlayTrans; // 0x60
	private const int SE3DPoolMax = 30;
	private const int BGMControllersMax = 3;
	private const int SE2DControllersMax = 20;
	private const int Voice2DControllersMax = 10;
	private HashSet<SEController> PlaySE3DSet; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x16E730 Offset: 0x16E831 VA: 0x16E730
	private AudioSource <MovieAudioSource>k__BackingField; // 0x70
	public ResourceManager<AudioClip> Resource_SE; // 0x78
	public ResourceManager<AudioClip> Resource_Voice; // 0x80
	public ResourceManager<AudioClip> Resource_BGM; // 0x88
	private AudioSource OneShotAudioSource; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x16E740 Offset: 0x16E841 VA: 0x16E740
	private BGMID <CurrentBGMID>k__BackingField; // 0x98
	[TupleElementNamesAttribute] // RVA: 0x16E750 Offset: 0x16E851 VA: 0x16E750
	private Dictionary<MixerVolumeGroup, ValueTuple<float, float>> VolumeRangeByMixerGroup; // 0xA0
	private const string TimelineTmpName = "SoundManager_TimelineTest";
	[TupleElementNamesAttribute] // RVA: 0x16E7F0 Offset: 0x16E8F1 VA: 0x16E7F0
	private Dictionary<SoundID, ValueTuple<SEController, List<EnvironmentSoundArea>>> EnvironmentAreaDictionay; // 0xA8

	// Properties
	public AudioMixerGroup[] MixerVolumeGroups { get; set; }
	public AudioSource MovieAudioSource { get; set; }
	public BGMID CurrentBGMID { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A66F0 Offset: 0x1A67F1 VA: 0x1A66F0
	// RVA: 0x2112130 Offset: 0x2112231 VA: 0x2112130
	public AudioMixerGroup[] get_MixerVolumeGroups() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6700 Offset: 0x1A6801 VA: 0x1A6700
	// RVA: 0x2112140 Offset: 0x2112241 VA: 0x2112140
	public void set_MixerVolumeGroups(AudioMixerGroup[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6710 Offset: 0x1A6811 VA: 0x1A6710
	// RVA: 0x2112150 Offset: 0x2112251 VA: 0x2112150
	public AudioSource get_MovieAudioSource() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6720 Offset: 0x1A6821 VA: 0x1A6720
	// RVA: 0x2112160 Offset: 0x2112261 VA: 0x2112160
	private void set_MovieAudioSource(AudioSource value) { }

	// RVA: 0x2112170 Offset: 0x2112271 VA: 0x2112170
	public void RemoveAllResources() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6730 Offset: 0x1A6831 VA: 0x1A6730
	// RVA: 0x2112550 Offset: 0x2112651 VA: 0x2112550
	public BGMID get_CurrentBGMID() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6740 Offset: 0x1A6841 VA: 0x1A6740
	// RVA: 0x2112560 Offset: 0x2112661 VA: 0x2112560
	private void set_CurrentBGMID(BGMID value) { }

	// RVA: 0x2112570 Offset: 0x2112671 VA: 0x2112570
	public void SetVolume(float value, MixerVolumeGroup mixerGroup) { }

	// RVA: 0x2112790 Offset: 0x2112891 VA: 0x2112790
	public float GetVolume(MixerVolumeGroup mixerGroup) { }

	// RVA: 0x2112720 Offset: 0x2112821 VA: 0x2112720
	private ValueTuple<float, float> GetDecibelRange(MixerVolumeGroup mixerGroup) { }

	// RVA: 0x21128D0 Offset: 0x21129D1 VA: 0x21128D0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2112FE0 Offset: 0x21130E1 VA: 0x2112FE0
	private void Start() { }

	// RVA: 0x2113350 Offset: 0x2113451 VA: 0x2113350
	public void Entry(BGMID id, UnityAction<AudioClip> callback, int priority = 0) { }

	// RVA: 0x2113460 Offset: 0x2113561 VA: 0x2113460
	public bool IsLoaded(BGMID id) { }

	// RVA: -1 Offset: -1
	private T FindFirstController<T>(IEnumerable<T> controllers, Func<T, bool> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C7C00 Offset: 0x23C7D01 VA: 0x23C7C00
	|-SoundManager.FindFirstController<SEController>
	|-SoundManager.FindFirstController<VoiceController>
	|-SoundManager.FindFirstController<object>
	*/

	// RVA: -1 Offset: -1
	private IEnumerable<T> FindControllers<T>(IEnumerable<T> controllers, Func<T, bool> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D4DB0 Offset: 0x22D4EB1 VA: 0x22D4DB0
	|-SoundManager.FindControllers<SEController>
	|-SoundManager.FindControllers<VoiceController>
	|-SoundManager.FindControllers<object>
	*/

	// RVA: -1 Offset: -1
	private T SearchUsableController<T, IDType>(LinkedList<T> controllers) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C8020 Offset: 0x23C8121 VA: 0x23C8020
	|-SoundManager.SearchUsableController<BGMController, BGMID>
	|-SoundManager.SearchUsableController<SEController, SoundID>
	|-SoundManager.SearchUsableController<VoiceController, SoundID>
	|-SoundManager.SearchUsableController<object, Int32Enum>
	|
	|-RVA: 0x23C8130 Offset: 0x23C8231 VA: 0x23C8130
	|-SoundManager.SearchUsableController<object, object>
	*/

	// RVA: 0x21134E0 Offset: 0x21135E1 VA: 0x21134E0
	public void PlayBGM(BGMID id, float fadetime = 3, int priority = 0) { }

	// RVA: 0x2113500 Offset: 0x2113601 VA: 0x2113500
	private void PlayBGM_internal(BGMID id, float fadetime, int priority) { }

	// RVA: 0x2113610 Offset: 0x2113711 VA: 0x2113610
	public void PlaySE(SoundID id) { }

	// RVA: 0x21137C0 Offset: 0x21138C1 VA: 0x21137C0
	private void PlayOneShot2D(SoundID id) { }

	// RVA: 0x21138F0 Offset: 0x21139F1 VA: 0x21138F0
	public VoiceController PlayVoice(SoundID id, int priority = 0) { }

	// RVA: 0x2113A70 Offset: 0x2113B71 VA: 0x2113A70
	public VoiceController PlayPlayerVoice(SoundID id) { }

	// RVA: 0x2113B80 Offset: 0x2113C81 VA: 0x2113B80
	public SEController PlaySE(SoundID id, Vector3 position) { }

	// RVA: 0x21145F0 Offset: 0x21146F1 VA: 0x21145F0
	public SEController PlaySE(SoundID id, Transform parent) { }

	// RVA: 0x2113C70 Offset: 0x2113D71 VA: 0x2113C70
	private SEController PlaySE3D_internal(SoundID id, Vector3 targetPos) { }

	// RVA: 0x2114700 Offset: 0x2114801 VA: 0x2114700
	public void BackPool(SEController controller) { }

	// RVA: 0x21147B0 Offset: 0x21148B1 VA: 0x21147B0
	public void StopAllBGM() { }

	// RVA: 0x21148D0 Offset: 0x21149D1 VA: 0x21148D0
	public void StopBGM(BGMID bgmID = 0) { }

	// RVA: 0x2114A10 Offset: 0x2114B11 VA: 0x2114A10
	public void PauseBGM() { }

	// RVA: 0x2114B80 Offset: 0x2114C81 VA: 0x2114B80
	public void UnPauseBGM() { }

	// RVA: 0x2114CF0 Offset: 0x2114DF1 VA: 0x2114CF0
	public void StopSound(SoundID soundID = 0) { }

	// RVA: 0x2115320 Offset: 0x2115421 VA: 0x2115320
	public void StopVoice(SoundID soundID = 0) { }

	// RVA: 0x2115650 Offset: 0x2115751 VA: 0x2115650
	public void StopPlayerVoice(SoundID soundID = 0) { }

	// RVA: 0x2115680 Offset: 0x2115781 VA: 0x2115680
	public void StopAllSound() { }

	// RVA: 0x2115870 Offset: 0x2115971 VA: 0x2115870
	public void StopAllVoice() { }

	// RVA: 0x2113AA0 Offset: 0x2113BA1 VA: 0x2113AA0
	public static SoundID ConvertPlayerVoiceID(SoundID voiceID) { }

	// RVA: 0x2115990 Offset: 0x2115A91 VA: 0x2115990
	private static SoundManager CheckAndSpawnInstanceForRFViewer() { }

	// RVA: 0x2115A20 Offset: 0x2115B21 VA: 0x2115A20
	public static void Timeline_PlayBGM(BGMID BGMID) { }

	// RVA: 0x2115B00 Offset: 0x2115C01 VA: 0x2115B00
	public static void Timeline_StopBGM() { }

	// RVA: 0x2115BB0 Offset: 0x2115CB1 VA: 0x2115BB0
	public static AudioSourceController<SoundID> Timeline_OnBehaviourPlay(SoundID soundID, RF_AudioBehaviour parent, bool isLoop, float volume, Transform targetTransform) { }

	// RVA: 0x2115F50 Offset: 0x2116051 VA: 0x2115F50
	private void OnApplicationQuit() { }

	// RVA: 0x2116000 Offset: 0x2116101 VA: 0x2116000
	private float FindMaxVolume(IEnumerable<EnvironmentSoundArea> EnvironmentSoundAreas) { }

	// RVA: 0x21162D0 Offset: 0x21163D1 VA: 0x21162D0
	public void OnEnterEnvironmentArea(EnvironmentSoundArea environmentSoundArea) { }

	// RVA: 0x2116470 Offset: 0x2116571 VA: 0x2116470
	public void OnExitEnvironmentArea(EnvironmentSoundArea environmentSoundArea) { }

	// RVA: 0x21165C0 Offset: 0x21166C1 VA: 0x21165C0
	public void ReleaseEnvironmentArea() { }

	// RVA: 0x2116700 Offset: 0x2116801 VA: 0x2116700
	public void PlaySE_Debug(string name, Transform parent) { }

	// RVA: 0x2116840 Offset: 0x2116941 VA: 0x2116840
	public void PlaySE_Debug(string name, Vector3 position) { }

	// RVA: 0x2116910 Offset: 0x2116A11 VA: 0x2116910
	public void StopSE_Debug(string name) { }

	// RVA: 0x21167B0 Offset: 0x21168B1 VA: 0x21167B0
	private SoundID StringToSoundID_Debug(string name) { }

	// RVA: 0x2116A10 Offset: 0x2116B11 VA: 0x2116A10
	private BGMID StringToBGMID_Debug(string name) { }

	// RVA: 0x2116AA0 Offset: 0x2116BA1 VA: 0x2116AA0
	public VoiceController PlayPlayerVoice_Debug(string name) { }

	// RVA: 0x2116B60 Offset: 0x2116C61 VA: 0x2116B60
	public void StopVoice_Debug(string name) { }

	// RVA: 0x2116C00 Offset: 0x2116D01 VA: 0x2116C00
	public void PlaySE_Debug(string name) { }

	// RVA: 0x2116CA0 Offset: 0x2116DA1 VA: 0x2116CA0
	public void PlayBGM_Debug(string name) { }

	// RVA: 0x2116D60 Offset: 0x2116E61 VA: 0x2116D60
	public void .ctor() { }
}

