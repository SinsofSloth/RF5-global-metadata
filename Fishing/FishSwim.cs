public class FishSwim : MonoBehaviour // TypeDefIndex: 10286
{
	// Fields
	public string PointName; // 0x18
	public ItemID FishId; // 0x20
	public int Size; // 0x24
	public int DispSize; // 0x28
	[HideInInspector] // RVA: 0x180DE0 Offset: 0x180EE1 VA: 0x180DE0
	public int IsDay; // 0x2C
	public float ChangeInterval; // 0x30
	public bool Use; // 0x34
	[SerializeField] // RVA: 0x180DF0 Offset: 0x180EF1 VA: 0x180DF0
	private FishSwim.State state_; // 0x38
	private Vector3 box_size_; // 0x3C
	public Vector3 FishingBoxPos; // 0x48
	[HideInInspector] // RVA: 0x180E00 Offset: 0x180F01 VA: 0x180E00
	public Quaternion FishingBoxRot; // 0x54
	private float move_speed_; // 0x64
	private float move_speed2_; // 0x68
	private float rotate_speed_; // 0x6C
	private Quaternion startRotation; // 0x70
	private Quaternion targetRotation; // 0x80
	private float rotate_time_; // 0x90
	private Vector3 target_; // 0x94
	[SerializeField] // RVA: 0x180E10 Offset: 0x180F11 VA: 0x180E10
	private int biteCount; // 0xA0
	[SerializeField] // RVA: 0x180E20 Offset: 0x180F21 VA: 0x180E20
	private float biteWaitTime; // 0xA4
	[SerializeField] // RVA: 0x180E30 Offset: 0x180F31 VA: 0x180E30
	private float PunchTime; // 0xA8
	[SerializeField] // RVA: 0x180E40 Offset: 0x180F41 VA: 0x180E40
	private Ease PunchEase; // 0xAC
	[SerializeField] // RVA: 0x180E50 Offset: 0x180F51 VA: 0x180E50
	private float PunchTime2; // 0xB0
	[SerializeField] // RVA: 0x180E60 Offset: 0x180F61 VA: 0x180E60
	private Ease PunchEase2; // 0xB4
	private float[] hit_wait_time_; // 0xB8
	private float time_; // 0xC0
	private float dist_; // 0xC4
	private Coroutine coroutine_; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x180E70 Offset: 0x180F71 VA: 0x180E70
	private int <UniqueId>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x180E80 Offset: 0x180F81 VA: 0x180E80
	private bool <IsSingleSpawn>k__BackingField; // 0xD4
	public float InactiveTime; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x180E90 Offset: 0x180F91 VA: 0x180E90
	private FishAnimation <fishAnimation>k__BackingField; // 0xE0
	private Tweener _tween; // 0xE8
	private int StartTime; // 0xF0
	private EmotionController emotionController; // 0xF8
	private Renderer _renderer; // 0x100
	private MaterialPropertyBlock materialPropertyBlock; // 0x108
	private Coroutine fadeCoroutine; // 0x110
	private SkinnedMeshRenderer SkinnedMeshRenderer; // 0x118
	private Vector3 startPos; // 0x120
	private Vector3 targetPos; // 0x12C

	// Properties
	public FishSwim.State GatState { get; }
	public Vector3 BoxSize { get; }
	public int UniqueId { get; set; }
	public bool IsSingleSpawn { get; set; }
	public FishAnimation fishAnimation { get; set; }

	// Methods

	// RVA: 0x1EF4700 Offset: 0x1EF4801 VA: 0x1EF4700
	public FishSwim.State get_GatState() { }

	// RVA: 0x1EF4710 Offset: 0x1EF4811 VA: 0x1EF4710
	public void SetState(FishSwim.State state) { }

	// RVA: 0x1EF4720 Offset: 0x1EF4821 VA: 0x1EF4720
	public Vector3 get_BoxSize() { }

	// RVA: 0x1EF4560 Offset: 0x1EF4661 VA: 0x1EF4560
	public void SetBoxSize(Vector3 size) { }

	// RVA: 0x1EF4730 Offset: 0x1EF4831 VA: 0x1EF4730
	public void SetTarget(Vector3 target) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADD50 Offset: 0x1ADE51 VA: 0x1ADD50
	// RVA: 0x1EF4740 Offset: 0x1EF4841 VA: 0x1EF4740
	public int get_UniqueId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADD60 Offset: 0x1ADE61 VA: 0x1ADD60
	// RVA: 0x1EF4750 Offset: 0x1EF4851 VA: 0x1EF4750
	private void set_UniqueId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADD70 Offset: 0x1ADE71 VA: 0x1ADD70
	// RVA: 0x1EF4760 Offset: 0x1EF4861 VA: 0x1EF4760
	public bool get_IsSingleSpawn() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADD80 Offset: 0x1ADE81 VA: 0x1ADD80
	// RVA: 0x1EF4770 Offset: 0x1EF4871 VA: 0x1EF4770
	private void set_IsSingleSpawn(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADD90 Offset: 0x1ADE91 VA: 0x1ADD90
	// RVA: 0x1EF4780 Offset: 0x1EF4881 VA: 0x1EF4780
	public FishAnimation get_fishAnimation() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ADDA0 Offset: 0x1ADEA1 VA: 0x1ADDA0
	// RVA: 0x1EF4790 Offset: 0x1EF4891 VA: 0x1EF4790
	private void set_fishAnimation(FishAnimation value) { }

	// RVA: 0x1EF47A0 Offset: 0x1EF48A1 VA: 0x1EF47A0
	public void FadeIn(float time = 1) { }

	// RVA: 0x1EF4950 Offset: 0x1EF4A51 VA: 0x1EF4950
	public void FadeOut(float time = 1) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ADDB0 Offset: 0x1ADEB1 VA: 0x1ADDB0
	// RVA: 0x1EF48B0 Offset: 0x1EF49B1 VA: 0x1EF48B0
	private IEnumerator Fade(float start, float end, float fade_time) { }

	// RVA: 0x1EF4A50 Offset: 0x1EF4B51 VA: 0x1EF4A50
	public void SetAlpha(float alpha) { }

	// RVA: 0x1EF4AD0 Offset: 0x1EF4BD1 VA: 0x1EF4AD0
	public void SetMaterial(Material material) { }

	// RVA: 0x1EF4B80 Offset: 0x1EF4C81 VA: 0x1EF4B80
	private void Awake() { }

	// RVA: 0x1EF4D70 Offset: 0x1EF4E71 VA: 0x1EF4D70
	private void OnDestroy() { }

	// RVA: 0x1EF3BA0 Offset: 0x1EF3CA1 VA: 0x1EF3BA0
	public void Release() { }

	// RVA: 0x1EF4FD0 Offset: 0x1EF50D1 VA: 0x1EF4FD0
	private void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ADE20 Offset: 0x1ADF21 VA: 0x1ADE20
	// RVA: 0x1EF6270 Offset: 0x1EF6371 VA: 0x1EF6270
	private IEnumerator BiteCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ADE90 Offset: 0x1ADF91 VA: 0x1ADE90
	// RVA: 0x1EF62F0 Offset: 0x1EF63F1 VA: 0x1EF62F0
	private IEnumerator HitCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ADF00 Offset: 0x1AE001 VA: 0x1ADF00
	// RVA: 0x1EF64A0 Offset: 0x1EF65A1 VA: 0x1EF64A0
	private IEnumerator HattenCoroutine() { }

	// RVA: 0x1EF6550 Offset: 0x1EF6651 VA: 0x1EF6550
	public void Hatten() { }

	// RVA: 0x1EF65F0 Offset: 0x1EF66F1 VA: 0x1EF65F0
	public void Escape() { }

	// RVA: 0x1EF6990 Offset: 0x1EF6A91 VA: 0x1EF6990
	public void SetMove() { }

	// RVA: 0x1EF6A00 Offset: 0x1EF6B01 VA: 0x1EF6A00
	public void Spawn() { }

	// RVA: 0x1EF6AE0 Offset: 0x1EF6BE1 VA: 0x1EF6AE0
	private float BiteTime(float default_time) { }

	// RVA: 0x1EF6B70 Offset: 0x1EF6C71 VA: 0x1EF6B70
	public void Surprise() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ADF70 Offset: 0x1AE071 VA: 0x1ADF70
	// RVA: 0x1EF6C10 Offset: 0x1EF6D11 VA: 0x1EF6C10
	private IEnumerator SurpriseCoroutine() { }

	// RVA: 0x1EF68F0 Offset: 0x1EF69F1 VA: 0x1EF68F0
	private void PlayManpu(EmotionType emotionType) { }

	// RVA: 0x1EF6CC0 Offset: 0x1EF6DC1 VA: 0x1EF6CC0
	public void .ctor() { }
}

