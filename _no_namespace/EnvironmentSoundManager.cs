public class EnvironmentSoundManager : SingletonMonoBehaviour<EnvironmentSoundManager> // TypeDefIndex: 8257
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16E5D0 Offset: 0x16E6D1 VA: 0x16E5D0
	private Stack<EnvironmentSoundController> <ControllerPool>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16E5E0 Offset: 0x16E6E1 VA: 0x16E5E0
	private Dictionary<SoundID, EnvironmentSoundController> <PlayingControllerDic>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x16E5F0 Offset: 0x16E6F1 VA: 0x16E5F0
	private HashSet<EnvironmentSoundPointController> <Playing3DSound>k__BackingField; // 0x28
	private const int InitialNum = 4;
	private bool DonePaused; // 0x30
	[TupleElementNamesAttribute] // RVA: 0x16E600 Offset: 0x16E701 VA: 0x16E600
	private List<ValueTuple<SoundID, EnvironmentSoundController>> RemoveList; // 0x38
	private const float VOLUME_UP_TARGET = 1;
	private const float VOLUME_DOWN_TARGET = 0.7;
	public float EnvironmentVolume; // 0x40
	private bool IsEnvironmentVolumeDown; // 0x44

	// Properties
	public Stack<EnvironmentSoundController> ControllerPool { get; set; }
	public Dictionary<SoundID, EnvironmentSoundController> PlayingControllerDic { get; set; }
	public HashSet<EnvironmentSoundPointController> Playing3DSound { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6670 Offset: 0x1A6771 VA: 0x1A6670
	// RVA: 0x201F1E0 Offset: 0x201F2E1 VA: 0x201F1E0
	public Stack<EnvironmentSoundController> get_ControllerPool() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6680 Offset: 0x1A6781 VA: 0x1A6680
	// RVA: 0x201F1F0 Offset: 0x201F2F1 VA: 0x201F1F0
	private void set_ControllerPool(Stack<EnvironmentSoundController> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6690 Offset: 0x1A6791 VA: 0x1A6690
	// RVA: 0x201F200 Offset: 0x201F301 VA: 0x201F200
	public Dictionary<SoundID, EnvironmentSoundController> get_PlayingControllerDic() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A66A0 Offset: 0x1A67A1 VA: 0x1A66A0
	// RVA: 0x201F210 Offset: 0x201F311 VA: 0x201F210
	private void set_PlayingControllerDic(Dictionary<SoundID, EnvironmentSoundController> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A66B0 Offset: 0x1A67B1 VA: 0x1A66B0
	// RVA: 0x201F220 Offset: 0x201F321 VA: 0x201F220
	public HashSet<EnvironmentSoundPointController> get_Playing3DSound() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A66C0 Offset: 0x1A67C1 VA: 0x1A66C0
	// RVA: 0x201F230 Offset: 0x201F331 VA: 0x201F230
	private void set_Playing3DSound(HashSet<EnvironmentSoundPointController> value) { }

	// RVA: 0x201F240 Offset: 0x201F341 VA: 0x201F240
	public void RemoveAllAreaSound() { }

	// RVA: 0x201F430 Offset: 0x201F531 VA: 0x201F430
	private void Start() { }

	// RVA: 0x201F590 Offset: 0x201F691 VA: 0x201F590
	private void OnChangeScene() { }

	// RVA: 0x201F650 Offset: 0x201F751 VA: 0x201F650
	public void Play(EnvironmentSoundType type, FieldSceneId sceneId) { }

	// RVA: 0x2020000 Offset: 0x2020101 VA: 0x2020000
	private void Update() { }

	// RVA: 0x20207F0 Offset: 0x20208F1 VA: 0x20207F0
	private void EnvironmentVolumeUpdate() { }

	// RVA: 0x20208F0 Offset: 0x20209F1 VA: 0x20208F0
	public void .ctor() { }
}

