public interface ISystemInformationService // TypeDefIndex: 5624
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<string> GetCategories() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IList<InfoEntry> GetInfo(string category) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Add(InfoEntry info, string category = "Default") { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = False) { }
}

