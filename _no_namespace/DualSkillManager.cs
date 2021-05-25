public class DualSkillManager : SingletonMonoBehaviour<DualSkillManager> // TypeDefIndex: 6704
{
	// Fields
	private const float PREPARATION_MINIMUM_TIME = 0.5;
	private const int EFFECT_RUNKUP_LEVEL_1 = 7;
	private const int EFFECT_RUNKUP_LEVEL_2 = 10;
	private DualSkillManager.Status m_currentStatus; // 0x18
	[SerializeField] // RVA: 0x15EF40 Offset: 0x15F041 VA: 0x15EF40
	private GameObject m_timelineObject; // 0x20
	[SerializeField] // RVA: 0x15EF50 Offset: 0x15F051 VA: 0x15EF50
	private PlayableDirector m_playableDirector; // 0x28
	private float m_elapsed; // 0x30
	[SerializeField] // RVA: 0x15EF60 Offset: 0x15F061 VA: 0x15EF60
	private UnityEvent m_eventPlayEnd; // 0x38
	[SerializeField] // RVA: 0x15EF70 Offset: 0x15F071 VA: 0x15EF70
	private Color m_ambientColor; // 0x40
	private ActorID m_PlayedActorID; // 0x50
	private Actor m_actor1; // 0x58
	private HumanModel m_humanModel1; // 0x60
	private bool m_isEnableIK1; // 0x68
	private Actor m_actor2; // 0x70
	private HumanModel m_humanModel2; // 0x78
	private bool m_isEnableIK2; // 0x80
	private bool m_fogBackup; // 0x81
	private Color m_ambientColorBackup; // 0x84
	private CharacterBase m_targetCharacter; // 0x98
	private DamageInfo m_damagaInfo; // 0xA0
	private int m_loaderID; // 0x120

	// Properties
	public PartyBase[] Parties { get; }
	public bool IsPlaying { get; }

	// Methods

	// RVA: 0x1CF3D40 Offset: 0x1CF3E41 VA: 0x1CF3D40
	public PartyBase[] get_Parties() { }

	// RVA: 0x1CF3E30 Offset: 0x1CF3F31 VA: 0x1CF3E30
	public bool get_IsPlaying() { }

	// RVA: 0x1CF3E40 Offset: 0x1CF3F41 VA: 0x1CF3E40
	private void Start() { }

	// RVA: 0x1CF3F70 Offset: 0x1CF4071 VA: 0x1CF3F70
	private void OnDisable() { }

	// RVA: 0x1CF3F80 Offset: 0x1CF4081 VA: 0x1CF3F80
	private void Update() { }

	// RVA: 0x1CF4340 Offset: 0x1CF4441 VA: 0x1CF4340
	public bool CheckStatus(ActorID actor_id) { }

	// RVA: 0x1CF4420 Offset: 0x1CF4521 VA: 0x1CF4420
	public bool PlayPartnerActorID(ActorID actorID) { }

	// RVA: 0x1CF45E0 Offset: 0x1CF46E1 VA: 0x1CF45E0
	public bool PlayPartnerPartyIndex(int index) { }

	// RVA: 0x1CF4530 Offset: 0x1CF4631 VA: 0x1CF4530
	public bool Play(ActorID actor_id, CharacterBase target) { }

	// RVA: 0x1CF4730 Offset: 0x1CF4831 VA: 0x1CF4730
	public bool PlayForce(ActorID actor_id, CharacterBase target) { }

	// RVA: 0x1CF4EE0 Offset: 0x1CF4FE1 VA: 0x1CF4EE0
	private bool BindTarget(CharacterBase target) { }

	// RVA: 0x1CF5210 Offset: 0x1CF5311 VA: 0x1CF5210
	private bool SetupEffect(int loveLevel) { }

	// RVA: 0x1CF5500 Offset: 0x1CF5601 VA: 0x1CF5500
	private void OnPlay() { }

	// RVA: 0x1CF57E0 Offset: 0x1CF58E1 VA: 0x1CF57E0
	private void OnStopped(PlayableDirector playableDirector) { }

	// RVA: 0x1CF57F0 Offset: 0x1CF58F1 VA: 0x1CF57F0
	private void OnResume() { }

	// RVA: 0x1CF56E0 Offset: 0x1CF57E1 VA: 0x1CF56E0
	private void HideToolEquip(Actor actor) { }

	// RVA: 0x1CF5B40 Offset: 0x1CF5C41 VA: 0x1CF5B40
	private void ResetToolEquip(Actor actor) { }

	// RVA: 0x1CF5C40 Offset: 0x1CF5D41 VA: 0x1CF5C40
	private void Init() { }

	// RVA: 0x1CF3E50 Offset: 0x1CF3F51 VA: 0x1CF3E50
	public void CleanUp() { }

	// RVA: 0x1CF5D10 Offset: 0x1CF5E11 VA: 0x1CF5D10
	public ActorID GetPartyMemberActorID(int index) { }

	// RVA: 0x1CF4670 Offset: 0x1CF4771 VA: 0x1CF4670
	public bool PlayWithMember(int index, CharacterBase target) { }

	// RVA: 0x1CF5DF0 Offset: 0x1CF5EF1 VA: 0x1CF5DF0
	public bool PlayWithMemberForce(int index, CharacterBase target) { }

	// RVA: 0x1CF5E40 Offset: 0x1CF5F41 VA: 0x1CF5E40
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CA30 Offset: 0x19CB31 VA: 0x19CA30
	// RVA: 0x1CF5EE0 Offset: 0x1CF5FE1 VA: 0x1CF5EE0
	private void <Init>b__41_0(PlayableDirector director) { }
}

