[ServiceAttribute] // RVA: 0x13B920 Offset: 0x13BA21 VA: 0x13B920
public class OptionsServiceImpl : IOptionsService // TypeDefIndex: 5633
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13CA90 Offset: 0x13CB91 VA: 0x13CA90
	private EventHandler OptionsUpdated; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x13CAA0 Offset: 0x13CBA1 VA: 0x13CAA0
	private EventHandler<PropertyChangedEventArgs> OptionsValueUpdated; // 0x18
	private readonly Dictionary<object, ICollection<OptionDefinition>> _optionContainerLookup; // 0x20
	private readonly List<OptionDefinition> _options; // 0x28
	private readonly IList<OptionDefinition> _optionsReadonly; // 0x30

	// Properties
	public ICollection<OptionDefinition> Options { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x13D280 Offset: 0x13D381 VA: 0x13D280
	// RVA: 0x1538790 Offset: 0x1538891 VA: 0x1538790 Slot: 4
	public void add_OptionsUpdated(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D290 Offset: 0x13D391 VA: 0x13D290
	// RVA: 0x1538840 Offset: 0x1538941 VA: 0x1538840 Slot: 5
	public void remove_OptionsUpdated(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D2A0 Offset: 0x13D3A1 VA: 0x13D2A0
	// RVA: 0x15388F0 Offset: 0x15389F1 VA: 0x15388F0 Slot: 6
	public void add_OptionsValueUpdated(EventHandler<PropertyChangedEventArgs> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D2B0 Offset: 0x13D3B1 VA: 0x13D2B0
	// RVA: 0x15389A0 Offset: 0x1538AA1 VA: 0x15389A0 Slot: 7
	public void remove_OptionsValueUpdated(EventHandler<PropertyChangedEventArgs> value) { }

	// RVA: 0x1538A50 Offset: 0x1538B51 VA: 0x1538A50 Slot: 8
	public ICollection<OptionDefinition> get_Options() { }

	// RVA: 0x1538A60 Offset: 0x1538B61 VA: 0x1538A60
	public void .ctor() { }

	// RVA: 0x1538B60 Offset: 0x1538C61 VA: 0x1538B60 Slot: 9
	public void Scan(object obj) { }

	// RVA: 0x1538B70 Offset: 0x1538C71 VA: 0x1538B70 Slot: 10
	public void AddContainer(object obj) { }

	// RVA: 0x1538EA0 Offset: 0x1538FA1 VA: 0x1538EA0 Slot: 11
	public void RemoveContainer(object obj) { }

	// RVA: 0x15392C0 Offset: 0x15393C1 VA: 0x15392C0
	private void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs) { }

	// RVA: 0x1538E00 Offset: 0x1538F01 VA: 0x1538E00
	private void OnOptionsUpdated() { }
}

