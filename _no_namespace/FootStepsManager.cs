public class FootStepsManager : SingletonMonoBehaviour<FootStepsManager> // TypeDefIndex: 6713
{
	// Fields
	protected const float kBackstepDistance = 0.05;
	protected const float kNoizeRadiusLanding = 0.5;
	protected const float kFootdownDistance = 0.1;
	private Register<Character, FootSteps> m_Register; // 0x18
	[SerializeField] // RVA: 0x15EFB0 Offset: 0x15F0B1 VA: 0x15EFB0
	private LayerMask m_ObstacleLayer; // 0x20
	[SerializeField] // RVA: 0x15EFC0 Offset: 0x15F0C1 VA: 0x15EFC0
	private AnimationCurve m_NoizeRadius; // 0x28
	private List<float> m_TimeCountList; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15EFD0 Offset: 0x15F0D1 VA: 0x15EFD0
	private int <LoadCounter>k__BackingField; // 0x38
	private Dictionary<SoundID, AudioClip> FootStepsSEDic; // 0x40

	// Properties
	public bool IsLoading { get; }
	private int LoadCounter { get; set; }
	private Camera CurrentCamera { get; }

	// Methods

	// RVA: 0x1D560B0 Offset: 0x1D561B1 VA: 0x1D560B0
	public bool get_IsLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CAB0 Offset: 0x19CBB1 VA: 0x19CAB0
	// RVA: 0x1D560C0 Offset: 0x1D561C1 VA: 0x1D560C0
	private int get_LoadCounter() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CAC0 Offset: 0x19CBC1 VA: 0x19CAC0
	// RVA: 0x1D560D0 Offset: 0x1D561D1 VA: 0x1D560D0
	private void set_LoadCounter(int value) { }

	// RVA: 0x1D560E0 Offset: 0x1D561E1 VA: 0x1D560E0
	private Camera get_CurrentCamera() { }

	// RVA: 0x1D561A0 Offset: 0x1D562A1 VA: 0x1D561A0
	public void Init() { }

	// RVA: 0x1D563F0 Offset: 0x1D564F1 VA: 0x1D563F0
	private void LoadClip_internal(SoundID soundID) { }

	// RVA: 0x1D56570 Offset: 0x1D56671 VA: 0x1D56570
	public bool Regist(Character chara, FootSteps controller) { }

	// RVA: 0x1D565E0 Offset: 0x1D566E1 VA: 0x1D565E0
	public bool Remove(Character chara) { }

	// RVA: 0x1D56650 Offset: 0x1D56751 VA: 0x1D56650
	public FootSteps Get(Character chara) { }

	// RVA: 0x1D56700 Offset: 0x1D56801 VA: 0x1D56700
	private void Update() { }

	// RVA: 0x1D56850 Offset: 0x1D56951 VA: 0x1D56850
	public void OnFootSteps(Character chara, int no, bool effectPlay, float locomotion) { }

	// RVA: 0x1D57A10 Offset: 0x1D57B11 VA: 0x1D57A10
	public void OnLanding(Character chara, bool soundPlay, bool effectPlay) { }

	// RVA: 0x1D56E50 Offset: 0x1D56F51 VA: 0x1D56E50
	public GroundType GetGroundType(Character chara, Vector3 origin, out Vector3 position, float offset, float distance, bool inWater, out Collider hitCollider) { }

	// RVA: 0x1D57FE0 Offset: 0x1D580E1 VA: 0x1D57FE0
	private string TerrainFootStepsString(Collider hit, Vector3 point) { }

	// RVA: 0x1D582E0 Offset: 0x1D583E1 VA: 0x1D582E0
	private GroundType GetGroundType(string name) { }

	// RVA: 0x1D57260 Offset: 0x1D57361 VA: 0x1D57260
	private void PlayStepSound(AudioSource audioSource, Vector3 position, SoundID soundID, float basePitch, bool decay) { }

	// RVA: 0x1D57540 Offset: 0x1D57641 VA: 0x1D57540
	private void PlayStepEffect(Vector3 position, Quaternion rot, EffectID effectID, float scale) { }

	// RVA: 0x1D576C0 Offset: 0x1D577C1 VA: 0x1D576C0
	private bool IsParty(Character chara) { }

	// RVA: 0x1D577E0 Offset: 0x1D578E1 VA: 0x1D577E0
	public void PlayNoize(Vector3 center, float radius) { }

	// RVA: 0x1D59220 Offset: 0x1D59321 VA: 0x1D59220
	public void .ctor() { }
}

