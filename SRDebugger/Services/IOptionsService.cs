public interface IOptionsService // TypeDefIndex: 5617
{
	// Properties
	public abstract ICollection<OptionDefinition> Options { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x13D080 Offset: 0x13D181 VA: 0x13D080
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_OptionsUpdated(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D090 Offset: 0x13D191 VA: 0x13D090
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_OptionsUpdated(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D0A0 Offset: 0x13D1A1 VA: 0x13D0A0
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_OptionsValueUpdated(EventHandler<PropertyChangedEventArgs> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D0B0 Offset: 0x13D1B1 VA: 0x13D0B0
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_OptionsValueUpdated(EventHandler<PropertyChangedEventArgs> value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ICollection<OptionDefinition> get_Options() { }

	[ObsoleteAttribute] // RVA: 0x13D0C0 Offset: 0x13D1C1 VA: 0x13D0C0
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Scan(object obj) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void AddContainer(object obj) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void RemoveContainer(object obj) { }
}

