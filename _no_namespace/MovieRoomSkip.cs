public class MovieRoomSkip : MonoBehaviour // TypeDefIndex: 8787
{
	// Fields
	public Key ActiveKey; // 0x18
	private UnityAction action; // 0x20
	[SerializeField] // RVA: 0x173750 Offset: 0x173851 VA: 0x173750
	private List<Sprite> dotSprite; // 0x28
	[SerializeField] // RVA: 0x173760 Offset: 0x173861 VA: 0x173760
	private List<Image> dotImage; // 0x30
	private CanvasGroup canvasGroup; // 0x38
	private const float FADE_SPEED = 5;
	private const float ACTIVE_TIME = 2;
	private float activeTimeCount; // 0x40
	private const float SKIP_TIME = 0.5;
	private float animInterval; // 0x44
	private float skipTimeCount; // 0x48
	private int dot; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x173770 Offset: 0x173871 VA: 0x173770
	private bool <IsReady>k__BackingField; // 0x50
	private MovieRoomSkip.State state; // 0x54

	// Properties
	public bool IsReady { get; set; }

	// Methods

	// RVA: 0x1CDED50 Offset: 0x1CDEE51 VA: 0x1CDED50
	public void IsMoviePlaying(UnityAction _call_back, bool _enable_skip = True) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8730 Offset: 0x1A8831 VA: 0x1A8730
	// RVA: 0x1CE1100 Offset: 0x1CE1201 VA: 0x1CE1100
	public bool get_IsReady() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8740 Offset: 0x1A8841 VA: 0x1A8740
	// RVA: 0x1CE1110 Offset: 0x1CE1211 VA: 0x1CE1110
	public void set_IsReady(bool value) { }

	// RVA: 0x1CE1120 Offset: 0x1CE1221 VA: 0x1CE1120
	private void Start() { }

	// RVA: 0x1CE12B0 Offset: 0x1CE13B1 VA: 0x1CE12B0
	private void Update() { }

	// RVA: 0x1CE16E0 Offset: 0x1CE17E1 VA: 0x1CE16E0
	public void .ctor() { }
}

