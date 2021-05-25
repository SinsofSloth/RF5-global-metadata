[MessagePackObjectAttribute] // RVA: 0x1461D0 Offset: 0x1462D1 VA: 0x1461D0
[Serializable]
public class EventData // TypeDefIndex: 7151
{
	// Fields
	[KeyAttribute] // RVA: 0x163E90 Offset: 0x163F91 VA: 0x163E90
	[SerializeField] // RVA: 0x163E90 Offset: 0x163F91 VA: 0x163E90
	public int EventId; // 0x10
	[KeyAttribute] // RVA: 0x163EE0 Offset: 0x163FE1 VA: 0x163EE0
	[SerializeField] // RVA: 0x163EE0 Offset: 0x163FE1 VA: 0x163EE0
	public int EventState; // 0x14
	[KeyAttribute] // RVA: 0x163F30 Offset: 0x164031 VA: 0x163F30
	[SerializeField] // RVA: 0x163F30 Offset: 0x164031 VA: 0x163F30
	public int OrderId; // 0x18
	[KeyAttribute] // RVA: 0x163F80 Offset: 0x164081 VA: 0x163F80
	[SerializeField] // RVA: 0x163F80 Offset: 0x164081 VA: 0x163F80
	public int CurrentStep; // 0x1C
	[KeyAttribute] // RVA: 0x163FD0 Offset: 0x1640D1 VA: 0x163FD0
	[SerializeField] // RVA: 0x163FD0 Offset: 0x1640D1 VA: 0x163FD0
	public int CurrentReservedStep; // 0x20
	[KeyAttribute] // RVA: 0x164020 Offset: 0x164121 VA: 0x164020
	[SerializeField] // RVA: 0x164020 Offset: 0x164121 VA: 0x164020
	public int NextStep; // 0x24
	[KeyAttribute] // RVA: 0x164070 Offset: 0x164171 VA: 0x164070
	[SerializeField] // RVA: 0x164070 Offset: 0x164171 VA: 0x164070
	public NpcEventType CurrentNpcEventType; // 0x28
	[KeyAttribute] // RVA: 0x1640C0 Offset: 0x1641C1 VA: 0x1640C0
	[SerializeField] // RVA: 0x1640C0 Offset: 0x1641C1 VA: 0x1640C0
	public string CurrentNpcEventPath; // 0x30
	[KeyAttribute] // RVA: 0x164110 Offset: 0x164211 VA: 0x164110
	[SerializeField] // RVA: 0x164110 Offset: 0x164211 VA: 0x164110
	public int CurrentTargetEventStep; // 0x38
	[KeyAttribute] // RVA: 0x164160 Offset: 0x164261 VA: 0x164160
	[SerializeField] // RVA: 0x164160 Offset: 0x164261 VA: 0x164160
	public List<SubEventStep> SubEventSteps; // 0x40

	// Methods

	// RVA: 0x203B480 Offset: 0x203B581 VA: 0x203B480
	public void InitParam(bool _orderInit = True) { }

	// RVA: 0x203B500 Offset: 0x203B601 VA: 0x203B500
	public void InitOrderParam() { }

	// RVA: 0x203B510 Offset: 0x203B611 VA: 0x203B510
	public void SetCurrentStep(int currentStep) { }

	// RVA: 0x203B520 Offset: 0x203B621 VA: 0x203B520
	public void SetCurrentReservedStep(int currentReservedStep) { }

	// RVA: 0x203B530 Offset: 0x203B631 VA: 0x203B530
	public void SetNextStep(int nextStep) { }

	// RVA: 0x203B540 Offset: 0x203B641 VA: 0x203B540
	public void SetNpcEventType(NpcEventType type) { }

	// RVA: 0x203B550 Offset: 0x203B651 VA: 0x203B550
	public void SetNpcEventPath(string path) { }

	// RVA: 0x203B640 Offset: 0x203B741 VA: 0x203B640
	public int GetCurrentStep() { }

	// RVA: 0x203B650 Offset: 0x203B751 VA: 0x203B650
	public int GetCurrentReservedStep() { }

	// RVA: 0x203B660 Offset: 0x203B761 VA: 0x203B660
	public int GetNextStep() { }

	// RVA: 0x203B670 Offset: 0x203B771 VA: 0x203B670
	public NpcEventType GetNpcEventType() { }

	// RVA: 0x203B680 Offset: 0x203B781 VA: 0x203B680
	public string GetNpcEventPath() { }

	// RVA: 0x203B690 Offset: 0x203B791 VA: 0x203B690
	public void AddCurrentReservedStep() { }

	// RVA: 0x203B6A0 Offset: 0x203B7A1 VA: 0x203B6A0
	public void .ctor() { }
}

