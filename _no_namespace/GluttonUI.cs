public class GluttonUI : FestivalUI // TypeDefIndex: 7392
{
	// Fields
	[SerializeField] // RVA: 0x166250 Offset: 0x166351 VA: 0x166250
	private GameObject ImageBtnBase; // 0x48
	private readonly Vector2 BTN_CENTER; // 0x50
	private readonly Vector2 BTN_LEFT; // 0x58
	private readonly Vector2 BTN_RIGHT; // 0x60
	[SerializeField] // RVA: 0x166260 Offset: 0x166361 VA: 0x166260
	private FestivalNumScore ScorePlus; // 0x68
	[SerializeField] // RVA: 0x166270 Offset: 0x166371 VA: 0x166270
	private FestivalNumScore ScoreMinus; // 0x70
	private readonly Vector2 SCORE_CENTER; // 0x78
	private readonly Vector2 SCORE_LEFT; // 0x80
	private readonly Vector2 SCORE_RIGHT; // 0x88

	// Methods

	// RVA: 0x1EB1A30 Offset: 0x1EB1B31 VA: 0x1EB1A30 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1EB1A40 Offset: 0x1EB1B41 VA: 0x1EB1A40
	private void Start() { }

	// RVA: 0x1EB0C80 Offset: 0x1EB0D81 VA: 0x1EB0C80
	public void OnBtnImage(GluttonTablePos pos) { }

	// RVA: 0x1EB0EF0 Offset: 0x1EB0FF1 VA: 0x1EB0EF0
	public void OnBtnImageOff() { }

	// RVA: 0x1EB0DC0 Offset: 0x1EB0EC1 VA: 0x1EB0DC0
	public void OnBtnPush() { }

	// RVA: 0x1EB0AF0 Offset: 0x1EB0BF1 VA: 0x1EB0AF0
	public void OnScoreImage(GluttonTablePos pos) { }

	// RVA: 0x1EB0E20 Offset: 0x1EB0F21 VA: 0x1EB0E20
	public void OnScorePlay(bool _plus, int _score) { }

	// RVA: 0x1EB1A60 Offset: 0x1EB1B61 VA: 0x1EB1A60
	public void .ctor() { }
}

