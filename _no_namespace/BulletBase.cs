[RequireComponent] // RVA: 0x145D10 Offset: 0x145E11 VA: 0x145D10
[RequireComponent] // RVA: 0x145D10 Offset: 0x145E11 VA: 0x145D10
public class BulletBase : MonoBehaviour // TypeDefIndex: 6445
{
	// Fields
	[SerializeField] // RVA: 0x15C650 Offset: 0x15C751 VA: 0x15C650
	private Transform m_Root; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15C660 Offset: 0x15C761 VA: 0x15C660
	private BulletDataTable <BulletData>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15C670 Offset: 0x15C771 VA: 0x15C670
	private Character <Owner>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15C680 Offset: 0x15C781 VA: 0x15C680
	private Alliance <Alliance>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15C690 Offset: 0x15C791 VA: 0x15C690
	private Collider <Target>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x15C6A0 Offset: 0x15C7A1 VA: 0x15C6A0
	private bool <IsSetup>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x15C6B0 Offset: 0x15C7B1 VA: 0x15C6B0
	private bool <IsDead>k__BackingField; // 0x41
	[CompilerGeneratedAttribute] // RVA: 0x15C6C0 Offset: 0x15C7C1 VA: 0x15C6C0
	private float <Elapsed>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x15C6D0 Offset: 0x15C7D1 VA: 0x15C6D0
	private DamageInfo <DamageInfo>k__BackingField; // 0x48
	[HeaderAttribute] // RVA: 0x15C6E0 Offset: 0x15C7E1 VA: 0x15C6E0
	[SerializeField] // RVA: 0x15C6E0 Offset: 0x15C7E1 VA: 0x15C6E0
	protected SoundID m_SoundID; // 0xC8
	[SerializeField] // RVA: 0x15C730 Offset: 0x15C831 VA: 0x15C730
	protected EffectID m_StartEffectID; // 0xCC
	[SerializeField] // RVA: 0x15C740 Offset: 0x15C841 VA: 0x15C740
	protected SoundID m_StartSoundID; // 0xD0
	[SerializeField] // RVA: 0x15C750 Offset: 0x15C851 VA: 0x15C750
	protected SoundID m_StartSoundID2; // 0xD4
	[HeaderAttribute] // RVA: 0x15C760 Offset: 0x15C861 VA: 0x15C760
	[SerializeField] // RVA: 0x15C760 Offset: 0x15C861 VA: 0x15C760
	protected EffectID m_DeadEffectID; // 0xD8
	[SerializeField] // RVA: 0x15C7B0 Offset: 0x15C8B1 VA: 0x15C7B0
	protected SoundID m_DeadSoundID; // 0xDC
	[HeaderAttribute] // RVA: 0x15C7C0 Offset: 0x15C8C1 VA: 0x15C7C0
	[SerializeField] // RVA: 0x15C7C0 Offset: 0x15C8C1 VA: 0x15C7C0
	protected BulletMotor m_Motor; // 0xE0
	[SerializeField] // RVA: 0x15C810 Offset: 0x15C911 VA: 0x15C810
	protected BulletMainModule m_MainModule; // 0xE8
	[SerializeField] // RVA: 0x15C820 Offset: 0x15C921 VA: 0x15C820
	protected BulletSubModule m_Extention; // 0xF0
	[HeaderAttribute] // RVA: 0x15C830 Offset: 0x15C931 VA: 0x15C830
	[SerializeField] // RVA: 0x15C830 Offset: 0x15C931 VA: 0x15C830
	public UnityEvent onHitEvent; // 0xF8
	[SerializeField] // RVA: 0x15C880 Offset: 0x15C981 VA: 0x15C880
	public UnityEvent onDeadEvent; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x15C890 Offset: 0x15C991 VA: 0x15C890
	private UnityEvent <onDestroyEvent>k__BackingField; // 0x108
	protected List<BulletColliderBase> m_Colliders; // 0x110
	[HeaderAttribute] // RVA: 0x15C8A0 Offset: 0x15C9A1 VA: 0x15C8A0
	[SerializeField] // RVA: 0x15C8A0 Offset: 0x15C9A1 VA: 0x15C8A0
	protected AS_BulletController m_ScriptController; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x15C8F0 Offset: 0x15C9F1 VA: 0x15C8F0
	private bool <ForceDead>k__BackingField; // 0x120
	private Transform m_TrackingTarget; // 0x128
	private Vector3 m_TrackingTargetPosition; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x15C900 Offset: 0x15CA01 VA: 0x15C900
	private int <Level>k__BackingField; // 0x13C
	[CompilerGeneratedAttribute] // RVA: 0x15C910 Offset: 0x15CA11 VA: 0x15C910
	private SkillActionID <SkillActionID>k__BackingField; // 0x140

