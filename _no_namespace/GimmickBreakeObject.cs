[RequireComponent] // RVA: 0x146690 Offset: 0x146791 VA: 0x146690
[RequireComponent] // RVA: 0x146690 Offset: 0x146791 VA: 0x146690
public class GimmickBreakeObject : GimmickBase // TypeDefIndex: 7566
{
	// Fields
	protected const string EffectRootName = "EffectRoot";
	[SerializeField] // RVA: 0x167590 Offset: 0x167691 VA: 0x167590
	public EffectID EffectId; // 0x20
	[SerializeField] // RVA: 0x1675A0 Offset: 0x1676A1 VA: 0x1675A0
	private Transform EffectRoot; // 0x28
	[SerializeField] // RVA: 0x1675B0 Offset: 0x1676B1 VA: 0x1675B0
	public string SpawnItemIDString; // 0x30
	[SerializeField] // RVA: 0x1675C0 Offset: 0x1676C1 VA: 0x1675C0
	private ItemID SpawnItemID; // 0x38
	[SerializeField] // RVA: 0x1675D0 Offset: 0x1676D1 VA: 0x1675D0
	public int SpawnCount; // 0x3C
	public float FadeOutTime; // 0x40
	[SerializeField] // RVA: 0x1675E0 Offset: 0x1676E1 VA: 0x1675E0
	protected SoundID SeId; // 0x44
	protected Collider WallCollider; // 0x48
	private NavMeshObstacle NavMeshObstacle; // 0x50
	protected GameObject Object; // 0x58
	private ParticleSystem Effect; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x1675F0 Offset: 0x1676F1 VA: 0x1675F0
	private bool <IsBreakFade>k__BackingField; // 0x68
	private Renderer[] _renderer; // 0x70
	private MaterialPropertyBlock materialPropertyBlock; // 0x78
	private Coroutine fadeCoroutine; // 0x80

	// Properties
	public bool IsBreakFade { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A1AF0 Offset: 0x1A1BF1 VA: 0x1A1AF0
	// RVA: 0x1E9D0E0 Offset: 0x1E9D1E1 VA: 0x1E9D0E0
	public bool get_IsBreakFade() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1B00 Offset: 0x1A1C01 VA: 0x1A1B00
	// RVA: 0x1E9D0F0 Offset: 0x1E9D1F1 VA: 0x1E9D0F0
	protected void set_IsBreakFade(bool value) { }

	// RVA: 0x1E9D100 Offset: 0x1E9D201 VA: 0x1E9D100 Slot: 5
	protected override void OnDestroy() { }

	// RVA: 0x1E9D190 Offset: 0x1E9D291 VA: 0x1E9D190
	private void LoadEffect() { }

	// RVA: 0x1E9D300 Offset: 0x1E9D401 VA: 0x1E9D300 Slot: 11
	protected virtual void SetEnableCollider(bool isEnable) { }

	// RVA: 0x1E9D410 Offset: 0x1E9D511 VA: 0x1E9D410 Slot: 12
	protected virtual void Awake() { }

	// RVA: 0x1E9D5E0 Offset: 0x1E9D6E1 VA: 0x1E9D5E0 Slot: 6
	protected override void Start() { }

	// RVA: 0x1E9D5F0 Offset: 0x1E9D6F1 VA: 0x1E9D5F0 Slot: 7
	public override void SetGimmickState(bool newState) { }

	// RVA: 0x1E9D670 Offset: 0x1E9D771 VA: 0x1E9D670 Slot: 9
	public override void Init() { }

	// RVA: 0x1E9D760 Offset: 0x1E9D861 VA: 0x1E9D760 Slot: 13
	public virtual void SetGimmickFlag(bool setValue) { }

	// RVA: 0x1E9D820 Offset: 0x1E9D921 VA: 0x1E9D820 Slot: 10
	public override void SetGimmickActiveFlag(bool isActive) { }

	// RVA: 0x1E9D9A0 Offset: 0x1E9DAA1 VA: 0x1E9D9A0 Slot: 14
	public virtual void Breake(Vector3 hitPoint) { }

	// RVA: 0x1E9DCF0 Offset: 0x1E9DDF1 VA: 0x1E9DCF0 Slot: 15
	public virtual bool InvalieEffect(ref DamageInfo damageInfo) { }

	// RVA: 0x1E9DB50 Offset: 0x1E9DC51 VA: 0x1E9DB50
	private void FadeInit() { }

	// RVA: 0x1E9DED0 Offset: 0x1E9DFD1 VA: 0x1E9DED0
	private void FadeIn(float time = 1, Action action) { }

	// RVA: 0x1E9DC00 Offset: 0x1E9DD01 VA: 0x1E9DC00
	private void FadeOut(float time = 1, Action action) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1B10 Offset: 0x1A1C11 VA: 0x1A1B10
	// RVA: 0x1E9DFC0 Offset: 0x1E9E0C1 VA: 0x1E9DFC0
	private IEnumerator Fade(float start, float end, float fade_time, Action action) { }

	// RVA: 0x1E9D880 Offset: 0x1E9D981 VA: 0x1E9D880
	private void SetAlpha(float alpha) { }

	// RVA: 0x1E9E0B0 Offset: 0x1E9E1B1 VA: 0x1E9E0B0
	private void FadeWaitStart(float time) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1B80 Offset: 0x1A1C81 VA: 0x1A1B80
	// RVA: 0x1E9E180 Offset: 0x1E9E281 VA: 0x1E9E180
	private IEnumerator FadeWait(float fade_time) { }

	// RVA: 0x1E9E240 Offset: 0x1E9E341 VA: 0x1E9E240
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1BF0 Offset: 0x1A1CF1 VA: 0x1A1BF0
	// RVA: 0x1E9E2B0 Offset: 0x1E9E3B1 VA: 0x1E9E2B0
	private void <LoadEffect>b__17_0(ParticleSystem effect) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1C00 Offset: 0x1A1D01 VA: 0x1A1C00
	// RVA: 0x1E9E3A0 Offset: 0x1E9E4A1 VA: 0x1E9E3A0
	private void <Breake>b__25_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1C10 Offset: 0x1A1D11 VA: 0x1A1C10
	// RVA: 0x1E9E3C0 Offset: 0x1E9E4C1 VA: 0x1E9E3C0
	private void <Breake>b__25_1() { }
}

