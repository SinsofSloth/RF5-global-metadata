public class AddressablesImpl.ResourceLocatorInfo // TypeDefIndex: 5673
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13DCA0 Offset: 0x13DDA1 VA: 0x13DCA0
	private IResourceLocator <Locator>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x13DCB0 Offset: 0x13DDB1 VA: 0x13DCB0
	private string <LocalHash>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x13DCC0 Offset: 0x13DDC1 VA: 0x13DCC0
	private IResourceLocation <CatalogLocation>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x13DCD0 Offset: 0x13DDD1 VA: 0x13DCD0
	private bool <ContentUpdateAvailable>k__BackingField; // 0x28

	// Properties
	public IResourceLocator Locator { get; set; }
	public string LocalHash { get; set; }
	public IResourceLocation CatalogLocation { get; set; }
	public bool ContentUpdateAvailable { get; set; }
	public IResourceLocation HashLocation { get; }
	public bool CanUpdateContent { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x13E8F0 Offset: 0x13E9F1 VA: 0x13E8F0
	// RVA: 0x15E32F0 Offset: 0x15E33F1 VA: 0x15E32F0
	public IResourceLocator get_Locator() { }

	[CompilerGeneratedAttribute] // RVA: 0x13E900 Offset: 0x13EA01 VA: 0x13E900
	// RVA: 0x15E3300 Offset: 0x15E3401 VA: 0x15E3300
	private void set_Locator(IResourceLocator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E910 Offset: 0x13EA11 VA: 0x13E910
	// RVA: 0x15E3310 Offset: 0x15E3411 VA: 0x15E3310
	public string get_LocalHash() { }

	[CompilerGeneratedAttribute] // RVA: 0x13E920 Offset: 0x13EA21 VA: 0x13E920
	// RVA: 0x15E3320 Offset: 0x15E3421 VA: 0x15E3320
	private void set_LocalHash(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E930 Offset: 0x13EA31 VA: 0x13E930
	// RVA: 0x15E3330 Offset: 0x15E3431 VA: 0x15E3330
	public IResourceLocation get_CatalogLocation() { }

	[CompilerGeneratedAttribute] // RVA: 0x13E940 Offset: 0x13EA41 VA: 0x13E940
	// RVA: 0x15E3340 Offset: 0x15E3441 VA: 0x15E3340
	private void set_CatalogLocation(IResourceLocation value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13E950 Offset: 0x13EA51 VA: 0x13E950
	// RVA: 0x15E3350 Offset: 0x15E3451 VA: 0x15E3350
	public bool get_ContentUpdateAvailable() { }

	[CompilerGeneratedAttribute] // RVA: 0x13E960 Offset: 0x13EA61 VA: 0x13E960
	// RVA: 0x15E3360 Offset: 0x15E3461 VA: 0x15E3360
	internal void set_ContentUpdateAvailable(bool value) { }

	// RVA: 0x15DB540 Offset: 0x15DB641 VA: 0x15DB540
	public void .ctor(IResourceLocator loc, string localHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x15E3370 Offset: 0x15E3471 VA: 0x15E3370
	public IResourceLocation get_HashLocation() { }

	// RVA: 0x15E34B0 Offset: 0x15E35B1 VA: 0x15E34B0
	public bool get_CanUpdateContent() { }

	// RVA: 0x15E36C0 Offset: 0x15E37C1 VA: 0x15E36C0
	internal void UpdateContent(IResourceLocator locator, string hash, IResourceLocation loc) { }
}