	// Properties
	public Transform Root { get; }
	public BulletDataTable BulletData { get; set; }
	public Character Owner { get; set; }
	public Alliance Alliance { get; set; }
	public Collider Target { get; set; }
	public bool IsSetup { get; set; }
	public bool IsDead { get; set; }
	public float Elapsed { get; set; }
	public DamageInfo DamageInfo { get; set; }
	public BulletMotor Motor { get; }
	public BulletMainModule MainModule { get; }
	public BulletSubModule Extention { get; }
	public UnityEvent onDestroyEvent { get; set; }
	public AS_BulletController ScriptController { get; }
	public bool ForceDead { get; set; }
	public int Level { get; set; }
	public SkillActionID SkillActionID { get; set; }

	// Methods

	// RVA: 0x2060EC0 Offset: 0x2060FC1 VA: 0x2060EC0
	public Transform get_Root() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B0E0 Offset: 0x19B1E1 VA: 0x19B0E0
	// RVA: 0x2060ED0 Offset: 0x2060FD1 VA: 0x2060ED0
	public BulletDataTable get_BulletData() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B0F0 Offset: 0x19B1F1 VA: 0x19B0F0
	// RVA: 0x2060EE0 Offset: 0x2060FE1 VA: 0x2060EE0
	public void set_BulletData(BulletDataTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B100 Offset: 0x19B201 VA: 0x19B100
	// RVA: 0x2060EF0 Offset: 0x2060FF1 VA: 0x2060EF0
	public Character get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B110 Offset: 0x19B211 VA: 0x19B110
	// RVA: 0x2060F00 Offset: 0x2061001 VA: 0x2060F00
	protected void set_Owner(Character value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B120 Offset: 0x19B221 VA: 0x19B120
	// RVA: 0x2060F10 Offset: 0x2061011 VA: 0x2060F10
	public Alliance get_Alliance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B130 Offset: 0x19B231 VA: 0x19B130
	// RVA: 0x2060F20 Offset: 0x2061021 VA: 0x2060F20
	protected void set_Alliance(Alliance value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B140 Offset: 0x19B241 VA: 0x19B140
	// RVA: 0x2060F30 Offset: 0x2061031 VA: 0x2060F30
	public Collider get_Target() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B150 Offset: 0x19B251 VA: 0x19B150
	// RVA: 0x2060F40 Offset: 0x2061041 VA: 0x2060F40
	public void set_Target(Collider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B160 Offset: 0x19B261 VA: 0x19B160
	// RVA: 0x2060F50 Offset: 0x2061051 VA: 0x2060F50
	public bool get_IsSetup() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B170 Offset: 0x19B271 VA: 0x19B170
	// RVA: 0x2060F60 Offset: 0x2061061 VA: 0x2060F60
	protected void set_IsSetup(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B180 Offset: 0x19B281 VA: 0x19B180
	// RVA: 0x2060F70 Offset: 0x2061071 VA: 0x2060F70
	public bool get_IsDead() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B190 Offset: 0x19B291 VA: 0x19B190
	// RVA: 0x2060F80 Offset: 0x2061081 VA: 0x2060F80
	protected void set_IsDead(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B1A0 Offset: 0x19B2A1 VA: 0x19B1A0
	// RVA: 0x2060F90 Offset: 0x2061091 VA: 0x2060F90
	public float get_Elapsed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B1B0 Offset: 0x19B2B1 VA: 0x19B1B0
	// RVA: 0x2060FA0 Offset: 0x20610A1 VA: 0x2060FA0
	protected void set_Elapsed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B1C0 Offset: 0x19B2C1 VA: 0x19B1C0
	// RVA: 0x2060FB0 Offset: 0x20610B1 VA: 0x2060FB0
	public DamageInfo get_DamageInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B1D0 Offset: 0x19B2D1 VA: 0x19B1D0
	// RVA: 0x2061000 Offset: 0x2061101 VA: 0x2061000
	protected void set_DamageInfo(DamageInfo value) { }

	// RVA: 0x2061030 Offset: 0x2061131 VA: 0x2061030
	public BulletMotor get_Motor() { }

	// RVA: 0x2061040 Offset: 0x2061141 VA: 0x2061040
	public BulletMainModule get_MainModule() { }

	// RVA: 0x2061050 Offset: 0x2061151 VA: 0x2061050
	public BulletSubModule get_Extention() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B1E0 Offset: 0x19B2E1 VA: 0x19B1E0
	// RVA: 0x2061060 Offset: 0x2061161 VA: 0x2061060
	public UnityEvent get_onDestroyEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B1F0 Offset: 0x19B2F1 VA: 0x19B1F0
	// RVA: 0x2061070 Offset: 0x2061171 VA: 0x2061070
	public void set_onDestroyEvent(UnityEvent value) { }

	// RVA: 0x2061080 Offset: 0x2061181 VA: 0x2061080
	public AS_BulletController get_ScriptController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B200 Offset: 0x19B301 VA: 0x19B200
	// RVA: 0x2061090 Offset: 0x2061191 VA: 0x2061090
	public bool get_ForceDead() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B210 Offset: 0x19B311 VA: 0x19B210
	// RVA: 0x20610A0 Offset: 0x20611A1 VA: 0x20610A0
	public void set_ForceDead(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B220 Offset: 0x19B321 VA: 0x19B220
	// RVA: 0x20610B0 Offset: 0x20611B1 VA: 0x20610B0
	public int get_Level() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B230 Offset: 0x19B331 VA: 0x19B230
	// RVA: 0x20610C0 Offset: 0x20611C1 VA: 0x20610C0
	private void set_Level(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B240 Offset: 0x19B341 VA: 0x19B240
	// RVA: 0x20610D0 Offset: 0x20611D1 VA: 0x20610D0
	public SkillActionID get_SkillActionID() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B250 Offset: 0x19B351 VA: 0x19B250
	// RVA: 0x20610E0 Offset: 0x20611E1 VA: 0x20610E0
	private void set_SkillActionID(SkillActionID value) { }

	// RVA: 0x20610F0 Offset: 0x20611F1 VA: 0x20610F0
	private void Awake() { }

	// RVA: 0x2061380 Offset: 0x2061481 VA: 0x2061380
	private void OnDestroy() { }

	// RVA: 0x2061610 Offset: 0x2061711 VA: 0x2061610
	public void SetPosition(Vector3 position) { }

	// RVA: 0x2061660 Offset: 0x2061761 VA: 0x2061660
	public void Move(Vector3 deltaPosition) { }

	// RVA: 0x2061760 Offset: 0x2061861 VA: 0x2061760 Slot: 4
	public virtual void Setup(BulletDataTable dataTable, Character owner, Transform parent, Collider target, int level, SkillActionID skillActionID = 0) { }

	// RVA: 0x2062800 Offset: 0x2062901 VA: 0x2062800 Slot: 5
	public virtual void OnUpdate() { }

	// RVA: 0x2062C40 Offset: 0x2062D41 VA: 0x2062C40 Slot: 6
	public virtual void OnFixedUpdate() { }

	// RVA: 0x2063020 Offset: 0x2063121 VA: 0x2063020 Slot: 7
	public virtual void OnCollision() { }

	// RVA: 0x2063130 Offset: 0x2063231 VA: 0x2063130 Slot: 8
	public virtual void OnHit(Collider collider, Vector3 point, Vector3 normal) { }

	// RVA: 0x2063780 Offset: 0x2063881 VA: 0x2063780 Slot: 9
	public virtual void OnDead() { }

	// RVA: 0x2062A40 Offset: 0x2062B41 VA: 0x2062A40
	private void TryDestroy() { }

	// RVA: 0x2063990 Offset: 0x2063A91 VA: 0x2063990
	public void ForceDestroy() { }

	// RVA: 0x2063BD0 Offset: 0x2063CD1 VA: 0x2063BD0 Slot: 10
	public virtual void DoExtension() { }

	// RVA: 0x2063DC0 Offset: 0x2063EC1 VA: 0x2063DC0
	public void DoActionExp() { }

	// RVA: 0x2063F10 Offset: 0x2064011 VA: 0x2063F10
	public void .ctor() { }
}

