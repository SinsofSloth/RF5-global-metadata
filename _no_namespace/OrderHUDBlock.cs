public class OrderHUDBlock : MonoBehaviour // TypeDefIndex: 8592
{
	// Fields
	[SerializeField] // RVA: 0x170F10 Offset: 0x171011 VA: 0x170F10
	private RectTransform rect; // 0x18
	[SerializeField] // RVA: 0x170F20 Offset: 0x171021 VA: 0x170F20
	private Text DetailText; // 0x20
	[SerializeField] // RVA: 0x170F30 Offset: 0x171031 VA: 0x170F30
	private Text NumText; // 0x28
	[SerializeField] // RVA: 0x170F40 Offset: 0x171041 VA: 0x170F40
	private Image CompleteImg; // 0x30
	[SerializeField] // RVA: 0x170F50 Offset: 0x171051 VA: 0x170F50
	private Image FailImg; // 0x38
	[SerializeField] // RVA: 0x170F60 Offset: 0x171061 VA: 0x170F60
	private Image IconImg; // 0x40
	[SerializeField] // RVA: 0x170F70 Offset: 0x171071 VA: 0x170F70
	private float BlockPadding; // 0x48
	[SerializeField] // RVA: 0x170F80 Offset: 0x171081 VA: 0x170F80
	private float StartX; // 0x4C
	private int oldBlockNo; // 0x50
	public int blockNo; // 0x54
	private OrderPopControl Controller; // 0x58
	private const float ShowTimeOnStart = 5;
	private const float ShowTimeOnUpdate = 5;
	private float ShowTime; // 0x60
	private bool isFadeIn; // 0x64
	private const float fadeTimeMax = 0.2;
	private float fadeTime; // 0x68
	private const float updownFadeTimeMax = 0.2;
	private float updownFadeTime; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x170F90 Offset: 0x171091 VA: 0x170F90
	private bool <isEnd>k__BackingField; // 0x70
	private bool onStopCreate; // 0x71

	// Properties
	public bool isEnd { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7E20 Offset: 0x1A7F21 VA: 0x1A7E20
	// RVA: 0x1F20A90 Offset: 0x1F20B91 VA: 0x1F20A90
	public bool get_isEnd() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7E30 Offset: 0x1A7F31 VA: 0x1A7E30
	// RVA: 0x1F20AA0 Offset: 0x1F20BA1 VA: 0x1F20AA0
	private void set_isEnd(bool value) { }

	// RVA: 0x1F20AB0 Offset: 0x1F20BB1 VA: 0x1F20AB0
	private void SetActive(bool value, float posX = 0) { }

	// RVA: 0x1F20BF0 Offset: 0x1F20CF1 VA: 0x1F20BF0
	public void InstantiatedInit(OrderPopControl orderPopControl, int BlockNo, OrderData orderData, Sprite IconImage, float addShowTime) { }

	// RVA: 0x1F20DF0 Offset: 0x1F20EF1 VA: 0x1F20DF0
	public void OnStopInstantiatedInit(OrderPopControl orderPopControl) { }

	// RVA: 0x1F20E60 Offset: 0x1F20F61 VA: 0x1F20E60
	public void OnUpdate(OrderData orderData) { }

	// RVA: 0x1F21040 Offset: 0x1F21141 VA: 0x1F21040
	public void OnFinish(OrderData orderData) { }

	// RVA: 0x1F21330 Offset: 0x1F21431 VA: 0x1F21330
	private void OnDestroy() { }

	// RVA: 0x1F204C0 Offset: 0x1F205C1 VA: 0x1F204C0
	public void OnEnd(OrderData orderData) { }

	// RVA: 0x1F21410 Offset: 0x1F21511 VA: 0x1F21410
	public void OnFail(OrderData orderData) { }

	// RVA: 0x1F21660 Offset: 0x1F21761 VA: 0x1F21660
	public void SetRedisp(float plusTime) { }

	// RVA: 0x1F216F0 Offset: 0x1F217F1 VA: 0x1F216F0
	public void SetStay(float plusTime) { }

	// RVA: 0x1F20B50 Offset: 0x1F20C51 VA: 0x1F20B50
	public void SetPosOnAppear(float posX) { }

	// RVA: 0x1F218E0 Offset: 0x1F219E1 VA: 0x1F218E0
	private void LateUpdate() { }

	// RVA: 0x1F21CC0 Offset: 0x1F21DC1 VA: 0x1F21CC0
	public void .ctor() { }
}

