public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 1537
{
	// Methods

	// RVA: 0x1BE2020 Offset: 0x1BE2121 VA: 0x1BE2020 Slot: 8
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x1BE2060 Offset: 0x1BE2161 VA: 0x1BE2060 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x1BE20A0 Offset: 0x1BE21A1 VA: 0x1BE20A0 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x1BE20E0 Offset: 0x1BE21E1 VA: 0x1BE20E0 Slot: 9
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }
}

