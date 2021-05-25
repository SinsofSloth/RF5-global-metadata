[ServiceAttribute] // RVA: 0x13BB50 Offset: 0x13BC51 VA: 0x13BB50
public class StandardSystemInformationService : ISystemInformationService // TypeDefIndex: 5639
{
	// Fields
	private readonly Dictionary<string, IList<InfoEntry>> _info; // 0x10

	// Methods

	// RVA: 0x153F600 Offset: 0x153F701 VA: 0x153F600
	public void .ctor() { }

	// RVA: 0x1541420 Offset: 0x1541521 VA: 0x1541420 Slot: 4
	public IEnumerable<string> GetCategories() { }

	// RVA: 0x1541480 Offset: 0x1541581 VA: 0x1541480 Slot: 5
	public IList<InfoEntry> GetInfo(string category) { }

	// RVA: 0x15415D0 Offset: 0x15416D1 VA: 0x15415D0 Slot: 6
	public void Add(InfoEntry info, string category = "Default") { }

	// RVA: 0x1541800 Offset: 0x1541901 VA: 0x1541800 Slot: 7
	public Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = False) { }

	// RVA: 0x153F690 Offset: 0x153F791 VA: 0x153F690
	private void CreateDefaultSet() { }

	// RVA: 0x1541DE0 Offset: 0x1541EE1 VA: 0x1541DE0
	private static string GetCloudManifestPrettyName(string name) { }
}

