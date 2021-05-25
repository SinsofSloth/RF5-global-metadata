public class InfoCanvasControl : MonoBehaviour // TypeDefIndex: 8866
{
	// Fields
	[SerializeField] // RVA: 0x174580 Offset: 0x174681 VA: 0x174580
	private Image LogoBg; // 0x18
	[SerializeField] // RVA: 0x174590 Offset: 0x174691 VA: 0x174590
	private GameObject InfoBg; // 0x20
	[SerializeField] // RVA: 0x1745A0 Offset: 0x1746A1 VA: 0x1745A0
	private Text InfoText; // 0x28
	[SerializeField] // RVA: 0x1745B0 Offset: 0x1746B1 VA: 0x1745B0
	private GameObject BtnBg; // 0x30
	[SerializeField] // RVA: 0x1745C0 Offset: 0x1746C1 VA: 0x1745C0
	private TitleTextButton BtnYesCntl; // 0x38
	[SerializeField] // RVA: 0x1745D0 Offset: 0x1746D1 VA: 0x1745D0
	private TitleTextButton BtnNoCntl; // 0x40
	[SerializeField] // RVA: 0x1745E0 Offset: 0x1746E1 VA: 0x1745E0
	private TitleTextButton BtnOkCntl; // 0x48
	private ChoiceButton BtnYes; // 0x50
	private ChoiceButton BtnNo; // 0x58
	private ChoiceButton BtnOk; // 0x60
	[SerializeField] // RVA: 0x1745F0 Offset: 0x1746F1 VA: 0x1745F0
	private RectTransform IconSaveRect; // 0x68
	[SerializeField] // RVA: 0x174600 Offset: 0x174701 VA: 0x174600
	private GameObject touchScreen; // 0x70

	// Methods

	// RVA: 0x20C69C0 Offset: 0x20C6AC1 VA: 0x20C69C0
	private void Start() { }

	// RVA: 0x20C6BF0 Offset: 0x20C6CF1 VA: 0x20C6BF0
	private void Update() { }

	// RVA: 0x20C6C00 Offset: 0x20C6D01 VA: 0x20C6C00
	private void updateSaveIcon() { }

	// RVA: 0x20C6CE0 Offset: 0x20C6DE1 VA: 0x20C6CE0
	public void SetLogoImg(Sprite spr) { }

	// RVA: 0x20C6D00 Offset: 0x20C6E01 VA: 0x20C6D00
	public void OnLogoImg(bool flg) { }

	// RVA: 0x20C6D10 Offset: 0x20C6E11 VA: 0x20C6D10
	public void SetInfoText(string text) { }

	// RVA: 0x20C6D40 Offset: 0x20C6E41 VA: 0x20C6D40
	public void OnInfoBg(bool flg) { }

	// RVA: 0x20C6D60 Offset: 0x20C6E61 VA: 0x20C6D60
	public void OnBtn(bool flg, int type = 0) { }

	// RVA: 0x20C6E90 Offset: 0x20C6F91 VA: 0x20C6E90
	public void FocusBtnYes(bool flg) { }

	// RVA: 0x20C6EE0 Offset: 0x20C6FE1 VA: 0x20C6EE0
	public void FocusBtnOk(bool flg) { }

	// RVA: 0x20C6F00 Offset: 0x20C7001 VA: 0x20C6F00
	public void OnSaveIcon(bool flg) { }

	// RVA: 0x20C6BD0 Offset: 0x20C6CD1 VA: 0x20C6BD0
	public void OnTouchScreen(bool flg) { }

	// RVA: 0x20C6F10 Offset: 0x20C7011 VA: 0x20C6F10
	public void DoButton(TitleTextButton.TextButtonType _type) { }

	// RVA: 0x20C6F70 Offset: 0x20C7071 VA: 0x20C6F70
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8B20 Offset: 0x1A8C21 VA: 0x1A8B20
	// RVA: 0x20C6F80 Offset: 0x20C7081 VA: 0x20C6F80
	private void <Start>b__12_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8B30 Offset: 0x1A8C31 VA: 0x1A8B30
	// RVA: 0x20C7010 Offset: 0x20C7111 VA: 0x20C7010
	private void <Start>b__12_1() { }
}

