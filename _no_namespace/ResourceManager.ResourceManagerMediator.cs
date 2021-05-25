internal class ResourceManager.ResourceManagerMediator // TypeDefIndex: 503
{
	// Fields
	private ResourceManager _rm; // 0x10

	// Properties
	internal string ModuleDir { get; }
	internal Type LocationInfo { get; }
	internal Type UserResourceSet { get; }
	internal string BaseNameField { get; }
	internal CultureInfo NeutralResourcesCulture { get; }
	internal bool LookedForSatelliteContractVersion { get; set; }
	internal Version SatelliteContractVersion { get; set; }
	internal UltimateResourceFallbackLocation FallbackLoc { get; }
	internal RuntimeAssembly CallingAssembly { get; }
	internal RuntimeAssembly MainAssembly { get; }
	internal string BaseName { get; }

	// Methods

	// RVA: 0x17F82F0 Offset: 0x17F83F1 VA: 0x17F82F0
	internal void .ctor(ResourceManager rm) { }

	// RVA: 0x17F4D70 Offset: 0x17F4E71 VA: 0x17F4D70
	internal string get_ModuleDir() { }

	// RVA: 0x17F4A30 Offset: 0x17F4B31 VA: 0x17F4A30
	internal Type get_LocationInfo() { }

	// RVA: 0x17F4D90 Offset: 0x17F4E91 VA: 0x17F4D90
	internal Type get_UserResourceSet() { }

	// RVA: 0x17F4A10 Offset: 0x17F4B11 VA: 0x17F4A10
	internal string get_BaseNameField() { }

	// RVA: 0x17F69D0 Offset: 0x17F6AD1 VA: 0x17F69D0
	internal CultureInfo get_NeutralResourcesCulture() { }

	// RVA: 0x17F4920 Offset: 0x17F4A21 VA: 0x17F4920
	internal string GetResourceFileName(CultureInfo culture) { }

	// RVA: 0x17F7500 Offset: 0x17F7601 VA: 0x17F7500
	internal bool get_LookedForSatelliteContractVersion() { }

	// RVA: 0x17F75C0 Offset: 0x17F76C1 VA: 0x17F75C0
	internal void set_LookedForSatelliteContractVersion(bool value) { }

	// RVA: 0x17F76B0 Offset: 0x17F77B1 VA: 0x17F76B0
	internal Version get_SatelliteContractVersion() { }

	// RVA: 0x17F75A0 Offset: 0x17F76A1 VA: 0x17F75A0
	internal void set_SatelliteContractVersion(Version value) { }

	// RVA: 0x17F7520 Offset: 0x17F7621 VA: 0x17F7520
	internal Version ObtainSatelliteContractVersion(Assembly a) { }

	// RVA: 0x17F5330 Offset: 0x17F5431 VA: 0x17F5330
	internal UltimateResourceFallbackLocation get_FallbackLoc() { }

	// RVA: 0x17F7080 Offset: 0x17F7181 VA: 0x17F7080
	internal RuntimeAssembly get_CallingAssembly() { }

	// RVA: 0x17F5350 Offset: 0x17F5451 VA: 0x17F5350
	internal RuntimeAssembly get_MainAssembly() { }

	// RVA: 0x17F7990 Offset: 0x17F7A91 VA: 0x17F7990
	internal string get_BaseName() { }
}

