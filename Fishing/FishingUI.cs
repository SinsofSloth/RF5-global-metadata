public class FishingUI : MonoBehaviour // TypeDefIndex: 10304
{
	// Fields
	[SerializeField] // RVA: 0x181150 Offset: 0x181251 VA: 0x181150
	private RectTransform RecordMaxRectTransform; // 0x18
	private RectTransform FishingUIRect; // 0x20
	[SerializeField] // RVA: 0x181160 Offset: 0x181261 VA: 0x181160
	private Image Back; // 0x28
	[SerializeField] // RVA: 0x181170 Offset: 0x181271 VA: 0x181170
	private Image RecordMax; // 0x30
	private FishingUI.State state_; // 0x38
	private const float FADE_IN_TIME = 0.5;
	private const float FADE_OUT_TIME = 0.5;
	private float time_; // 0x3C
	private int TexId; // 0x40
	private bool is_next; // 0x44
	private bool isDestroy; // 0x45
	private SoundID[] se_tbl_; // 0x48

	// Methods

	// RVA: 0x1D4B8C0 Offset: 0x1D4B9C1 VA: 0x1D4B8C0
	public void Load(int tex_id) { }

	// RVA: 0x1D4BE80 Offset: 0x1D4BF81 VA: 0x1D4BE80
	private void MaxStart() { }

	// RVA: 0x1D4C230 Offset: 0x1D4C331 VA: 0x1D4C230
	public void Next() { }

	// RVA: 0x1D4C240 Offset: 0x1D4C341 VA: 0x1D4C240
	private void Awake() { }

	// RVA: 0x1D4C2B0 Offset: 0x1D4C3B1 VA: 0x1D4C2B0
	private void Start() { }

	// RVA: 0x1D4C3E0 Offset: 0x1D4C4E1 VA: 0x1D4C3E0
	private void OnDestroy() { }

	// RVA: 0x1D4C4E0 Offset: 0x1D4C5E1 VA: 0x1D4C4E0
	private void Update() { }

	// RVA: 0x1D4C8B0 Offset: 0x1D4C9B1 VA: 0x1D4C8B0
	public void CheckDestroy() { }

	// RVA: 0x1D4C460 Offset: 0x1D4C561 VA: 0x1D4C460
	private void RemoveTex() { }

	// RVA: 0x1D4BFD0 Offset: 0x1D4C0D1 VA: 0x1D4BFD0
	private void SetAlpha(Image image, float alpha) { }

	// RVA: 0x1D4C150 Offset: 0x1D4C251 VA: 0x1D4C150
	private void SetScale(RectTransform rect, float scale) { }

	// RVA: 0x1D4C0A0 Offset: 0x1D4C1A1 VA: 0x1D4C0A0
	private void SetEnable(Image image, bool enable) { }

	// RVA: 0x1D4C9B0 Offset: 0x1D4CAB1 VA: 0x1D4C9B0
	private void SetTexture(Image image, Texture tex) { }

	// RVA: 0x1D4CAF0 Offset: 0x1D4CBF1 VA: 0x1D4CAF0
	private void SetSize(RectTransform rect, Texture tex) { }

	// RVA: 0x1D4CB70 Offset: 0x1D4CC71 VA: 0x1D4CB70
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE100 Offset: 0x1AE201 VA: 0x1AE100
	// RVA: 0x1D4CC00 Offset: 0x1D4CD01 VA: 0x1D4CC00
	private void <Load>b__13_0(AssetHandle<Texture> handle) { }
}

