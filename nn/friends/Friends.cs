public static class Friends // TypeDefIndex: 11669
{
	// Fields
	public const int FriendCountMax = 300;
	public const int BlockedUserCountMax = 100;
	public const long PresenceAppFieldSize = 192;
	public const int InAppScreenNameLengthMax = 20;
	public const int GetProfileCountMax = 100;
	public const long ProfileImageSizeMax = 131072;
	public const int NotificationCountMax = 100;
	public const int FriendInvitationInviteeCountMax = 16;
	public const long FriendInvitationApplicationParameterSizeMax = 1024;

	// Properties
	public static ErrorRange ResultNotInitialized { get; }
	public static ErrorRange ResultInvalidArgument { get; }
	public static ErrorRange ResultUserNotOpened { get; }
	public static ErrorRange ResultNetworkServiceAccountNotLinked { get; }
	public static ErrorRange ResultOwnNetworkServiceAccountSpecified { get; }
	public static ErrorRange ResultInternetRequestNotAccepted { get; }
	public static ErrorRange ResultNotCalled { get; }
	public static ErrorRange ResultCallInProgress { get; }
	public static ErrorRange ResultCanceled { get; }
	public static ErrorRange ResultProfileImageCacheNotFound { get; }
	public static ErrorRange ResultOutOfMemory { get; }
	public static ErrorRange ResultOutOfResource { get; }
	public static ErrorRange ResultReservedKey { get; }
	public static ErrorRange ResultDuplicatedKey { get; }
	public static ErrorRange ResultNotificationNotFound { get; }
	public static ErrorRange ResultPlayHistoryRegistrationKeyBroken { get; }
	public static ErrorRange ResultOwnPlayHistoryRegistrationKey { get; }
	public static ErrorRange ResultAppletCanceled { get; }
	public static ErrorRange ResultApplicationInfoNotRegistered { get; }
	public static ErrorRange ResultNotPermitted { get; }
	public static ErrorRange ResultInvalidOperation { get; }
	public static ErrorRange ResultNotImplemented { get; }
	public static ErrorRange ResultResponseFormatError { get; }
	public static ErrorRange ResultHttpError { get; }
	public static ErrorRange ResultServerError { get; }

	// Methods

	// RVA: 0x26AB090 Offset: 0x26AB191 VA: 0x26AB090
	public static extern void Initialize() { }

	// RVA: 0x26AB0A0 Offset: 0x26AB1A1 VA: 0x26AB0A0
	public static Result GetFriendList(ref int outCount, NetworkServiceAccountId[] outAccountIds, Uid uid, int offset, FriendFilter filter) { }

	// RVA: 0x26AB0D0 Offset: 0x26AB1D1 VA: 0x26AB0D0
	private static extern Result GetFriendList(ref int outCount, [In] [Out] NetworkServiceAccountId[] outAccountIds, Uid uid, int offset, int count, FriendFilter filter) { }

	// RVA: 0x26AB100 Offset: 0x26AB201 VA: 0x26AB100
	public static Result GetFriendList(ref int outCount, NetworkServiceAccountId[] outAccountIds, int offset, FriendFilter filter) { }

	// RVA: 0x26AB130 Offset: 0x26AB231 VA: 0x26AB130
	private static extern Result GetFriendList(ref int outCount, [In] [Out] NetworkServiceAccountId[] outAccountIds, int offset, int count, FriendFilter filter) { }

	// RVA: 0x26AB160 Offset: 0x26AB261 VA: 0x26AB160
	public static Result GetFriendList(ref int outCount, Friend[] outFriends, Uid uid, int offset, FriendFilter filter) { }

	// RVA: 0x26AB190 Offset: 0x26AB291 VA: 0x26AB190
	private static extern Result GetFriendList(ref int outCount, [In] [Out] Friend[] outFriends, Uid uid, int offset, int count, FriendFilter filter) { }

	// RVA: 0x26AB1C0 Offset: 0x26AB2C1 VA: 0x26AB1C0
	public static Result GetFriendList(ref int outCount, Friend[] outFriends, int offset, FriendFilter filter) { }

	// RVA: 0x26AB1F0 Offset: 0x26AB2F1 VA: 0x26AB1F0
	private static extern Result GetFriendList(ref int outCount, [In] [Out] Friend[] outFriends, int offset, int count, FriendFilter filter) { }

	// RVA: 0x26AB220 Offset: 0x26AB321 VA: 0x26AB220
	public static Result UpdateFriendInfo(Friend[] outFriends, Uid uid, NetworkServiceAccountId[] accountIds) { }

	// RVA: 0x26AB260 Offset: 0x26AB361 VA: 0x26AB260
	private static extern Result UpdateFriendInfo([In] [Out] Friend[] outFriends, Uid uid, [In] NetworkServiceAccountId[] accountIds, int count) { }

	// RVA: 0x26AB290 Offset: 0x26AB391 VA: 0x26AB290
	public static Result UpdateFriendInfo(Friend[] outFriends, NetworkServiceAccountId[] accountIds) { }

	// RVA: 0x26AB2D0 Offset: 0x26AB3D1 VA: 0x26AB2D0
	private static extern Result UpdateFriendInfo([In] [Out] Friend[] outFriends, NetworkServiceAccountId[] accountIds, int count) { }

	// RVA: 0x26AB300 Offset: 0x26AB401 VA: 0x26AB300
	public static Result EnsureFriendListAvailable(AsyncContext outAsync, Uid uid) { }

	// RVA: 0x26AB330 Offset: 0x26AB431 VA: 0x26AB330
	private static extern Result EnsureFriendListAvailable(IntPtr outAsync, Uid uid) { }

	// RVA: 0x26AB350 Offset: 0x26AB451 VA: 0x26AB350
	public static Result EnsureFriendListAvailable(AsyncContext outAsync) { }

	// RVA: 0x26AB380 Offset: 0x26AB481 VA: 0x26AB380
	private static extern Result EnsureFriendListAvailable(IntPtr outAsync) { }

	// RVA: 0x26AB3A0 Offset: 0x26AB4A1 VA: 0x26AB3A0
	public static Result GetBlockedUserList(ref int outCount, NetworkServiceAccountId[] outAccountIds, Uid uid, int offset) { }

	// RVA: 0x26AB3D0 Offset: 0x26AB4D1 VA: 0x26AB3D0
	private static extern Result GetBlockedUserList(ref int outCount, [In] [Out] NetworkServiceAccountId[] outAccountIds, Uid uid, int offset, int count) { }

	// RVA: 0x26AB400 Offset: 0x26AB501 VA: 0x26AB400
	public static Result GetBlockedUserList(ref int outCount, NetworkServiceAccountId[] outAccountIds, int offset) { }

	// RVA: 0x26AB430 Offset: 0x26AB531 VA: 0x26AB430
	private static extern Result GetBlockedUserList(ref int outCount, [In] [Out] NetworkServiceAccountId[] outAccountIds, int offset, int count) { }

	// RVA: 0x26AB460 Offset: 0x26AB561 VA: 0x26AB460
	public static Result GetProfileList(AsyncContext outAsync, Profile[] outProfiles, Uid uid, NetworkServiceAccountId[] accountIds) { }

	// RVA: 0x26AB4D0 Offset: 0x26AB5D1 VA: 0x26AB4D0
	public static Result EnsureBlockedUserListAvailable(AsyncContext outAsync, Uid uid) { }

	// RVA: 0x26AB500 Offset: 0x26AB601 VA: 0x26AB500
	private static extern Result EnsureBlockedUserListAvailable(IntPtr outAsync, Uid uid) { }

	// RVA: 0x26AB520 Offset: 0x26AB621 VA: 0x26AB520
	public static Result EnsureBlockedUserListAvailable(AsyncContext outAsync) { }

	// RVA: 0x26AB550 Offset: 0x26AB651 VA: 0x26AB550
	private static extern Result EnsureBlockedUserListAvailable(IntPtr outAsync) { }

	// RVA: 0x26AB4A0 Offset: 0x26AB5A1 VA: 0x26AB4A0
	private static extern Result GetProfileList(IntPtr outAsync, [In] [Out] Profile[] outProfiles, Uid uid, [In] NetworkServiceAccountId[] accountIds, int count) { }

	// RVA: 0x26AB570 Offset: 0x26AB671 VA: 0x26AB570
	public static Result GetProfileList(AsyncContext outAsync, Profile[] outProfiles, NetworkServiceAccountId[] accountIds) { }

	// RVA: 0x26AB5B0 Offset: 0x26AB6B1 VA: 0x26AB5B0
	private static extern Result GetProfileList(IntPtr outAsync, [In] [Out] Profile[] outProfiles, [In] NetworkServiceAccountId[] accountIds, int count) { }

	// RVA: 0x26AB5E0 Offset: 0x26AB6E1 VA: 0x26AB5E0
	public static extern Result DeclareOpenOnlinePlaySession(Uid uid) { }

	// RVA: 0x26AB600 Offset: 0x26AB701 VA: 0x26AB600
	public static extern Result DeclareOpenOnlinePlaySession() { }

	// RVA: 0x26AB620 Offset: 0x26AB721 VA: 0x26AB620
	public static extern Result DeclareCloseOnlinePlaySession(Uid uid) { }

	// RVA: 0x26AB640 Offset: 0x26AB741 VA: 0x26AB640
	public static extern Result DeclareCloseOnlinePlaySession() { }

	// RVA: 0x26AB660 Offset: 0x26AB761 VA: 0x26AB660
	public static extern Result GetPlayHistoryRegistrationKey(ref PlayHistoryRegistrationKey outKey, Uid uid, bool isLocalPlay) { }

	// RVA: 0x26AB680 Offset: 0x26AB781 VA: 0x26AB680
	public static extern Result GetPlayHistoryRegistrationKey(ref PlayHistoryRegistrationKey outKey, bool isLocalPlay) { }

	// RVA: 0x26AB6A0 Offset: 0x26AB7A1 VA: 0x26AB6A0
	public static extern Result AddPlayHistory(Uid uid, PlayHistoryRegistrationKey key, InAppScreenName inAppScreenName, InAppScreenName myInAppScreenName) { }

	// RVA: 0x26AB7B0 Offset: 0x26AB8B1 VA: 0x26AB7B0
	public static extern Result AddPlayHistory(PlayHistoryRegistrationKey key, InAppScreenName inAppScreenName, InAppScreenName myInAppScreenName) { }

	// RVA: 0x26AB8A0 Offset: 0x26AB9A1 VA: 0x26AB8A0
	public static bool TryPopFriendInvitationNotificationInfo(ref Uid pOutUid, ref long pOutSize, byte[] pOutBuffer) { }

	// RVA: 0x26AB8D0 Offset: 0x26AB9D1 VA: 0x26AB8D0
	private static extern bool TryPopFriendInvitationNotificationInfo(ref Uid pOutUid, ref long pOutSize, [In] [Out] byte[] pOutBuffer, long bufferSize) { }

	// RVA: 0x26AB900 Offset: 0x26ABA01 VA: 0x26AB900
	public static extern Result ShowFriendList(Uid uid) { }

	// RVA: 0x26AB920 Offset: 0x26ABA21 VA: 0x26AB920
	public static extern Result ShowUserDetailInfo(Uid uid, NetworkServiceAccountId accountId, InAppScreenName myInAppScreenName, InAppScreenName inAppScreenName) { }

	// RVA: 0x26ABA10 Offset: 0x26ABB11 VA: 0x26ABA10
	public static extern Result StartSendingFriendRequest(Uid uid, NetworkServiceAccountId accountId, InAppScreenName myInAppScreenName, InAppScreenName inAppScreenName) { }

	// RVA: 0x26ABB00 Offset: 0x26ABC01 VA: 0x26ABB00
	public static extern Result ShowMethodsOfSendingFriendRequest(Uid uid) { }

	// RVA: 0x26ABB20 Offset: 0x26ABC21 VA: 0x26ABB20
	public static extern Result StartFacedFriendRequest(Uid uid) { }

	// RVA: 0x26ABB40 Offset: 0x26ABC41 VA: 0x26ABB40
	public static extern Result ShowReceivedFriendRequestList(Uid uid) { }

	// RVA: 0x26ABB60 Offset: 0x26ABC61 VA: 0x26ABB60
	public static extern Result ShowBlockedUserList(Uid uid) { }

	// RVA: 0x26ABB80 Offset: 0x26ABC81 VA: 0x26ABB80
	public static Result StartFriendInvitation(Uid uid, int maxInviteeCount, FriendInvitationGameModeDescription description, byte[] pAppParameter) { }

	// RVA: 0x26ABC90 Offset: 0x26ABD91 VA: 0x26ABC90
	private static extern Result StartFriendInvitation(Uid uid, int maxInviteeCount, FriendInvitationGameModeDescription description, [In] byte[] pAppParameter, long appParameterSize) { }

	// RVA: 0x26ABDA0 Offset: 0x26ABEA1 VA: 0x26ABDA0
	public static Result StartSendingFriendInvitation(Uid uid, NetworkServiceAccountId[] pInvitees, FriendInvitationGameModeDescription description, byte[] pAppParameter) { }

	// RVA: 0x26ABEC0 Offset: 0x26ABFC1 VA: 0x26ABEC0
	private static extern Result StartSendingFriendInvitation(Uid uid, [In] NetworkServiceAccountId[] pInvitees, int inviteeCount, FriendInvitationGameModeDescription description, [In] byte[] pAppParameter, long appParameterSize) { }

	// RVA: 0x26ABFE0 Offset: 0x26AC0E1 VA: 0x26ABFE0
	public static ErrorRange get_ResultNotInitialized() { }

	// RVA: 0x26ABFF0 Offset: 0x26AC0F1 VA: 0x26ABFF0
	public static ErrorRange get_ResultInvalidArgument() { }

	// RVA: 0x26AC000 Offset: 0x26AC101 VA: 0x26AC000
	public static ErrorRange get_ResultUserNotOpened() { }

	// RVA: 0x26AC010 Offset: 0x26AC111 VA: 0x26AC010
	public static ErrorRange get_ResultNetworkServiceAccountNotLinked() { }

	// RVA: 0x26AC020 Offset: 0x26AC121 VA: 0x26AC020
	public static ErrorRange get_ResultOwnNetworkServiceAccountSpecified() { }

	// RVA: 0x26AC030 Offset: 0x26AC131 VA: 0x26AC030
	public static ErrorRange get_ResultInternetRequestNotAccepted() { }

	// RVA: 0x26AC040 Offset: 0x26AC141 VA: 0x26AC040
	public static ErrorRange get_ResultNotCalled() { }

	// RVA: 0x26AC050 Offset: 0x26AC151 VA: 0x26AC050
	public static ErrorRange get_ResultCallInProgress() { }

	// RVA: 0x26AC060 Offset: 0x26AC161 VA: 0x26AC060
	public static ErrorRange get_ResultCanceled() { }

	// RVA: 0x26AC070 Offset: 0x26AC171 VA: 0x26AC070
	public static ErrorRange get_ResultProfileImageCacheNotFound() { }

	// RVA: 0x26AC080 Offset: 0x26AC181 VA: 0x26AC080
	public static ErrorRange get_ResultOutOfMemory() { }

	// RVA: 0x26AC090 Offset: 0x26AC191 VA: 0x26AC090
	public static ErrorRange get_ResultOutOfResource() { }

	// RVA: 0x26AC0A0 Offset: 0x26AC1A1 VA: 0x26AC0A0
	public static ErrorRange get_ResultReservedKey() { }

	// RVA: 0x26AC0B0 Offset: 0x26AC1B1 VA: 0x26AC0B0
	public static ErrorRange get_ResultDuplicatedKey() { }

	// RVA: 0x26AC0C0 Offset: 0x26AC1C1 VA: 0x26AC0C0
	public static ErrorRange get_ResultNotificationNotFound() { }

	// RVA: 0x26AC0D0 Offset: 0x26AC1D1 VA: 0x26AC0D0
	public static ErrorRange get_ResultPlayHistoryRegistrationKeyBroken() { }

	// RVA: 0x26AC0E0 Offset: 0x26AC1E1 VA: 0x26AC0E0
	public static ErrorRange get_ResultOwnPlayHistoryRegistrationKey() { }

	// RVA: 0x26AC0F0 Offset: 0x26AC1F1 VA: 0x26AC0F0
	public static ErrorRange get_ResultAppletCanceled() { }

	// RVA: 0x26AC100 Offset: 0x26AC201 VA: 0x26AC100
	public static ErrorRange get_ResultApplicationInfoNotRegistered() { }

	// RVA: 0x26AC110 Offset: 0x26AC211 VA: 0x26AC110
	public static ErrorRange get_ResultNotPermitted() { }

	// RVA: 0x26AC120 Offset: 0x26AC221 VA: 0x26AC120
	public static ErrorRange get_ResultInvalidOperation() { }

	// RVA: 0x26AC130 Offset: 0x26AC231 VA: 0x26AC130
	public static ErrorRange get_ResultNotImplemented() { }

	// RVA: 0x26AC140 Offset: 0x26AC241 VA: 0x26AC140
	public static ErrorRange get_ResultResponseFormatError() { }

	// RVA: 0x26AC150 Offset: 0x26AC251 VA: 0x26AC150
	public static ErrorRange get_ResultHttpError() { }

	// RVA: 0x26AC160 Offset: 0x26AC261 VA: 0x26AC160
	public static ErrorRange get_ResultServerError() { }
}

