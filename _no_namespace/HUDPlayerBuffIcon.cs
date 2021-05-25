public class HUDPlayerBuffIcon : MonoBehaviour // TypeDefIndex: 8575
{
	// Fields
	[SerializeField] // RVA: 0x170C00 Offset: 0x170D01 VA: 0x170C00
	private Image FoodIconImage; // 0x18
	[SerializeField] // RVA: 0x170C10 Offset: 0x170D11 VA: 0x170C10
	private Image OnsenIconImage; // 0x20
	[SerializeField] // RVA: 0x170C20 Offset: 0x170D21 VA: 0x170C20
	private Image VaccineIconImage; // 0x28
	[SerializeField] // RVA: 0x170C30 Offset: 0x170D31 VA: 0x170C30
	private Image HandCuffIconImage; // 0x30
	[SerializeField] // RVA: 0x170C40 Offset: 0x170D41 VA: 0x170C40
	private RectTransform[] SubBuffPos; // 0x38
	private bool foodStat; // 0x40
	private bool onsenStat; // 0x41
	private bool vacStat; // 0x42
	private bool handcuffStat; // 0x43
	private HumanStatus humanStatus; // 0x48

	// Methods

	// RVA: 0x1ECE2F0 Offset: 0x1ECE3F1 VA: 0x1ECE2F0
	private void Start() { }

	// RVA: 0x1ECE4D0 Offset: 0x1ECE5D1 VA: 0x1ECE4D0
	private bool CheckOnFoodBuff() { }

	// RVA: 0x1ECE660 Offset: 0x1ECE761 VA: 0x1ECE660
	private bool CheckOnOnsenBuff() { }

	// RVA: 0x1ECE7F0 Offset: 0x1ECE8F1 VA: 0x1ECE7F0
	private bool CheckOnVacBuff() { }

	// RVA: 0x1ECEA70 Offset: 0x1ECEB71 VA: 0x1ECEA70
	private bool CheckOnHandCuff() { }

	// RVA: 0x1ECEC60 Offset: 0x1ECED61 VA: 0x1ECEC60
	private void SetDispFood() { }

	// RVA: 0x1ECED50 Offset: 0x1ECEE51 VA: 0x1ECED50
	private void SetDispOnsen() { }

	// RVA: 0x1ECEE00 Offset: 0x1ECEF01 VA: 0x1ECEE00
	private void SetDispVac() { }

	// RVA: 0x1ECEEB0 Offset: 0x1ECEFB1 VA: 0x1ECEEB0
	private void SetDispHandcuff() { }

	// RVA: 0x1ECEF50 Offset: 0x1ECF051 VA: 0x1ECEF50
	private void Update() { }

	// RVA: 0x1ECEFF0 Offset: 0x1ECF0F1 VA: 0x1ECEFF0
	public void .ctor() { }
}

