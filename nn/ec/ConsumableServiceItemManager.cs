public sealed class ConsumableServiceItemManager : IDisposable // TypeDefIndex: 11689
{
	// Fields
	private IntPtr _consumableServiceItemManager; // 0x10
	private IntPtr _workMemory; // 0x18
	private bool isDisposed; // 0x20

	// Methods

	// RVA: 0x26A7500 Offset: 0x26A7601 VA: 0x26A7500
	public void .ctor() { }

	// RVA: 0x26A7570 Offset: 0x26A7671 VA: 0x26A7570 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26A76E0 Offset: 0x26A77E1 VA: 0x26A76E0
	public Result Initialize(ShopServiceAccessor accessor, Uid user) { }

	// RVA: 0x26A7740 Offset: 0x26A7841 VA: 0x26A7740
	public Result Initialize(ShopServiceAccessor accessor, Uid user, byte[] buffer) { }

	// RVA: 0x26A77C0 Offset: 0x26A78C1 VA: 0x26A77C0
	public bool IsInitialized() { }

	// RVA: 0x26A7800 Offset: 0x26A7901 VA: 0x26A7800
	public bool CanQueryNewData() { }

	// RVA: 0x26A7840 Offset: 0x26A7941 VA: 0x26A7840
	public bool IsConsumptionRequired() { }

	// RVA: 0x26A7880 Offset: 0x26A7981 VA: 0x26A7880
	public bool IsRecoveryRequired() { }

	// RVA: 0x26A78C0 Offset: 0x26A79C1 VA: 0x26A78C0
	public void SetupAsyncRequest(AsyncGetConsumableRightDataRequest outRequest) { }

	// RVA: 0x26A7910 Offset: 0x26A7A11 VA: 0x26A7910
	public void SetupAsyncRequest(AsyncConsumeRightDataRequest outRequest) { }

	// RVA: 0x26A7960 Offset: 0x26A7A61 VA: 0x26A7960
	public void SetupAsyncRequest(AsyncRecoverRightDataRequest outRequest) { }

	// RVA: 0x26A79B0 Offset: 0x26A7AB1 VA: 0x26A79B0
	public long GetRequiredBufferSizeToExportSerializedRightData() { }

	// RVA: 0x26A79D0 Offset: 0x26A7AD1 VA: 0x26A79D0
	public long ExportSerializedRightData(byte[] buffer) { }

	// RVA: 0x26A7A00 Offset: 0x26A7B01 VA: 0x26A7A00
	public byte[] ExportSerializedRightData() { }

	// RVA: 0x26A7A90 Offset: 0x26A7B91 VA: 0x26A7A90
	public int GetProvidableItemIdCount() { }

	// RVA: 0x26A7AB0 Offset: 0x26A7BB1 VA: 0x26A7AB0
	public Result GetProvidableItemIds(ref int outItemIdCount, ref ConsumableServiceItemId[] outItemIdArray) { }

	// RVA: 0x26A7BE0 Offset: 0x26A7CE1 VA: 0x26A7BE0
	public Result GetProvidableItemIds(out ConsumableServiceItemId[] outItemIdArray) { }

	// RVA: 0x26A7C80 Offset: 0x26A7D81 VA: 0x26A7C80
	public Result MarkServiceProvided(ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7D40 Offset: 0x26A7E41 VA: 0x26A7D40
	public Result MarkServiceProvided(ref ulong outSeed, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7E20 Offset: 0x26A7F21 VA: 0x26A7E20 Slot: 4
	public void Dispose() { }

	// RVA: 0x26A7640 Offset: 0x26A7741 VA: 0x26A7640
	private void _Dispose() { }

	// RVA: 0x26A7720 Offset: 0x26A7821 VA: 0x26A7720
	private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user) { }

	// RVA: 0x26A7790 Offset: 0x26A7891 VA: 0x26A7790
	private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user, byte[] buffer, long bufferSize) { }

	// RVA: 0x26A77E0 Offset: 0x26A78E1 VA: 0x26A77E0
	private static extern bool IsInitialized(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7820 Offset: 0x26A7921 VA: 0x26A7820
	private static extern bool CanQueryNewData(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7860 Offset: 0x26A7961 VA: 0x26A7860
	private static extern bool IsConsumptionRequired(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A78A0 Offset: 0x26A79A1 VA: 0x26A78A0
	private static extern bool IsRecoveryRequired(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7900 Offset: 0x26A7A01 VA: 0x26A7900
	private static extern void SetupAsyncGetConsumableRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncGetConsumableRightDataRequest) { }

	// RVA: 0x26A7950 Offset: 0x26A7A51 VA: 0x26A7950
	private static extern void SetupAsyncConsumeRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncConsumeRightDataRequest) { }

	// RVA: 0x26A79A0 Offset: 0x26A7AA1 VA: 0x26A79A0
	private static extern void SetupAsyncRecoverRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncRecoverRightDataRequest) { }

	// RVA: 0x26A79C0 Offset: 0x26A7AC1 VA: 0x26A79C0
	private static extern long GetRequiredBufferSizeToExportSerializedRightData(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A79F0 Offset: 0x26A7AF1 VA: 0x26A79F0
	private static extern long ExportSerializedRightData(IntPtr consumableServiceItemManager, byte[] buffer, long bufferSize) { }

	// RVA: 0x26A7AA0 Offset: 0x26A7BA1 VA: 0x26A7AA0
	private static extern int GetProvidableItemIdCount(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7AE0 Offset: 0x26A7BE1 VA: 0x26A7AE0
	private static extern Result GetProvidableItemIds(IntPtr consumableServiceItemManager, ref int outItemIdCount, [Out] ConsumableServiceItemId[] outItemIdArray, int itemIdArrayCount) { }

	// RVA: 0x26A7CE0 Offset: 0x26A7DE1 VA: 0x26A7CE0
	private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7DB0 Offset: 0x26A7EB1 VA: 0x26A7DB0
	private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ref ulong outSeed, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7560 Offset: 0x26A7661 VA: 0x26A7560
	private static extern void New(ref IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7F10 Offset: 0x26A8011 VA: 0x26A7F10
	private static extern void Delete(IntPtr consumableServiceItemManager, IntPtr workBuffer) { }
}

public sealed class ConsumableServiceItemManager : IDisposable // TypeDefIndex: 11689
{
	// Fields
	private IntPtr _consumableServiceItemManager; // 0x10
	private IntPtr _workMemory; // 0x18
	private bool isDisposed; // 0x20

	// Methods

	// RVA: 0x26A7500 Offset: 0x26A7601 VA: 0x26A7500
	public void .ctor() { }

	// RVA: 0x26A7570 Offset: 0x26A7671 VA: 0x26A7570 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26A76E0 Offset: 0x26A77E1 VA: 0x26A76E0
	public Result Initialize(ShopServiceAccessor accessor, Uid user) { }

	// RVA: 0x26A7740 Offset: 0x26A7841 VA: 0x26A7740
	public Result Initialize(ShopServiceAccessor accessor, Uid user, byte[] buffer) { }

	// RVA: 0x26A77C0 Offset: 0x26A78C1 VA: 0x26A77C0
	public bool IsInitialized() { }

	// RVA: 0x26A7800 Offset: 0x26A7901 VA: 0x26A7800
	public bool CanQueryNewData() { }

	// RVA: 0x26A7840 Offset: 0x26A7941 VA: 0x26A7840
	public bool IsConsumptionRequired() { }

	// RVA: 0x26A7880 Offset: 0x26A7981 VA: 0x26A7880
	public bool IsRecoveryRequired() { }

	// RVA: 0x26A78C0 Offset: 0x26A79C1 VA: 0x26A78C0
	public void SetupAsyncRequest(AsyncGetConsumableRightDataRequest outRequest) { }

	// RVA: 0x26A7910 Offset: 0x26A7A11 VA: 0x26A7910
	public void SetupAsyncRequest(AsyncConsumeRightDataRequest outRequest) { }

	// RVA: 0x26A7960 Offset: 0x26A7A61 VA: 0x26A7960
	public void SetupAsyncRequest(AsyncRecoverRightDataRequest outRequest) { }

	// RVA: 0x26A79B0 Offset: 0x26A7AB1 VA: 0x26A79B0
	public long GetRequiredBufferSizeToExportSerializedRightData() { }

	// RVA: 0x26A79D0 Offset: 0x26A7AD1 VA: 0x26A79D0
	public long ExportSerializedRightData(byte[] buffer) { }

	// RVA: 0x26A7A00 Offset: 0x26A7B01 VA: 0x26A7A00
	public byte[] ExportSerializedRightData() { }

	// RVA: 0x26A7A90 Offset: 0x26A7B91 VA: 0x26A7A90
	public int GetProvidableItemIdCount() { }

	// RVA: 0x26A7AB0 Offset: 0x26A7BB1 VA: 0x26A7AB0
	public Result GetProvidableItemIds(ref int outItemIdCount, ref ConsumableServiceItemId[] outItemIdArray) { }

	// RVA: 0x26A7BE0 Offset: 0x26A7CE1 VA: 0x26A7BE0
	public Result GetProvidableItemIds(out ConsumableServiceItemId[] outItemIdArray) { }

	// RVA: 0x26A7C80 Offset: 0x26A7D81 VA: 0x26A7C80
	public Result MarkServiceProvided(ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7D40 Offset: 0x26A7E41 VA: 0x26A7D40
	public Result MarkServiceProvided(ref ulong outSeed, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7E20 Offset: 0x26A7F21 VA: 0x26A7E20 Slot: 4
	public void Dispose() { }

	// RVA: 0x26A7640 Offset: 0x26A7741 VA: 0x26A7640
	private void _Dispose() { }

	// RVA: 0x26A7720 Offset: 0x26A7821 VA: 0x26A7720
	private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user) { }

	// RVA: 0x26A7790 Offset: 0x26A7891 VA: 0x26A7790
	private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user, byte[] buffer, long bufferSize) { }

	// RVA: 0x26A77E0 Offset: 0x26A78E1 VA: 0x26A77E0
	private static extern bool IsInitialized(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7820 Offset: 0x26A7921 VA: 0x26A7820
	private static extern bool CanQueryNewData(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7860 Offset: 0x26A7961 VA: 0x26A7860
	private static extern bool IsConsumptionRequired(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A78A0 Offset: 0x26A79A1 VA: 0x26A78A0
	private static extern bool IsRecoveryRequired(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7900 Offset: 0x26A7A01 VA: 0x26A7900
	private static extern void SetupAsyncGetConsumableRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncGetConsumableRightDataRequest) { }

	// RVA: 0x26A7950 Offset: 0x26A7A51 VA: 0x26A7950
	private static extern void SetupAsyncConsumeRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncConsumeRightDataRequest) { }

	// RVA: 0x26A79A0 Offset: 0x26A7AA1 VA: 0x26A79A0
	private static extern void SetupAsyncRecoverRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncRecoverRightDataRequest) { }

	// RVA: 0x26A79C0 Offset: 0x26A7AC1 VA: 0x26A79C0
	private static extern long GetRequiredBufferSizeToExportSerializedRightData(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A79F0 Offset: 0x26A7AF1 VA: 0x26A79F0
	private static extern long ExportSerializedRightData(IntPtr consumableServiceItemManager, byte[] buffer, long bufferSize) { }

	// RVA: 0x26A7AA0 Offset: 0x26A7BA1 VA: 0x26A7AA0
	private static extern int GetProvidableItemIdCount(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7AE0 Offset: 0x26A7BE1 VA: 0x26A7AE0
	private static extern Result GetProvidableItemIds(IntPtr consumableServiceItemManager, ref int outItemIdCount, [Out] ConsumableServiceItemId[] outItemIdArray, int itemIdArrayCount) { }

	// RVA: 0x26A7CE0 Offset: 0x26A7DE1 VA: 0x26A7CE0
	private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7DB0 Offset: 0x26A7EB1 VA: 0x26A7DB0
	private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ref ulong outSeed, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7560 Offset: 0x26A7661 VA: 0x26A7560
	private static extern void New(ref IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7F10 Offset: 0x26A8011 VA: 0x26A7F10
	private static extern void Delete(IntPtr consumableServiceItemManager, IntPtr workBuffer) { }
}

public sealed class ConsumableServiceItemManager : IDisposable // TypeDefIndex: 11689
{
	// Fields
	private IntPtr _consumableServiceItemManager; // 0x10
	private IntPtr _workMemory; // 0x18
	private bool isDisposed; // 0x20

	// Methods

	// RVA: 0x26A7500 Offset: 0x26A7601 VA: 0x26A7500
	public void .ctor() { }

	// RVA: 0x26A7570 Offset: 0x26A7671 VA: 0x26A7570 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26A76E0 Offset: 0x26A77E1 VA: 0x26A76E0
	public Result Initialize(ShopServiceAccessor accessor, Uid user) { }

	// RVA: 0x26A7740 Offset: 0x26A7841 VA: 0x26A7740
	public Result Initialize(ShopServiceAccessor accessor, Uid user, byte[] buffer) { }

	// RVA: 0x26A77C0 Offset: 0x26A78C1 VA: 0x26A77C0
	public bool IsInitialized() { }

	// RVA: 0x26A7800 Offset: 0x26A7901 VA: 0x26A7800
	public bool CanQueryNewData() { }

	// RVA: 0x26A7840 Offset: 0x26A7941 VA: 0x26A7840
	public bool IsConsumptionRequired() { }

	// RVA: 0x26A7880 Offset: 0x26A7981 VA: 0x26A7880
	public bool IsRecoveryRequired() { }

	// RVA: 0x26A78C0 Offset: 0x26A79C1 VA: 0x26A78C0
	public void SetupAsyncRequest(AsyncGetConsumableRightDataRequest outRequest) { }

	// RVA: 0x26A7910 Offset: 0x26A7A11 VA: 0x26A7910
	public void SetupAsyncRequest(AsyncConsumeRightDataRequest outRequest) { }

	// RVA: 0x26A7960 Offset: 0x26A7A61 VA: 0x26A7960
	public void SetupAsyncRequest(AsyncRecoverRightDataRequest outRequest) { }

	// RVA: 0x26A79B0 Offset: 0x26A7AB1 VA: 0x26A79B0
	public long GetRequiredBufferSizeToExportSerializedRightData() { }

	// RVA: 0x26A79D0 Offset: 0x26A7AD1 VA: 0x26A79D0
	public long ExportSerializedRightData(byte[] buffer) { }

	// RVA: 0x26A7A00 Offset: 0x26A7B01 VA: 0x26A7A00
	public byte[] ExportSerializedRightData() { }

	// RVA: 0x26A7A90 Offset: 0x26A7B91 VA: 0x26A7A90
	public int GetProvidableItemIdCount() { }

	// RVA: 0x26A7AB0 Offset: 0x26A7BB1 VA: 0x26A7AB0
	public Result GetProvidableItemIds(ref int outItemIdCount, ref ConsumableServiceItemId[] outItemIdArray) { }

	// RVA: 0x26A7BE0 Offset: 0x26A7CE1 VA: 0x26A7BE0
	public Result GetProvidableItemIds(out ConsumableServiceItemId[] outItemIdArray) { }

	// RVA: 0x26A7C80 Offset: 0x26A7D81 VA: 0x26A7C80
	public Result MarkServiceProvided(ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7D40 Offset: 0x26A7E41 VA: 0x26A7D40
	public Result MarkServiceProvided(ref ulong outSeed, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7E20 Offset: 0x26A7F21 VA: 0x26A7E20 Slot: 4
	public void Dispose() { }

	// RVA: 0x26A7640 Offset: 0x26A7741 VA: 0x26A7640
	private void _Dispose() { }

	// RVA: 0x26A7720 Offset: 0x26A7821 VA: 0x26A7720
	private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user) { }

	// RVA: 0x26A7790 Offset: 0x26A7891 VA: 0x26A7790
	private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user, byte[] buffer, long bufferSize) { }

	// RVA: 0x26A77E0 Offset: 0x26A78E1 VA: 0x26A77E0
	private static extern bool IsInitialized(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7820 Offset: 0x26A7921 VA: 0x26A7820
	private static extern bool CanQueryNewData(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7860 Offset: 0x26A7961 VA: 0x26A7860
	private static extern bool IsConsumptionRequired(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A78A0 Offset: 0x26A79A1 VA: 0x26A78A0
	private static extern bool IsRecoveryRequired(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7900 Offset: 0x26A7A01 VA: 0x26A7900
	private static extern void SetupAsyncGetConsumableRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncGetConsumableRightDataRequest) { }

	// RVA: 0x26A7950 Offset: 0x26A7A51 VA: 0x26A7950
	private static extern void SetupAsyncConsumeRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncConsumeRightDataRequest) { }

	// RVA: 0x26A79A0 Offset: 0x26A7AA1 VA: 0x26A79A0
	private static extern void SetupAsyncRecoverRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncRecoverRightDataRequest) { }

	// RVA: 0x26A79C0 Offset: 0x26A7AC1 VA: 0x26A79C0
	private static extern long GetRequiredBufferSizeToExportSerializedRightData(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A79F0 Offset: 0x26A7AF1 VA: 0x26A79F0
	private static extern long ExportSerializedRightData(IntPtr consumableServiceItemManager, byte[] buffer, long bufferSize) { }

	// RVA: 0x26A7AA0 Offset: 0x26A7BA1 VA: 0x26A7AA0
	private static extern int GetProvidableItemIdCount(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7AE0 Offset: 0x26A7BE1 VA: 0x26A7AE0
	private static extern Result GetProvidableItemIds(IntPtr consumableServiceItemManager, ref int outItemIdCount, [Out] ConsumableServiceItemId[] outItemIdArray, int itemIdArrayCount) { }

	// RVA: 0x26A7CE0 Offset: 0x26A7DE1 VA: 0x26A7CE0
	private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7DB0 Offset: 0x26A7EB1 VA: 0x26A7DB0
	private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ref ulong outSeed, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7560 Offset: 0x26A7661 VA: 0x26A7560
	private static extern void New(ref IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7F10 Offset: 0x26A8011 VA: 0x26A7F10
	private static extern void Delete(IntPtr consumableServiceItemManager, IntPtr workBuffer) { }
}

public sealed class ConsumableServiceItemManager : IDisposable // TypeDefIndex: 11689
{
	// Fields
	private IntPtr _consumableServiceItemManager; // 0x10
	private IntPtr _workMemory; // 0x18
	private bool isDisposed; // 0x20

	// Methods

	// RVA: 0x26A7500 Offset: 0x26A7601 VA: 0x26A7500
	public void .ctor() { }

	// RVA: 0x26A7570 Offset: 0x26A7671 VA: 0x26A7570 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26A76E0 Offset: 0x26A77E1 VA: 0x26A76E0
	public Result Initialize(ShopServiceAccessor accessor, Uid user) { }

	// RVA: 0x26A7740 Offset: 0x26A7841 VA: 0x26A7740
	public Result Initialize(ShopServiceAccessor accessor, Uid user, byte[] buffer) { }

	// RVA: 0x26A77C0 Offset: 0x26A78C1 VA: 0x26A77C0
	public bool IsInitialized() { }

	// RVA: 0x26A7800 Offset: 0x26A7901 VA: 0x26A7800
	public bool CanQueryNewData() { }

	// RVA: 0x26A7840 Offset: 0x26A7941 VA: 0x26A7840
	public bool IsConsumptionRequired() { }

	// RVA: 0x26A7880 Offset: 0x26A7981 VA: 0x26A7880
	public bool IsRecoveryRequired() { }

	// RVA: 0x26A78C0 Offset: 0x26A79C1 VA: 0x26A78C0
	public void SetupAsyncRequest(AsyncGetConsumableRightDataRequest outRequest) { }

	// RVA: 0x26A7910 Offset: 0x26A7A11 VA: 0x26A7910
	public void SetupAsyncRequest(AsyncConsumeRightDataRequest outRequest) { }

	// RVA: 0x26A7960 Offset: 0x26A7A61 VA: 0x26A7960
	public void SetupAsyncRequest(AsyncRecoverRightDataRequest outRequest) { }

	// RVA: 0x26A79B0 Offset: 0x26A7AB1 VA: 0x26A79B0
	public long GetRequiredBufferSizeToExportSerializedRightData() { }

	// RVA: 0x26A79D0 Offset: 0x26A7AD1 VA: 0x26A79D0
	public long ExportSerializedRightData(byte[] buffer) { }

	// RVA: 0x26A7A00 Offset: 0x26A7B01 VA: 0x26A7A00
	public byte[] ExportSerializedRightData() { }

	// RVA: 0x26A7A90 Offset: 0x26A7B91 VA: 0x26A7A90
	public int GetProvidableItemIdCount() { }

	// RVA: 0x26A7AB0 Offset: 0x26A7BB1 VA: 0x26A7AB0
	public Result GetProvidableItemIds(ref int outItemIdCount, ref ConsumableServiceItemId[] outItemIdArray) { }

	// RVA: 0x26A7BE0 Offset: 0x26A7CE1 VA: 0x26A7BE0
	public Result GetProvidableItemIds(out ConsumableServiceItemId[] outItemIdArray) { }

	// RVA: 0x26A7C80 Offset: 0x26A7D81 VA: 0x26A7C80
	public Result MarkServiceProvided(ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7D40 Offset: 0x26A7E41 VA: 0x26A7D40
	public Result MarkServiceProvided(ref ulong outSeed, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7E20 Offset: 0x26A7F21 VA: 0x26A7E20 Slot: 4
	public void Dispose() { }

	// RVA: 0x26A7640 Offset: 0x26A7741 VA: 0x26A7640
	private void _Dispose() { }

	// RVA: 0x26A7720 Offset: 0x26A7821 VA: 0x26A7720
	private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user) { }

	// RVA: 0x26A7790 Offset: 0x26A7891 VA: 0x26A7790
	private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user, byte[] buffer, long bufferSize) { }

	// RVA: 0x26A77E0 Offset: 0x26A78E1 VA: 0x26A77E0
	private static extern bool IsInitialized(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7820 Offset: 0x26A7921 VA: 0x26A7820
	private static extern bool CanQueryNewData(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7860 Offset: 0x26A7961 VA: 0x26A7860
	private static extern bool IsConsumptionRequired(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A78A0 Offset: 0x26A79A1 VA: 0x26A78A0
	private static extern bool IsRecoveryRequired(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7900 Offset: 0x26A7A01 VA: 0x26A7900
	private static extern void SetupAsyncGetConsumableRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncGetConsumableRightDataRequest) { }

	// RVA: 0x26A7950 Offset: 0x26A7A51 VA: 0x26A7950
	private static extern void SetupAsyncConsumeRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncConsumeRightDataRequest) { }

	// RVA: 0x26A79A0 Offset: 0x26A7AA1 VA: 0x26A79A0
	private static extern void SetupAsyncRecoverRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncRecoverRightDataRequest) { }

	// RVA: 0x26A79C0 Offset: 0x26A7AC1 VA: 0x26A79C0
	private static extern long GetRequiredBufferSizeToExportSerializedRightData(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A79F0 Offset: 0x26A7AF1 VA: 0x26A79F0
	private static extern long ExportSerializedRightData(IntPtr consumableServiceItemManager, byte[] buffer, long bufferSize) { }

	// RVA: 0x26A7AA0 Offset: 0x26A7BA1 VA: 0x26A7AA0
	private static extern int GetProvidableItemIdCount(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7AE0 Offset: 0x26A7BE1 VA: 0x26A7AE0
	private static extern Result GetProvidableItemIds(IntPtr consumableServiceItemManager, ref int outItemIdCount, [Out] ConsumableServiceItemId[] outItemIdArray, int itemIdArrayCount) { }

	// RVA: 0x26A7CE0 Offset: 0x26A7DE1 VA: 0x26A7CE0
	private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7DB0 Offset: 0x26A7EB1 VA: 0x26A7DB0
	private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ref ulong outSeed, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7560 Offset: 0x26A7661 VA: 0x26A7560
	private static extern void New(ref IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7F10 Offset: 0x26A8011 VA: 0x26A7F10
	private static extern void Delete(IntPtr consumableServiceItemManager, IntPtr workBuffer) { }
}

public sealed class ConsumableServiceItemManager : IDisposable // TypeDefIndex: 11689
{
	// Fields
	private IntPtr _consumableServiceItemManager; // 0x10
	private IntPtr _workMemory; // 0x18
	private bool isDisposed; // 0x20

	// Methods

	// RVA: 0x26A7500 Offset: 0x26A7601 VA: 0x26A7500
	public void .ctor() { }

	// RVA: 0x26A7570 Offset: 0x26A7671 VA: 0x26A7570 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26A76E0 Offset: 0x26A77E1 VA: 0x26A76E0
	public Result Initialize(ShopServiceAccessor accessor, Uid user) { }

	// RVA: 0x26A7740 Offset: 0x26A7841 VA: 0x26A7740
	public Result Initialize(ShopServiceAccessor accessor, Uid user, byte[] buffer) { }

	// RVA: 0x26A77C0 Offset: 0x26A78C1 VA: 0x26A77C0
	public bool IsInitialized() { }

	// RVA: 0x26A7800 Offset: 0x26A7901 VA: 0x26A7800
	public bool CanQueryNewData() { }

	// RVA: 0x26A7840 Offset: 0x26A7941 VA: 0x26A7840
	public bool IsConsumptionRequired() { }

	// RVA: 0x26A7880 Offset: 0x26A7981 VA: 0x26A7880
	public bool IsRecoveryRequired() { }

	// RVA: 0x26A78C0 Offset: 0x26A79C1 VA: 0x26A78C0
	public void SetupAsyncRequest(AsyncGetConsumableRightDataRequest outRequest) { }

	// RVA: 0x26A7910 Offset: 0x26A7A11 VA: 0x26A7910
	public void SetupAsyncRequest(AsyncConsumeRightDataRequest outRequest) { }

	// RVA: 0x26A7960 Offset: 0x26A7A61 VA: 0x26A7960
	public void SetupAsyncRequest(AsyncRecoverRightDataRequest outRequest) { }

	// RVA: 0x26A79B0 Offset: 0x26A7AB1 VA: 0x26A79B0
	public long GetRequiredBufferSizeToExportSerializedRightData() { }

	// RVA: 0x26A79D0 Offset: 0x26A7AD1 VA: 0x26A79D0
	public long ExportSerializedRightData(byte[] buffer) { }

	// RVA: 0x26A7A00 Offset: 0x26A7B01 VA: 0x26A7A00
	public byte[] ExportSerializedRightData() { }

	// RVA: 0x26A7A90 Offset: 0x26A7B91 VA: 0x26A7A90
	public int GetProvidableItemIdCount() { }

	// RVA: 0x26A7AB0 Offset: 0x26A7BB1 VA: 0x26A7AB0
	public Result GetProvidableItemIds(ref int outItemIdCount, ref ConsumableServiceItemId[] outItemIdArray) { }

	// RVA: 0x26A7BE0 Offset: 0x26A7CE1 VA: 0x26A7BE0
	public Result GetProvidableItemIds(out ConsumableServiceItemId[] outItemIdArray) { }

	// RVA: 0x26A7C80 Offset: 0x26A7D81 VA: 0x26A7C80
	public Result MarkServiceProvided(ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7D40 Offset: 0x26A7E41 VA: 0x26A7D40
	public Result MarkServiceProvided(ref ulong outSeed, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7E20 Offset: 0x26A7F21 VA: 0x26A7E20 Slot: 4
	public void Dispose() { }

	// RVA: 0x26A7640 Offset: 0x26A7741 VA: 0x26A7640
	private void _Dispose() { }

	// RVA: 0x26A7720 Offset: 0x26A7821 VA: 0x26A7720
	private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user) { }

	// RVA: 0x26A7790 Offset: 0x26A7891 VA: 0x26A7790
	private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user, byte[] buffer, long bufferSize) { }

	// RVA: 0x26A77E0 Offset: 0x26A78E1 VA: 0x26A77E0
	private static extern bool IsInitialized(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7820 Offset: 0x26A7921 VA: 0x26A7820
	private static extern bool CanQueryNewData(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7860 Offset: 0x26A7961 VA: 0x26A7860
	private static extern bool IsConsumptionRequired(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A78A0 Offset: 0x26A79A1 VA: 0x26A78A0
	private static extern bool IsRecoveryRequired(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7900 Offset: 0x26A7A01 VA: 0x26A7900
	private static extern void SetupAsyncGetConsumableRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncGetConsumableRightDataRequest) { }

	// RVA: 0x26A7950 Offset: 0x26A7A51 VA: 0x26A7950
	private static extern void SetupAsyncConsumeRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncConsumeRightDataRequest) { }

	// RVA: 0x26A79A0 Offset: 0x26A7AA1 VA: 0x26A79A0
	private static extern void SetupAsyncRecoverRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncRecoverRightDataRequest) { }

	// RVA: 0x26A79C0 Offset: 0x26A7AC1 VA: 0x26A79C0
	private static extern long GetRequiredBufferSizeToExportSerializedRightData(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A79F0 Offset: 0x26A7AF1 VA: 0x26A79F0
	private static extern long ExportSerializedRightData(IntPtr consumableServiceItemManager, byte[] buffer, long bufferSize) { }

	// RVA: 0x26A7AA0 Offset: 0x26A7BA1 VA: 0x26A7AA0
	private static extern int GetProvidableItemIdCount(IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7AE0 Offset: 0x26A7BE1 VA: 0x26A7AE0
	private static extern Result GetProvidableItemIds(IntPtr consumableServiceItemManager, ref int outItemIdCount, [Out] ConsumableServiceItemId[] outItemIdArray, int itemIdArrayCount) { }

	// RVA: 0x26A7CE0 Offset: 0x26A7DE1 VA: 0x26A7CE0
	private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7DB0 Offset: 0x26A7EB1 VA: 0x26A7DB0
	private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ref ulong outSeed, ConsumableServiceItemId itemId) { }

	// RVA: 0x26A7560 Offset: 0x26A7661 VA: 0x26A7560
	private static extern void New(ref IntPtr consumableServiceItemManager) { }

	// RVA: 0x26A7F10 Offset: 0x26A8011 VA: 0x26A7F10
	private static extern void Delete(IntPtr consumableServiceItemManager, IntPtr workBuffer) { }
}

