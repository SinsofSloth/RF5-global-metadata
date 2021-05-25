public static class Account // TypeDefIndex: 11711
{
	// Fields
	public const int UserCountMax = 8;
	public const int ProfileImageBytesMax = 131072;
	public const int SaveDataThumbnailImageBytesMax = 147456;

	// Properties
	public static ErrorRange ResultCancelled { get; }
	public static ErrorRange ResultCancelledByUser { get; }
	public static ErrorRange ResultUserNotExist { get; }

	// Methods

	// RVA: 0x26A3FF0 Offset: 0x26A40F1 VA: 0x26A3FF0
	public static extern Result GetUserCount(ref int pOutCount) { }

	// RVA: 0x26A4010 Offset: 0x26A4111 VA: 0x26A4010
	public static extern Result GetUserExistence(ref bool pOutExistence, Uid user) { }

	// RVA: 0x26A4030 Offset: 0x26A4131 VA: 0x26A4030
	public static Result ListAllUsers(ref int pOutActualLength, Uid[] outUsers) { }

	// RVA: 0x26A40E0 Offset: 0x26A41E1 VA: 0x26A40E0
	private static extern Result ListAllUsers(ref int pOutActualLength, [Out] Uid[] outUsers, int arrayLength) { }

	// RVA: 0x26A41B0 Offset: 0x26A42B1 VA: 0x26A41B0
	public static Result ListOpenUsers(ref int pOutActualLength, Uid[] outUsers) { }

	// RVA: 0x26A4260 Offset: 0x26A4361 VA: 0x26A4260
	private static extern Result ListOpenUsers(ref int pOutActualLength, [Out] Uid[] outUsers, int arrayLength) { }

	// RVA: 0x26A4330 Offset: 0x26A4431 VA: 0x26A4330
	public static extern Result GetLastOpenedUser(ref Uid pOutUser) { }

	// RVA: 0x26A4350 Offset: 0x26A4451 VA: 0x26A4350
	public static extern Result GetNickname(ref Nickname pOut, Uid user) { }

	// RVA: 0x26A43F0 Offset: 0x26A44F1 VA: 0x26A43F0
	public static Result LoadProfileImage(ref long pOutActualSize, byte[] outImage, Uid user) { }

	// RVA: 0x26A4420 Offset: 0x26A4521 VA: 0x26A4420
	private static extern Result LoadProfileImage(ref long pOutActualSize, byte[] outImage, long bufferSize, Uid user) { }

	// RVA: 0x26A4450 Offset: 0x26A4551 VA: 0x26A4450
	public static extern void Initialize() { }

	// RVA: 0x26A4460 Offset: 0x26A4561 VA: 0x26A4460
	public static extern Result OpenUser(ref UserHandle pOutHandle, Uid user) { }

	// RVA: 0x26A4480 Offset: 0x26A4581 VA: 0x26A4480
	public static extern bool TryOpenPreselectedUser(ref UserHandle pOutHandle) { }

	// RVA: 0x26A44A0 Offset: 0x26A45A1 VA: 0x26A44A0
	public static extern Result ListQualifiedUsers(ref int pOutActualLength, Uid[] outUsers, int arrayLength) { }

	// RVA: 0x26A44D0 Offset: 0x26A45D1 VA: 0x26A44D0
	public static extern void CloseUser(UserHandle handle) { }

	// RVA: 0x26A4500 Offset: 0x26A4601 VA: 0x26A4500
	public static extern Result GetUserId(ref Uid pOut, UserHandle handle) { }

	// RVA: 0x26A4540 Offset: 0x26A4641 VA: 0x26A4540
	public static Result StoreSaveDataThumbnailImage(Uid user, byte[] imageBuffer) { }

	// RVA: 0x26A4570 Offset: 0x26A4671 VA: 0x26A4570
	private static extern Result StoreSaveDataThumbnailImage(Uid user, byte[] imageBuffer, long imageBufferSize) { }

	// RVA: 0x26A45A0 Offset: 0x26A46A1 VA: 0x26A45A0
	public static extern Result DeleteSaveDataThumbnailImage(Uid user) { }

	// RVA: 0x26A45C0 Offset: 0x26A46C1 VA: 0x26A45C0
	public static ErrorRange get_ResultCancelled() { }

	// RVA: 0x26A45D0 Offset: 0x26A46D1 VA: 0x26A45D0
	public static ErrorRange get_ResultCancelledByUser() { }

	// RVA: 0x26A45E0 Offset: 0x26A46E1 VA: 0x26A45E0
	public static ErrorRange get_ResultUserNotExist() { }

	// RVA: 0x26A45F0 Offset: 0x26A46F1 VA: 0x26A45F0
	public static extern Result ShowUserSelector(ref Uid pOut, UserSelectionSettings arg) { }

	// RVA: 0x26A4630 Offset: 0x26A4731 VA: 0x26A4630
	public static extern Result ShowUserSelector(ref Uid pOut) { }

	// RVA: 0x26A4650 Offset: 0x26A4751 VA: 0x26A4650
	public static extern Result ShowUserCreator() { }

	// RVA: 0x26A4670 Offset: 0x26A4771 VA: 0x26A4670
	public static Result ShowUserSelector(ref Uid pOut, UserSelectionSettings arg, bool suspendUnityThreads) { }

	// RVA: 0x26A4700 Offset: 0x26A4801 VA: 0x26A4700
	public static Result ShowUserSelector(ref Uid pOut, bool suspendUnityThreads) { }

	// RVA: 0x26A4760 Offset: 0x26A4861 VA: 0x26A4760
	public static Result ShowUserCreator(bool suspendUnityThreads) { }
}

