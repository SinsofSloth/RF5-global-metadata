public class MoveCloud : MonoBehaviour // TypeDefIndex: 7600
{
	// Fields
	public Spline Spline; // 0x18
	public float MoveSpeed; // 0x20
	public float FadeInTime; // 0x24
	public float FadeOutTime; // 0x28
	[SerializeField] // RVA: 0x168050 Offset: 0x168151 VA: 0x168050
	[RangeAttribute] // RVA: 0x168050 Offset: 0x168151 VA: 0x168050
	public float LerpValue; // 0x2C
	[SerializeField] // RVA: 0x1680A0 Offset: 0x1681A1 VA: 0x1680A0
	public Vector3 Rotation; // 0x30
	[SerializeField] // RVA: 0x1680B0 Offset: 0x1681B1 VA: 0x1680B0
	private float DelayTime; // 0x3C
	private bool IsBreak; // 0x40
	private float MovedDistance; // 0x44
	private Vector3 PrebPoint; // 0x48
	private CurveSample Sample; // 0x54
	private Quaternion target_rot; // 0x9C
	private Renderer _renderer; // 0xB0
	private MaterialPropertyBlock materialPropertyBlock; // 0xB8
	private Coroutine fadeCoroutine; // 0xC0

	// Methods

	// RVA: 0x1CD9F60 Offset: 0x1CDA061 VA: 0x1CD9F60
	private void Awake() { }

	// RVA: 0x1CDA0E0 Offset: 0x1CDA1E1 VA: 0x1CDA0E0
	private void Start() { }

	// RVA: 0x1CDA1D0 Offset: 0x1CDA2D1 VA: 0x1CDA1D0
	private void Update() { }

	// RVA: 0x1CDA200 Offset: 0x1CDA301 VA: 0x1CDA200
	private void Update0() { }

	// RVA: 0x1CDA530 Offset: 0x1CDA631 VA: 0x1CDA530
	private void Update1() { }

	// RVA: 0x1CDA670 Offset: 0x1CDA771 VA: 0x1CDA670
	public void Break() { }

	// RVA: 0x1CDA040 Offset: 0x1CDA141 VA: 0x1CDA040
	private void FadeInit() { }

	// RVA: 0x1CDA0F0 Offset: 0x1CDA1F1 VA: 0x1CDA0F0
	private void FadeIn(float time = 1) { }

	// RVA: 0x1CDA870 Offset: 0x1CDA971 VA: 0x1CDA870
	private void FadeOut(float time = 1) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1FF0 Offset: 0x1A20F1 VA: 0x1A1FF0
	// RVA: 0x1CDAA10 Offset: 0x1CDAB11 VA: 0x1CDAA10
	private IEnumerator Fade(float start, float end, float fade_time) { }

	// RVA: 0x1CDA950 Offset: 0x1CDAA51 VA: 0x1CDA950
	private void SetAlpha(float alpha) { }

	// RVA: 0x1CDAAE0 Offset: 0x1CDABE1 VA: 0x1CDAAE0
	public void .ctor() { }
}

