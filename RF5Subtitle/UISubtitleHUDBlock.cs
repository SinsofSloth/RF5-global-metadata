public class UISubtitleHUDBlock : MonoBehaviour // TypeDefIndex: 9771
{
	// Fields
	[SerializeField] // RVA: 0x17F130 Offset: 0x17F231 VA: 0x17F130
	private Image iconImage; // 0x18
	[SerializeField] // RVA: 0x17F140 Offset: 0x17F241 VA: 0x17F140
	private Text Text; // 0x20
	[SerializeField] // RVA: 0x17F150 Offset: 0x17F251 VA: 0x17F150
	private Image borderImage; // 0x28
	[SerializeField] // RVA: 0x17F160 Offset: 0x17F261 VA: 0x17F160
	private float baseWidth; // 0x30
	private RectTransform rectTransform; // 0x38
	private float baseHeight; // 0x40
	public SubtitleHandler handler; // 0x48
	private int dispNum; // 0x50
	private CanvasGroup canvasGroup; // 0x58
	private Vector2 posA; // 0x60
	private Vector2 posB; // 0x68
	private float lifeTime; // 0x70
	private float moveTime; // 0x74
	private const float moveTimeMax = 0.2;
	private float appearTime; // 0x78
	private const float appearTimeMax = 0.1;
	private float disTime; // 0x7C
	private const float disTimeMax = 0.2;
	private bool onDeleting; // 0x80
	private const int NpcIdMax = 36;
	private const int ChildBoyA = 36;
	private const int ChildBoyB = 37;
	private const int ChildBoyC = 38;
	private const int ChildGirlA = 39;
	private const int ChildGirlB = 40;
	private const int ChildGirlC = 41;
	private const int SeedMobA = 42;
	private const int SeedMobB = 43;

	// Properties
	public float height { get; }

	// Methods

	// RVA: 0x1DFCC00 Offset: 0x1DFCD01 VA: 0x1DFCC00
	public float get_height() { }

	// RVA: 0x1DFCC40 Offset: 0x1DFCD41 VA: 0x1DFCC40
	private bool CheckChildNpcId(ChildData cData, bool isMale, ChildPersonality personality) { }

	// RVA: 0x1DFCC80 Offset: 0x1DFCD81 VA: 0x1DFCC80
	private int GetChildNpcId(bool isMale, ChildPersonality personality) { }

	// RVA: 0x1DFCDA0 Offset: 0x1DFCEA1 VA: 0x1DFCDA0
	private int ConvNpcId(int id) { }

	// RVA: 0x1DFCE20 Offset: 0x1DFCF21 VA: 0x1DFCE20
	public void ForceEnd() { }

	// RVA: 0x1DFCE30 Offset: 0x1DFCF31 VA: 0x1DFCE30
	public void ResetHeight(float slideDown) { }

	// RVA: 0x1DFCEF0 Offset: 0x1DFCFF1 VA: 0x1DFCEF0
	public void Setup(SubtitleHandler _handler, string text, int npcid, int _dispNum, float slideDown) { }

	// RVA: 0x1DFB2A0 Offset: 0x1DFB3A1 VA: 0x1DFB2A0
	public void EndVoice() { }

	// RVA: 0x1DFD220 Offset: 0x1DFD321 VA: 0x1DFD220
	public void Update() { }

	// RVA: 0x1DFD700 Offset: 0x1DFD801 VA: 0x1DFD700
	public void .ctor() { }
}

