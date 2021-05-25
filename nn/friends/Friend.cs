public struct Friend // TypeDefIndex: 11671
{
	// Methods

	// RVA: 0x362590 Offset: 0x362691 VA: 0x362590
	public NetworkServiceAccountId GetAccountId() { }

	// RVA: 0x3625D0 Offset: 0x3626D1 VA: 0x3625D0
	public Nickname GetNickname() { }

	// RVA: 0x362630 Offset: 0x362731 VA: 0x362630
	public FriendPresence GetPresence() { }

	// RVA: 0x3626C0 Offset: 0x3627C1 VA: 0x3626C0
	public Result GetProfileImage(ref long outSize, byte[] buffer) { }

	// RVA: 0x362740 Offset: 0x362841 VA: 0x362740
	public bool IsFavorite() { }

	// RVA: 0x362780 Offset: 0x362881 VA: 0x362780
	public bool IsNewly() { }

	// RVA: 0x3627C0 Offset: 0x3628C1 VA: 0x3627C0
	public bool IsValid() { }

	// RVA: 0x362800 Offset: 0x362901 VA: 0x362800
	public Result Update() { }

	// RVA: 0x26A9B20 Offset: 0x26A9C21 VA: 0x26A9B20
	private static extern NetworkServiceAccountId GetAccountId(Friend friend) { }

	// RVA: 0x26A9BC0 Offset: 0x26A9CC1 VA: 0x26A9BC0
	private static extern Nickname GetNickname(Friend friend) { }

	// RVA: 0x26A9CB0 Offset: 0x26A9DB1 VA: 0x26A9CB0
	private static extern void GetPresence(Friend friend, ref FriendPresence outPresence) { }

	// RVA: 0x26A9D70 Offset: 0x26A9E71 VA: 0x26A9D70
	private static extern Result GetProfileImage(Friend friend, ref long outSize, [In] [Out] byte[] outBuffer, long size) { }

	// RVA: 0x26A9E20 Offset: 0x26A9F21 VA: 0x26A9E20
	private static extern bool IsFavorite(Friend friend) { }

	// RVA: 0x26A9EA0 Offset: 0x26A9FA1 VA: 0x26A9EA0
	private static extern bool IsNewly(Friend friend) { }

	// RVA: 0x26A9F20 Offset: 0x26AA021 VA: 0x26A9F20
	private static extern bool IsValid(Friend friend) { }

	// RVA: 0x26A9F80 Offset: 0x26AA081 VA: 0x26A9F80
	private static extern Result Update(ref Friend pFriend) { }
}

