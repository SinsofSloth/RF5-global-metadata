[FlagsAttribute] // RVA: 0xAFDB0 Offset: 0xAFEB1 VA: 0xAFDB0
[ComVisibleAttribute] // RVA: 0xAFDB0 Offset: 0xAFEB1 VA: 0xAFDB0
[Serializable]
public enum CspProviderFlags // TypeDefIndex: 920
{
	// Fields
	public int value__; // 0x0
	public const CspProviderFlags NoFlags = 0;
	public const CspProviderFlags UseMachineKeyStore = 1;
	public const CspProviderFlags UseDefaultKeyContainer = 2;
	public const CspProviderFlags UseNonExportableKey = 4;
	public const CspProviderFlags UseExistingKey = 8;
	public const CspProviderFlags UseArchivableKey = 16;
	public const CspProviderFlags UseUserProtectedKey = 32;
	public const CspProviderFlags NoPrompt = 64;
	public const CspProviderFlags CreateEphemeralKey = 128;
}

