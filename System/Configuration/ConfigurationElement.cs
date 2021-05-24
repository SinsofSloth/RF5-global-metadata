[DefaultMemberAttribute] // RVA: 0xBA890 Offset: 0xBA991 VA: 0xBA890
public abstract class ConfigurationElement // TypeDefIndex: 1538
{
	// Properties
	protected internal virtual ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1BE1F20 Offset: 0x1BE2021 VA: 0x1BE1F20 Slot: 4
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x1BE1F60 Offset: 0x1BE2061 VA: 0x1BE1F60 Slot: 5
	protected internal virtual bool IsModified() { }

	// RVA: 0x1BE1FA0 Offset: 0x1BE20A1 VA: 0x1BE1FA0 Slot: 6
	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	// RVA: 0x1BE1FE0 Offset: 0x1BE20E1 VA: 0x1BE1FE0 Slot: 7
	protected internal virtual void ResetModified() { }
}

