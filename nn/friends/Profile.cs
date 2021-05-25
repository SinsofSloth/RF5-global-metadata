public struct Profile // TypeDefIndex: 11675
{
	// Methods

	// RVA: 0x363830 Offset: 0x363931 VA: 0x363830
	public NetworkServiceAccountId GetAccountId() { }

	// RVA: 0x363870 Offset: 0x363971 VA: 0x363870
	public Nickname GetNickname() { }

	// RVA: 0x3638D0 Offset: 0x3639D1 VA: 0x3638D0
	public Result GetProfileImageUrl(ref string outUrl, ImageSize imageSize) { }

	// RVA: 0x3638F0 Offset: 0x3639F1 VA: 0x3638F0
	public bool IsValid() { }

	// RVA: 0x26ACCC0 Offset: 0x26ACDC1 VA: 0x26ACCC0
	private static extern NetworkServiceAccountId GetAccountId(Profile profile) { }

	// RVA: 0x26ACD60 Offset: 0x26ACE61 VA: 0x26ACD60
	private static extern Nickname GetNickname(Profile profile) { }

	// RVA: 0x26ACED0 Offset: 0x26ACFD1 VA: 0x26ACED0
	private static extern Result GetProfileImageUrl(Profile profile, [In] [Out] StringBuilder outUrl, ImageSize imageSize) { }

	// RVA: 0x26ACFA0 Offset: 0x26AD0A1 VA: 0x26ACFA0
	private static extern bool IsValid(Profile profile) { }
}

