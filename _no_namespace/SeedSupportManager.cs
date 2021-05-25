public class SeedSupportManager : SingletonMonoBehaviour<SeedSupportManager> // TypeDefIndex: 6728
{
	// Fields
	private const float PREPARATION_MINIMUM_TIME = 0.5;
	private SeedSupportManager.Status m_currentStatus; // 0x18
	[SerializeField] // RVA: 0x15F230 Offset: 0x15F331 VA: 0x15F230
	private GameObject m_timelineObject; // 0x20
	[SerializeField] // RVA: 0x15F240 Offset: 0x15F341 VA: 0x15F240
	private PlayableDirector m_playableDirector; // 0x28
	private float m_elapsed; // 0x30
	[SerializeField] // RVA: 0x15F250 Offset: 0x15F351 VA: 0x15F250
	private UnityEvent m_eventPlayEnd; // 0x38
	[SerializeField] // RVA: 0x15F260 Offset: 0x15F361 VA: 0x15F260
	private Color m_ambientColor; // 0x40
	private bool m_fogBackup; // 0x50
	private Color m_ambientColorBackup; // 0x54
	private DamageInfo m_damagaInfo; // 0x68
	private int m_loaderID; // 0xE8
	private SeedSupportID m_CurretSupportID; // 0xEC
	private SeedSupportType m_CurretSupportType; // 0xF0

	// Properties
	public bool IsPlaying { get; }

	// Methods

	// RVA: 0x1C87810 Offset: 0x1C87911 VA: 0x1C87810
	public bool get_IsPlaying() { }

	// RVA: 0x1C87820 Offset: 0x1C87921 VA: 0x1C87820
	private void Start() { }

	// RVA: 0x1C87830 Offset: 0x1C87931 VA: 0x1C87830
	private void OnDisable() { }

	// RVA: 0x1C87840 Offset: 0x1C87941 VA: 0x1C87840
	private void Update() { }

	// RVA: 0x1C87BB0 Offset: 0x1C87CB1 VA: 0x1C87BB0
	public bool PlayForce(SeedSupportID SupportID, SeedSupportType SupportType) { }

	// RVA: 0x1C87ED0 Offset: 0x1C87FD1 VA: 0x1C87ED0 Slot: 5
	protected virtual void OnPlay() { }

	// RVA: 0x1C881D0 Offset: 0x1C882D1 VA: 0x1C881D0 Slot: 6
	protected virtual void OnStopped(PlayableDirector playableDirector) { }

	// RVA: 0x1C881E0 Offset: 0x1C882E1 VA: 0x1C881E0 Slot: 7
	protected virtual void OnResume() { }

	// RVA: 0x1C880D0 Offset: 0x1C881D1 VA: 0x1C880D0
	private void HideToolEquip(Actor actor) { }

	// RVA: 0x1C88400 Offset: 0x1C88501 VA: 0x1C88400
	private void ResetToolEquip(Actor actor) { }

	// RVA: 0x1C88500 Offset: 0x1C88601 VA: 0x1C88500
	private void Init() { }

	// RVA: 0x1C885D0 Offset: 0x1C886D1 VA: 0x1C885D0 Slot: 8
	public virtual void CleanUp() { }

	// RVA: 0x1C886F0 Offset: 0x1C887F1 VA: 0x1C886F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CCB0 Offset: 0x19CDB1 VA: 0x19CCB0
	// RVA: 0x1C88790 Offset: 0x1C88891 VA: 0x1C88790
	private void <PlayForce>b__19_0(AssetHandle<GameObject> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CCC0 Offset: 0x19CDC1 VA: 0x19CCC0
	// RVA: 0x1C889B0 Offset: 0x1C88AB1 VA: 0x1C889B0
	private void <Init>b__25_0(PlayableDirector director) { }
}

