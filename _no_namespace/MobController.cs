public class MobController : HumanController, InteractionInterface, FocusInterface // TypeDefIndex: 6739
{
	// Fields
	private static MobController.EventMode m_EventMode; // 0x0
	private static MobController m_EventOwner; // 0x8
	protected const float kTalkRotateAngle = 45;
	[HeaderAttribute] // RVA: 0x15F2B0 Offset: 0x15F3B1 VA: 0x15F2B0
	[SerializeField] // RVA: 0x15F2B0 Offset: 0x15F3B1 VA: 0x15F2B0
	protected CharacterModel m_charaModel; // 0x238
	[SerializeField] // RVA: 0x15F300 Offset: 0x15F401 VA: 0x15F300
	protected float m_rotateSpeed; // 0x240
	[SerializeField] // RVA: 0x15F310 Offset: 0x15F411 VA: 0x15F310
	protected bool m_isSitting; // 0x244
	[SerializeField] // RVA: 0x15F320 Offset: 0x15F421 VA: 0x15F320
	protected Alliance m_alliance; // 0x248
	[SerializeField] // RVA: 0x15F330 Offset: 0x15F431 VA: 0x15F330
	protected string m_talkScriptName; // 0x250
	private string m_SavetalkScriptName; // 0x258
	private int mobid; // 0x260
	protected MobController.TalkState m_talkState; // 0x264
	protected Vector3 m_talkDirection; // 0x268

	// Properties
	public virtual bool Focusable { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }
	public override Alliance Alliance { get; }
	public bool IsTalking { get; }
	public override CharacterStatusBase Status { get; }
	public override bool IsDead { get; }
	public virtual FocusObjectType FocusObjectType { get; }
	public virtual float OnEnableFadeAlpha { get; }

	// Methods

	// RVA: 0x1CBB000 Offset: 0x1CBB101 VA: 0x1CBB000
	public static void OnUpdateEvent() { }

	// RVA: 0x1CBB0B0 Offset: 0x1CBB1B1 VA: 0x1CBB0B0
	private static void OnUpdateTalkEvent() { }

	// RVA: 0x1CBB210 Offset: 0x1CBB311 VA: 0x1CBB210
	public static bool PlayTalkEvent(MobController controller, Character opponent) { }

	// RVA: 0x1CBB520 Offset: 0x1CBB621 VA: 0x1CBB520
	public static MobController Get() { }

	// RVA: 0x1CBB590 Offset: 0x1CBB691 VA: 0x1CBB590 Slot: 112
	public virtual bool get_Focusable() { }

	// RVA: 0x1CBB690 Offset: 0x1CBB791 VA: 0x1CBB690 Slot: 107
	public int get_FocusPriority() { }

	// RVA: 0x1CBB6A0 Offset: 0x1CBB7A1 VA: 0x1CBB6A0 Slot: 108
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1CBB6B0 Offset: 0x1CBB7B1 VA: 0x1CBB6B0 Slot: 113
	public virtual string GetFocusName() { }

	// RVA: 0x1CBB700 Offset: 0x1CBB801 VA: 0x1CBB700 Slot: 114
	public virtual void OnFocus() { }

	// RVA: 0x1CBB710 Offset: 0x1CBB811 VA: 0x1CBB710 Slot: 115
	public virtual void OffFocus() { }

	// RVA: 0x1CBB720 Offset: 0x1CBB821 VA: 0x1CBB720 Slot: 116
	public virtual ushort GetInteractionType() { }

	// RVA: 0x1CBB730 Offset: 0x1CBB831 VA: 0x1CBB730 Slot: 117
	public virtual bool CanInteraction(HumanController character) { }

	// RVA: 0x1CBB740 Offset: 0x1CBB841 VA: 0x1CBB740 Slot: 118
	public virtual string GetInteractionButtonHint() { }

	// RVA: 0x1CBB790 Offset: 0x1CBB891 VA: 0x1CBB790 Slot: 119
	public virtual void DoInteraction(HumanController character) { }

	// RVA: 0x1CBB810 Offset: 0x1CBB911 VA: 0x1CBB810 Slot: 120
	public virtual void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1CBB890 Offset: 0x1CBB991 VA: 0x1CBB890 Slot: 121
	public virtual bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1CBB8A0 Offset: 0x1CBB9A1 VA: 0x1CBB8A0 Slot: 8
	public override Alliance get_Alliance() { }

	// RVA: 0x1CBB8B0 Offset: 0x1CBB9B1 VA: 0x1CBB8B0
	public bool get_IsTalking() { }

	// RVA: 0x1CBB8C0 Offset: 0x1CBB9C1 VA: 0x1CBB8C0 Slot: 27
	public override CharacterStatusBase get_Status() { }

	// RVA: 0x1CBB8D0 Offset: 0x1CBB9D1 VA: 0x1CBB8D0 Slot: 28
	public override bool get_IsDead() { }

	// RVA: 0x1CBB8E0 Offset: 0x1CBB9E1 VA: 0x1CBB8E0 Slot: 122
	public virtual FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1CBB8F0 Offset: 0x1CBB9F1 VA: 0x1CBB8F0 Slot: 123
	public virtual float get_OnEnableFadeAlpha() { }

	// RVA: 0x1CBB900 Offset: 0x1CBBA01 VA: 0x1CBB900 Slot: 12
	protected override void Start() { }

	// RVA: 0x1CBBB30 Offset: 0x1CBBC31 VA: 0x1CBBB30 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x1CBBCA0 Offset: 0x1CBBDA1 VA: 0x1CBBCA0 Slot: 13
	protected override void OnEnable() { }

	// RVA: 0x1CBBD70 Offset: 0x1CBBE71 VA: 0x1CBBD70 Slot: 124
	public virtual void SetTalkScript(string talkScriptName) { }

	// RVA: 0x1CBBDB0 Offset: 0x1CBBEB1 VA: 0x1CBBDB0
	public void SetMobID(int id) { }

	// RVA: 0x1CBBDC0 Offset: 0x1CBBEC1 VA: 0x1CBBDC0 Slot: 79
	protected override void UpdateLookIK() { }

	// RVA: 0x1CBC090 Offset: 0x1CBC191 VA: 0x1CBC090 Slot: 40
	protected override void Update() { }

	// RVA: 0x1CBC1F0 Offset: 0x1CBC2F1 VA: 0x1CBC1F0 Slot: 42
	protected override void FixedUpdate() { }

	// RVA: 0x1CBC3B0 Offset: 0x1CBC4B1 VA: 0x1CBC3B0 Slot: 45
	protected override void InitAnimator() { }

	// RVA: 0x1CBC4D0 Offset: 0x1CBC5D1 VA: 0x1CBC4D0 Slot: 57
	public override float GetRotateSpeed() { }

	// RVA: 0x1CBC4E0 Offset: 0x1CBC5E1 VA: 0x1CBC4E0 Slot: 49
	public override bool InputMove(Vector3 vector) { }

	// RVA: 0x1CBC500 Offset: 0x1CBC601 VA: 0x1CBC500 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x1CBB400 Offset: 0x1CBB501 VA: 0x1CBB400
	public void DullJudg() { }

	// RVA: 0x1CBC520 Offset: 0x1CBC621 VA: 0x1CBC520 Slot: 125
	public virtual void StartTalk(Character chara) { }

	// RVA: 0x1CBC780 Offset: 0x1CBC881 VA: 0x1CBC780 Slot: 126
	public virtual void EndTalk() { }

	// RVA: 0x1CBC790 Offset: 0x1CBC891 VA: 0x1CBC790
	public bool FadeIn() { }

	// RVA: 0x1CBC910 Offset: 0x1CBCA11 VA: 0x1CBC910
	public bool FadeOut() { }

	// RVA: 0x1CBCA90 Offset: 0x1CBCB91 VA: 0x1CBCA90
	public void .ctor() { }

	// RVA: 0x1CBCB50 Offset: 0x1CBCC51 VA: 0x1CBCB50
	private static void .cctor() { }

	// RVA: 0x1CBCB60 Offset: 0x1CBCC61 VA: 0x1CBCB60 Slot: 110
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1CBCB70 Offset: 0x1CBCC71 VA: 0x1CBCB70 Slot: 111
	private Transform FocusInterface.get_transform() { }
}

