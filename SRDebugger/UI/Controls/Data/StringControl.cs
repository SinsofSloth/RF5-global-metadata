public class StringControl : DataBoundControl // TypeDefIndex: 5604
{
	// Fields
	[RequiredFieldAttribute] // RVA: 0x13CA60 Offset: 0x13CB61 VA: 0x13CA60
	public InputField InputField; // 0x80
	[RequiredFieldAttribute] // RVA: 0x13CA70 Offset: 0x13CB71 VA: 0x13CA70
	public Text Title; // 0x88

	// Methods

	// RVA: 0x15465B0 Offset: 0x15466B1 VA: 0x15465B0 Slot: 5
	protected override void Start() { }

	// RVA: 0x1546680 Offset: 0x1546781 VA: 0x1546680
	private void OnValueChanged(string newValue) { }

	// RVA: 0x15466E0 Offset: 0x15467E1 VA: 0x15466E0 Slot: 12
	protected override void OnBind(string propertyName, Type t) { }

	// RVA: 0x1546780 Offset: 0x1546881 VA: 0x1546780 Slot: 13
	protected override void OnValueUpdated(object newValue) { }

	// RVA: 0x1546820 Offset: 0x1546921 VA: 0x1546820 Slot: 14
	public override bool CanBind(Type type, bool isReadOnly) { }

	// RVA: 0x15468C0 Offset: 0x15469C1 VA: 0x15468C0
	public void .ctor() { }
}

