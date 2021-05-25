public class CutInTelopControl : MonoBehaviour // TypeDefIndex: 8476
{
	// Fields
	[SerializeField] // RVA: 0x16FF70 Offset: 0x170071 VA: 0x16FF70
	private SText SText; // 0x18
	[SerializeField] // RVA: 0x16FF80 Offset: 0x170081 VA: 0x16FF80
	private Image TelopImage; // 0x20
	[SerializeField] // RVA: 0x16FF90 Offset: 0x170091 VA: 0x16FF90
	private float MinTextWidth; // 0x28
	[SerializeField] // RVA: 0x16FFA0 Offset: 0x1700A1 VA: 0x16FFA0
	private float fadeSpeed; // 0x2C
	private RectTransform rectTransform; // 0x30
	private Color borderColor; // 0x38
	private Color textColor; // 0x48
	private string TextId; // 0x58
	private float LifeTime; // 0x60
	private float fade; // 0x64
	private bool Inited; // 0x68

	// Methods

	// RVA: 0x1FD8220 Offset: 0x1FD8321 VA: 0x1FD8220
	private void CheckInit() { }

	// RVA: 0x1FD82E0 Offset: 0x1FD83E1 VA: 0x1FD82E0
	public void UseTelopOn(string textid, float lifeTime, bool PlaySE) { }

	// RVA: 0x1FD84C0 Offset: 0x1FD85C1 VA: 0x1FD84C0
	private void SetColor() { }

	// RVA: 0x1FD8530 Offset: 0x1FD8631 VA: 0x1FD8530
	private void Update() { }

	// RVA: 0x1FD8770 Offset: 0x1FD8871 VA: 0x1FD8770
	public void .ctor() { }
}

